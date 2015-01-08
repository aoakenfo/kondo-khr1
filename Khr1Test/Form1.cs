using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO.Ports;

namespace Khr1Test
{
    public partial class Form1 : Form
    {
        #region Data members
        private SerialPort serialPort = new SerialPort();
        private Khr1 khr1;
        private Panel selectedPanel = null;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            TextboxTraceListener listener = new TextboxTraceListener(this.outputTextBox);
            Trace.Listeners.Add(listener);
            Trace.AutoFlush = true;

            if (!OpenComPort())
            {
                EnableUserInterface(false);
                Trace.WriteLine("=========================================");
                Trace.WriteLine("Failure to open COM port");
                Trace.WriteLine("It may be in use");
                Trace.WriteLine("Disabling user interface");
                Trace.WriteLine("The application cannot proceed");
                Trace.WriteLine("=========================================");
                return;
            }

            try
            {
                this.khr1 = new Khr1(serialPort);
            }
            catch
            {
                EnableUserInterface(false);

                Trace.WriteLine("=========================================");
                Trace.WriteLine("Failure initializing KHR-1");
                Trace.WriteLine("Disabling user interface");
                Trace.WriteLine("Please make sure the KHR-1 is on and connected");
                Trace.WriteLine("After, select Reconnect from the File menu");
                Trace.WriteLine("=========================================");

                this.khr1 = null;
            }

            this.KeyPreview = true;

            for (int i = 0; i < Rcb1.TotalMotions; ++i)
            {
                this.upperTorsoMotionNumber.Items.Add(i.ToString());
                this.lowerTorsoMotionNumber.Items.Add(i.ToString());
            }
            for (int i = 0; i < Rcb1.TotalPositions; ++i)
            {
                this.upperTorsoPositionNumber.Items.Add(i.ToString());
                this.lowerTorsoPositionNumber.Items.Add(i.ToString());
            }

            this.upperTorsoMotionNumber.SelectedIndex   = 0;
            this.lowerTorsoMotionNumber.SelectedIndex   = 0;
            this.upperTorsoPositionNumber.SelectedIndex = 0;
            this.lowerTorsoPositionNumber.SelectedIndex = 0;

            this.correspondingRadioButton.Select();

            this.Focus();
        }

        private bool OpenComPort()
        {
            this.serialPort.BaudRate = 115200;
            this.serialPort.ReadTimeout = 30;

            int portNum = 0;
            this.serialPort.PortName = "COM" + portNum.ToString();

        Retry:
            try
            {
                Trace.WriteLine("Attempting to open " + this.serialPort.PortName);
                serialPort.Open();
                Trace.WriteLine("Success!");
                return true;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);

                ++portNum;

                if (portNum < 6)
                {
                    this.serialPort.PortName = "COM" + portNum.ToString();
                    goto Retry;
                }
            }

            return false;
        }

        private void EnableUserInterface(bool value)
        {
            this.servoGroupBox.Enabled = value;
            this.upperTorsoPoseGroupBox.Enabled = value;
            this.upperTorsoMotionGroupBox.Enabled = value;
            this.lowerTorsoPoseGroupBox.Enabled = value;
            this.imagePanel.Enabled = value;
            this.homePositionGroupBox.Enabled = value;
            this.motionComboGroupBox.Enabled = value;
            this.lowerTorsoMotionGroupBox.Enabled = value;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.serialPort.IsOpen)
                this.serialPort.Close();
        }

        private void OnFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void OnReconnectMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                this.khr1 = new Khr1(serialPort);
            }
            catch
            {
                EnableUserInterface(false);

                Trace.WriteLine("=========================================");
                Trace.WriteLine("Failure initializing KHR-1");
                Trace.WriteLine("Disabling user interface");
                Trace.WriteLine("Please make sure the KHR-1 is on and connected");
                Trace.WriteLine("After, select Reconnect from the File menu");
                Trace.WriteLine("=========================================");

                this.khr1 = null;

                return;
            }

            EnableUserInterface(true);
        }

        private void OnExitMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnPanelClick(object sender, EventArgs e)
        {
            Panel p = sender as Panel;

            if (p != null)
            {
                if (selectedPanel != null)
                {
                    selectedPanel.BackColor   = Color.Transparent;
                    selectedPanel.BorderStyle = BorderStyle.None;
                }

                selectedPanel = p;

                p.BackColor   = Color.FromArgb(40, 255, 0, 0);
                p.BorderStyle = BorderStyle.FixedSingle;

                byte value = 0;

                switch (selectedPanel.Name)
                {
                    #region Upper torso
                    case "ch3Panel": // left forearm
                        value = khr1.LeftForearm.Degree;
                        break;

                    case "ch2Panel": // left bicep
                        value = khr1.LeftBicep.Degree;
                        break;

                    case "ch1Panel": // left shoulder
                        value = khr1.LeftShoulder.Degree;
                        break;

                    case "ch6Panel": // head
                        value = khr1.Head.Degree;                        
                        break;

                    case "ch7Panel": // right shoulder
                        value = khr1.RightShoulder.Degree;                        
                        break;

                    case "ch8Panel": // right bicep
                        value = khr1.RightBicep.Degree;                        
                        break;

                    case "ch9Panel": // right forearm
                        value = khr1.RightForearm.Degree;                       
                        break;
                    #endregion

                    #region Lower torso
                    case "ch13Panel": // left hip
                        value = khr1.LeftHip.Degree;
                        break;

                    case "ch14Panel": // left upper thigh
                        value = khr1.LeftUpperThigh.Degree;
                        break;

                    case "ch15Panel": // left lower thigh
                        value = khr1.LeftLowerThigh.Degree;
                        break;
                    
                    case "ch16Panel": // left shin
                        value = khr1.LeftShin.Degree;
                        break;

                    case "ch17Panel": // left foot
                        value = khr1.LeftFoot.Degree;
                        break;

                    case "ch19Panel": // right hip
                        value = khr1.RightHip.Degree;
                        break;

                    case "ch20Panel": // right upper thigh
                        value = khr1.RightUpperThigh.Degree;
                        break;

                    case "ch21Panel": // right lower thigh
                        value = khr1.RightLowerThigh.Degree;
                        break;

                    case "ch22Panel": // right shin
                        value = khr1.RightShin.Degree;
                        break;

                    case "ch23Panel": // right foot
                        value = khr1.RightFoot.Degree;
                        break;
                    #endregion
                }

                if (value >= Servo.MinDegree && value <= Servo.MaxDegree)
                    this.servoTrackBar.Value = value;
            }
        }

        // deselect panel when user clicks image background
        private void OnImagePanelClick(object sender, EventArgs e)
        {
            if (selectedPanel != null)
            {
                selectedPanel.BackColor   = Color.Transparent;
                selectedPanel.BorderStyle = BorderStyle.None;
            }
        }

        private void OnServoTrackbarScroll(object sender, EventArgs e)
        {
            if (selectedPanel != null)
            {
                switch (selectedPanel.Name)
                {
                    #region Upper torso
                    case "ch3Panel": // left forearm
                        khr1.LeftForearm.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch2Panel": // left bicep
                        khr1.LeftBicep.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch1Panel": // left shoulder
                        khr1.LeftShoulder.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch6Panel": // head
                        khr1.Head.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch7Panel": // right shoulder
                        khr1.RightShoulder.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch8Panel": // right bicep
                        //khr1.RightBicep.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch9Panel": // right forearm
                        //khr1.RightForearm.Degree = (byte)this.servoTrackBar.Value;
                        break;
                    #endregion

                    #region Lower torso

                    case "ch13Panel": // left hip
                        khr1.LeftHip.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch14Panel": // left upper thigh
                        khr1.LeftUpperThigh.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch15Panel": // left lower thigh
                        khr1.LeftLowerThigh.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch16Panel": // left shin
                        khr1.LeftShin.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch17Panel": // left foot
                        khr1.LeftFoot.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch19Panel": // right hip
                        khr1.RightHip.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch20Panel": // right upper thigh
                        khr1.RightUpperThigh.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch21Panel": // right lower thigh
                        khr1.RightLowerThigh.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch22Panel": // right shin
                        khr1.RightShin.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    case "ch23Panel": // right foot
                        khr1.RightFoot.Degree = (byte)this.servoTrackBar.Value;
                        break;

                    #endregion
                }

                if (this.outputTextBox.Lines.Length > 100)
                    this.outputTextBox.Clear();
            }
        }

        private void OnSetPoseButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                if (button.Name == "upperTorsoSetPoseButton")
                {
                    khr1.Rcb1.SetPose(BoardId.Zero,
                                      this.upperTorsoPositionNumber.SelectedIndex,
                                      this.upperTorsoMotionNumber.SelectedIndex,
                                      (int)this.upperTorsoRelativeSpeed.Value);

                    if (this.upperTorsoPositionNumber.SelectedIndex != Rcb1.TotalPositions - 1)
                    {
                        upperTorsoPositionNumber.SelectedIndex += 1;
                        this.upperTorsoPoseCount.Value += 1;
                    }
                    else
                    {
                        if (this.upperTorsoMotionNumber.SelectedIndex != Rcb1.TotalMotions - 1)
                        {
                            this.upperTorsoMotionNumber.SelectedIndex += 1;
                            this.upperTorsoPositionNumber.SelectedIndex = 0;
                            this.upperTorsoPoseCount.Value = 0;
                        }
                        else
                            MessageBox.Show("There are no more motions and positions to be set.");
                    }
                }
                else if (button.Name == "lowerTorsoSetPoseButton")
                {
                    khr1.Rcb1.SetPose(BoardId.One,
                                     this.lowerTorsoPositionNumber.SelectedIndex,
                                     this.lowerTorsoMotionNumber.SelectedIndex,
                                     (int)this.lowerTorsoRelativeSpeed.Value);

                    if (this.lowerTorsoPositionNumber.SelectedIndex != Rcb1.TotalPositions - 1)
                    {
                        lowerTorsoPositionNumber.SelectedIndex += 1;
                        this.lowerTorsoPoseCount.Value += 1;
                    }
                    else
                    {
                        if (this.lowerTorsoMotionNumber.SelectedIndex != Rcb1.TotalMotions - 1)
                        {
                            this.lowerTorsoMotionNumber.SelectedIndex += 1;
                            this.lowerTorsoPositionNumber.SelectedIndex = 0;
                            this.lowerTorsoPoseCount.Value = 0;
                        }
                        else
                            MessageBox.Show("There are no more motions and positions to be set.");
                    }

                }
            }
        }

        private void OnClearMotionButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                if (button.Name == "upperTorsoClearMotionButton")
                {
                    if (khr1.Rcb1.SetPoseCount(BoardId.Zero,
                                               this.upperTorsoMotionNumber.SelectedIndex,
                                               0))
                    {
                        Trace.WriteLine("Success clearing motion.");
                        this.upperTorsoPositionNumber.SelectedIndex = 0;
                        this.upperTorsoPoseCount.Value = 0;
                    }
                }
                else if (button.Name == "lowerTorsoClearMotionButton")
                {
                    if (khr1.Rcb1.SetPoseCount(BoardId.One,
                                               this.lowerTorsoMotionNumber.SelectedIndex,
                                               0))
                    {
                        Trace.WriteLine("Success clearing motion.");
                        this.lowerTorsoPositionNumber.SelectedIndex = 0;
                        this.lowerTorsoPoseCount.Value = 0;
                    }
                }
            }
        }

        private void OnPlayMotionButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                if (correspondingRadioButton.Checked)
                {
                    khr1.Rcb1.PlayMotion(BoardId.Zero,
                                            this.upperTorsoMotionNumber.SelectedIndex);
                    khr1.Rcb1.PlayMotion(BoardId.One,
                                             this.lowerTorsoMotionNumber.SelectedIndex);
                }
                else if(individualRadioButton.Checked)
                {
                    if(button.Name == "upperTorsoPlayMotionButton")
                    {
                        khr1.Rcb1.PlayMotion(BoardId.Zero,
                                             this.upperTorsoMotionNumber.SelectedIndex);
                    }
                    else if (button.Name == "lowerTorsoPlayMotionButton")
                    {
                        khr1.Rcb1.PlayMotion(BoardId.One,
                                             this.lowerTorsoMotionNumber.SelectedIndex);
                    }
                }
            }
        }

        private void OnSetPoseCountClick(object sender, EventArgs e)
        {
             Button button = sender as Button;

             if (button != null)
             {
                 if (button.Name == "upperTorsoSetPoseCountButton")
                 {
                     khr1.Rcb1.SetPoseCount(BoardId.Zero,
                                            this.upperTorsoMotionNumber.SelectedIndex,
                                            (int)this.upperTorsoPoseCount.Value);
                 }
                 else if (button.Name == "lowerTorsoSetPoseCountButton")
                 {
                     khr1.Rcb1.SetPoseCount(BoardId.One,
                                            this.lowerTorsoMotionNumber.SelectedIndex,
                                            (int)this.lowerTorsoPoseCount.Value);
                 }
             }
        }

        private void OnSetHomePositionButton(object sender, EventArgs e)
        {
            khr1.Rcb1.SetHomePosition();
        }

    } // end class Form1

} // end namespace Khr1Test