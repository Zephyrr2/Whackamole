namespace whackamole
{
    partial class lobby
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
            this.mulai = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mulai
            // 
            this.mulai.BackColor = System.Drawing.Color.Transparent;
            this.mulai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mulai.Font = new System.Drawing.Font("News706 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulai.Image = global::whackamole.Properties.Resources.button_removebg_preview;
            this.mulai.Location = new System.Drawing.Point(252, 417);
            this.mulai.Name = "mulai";
            this.mulai.Size = new System.Drawing.Size(92, 43);
            this.mulai.TabIndex = 0;
            this.mulai.Text = "Mulai";
            this.mulai.UseVisualStyleBackColor = false;
            this.mulai.Click += new System.EventHandler(this.mulai_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("News706 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Image = global::whackamole.Properties.Resources.button_removebg_preview;
            this.exit.Location = new System.Drawing.Point(252, 466);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(92, 43);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::whackamole.Properties.Resources.Screenshot_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 645);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.mulai);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "lobby";
            this.Text = "lobby";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mulai;
        private System.Windows.Forms.Button exit;


    }
}