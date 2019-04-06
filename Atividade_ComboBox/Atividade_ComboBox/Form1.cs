using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbDiasSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            try
            {
                cmbEstado.Items.Clear();
                cmbEstado.Items.Add("Selecione...");

                cmbEstado.SelectedIndex = 0;

                string[] linhas = System.IO.File.ReadAllLines("F:\\Programação II - C#\\Atividade_ComboBox\\estado.txt");

                foreach (string l in linhas)
                {

                    //Console.WriteLine(l);

                    cmbEstado.Items.Add(l);
                }

            }

            catch (Exception ee)
            {

                MessageBox.Show("Falha na abertura do arquivo estado.txt"+ee.Message);

            }
        }

        private void btnDiasSemana_Click(object sender, EventArgs e)
        {
            try
            {

                cmbDiasSemana.Items.Add("Selecione...");

                cmbDiasSemana.SelectedIndex = 0;

                string[] linhas = System.IO.File.ReadAllLines("F:\\Programação II - C#\\Atividade_ComboBox\\diassemana.txt");

                foreach (string l in linhas)
                {

                    //Console.WriteLine(l);

                    cmbDiasSemana.Items.Add(l);
                }

            }

            catch (Exception ee)
            {

                MessageBox.Show("Falha na abertura do arquivo diassemana.txt");

            }
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            try
            {

                cmbProduto.Items.Add("Selecione...");

                cmbProduto.SelectedIndex = 0;

                string[] linhas = System.IO.File.ReadAllLines("F:\\Programação II - C#\\Atividade_ComboBox\\produtos.txt");

                foreach (string l in linhas)
                {

                    //Console.WriteLine(l);

                    cmbProduto.Items.Add(l);
                }

                cmbPreco.Items.Add("Selecione...");

                cmbPreco.SelectedIndex = 0;

                string[] linhas2 = System.IO.File.ReadAllLines("F:\\Programação II - C#\\Atividade_ComboBox\\preço.txt");

                foreach (string l2 in linhas2)
                {

                    //Console.WriteLine(l);

                    cmbPreco.Items.Add(l2);
                }

            }

            catch (Exception ee)
            {

                MessageBox.Show("Falha na abertura do arquivo produtos.txt");
                Console.WriteLine(ee);

            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("F");
            try
            {
                cmbPreco.SelectedIndex = cmbProduto.SelectedIndex;
            }
            catch (Exception ee)
            {
                //MessageBox.Show("Fooooo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmbPreco.Items.Clear();
                cmbProduto.Items.Clear();

                cmbProduto.Items.Add("Selecione...");

                cmbProduto.SelectedIndex = 0;

                string[] linhas = System.IO.File.ReadAllLines("F:\\Programação II - C#\\Atividade_ComboBox\\produtos.txt");

                

                cmbPreco.Items.Add("Selecione...");

                cmbPreco.SelectedIndex = 0;

                string[] linhas2 = System.IO.File.ReadAllLines("F:\\Programação II - C#\\Atividade_ComboBox\\preço.txt");

                foreach (string c in linhas2)
                {
                    Console.WriteLine(c);
                }

                Array.Sort(linhas2,linhas);
                foreach (string c in linhas2)
                {
                    Console.WriteLine(c);
                }
                
                foreach (string l2 in linhas2)
                {

                    //Console.WriteLine(l);

                    cmbPreco.Items.Add(l2);
                }

                foreach (string l in linhas)
                {

                    //Console.WriteLine(l);

                    cmbProduto.Items.Add(l);
                }

            }

            catch (Exception ee)
            {

                MessageBox.Show("Falha na abertura do arquivo produtos.txt");
                Console.WriteLine(ee);

            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //cmbCidade.SelectedIndex = cmbEstado.SelectedIndex;
                if (cmbEstado.SelectedIndex != 0)
                {
                    //MessageBox.Show("selecionou"+cmbEstado.SelectedItem.ToString());
                    cmbCidade.Items.Clear();
                    cmbCidade.Items.Add("Selecione...");

                    cmbCidade.SelectedIndex = 0;

                    string[] linhas2 = System.IO.File.ReadAllLines("F:\\Programação II - C#\\Atividade_ComboBox\\cidade.txt");
                    int linhaLida = 0;
                    foreach (string l2 in linhas2)
                    {
                        if(l2.Contains(cmbEstado.SelectedItem.ToString())){
                            //MessageBox.Show("ccccccc" + linhaLida);
                            linhaLida++;
                            cmbCidade.Items.Add(l2);
                        }
                        //Console.WriteLine(l2);
                    }

                }
            

            
                
                

            }
            catch (Exception ee)
            {
                //MessageBox.Show("Erro.");
            }
        }
    }
}
