namespace WindowsFormsApplication1
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
            this.ThrusterBox = new System.Windows.Forms.PictureBox();
            this.CockpitBox = new System.Windows.Forms.PictureBox();
            this.RightWingBox = new System.Windows.Forms.PictureBox();
            this.LeftWingBox = new System.Windows.Forms.PictureBox();
            this.CockpitCombo = new System.Windows.Forms.ComboBox();
            this.ChassisCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LeftWingCombo = new System.Windows.Forms.ComboBox();
            this.RightWingCombo = new System.Windows.Forms.ComboBox();
            this.ThrusterCombo = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.Chassisbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThrusterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CockpitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightWingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftWingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chassisbox)).BeginInit();
            this.SuspendLayout();
            // 
            // ThrusterBox
            // 
            this.ThrusterBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThrusterBox.Image = global::WindowsFormsApplication1.Properties.Resources.TestBox;
            this.ThrusterBox.Location = new System.Drawing.Point(600, 350);
            this.ThrusterBox.Name = "ThrusterBox";
            this.ThrusterBox.Size = new System.Drawing.Size(100, 100);
            this.ThrusterBox.TabIndex = 8;
            this.ThrusterBox.TabStop = false;
            // 
            // CockpitBox
            // 
            this.CockpitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CockpitBox.Image = global::WindowsFormsApplication1.Properties.Resources.TestBox;
            this.CockpitBox.Location = new System.Drawing.Point(600, 150);
            this.CockpitBox.Name = "CockpitBox";
            this.CockpitBox.Size = new System.Drawing.Size(100, 100);
            this.CockpitBox.TabIndex = 9;
            this.CockpitBox.TabStop = false;
            // 
            // RightWingBox
            // 
            this.RightWingBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightWingBox.Image = global::WindowsFormsApplication1.Properties.Resources.TestBox;
            this.RightWingBox.Location = new System.Drawing.Point(700, 250);
            this.RightWingBox.Name = "RightWingBox";
            this.RightWingBox.Size = new System.Drawing.Size(100, 100);
            this.RightWingBox.TabIndex = 11;
            this.RightWingBox.TabStop = false;
            // 
            // LeftWingBox
            // 
            this.LeftWingBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftWingBox.Image = global::WindowsFormsApplication1.Properties.Resources.TestBox;
            this.LeftWingBox.Location = new System.Drawing.Point(500, 250);
            this.LeftWingBox.Name = "LeftWingBox";
            this.LeftWingBox.Size = new System.Drawing.Size(100, 100);
            this.LeftWingBox.TabIndex = 13;
            this.LeftWingBox.TabStop = false;
            // 
            // CockpitCombo
            // 
            this.CockpitCombo.FormattingEnabled = true;
            this.CockpitCombo.Items.AddRange(new object[] {
            "CockpitOne",
            "CockpitThree",
            "CockpitTwo"});
            this.CockpitCombo.Location = new System.Drawing.Point(35, 55);
            this.CockpitCombo.Name = "CockpitCombo";
            this.CockpitCombo.Size = new System.Drawing.Size(121, 21);
            this.CockpitCombo.TabIndex = 15;
            this.CockpitCombo.SelectedIndexChanged += new System.EventHandler(this.CockpitCombo_SelectedIndexChanged);
            // 
            // ChassisCombo
            // 
            this.ChassisCombo.FormattingEnabled = true;
            this.ChassisCombo.Items.AddRange(new object[] {
            "ChassisOne",
            "ChassisTwo",
            "ChassisThree"});
            this.ChassisCombo.Location = new System.Drawing.Point(35, 99);
            this.ChassisCombo.Name = "ChassisCombo";
            this.ChassisCombo.Size = new System.Drawing.Size(121, 21);
            this.ChassisCombo.TabIndex = 16;
            this.ChassisCombo.SelectedIndexChanged += new System.EventHandler(this.ChassisCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cockpit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Chassis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Left Wing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(32, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Right Wing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(32, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Thrusters";
            // 
            // LeftWingCombo
            // 
            this.LeftWingCombo.FormattingEnabled = true;
            this.LeftWingCombo.Items.AddRange(new object[] {
            "LeftWingOne",
            "LeftWingTwo",
            "LeftWingThree"});
            this.LeftWingCombo.Location = new System.Drawing.Point(35, 151);
            this.LeftWingCombo.Name = "LeftWingCombo";
            this.LeftWingCombo.Size = new System.Drawing.Size(121, 21);
            this.LeftWingCombo.TabIndex = 22;
            this.LeftWingCombo.SelectedIndexChanged += new System.EventHandler(this.LeftWingCombo_SelectedIndexChanged);
            // 
            // RightWingCombo
            // 
            this.RightWingCombo.FormattingEnabled = true;
            this.RightWingCombo.Items.AddRange(new object[] {
            "RightWingOne",
            "RightWingTwo",
            "RigthWingThree"});
            this.RightWingCombo.Location = new System.Drawing.Point(35, 201);
            this.RightWingCombo.Name = "RightWingCombo";
            this.RightWingCombo.Size = new System.Drawing.Size(121, 21);
            this.RightWingCombo.TabIndex = 23;
            this.RightWingCombo.SelectedIndexChanged += new System.EventHandler(this.RightWingCombo_SelectedIndexChanged);
            // 
            // ThrusterCombo
            // 
            this.ThrusterCombo.FormattingEnabled = true;
            this.ThrusterCombo.Items.AddRange(new object[] {
            "ThrustersOne",
            "ThrustersTwo",
            "ThrustersThree"});
            this.ThrusterCombo.Location = new System.Drawing.Point(35, 249);
            this.ThrusterCombo.Name = "ThrusterCombo";
            this.ThrusterCombo.Size = new System.Drawing.Size(121, 21);
            this.ThrusterCombo.TabIndex = 24;
            this.ThrusterCombo.SelectedIndexChanged += new System.EventHandler(this.ThrusterCombo_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(35, 350);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.ForeColor = System.Drawing.Color.Black;
            this.LoadButton.Location = new System.Drawing.Point(35, 516);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 27;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Chassisbox
            // 
            this.Chassisbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chassisbox.Image = global::WindowsFormsApplication1.Properties.Resources.TestBox;
            this.Chassisbox.Location = new System.Drawing.Point(600, 250);
            this.Chassisbox.Name = "Chassisbox";
            this.Chassisbox.Size = new System.Drawing.Size(100, 100);
            this.Chassisbox.TabIndex = 30;
            this.Chassisbox.TabStop = false;
            // 
            // Form1
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(977, 564);
            this.Controls.Add(this.Chassisbox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ThrusterCombo);
            this.Controls.Add(this.RightWingCombo);
            this.Controls.Add(this.LeftWingCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChassisCombo);
            this.Controls.Add(this.CockpitCombo);
            this.Controls.Add(this.LeftWingBox);
            this.Controls.Add(this.RightWingBox);
            this.Controls.Add(this.CockpitBox);
            this.Controls.Add(this.ThrusterBox);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThrusterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CockpitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightWingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftWingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chassisbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.PictureBox ThrusterBox;
        private System.Windows.Forms.PictureBox CockpitBox;
        private System.Windows.Forms.PictureBox RightWingBox;
        private System.Windows.Forms.PictureBox LeftWingBox;
        private System.Windows.Forms.ComboBox CockpitCombo;
        private System.Windows.Forms.ComboBox ChassisCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox LeftWingCombo;
        private System.Windows.Forms.ComboBox RightWingCombo;
        private System.Windows.Forms.ComboBox ThrusterCombo;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.PictureBox Chassisbox;
    }
}

