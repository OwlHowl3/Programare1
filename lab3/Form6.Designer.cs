namespace lab3
{
    partial class Form6
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
            this.textBoxNr1 = new System.Windows.Forms.TextBox();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.labelNr1 = new System.Windows.Forms.Label();
            this.labelNr2 = new System.Windows.Forms.Label();
            this.textBoxNr2 = new System.Windows.Forms.TextBox();
            this.buttonDifference = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNr1
            // 
            this.textBoxNr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNr1.Location = new System.Drawing.Point(41, 74);
            this.textBoxNr1.Name = "textBoxNr1";
            this.textBoxNr1.Size = new System.Drawing.Size(86, 29);
            this.textBoxNr1.TabIndex = 0;
            // 
            // buttonAddition
            // 
            this.buttonAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddition.Location = new System.Drawing.Point(94, 144);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(33, 34);
            this.buttonAddition.TabIndex = 1;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.buttonAddition_Click);
            // 
            // labelNr1
            // 
            this.labelNr1.AutoSize = true;
            this.labelNr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNr1.Location = new System.Drawing.Point(37, 37);
            this.labelNr1.Name = "labelNr1";
            this.labelNr1.Size = new System.Drawing.Size(90, 20);
            this.labelNr1.TabIndex = 2;
            this.labelNr1.Text = "Numarul 1";
            // 
            // labelNr2
            // 
            this.labelNr2.AutoSize = true;
            this.labelNr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNr2.Location = new System.Drawing.Point(234, 37);
            this.labelNr2.Name = "labelNr2";
            this.labelNr2.Size = new System.Drawing.Size(90, 20);
            this.labelNr2.TabIndex = 3;
            this.labelNr2.Text = "Numarul 2";
            // 
            // textBoxNr2
            // 
            this.textBoxNr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNr2.Location = new System.Drawing.Point(238, 74);
            this.textBoxNr2.Name = "textBoxNr2";
            this.textBoxNr2.Size = new System.Drawing.Size(86, 29);
            this.textBoxNr2.TabIndex = 4;
            // 
            // buttonDifference
            // 
            this.buttonDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDifference.Location = new System.Drawing.Point(149, 144);
            this.buttonDifference.Name = "buttonDifference";
            this.buttonDifference.Size = new System.Drawing.Size(33, 34);
            this.buttonDifference.TabIndex = 5;
            this.buttonDifference.Text = "-";
            this.buttonDifference.UseVisualStyleBackColor = true;
            this.buttonDifference.Click += new System.EventHandler(this.buttonDifference_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplication.Location = new System.Drawing.Point(208, 144);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(36, 34);
            this.buttonMultiplication.TabIndex = 6;
            this.buttonMultiplication.Text = "x";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(263, 144);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(36, 34);
            this.buttonDivision.TabIndex = 7;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 398);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDifference);
            this.Controls.Add(this.textBoxNr2);
            this.Controls.Add(this.labelNr2);
            this.Controls.Add(this.labelNr1);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.textBoxNr1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNr1;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Label labelNr1;
        private System.Windows.Forms.Label labelNr2;
        private System.Windows.Forms.TextBox textBoxNr2;
        private System.Windows.Forms.Button buttonDifference;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
    }
}