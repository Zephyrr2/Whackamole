namespace whackamole
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
            this.lblHit = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.Mole = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRetry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHit
            // 
            this.lblHit.AutoSize = true;
            this.lblHit.BackColor = System.Drawing.Color.Transparent;
            this.lblHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHit.Location = new System.Drawing.Point(436, 32);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(62, 32);
            this.lblHit.TabIndex = 0;
            this.lblHit.Text = "Hit:";
            // 
            // lblMiss
            // 
            this.lblMiss.AutoSize = true;
            this.lblMiss.BackColor = System.Drawing.Color.Transparent;
            this.lblMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiss.Location = new System.Drawing.Point(412, 64);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(86, 32);
            this.lblMiss.TabIndex = 1;
            this.lblMiss.Text = "Miss:";
            // 
            // Mole
            // 
            this.Mole.BackColor = System.Drawing.Color.Transparent;
            this.Mole.Image = global::whackamole.Properties.Resources.mario_removebg_preview__1_;
            this.Mole.Location = new System.Drawing.Point(460, 411);
            this.Mole.Name = "Mole";
            this.Mole.Size = new System.Drawing.Size(90, 100);
            this.Mole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mole.TabIndex = 2;
            this.Mole.TabStop = false;
            this.Mole.Click += new System.EventHandler(this.gotMole);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.moveMole);
            // 
            // btnRetry
            // 
            this.btnRetry.Font = new System.Drawing.Font("News706 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.Image = global::whackamole.Properties.Resources.button_removebg_preview;
            this.btnRetry.Location = new System.Drawing.Point(272, 594);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(92, 43);
            this.btnRetry.TabIndex = 3;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::whackamole.Properties.Resources.ground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 649);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.Mole);
            this.Controls.Add(this.lblMiss);
            this.Controls.Add(this.lblHit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.Label lblMiss;
        private System.Windows.Forms.PictureBox Mole;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRetry;
    }
}

