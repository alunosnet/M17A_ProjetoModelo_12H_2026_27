using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17A_ProjetoModelo_12H_2026_27.Livros
{
    public partial class f_livros : Form
    {
        public f_livros()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Botão para adicionar um livro novo à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            c_livros novo = new c_livros();
            novo.titulo = txt_titulo.Text;
            
            //recolher dados do form
            //validar os dados
            //estabelecer a ligação com a base de dados
            //inserir o registo na base dados
            //feedback ao utilizador (sucesso/erro)
            //desligar da base de dados
        }
    }
}
