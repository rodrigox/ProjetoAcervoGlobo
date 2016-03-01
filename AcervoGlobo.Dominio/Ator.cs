using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoGlobo.Dominio
{
    public class Ator : Pessoa
    {
        public string Papel { get; set; }

        public virtual List<Teledramaturgia> Teledramaturgia { get; set; }


        public Ator():base( ) {
        }
        public Ator(int Id, string Nome, DateTime Idade, string Cpf, string papel, List<Teledramaturgia> teledramaturgia) : base ( Id,  Nome,  Idade,  Cpf) {

            this.Id = Id;
            this.Nome = Nome;
            this.Papel = papel;
            this.Teledramaturgia = teledramaturgia;
            this.Cpf = Cpf;
            this.Papel = papel;


        }
    }
}
