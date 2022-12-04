
namespace Exam
{
    partial class Form31
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qcm = new Exam.RJButton();
            this.rjButton3 = new Exam.RJButton();
            this.rjButton1 = new Exam.RJButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 31);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question N°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(568, 31);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Question type";
            // 
            // qcm
            // 
            this.qcm.BackColor = System.Drawing.SystemColors.Info;
            this.qcm.BackgroundColor = System.Drawing.SystemColors.Info;
            this.qcm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.qcm.BorderRadius = 13;
            this.qcm.BorderSize = 0;
            this.qcm.FlatAppearance.BorderSize = 0;
            this.qcm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qcm.Font = new System.Drawing.Font("Simplified Arabic Fixed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qcm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.qcm.Location = new System.Drawing.Point(111, 332);
            this.qcm.Name = "qcm";
            this.qcm.Size = new System.Drawing.Size(188, 49);
            this.qcm.TabIndex = 24;
            this.qcm.Text = "QCM";
            this.qcm.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.qcm.UseVisualStyleBackColor = false;
            this.qcm.Click += new System.EventHandler(this.qcm_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.DarkOrange;
            this.rjButton3.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 13;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Simplified Arabic Fixed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rjButton3.Location = new System.Drawing.Point(51, 171);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(145, 49);
            this.rjButton3.TabIndex = 23;
            this.rjButton3.Text = "Confirm";
            this.rjButton3.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.SystemColors.Info;
            this.rjButton1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 13;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Simplified Arabic Fixed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rjButton1.Location = new System.Drawing.Point(359, 332);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(188, 49);
            this.rjButton1.TabIndex = 25;
            this.rjButton1.Text = "open question";
            this.rjButton1.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Form31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.qcm);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form31";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private RJButton qcm;
        private RJButton rjButton3;
        private RJButton rjButton1;
    }
}