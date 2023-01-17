namespace MittWinForms
{
    partial class NyttSlumpTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.NumFrom = new System.Windows.Forms.NumericUpDown();
            this.NumTo = new System.Windows.Forms.NumericUpDown();
            this.NumCount = new System.Windows.Forms.NumericUpDown();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slumpa tala mellan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Antal";
            // 
            // NumFrom
            // 
            this.NumFrom.Location = new System.Drawing.Point(112, 85);
            this.NumFrom.Name = "NumFrom";
            this.NumFrom.Size = new System.Drawing.Size(66, 27);
            this.NumFrom.TabIndex = 2;
            // 
            // NumTo
            // 
            this.NumTo.Location = new System.Drawing.Point(194, 85);
            this.NumTo.Name = "NumTo";
            this.NumTo.Size = new System.Drawing.Size(67, 27);
            this.NumTo.TabIndex = 3;
            // 
            // NumCount
            // 
            this.NumCount.Location = new System.Drawing.Point(323, 86);
            this.NumCount.Name = "NumCount";
            this.NumCount.Size = new System.Drawing.Size(91, 27);
            this.NumCount.TabIndex = 4;
            // 
            // BtnRandom
            // 
            this.BtnRandom.BackColor = System.Drawing.Color.Firebrick;
            this.BtnRandom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRandom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRandom.Location = new System.Drawing.Point(110, 140);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(304, 49);
            this.BtnRandom.TabIndex = 5;
            this.BtnRandom.Text = "Slumpa";
            this.BtnRandom.UseVisualStyleBackColor = false;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(114, 206);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(74, 20);
            this.LblResult.TabIndex = 6;
            this.LblResult.Text = "Resultat....";
            // 
            // NyttSlumpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 269);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnRandom);
            this.Controls.Add(this.NumCount);
            this.Controls.Add(this.NumTo);
            this.Controls.Add(this.NumFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NyttSlumpTest";
            this.Text = "NyttSlumpTest";
            ((System.ComponentModel.ISupportInitialize)(this.NumFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown NumFrom;
        private NumericUpDown NumTo;
        private NumericUpDown NumCount;
        private Button BtnRandom;
        private Label LblResult;
    }
}