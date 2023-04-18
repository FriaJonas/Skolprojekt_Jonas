namespace MittWinForms
{
    partial class Shoot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shoot));
            this.Ship = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ship)).BeginInit();
            this.SuspendLayout();
            // 
            // Ship
            // 
            this.Ship.Image = ((System.Drawing.Image)(resources.GetObject("Ship.Image")));
            this.Ship.Location = new System.Drawing.Point(525, 482);
            this.Ship.Name = "Ship";
            this.Ship.Size = new System.Drawing.Size(152, 181);
            this.Ship.TabIndex = 0;
            this.Ship.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1027, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Shoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ship);
            this.Name = "Shoot";
            this.Text = "Shoot";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Shoot_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Ship)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Ship;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}