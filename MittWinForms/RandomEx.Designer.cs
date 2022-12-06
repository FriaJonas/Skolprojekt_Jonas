namespace MittWinForms
{
    partial class RandomEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomEx));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Bomb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Bomb
            // 
            this.Bomb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bomb.BackgroundImage")));
            this.Bomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bomb.Location = new System.Drawing.Point(205, 106);
            this.Bomb.Name = "Bomb";
            this.Bomb.Size = new System.Drawing.Size(49, 62);
            this.Bomb.TabIndex = 0;
            this.Bomb.TabStop = false;
            this.Bomb.Visible = false;
            this.Bomb.Click += new System.EventHandler(this.Bomb_Click);
            // 
            // RandomEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 484);
            this.Controls.Add(this.Bomb);
            this.Name = "RandomEx";
            this.Text = "RandomEx";
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox Bomb;
    }
}