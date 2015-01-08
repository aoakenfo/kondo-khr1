using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace Khr1Test
{
    public class Khr1
    {
        #region Data members
        private Rcb1 rcb1;

        // upper torso
        private Servo leftForearm;
        private Servo leftBicep;
        private Servo leftShoulder;
        private Servo head;
        private Servo rightShoulder;
        private Servo rightBicep;
        private Servo rightForearm;

        // lower torso
        private Servo leftHip;
        private Servo leftUpperThigh;
        private Servo leftLowerThigh;
        private Servo leftShin;
        private Servo leftFoot;
        private Servo rightHip;
        private Servo rightUpperThigh;
        private Servo rightLowerThigh;
        private Servo rightShin;
        private Servo rightFoot;
        #endregion

        #region Properties
        public Rcb1 Rcb1 { get { return rcb1; } }

        public Servo LeftForearm { get { return leftForearm; } }
        public Servo LeftBicep { get { return leftBicep; } }
        public Servo LeftShoulder { get { return leftShoulder; } }
        public Servo Head { get { return head; } }
        public Servo RightForearm { get { return rightForearm; } }
        public Servo RightBicep { get { return rightBicep; } }
        public Servo RightShoulder { get { return rightShoulder; } }

        public Servo LeftHip { get { return leftHip; } }
        public Servo LeftUpperThigh { get { return leftUpperThigh; } }
        public Servo LeftLowerThigh { get { return leftLowerThigh; } }
        public Servo LeftShin { get { return leftShin; } }
        public Servo LeftFoot { get { return leftFoot; } }
        public Servo RightHip { get { return rightHip; } }
        public Servo RightUpperThigh { get { return rightUpperThigh; } }
        public Servo RightLowerThigh { get { return rightLowerThigh; } }
        public Servo RightShin { get { return rightShin; } }
        public Servo RightFoot { get { return rightFoot; } }
        #endregion

        public Khr1(SerialPort serialPort)
        {
            rcb1 = new Rcb1(this, serialPort);

            leftForearm = new LeftForearm(rcb1);
            leftBicep = new LeftBicep(rcb1);
            leftShoulder = new LeftShoulder(rcb1);
            head = new Head(rcb1);
            rightShoulder = new RightShoulder(rcb1);
            rightBicep = new RightBicep(rcb1);
            rightForearm = new RightForearm(rcb1);

            leftHip = new LeftHip(rcb1);
            leftUpperThigh = new LeftUpperThigh(rcb1);
            leftLowerThigh = new LeftLowerThigh(rcb1);
            leftShin = new LeftShin(rcb1);
            leftFoot = new LeftFoot(rcb1);
            rightHip = new RightHip(rcb1);
            rightUpperThigh = new RightUpperThigh(rcb1);
            rightLowerThigh = new RightLowerThigh(rcb1);
            rightShin = new RightShin(rcb1);
            rightFoot = new RightFoot(rcb1);
        }
    }
}
