using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $safeprojectname$
{
    class Carro
    {
        private string marca;
        private string modelo;
        private int ano;
        private int velocidadeAtual;
        private bool ligado;

        public Carro() { }

        public Carro(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.ligado = false;
        }

        public bool Ligado
        {
            set { ligado = value; }
            get { return ligado; }
        }

        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }

        public string Modelo
        {
            set { modelo = value; }
            get { return modelo; }
        }

        public int Ano
        {
            set { ano = value; }
            get { return ano; }
        }

        public int VelocidadeAtual
        {
            set { velocidadeAtual = value; }
            get { return velocidadeAtual; }
        }

        public virtual void Acelerar(int i)
        {
            velocidadeAtual += i;
        }

        public virtual void Frear(int i)
        {
            velocidadeAtual -= i;
        }

        public override string ToString()
        {
            return "Marca: " + marca
                 + "\nModelo: " + modelo
                 + "\nAno de fab.: " + ano
                 + "\nVelocidade : " + velocidadeAtual;
                
        }

        public void Ligar()
        {
            this.Ligado = true;
            this.velocidadeAtual = 0;
        }

        public void Desligar()
        {
            this.Ligado = false;
            this.velocidadeAtual = 0;
        }
    }
}
