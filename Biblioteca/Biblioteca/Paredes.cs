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
    class Paredes
    {
        public void fazerParede(float hi, float hf, float xi,
                                 float xf, float yi, float yf)
        {
            GL.Color3(Color.Gray);

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(xi, yi, hi);
            GL.Vertex3(xi, yi, hf);
            GL.Vertex3(xi + xf, yi + yf, hf);
            GL.Vertex3(xi + xf, yi + yf, hi);
            GL.End();
        }
        
        public void fazerChao(float hi, float hf, float xi,
                              float xf, float yi, float yf)
        {
            GL.Color3(Color.Gray);

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(xi, yi, hi);
            GL.Vertex3(xi, yi+yf, hf);
            GL.Vertex3(xi + xf, yi + yf, hf);
            GL.Vertex3(xi + xf, yi, hi);
            GL.End();
        }

        public void fazerChao2(float hi, float hf, float xi,
                              float xf, float yi, float yf)
        {
            GL.Color3(Color.Gray);

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(xi, yi, hi);
            GL.Vertex3(xi+xf, yi, hf);
            GL.Vertex3(xi+xf, yi + yf, hf);
            GL.Vertex3(xi, yi + yf, hi);
            GL.End();
        }

        public void fazerParede(float hi, float hf, float xi,
                                 float xf, float posY) //Apenas criar a parede indo no X
        {
            GL.Color3(Color.Gray);

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(xi, posY, hi);
            GL.Vertex3(xi, posY, hf);
            GL.Vertex3(xi + xf, posY, hf);
            GL.Vertex3(xi + xf, posY, hi);
            GL.End();
        }
        
        public void paredeBuraco(float hi, float hf, float xi,
                                 float xf, float yi, float yf, 
                                 float buracoHi, float buracoHf,
                                 float buracoXi, float buracoXf,
                                 float buracoYi, float buracoYf)
        {

            GL.Begin(PrimitiveType.Quads);

            GL.Vertex3(xi, yi, hi);
            GL.Vertex3(xi, yi, buracoHi);
            GL.Vertex3(xi + xf, yi + yf, buracoHi);
            GL.Vertex3(xi + xf, yi + yf, hi);

            GL.Vertex3(xi, yi, buracoHf);
            GL.Vertex3(xi, yi, hf);
            GL.Vertex3(xi + xf, yi + yf, hf);
            GL.Vertex3(xi + xf, yi + yf, buracoHf);

            if (xi != xf) //cria na diagonal
            {
                buracoYi = yf * buracoXi / xf; //eq. para achar valor adequado do y do buraco
                buracoYf = yf * buracoXf / xf;

            }

            GL.Vertex3(xi, yi, buracoHi);
            GL.Vertex3(xi, yi, buracoHf);
            GL.Vertex3(xi + buracoXi, yi + buracoYi, buracoHf);
            GL.Vertex3(xi + buracoXi, yi + buracoYi, buracoHi);

            GL.Vertex3(buracoXf, buracoYf, buracoHi);
            GL.Vertex3(buracoXf, buracoYf, buracoHf);
            GL.Vertex3(xf, yf, buracoHf);
            GL.Vertex3(xf, yf, buracoHi);

            GL.End();
        }

        public void fazerEscada(int deg, float altura, float hf, float xi,
                              float xf, float yi, float yf)  //começando de cima para baixo
        {
            float alturaDeg;
            int cont;

            GL.Begin(PrimitiveType.Quads);
            for (cont = 0; cont < deg; cont++)
            {
                GL.Vertex3(xi + xf, yi + yf, altura);
                GL.Vertex3(xi + xf, yi, altura);
                GL.Vertex3(xi, yi, altura);
                GL.Vertex3(xi, yi + yf, altura);

                
                alturaDeg = altura - hf;

                GL.Vertex3(xi, yi, altura);
                GL.Vertex3(xi, yi + yf, altura);
                GL.Vertex3(xi, yi + yf, alturaDeg);
                GL.Vertex3(xi, yi, alturaDeg);

                altura = alturaDeg;
                xi -= xf;
            }

            GL.End();
        }
    }
}
