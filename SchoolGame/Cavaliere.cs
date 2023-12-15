using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolGame
{
    public class Cavaliere:Personaggio
    {

        public void Attacca( Personaggio bersaglio,int puntiAttacco)
        {
            bersaglio.PuntiSalute -= puntiAttacco;
        }
    }
}
