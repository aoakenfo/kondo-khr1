namespace Khr1Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.servoTrackBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.ch17Panel = new System.Windows.Forms.Panel();
            this.ch23Panel = new System.Windows.Forms.Panel();
            this.ch16Panel = new System.Windows.Forms.Panel();
            this.ch22Panel = new System.Windows.Forms.Panel();
            this.ch15Panel = new System.Windows.Forms.Panel();
            this.ch21Panel = new System.Windows.Forms.Panel();
            this.ch14Panel = new System.Windows.Forms.Panel();
            this.ch20Panel = new System.Windows.Forms.Panel();
            this.ch13Panel = new System.Windows.Forms.Panel();
            this.ch19Panel = new System.Windows.Forms.Panel();
            this.ch1Panel = new System.Windows.Forms.Panel();
            this.ch7Panel = new System.Windows.Forms.Panel();
            this.ch2Panel = new System.Windows.Forms.Panel();
            this.ch6Panel = new System.Windows.Forms.Panel();
            this.ch8Panel = new System.Windows.Forms.Panel();
            this.ch9Panel = new System.Windows.Forms.Panel();
            this.ch3Panel = new System.Windows.Forms.Panel();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.servoGroupBox = new System.Windows.Forms.GroupBox();
            this.upperTorsoMotionNumber = new System.Windows.Forms.ComboBox();
            this.label_10 = new System.Windows.Forms.Label();
            this.upperTorsoPoseGroupBox = new System.Windows.Forms.GroupBox();
            this.upperTorsoSetPoseCountButton = new System.Windows.Forms.Button();
            this.upperTorsoPoseCount = new System.Windows.Forms.NumericUpDown();
            this.label_6 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.upperTorsoRelativeSpeed = new System.Windows.Forms.NumericUpDown();
            this.upperTorsoSetPoseButton = new System.Windows.Forms.Button();
            this.upperTorsoPositionNumber = new System.Windows.Forms.ComboBox();
            this.label_4 = new System.Windows.Forms.Label();
            this.upperTorsoPlayMotionButton = new System.Windows.Forms.Button();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.upperTorsoMotionGroupBox = new System.Windows.Forms.GroupBox();
            this.upperTorsoClearMotionButton = new System.Windows.Forms.Button();
            this.lowerTorsoPoseGroupBox = new System.Windows.Forms.GroupBox();
            this.lowerTorsoSetPoseCountButton = new System.Windows.Forms.Button();
            this.lowerTorsoPoseCount = new System.Windows.Forms.NumericUpDown();
            this.label_9 = new System.Windows.Forms.Label();
            this.label_8 = new System.Windows.Forms.Label();
            this.lowerTorsoRelativeSpeed = new System.Windows.Forms.NumericUpDown();
            this.lowerTorsoSetPoseButton = new System.Windows.Forms.Button();
            this.lowerTorsoPositionNumber = new System.Windows.Forms.ComboBox();
            this.label_7 = new System.Windows.Forms.Label();
            this.individualRadioButton = new System.Windows.Forms.RadioButton();
            this.correspondingRadioButton = new System.Windows.Forms.RadioButton();
            this.homePositionGroupBox = new System.Windows.Forms.GroupBox();
            this.setHomePositionButton = new System.Windows.Forms.Button();
            this.motionComboGroupBox = new System.Windows.Forms.GroupBox();
            this.lowerTorsoMotionGroupBox = new System.Windows.Forms.GroupBox();
            this.lowerTorsoClearMotionButton = new System.Windows.Forms.Button();
            this.lowerTorsoMotionNumber = new System.Windows.Forms.ComboBox();
            this.label_11 = new System.Windows.Forms.Label();
            this.lowerTorsoPlayMotionButton = new System.Windows.Forms.Button();
            this.reconnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.servoTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.imagePanel.SuspendLayout();
            this.servoGroupBox.SuspendLayout();
            this.upperTorsoPoseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperTorsoPoseCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperTorsoRelativeSpeed)).BeginInit();
            this.outputGroupBox.SuspendLayout();
            this.upperTorsoMotionGroupBox.SuspendLayout();
            this.lowerTorsoPoseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowerTorsoPoseCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerTorsoRelativeSpeed)).BeginInit();
            this.homePositionGroupBox.SuspendLayout();
            this.motionComboGroupBox.SuspendLayout();
            this.lowerTorsoMotionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // servoTrackBar
            // 
            this.servoTrackBar.Location = new System.Drawing.Point(12, 29);
            this.servoTrackBar.Maximum = 180;
            this.servoTrackBar.Name = "servoTrackBar";
            this.servoTrackBar.Size = new System.Drawing.Size(435, 45);
            this.servoTrackBar.TabIndex = 1;
            this.servoTrackBar.TickFrequency = 5;
            this.servoTrackBar.Scroll += new System.EventHandler(this.OnServoTrackbarScroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reconnectMenuItem,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(35, 20);
            this.fileMenu.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.OnExitMenuItemClick);
            // 
            // imagePanel
            // 
            this.imagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagePanel.BackgroundImage")));
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Controls.Add(this.ch17Panel);
            this.imagePanel.Controls.Add(this.ch23Panel);
            this.imagePanel.Controls.Add(this.ch16Panel);
            this.imagePanel.Controls.Add(this.ch22Panel);
            this.imagePanel.Controls.Add(this.ch15Panel);
            this.imagePanel.Controls.Add(this.ch21Panel);
            this.imagePanel.Controls.Add(this.ch14Panel);
            this.imagePanel.Controls.Add(this.ch20Panel);
            this.imagePanel.Controls.Add(this.ch13Panel);
            this.imagePanel.Controls.Add(this.ch19Panel);
            this.imagePanel.Controls.Add(this.ch1Panel);
            this.imagePanel.Controls.Add(this.ch7Panel);
            this.imagePanel.Controls.Add(this.ch2Panel);
            this.imagePanel.Controls.Add(this.ch6Panel);
            this.imagePanel.Controls.Add(this.ch8Panel);
            this.imagePanel.Controls.Add(this.ch9Panel);
            this.imagePanel.Controls.Add(this.ch3Panel);
            this.imagePanel.Location = new System.Drawing.Point(12, 36);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(549, 453);
            this.imagePanel.TabIndex = 20;
            this.imagePanel.Click += new System.EventHandler(this.OnImagePanelClick);
            // 
            // ch17Panel
            // 
            this.ch17Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch17Panel.Location = new System.Drawing.Point(279, 392);
            this.ch17Panel.Name = "ch17Panel";
            this.ch17Panel.Size = new System.Drawing.Size(77, 56);
            this.ch17Panel.TabIndex = 16;
            this.ch17Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch23Panel
            // 
            this.ch23Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch23Panel.Location = new System.Drawing.Point(194, 392);
            this.ch23Panel.Name = "ch23Panel";
            this.ch23Panel.Size = new System.Drawing.Size(79, 56);
            this.ch23Panel.TabIndex = 15;
            this.ch23Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch16Panel
            // 
            this.ch16Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch16Panel.Location = new System.Drawing.Point(279, 317);
            this.ch16Panel.Name = "ch16Panel";
            this.ch16Panel.Size = new System.Drawing.Size(62, 69);
            this.ch16Panel.TabIndex = 14;
            this.ch16Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch22Panel
            // 
            this.ch22Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch22Panel.Location = new System.Drawing.Point(205, 317);
            this.ch22Panel.Name = "ch22Panel";
            this.ch22Panel.Size = new System.Drawing.Size(68, 69);
            this.ch22Panel.TabIndex = 13;
            this.ch22Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch15Panel
            // 
            this.ch15Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch15Panel.Location = new System.Drawing.Point(279, 262);
            this.ch15Panel.Name = "ch15Panel";
            this.ch15Panel.Size = new System.Drawing.Size(62, 49);
            this.ch15Panel.TabIndex = 12;
            this.ch15Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch21Panel
            // 
            this.ch21Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch21Panel.Location = new System.Drawing.Point(205, 262);
            this.ch21Panel.Name = "ch21Panel";
            this.ch21Panel.Size = new System.Drawing.Size(68, 49);
            this.ch21Panel.TabIndex = 11;
            this.ch21Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch14Panel
            // 
            this.ch14Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch14Panel.Location = new System.Drawing.Point(279, 199);
            this.ch14Panel.Name = "ch14Panel";
            this.ch14Panel.Size = new System.Drawing.Size(62, 57);
            this.ch14Panel.TabIndex = 10;
            this.ch14Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch20Panel
            // 
            this.ch20Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch20Panel.Location = new System.Drawing.Point(205, 199);
            this.ch20Panel.Name = "ch20Panel";
            this.ch20Panel.Size = new System.Drawing.Size(68, 57);
            this.ch20Panel.TabIndex = 9;
            this.ch20Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch13Panel
            // 
            this.ch13Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch13Panel.Location = new System.Drawing.Point(279, 135);
            this.ch13Panel.Name = "ch13Panel";
            this.ch13Panel.Size = new System.Drawing.Size(62, 58);
            this.ch13Panel.TabIndex = 8;
            this.ch13Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch19Panel
            // 
            this.ch19Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch19Panel.Location = new System.Drawing.Point(205, 135);
            this.ch19Panel.Name = "ch19Panel";
            this.ch19Panel.Size = new System.Drawing.Size(68, 58);
            this.ch19Panel.TabIndex = 7;
            this.ch19Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch1Panel
            // 
            this.ch1Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch1Panel.Location = new System.Drawing.Point(279, 76);
            this.ch1Panel.Name = "ch1Panel";
            this.ch1Panel.Size = new System.Drawing.Size(62, 53);
            this.ch1Panel.TabIndex = 6;
            this.ch1Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch7Panel
            // 
            this.ch7Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch7Panel.Location = new System.Drawing.Point(205, 76);
            this.ch7Panel.Name = "ch7Panel";
            this.ch7Panel.Size = new System.Drawing.Size(68, 53);
            this.ch7Panel.TabIndex = 5;
            this.ch7Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch2Panel
            // 
            this.ch2Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch2Panel.Location = new System.Drawing.Point(347, 45);
            this.ch2Panel.Name = "ch2Panel";
            this.ch2Panel.Size = new System.Drawing.Size(83, 84);
            this.ch2Panel.TabIndex = 4;
            this.ch2Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch6Panel
            // 
            this.ch6Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch6Panel.Location = new System.Drawing.Point(255, 3);
            this.ch6Panel.Name = "ch6Panel";
            this.ch6Panel.Size = new System.Drawing.Size(40, 67);
            this.ch6Panel.TabIndex = 3;
            this.ch6Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch8Panel
            // 
            this.ch8Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch8Panel.Location = new System.Drawing.Point(118, 45);
            this.ch8Panel.Name = "ch8Panel";
            this.ch8Panel.Size = new System.Drawing.Size(83, 84);
            this.ch8Panel.TabIndex = 2;
            this.ch8Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch9Panel
            // 
            this.ch9Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch9Panel.Location = new System.Drawing.Point(3, 45);
            this.ch9Panel.Name = "ch9Panel";
            this.ch9Panel.Size = new System.Drawing.Size(111, 84);
            this.ch9Panel.TabIndex = 1;
            this.ch9Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // ch3Panel
            // 
            this.ch3Panel.BackColor = System.Drawing.Color.Transparent;
            this.ch3Panel.Location = new System.Drawing.Point(434, 45);
            this.ch3Panel.Name = "ch3Panel";
            this.ch3Panel.Size = new System.Drawing.Size(111, 84);
            this.ch3Panel.TabIndex = 0;
            this.ch3Panel.Click += new System.EventHandler(this.OnPanelClick);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(19, 77);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(13, 13);
            this.label_1.TabIndex = 21;
            this.label_1.Text = "0";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(219, 77);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(19, 13);
            this.label_2.TabIndex = 22;
            this.label_2.Text = "90";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(422, 77);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(25, 13);
            this.label_3.TabIndex = 23;
            this.label_3.Text = "180";
            // 
            // servoGroupBox
            // 
            this.servoGroupBox.Controls.Add(this.servoTrackBar);
            this.servoGroupBox.Controls.Add(this.label_3);
            this.servoGroupBox.Controls.Add(this.label_1);
            this.servoGroupBox.Controls.Add(this.label_2);
            this.servoGroupBox.Location = new System.Drawing.Point(578, 36);
            this.servoGroupBox.Name = "servoGroupBox";
            this.servoGroupBox.Size = new System.Drawing.Size(462, 100);
            this.servoGroupBox.TabIndex = 24;
            this.servoGroupBox.TabStop = false;
            this.servoGroupBox.Text = "Servo Rotation Degree";
            // 
            // upperTorsoMotionNumber
            // 
            this.upperTorsoMotionNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.upperTorsoMotionNumber.FormattingEnabled = true;
            this.upperTorsoMotionNumber.Location = new System.Drawing.Point(77, 35);
            this.upperTorsoMotionNumber.Name = "upperTorsoMotionNumber";
            this.upperTorsoMotionNumber.Size = new System.Drawing.Size(64, 21);
            this.upperTorsoMotionNumber.TabIndex = 25;
            // 
            // label_10
            // 
            this.label_10.AutoSize = true;
            this.label_10.Location = new System.Drawing.Point(19, 39);
            this.label_10.Name = "label_10";
            this.label_10.Size = new System.Drawing.Size(52, 13);
            this.label_10.TabIndex = 26;
            this.label_10.Text = "Motion #:";
            // 
            // upperTorsoPoseGroupBox
            // 
            this.upperTorsoPoseGroupBox.Controls.Add(this.upperTorsoSetPoseCountButton);
            this.upperTorsoPoseGroupBox.Controls.Add(this.upperTorsoPoseCount);
            this.upperTorsoPoseGroupBox.Controls.Add(this.label_6);
            this.upperTorsoPoseGroupBox.Controls.Add(this.label_5);
            this.upperTorsoPoseGroupBox.Controls.Add(this.upperTorsoRelativeSpeed);
            this.upperTorsoPoseGroupBox.Controls.Add(this.upperTorsoSetPoseButton);
            this.upperTorsoPoseGroupBox.Controls.Add(this.upperTorsoPositionNumber);
            this.upperTorsoPoseGroupBox.Controls.Add(this.label_4);
            this.upperTorsoPoseGroupBox.Location = new System.Drawing.Point(578, 142);
            this.upperTorsoPoseGroupBox.Name = "upperTorsoPoseGroupBox";
            this.upperTorsoPoseGroupBox.Size = new System.Drawing.Size(462, 121);
            this.upperTorsoPoseGroupBox.TabIndex = 27;
            this.upperTorsoPoseGroupBox.TabStop = false;
            this.upperTorsoPoseGroupBox.Text = " Upper Torso Pose";
            // 
            // upperTorsoSetPoseCountButton
            // 
            this.upperTorsoSetPoseCountButton.Location = new System.Drawing.Point(328, 78);
            this.upperTorsoSetPoseCountButton.Name = "upperTorsoSetPoseCountButton";
            this.upperTorsoSetPoseCountButton.Size = new System.Drawing.Size(119, 23);
            this.upperTorsoSetPoseCountButton.TabIndex = 38;
            this.upperTorsoSetPoseCountButton.Text = "Set Pose Count";
            this.upperTorsoSetPoseCountButton.UseVisualStyleBackColor = true;
            this.upperTorsoSetPoseCountButton.Click += new System.EventHandler(this.OnSetPoseCountClick);
            // 
            // upperTorsoPoseCount
            // 
            this.upperTorsoPoseCount.Location = new System.Drawing.Point(261, 81);
            this.upperTorsoPoseCount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.upperTorsoPoseCount.Name = "upperTorsoPoseCount";
            this.upperTorsoPoseCount.Size = new System.Drawing.Size(35, 20);
            this.upperTorsoPoseCount.TabIndex = 37;
            // 
            // label_6
            // 
            this.label_6.AutoSize = true;
            this.label_6.Location = new System.Drawing.Point(191, 83);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(64, 13);
            this.label_6.TabIndex = 36;
            this.label_6.Text = "Pose count:";
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Location = new System.Drawing.Point(174, 38);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(81, 13);
            this.label_5.TabIndex = 33;
            this.label_5.Text = "Relative speed:";
            // 
            // upperTorsoRelativeSpeed
            // 
            this.upperTorsoRelativeSpeed.Location = new System.Drawing.Point(261, 34);
            this.upperTorsoRelativeSpeed.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.upperTorsoRelativeSpeed.Name = "upperTorsoRelativeSpeed";
            this.upperTorsoRelativeSpeed.Size = new System.Drawing.Size(35, 20);
            this.upperTorsoRelativeSpeed.TabIndex = 32;
            this.upperTorsoRelativeSpeed.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // upperTorsoSetPoseButton
            // 
            this.upperTorsoSetPoseButton.Location = new System.Drawing.Point(328, 33);
            this.upperTorsoSetPoseButton.Name = "upperTorsoSetPoseButton";
            this.upperTorsoSetPoseButton.Size = new System.Drawing.Size(119, 23);
            this.upperTorsoSetPoseButton.TabIndex = 29;
            this.upperTorsoSetPoseButton.Text = "Set Pose";
            this.upperTorsoSetPoseButton.UseVisualStyleBackColor = true;
            this.upperTorsoSetPoseButton.Click += new System.EventHandler(this.OnSetPoseButtonClick);
            // 
            // upperTorsoPositionNumber
            // 
            this.upperTorsoPositionNumber.FormattingEnabled = true;
            this.upperTorsoPositionNumber.Location = new System.Drawing.Point(82, 34);
            this.upperTorsoPositionNumber.Name = "upperTorsoPositionNumber";
            this.upperTorsoPositionNumber.Size = new System.Drawing.Size(64, 21);
            this.upperTorsoPositionNumber.TabIndex = 28;
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Location = new System.Drawing.Point(19, 38);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(57, 13);
            this.label_4.TabIndex = 27;
            this.label_4.Text = "Position #:";
            // 
            // upperTorsoPlayMotionButton
            // 
            this.upperTorsoPlayMotionButton.Location = new System.Drawing.Point(323, 34);
            this.upperTorsoPlayMotionButton.Name = "upperTorsoPlayMotionButton";
            this.upperTorsoPlayMotionButton.Size = new System.Drawing.Size(119, 23);
            this.upperTorsoPlayMotionButton.TabIndex = 31;
            this.upperTorsoPlayMotionButton.Text = "Play Motion";
            this.upperTorsoPlayMotionButton.UseVisualStyleBackColor = true;
            this.upperTorsoPlayMotionButton.Click += new System.EventHandler(this.OnPlayMotionButtonClick);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputTextBox);
            this.outputGroupBox.Location = new System.Drawing.Point(16, 504);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(545, 257);
            this.outputGroupBox.TabIndex = 29;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(16, 19);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(512, 224);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "";
            // 
            // upperTorsoMotionGroupBox
            // 
            this.upperTorsoMotionGroupBox.Controls.Add(this.upperTorsoClearMotionButton);
            this.upperTorsoMotionGroupBox.Controls.Add(this.upperTorsoMotionNumber);
            this.upperTorsoMotionGroupBox.Controls.Add(this.label_10);
            this.upperTorsoMotionGroupBox.Controls.Add(this.upperTorsoPlayMotionButton);
            this.upperTorsoMotionGroupBox.Location = new System.Drawing.Point(578, 504);
            this.upperTorsoMotionGroupBox.Name = "upperTorsoMotionGroupBox";
            this.upperTorsoMotionGroupBox.Size = new System.Drawing.Size(462, 83);
            this.upperTorsoMotionGroupBox.TabIndex = 30;
            this.upperTorsoMotionGroupBox.TabStop = false;
            this.upperTorsoMotionGroupBox.Text = "Upper Torso Motion";
            // 
            // upperTorsoClearMotionButton
            // 
            this.upperTorsoClearMotionButton.Location = new System.Drawing.Point(172, 34);
            this.upperTorsoClearMotionButton.Name = "upperTorsoClearMotionButton";
            this.upperTorsoClearMotionButton.Size = new System.Drawing.Size(119, 23);
            this.upperTorsoClearMotionButton.TabIndex = 32;
            this.upperTorsoClearMotionButton.Text = "Clear Motion";
            this.upperTorsoClearMotionButton.UseVisualStyleBackColor = true;
            this.upperTorsoClearMotionButton.Click += new System.EventHandler(this.OnClearMotionButtonClick);
            // 
            // lowerTorsoPoseGroupBox
            // 
            this.lowerTorsoPoseGroupBox.Controls.Add(this.lowerTorsoSetPoseCountButton);
            this.lowerTorsoPoseGroupBox.Controls.Add(this.lowerTorsoPoseCount);
            this.lowerTorsoPoseGroupBox.Controls.Add(this.label_9);
            this.lowerTorsoPoseGroupBox.Controls.Add(this.label_8);
            this.lowerTorsoPoseGroupBox.Controls.Add(this.lowerTorsoRelativeSpeed);
            this.lowerTorsoPoseGroupBox.Controls.Add(this.lowerTorsoSetPoseButton);
            this.lowerTorsoPoseGroupBox.Controls.Add(this.lowerTorsoPositionNumber);
            this.lowerTorsoPoseGroupBox.Controls.Add(this.label_7);
            this.lowerTorsoPoseGroupBox.Location = new System.Drawing.Point(578, 269);
            this.lowerTorsoPoseGroupBox.Name = "lowerTorsoPoseGroupBox";
            this.lowerTorsoPoseGroupBox.Size = new System.Drawing.Size(462, 121);
            this.lowerTorsoPoseGroupBox.TabIndex = 39;
            this.lowerTorsoPoseGroupBox.TabStop = false;
            this.lowerTorsoPoseGroupBox.Text = "Lower Torso Pose";
            // 
            // lowerTorsoSetPoseCountButton
            // 
            this.lowerTorsoSetPoseCountButton.Location = new System.Drawing.Point(328, 78);
            this.lowerTorsoSetPoseCountButton.Name = "lowerTorsoSetPoseCountButton";
            this.lowerTorsoSetPoseCountButton.Size = new System.Drawing.Size(119, 23);
            this.lowerTorsoSetPoseCountButton.TabIndex = 38;
            this.lowerTorsoSetPoseCountButton.Text = "Set Pose Count";
            this.lowerTorsoSetPoseCountButton.UseVisualStyleBackColor = true;
            this.lowerTorsoSetPoseCountButton.Click += new System.EventHandler(this.OnSetPoseCountClick);
            // 
            // lowerTorsoPoseCount
            // 
            this.lowerTorsoPoseCount.Location = new System.Drawing.Point(261, 81);
            this.lowerTorsoPoseCount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.lowerTorsoPoseCount.Name = "lowerTorsoPoseCount";
            this.lowerTorsoPoseCount.Size = new System.Drawing.Size(35, 20);
            this.lowerTorsoPoseCount.TabIndex = 37;
            // 
            // label_9
            // 
            this.label_9.AutoSize = true;
            this.label_9.Location = new System.Drawing.Point(191, 83);
            this.label_9.Name = "label_9";
            this.label_9.Size = new System.Drawing.Size(64, 13);
            this.label_9.TabIndex = 36;
            this.label_9.Text = "Pose count:";
            // 
            // label_8
            // 
            this.label_8.AutoSize = true;
            this.label_8.Location = new System.Drawing.Point(174, 38);
            this.label_8.Name = "label_8";
            this.label_8.Size = new System.Drawing.Size(81, 13);
            this.label_8.TabIndex = 33;
            this.label_8.Text = "Relative speed:";
            // 
            // lowerTorsoRelativeSpeed
            // 
            this.lowerTorsoRelativeSpeed.Location = new System.Drawing.Point(261, 34);
            this.lowerTorsoRelativeSpeed.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.lowerTorsoRelativeSpeed.Name = "lowerTorsoRelativeSpeed";
            this.lowerTorsoRelativeSpeed.Size = new System.Drawing.Size(35, 20);
            this.lowerTorsoRelativeSpeed.TabIndex = 32;
            this.lowerTorsoRelativeSpeed.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lowerTorsoSetPoseButton
            // 
            this.lowerTorsoSetPoseButton.Location = new System.Drawing.Point(328, 33);
            this.lowerTorsoSetPoseButton.Name = "lowerTorsoSetPoseButton";
            this.lowerTorsoSetPoseButton.Size = new System.Drawing.Size(119, 23);
            this.lowerTorsoSetPoseButton.TabIndex = 29;
            this.lowerTorsoSetPoseButton.Text = "Set Pose";
            this.lowerTorsoSetPoseButton.UseVisualStyleBackColor = true;
            this.lowerTorsoSetPoseButton.Click += new System.EventHandler(this.OnSetPoseButtonClick);
            // 
            // lowerTorsoPositionNumber
            // 
            this.lowerTorsoPositionNumber.FormattingEnabled = true;
            this.lowerTorsoPositionNumber.Location = new System.Drawing.Point(82, 34);
            this.lowerTorsoPositionNumber.Name = "lowerTorsoPositionNumber";
            this.lowerTorsoPositionNumber.Size = new System.Drawing.Size(64, 21);
            this.lowerTorsoPositionNumber.TabIndex = 28;
            // 
            // label_7
            // 
            this.label_7.AutoSize = true;
            this.label_7.Location = new System.Drawing.Point(19, 38);
            this.label_7.Name = "label_7";
            this.label_7.Size = new System.Drawing.Size(57, 13);
            this.label_7.TabIndex = 27;
            this.label_7.Text = "Position #:";
            // 
            // individualRadioButton
            // 
            this.individualRadioButton.AutoSize = true;
            this.individualRadioButton.Location = new System.Drawing.Point(22, 33);
            this.individualRadioButton.Name = "individualRadioButton";
            this.individualRadioButton.Size = new System.Drawing.Size(157, 17);
            this.individualRadioButton.TabIndex = 38;
            this.individualRadioButton.TabStop = true;
            this.individualRadioButton.Text = "Play individual torso motions";
            this.individualRadioButton.UseVisualStyleBackColor = true;
            // 
            // correspondingRadioButton
            // 
            this.correspondingRadioButton.AutoSize = true;
            this.correspondingRadioButton.Location = new System.Drawing.Point(22, 56);
            this.correspondingRadioButton.Name = "correspondingRadioButton";
            this.correspondingRadioButton.Size = new System.Drawing.Size(246, 17);
            this.correspondingRadioButton.TabIndex = 39;
            this.correspondingRadioButton.TabStop = true;
            this.correspondingRadioButton.Text = "Play corresponding motion index for lower torso";
            this.correspondingRadioButton.UseVisualStyleBackColor = true;
            // 
            // homePositionGroupBox
            // 
            this.homePositionGroupBox.Controls.Add(this.setHomePositionButton);
            this.homePositionGroupBox.Location = new System.Drawing.Point(578, 682);
            this.homePositionGroupBox.Name = "homePositionGroupBox";
            this.homePositionGroupBox.Size = new System.Drawing.Size(462, 79);
            this.homePositionGroupBox.TabIndex = 40;
            this.homePositionGroupBox.TabStop = false;
            this.homePositionGroupBox.Text = "Home Position";
            // 
            // setHomePositionButton
            // 
            this.setHomePositionButton.Location = new System.Drawing.Point(113, 32);
            this.setHomePositionButton.Name = "setHomePositionButton";
            this.setHomePositionButton.Size = new System.Drawing.Size(270, 23);
            this.setHomePositionButton.TabIndex = 0;
            this.setHomePositionButton.Text = "Set current pose as home position";
            this.setHomePositionButton.UseVisualStyleBackColor = true;
            this.setHomePositionButton.Click += new System.EventHandler(this.OnSetHomePositionButton);
            // 
            // motionComboGroupBox
            // 
            this.motionComboGroupBox.Controls.Add(this.correspondingRadioButton);
            this.motionComboGroupBox.Controls.Add(this.individualRadioButton);
            this.motionComboGroupBox.Location = new System.Drawing.Point(578, 396);
            this.motionComboGroupBox.Name = "motionComboGroupBox";
            this.motionComboGroupBox.Size = new System.Drawing.Size(462, 93);
            this.motionComboGroupBox.TabIndex = 41;
            this.motionComboGroupBox.TabStop = false;
            this.motionComboGroupBox.Text = "Motion Combo";
            // 
            // lowerTorsoMotionGroupBox
            // 
            this.lowerTorsoMotionGroupBox.Controls.Add(this.lowerTorsoClearMotionButton);
            this.lowerTorsoMotionGroupBox.Controls.Add(this.lowerTorsoMotionNumber);
            this.lowerTorsoMotionGroupBox.Controls.Add(this.label_11);
            this.lowerTorsoMotionGroupBox.Controls.Add(this.lowerTorsoPlayMotionButton);
            this.lowerTorsoMotionGroupBox.Location = new System.Drawing.Point(578, 593);
            this.lowerTorsoMotionGroupBox.Name = "lowerTorsoMotionGroupBox";
            this.lowerTorsoMotionGroupBox.Size = new System.Drawing.Size(462, 83);
            this.lowerTorsoMotionGroupBox.TabIndex = 33;
            this.lowerTorsoMotionGroupBox.TabStop = false;
            this.lowerTorsoMotionGroupBox.Text = "Lower Torso Motion";
            // 
            // lowerTorsoClearMotionButton
            // 
            this.lowerTorsoClearMotionButton.Location = new System.Drawing.Point(172, 34);
            this.lowerTorsoClearMotionButton.Name = "lowerTorsoClearMotionButton";
            this.lowerTorsoClearMotionButton.Size = new System.Drawing.Size(119, 23);
            this.lowerTorsoClearMotionButton.TabIndex = 32;
            this.lowerTorsoClearMotionButton.Text = "Clear Motion";
            this.lowerTorsoClearMotionButton.UseVisualStyleBackColor = true;
            this.lowerTorsoClearMotionButton.Click += new System.EventHandler(this.OnClearMotionButtonClick);
            // 
            // lowerTorsoMotionNumber
            // 
            this.lowerTorsoMotionNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lowerTorsoMotionNumber.FormattingEnabled = true;
            this.lowerTorsoMotionNumber.Location = new System.Drawing.Point(77, 35);
            this.lowerTorsoMotionNumber.Name = "lowerTorsoMotionNumber";
            this.lowerTorsoMotionNumber.Size = new System.Drawing.Size(64, 21);
            this.lowerTorsoMotionNumber.TabIndex = 25;
            // 
            // label_11
            // 
            this.label_11.AutoSize = true;
            this.label_11.Location = new System.Drawing.Point(19, 39);
            this.label_11.Name = "label_11";
            this.label_11.Size = new System.Drawing.Size(52, 13);
            this.label_11.TabIndex = 26;
            this.label_11.Text = "Motion #:";
            // 
            // lowerTorsoPlayMotionButton
            // 
            this.lowerTorsoPlayMotionButton.Location = new System.Drawing.Point(323, 34);
            this.lowerTorsoPlayMotionButton.Name = "lowerTorsoPlayMotionButton";
            this.lowerTorsoPlayMotionButton.Size = new System.Drawing.Size(119, 23);
            this.lowerTorsoPlayMotionButton.TabIndex = 31;
            this.lowerTorsoPlayMotionButton.Text = "Play Motion";
            this.lowerTorsoPlayMotionButton.UseVisualStyleBackColor = true;
            this.lowerTorsoPlayMotionButton.Click += new System.EventHandler(this.OnPlayMotionButtonClick);
            // 
            // reconnectMenuItem
            // 
            this.reconnectMenuItem.Name = "reconnectMenuItem";
            this.reconnectMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reconnectMenuItem.Text = "Reconnect";
            this.reconnectMenuItem.Click += new System.EventHandler(this.OnReconnectMenuItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 782);
            this.Controls.Add(this.lowerTorsoMotionGroupBox);
            this.Controls.Add(this.motionComboGroupBox);
            this.Controls.Add(this.homePositionGroupBox);
            this.Controls.Add(this.lowerTorsoPoseGroupBox);
            this.Controls.Add(this.upperTorsoMotionGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.upperTorsoPoseGroupBox);
            this.Controls.Add(this.servoGroupBox);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kondo KHR-1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnFormKeyDown);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.servoTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.imagePanel.ResumeLayout(false);
            this.servoGroupBox.ResumeLayout(false);
            this.servoGroupBox.PerformLayout();
            this.upperTorsoPoseGroupBox.ResumeLayout(false);
            this.upperTorsoPoseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperTorsoPoseCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperTorsoRelativeSpeed)).EndInit();
            this.outputGroupBox.ResumeLayout(false);
            this.upperTorsoMotionGroupBox.ResumeLayout(false);
            this.upperTorsoMotionGroupBox.PerformLayout();
            this.lowerTorsoPoseGroupBox.ResumeLayout(false);
            this.lowerTorsoPoseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowerTorsoPoseCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerTorsoRelativeSpeed)).EndInit();
            this.homePositionGroupBox.ResumeLayout(false);
            this.motionComboGroupBox.ResumeLayout(false);
            this.motionComboGroupBox.PerformLayout();
            this.lowerTorsoMotionGroupBox.ResumeLayout(false);
            this.lowerTorsoMotionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar servoTrackBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Panel ch3Panel;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.GroupBox servoGroupBox;
        private System.Windows.Forms.ComboBox upperTorsoMotionNumber;
        private System.Windows.Forms.Label label_10;
        private System.Windows.Forms.GroupBox upperTorsoPoseGroupBox;
        private System.Windows.Forms.ComboBox upperTorsoPositionNumber;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Button upperTorsoSetPoseButton;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Button upperTorsoPlayMotionButton;
        private System.Windows.Forms.Panel ch9Panel;
        private System.Windows.Forms.Panel ch8Panel;
        private System.Windows.Forms.Panel ch6Panel;
        private System.Windows.Forms.Panel ch2Panel;
        private System.Windows.Forms.Panel ch7Panel;
        private System.Windows.Forms.Panel ch1Panel;
        private System.Windows.Forms.Panel ch19Panel;
        private System.Windows.Forms.Panel ch13Panel;
        private System.Windows.Forms.Panel ch20Panel;
        private System.Windows.Forms.Panel ch14Panel;
        private System.Windows.Forms.Panel ch15Panel;
        private System.Windows.Forms.Panel ch21Panel;
        private System.Windows.Forms.Panel ch22Panel;
        private System.Windows.Forms.Panel ch16Panel;
        private System.Windows.Forms.Panel ch17Panel;
        private System.Windows.Forms.Panel ch23Panel;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.NumericUpDown upperTorsoRelativeSpeed;
        private System.Windows.Forms.GroupBox upperTorsoMotionGroupBox;
        private System.Windows.Forms.Button upperTorsoClearMotionButton;
        private System.Windows.Forms.Button upperTorsoSetPoseCountButton;
        private System.Windows.Forms.NumericUpDown upperTorsoPoseCount;
        private System.Windows.Forms.Label label_6;
        private System.Windows.Forms.RadioButton correspondingRadioButton;
        private System.Windows.Forms.RadioButton individualRadioButton;
        private System.Windows.Forms.GroupBox lowerTorsoPoseGroupBox;
        private System.Windows.Forms.Button lowerTorsoSetPoseCountButton;
        private System.Windows.Forms.NumericUpDown lowerTorsoPoseCount;
        private System.Windows.Forms.Label label_9;
        private System.Windows.Forms.Label label_8;
        private System.Windows.Forms.NumericUpDown lowerTorsoRelativeSpeed;
        private System.Windows.Forms.Button lowerTorsoSetPoseButton;
        private System.Windows.Forms.ComboBox lowerTorsoPositionNumber;
        private System.Windows.Forms.Label label_7;
        private System.Windows.Forms.GroupBox homePositionGroupBox;
        private System.Windows.Forms.Button setHomePositionButton;
        private System.Windows.Forms.GroupBox motionComboGroupBox;
        private System.Windows.Forms.GroupBox lowerTorsoMotionGroupBox;
        private System.Windows.Forms.Button lowerTorsoClearMotionButton;
        private System.Windows.Forms.ComboBox lowerTorsoMotionNumber;
        private System.Windows.Forms.Label label_11;
        private System.Windows.Forms.Button lowerTorsoPlayMotionButton;
        private System.Windows.Forms.ToolStripMenuItem reconnectMenuItem;
    }
}

