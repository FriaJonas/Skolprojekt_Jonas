namespace MittWinForms
{
    partial class CatchStars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatchStars));
            this.Player = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Star = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player.BackgroundImage")));
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Location = new System.Drawing.Point(414, 430);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(69, 65);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTimer.Location = new System.Drawing.Point(23, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(84, 37);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "Timer";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPoints.Location = new System.Drawing.Point(712, 20);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(89, 37);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Points";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Star
            // 
            this.Star.BackColor = System.Drawing.Color.Transparent;
            this.Star.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Star.BackgroundImage")));
            this.Star.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Star.Location = new System.Drawing.Point(226, 93);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(33, 31);
            this.Star.TabIndex = 3;
            this.Star.TabStop = false;
            // 
            // CatchStars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.Star);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.Player);
            this.Name = "CatchStars";
            this.Text = "CatchStars";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CatchStars_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Player;
        private Label lblTimer;
        private Label lblPoints;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Star;
    }
}