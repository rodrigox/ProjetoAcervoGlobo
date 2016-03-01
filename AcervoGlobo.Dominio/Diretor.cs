using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoGlobo.Dominio
{
   public class Diretor : Pessoa
    {

        public string RegistroDirecao { get; set; }
        public List<Teledramaturgia> Teledramaturgia { get; set; }

        public Diretor() : base() {
        }

        public Diretor(int Id, string Nome, DateTime Idade, string Cpf,  string registroDirecao, Teledramaturgia teledramaturgia): base( Id,  Nome,  Idade,  Cpf) {

            this.Id = Id;
            this.Nome = Nome;
            this.RegistroDirecao = registroDirecao;
            this.Teledramaturgia = Teledramaturgia;
            this.Cpf = Cpf;
           
        }
    }
}
