using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_ProjetoModelo_12H_2026_27
{
    public class c_utils
    {
        /// <summary>
        /// Verifica se existe a pasta indicada dentro da pasta AppData\Local
        /// caso não exista cria a pasta
        /// </summary>
        /// <param name="nomePasta">Nome da pasta a criar/verificar</param>
        /// <returns>Caminho completo para a pasta</returns>
        public static string pastaPrograma(string nomePasta)
        {
            string pastainicial = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string caminhocompleto = pastainicial + "\\" + nomePasta;

            if (System.IO.Directory.Exists(caminhocompleto)==false)
                System.IO.Directory.CreateDirectory(caminhocompleto);

            return caminhocompleto;
        }
    }
}
