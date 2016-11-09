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

        
        float portaBanheiro = 115;
        float portaBanheiro2 = 130;
        float porta = 130;

        float recepCompr = 1680;
        float recepLarg = 2230;
        float altura = 600;
        float largBanheiro = 277;
        float largBanheiro2 = 193;
        float largSalaTec = 550;

        //var de fotografia
        int alturaFotografia = 100;
        int comprimentoEstudioFotografia = 1280;
        int larguraEstudioFotografia = 1065;

        int comprimentoEstudio = 320;
        int larguraEstudio = 185;

        //var Anfiteatro
        int largAnfiteatro = 1100;
        int compAnfiteatro = 1940;
        int portaAnfiteadro = 210;
        int portAltura = 210;
        //

        //var TV
        int distRecepTV = 550;
        int tamMaiorTV = 1125;
        int tamMenorTV = 590;
        int tamProd = 550;



        public void fazerEntrada()
        {
            GL.Color3(Color.DimGray);
            fazerParede(0, altura, -850, 850, 534);

            
            fazerParede(270, altura, -850,0, 640, 160);//porta
            fazerParede(0, altura, -850, 0, 534, 125);//direita da porta

        }
        public void fazerAuditorio()//pular distancia corredor
        {
            GL.Color3(Color.SlateBlue);
            //parede + porta superior          
            fazerParede(0, altura, -2225, largAnfiteatro-661, 3090);//esquerda da porta
            fazerParede(270, altura, -2225, largAnfiteatro-201, 3090);//porta
            fazerParede(0, altura, -1546, largAnfiteatro-679, 3090);//direita da porta
            //
            GL.Color3(Color.PowderBlue);
            fazerParede(0, altura, -2225, largAnfiteatro, 1940);//inferior
            fazerParede(0, altura, -2225, 0, compAnfiteatro, 1150);//esquerda

            //parede interior traseira
           
            GL.Color3(Color.Black);
            //fazerParede(0, altura, -1325, -400, compAnfiteatro, 400);//teste de reta
            //GL.Color3(Color.Yellow);//teste
            fazerParede(0, altura, -2225, 140, compAnfiteatro + 400, -140);//esquerda
            fazerParede(0, altura, -1825, -140, compAnfiteatro, 140);

            /*/telhado Anfiteatro
            fazerChao(altura, altura, -1725, largAnfiteatro, 1882, largAnfiteatro);
            /*/

            GL.Color3(Color.Turquoise);
            //parede + porta direita
            fazerParede(0, altura, -1125, 0, compAnfiteatro, 255);//esquerda da porta
            fazerParede(270, altura, -1125 , 0, compAnfiteatro+255, 160); //porta
            fazerParede(0, altura, -1125, 0, compAnfiteatro+415, 735);//direita da porta
            //
            //degraus
            GL.Color3(Color.Black);
            fazerEscada(1, 10, -20, -1225, 100, 2680, 30);
            fazerEscada(1, 10, -20, -1575, 100, 3002, 30);
            //
            GL.Color3(Color.LightGray);
            fazerChao(0, 0, -2225, largAnfiteatro, 1940,largAnfiteatro+50);


        }

        public void fazerRecepcao() //pular distancia do jardim
        {

            GL.Color3(Color.DarkSeaGreen);
            paredeBuraco(0, altura, 0, 0, 0, recepCompr,
                         0, 400, 0, 0, 801, recepCompr - 435);

            //fazerParede(270,300,0,0,0,recepCompr);
            //fazerParede(0, 270, 0, 0, 0, 801);
            //fazerParede(0, 270, 0, 0, recepCompr - 435, 435); 1245, 1680 - comprBuraco

            GL.Color3(Color.Black);
            fazerParede(260, 270, 0, 0, 801, 445);
            GL.Color4(0.5f, 0.5f, 0.5f, 0.7f);
            fazerParede(270, 400, 0, 0, 801, 445);
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
            fazerParede(0, 300, 1365, 600, 534, 0); //parede depois do balcao no meio da recepção

            GL.Color3(Color.DarkGoldenrod);
            fazerParede(0, altura, portaBanheiro + largBanheiro2, 0, recepCompr - 435, 435);
            fazerParede(0, altura, 2 * portaBanheiro + 2 * largBanheiro2, 0, recepCompr - 560, 560);
            fazerParede(0, altura, 2 * portaBanheiro + 2 * largBanheiro2 + largSalaTec, 0, recepCompr - 560, 560 - porta);
            fazerParede(0, altura, 550, 0, 0, 534);
            fazerParede(0, 100, 1100, 0, 534, 550); //balcao

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
            GL.Color3(Color.Gray);
            fazerParede(0, altura, 2430, 1680, 0);
            fazerParede(0, altura, 4110, 0, 0, 1680);
            fazerParede(0, altura, 2430, 1680, 1680);
            fazerParede(0, altura, 2430, 0, 0, 570);
            fazerParede(0, altura, 2430, 0, 1680, -570);
        }
        public void fazerTV()
        {
            GL.Color3(Color.DodgerBlue);
            //         (hi,     hf,  xi,  xf, yi,   if)
            fazerParede(0, altura, -distRecepTV, 0, 800, tamMenorTV);//parede leste

            //parede sul
            fazerParede(0, 270, -distRecepTV, -45, 800);
            fazerParede(0, 270, -distRecepTV - 145, -tamMaiorTV - tamProd + 145, 800);
            fazerParede(270, altura, -distRecepTV, -tamMaiorTV, 800);//parte superior sul
            GL.Color3(Color.DodgerBlue);
            fazerParede(270, altura, -distRecepTV - tamMaiorTV, -tamProd, 800, 0); //superior sul sala producao


            //chao
            GL.Color3(Color.LawnGreen);
            fazerChao(0, 0, -distRecepTV, -tamMaiorTV, 800, tamMenorTV);
            GL.Color3(Color.LightSteelBlue);
            fazerParede(0, altura, -distRecepTV - tamMaiorTV, 0, 800, 385);//parede interior curta
            GL.Color3(Color.MediumAquamarine);
            fazerParede(0, altura, -distRecepTV - tamMaiorTV - tamProd, 0, 800, tamMenorTV);//parede oeste
            GL.Color3(Color.Gray);
            fazerParede(0, altura, -distRecepTV, -tamMaiorTV, 800 + tamMenorTV); //parede norte tv
            fazerParede(0, altura, -distRecepTV - tamMaiorTV - 100, -tamProd + 100, 800 + tamMenorTV);
            fazerParede(0, altura, -distRecepTV - tamMaiorTV + 100, 0, 800 + tamMenorTV, -165);
            fazerParede(0, altura, -distRecepTV - tamMaiorTV - 100, 0, 800 + tamMenorTV, -165);



            GL.Color3(Color.BlueViolet);
            fazerParede(0, altura, -distRecepTV - 575, -425, 800 + tamMenorTV + 120);
            fazerParede(0, altura, -distRecepTV - tamMaiorTV, -275, 800 + tamMenorTV + 120);
            fazerParede(0, altura, -distRecepTV - tamMaiorTV - tamProd, 0, 800+tamMenorTV,550);

            fazerParede(0, altura, -distRecepTV - 575, 0, 800 + tamMenorTV + 120, 550 - 120);
            fazerParede(0, altura, -distRecepTV - 575, -550, 800 + tamMenorTV + 550);

            fazerParede(0, altura, -distRecepTV - 575 - 550, 0, 800 + tamMenorTV + 550, -550 + 120);

            fazerParede(0, altura, -distRecepTV - 575 - 550, -tamProd, 800 + tamMenorTV+ 550 );


        }

        public void fazerFotografia()
        {
            GL.Color3(Color.LightGray);
            fazerParede(0, altura, 950, comprimentoEstudioFotografia, 2945);
            fazerParede(0, altura, 950, -400, 2945);
            fazerParede(0, altura, 950, comprimentoEstudioFotografia, 1880);
            fazerParede(0, altura, 950, -400, 1880);
            GL.Color3(Color.LightGray);
            fazerParede(0, altura, 950, 0, 1980, larguraEstudioFotografia - 100);
            fazerParede(0, altura, 950 + comprimentoEstudioFotografia, 0, 1880, larguraEstudioFotografia);

            // Parede com Buraco
            GL.Color3(Color.Yellow);

            fazerParede(0, altura, 950, 0, 1980, larguraEstudioFotografia-100);

            //Estudio//
            GL.Color3(Color.Green);
            fazerParede(0, altura, 750, 130, 2040);
            fazerParede(0, altura, 750, 0 , 2040, 320);
            fazerParede(0, altura, 750, 200, 2360);

        }

        public void FazerChaoComodos(int texGrama, int texPiso, int[] texPav)
        {
            //Recepção simples
            //GL.Color3(Color.LightGray);
            //fazerChao2(0, 0, 2230, 200, 570, 540);
            //fazerChao2(0, 0, 0, recepLarg, 0, 1680);
            
            //Recepção c/ textura
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPiso);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0/568);  GL.Vertex3(2230,1680,0);
            GL.TexCoord2(0/984, 0 / 568); GL.Vertex3(0, 1680, 0);
            GL.TexCoord2(0/984, 1f); GL.Vertex3(0, 0, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(2230, 0, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //Chao entre a recepção e o saguão
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPiso);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0 / 568); GL.Vertex3(2430, 1110, 0);
            GL.TexCoord2(0 / 984, 0 / 568); GL.Vertex3(2230, 1110, 0);
            GL.TexCoord2(0 / 984, 1f); GL.Vertex3(2230, 570, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(2430, 570, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //Chao do Saguão
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPiso);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0 / 568); GL.Vertex3(4110, 1680, 0);
            GL.TexCoord2(0 / 984, 0 / 568); GL.Vertex3(2430, 1680, 0);
            GL.TexCoord2(0 / 984, 1f); GL.Vertex3(2430, 0, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(4110, 0, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //Chao do Estudio
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPiso);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0 / 568); GL.Vertex3(950 + comprimentoEstudioFotografia , 2945, 0);
            GL.TexCoord2(0 / 984, 0 / 568); GL.Vertex3(950, 2945, 0);
            GL.TexCoord2(0 / 984, 1f); GL.Vertex3(950, 1880, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(950 + comprimentoEstudioFotografia, 1880, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //Chao do laboratório de fotografia
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPiso);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0 / 568); GL.Vertex3(950, 2945, 0);
            GL.TexCoord2(0 / 984, 0 / 568); GL.Vertex3(550, 2945, 0);
            GL.TexCoord2(0 / 984, 1f); GL.Vertex3(550, 1880, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(950, 1880, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //Corredor entre estudio e recepção
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPiso);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0 / 568); GL.Vertex3(1350, 1880, 0);
            GL.TexCoord2(0 / 984, 0 / 568); GL.Vertex3(0, 1880, 0);
            GL.TexCoord2(0 / 984, 1f); GL.Vertex3(0, 1680, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(1350, 1680, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //Jardim parte de baixo
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texGrama);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0f / 310f); GL.Vertex3(2430, 570, 0);
            GL.TexCoord2(0f / 550f, 0f / 310f); GL.Vertex3(2230, 570, 0);
            GL.TexCoord2(0f / 550f, 1f); GL.Vertex3(2230, 0, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(2430, 0, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);
            
            //Jardim parte de cima
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texGrama);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0f / 310f); GL.Vertex3(2430, 1680, 0);
            GL.TexCoord2(0f / 550f, 0f / 310f); GL.Vertex3(2230, 1680, 0);
            GL.TexCoord2(0f / 550f, 1f); GL.Vertex3(2230, 1110, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(2430, 1110, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);
            
            //Jardim parte de baixo da fotografia
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texGrama);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0f / 310f); GL.Vertex3(2430, 1880, 0);
            GL.TexCoord2(0f / 550f, 0f / 310f); GL.Vertex3(1350, 1880, 0);
            GL.TexCoord2(0f / 550f, 1f); GL.Vertex3(1350, 1680, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(2430, 1680, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            

            //Jardim parte de baixo da TV
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texGrama);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Polygon);
            GL.TexCoord2(1f, 0f / 310f); GL.Vertex3(-100, 450, 0);
            GL.TexCoord2(0f / 550f, 0f / 310f); GL.Vertex3(-1000, 450, 0);
            GL.TexCoord2(0f / 550f, 85f / 310f); GL.Vertex3(-1000, 300, 0);
            GL.TexCoord2(351f / 550f, 309f / 310f); GL.Vertex3(-200, -100, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(-100, -100, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //pavimento de fora 1
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[0]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0f / 1066f); GL.Vertex3(-950, 800, 0);
            GL.TexCoord2(0 / 1600, 0f / 1066f); GL.Vertex3(-1300, 800, 0);
            GL.TexCoord2(0/1600, 1f); GL.Vertex3(-1300, 535, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(-950, 535, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //2
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[0]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0f / 1066f); GL.Vertex3(-1300, 800, 0);
            GL.TexCoord2(0 / 1600, 0f / 1066f); GL.Vertex3(-2200, 800, 0);
            GL.TexCoord2(0 / 1600, 1f); GL.Vertex3(-2200, 750, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(-1300, 750, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //3
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[0]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0f / 1066f); GL.Vertex3(-0, 535, 0);
            GL.TexCoord2(200f / 1600f, 0f / 1066f); GL.Vertex3(-950, 535, 0);
            GL.TexCoord2(200f / 1600f, 400f / 1066f); GL.Vertex3(-950, 450, 0);
            GL.TexCoord2(1f, 400f / 1066f); GL.Vertex3(-0, 450, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);
            
            //4
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[0]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0f / 1066f); GL.Vertex3(-0, 535, 0);
            GL.TexCoord2(200f / 1600f, 0f / 1066f); GL.Vertex3(-200, 535, 0);
            GL.TexCoord2(200f / 1600f, 400f / 1066f); GL.Vertex3(-200, -100, 0);
            GL.TexCoord2(1f, 400f / 1066f); GL.Vertex3(-0, -100, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //5
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[1]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0f / 1066f); GL.Vertex3(850, 0, 0);
            GL.TexCoord2(200f / 1600f, 0f / 1066f); GL.Vertex3(0, 0, 0);
            GL.TexCoord2(200f / 1600f, 400f / 1066f); GL.Vertex3(0, -100, 0);
            GL.TexCoord2(1f, 400f / 1066f); GL.Vertex3(850, -100, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //Saguao
            GL.Color3(Color.LightGray);
            fazerChao2(0, 0, 2430, 1680, 0, 1680);
            //Fotografia
            GL.Color3(Color.LightGray);
            fazerChao(0, 0, 950, comprimentoEstudioFotografia, 1880, larguraEstudioFotografia);

            //chao corredor
            //GL.Color3(Color.LightGray);
            //fazerChao(0, 0, 0, -550, 800, 2000);
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPiso);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0f / 1066f); GL.Vertex3(0, 2800, 0);
            GL.TexCoord2(0 / 1600, 0f / 1066f); GL.Vertex3(-550, 2800, 0);
            GL.TexCoord2(0 / 1600, 1f); GL.Vertex3(-550, 800, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(0, 800, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //chao da entrada da biblioteca
            //GL.Color3(Color.Red);
            //fazerChao(0, 0, -850, 850, 534, 266);
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPiso);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0f / 1066f); GL.Vertex3(0, 534, 0);
            GL.TexCoord2(0 / 1600, 0f / 1066f); GL.Vertex3(-850, 534, 0);
            GL.TexCoord2(0 / 1600, 1f); GL.Vertex3(-850, 800, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(0, 800, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

        }

    }
}
