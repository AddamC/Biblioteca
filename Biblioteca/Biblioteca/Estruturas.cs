using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Biblioteca
{
    public class Estruturas : Paredes
    {

        int alturaFotografia = 100;
        int comprimentoEstudioFotografia = 1280;
        int larguraEstudioFotografia = 1065;

        int comprimentoEstudio = 320;
        int larguraEstudio = 185;

       

        
        public void fazerAuditorio()
        {
            
        }

        public void fazerRecepcao() //pular distancia do jardim
        {
           // fazerParede(0, 100, 0, 645, 0);
        }
        public void fazerSaguao() //pular distancia do jardim
        { }
        public void fazerTV() {}

        public void fazerBanheiros() {}

        public void fazerFotografia()
        {

            //Estúdio Fotográfia//

            GL.Color3(Color.Red); 
             fazerParede(0, alturaFotografia, 0, comprimentoEstudioFotografia, 0);
             fazerParede(0, alturaFotografia, 0, comprimentoEstudioFotografia, 1065);
            GL.Color3(Color.Blue);
            fazerParede(0, alturaFotografia, 1280, 0, 0, larguraEstudioFotografia);

            // Parede com Buraco
            GL.Color3(Color.Yellow);

            fazerParede(0, 400, 0, 0, 140, 925);

            fazerParede(300, 400, 0, 0, 0, 160);

            GL.Color3(Color.Chocolate);
            fazerChao2(0, 10, 0, 1280, 0, 1065);


            /////////////-------------------/////////////////////

            //Estudio//
            GL.Color3(Color.Green);
            fazerParede(0, alturaFotografia, -190, 0, 140, comprimentoEstudio);
            fazerParede(0, alturaFotografia, -6, 0, 140, comprimentoEstudio);
            fazerParede(0, alturaFotografia, -190, larguraEstudio, 460);

            //Parede com Buraco
            GL.Color3(Color.Blue);
            fazerParede(0, 400, -190, 50, 140);
            fazerParede(300, 400, -140, 140, 140);


            GL.Color3(Color.Purple);
            fazerChao2(10, 10, 0, -190, 140,320);

            /////////////-------------------/////////////////////

            //Laboratorio de Fotografia
            GL.Color3(Color.Gold);
            fazerParede(0, alturaFotografia, 0, -400, 0);
            fazerParede(0, alturaFotografia, -400, 0, 140, 925);
            fazerParede(0, alturaFotografia, -400, 400, 1065);

            //Parede com buraco
            GL.Color3(Color.Black);
            fazerParede(0, 400, -400, 70, 340);
            GL.Color3(Color.Purple);
            fazerParede(300, 400, -330, 140, 340);

            //fazerParede()




            // paredeBuraco(0, 300, 0, 300, 0, 100,
            //                        0, 220, 20, 220, 50, 70);

            // paredeBuraco(0, 300, 50, 0, 0, -1000,  //DA ERRO QUANDO VARIA NO EIXO X
            //              0, 270, 50, 0, -500, -700);

            // paredeBuraco(0, 300, 0, 0, 0, -1000,  //DA ERRO QUANDO VARIA NO EIXO X
            //             0, 270, 0, 0, -500, -700);

            //fazerParede(0, alturaFotografia, larguraEstudio, 0, 0, 1060);
            //Fazer Parede
            //1° Utilizado
            // 2° Altura no Verde
            // 3° Posição na direção vermelho
            // 4° Tamanho na direção do vermelho
            //5° Posição na direção do azul
            // fazerChao2(10, 10, 0, 500, 0, 500);



            /// Fazer Chao
            //1° Inclinação direita pra esquerda
            //2° Inclinação esquerda pra direita
            //3° Posição X no vermelho
            //4° Tamanho que cresce para o vermelho
            //5° Posição no Z azul
            //6° Tamanho que cresce no azul
        }
    }
}
