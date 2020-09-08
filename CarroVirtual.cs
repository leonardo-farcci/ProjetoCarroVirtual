using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class CarroVirtual : Form
    {
        Pickup carro;
        public CarroVirtual()
        {
            InitializeComponent();
        }

        private void CarroVirtual_Load(object sender, EventArgs e)
        {

        }

        private void grupoCadastrar_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            textoModelo.Clear();
            textoMarca.Clear();
            textoAno.Clear();
            comboCabine.SelectedIndex = -1;
            comboTracao.SelectedIndex = -1;
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            carro = new Pickup();

            carro.Marca = textoMarca.Text;
            carro.Modelo = textoModelo.Text;
            carro.Ano = int.Parse(textoAno.Text);

            carro.TipoCabine = comboCabine.SelectedItem.ToString();
            carro.TipoTracao = comboTracao.SelectedItem.ToString();

            this.LimparCampos();
        }

        private void comboCabine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botaoExibir_Click(object sender, EventArgs e)
        {
            textoExibir.Lines = carro.ToString().Split('\n');
        }

        private void botaoLigar_Click(object sender, EventArgs e)
        {
            if (!carro.Ligado)
            {
                MessageBox.Show("Carro Ligado!");
                carro.Ligar();
            }
        }

        private void botaoDesligar_Click(object sender, EventArgs e)
        {
            if (carro.Ligado)
            {
                MessageBox.Show("Carro Desligado");
                carro.Desligar();
            }
        }

        private void botaoAcelerar_Click(object sender, EventArgs e)
        {
            barraProgresso.Minimum = 0;
            barraProgresso.Maximum = 240;

            carro.Acelerar(100);

            barraProgresso.Value = carro.VelocidadeAtual;
        
            
        }

        private void barraProgresso_Click(object sender, EventArgs e)
        {
            barraProgresso.Value = carro.VelocidadeAtual;
        }

        private void botaoFreiar_Click(object sender, EventArgs e)
        {
            barraProgresso.Value = 0;
        }
    }
}
