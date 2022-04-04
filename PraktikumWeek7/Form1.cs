using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek7
{
    public partial class praktikumWeek7 : Form
    {
        public praktikumWeek7()
        {
            InitializeComponent();
        }

        private void praktikumWeek7_Load(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            char hurufAwal = Convert.ToChar(tboxAwal.Text);
            char hurufAkhir = Convert.ToChar(tboxAkhir.Text);
            int selisih = hurufAkhir - hurufAwal;
            if (selisih < 0)
            {
                selisih += 26;
            }
            string kumpulanHuruf = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
            char[] huruf = kumpulanHuruf.ToUpper().ToCharArray();
            char[] inputKalimat = tboxKalimat.Text.ToUpper().ToCharArray();
            int hurufTambah = hurufAwal + selisih;
            int jumlahKata = tboxKalimat.TextLength;
            string hasil = "";
            for (int i = 0; i < jumlahKata; i++)
            {
                if (inputKalimat[i] == ' ')
                {
                    hasil += inputKalimat[i];
                }
                for (int j = 0; j < 26; j++)
                {
                    if (inputKalimat[i] == huruf[j])
                    {
                        hasil += huruf[j + selisih];
                    }
                }
            }
            lblOutput.Text = hasil.ToUpper();
        }
    }
}
