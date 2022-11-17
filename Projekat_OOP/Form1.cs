using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_OOP
{
    public partial class frmIgra : Form
    {
        public frmIgra()
        {
            InitializeComponent();
            for (int y = 0; y < matrica.GetLength(1); y++)
            {
                for (int x = 0; x < matrica.GetLength(0); x++)
                {
                    matrica[x, y] = new Polje();
                }
            }
        }
        Polje[,] matrica = new Polje[30, 20];
        bool igra_gotova = true;
        int broj_mina = 40;
        int broj_neotvorenih_polja = 30 * 20;//kada broj neotvorenih polja bude jednak broju mina, igra je gotova-pobeda
        Pen olovka = new Pen(Color.Black, 2);
        Font fontic = new Font("Arial", 13);
        SolidBrush cetka = new SolidBrush(Color.Black);
        
        static int[] nizx = new int[40];
        static int[] nizy = new int[40];
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int sirina = pbxTabela.Width = 600;
            int visina = pbxTabela.Height = 400;
            for (int i = 0; i <= visina; i += visina / 20)
            {
                e.Graphics.DrawLine(olovka, 0, i, sirina, i);
            }

            for (int j = 0; j <= sirina; j += sirina / 30)
            {
                e.Graphics.DrawLine(olovka, j, 0, j, visina);
            }
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            pbxTabela.Refresh();
            igra_gotova = false;
            Upisi_minice(matrica, broj_mina);
        }
        
        private void pbxTabela_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int m = e.X / (pbxTabela.Width / 30);
                int n = e.Y / (pbxTabela.Height / 20);
                Graphics g = pbxTabela.CreateGraphics();
                if (!matrica[m, n].mina && !matrica[m, n].otvoreno)
                {
                    Otvori_Polje(matrica, m, n);
                    broj_neotvorenih_polja--;
                    g.DrawString(Izbroji_Susede(matrica, m, n).ToString(), fontic, cetka, m * (pbxTabela.Width / 30), n * (pbxTabela.Height / 20));
                }
                else if (matrica[m, n].mina && !matrica[m, n].otvoreno)
                {
                    igra_gotova = true;
                    for (int i = 0; i < 40; i++)
                    {
                        g.DrawString("☼", fontic, cetka, nizx[i] * (pbxTabela.Width / 30), nizy[i] * (pbxTabela.Height / 20));
                    }
                    MessageBox.Show("KRAJ IGRE", "IZGUBILI STE");
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                int m = e.X / (pbxTabela.Width / 30);
                int n = e.Y / (pbxTabela.Height / 20);
                g.DrawString("⚑", fontic, cetka, m * (pbxTabela.Width / 30), n * (pbxTabela.Height / 20));
            }
        }

        //-----------------------------------algoritam-------------------------------------//
        static Polje[,] Upisi_minice(Polje[,] matrica, int broj_mina)
        {
             
            Random rand_generator = new Random();
            for (int i = 0; i < broj_mina; i++)
            {
                int mina_x = rand_generator.Next(0, 30);
                int mina_y = rand_generator.Next(0, 20);
                nizx[i] = mina_x;
                nizy[i] = mina_y;
                if (matrica[mina_x, mina_y].mina)
                {
                    i--;
                    
                }
                else matrica[mina_x, mina_y].mina = true;
            }
            return matrica;
        }

        static int Izbroji_Susede(Polje[,] matrica, int x, int y)
        {
            int susedi = 0;
            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if (Proveri_Dimenzije(i, j, matrica) && matrica[i, j].mina == true)
                    {
                        susedi++;
                    }
                }
            }
            if (susedi == 0)
            {
                Otvori_Susede(matrica, x, y);
            }
            return susedi;
        }

        //algoritam
        static void Otvori_Susede(Polje[,] matrica, int x, int y)
        {
            Otvori_Polje(matrica, x - 1, y - 1); Otvori_Polje(matrica, x - 1, y);
            Otvori_Polje(matrica, x - 1, y + 1); Otvori_Polje(matrica, x, y - 1);
            Otvori_Polje(matrica, x, y + 1); Otvori_Polje(matrica, x + 1, y - 1);
            Otvori_Polje(matrica, x + 1, y); Otvori_Polje(matrica, x + 1, y + 1);
        }

        static void Otvori_Polje(Polje[,] matrica, int x, int y)
        {
            if (Proveri_Dimenzije(x, y, matrica) && !matrica[x, y].otvoreno)
            {
                matrica[x, y].otvoreno = true;
                if (Izbroji_Susede(matrica, x, y) == 0)
                    Otvori_Susede(matrica, x, y);
            }
            else return;
        }

        static bool Proveri_Dimenzije(int x, int y, Polje[,] matrica)
        {
            return x >= 0 && x < matrica.GetLength(0) && y >= 0 && y < matrica.GetLength(1);
        }
    }
    }
}
