namespace MittWinForms
{
    partial class Slumpknapp
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
            this.lblAntalTryck = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSlumptal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPress
            // 
            this.btnPress.Location = new System.Drawing.Point(93, 228);
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
            this.label1.Location = new System.Drawing.Point(93, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Antal tryck";
            // 
            // lblAntalTryck
            // 
            this.lblAntalTryck.AutoSize = true;
            this.lblAntalTryck.Location = new System.Drawing.Point(185, 57);
            this.lblAntalTryck.Name = "lblAntalTryck";
            this.lblAntalTryck.Size = new System.Drawing.Size(17, 20);
            this.lblAntalTryck.TabIndex = 2;
            this.lblAntalTryck.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slumptal: ";
            // 
            // lblSlumptal
            // 
            this.lblSlumptal.AutoSize = true;
            this.lblSlumptal.Location = new System.Drawing.Point(185, 157);
            this.lblSlumptal.Name = "lblSlumptal";
            this.lblSlumptal.Size = new System.Drawing.Size(17, 20);
            this.lblSlumptal.TabIndex = 4;
            this.lblSlumptal.Text = "0";
            // 
            // Slumpknapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 312);
            this.Controls.Add(this.lblSlumptal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAntalTryck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPress);
            this.Name = "Slumpknapp";
            this.Text = "Slumpknapp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPress;
        private Label label1;
        private Label lblAntalTryck;
        private Label label2;
        private Label lblSlumptal;
    }
}