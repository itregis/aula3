using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsoleApplication
{
    class Cliente
    {
        private String nome;

        private long cpf;

        private char sexo;

        private int idade;

        private long telefone;

        private String endereco;

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public long Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }


        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
