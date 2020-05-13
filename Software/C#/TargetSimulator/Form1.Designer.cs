﻿namespace TargetSimulator
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnShot = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnHalfway = new System.Windows.Forms.Button();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(139, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 70);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(565, 449);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.WordWrap = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnShot
            // 
            this.btnShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShot.Enabled = false;
            this.btnShot.Location = new System.Drawing.Point(416, 10);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(75, 23);
            this.btnShot.TabIndex = 3;
            this.btnShot.Text = "Take a Shot";
            this.btnShot.UseVisualStyleBackColor = true;
            this.btnShot.Click += new System.EventHandler(this.btnShot_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimer.Enabled = false;
            this.btnTimer.Location = new System.Drawing.Point(502, 10);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(75, 23);
            this.btnTimer.TabIndex = 4;
            this.btnTimer.Text = "Start Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.status.Location = new System.Drawing.Point(0, 519);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(589, 22);
            this.status.TabIndex = 5;
            this.status.Text = "Ready";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(39, 17);
            this.statusText.Text = "Ready";
            // 
            // btnCenter
            // 
            this.btnCenter.Enabled = false;
            this.btnCenter.Location = new System.Drawing.Point(13, 40);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(75, 23);
            this.btnCenter.TabIndex = 6;
            this.btnCenter.Text = "Center";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(95, 40);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnTop
            // 
            this.btnTop.Enabled = false;
            this.btnTop.Location = new System.Drawing.Point(177, 40);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(75, 23);
            this.btnTop.TabIndex = 8;
            this.btnTop.Text = "Top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnTopRight
            // 
            this.btnTopRight.Enabled = false;
            this.btnTopRight.Location = new System.Drawing.Point(420, 39);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(75, 23);
            this.btnTopRight.TabIndex = 9;
            this.btnTopRight.Text = "TopRight";
            this.btnTopRight.UseVisualStyleBackColor = true;
            this.btnTopRight.Click += new System.EventHandler(this.btnTopRight_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.Enabled = false;
            this.btnBottom.Location = new System.Drawing.Point(258, 39);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(75, 23);
            this.btnBottom.TabIndex = 10;
            this.btnBottom.Text = "Bottom";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(339, 39);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 11;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnHalfway
            // 
            this.btnHalfway.Enabled = false;
            this.btnHalfway.Location = new System.Drawing.Point(501, 39);
            this.btnHalfway.Name = "btnHalfway";
            this.btnHalfway.Size = new System.Drawing.Size(75, 23);
            this.btnHalfway.TabIndex = 12;
            this.btnHalfway.Text = "Halfway";
            this.btnHalfway.UseVisualStyleBackColor = true;
            this.btnHalfway.Click += new System.EventHandler(this.btnHalfway_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 541);
            this.Controls.Add(this.btnHalfway);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnTopRight);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.status);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnShot);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnHalfway;
    }
}

