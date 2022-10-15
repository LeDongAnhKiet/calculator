namespace WinFrmApp1
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
            this.lbA = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.tbKq = new System.Windows.Forms.TextBox();
            this.lbKq = new System.Windows.Forms.Label();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(68, 58);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(36, 16);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "Số a";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbA.Location = new System.Drawing.Point(138, 55);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 22);
            this.tbA.TabIndex = 1;
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbB.Location = new System.Drawing.Point(138, 100);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 22);
            this.tbB.TabIndex = 3;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(68, 103);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(36, 16);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "Số b";
            // 
            // tbKq
            // 
            this.tbKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKq.Location = new System.Drawing.Point(138, 145);
            this.tbKq.Name = "tbKq";
            this.tbKq.Size = new System.Drawing.Size(100, 22);
            this.tbKq.TabIndex = 5;
            // 
            // lbKq
            // 
            this.lbKq.AutoSize = true;
            this.lbKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKq.Location = new System.Drawing.Point(68, 148);
            this.lbKq.Name = "lbKq";
            this.lbKq.Size = new System.Drawing.Size(53, 16);
            this.lbKq.TabIndex = 4;
            this.lbKq.Text = "Kết quả";
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.Location = new System.Drawing.Point(163, 192);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 29);
            this.btCong.TabIndex = 6;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.tbKq);
            this.Controls.Add(this.lbKq);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox tbKq;
        private System.Windows.Forms.Label lbKq;
        private System.Windows.Forms.Button btCong;
    }
}

