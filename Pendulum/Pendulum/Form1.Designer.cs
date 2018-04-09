namespace Pendulum
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
            this.components = new System.ComponentModel.Container();
            this.ptbMain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLenght = new System.Windows.Forms.NumericUpDown();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.lblAngle = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.nudForceValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.grbForce = new System.Windows.Forms.GroupBox();
            this.cmbDirection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbForce = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.nudMass = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudForceValue)).BeginInit();
            this.grbForce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMass)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbMain
            // 
            this.ptbMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ptbMain.Location = new System.Drawing.Point(12, 12);
            this.ptbMain.Name = "ptbMain";
            this.ptbMain.Size = new System.Drawing.Size(636, 434);
            this.ptbMain.TabIndex = 0;
            this.ptbMain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lenght :";
            // 
            // nudLenght
            // 
            this.nudLenght.Location = new System.Drawing.Point(717, 14);
            this.nudLenght.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudLenght.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudLenght.Name = "nudLenght";
            this.nudLenght.Size = new System.Drawing.Size(57, 20);
            this.nudLenght.TabIndex = 2;
            this.nudLenght.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudLenght.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudRadius
            // 
            this.nudRadius.Location = new System.Drawing.Point(717, 40);
            this.nudRadius.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(57, 20);
            this.nudRadius.TabIndex = 4;
            this.nudRadius.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRadius.ValueChanged += new System.EventHandler(this.nudRadius_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Radius : ";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nudAngle
            // 
            this.nudAngle.Location = new System.Drawing.Point(717, 92);
            this.nudAngle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudAngle.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(57, 20);
            this.nudAngle.TabIndex = 6;
            this.nudAngle.ValueChanged += new System.EventHandler(this.nudAngle_ValueChanged);
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(654, 92);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(43, 13);
            this.lblAngle.TabIndex = 5;
            this.lblAngle.Text = "Angle : ";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(654, 140);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(73, 23);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // nudForceValue
            // 
            this.nudForceValue.Location = new System.Drawing.Point(70, 19);
            this.nudForceValue.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudForceValue.Name = "nudForceValue";
            this.nudForceValue.Size = new System.Drawing.Size(67, 20);
            this.nudForceValue.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Value : ";
            // 
            // grbForce
            // 
            this.grbForce.Controls.Add(this.cmbDirection);
            this.grbForce.Controls.Add(this.label5);
            this.grbForce.Controls.Add(this.nudForceValue);
            this.grbForce.Controls.Add(this.label4);
            this.grbForce.Location = new System.Drawing.Point(657, 140);
            this.grbForce.Name = "grbForce";
            this.grbForce.Size = new System.Drawing.Size(149, 81);
            this.grbForce.TabIndex = 10;
            this.grbForce.TabStop = false;
            this.grbForce.Text = "Add force";
            this.grbForce.Visible = false;
            // 
            // cmbDirection
            // 
            this.cmbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.cmbDirection.Location = new System.Drawing.Point(70, 44);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(67, 21);
            this.cmbDirection.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direction :";
            // 
            // ckbForce
            // 
            this.ckbForce.AutoSize = true;
            this.ckbForce.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbForce.Location = new System.Drawing.Point(654, 117);
            this.ckbForce.Name = "ckbForce";
            this.ckbForce.Size = new System.Drawing.Size(78, 17);
            this.ckbForce.TabIndex = 11;
            this.ckbForce.Text = "Add force :";
            this.ckbForce.UseVisualStyleBackColor = true;
            this.ckbForce.CheckedChanged += new System.EventHandler(this.ckbForce_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(733, 140);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 23);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // nudMass
            // 
            this.nudMass.Location = new System.Drawing.Point(717, 66);
            this.nudMass.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMass.Name = "nudMass";
            this.nudMass.Size = new System.Drawing.Size(57, 20);
            this.nudMass.TabIndex = 14;
            this.nudMass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mass :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(818, 458);
            this.Controls.Add(this.nudMass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.ckbForce);
            this.Controls.Add(this.grbForce);
            this.Controls.Add(this.nudAngle);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.nudRadius);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudLenght);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbMain);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Pendulum";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudForceValue)).EndInit();
            this.grbForce.ResumeLayout(false);
            this.grbForce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLenght;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.NumericUpDown nudForceValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbForce;
        private System.Windows.Forms.ComboBox cmbDirection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbForce;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown nudMass;
        private System.Windows.Forms.Label label3;
    }
}

