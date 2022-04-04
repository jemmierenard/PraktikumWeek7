namespace PraktikumWeek7
{
    partial class praktikumWeek7
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInputKalimat = new System.Windows.Forms.Label();
            this.lblInputHuruf = new System.Windows.Forms.Label();
            this.tboxKalimat = new System.Windows.Forms.TextBox();
            this.tboxAwal = new System.Windows.Forms.TextBox();
            this.tboxAkhir = new System.Windows.Forms.TextBox();
            this.lblMenjadi = new System.Windows.Forms.Label();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputKalimat
            // 
            this.lblInputKalimat.AutoSize = true;
            this.lblInputKalimat.Location = new System.Drawing.Point(29, 35);
            this.lblInputKalimat.Name = "lblInputKalimat";
            this.lblInputKalimat.Size = new System.Drawing.Size(129, 20);
            this.lblInputKalimat.TabIndex = 0;
            this.lblInputKalimat.Text = "Masukkan Kalimat";
            // 
            // lblInputHuruf
            // 
            this.lblInputHuruf.AutoSize = true;
            this.lblInputHuruf.Location = new System.Drawing.Point(29, 93);
            this.lblInputHuruf.Name = "lblInputHuruf";
            this.lblInputHuruf.Size = new System.Drawing.Size(115, 20);
            this.lblInputHuruf.TabIndex = 1;
            this.lblInputHuruf.Text = "Masukkan Huruf";
            // 
            // tboxKalimat
            // 
            this.tboxKalimat.Location = new System.Drawing.Point(189, 35);
            this.tboxKalimat.Name = "tboxKalimat";
            this.tboxKalimat.Size = new System.Drawing.Size(392, 27);
            this.tboxKalimat.TabIndex = 2;
            // 
            // tboxAwal
            // 
            this.tboxAwal.Location = new System.Drawing.Point(189, 86);
            this.tboxAwal.Name = "tboxAwal";
            this.tboxAwal.Size = new System.Drawing.Size(125, 27);
            this.tboxAwal.TabIndex = 3;
            // 
            // tboxAkhir
            // 
            this.tboxAkhir.Location = new System.Drawing.Point(456, 86);
            this.tboxAkhir.Name = "tboxAkhir";
            this.tboxAkhir.Size = new System.Drawing.Size(125, 27);
            this.tboxAkhir.TabIndex = 4;
            // 
            // lblMenjadi
            // 
            this.lblMenjadi.AutoSize = true;
            this.lblMenjadi.Location = new System.Drawing.Point(359, 93);
            this.lblMenjadi.Name = "lblMenjadi";
            this.lblMenjadi.Size = new System.Drawing.Size(63, 20);
            this.lblMenjadi.TabIndex = 5;
            this.lblMenjadi.Text = "Menjadi";
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(189, 158);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(392, 29);
            this.btnKonversi.TabIndex = 6;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(29, 244);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(49, 20);
            this.lblHasil.TabIndex = 7;
            this.lblHasil.Text = "Hasil :";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(189, 244);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 8;
            // 
            // praktikumWeek7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 408);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.lblMenjadi);
            this.Controls.Add(this.tboxAkhir);
            this.Controls.Add(this.tboxAwal);
            this.Controls.Add(this.tboxKalimat);
            this.Controls.Add(this.lblInputHuruf);
            this.Controls.Add(this.lblInputKalimat);
            this.Name = "praktikumWeek7";
            this.Text = "Praktikum Week 7";
            this.Load += new System.EventHandler(this.praktikumWeek7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputKalimat;
        private System.Windows.Forms.Label lblInputHuruf;
        private System.Windows.Forms.TextBox tboxKalimat;
        private System.Windows.Forms.TextBox tboxAwal;
        private System.Windows.Forms.TextBox tboxAkhir;
        private System.Windows.Forms.Label lblMenjadi;
        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label lblOutput;
    }
}
