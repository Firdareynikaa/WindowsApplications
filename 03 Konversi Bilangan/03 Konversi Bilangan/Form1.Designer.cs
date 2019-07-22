namespace _03_Konversi_Bilangan
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
            this.TB_DEC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_BIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_OKT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_DEC
            // 
            this.TB_DEC.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DEC.ForeColor = System.Drawing.Color.Blue;
            this.TB_DEC.Location = new System.Drawing.Point(145, 101);
            this.TB_DEC.Name = "TB_DEC";
            this.TB_DEC.Size = new System.Drawing.Size(100, 31);
            this.TB_DEC.TabIndex = 0;
            this.TB_DEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_DEC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_DEC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desimal";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Biner";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_BIN
            // 
            this.TB_BIN.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BIN.ForeColor = System.Drawing.Color.Blue;
            this.TB_BIN.Location = new System.Drawing.Point(145, 157);
            this.TB_BIN.Name = "TB_BIN";
            this.TB_BIN.Size = new System.Drawing.Size(100, 31);
            this.TB_BIN.TabIndex = 1;
            this.TB_BIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_BIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_BIN_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Motion Picture Personal Use ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konversi Bilangan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oktal";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_OKT
            // 
            this.TB_OKT.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_OKT.ForeColor = System.Drawing.Color.Blue;
            this.TB_OKT.Location = new System.Drawing.Point(145, 204);
            this.TB_OKT.Name = "TB_OKT";
            this.TB_OKT.Size = new System.Drawing.Size(100, 31);
            this.TB_OKT.TabIndex = 2;
            this.TB_OKT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TB_OKT);
            this.Controls.Add(this.TB_BIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_DEC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "KONVERSI BILANGAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_DEC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_BIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_OKT;
    }
}

