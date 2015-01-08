using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Diagnostics;

namespace Khr1Test
{
    public class Rcb1
    {
        #region Data members
        private enum Command : byte
        {
            SetPosition     = 0xfd,
            GetPosition     = 0xfc,
            SetPose         = 0xf9,
            PlayMotion      = 0xef,
            SetPoseCount    = 0xf7,
            GetPoseCount    = 0xf6,
            SetHomePosition = 0xfb,
            GetHomePosition = 0xfa,
        }

        // [ TX ]
        // CMD    ID  CHKSUM
        //  1      2    3
        private byte[] txGetPosition = new byte[3];

        // [ RX ]
        // ID    CH1 … CH12 CHKSUM
        //  0     1     12    13
        private byte[] rxGetPosition = new byte[14];

        //[ TX ]
        // CMD  ID  SPD  CH1 ... CH12  CHKSUM
        //  1    2   3    4       15     16
        public byte[] txSetPosition = new byte[16];

        // [ RX ]
        // ID    ACK
        //  1     2
        byte[] rxSetPosition = new byte[2];

        // [ TX ]
        // CMD   ID  MOTION# POS# SPD CH1 … CH12 CHKSUM
        //  1     2     3     4    5   6     17    18
        byte[] txSetPose = new byte[18];

        // [ RX ]
        // ID    ACK
        //  1     2
        byte[] rxSetPose = new byte[2];

        // [ TX ]
        // CMD   ID  MOTION   CHKSUM
        // 1     2   3        4
        byte[] txPlayMotion = new byte[4];

        // [ RX ]	
        // ID    ACK
        //  1     2
        byte[] rxPlayMotion = new byte[2];

        // [ TX ]
        // CMD    ID   MOTION#   COUNT CHKSUM
        //  1      2      3        4     5
        byte[] txSetPoseCount = new byte[5];

        // [ RX ]
        // ID   ACK
        //  1    2     
        byte[] rxSetPoseCount = new byte[2];

        // [ TX ]
        // CMD    ID   MOTION#   CHKSUM
        //  1      2      3         4
        byte[] txGetPoseCount = new byte[4];

        // [ RX ]
        // ID    COUNT   CHKSUM
        //  1      2        3       
        byte[] rxGetPoseCount = new byte[3];

        // [ TX ]
        // CMD   ID  CHKSUM
        //  1     2     3
        byte[] txSetHomePosition = new byte[3];

        // [ RX ]
        // ID    ACK
        //  1     2
        byte[] rxSetHomePosition = new byte[2];  
   
        private Khr1 khr1;
        private SerialPort serialPort;
        
        public  const int TotalMotions      = 40;
        public  const int TotalPositions    = 100;
        private const int SpeedIndex        = 2;
        private const int TorsoOffset       = 2;
        private const byte Acknowledgement  = 0x06;
        #endregion

        public Rcb1(Khr1 khr1, SerialPort serialPort)
        {
            this.khr1 = khr1;
            this.serialPort = serialPort;
        }

        public bool SetServoPosition(Servo servo)
        {
            txSetPosition[0] = (byte)Command.SetPosition;
            txSetPosition[1] = (byte)servo.BoardId;
            txSetPosition[2] = servo.Speed;

            for (int i = 3; i < txSetPosition.Length - 1; ++i)
                txSetPosition[i] = 255;

            if (servo.BoardId == BoardId.Zero)
                txSetPosition[servo.Index + Rcb1.TorsoOffset] = servo.Degree;
            else
                txSetPosition[servo.Index] = servo.Degree;

            // calculate checksum
            int total = 0;
            for (int i = 0; i < txSetPosition.Length - 1; ++i)
                total += txSetPosition[i];

            txSetPosition[txSetPosition.Length - 1] = (byte)(total & 0x7f);

            int tryCount = 0;

        Retry:

            ++tryCount;
            if (tryCount > 10)
            {
                Trace.WriteLine("Failure to set servo position.");
                return false;
            }

            this.serialPort.Write(txSetPosition, 0, txSetPosition.Length);
            this.serialPort.BaseStream.Flush();

            try
            {
                rxSetPosition[0] = (byte)this.serialPort.ReadByte();
                rxSetPosition[1] = (byte)this.serialPort.ReadByte();
            }
            catch(Exception e)
            {
                Trace.WriteLine(e.Message);
                goto Retry;
            }

            if (rxSetPosition[1] == Rcb1.Acknowledgement)
            {
                Trace.WriteLine("Success setting servo position.");
                return true;
            }
            else
                goto Retry;
        }

        public byte GetPosition(Servo servo)
        {
            txGetPosition[0] = (byte)Command.GetPosition;
            txGetPosition[1] = (byte)servo.BoardId;
            txGetPosition[2] = (byte)((txGetPosition[0] + txGetPosition[1]) & 0x7f);

            int tryCount = 0;

        Retry:

            this.serialPort.Write(txGetPosition, 0, txGetPosition.Length);
            this.serialPort.BaseStream.Flush();

            ++tryCount;
            if (tryCount > 10)
            {
                Trace.WriteLine("Failure to get servo position.");
                return 255;
            }

            try
            {
                for (int i = 0; i < rxGetPosition.Length; ++i)
                    rxGetPosition[i] = (byte)this.serialPort.ReadByte();
            }
            catch(Exception e)
            {
                Trace.WriteLine(e.Message);
                goto Retry;
            }

            // check for null (all values returned are zero)
            int total = 0;
            for (int i = 0; i < rxGetPosition.Length - 1; ++i)
                total += rxGetPosition[i];

            if (total == 0)
                goto Retry;

            // calculate checksum
            if (rxGetPosition[13] != (byte)(total & 0x7f))
                goto Retry;

            Trace.WriteLine("Success getting servo position.");

            if (servo.BoardId == BoardId.One)
                return rxGetPosition[servo.Index - Rcb1.TorsoOffset];
            else
                return rxGetPosition[servo.Index];
        }

        public bool SetPose(BoardId boardId,
                            int positionNumber,
                            int motionNumber,
                            int relativeSpeed)
        {
            txSetPose[0] = (byte)Command.SetPose;
            txSetPose[1] = (byte)boardId;
            txSetPose[2] = (byte)motionNumber;          // 1 of 40
            txSetPose[3] = (byte)positionNumber;        // 1 of 100
            txSetPose[4] = (byte)relativeSpeed;         // between positions

            if (boardId == BoardId.Zero)
            {
                txSetPose[5] = khr1.LeftShoulder.Degree;    // ch 1
                txSetPose[6] = khr1.LeftBicep.Degree;       // ch 2
                txSetPose[7] = khr1.LeftForearm.Degree;     // ch 3
                txSetPose[8] = 255;                         // ch 4
                txSetPose[9] = 255;                         // ch 5
                txSetPose[10] = khr1.Head.Degree;           // ch 6
                txSetPose[11] = khr1.RightShoulder.Degree;  // ch 7
                txSetPose[12] = khr1.RightBicep.Degree;     // ch 8
                txSetPose[13] = khr1.RightForearm.Degree;   // ch 9
                txSetPose[14] = 255;                        // ch 10
                txSetPose[15] = 255;                        // ch 11
                txSetPose[16] = 255;                        // ch 12
            }
            else if (boardId == BoardId.One)
            {
                txSetPose[5] = khr1.LeftHip.Degree;
                txSetPose[6] = khr1.LeftUpperThigh.Degree;
                txSetPose[7] = khr1.LeftLowerThigh.Degree;
                txSetPose[8] = khr1.LeftShin.Degree;
                txSetPose[9] = khr1.LeftFoot.Degree;
                txSetPose[10] = 255;
                txSetPose[11] = khr1.RightHip.Degree;
                txSetPose[12] = khr1.RightUpperThigh.Degree;
                txSetPose[13] = khr1.RightLowerThigh.Degree;
                txSetPose[14] = khr1.RightShin.Degree;
                txSetPose[15] = khr1.RightFoot.Degree;
                txSetPose[16] = 255;
            }

            // calculate checksum
            int total = 0;
            for (int i = 0; i < txSetPose.Length - 1; ++i)
                total += txSetPose[i];

            txSetPose[17] = (byte)(total & 0x7f);

            int tryCount = 0;

        Retry:
            
            ++tryCount;
            if (tryCount > 10)
            {
                Trace.WriteLine("Failure to set pose.");
                return false;
            }

            this.serialPort.Write(txSetPose, 0, txSetPose.Length);
            this.serialPort.BaseStream.Flush();

            try
            {
                rxSetPose[0] = (byte)this.serialPort.ReadByte();
                rxSetPose[1] = (byte)this.serialPort.ReadByte();
            }
            catch(Exception e)
            {
                Trace.WriteLine(e.Message);
                goto Retry;
            }

            if (rxSetPose[1] == Rcb1.Acknowledgement)
            {
                Trace.WriteLine("Success setting pose.");
                return true;
            }
            else
                goto Retry;
        }

        public bool SetPoseCount(BoardId boardId, int motionNumber, int count)
        {
            txSetPoseCount[0] = (byte)Command.SetPoseCount;
            txSetPoseCount[1] = (byte)boardId;
            txSetPoseCount[2] = (byte)motionNumber;
            txSetPoseCount[3] = (byte)count;

            // checksum
            txSetPoseCount[4] = (byte)((txSetPoseCount[0] + txSetPoseCount[1] +
                                        txSetPoseCount[2] + txSetPoseCount[3]) & 0x7f);

            int tryCount = 0;

        Retry:

            ++tryCount;
            if (tryCount > 10)
            {
                Trace.WriteLine("Failure setting pose count.");
                return false;
            }

            this.serialPort.Write(txSetPoseCount, 0, txSetPoseCount.Length);
            this.serialPort.BaseStream.Flush();

            try
            {
                rxSetPoseCount[0] = (byte)this.serialPort.ReadByte();
                rxSetPoseCount[1] = (byte)this.serialPort.ReadByte();
            }
            catch(Exception e)
            {
                Trace.WriteLine(e.Message);
                goto Retry;
            }

            if (rxSetPoseCount[1] == Rcb1.Acknowledgement)
            {
                Trace.WriteLine("Success setting pose count.");
                return true;
            }
            else
                goto Retry;
        }

        public byte GetPoseCount(BoardId boardId, int motionNumber)
        {
            txGetPoseCount[0] = (byte)Command.GetPoseCount;
            txGetPoseCount[1] = (byte)boardId;
            txGetPoseCount[2] = (byte)motionNumber;
            txGetPoseCount[3] = (byte)((txGetPoseCount[0] + txGetPoseCount[1] +
                                 txGetPoseCount[2]) & 0x7f);

            int tryCount = 0;

        Retry:

            ++tryCount;
            if (tryCount > 10)
            {
                Trace.WriteLine("Failure getting pose count.");
                return 0;
            }

            this.serialPort.Write(txGetPoseCount, 0, txGetPoseCount.Length);
            this.serialPort.BaseStream.Flush();

            try
            {
                rxGetPoseCount[0] = (byte)this.serialPort.ReadByte();
                rxGetPoseCount[1] = (byte)this.serialPort.ReadByte();
                rxGetPoseCount[2] = (byte)this.serialPort.ReadByte();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                goto Retry;
            }

            if (rxGetPoseCount[2] == (byte)((rxGetPoseCount[0] + rxGetPoseCount[1]) & 0x7f))
            {
                Trace.WriteLine("Success getting pose count.");
                return rxGetPoseCount[1];
            }
            else
                goto Retry;
        }

        public bool PlayMotion(BoardId boardId, int motionNumber)
        {
            // check pose count
            if (GetPoseCount(boardId, motionNumber) == 0)
            {
                Trace.WriteLine("Failure to play motion becasue pose count is not set.");
                return false;
            }

            txPlayMotion[0] = (byte)Command.PlayMotion;
            txPlayMotion[1] = (byte)boardId;
            txPlayMotion[2] = (byte)motionNumber;        // 1 of 40
            
            // checksum
            txPlayMotion[3] = (byte)((txPlayMotion[0] + txPlayMotion[1] + txPlayMotion[2]) & 0x7f);

            int tryCount = 0;

        Retry:

            ++tryCount;
            if (tryCount > 10)
            {
                Trace.WriteLine("Failure to play motion.");
                return false;
            }

            this.serialPort.Write(txPlayMotion, 0, txPlayMotion.Length);
            this.serialPort.BaseStream.Flush();

            try
            {
                rxPlayMotion[0] = (byte)this.serialPort.ReadByte();
                rxPlayMotion[1] = (byte)this.serialPort.ReadByte();
            }
            catch(Exception e)
            {
                Trace.WriteLine(e.Message);
                goto Retry;
            }

            if (rxPlayMotion[1] == Rcb1.Acknowledgement)
            {
                Trace.WriteLine("Success playing motion.");
                return true;
            }
            else
                goto Retry;
        }

        public bool SetHomePosition()
        {
            // set upper torso
            txSetHomePosition[0] = (byte)Command.SetHomePosition;
            txSetHomePosition[1] = (byte)BoardId.Zero;
            txSetHomePosition[2] = (byte)((txSetHomePosition[0] + txSetHomePosition[1]) & 0x7f);

            int tryCount = 0;

        RetryUpperTorso:

            ++tryCount;
            if (tryCount > 10)
            {
                Trace.WriteLine("Failure to set home position for uppert torso.");
                return false;
            }

            this.serialPort.Write(txSetHomePosition, 0, txSetHomePosition.Length);
            this.serialPort.BaseStream.Flush();

            try
            {
                rxSetHomePosition[0] = (byte)this.serialPort.ReadByte();
                rxSetHomePosition[1] = (byte)this.serialPort.ReadByte();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                goto RetryUpperTorso;
            }

            if (rxSetHomePosition[1] == Rcb1.Acknowledgement)
                Trace.WriteLine("Success setting home position for upper torso.");
            else
                goto RetryUpperTorso;

            // set lower torso
            txSetHomePosition[0] = (byte)Command.SetHomePosition;
            txSetHomePosition[1] = (byte)BoardId.One;
            txSetHomePosition[2] = (byte)((txSetHomePosition[0] + txSetHomePosition[1]) & 0x7f);

            tryCount = 0;

        RetryLowerTorso:

            ++tryCount;
            if (tryCount > 10)
            {
                Trace.WriteLine("Failure to set home position for lower torso.");
                return false;
            }

            this.serialPort.Write(txSetHomePosition, 0, txSetHomePosition.Length);
            this.serialPort.BaseStream.Flush();

            try
            {
                rxSetHomePosition[0] = (byte)this.serialPort.ReadByte();
                rxSetHomePosition[1] = (byte)this.serialPort.ReadByte();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                goto RetryLowerTorso;
            }

            if (rxSetHomePosition[1] == Rcb1.Acknowledgement)
            {
                Trace.WriteLine("Success setting home position for lower torso.");
                return true;
            }
            else
                goto RetryLowerTorso;
        }
    }

}