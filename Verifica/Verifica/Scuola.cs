using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
     public class Scuola
    {
        private string Nome {  get; set; }
        private string Indirizzo { get; set; }

        private string OrarioApertura { get; set; }
        private string OrarioChiusura { get; set; }
        public List<Alunno> ElencoAlunni {  get; set; }

        public Scuola(string nome, string indirizzo, string orarioApertura, string orarioChiusura, List<Alunno> elencoAlunni)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            ElencoAlunni = elencoAlunni;
        }
    }
}
