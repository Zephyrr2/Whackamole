namespace whackamole
{
    partial class level
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblHit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::whackamole.Properties.Resources.button_removebg_preview;
            this.button1.Location = new System.Drawing.Point(91, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::whackamole.Properties.Resources.button_removebg_preview;
            this.button2.Location = new System.Drawing.Point(259, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::whackamole.Properties.Resources.button_removebg_preview;
            this.button3.Location = new System.Drawing.Point(430, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblHit
            // 
            this.lblHit.AutoSize = true;
            this.lblHit.BackColor = System.Drawing.Color.Transparent;
            this.lblHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHit.Image = global::whackamole.Properties.Resources.button_removebg_preview;
            this.lblHit.Location = new System.Drawing.Point(239, 426);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(89, 32);
            this.lblHit.TabIndex = 3;
            this.lblHit.Text = "Level";
            this.lblHit.Click += new System.EventHandler(this.lblHit_Click);
            // 
            // level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::whackamole.Properties.Resources.Screenshot_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 637);
            this.Controls.Add(this.lblHit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "level";
            this.Text = "level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblHit;
    }
}