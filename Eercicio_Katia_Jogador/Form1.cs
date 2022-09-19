using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eercicio_Katia_Jogador
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Jogador obj;
		Jogador[] v = new Jogador[10];
		int i = 0;

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnGravar_Click(object sender, EventArgs e)
		{
			if (i < 10)
			{
				obj = new Jogador();
				obj.Nome = txtNome.Text;
				obj.Peso = double.Parse(txtPeso.Text);
				obj.Altura = double.Parse(txtAltura.Text);
				obj.Idade = int.Parse(txtIdade.Text);
				obj.Time = txtTime.Text;
				obj.Numero_Camisa = int.Parse(txtNumCamisa.Text);
				v[i] = obj;
				i++;
			}
			else
			{
				MessageBox.Show("Sem Gravação!!");
			}

		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			for (int j = 0; j < 10; j++)
			{
				if (v[j].Nome.Equals(txtNome.Text))
				{
					txtPeso.Text = v[j].Peso.ToString();
					txtAltura.Text = v[j].Altura.ToString();
					txtIdade.Text = v[j].Idade.ToString();
					txtTime.Text = v[j].Time.ToString();
					txtNumCamisa.Text = v[j].Numero_Camisa.ToString();

					j = 9;
				}
				else
				{
					if (j == 9) MessageBox.Show("Jogador Inexistente!");
				}
			}
		}
	}
	}
