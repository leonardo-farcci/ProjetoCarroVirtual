using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $safeprojectname$
{
    class Pickup:Carro
    {
        private bool cacamba;
        private float litros;
        private string tipoCabine;
        private string tipoTracao;

        public Pickup() : base() { }

        public Pickup(string marca, string modelo, int ano, bool cacamba, float litros)
            : base(marca, modelo, ano)
        {
            this.cacamba = cacamba;
            this.litros = litros;
        }

        public string TipoTracao
        {
            get { return tipoTracao; }
            set { tipoTracao = value; }
        }

        public string TipoCabine
        {
            get { return tipoCabine; }
            set { tipoCabine = value; }
        }

        public bool Cacamba
        {
            set { cacamba = value; }
            get { return cacamba; }
        }

        public float Litros
        {
            set { litros = value; }
            get { return litros; }
        }

        public string estadoCacamba()
        {
            if (cacamba == true)
                return "Ocupada";
            else
                return "Vazia";
        }

        public override void Acelerar(int i)
        {
            base.Acelerar(i+2);
        }

        public override void Frear(int i)
        {
            base.Frear(i + 2);
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nA cacamba esta: " + estadoCacamba()
                + "\nCapacidade em litros: " + litros
				+ "\nCabine: " + TipoCabine
				+ "\nTração: " + TipoTracao;
        }
    }
}
