using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_ProjetoModelo_12H_2026_27
{
    /// <summary>
    /// Responsável por estabelecer a ligação à base de dados
    /// Verificar se a bd existe e se não existir criar a bd e as tabelas
    /// </summary>
    public class c_basedados
    {
        string strligacao;
        string NomeBD;
        string caminhoBD;
        SqlConnection ligacaoBD;

        public c_basedados(string NomeBD)
        {
            this.NomeBD= NomeBD;
            //ler a string de ligação à bd
            strligacao = ConfigurationManager.ConnectionStrings["sql"].ToString();
            //verificar se a pasta do programa existe
            caminhoBD = c_utils.pastaPrograma("M17A_12H_Projeto");
            //caminho completo com bd
            caminhoBD = caminhoBD + "\\" + NomeBD + ".mdf";
            //verificar se a bd existe
            if (System.IO.File.Exists(caminhoBD)==false)
            {
                //criar a bd
                CriarBD();
            }
        }

        private void CriarBD()
        {
            //Ligação ao servidor
            ligacaoBD = new SqlConnection(strligacao);
            ligacaoBD.Open();
            //verificar se a bd já existe no catálogo do sql server
            string sql = $@"
                            IF EXISTS(SELECT * FROM master.sys.databases 
                                        WHERE name='{this.NomeBD}')
                            BEGIN
                                USE master;
                                EXEC sp_detach_db {this.NomeBD};
                            END
                            ";
            SqlCommand comando = new SqlCommand(sql,ligacaoBD);
            comando.ExecuteNonQuery();
            //criar a bd
            sql = $@"CREATE DATABASE {this.NomeBD} ON PRIMARY 
                        (NAME={this.NomeBD},FILENAME='{this.caminhoBD}')";
            comando = new SqlCommand(sql, ligacaoBD);
            comando.ExecuteNonQuery();
            CriarTabelas();
        }
        void CriarTabelas()
        {
            //ligar à base de dados criada
            ligacaoBD.ChangeDatabase(this.NomeBD);
            //criar tabela livros
            string sql = @"
                IF (OBJECT_ID('Livros') IS NULL)
                BEGIN
                    CREATE TABLE Livros(
                        id INT IDENTITY PRIMARY KEY,
                        ISBN VARCHAR(20) NOT NULL,
                        Titulo VARCHAR(30) NOT NULL,
                        Autor VARCHAR(40) NOT NULL,
                        Tipo VARCHAR(20) NOT NULL,
                        DataEntrada DATE DEFAULT (GETDATE()),
                        Estado VARCHAR(50) DEFAULT ('Bom Estado'),
                        Disponivel BIT DEFAULT (1)
                    )
                END
            ";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
            comando.ExecuteNonQuery();
            comando.Dispose();
            //criar leitores
            //criar empréstimos
        }
    }
}
