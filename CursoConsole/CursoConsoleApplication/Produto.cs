using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsoleApplication
{
    class Produto
    {
        private int codigo;

        private String descricao;

        private float valor;

        private String fabricante;

        public String Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
