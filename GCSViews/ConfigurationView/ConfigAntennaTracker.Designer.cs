namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class ConfigAntennaTracker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigAntennaTracker));
            this.TUNE_LOW = new System.Windows.Forms.NumericUpDown();
            this.TUNE_HIGH = new System.Windows.Forms.NumericUpDown();
            this.TUNE = new System.Windows.Forms.ComboBox();
            this.CH7_OPT = new System.Windows.Forms.ComboBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BUT_rerequestparams = new MissionPlanner.Controls.MyButton();
            this.BUT_writePIDS = new MissionPlanner.Controls.MyButton();
            this.myLabel3 = new MissionPlanner.Controls.MyLabel();
            this.myLabel2 = new MissionPlanner.Controls.MyLabel();
            this.myLabel1 = new MissionPlanner.Controls.MyLabel();
            this.BUT_refreshpart = new MissionPlanner.Controls.MyButton();
            this.myLabel4 = new MissionPlanner.Controls.MyLabel();
            this.CH8_OPT = new System.Windows.Forms.ComboBox();
            this.mavlinkComboBox1 = new MissionPlanner.Controls.MavlinkComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mavlinkComboBox2 = new MissionPlanner.Controls.MavlinkComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mavlinkComboBox3 = new MissionPlanner.Controls.MavlinkComboBox();
            this.mavlinkCheckBox1 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.mavlinkNumericUpDown1 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.myTrackBar1 = new MissionPlanner.Controls.MyTrackBar();
            this.mavlinkNumericUpDown2 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.mavlinkNumericUpDown3 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.TUNE_LOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TUNE_HIGH)).BeginInit();
            this.groupBox22.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // TUNE_LOW
            // 
            resources.ApplyResources(this.TUNE_LOW, "TUNE_LOW");
            this.TUNE_LOW.Name = "TUNE_LOW";
            // 
            // TUNE_HIGH
            // 
            resources.ApplyResources(this.TUNE_HIGH, "TUNE_HIGH");
            this.TUNE_HIGH.Name = "TUNE_HIGH";
            // 
            // TUNE
            // 
            this.TUNE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TUNE.DropDownWidth = 170;
            this.TUNE.FormattingEnabled = true;
            resources.ApplyResources(this.TUNE, "TUNE");
            this.TUNE.Name = "TUNE";
            // 
            // CH7_OPT
            // 
            this.CH7_OPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH7_OPT.DropDownWidth = 170;
            this.CH7_OPT.FormattingEnabled = true;
            resources.ApplyResources(this.CH7_OPT, "CH7_OPT");
            this.CH7_OPT.Name = "CH7_OPT";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.mavlinkComboBox1);
            resources.ApplyResources(this.groupBox22, "groupBox22");
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.TabStop = false;
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.myButton1);
            this.groupBox25.Controls.Add(this.mavlinkNumericUpDown3);
            this.groupBox25.Controls.Add(this.mavlinkNumericUpDown2);
            this.groupBox25.Controls.Add(this.myTrackBar1);
            this.groupBox25.Controls.Add(this.mavlinkNumericUpDown1);
            this.groupBox25.Controls.Add(this.mavlinkCheckBox1);
            this.groupBox25.Controls.Add(this.label17);
            this.groupBox25.Controls.Add(this.label90);
            this.groupBox25.Controls.Add(this.label91);
            resources.ApplyResources(this.groupBox25, "groupBox25");
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.TabStop = false;
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label90
            // 
            resources.ApplyResources(this.label90, "label90");
            this.label90.Name = "label90";
            // 
            // label91
            // 
            resources.ApplyResources(this.label91, "label91");
            this.label91.Name = "label91";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // BUT_rerequestparams
            // 
            resources.ApplyResources(this.BUT_rerequestparams, "BUT_rerequestparams");
            this.BUT_rerequestparams.Name = "BUT_rerequestparams";
            this.BUT_rerequestparams.UseVisualStyleBackColor = true;
            this.BUT_rerequestparams.Click += new System.EventHandler(this.BUT_rerequestparams_Click);
            // 
            // BUT_writePIDS
            // 
            resources.ApplyResources(this.BUT_writePIDS, "BUT_writePIDS");
            this.BUT_writePIDS.Name = "BUT_writePIDS";
            this.BUT_writePIDS.UseVisualStyleBackColor = true;
            this.BUT_writePIDS.Click += new System.EventHandler(this.BUT_writePIDS_Click);
            // 
            // myLabel3
            // 
            resources.ApplyResources(this.myLabel3, "myLabel3");
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.resize = false;
            // 
            // myLabel2
            // 
            resources.ApplyResources(this.myLabel2, "myLabel2");
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.resize = false;
            // 
            // myLabel1
            // 
            resources.ApplyResources(this.myLabel1, "myLabel1");
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.resize = false;
            // 
            // BUT_refreshpart
            // 
            resources.ApplyResources(this.BUT_refreshpart, "BUT_refreshpart");
            this.BUT_refreshpart.Name = "BUT_refreshpart";
            this.BUT_refreshpart.UseVisualStyleBackColor = true;
            this.BUT_refreshpart.Click += new System.EventHandler(this.BUT_refreshpart_Click);
            // 
            // myLabel4
            // 
            resources.ApplyResources(this.myLabel4, "myLabel4");
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.resize = false;
            // 
            // CH8_OPT
            // 
            this.CH8_OPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH8_OPT.DropDownWidth = 170;
            this.CH8_OPT.FormattingEnabled = true;
            resources.ApplyResources(this.CH8_OPT, "CH8_OPT");
            this.CH8_OPT.Name = "CH8_OPT";
            // 
            // mavlinkComboBox1
            // 
            this.mavlinkComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.mavlinkComboBox1, "mavlinkComboBox1");
            this.mavlinkComboBox1.FormattingEnabled = true;
            this.mavlinkComboBox1.Name = "mavlinkComboBox1";
            this.mavlinkComboBox1.param = null;
            this.mavlinkComboBox1.ParamName = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mavlinkComboBox2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // mavlinkComboBox2
            // 
            this.mavlinkComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.mavlinkComboBox2, "mavlinkComboBox2");
            this.mavlinkComboBox2.FormattingEnabled = true;
            this.mavlinkComboBox2.Name = "mavlinkComboBox2";
            this.mavlinkComboBox2.param = null;
            this.mavlinkComboBox2.ParamName = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mavlinkComboBox3);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // mavlinkComboBox3
            // 
            this.mavlinkComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.mavlinkComboBox3, "mavlinkComboBox3");
            this.mavlinkComboBox3.FormattingEnabled = true;
            this.mavlinkComboBox3.Name = "mavlinkComboBox3";
            this.mavlinkComboBox3.param = null;
            this.mavlinkComboBox3.ParamName = null;
            // 
            // mavlinkCheckBox1
            // 
            resources.ApplyResources(this.mavlinkCheckBox1, "mavlinkCheckBox1");
            this.mavlinkCheckBox1.Name = "mavlinkCheckBox1";
            this.mavlinkCheckBox1.OffValue = 0F;
            this.mavlinkCheckBox1.OnValue = 1F;
            this.mavlinkCheckBox1.param = null;
            this.mavlinkCheckBox1.ParamName = null;
            this.mavlinkCheckBox1.UseVisualStyleBackColor = true;
            // 
            // mavlinkNumericUpDown1
            // 
            resources.ApplyResources(this.mavlinkNumericUpDown1, "mavlinkNumericUpDown1");
            this.mavlinkNumericUpDown1.Max = 1F;
            this.mavlinkNumericUpDown1.Min = 0F;
            this.mavlinkNumericUpDown1.Name = "mavlinkNumericUpDown1";
            this.mavlinkNumericUpDown1.param = null;
            this.mavlinkNumericUpDown1.ParamName = null;
            // 
            // myTrackBar1
            // 
            this.myTrackBar1.LargeChange = 0.005F;
            resources.ApplyResources(this.myTrackBar1, "myTrackBar1");
            this.myTrackBar1.Maximum = 0.01F;
            this.myTrackBar1.Minimum = 0F;
            this.myTrackBar1.Name = "myTrackBar1";
            this.myTrackBar1.SmallChange = 0.001F;
            this.myTrackBar1.TickFrequency = 0.001F;
            this.myTrackBar1.Value = 0F;
            // 
            // mavlinkNumericUpDown2
            // 
            resources.ApplyResources(this.mavlinkNumericUpDown2, "mavlinkNumericUpDown2");
            this.mavlinkNumericUpDown2.Max = 1F;
            this.mavlinkNumericUpDown2.Min = 0F;
            this.mavlinkNumericUpDown2.Name = "mavlinkNumericUpDown2";
            this.mavlinkNumericUpDown2.param = null;
            this.mavlinkNumericUpDown2.ParamName = null;
            // 
            // mavlinkNumericUpDown3
            // 
            resources.ApplyResources(this.mavlinkNumericUpDown3, "mavlinkNumericUpDown3");
            this.mavlinkNumericUpDown3.Max = 1F;
            this.mavlinkNumericUpDown3.Min = 0F;
            this.mavlinkNumericUpDown3.Name = "mavlinkNumericUpDown3";
            this.mavlinkNumericUpDown3.param = null;
            this.mavlinkNumericUpDown3.ParamName = null;
            // 
            // myButton1
            // 
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.Name = "myButton1";
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // ConfigAntennaTracker
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.CH8_OPT);
            this.Controls.Add(this.BUT_refreshpart);
            this.Controls.Add(this.BUT_rerequestparams);
            this.Controls.Add(this.BUT_writePIDS);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.TUNE_LOW);
            this.Controls.Add(this.TUNE_HIGH);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.TUNE);
            this.Controls.Add(this.myLabel1);
            this.Controls.Add(this.CH7_OPT);
            this.Controls.Add(this.groupBox22);
            this.Controls.Add(this.groupBox25);
            this.Name = "ConfigAntennaTracker";
            ((System.ComponentModel.ISupportInitialize)(this.TUNE_LOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TUNE_HIGH)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyLabel myLabel3;
        private System.Windows.Forms.NumericUpDown TUNE_LOW;
        private System.Windows.Forms.NumericUpDown TUNE_HIGH;
        private Controls.MyLabel myLabel2;
        private System.Windows.Forms.ComboBox TUNE;
        private Controls.MyLabel myLabel1;
        private System.Windows.Forms.ComboBox CH7_OPT;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.ToolTip toolTip1;
        private Controls.MyButton BUT_writePIDS;
        private Controls.MyButton BUT_rerequestparams;
        private Controls.MyButton BUT_refreshpart;
        private Controls.MyLabel myLabel4;
        private System.Windows.Forms.ComboBox CH8_OPT;
        private Controls.MavlinkComboBox mavlinkComboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.MavlinkComboBox mavlinkComboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.MavlinkComboBox mavlinkComboBox3;
        private Controls.MyButton myButton1;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDown3;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDown2;
        private Controls.MyTrackBar myTrackBar1;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDown1;
        private Controls.MavlinkCheckBox mavlinkCheckBox1;
    }
}
