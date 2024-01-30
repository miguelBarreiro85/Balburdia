using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balburdia
{
    public partial class Form1 : Form
    {
        BindingList<Coisa> listaCoisas = new BindingList<Coisa>();
        public Form1()
        {
            InitializeComponent();
            listBoxBalburdia.DataSource = listaCoisas;
        }

        private void buttonAddNome_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Digite um nome");
                return;
            }
            listBoxNomes.Items.Add(textBoxNome.Text);
        }

        private void buttonBaralhar_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            listaCoisas.Clear();

            for (int i=0; i<numericUpDownIteracoes.Value;i++)
            {
                int k = rng.Next(listBoxNomes.Items.Count);
                listaCoisas.Add(new Coisa(listBoxNomes.Items[k].ToString()));
            }
            //shuffle listaCoisas
            
            int n = listaCoisas.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Coisa value = listaCoisas[k];
                listaCoisas[k] = listaCoisas[n];
                listaCoisas[n] = value;
            }
        }

        private void buttonAddValues_Click(object sender, EventArgs e)
        {
            listaCoisas[listBoxBalburdia.SelectedIndex].inventarValor();
        }
    }
}
