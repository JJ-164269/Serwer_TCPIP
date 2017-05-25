namespace Serwer_TCPIP
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
            this.My_Port = new System.Windows.Forms.NumericUpDown();
            this.Address = new System.Windows.Forms.TextBox();
            this.Info_connect = new System.Windows.Forms.ListBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.My_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // My_Port
            // 
            this.My_Port.Location = new System.Drawing.Point(351, 27);
            this.My_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.My_Port.Name = "My_Port";
            this.My_Port.Size = new System.Drawing.Size(371, 20);
            this.My_Port.TabIndex = 0;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(117, 26);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(139, 20);
            this.Address.TabIndex = 1;
            this.Address.Text = "Address";
            // 
            // Info_connect
            // 
            this.Info_connect.FormattingEnabled = true;
            this.Info_connect.Location = new System.Drawing.Point(29, 73);
            this.Info_connect.Name = "Info_connect";
            this.Info_connect.Size = new System.Drawing.Size(730, 251);
            this.Info_connect.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(205, 346);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(116, 48);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(476, 346);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(105, 48);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Info_connect);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.My_Port);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.My_Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown My_Port;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.ListBox Info_connect;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
    }
}

