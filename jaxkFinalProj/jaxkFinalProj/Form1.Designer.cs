namespace jaxkFinalProj
{
    partial class wcPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wcPage));
            this.wcLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wcLabel
            // 
            this.wcLabel.AutoSize = true;
            this.wcLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(18)))), ((int)(((byte)(39)))));
            this.wcLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 45F, System.Drawing.FontStyle.Italic);
            this.wcLabel.ForeColor = System.Drawing.Color.Thistle;
            this.wcLabel.ImageKey = "(none)";
            this.wcLabel.Location = new System.Drawing.Point(448, 135);
            this.wcLabel.Name = "wcLabel";
            this.wcLabel.Size = new System.Drawing.Size(322, 73);
            this.wcLabel.TabIndex = 0;
            this.wcLabel.Text = "WELCOME";
            this.wcLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startButton.Location = new System.Drawing.Point(507, 304);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(211, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START YOUR JOURNEY";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(18)))), ((int)(((byte)(39)))));
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(484, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "To Astral Express";
            // 
            // wcPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.wcLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wcPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WELCOME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wcLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
    }
}

