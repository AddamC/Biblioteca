using System;
using System.Collections.Generic;
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
        float recepCompr = 1683;
        float recepLarg = 2230;
        float altura = 300;
        float largBanheiro = 277;
        float largBanheiro2 = 267;

        //var de fotografia
        int alturaFotografia = 100;
        int comprimentoEstudio = 1280;
        int larguraEstudio = 1280;


        public void fazerAuditorio()
        {
            paredeBuraco(0, 300, 0, 300, 0, 2000,
                                    0, 220, 0, 300, 50, 70);
        }

        public void fazerRecepcao() //pular distancia do jardim
        {
            fazerParede(0, 100, 0, 645, 0);
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

        }

        


    }
}
