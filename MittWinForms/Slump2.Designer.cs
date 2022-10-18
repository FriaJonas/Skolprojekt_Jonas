namespace MittWinForms
{
    partial class Slump2
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
            this.btnPress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNrOfClick = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPress
            // 
            this.btnPress.Location = new System.Drawing.Point(291, 181);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(94, 29);
            this.btnPress.TabIndex = 0;
            this.btnPress.Text = "Klicka här";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Antal klick";
            // 
            // lblNrOfClick
            // 
            this.lblNrOfClick.AutoSize = true;
            this.lblNrOfClick.Location = new System.Drawing.Point(243, 115);
            this.lblNrOfClick.Name = "lblNrOfClick";
            this.lblNrOfClick.Size = new System.Drawing.Size(17, 20);
            this.lblNrOfClick.TabIndex = 2;
            this.lblNrOfClick.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slumptal";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(467, 114);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(17, 20);
            this.lblRandom.TabIndex = 4;
            this.lblRandom.Text = "0";
            // 
            // Slump2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNrOfClick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPress);
            this.Name = "Slump2";
            this.Text = "Slump2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPress;
        private Label label1;
        private Label lblNrOfClick;
        private Label label2;
        private Label lblRandom;
    }
}