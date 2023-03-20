using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_OO1
{
    internal class Pessoa
    {
        string _nome;

        public int _idade { get; }

        public Pessoa(string nome) 
        {
            this._nome = nome;
        }

        public Pessoa() 
        {
            this._nome = "john doe";
            this._idade = 0;
            Console.WriteLine("A pessoa nasceu!!!");
        }

        public string getNome()
        {
            return this._nome;
        }

        public void setNome(string nome) 
        {
            this._nome = nome;
        }
    }
}
