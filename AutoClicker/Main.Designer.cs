namespace AutoClicker
{
    partial class Main
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
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_startText = new System.Windows.Forms.Label();
            this.lblstart_time = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_delay = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.rdio_RightClick = new System.Windows.Forms.RadioButton();
            this.rdio_LeftClick = new System.Windows.Forms.RadioButton();
            this.chkHold = new System.Windows.Forms.CheckBox();
            this.lbl_rand = new System.Windows.Forms.Label();
            this.txtRand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(116, 127);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(88, 51);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_action_Click);
            // 
            // lbl_startText
            // 
            this.lbl_startText.AutoSize = true;
            this.lbl_startText.Location = new System.Drawing.Point(9, 9);
            this.lbl_startText.Name = "lbl_startText";
            this.lbl_startText.Size = new System.Drawing.Size(77, 13);
            this.lbl_startText.TabIndex = 1;
            this.lbl_startText.Text = "Started Action:";
            // 
            // lblstart_time
            // 
            this.lblstart_time.AutoSize = true;
            this.lblstart_time.Location = new System.Drawing.Point(103, 18);
            this.lblstart_time.Name = "lblstart_time";
            this.lblstart_time.Size = new System.Drawing.Size(0, 13);
            this.lblstart_time.TabIndex = 2;
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(7, 128);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(88, 51);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "STOP!";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // lbl_delay
            // 
            this.lbl_delay.AutoSize = true;
            this.lbl_delay.Location = new System.Drawing.Point(24, 22);
            this.lbl_delay.Name = "lbl_delay";
            this.lbl_delay.Size = new System.Drawing.Size(62, 13);
            this.lbl_delay.TabIndex = 4;
            this.lbl_delay.Text = "Delay (ms): ";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(102, 19);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(70, 20);
            this.txtDelay.TabIndex = 5;
            this.txtDelay.Text = "300";
            // 
            // rdio_RightClick
            // 
            this.rdio_RightClick.AutoSize = true;
            this.rdio_RightClick.Checked = true;
            this.rdio_RightClick.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdio_RightClick.Location = new System.Drawing.Point(27, 71);
            this.rdio_RightClick.Name = "rdio_RightClick";
            this.rdio_RightClick.Size = new System.Drawing.Size(76, 17);
            this.rdio_RightClick.TabIndex = 6;
            this.rdio_RightClick.TabStop = true;
            this.rdio_RightClick.Text = "Right Click";
            this.rdio_RightClick.UseVisualStyleBackColor = true;
            // 
            // rdio_LeftClick
            // 
            this.rdio_LeftClick.AutoSize = true;
            this.rdio_LeftClick.Location = new System.Drawing.Point(116, 71);
            this.rdio_LeftClick.Name = "rdio_LeftClick";
            this.rdio_LeftClick.Size = new System.Drawing.Size(69, 17);
            this.rdio_LeftClick.TabIndex = 7;
            this.rdio_LeftClick.Text = "Left Click";
            this.rdio_LeftClick.UseVisualStyleBackColor = true;
            // 
            // chkHold
            // 
            this.chkHold.AutoSize = true;
            this.chkHold.Location = new System.Drawing.Point(5, 99);
            this.chkHold.Name = "chkHold";
            this.chkHold.Size = new System.Drawing.Size(197, 17);
            this.chkHold.TabIndex = 8;
            this.chkHold.Text = "Hold Click Button Down (For Mining)";
            this.chkHold.UseVisualStyleBackColor = true;
            // 
            // lbl_rand
            // 
            this.lbl_rand.AutoSize = true;
            this.lbl_rand.Location = new System.Drawing.Point(24, 48);
            this.lbl_rand.Name = "lbl_rand";
            this.lbl_rand.Size = new System.Drawing.Size(53, 13);
            this.lbl_rand.TabIndex = 9;
            this.lbl_rand.Text = "Random :";
            this.lbl_rand.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRand
            // 
            this.txtRand.Location = new System.Drawing.Point(102, 45);
            this.txtRand.Name = "txtRand";
            this.txtRand.Size = new System.Drawing.Size(56, 20);
            this.txtRand.TabIndex = 10;
            this.txtRand.Text = "2500";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 186);
            this.Controls.Add(this.txtRand);
            this.Controls.Add(this.lbl_rand);
            this.Controls.Add(this.chkHold);
            this.Controls.Add(this.rdio_LeftClick);
            this.Controls.Add(this.rdio_RightClick);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.lbl_delay);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.lblstart_time);
            this.Controls.Add(this.lbl_startText);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Auto-Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_startText;
        private System.Windows.Forms.Label lblstart_time;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lbl_delay;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.RadioButton rdio_RightClick;
        private System.Windows.Forms.RadioButton rdio_LeftClick;
        private System.Windows.Forms.CheckBox chkHold;
        private System.Windows.Forms.Label lbl_rand;
        private System.Windows.Forms.TextBox txtRand;
    }
}

