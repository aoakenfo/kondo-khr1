using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Khr1Test
{
    public abstract class Servo
    {
        #region Data members
        Rcb1 rcb1;

        public const byte SlowestSpeed = 7;
        public const byte FastestSpeed = 0;
        public const byte MinDegree = 0;
        public const byte MaxDegree = 180;

        private BoardId boardId;
        private byte degree;
        private byte speed;        
        private byte index;
        #endregion

        public BoardId BoardId
        {
            get { return this.boardId; }
        }

        public byte Degree
        {
            get { return degree; }
            set
            {
                if (degree >= Servo.MinDegree && degree <= Servo.MaxDegree)
                {
                    byte previousDegree = degree;
                    degree = value;

                    if (!rcb1.SetServoPosition(this))
                    {
                        degree = previousDegree;
                        Trace.WriteLine("WARNING: Failure to set servo position.");
                    }
                    else
                    {
                        Trace.WriteLine("MESSAGE: Successfully set servo position.");
                    }
                }
                else
                    Trace.WriteLine("WARNING: Degree value is beyond 0-180 range.");
            }
        }

        public byte Speed
        {
            get { return this.speed; }
            set
            {
                if (value >= Servo.FastestSpeed && value <= Servo.SlowestSpeed)
                    this.speed = value;
                else
                    Trace.WriteLine("WARNING: Speed value beyond 0-7 range.");
            }
        }

        public byte Index
        {
            get { return this.index; }
        }

        public Servo(Rcb1 rcb1, BoardId boardId, byte index)
        {
            this.rcb1    = rcb1;
            this.boardId = boardId;
            this.index   = index;
            this.speed   = 3;

            this.degree = rcb1.GetPosition(this);

            if (degree == 255)
                throw new Exception();
        }
    }

    #region Upper torso servos
    public class LeftForearm : Servo
    {
        public LeftForearm(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.Zero, (byte)UpperTorso.LeftForearm)
        {

        }
    }

    public class LeftBicep : Servo
    {
        public LeftBicep(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.Zero, (byte)UpperTorso.LeftBicep)
        {

        }
    }

    public class LeftShoulder : Servo
    {
        public LeftShoulder(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.Zero, (byte)UpperTorso.LeftShoulder)
        {

        }
    }

    public class Head : Servo
    {
        public Head(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.Zero, (byte)UpperTorso.Head)
        {

        }
    }

    public class RightShoulder : Servo
    {
        public RightShoulder(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.Zero, (byte)UpperTorso.RightShoulder)
        {

        }
    }

    public class RightBicep : Servo
    {
        public RightBicep(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.Zero, (byte)UpperTorso.RightBicep)
        {

        }
    }

    public class RightForearm : Servo
    {
        public RightForearm(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.Zero, (byte)UpperTorso.RightForearm)
        {

        }
    }
    #endregion

    #region Lower torso servos
    public class LeftHip : Servo
    {
        public LeftHip(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.One, (byte)LowerTorso.LeftHip)
        {

        }
    }

    public class LeftUpperThigh : Servo
    {
        public LeftUpperThigh(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.One, (byte)LowerTorso.LeftUpperThigh)
        {

        }
    }

    public class LeftLowerThigh : Servo
    {
        public LeftLowerThigh(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.One, (byte)LowerTorso.LeftLowerThigh)
        {

        }
    }

    public class LeftShin : Servo
    {
        public LeftShin(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.One, (byte)LowerTorso.LeftShin)
        {

        }
    }

    public class LeftFoot : Servo
    {
        public LeftFoot(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.One, (byte)LowerTorso.LeftFoot)
        {

        }
    }

    public class RightHip : Servo
    {
        public RightHip(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.One, (byte)LowerTorso.RightHip)
        {

        }
    }

    public class RightUpperThigh : Servo
    {
        public RightUpperThigh(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.One, (byte)LowerTorso.RightUpperThigh)
        {

        }
    }

    public class RightLowerThigh : Servo
    {
        public RightLowerThigh(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.One, (byte)LowerTorso.RightLowerThigh)
        {

        }
    }

    public class RightShin : Servo
    {
        public RightShin(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.One, (byte)LowerTorso.RightShin)
        {

        }
    }

    public class RightFoot : Servo
    {
        public RightFoot(Rcb1 circuitBoard)
            : base(circuitBoard, BoardId.One, (byte)LowerTorso.RightFoot)
        {

        }
    }
    #endregion
}
