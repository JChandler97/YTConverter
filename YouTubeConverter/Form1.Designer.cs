namespace YouTubeConverter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCheck = new System.Windows.Forms.Label();
            this.DLButton = new System.Windows.Forms.Button();
            this.FPDisplay = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Enter YouTube link here";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check Link";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.Location = new System.Drawing.Point(641, 81);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(46, 17);
            this.labelCheck.TabIndex = 3;
            this.labelCheck.Text = "label2";
            this.labelCheck.Visible = false;
            // 
            // DLButton
            // 
            this.DLButton.Location = new System.Drawing.Point(627, 226);
            this.DLButton.Name = "DLButton";
            this.DLButton.Size = new System.Drawing.Size(109, 23);
            this.DLButton.TabIndex = 4;
            this.DLButton.Text = "Download";
            this.DLButton.UseVisualStyleBackColor = true;
            this.DLButton.Visible = false;
            this.DLButton.Click += new System.EventHandler(this.DLButton_Click);
            // 
            // FPDisplay
            // 
            this.FPDisplay.Location = new System.Drawing.Point(293, 226);
            this.FPDisplay.Name = "FPDisplay";
            this.FPDisplay.ReadOnly = true;
            this.FPDisplay.Size = new System.Drawing.Size(292, 22);
            this.FPDisplay.TabIndex = 5;
            this.FPDisplay.Text = "Select a folder:";
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(591, 225);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(30, 23);
            this.FileButton.TabIndex = 7;
            this.FileButton.Text = "...";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(953, 526);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.FPDisplay);
            this.Controls.Add(this.DLButton);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Youtube Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.Button DLButton;
        private System.Windows.Forms.TextBox FPDisplay;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button FileButton;
    }
}

