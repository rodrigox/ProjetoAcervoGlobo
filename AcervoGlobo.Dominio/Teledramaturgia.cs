using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoGlobo.Dominio
{
    /// <summary>
    /// Classe com os atributos da obra (novela / cinema)
    /// </summary>
   public  class Teledramaturgia
    {

        public long Id { get; set; }
        public string Titulo { get; set; }
        public virtual List<Ator> Ator { get; set; }
        public Genero eGenero { get; set; }
        public DateTime AnoLancamento { get; set; }
        public Diretor Diretor { get; set; }
        


    }
}
