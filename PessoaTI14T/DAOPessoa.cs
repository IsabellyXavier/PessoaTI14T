using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PessoaTI14T
{
    class DAOPessoa
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public string resultado;
        public DAOPessoa()
        {
            conexao = new MySqlConnection("server=localhost;Database=NovoPessoa;Uid=root;password=");
            try
            {

                conexao.Open();//tentando conectar ao BD
                MessageBox.Show("Conectado com Sucesso!");

            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu Errado!\n\n" + erro);// enviando a mensagem de erro aos usuarios.
                conexao.Close();// fechando a conexao com o banco de dados
            }


        }// fim do Construtor.

//_________________________________________________________________________________________________________________________________________________

        public void Inserir(long cpf, string nome, string telefone, string endereco)
        {
            try
            {

                //Preparar os dados para inserir no banco.
                dados = "('','" + cpf + "','" + nome + "','" + telefone + "','" + endereco + "')";
                comando = "Insert into PessoaTI14T(codigo,cpf,nome,telefone,endereco) values " + dados;

                //executar o comando na base de dados.
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultado + "linha afetada!");

            }
            catch (Exception erro)
            {

                MessageBox.Show("Algo deu Errado!\n\n" + erro);// enviando a mensagem de erro aos usuarios.

            }
        }// fim do metodo inserir.



    }// fim da classe

}// fim do projeto
