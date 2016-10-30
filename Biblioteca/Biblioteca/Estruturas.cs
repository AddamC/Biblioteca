using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;


namespace Biblioteca
{
    public class Estruturas : Paredes
    {

        public void fazerAuditorio()
        {
            
        }

        public void fazerRecepcao() //pular distancia do jardim
        {
            //   fazerParede(0, 100, 0, 550, 0);
            //   fazerParede(0, 100, 0, 0, 0, 550);
            //   fazerParede(0, 100, 550, 0, 0, 550);

            

        }

        public void fazerSaguao() //pular distancia do jardim
        {

            fazerParede(0, 100, 2230, 1680, 0);
            fazerParede(0, 100, 3910, 0, 0, 1680);
            fazerParede(0, 100, 2230, 1680, 1680);
            fazerParede(0, 100, 2230, 0, 0, 550);
            fazerParede(0, 100, 2230, 0, 1100, 580);


        }
        public void fazerTV()
        {

        }

        public void fazerFotografia()
        {

           // fazerParede(0, alturaFotografia, 0, comprimentoEstudio, 0);
           // fazerParede(0, alturaFotografia, 0, comprimentoEstudio, 1280);
           //// fazerParede(0, 100, 0, 645, 200);
           //// fazerParede(0, 100, 645, 0, 0, 200);
           // fazerParede(0, alturaFotografia, 0, 0, 0, larguraEstudio);
           // fazerParede(0, alturaFotografia, 1280, 0, 0, larguraEstudio);

        }

        


    }
}
