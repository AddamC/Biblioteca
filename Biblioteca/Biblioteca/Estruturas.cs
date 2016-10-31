﻿using System;
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
        float portaBanheiro = 115;
        float portaBanheiro2 = 130;
        float porta = 130;

        float recepCompr = 1680;
        float recepLarg = 2230;
        float altura = 300;
        float largBanheiro = 277;
        float largBanheiro2 = 193;
        float largSalaTec = 550;

        //var de fotografia
        int alturaFotografia = 100;
        int comprimentoEstudioFotografia = 1280;
        int larguraEstudioFotografia = 1065;

        int comprimentoEstudio = 320;
        int larguraEstudio = 185;

        //var TV
        int distRecepTV = 550;
        int tamMaiorTV = 1125;
        int tamMenorTV = 590;
        int tamProd = 550;

        public void fazerAuditorio()
        {
        }

        public void fazerRecepcao() //pular distancia do jardim
        {

            GL.Color3(Color.DarkSeaGreen);
            paredeBuraco(0, altura, 0, 0, 0, recepCompr,
                         0, 270, 0, 0, 801, recepCompr - 435);

            //fazerParede(270,300,0,0,0,recepCompr);
            //fazerParede(0, 270, 0, 0, 0, 801);
            //fazerParede(0, 270, 0, 0, recepCompr - 435, 435); 1245, 1680 - comprBuraco

            GL.Color4(0f, 0f, 0f, 0.6f);
            fazerParede(260, 270, 0, 0, 801, 445);
            fazerParede(0, 270, 0, 0, 801, 80);
            fazerParede(0, 270, 0, 0,1246-80,80); //1436 = buracoYf
            //paredeBuraco(0, 270, 0, 0, 801, 435,
            //             0, 260, 0, 0, 850, 435+50);

            GL.Color3(Color.Gray);
            fazerParede(0, altura, 0, recepLarg, 0, 0);

            fazerParede(0, altura, 0, recepLarg, recepCompr, 0);
            GL.Color3(Color.PaleVioletRed);
            fazerParede(0, altura, 0, largBanheiro - portaBanheiro, recepCompr - 435, 0);
            fazerParede(0, altura, portaBanheiro + largBanheiro2, largBanheiro - portaBanheiro, recepCompr - 435, 0);
            fazerParede(0, altura, 2 * portaBanheiro + 2 * largBanheiro2 + porta, largSalaTec - porta, recepCompr - 560, 0); //sala tecnica
            fazerParede(0, altura, 0, 550 - porta, 534, 0);
            fazerParede(0, 100, 550 + porta, 550 - porta, 534, 0); //balcao

            GL.Color3(Color.DarkGoldenrod);
            fazerParede(0, altura, portaBanheiro + largBanheiro2, 0, recepCompr - 435, 435);
            fazerParede(0, altura, 2 * portaBanheiro + 2 * largBanheiro2, 0, recepCompr - 560, 560);
            fazerParede(0, altura, 2 * portaBanheiro + 2 * largBanheiro2 + largSalaTec, 0, recepCompr - 560, 560 - porta);
            fazerParede(0, altura, 550, 0, 0, 534);
            fazerParede(0, 100, 1100, 0, 534, 550);

            GL.Color3(Color.DarkSlateBlue);
            fazerParede(0, altura, portaBanheiro, largBanheiro2, recepCompr - 315, 0); //banheiro 1
            fazerParede(0, altura, 2 * portaBanheiro + largBanheiro2, largBanheiro2, recepCompr - 315, 0); //banheiro 2
            fazerParede(0, altura, 2 * portaBanheiro + 2 * largBanheiro2, largSalaTec, recepCompr - 315, 0); //arquivo/sala técnica
            fazerParede(0, altura, 0, 550 - porta, 267, 0);

            //paredeBuraco(0, 300, 50, 0, 0, -1000,  //DA ERRO QUANDO VARIA NO EIXO X
            //             0, 270, 50, 0, -500, -700);

            //paredeBuraco(0, 300, 0, 0, 0, -1000,  //DA ERRO QUANDO VARIA NO EIXO X
            //             0, 270, 0, 0, -500, -700);

            GL.Color3(Color.Blue);
            //paredeBuraco(0, 300, 1400, 0, 0, -277, 0, 270, recepCompr, 0, -300, -300);

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
            GL.Color3(Color.Magenta);
            //         (hi,     hf,  xi,  xf, yi,   if)
            fazerParede(0, altura, -distRecepTV, 0, 800, tamMenorTV);//parede leste

            //parede norte
            fazerParede(0, 270, -distRecepTV, -45, 800);
            fazerParede(0, 270, -distRecepTV - 145, -tamMaiorTV - tamProd + 145, 800);
            fazerParede(270, altura, -distRecepTV, -tamMaiorTV, 800);//parte superior norte
            GL.Color3(Color.Magenta);
            fazerParede(270, altura, -distRecepTV - tamMaiorTV, -tamProd, 800, 0); //superior norte sala producao


            //chao
            GL.Color3(Color.Maroon);
            fazerChao(0, 0, -distRecepTV, -tamMaiorTV, 800, tamMenorTV);

            fazerParede(0, altura, -distRecepTV - tamMaiorTV, 0, 800, 385);//parede interior curta
            fazerParede(0, altura, -distRecepTV - tamMaiorTV - tamProd, 0, 800, tamMenorTV);//parede oeste
            GL.Color3(Color.Gray);
            fazerParede(0, altura, -distRecepTV, -tamMaiorTV, 800 + tamMenorTV); //parede sul
            fazerParede(0, altura, -distRecepTV - tamMaiorTV - 100, -tamProd + 100, 800 + tamMenorTV);
            fazerParede(0, altura, -distRecepTV - tamMaiorTV + 100, 0, 800 + tamMenorTV, -165);
            fazerParede(0, altura, -distRecepTV - tamMaiorTV - 100, 0, 800 + tamMenorTV, -165);
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
