using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolGame
{
    public class Goblin:Personaggio
    {
        public void Attaca(Cavaliere bersaglio, int puntiAttacco)
        {
            bersaglio.PuntiSalute -= this.puntiAttacco;
        }
    }
}
