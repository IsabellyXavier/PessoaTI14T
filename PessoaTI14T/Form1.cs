using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoaTI14T
{
    public partial class Form1 : Form
    {
        DAOPessoa pessoa;
        public Form1()
        {
            InitializeComponent();
            pessoa = new DAOPessoa();// abrindo a conexao com o banco de dados.

        }// fim do construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {

            // int codigo = Convert.ToInt32(textBox1.Text);//coletar o dado do campo codigo.
            
            string tratamentoCPF = maskedTextBox1.Text.Replace(",", "");
            tratamentoCPF = tratamentoCPF.Replace("-", "");

            long cpf = Convert.ToInt64(tratamentoCPF);//coletar o dado do campo CPF.
            string nome = textBox2.Text; //coletar o dado do campo nome.
            string telefone = maskedTextBox2.Text;//coletar o dado do campo telefone.
            string endereco = textBox4.Text;//coletar o dado do campo emdereco.
            // chamar o metodo inserir craido na classe DAOPessoa.
            pessoa.Inserir(cpf, nome, telefone, endereco);// inserir no banco os dados do formulário.
                       
            }
            catch(Exception erro)
            {
                MessageBox.Show("" + erro);
            }


        }//fim do botão cadastrar

        private void Consultar_Click(object sender, EventArgs e)
        {

        }//fim do botão consultar

        private void Atualizar_Click(object sender, EventArgs e)
        {

        }//fim do botão Atualizar

        private void Excluir_Click(object sender, EventArgs e)
        {

        }//fim do botão Excluir

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//textBox de codigo;

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// maskedTextBox do CPF;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// textBox do Nome;

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// maskedTextBox do Telefone;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }// textBox de endereco;

    }//fim da classe

}//fim do projeto
