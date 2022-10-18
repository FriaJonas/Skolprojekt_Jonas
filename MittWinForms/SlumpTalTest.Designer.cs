namespace MittWinForms
{
    partial class SlumpTalTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.numGuess = new System.Windows.Forms.NumericUpDown();
            this.btnPress = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numGuess)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antal gissningar";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(217, 83);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(17, 20);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0";
            // 
            // numGuess
            // 
            this.numGuess.Location = new System.Drawing.Point(93, 134);
            this.numGuess.Name = "numGuess";
            this.numGuess.Size = new System.Drawing.Size(150, 27);
            this.numGuess.TabIndex = 2;
            // 
            // btnPress
            // 
            this.btnPress.Location = new System.Drawing.Point(92, 196);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(94, 29);
            this.btnPress.TabIndex = 3;
            this.btnPress.Text = "Gissa!";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(89, 252);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(55, 20);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Gissa!!!";
            // 
            // SlumpTalTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 363);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnPress);
            this.Controls.Add(this.numGuess);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Name = "SlumpTalTest";
            this.Text = "SlumpTalTest";
            this.Load += new System.EventHandler(this.SlumpTalTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGuess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblCount;
        private NumericUpDown numGuess;
        private Button btnPress;
        private Label lblMessage;
    }
}