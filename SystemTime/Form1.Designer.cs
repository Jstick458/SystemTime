namespace SystemTime
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRun = new Label();
            btnStart = new Button();
            btnQuit = new Button();
            groupBox1 = new GroupBox();
            hsbInterval = new HScrollBar();
            txtInterval = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRun
            // 
            lblRun.AutoSize = true;
            lblRun.BackColor = Color.Red;
            lblRun.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblRun.ForeColor = SystemColors.ControlText;
            lblRun.Location = new Point(603, 195);
            lblRun.Name = "lblRun";
            lblRun.Size = new Size(117, 37);
            lblRun.TabIndex = 0;
            lblRun.Text = "Stopped";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(100, 159);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(142, 136);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            btnStart.MouseDown += btnStart_MouseDown;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuit.Location = new Point(302, 159);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(142, 136);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(hsbInterval);
            groupBox1.Controls.Add(txtInterval);
            groupBox1.Location = new Point(39, 311);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 110);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Interval Time (s)";
            // 
            // hsbInterval
            // 
            hsbInterval.Location = new Point(23, 61);
            hsbInterval.Name = "hsbInterval";
            hsbInterval.Size = new Size(492, 41);
            hsbInterval.TabIndex = 1;
            hsbInterval.Scroll += hsbInterval_Scroll;
            // 
            // txtInterval
            // 
            txtInterval.Location = new Point(136, 20);
            txtInterval.Name = "txtInterval";
            txtInterval.ReadOnly = true;
            txtInterval.Size = new Size(241, 23);
            txtInterval.TabIndex = 0;
            txtInterval.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnQuit);
            Controls.Add(btnStart);
            Controls.Add(lblRun);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRun;
        private Button btnStart;
        private Button btnQuit;
        private GroupBox groupBox1;
        private HScrollBar hsbInterval;
        private TextBox txtInterval;
    }
}