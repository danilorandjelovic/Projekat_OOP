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
    }
}