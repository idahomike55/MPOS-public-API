namespace MiningInfoApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblPoolName = new System.Windows.Forms.Label();
            this.lblHashrate = new System.Windows.Forms.Label();
            this.lblWorkers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNetworkHashrate = new System.Windows.Forms.Label();
            this.lblLastBlock = new System.Windows.Forms.Label();
            this.lblSharesThisRound = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPoolName
            // 
            this.lblPoolName.AutoSize = true;
            this.lblPoolName.Location = new System.Drawing.Point(175, 13);
            this.lblPoolName.Name = "lblPoolName";
            this.lblPoolName.Size = new System.Drawing.Size(53, 13);
            this.lblPoolName.TabIndex = 1;
            this.lblPoolName.Text = "poolname";
            // 
            // lblHashrate
            // 
            this.lblHashrate.AutoSize = true;
            this.lblHashrate.Location = new System.Drawing.Point(175, 41);
            this.lblHashrate.Name = "lblHashrate";
            this.lblHashrate.Size = new System.Drawing.Size(48, 13);
            this.lblHashrate.TabIndex = 2;
            this.lblHashrate.Text = "hashrate";
            // 
            // lblWorkers
            // 
            this.lblWorkers.AutoSize = true;
            this.lblWorkers.Location = new System.Drawing.Point(175, 97);
            this.lblWorkers.Name = "lblWorkers";
            this.lblWorkers.Size = new System.Drawing.Size(44, 13);
            this.lblWorkers.TabIndex = 3;
            this.lblWorkers.Text = "workers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pool Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hashrate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Network Hashrate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Workers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Block:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Shares This Round:";
            // 
            // lblNetworkHashrate
            // 
            this.lblNetworkHashrate.AutoSize = true;
            this.lblNetworkHashrate.Location = new System.Drawing.Point(175, 69);
            this.lblNetworkHashrate.Name = "lblNetworkHashrate";
            this.lblNetworkHashrate.Size = new System.Drawing.Size(86, 13);
            this.lblNetworkHashrate.TabIndex = 10;
            this.lblNetworkHashrate.Text = "networkhashrate";
            // 
            // lblLastBlock
            // 
            this.lblLastBlock.AutoSize = true;
            this.lblLastBlock.Location = new System.Drawing.Point(175, 125);
            this.lblLastBlock.Name = "lblLastBlock";
            this.lblLastBlock.Size = new System.Drawing.Size(49, 13);
            this.lblLastBlock.TabIndex = 11;
            this.lblLastBlock.Text = "lastblock";
            // 
            // lblSharesThisRound
            // 
            this.lblSharesThisRound.AutoSize = true;
            this.lblSharesThisRound.Location = new System.Drawing.Point(175, 153);
            this.lblSharesThisRound.Name = "lblSharesThisRound";
            this.lblSharesThisRound.Size = new System.Drawing.Size(81, 13);
            this.lblSharesThisRound.TabIndex = 12;
            this.lblSharesThisRound.Text = "sharesthisround";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(19, 211);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(237, 20);
            this.textBoxUrl.TabIndex = 13;
            this.textBoxUrl.Text = "http://mzc.cryptopools.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Enter pool address here: \r\n(ex. http://mzc.cryptopools.com)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 266);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.lblSharesThisRound);
            this.Controls.Add(this.lblLastBlock);
            this.Controls.Add(this.lblNetworkHashrate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWorkers);
            this.Controls.Add(this.lblHashrate);
            this.Controls.Add(this.lblPoolName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Public";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPoolName;
        private System.Windows.Forms.Label lblHashrate;
        private System.Windows.Forms.Label lblWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNetworkHashrate;
        private System.Windows.Forms.Label lblLastBlock;
        private System.Windows.Forms.Label lblSharesThisRound;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label7;
    }
}

