using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula07fase2Funcoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        //Minhas funçoes
        void mostrarMensagem()
        {
            MessageBox.Show("ola seja bem-vindo");
            MessageBox.Show("lalala");
          
        }
        void mostrarNome()
        {
            string nome = textBox1.Text;
            MessageBox.Show("ola " +nome);
      
        }

        Double converteDinheiro(Label dindin)
        {
            double dinheiro = double.Parse(dindin.Text.Replace("R$",""));//transforma label1 label2 label3...etc em dindin e acha na label a escrita itada (R$) e substitui ela por nada(VAZIO)
            return dinheiro;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarMensagem();
            mostrarNome();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarMensagem();
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox2.Text);
           double dinheiro=converteDinheiro(lblValor);
            double soma = valor + dinheiro;
            lblValor.Text = "R$"+soma;

        }
    }
}
