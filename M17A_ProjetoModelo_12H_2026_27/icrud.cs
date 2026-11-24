using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_ProjetoModelo_12H_2026_27
{
    /// <summary>
    /// Funções para implementar o CRUD
    /// </summary>
    internal interface icrud
    {
        void adicionar();
        void apagar();
        void atualizar();
        void listar();

    }
}
