using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    public class Alunno
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public string CittaResidenza { get; set; }

        public Alunno(string Nome, string Cognome, int Eta, string CittaResidenza)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Eta = Eta;
            this.CittaResidenza = CittaResidenza;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Cognome:{Cognome}, Eta:{Eta}, Citta:{CittaResidenza}";
        }
        public string Classe()
        {
            return Eta < 16 ? "biennio" : "triennio";
        }

    }
    
}
