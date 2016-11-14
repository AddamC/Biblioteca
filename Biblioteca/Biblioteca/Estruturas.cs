using System;
using System.Collections.Generic;
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

            GL.Color3(Color.Blue);
            paredeBuraco(0, altura, 0, 1683, 0, 0, 0, 270, 1179, recepCompr - 435, 0, 0);
            GL.Color3(Color.Gray);
            fazerParede(0, altura, 0, 0, 0, -recepLarg);
            fazerParede(0, altura, recepCompr, 0, 0, -recepLarg);
            GL.Color3(Color.Red);
            fazerParede(0, altura, recepCompr - 435, 0, 0, -largBanheiro);
            fazerParede(0, altura, recepCompr - 435, 0, -100 - largBanheiro2, -650 - largBanheiro);
            GL.Color3(Color.Green);
            fazerParede(0, altura, recepCompr - 435, 435, -100 - largBanheiro2, 0);

            GL.Color3(Color.Gray);
            fazerParede(0, altura, recepCompr - 315, 0, -100, -largBanheiro2);
            fazerParede(0, altura, recepCompr - 315, 0, -800, -largBanheiro2);

            paredeBuraco(0, 300, 50, 0, 0, -1000,  //DA ERRO QUANDO VARIA NO EIXO X
                         0, 270, 50, 0, -500, -700);

            paredeBuraco(0, 300, 0, 0, 0, -1000,  //DA ERRO QUANDO VARIA NO EIXO X
                         0, 270, 0, 0, -500, -700);

            GL.Color3(Color.Blue);
            paredeBuraco(0, 300, 1400, 0, 0, -277, 0, 270, recepCompr, 0, -300, -300);
        }
        public void fazerSaguao() //pular distancia do jardim
        {

        }
        public void fazerTV()
        {

        }

        public void fazerFotografia() {
            //construcao.fazerEscada(12, 100, 200, 200, 200, 500, 500);
           fazerEscada(12, 100, 200, 200, 200, 500, 500);
        }
    }
}
