using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_ProjetoModelo_12H_2026_27.Livros
{
    /// <summary>
    /// Responsável por manipular os livros na base de dados (CRUD)
    /// </summary>
    internal class c_livros : icrud
    {
        public int id;
        public string isbn;
        public string titulo;
        public string autor;
        public string tipo;
        public DateTime data_entrada;
        public string estado;
        public bool disponivel;

        public c_livros()
        {
        }

        public c_livros(int id, string isbn, string titulo, string autor, string tipo, DateTime data_entrada, string estado, bool disponivel)
        {
            this.id = id;
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.tipo = tipo;
            this.data_entrada = data_entrada;
            this.estado = estado;
            this.disponivel = disponivel;
        }
        /// <summary>
        /// Faz a validação dos dados do objeto.
        /// </summary>
        /// <returns>String vazia se os dados são válidos. Erros a mostrar ao utilizador.</returns>
        public string validar()
        {
            string erros = "";

            return erros;
        }


        public void atualizar()
        {
            throw new NotImplementedException();
        }

        public void listar()
        {
            throw new NotImplementedException();
        }
        public void adicionar() 
        {
            string sql = "INSERT INTO ....";
        }

        public override string ToString()
        {
            return id + $" - {titulo}";
        }

        public void apagar()
        {
            throw new NotImplementedException();
        }
    }
}
