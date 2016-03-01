using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoGlobo.Dominio
{
    public abstract class Pessoa
    {


        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Idade { get; set; }
        public string Cpf { get; set; }



        public  Pessoa(int Id, string Nome, DateTime Idade, string Cpf) {

            this.Cpf = Cpf;
            this.Id = Id;
            this.Nome = Nome;
            this.Idade = Idade;


            
        }
        public Pessoa() {
        }

    }
}
