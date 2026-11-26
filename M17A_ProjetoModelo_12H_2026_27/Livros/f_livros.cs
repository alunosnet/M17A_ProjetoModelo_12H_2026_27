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
        c_basedados bd;
        public f_livros(c_basedados bd)
        {
            InitializeComponent();
            this.bd = bd;
        }
        /// <summary>
        /// Botão para adicionar um livro novo à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            c_livros novo = new c_livros(bd);
            
            //recolher dados do form
            novo.titulo = txt_titulo.Text;
            novo.isbn=txt_isbn.Text;
            novo.autor=txt_autor.Text;
            novo.tipo = cmb_tipo.Text;
            novo.data_entrada = dtp_data_entrada.Value;
            novo.estado= txt_estado.Text;
            novo.disponivel=ckb_disponivel.Checked;
            //validar os dados
            string erros = novo.validar();
            if (erros != "")
            {
                MessageBox.Show(erros, "Verifique os dados do form.");
                return;
            }

            //inserir o registo na base dados
            novo.adicionar();
            //feedback ao utilizador (sucesso/erro)
           
        }
    }
}
