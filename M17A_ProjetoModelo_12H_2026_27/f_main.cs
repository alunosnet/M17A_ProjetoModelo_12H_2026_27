using M17A_ProjetoModelo_12H_2026_27.Livros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17A_ProjetoModelo_12H_2026_27
{
    public partial class f_main : Form
    {
        c_basedados bd=new c_basedados("M17A_12H_Projeto");
        public f_main()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Menu Editar -> Livros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_livros f = new f_livros(bd);
            f.Show();
        }
    }
}
