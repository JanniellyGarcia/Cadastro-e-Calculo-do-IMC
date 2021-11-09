using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcAtividade.Models
{
    class Pessoa
    {
        public string name { get; set; }
        public double weight { get; set; }
        public double height { get; set; }
        public double imc { get; set; }

        public Pessoa(string nome, double peso, double altura, double iMc)
        {
            this.name = nome;
            this.weight = peso;
            this.height = altura;
            this.imc = iMc;
        }
    }
   
}
