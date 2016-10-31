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
        int comprimentoEstudioFotografia = 880;
        int larguraEstudioFotografia = 1065;

        int comprimentoEstudio = 320;
        int larguraEstudio = 185;

        public void fazerAuditorio()
        {
        }

        public void fazerRecepcao() //pular distancia do jardim
        {

            GL.Color3(Color.Blue);
            paredeBuraco(0, altura, 0, 0, 0, 1683, 0, 270, 0, 0, 1179, recepCompr - 435);
            GL.Color3(Color.Gray);
            fazerParede(0, altura, 0, recepLarg, 0, 0);

            fazerParede(0, altura, 0, recepLarg, recepCompr, 0);
            GL.Color3(Color.Red);
            fazerParede(0, altura, 0, largBanheiro, recepCompr - 435, 0);
            fazerParede(0, altura, 100 + largBanheiro2, largBanheiro, recepCompr - 435, 0);

            GL.Color3(Color.Green);
            fazerParede(0, altura, 100 + largBanheiro2, 0, recepCompr - 435, 435);
            fazerParede(0, altura, 200 + 2 * largBanheiro2, 0, recepCompr - 435, 435);

            GL.Color3(Color.Gray);
            fazerParede(0, altura, 100, largBanheiro2, recepCompr - 315, 0);
            fazerParede(0, altura, 200 + largBanheiro2, largBanheiro2, recepCompr - 315, 0);

            fazerParede(0, altura, recepLarg, 0, 0, 620);
            fazerParede(0, altura, recepLarg, 0, recepCompr, -620);
        }
        public void fazerSaguao() //pular distancia do jardim
        {
            fazerParede(0, altura, 2430, 1680, 0);
            fazerParede(0, altura, 4110, 0, 0, 1680);
            fazerParede(0, altura, 2430, 1680, 1680);
            fazerParede(0, altura, 2430, 0, 0, 570);
            fazerParede(0, altura, 2430, 0, 1680, -570);
        }
        public void fazerTV()
        {

        }

        public void fazerFotografia()
        {
            GL.Color3(Color.Red);
            fazerParede(0, alturaFotografia, 1350, comprimentoEstudioFotografia, 2945);
            fazerParede(0, alturaFotografia, 1350, -400, 2945);
            fazerParede(0, alturaFotografia, 1350, comprimentoEstudioFotografia, 1880);
            fazerParede(0, alturaFotografia, 1350, -400, 1880);
            GL.Color3(Color.Blue);
            fazerParede(0, altura, 950, 0, 1980, larguraEstudioFotografia - 100);
            fazerParede(0, alturaFotografia, 1350 + comprimentoEstudioFotografia, 0, 1880, larguraEstudioFotografia);

            // Parede com Buraco
            GL.Color3(Color.Yellow);

            fazerParede(0, altura, 1350, 0, 1980, larguraEstudioFotografia-100);

            //Estudio//
            GL.Color3(Color.Green);
            fazerParede(0, alturaFotografia, 1150, 130, 2040);
            fazerParede(0, altura, 1150, 0 , 2040, 320);
            fazerParede(0, altura, 1150, 200, 2360);
            //Chão // 
            GL.Color3(Color.Purple);
            fazerChao(0, 0, 1350, comprimentoEstudioFotografia, 1880, larguraEstudioFotografia);
            GL.Color3(Color.Pink);
            fazerChao(0 , 0 , 950 , comprimentoEstudioFotografia , 1350 , larguraEstudioFotografia);
        }
    }
}
