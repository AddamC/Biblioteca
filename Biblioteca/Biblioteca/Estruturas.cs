using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public class Estruturas : Paredes
    {

        public void fazerAuditorio()
        {
            
        }

        public void fazerRecepcao() //pular distancia do jardim
        {
            fazerParede(0, 100, 0, 645, 0);
        }
        public void fazerSaguao() //pular distancia do jardim
        {

        }
        public void fazerTV()
        {

        }

        public void fazerFotografia()
        {

        }
    }
}
