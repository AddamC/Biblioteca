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
            fazerParede(0, altura/5, -850, 850, 534);
            fazerParede(0, altura / 5, -850, 850, 2800);

            fazerParede(270, altura, -850,0, 640, 160);//porta
            fazerParede(0, altura, -850, 0, 534, 125);//direita da porta
            GL.Color3(Color.LightPink);
            //fazerChao((450*altura/5)/534, 1000, -850, 850, 534, 500);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(0, 1); GL.Vertex3(0, 535, 120);
            GL.TexCoord2(0, 0); GL.Vertex3(0, 1200, 1000);
            GL.TexCoord2(1, 0); GL.Vertex3(-850, 1200, 1000);
            GL.TexCoord2(1, 1); GL.Vertex3(-850, 535, 120);

            GL.TexCoord2(0, 1); GL.Vertex3(0, 1200, 1000);
            GL.TexCoord2(0, 0); GL.Vertex3(0, 2800, 120);
            GL.TexCoord2(1, 0); GL.Vertex3(-850, 2800, 120);
            GL.TexCoord2(1, 1); GL.Vertex3(-850, 1200, 1000);




            GL.Color3(Color.Red);
            
            fazerChao(0, 0, -850, 850, 534, 266 );

            //GL.Color3(Color.Green);
            //fazerChao(0, 0, -1000, 1000, -100, 635);
        }
        public void fazerAuditorio(int texParede, int texPorta)//pular distancia corredor
        {
            GL.Color3(Color.WhiteSmoke);
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texParede);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(0, 5); GL.Vertex3(-2225, 1940, altura);
            GL.TexCoord2(0, 0); GL.Vertex3(-2225, 3090, altura);
            GL.TexCoord2(5, 0); GL.Vertex3(-1125, 3090, altura);
            GL.TexCoord2(5, 5); GL.Vertex3(-1125, 1940, altura);
            GL.End();
            GL.Disable(EnableCap.Blend); //FIM DA TEXTURA DO TETO
            GL.Color3(Color.SlateBlue);
            //parede + porta superior          
            paredeTextura(0, altura, -2225, largAnfiteatro - 661, 3090, texParede);//fazerParede(0, altura, -2225, largAnfiteatro-661, 3090);//esquerda da porta
            paredeTextura(270, altura, -2225, largAnfiteatro - 201, 3090, texParede);//fazerParede(270, altura, -2225, largAnfiteatro-201, 3090);//porta
            paredeTextura(0, altura, -1546, largAnfiteatro - 679, 3090, texParede);//fazerParede(0, altura, -1546, largAnfiteatro-679, 3090);//direita da porta
                        //Porta 1
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPorta);
            GL.Color3(Color.White);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(0, 0); GL.Vertex3(-1125, 2195, portAltura + 60);
            GL.TexCoord2(0, 1); GL.Vertex3(-1125, 2195, 0);
            GL.TexCoord2(1, 1); GL.Vertex3(-1125, 2355, 0);
            GL.TexCoord2(1, 0); GL.Vertex3(-1125, 2355, portAltura + 60);
            GL.End();
            GL.Disable(EnableCap.Blend);
            //
            GL.Color3(Color.PowderBlue);
            paredeTextura(0, altura, -2225, largAnfiteatro, 1940, texParede);//fazerParede(0, altura, -2225, largAnfiteatro, 1940);//inferior
            paredeTextura(0, altura, -2225, 0, compAnfiteatro, 1150, texParede);//fazerParede(0, altura, -2225, 0, compAnfiteatro, 1150);//esquerda

            //parede interior traseira

            GL.Color3(Color.Black);
            //fazerParede(0, altura, -1325, -400, compAnfiteatro, 400);//teste de reta
            //GL.Color3(Color.Yellow);//teste
            paredeTextura(0, altura, -2225, 140, compAnfiteatro + 400, -140, texParede);//fazerParede(0, altura, -2225, 140, compAnfiteatro + 400, -140);//esquerda
            paredeTextura(0, altura, -1825, -140, compAnfiteatro, 140, texParede);//fazerParede(0, altura, -1825, -140, compAnfiteatro, 140);

            /*/telhado Anfiteatro
            fazerChao(altura, altura, -1725, largAnfiteatro, 1882, largAnfiteatro);
            /*/

            GL.Color3(Color.Turquoise);
            //parede + porta direita
            paredeTextura(0, altura, -1125, 0, compAnfiteatro, 255, texParede);//fazerParede(0, altura, -1125, 0, compAnfiteatro, 255);//esquerda da porta
            paredeTextura(270, altura, -1125, 0, compAnfiteatro + 255, 160, texParede);//fazerParede(270, altura, -1125 , 0, compAnfiteatro+255, 160); //porta
            paredeTextura(0, altura, -1125, 0, compAnfiteatro + 415, 735, texParede);// fazerParede(0, altura, -1125, 0, compAnfiteatro+415, 735);//direita da porta
            //
            //degraus
            GL.Color3(Color.Black);
            fazerEscada(1, 10, -20, -1225, 100, 2680, 30);
            fazerEscada(1, 10, -20, -1575, 100, 3002, 30);
            

        }
        public void fazerRecep2(int texParede,int texPiso, int textPortaFoto)
        {
            //PAREDES
            GL.Color3(Color.DarkOrange);
            paredeTextura(0, altura, 0, 550, 1681,texParede);//fazerParede(0, altura , 0, 550, 1681);//parede baixo
            paredeTextura(0, altura, 200, 350, 2080, texParede); //fazerParede(0, altura , 200, 350, 2080); //aprece cima c/porta
            paredeTextura(400, altura, 0, 200, 2080, texParede);//fazerParede(400, altura, 0, 200, 2080);//porta para sala1
            paredeTextura(0, altura / 5, 550, 0, 1681, 200, texParede);//fazerParede(0, altura/5, 550, 0, 1681, 200);//rever Oque tem aqui
            paredeTextura(0, altura, 0, 0, 1881, 200, texParede);//fazerParede(0, altura, 0, 0, 1881, 200);//direita da porta
            paredeTextura(400, altura, 0, 0, 1681, 200, texParede);//fazerParede(400, altura, 0, 0, 1681, 200);//porta direita
            //
            //PORTAS
            portaTextura(0, 400, 0, 0, 1681, 200, textPortaFoto);
            //
            //TETO
            chaoTextura(altura, altura, 0, 550, 1681, 400, texParede);
            //
            //CHAO
            GL.Color3(Color.Transparent);
            chaoTextura(0, 0, 0, 550, 1880, 200, texPiso);
            //

        }
        public void fazerSala1(int texParede, int texPiso, int textPortaFoto)
        {
            //PAREDES
            GL.Color3(Color.IndianRed);
            paredeTextura(400, altura, 0, 200, 2081, texParede);//fazerParede(0, altura , 0, 550, 1681);//parede baixo
            paredeTextura(0, altura, 200, 350, 2081, texParede);//fazerParede(0, altura , 0, 550, 1681);//parede baixo
            paredeTextura(0, altura, 0, 350, 2480, texParede); //fazerParede(0, altura , 200, 350, 2080); //aprece cima c/porta
            paredeTextura(400, altura, 350, 200, 2480, texParede);//fazerParede(400, altura, 0, 200, 2080);//porta para sala1           
            paredeTextura(0, altura, 0, 0, 2081, 399, texParede);//fazerParede(0, altura, 0, 0, 1881, 200);//direita da porta  
            // 
            //PORTAS        
            portaTextura(0, 400, 350, 200, 2480, 0, textPortaFoto);
            portaTextura(0, 400, 0, 200, 2080, 0, textPortaFoto);
            //
            //TETO
            chaoTextura(altura, altura, 0, 550, 2080, 400, texParede);
            //
            //CHAO
            GL.Color3(Color.Transparent);
            chaoTextura(0, 0, 0, 550, 2080, 400, texPiso);
            //


        }


        public void fazerRecepcao(int texParede) //pular distancia do jardim
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

            fazerParede(0, 270, 0, 0, 1246 - 80, 80); //1436 = buracoYf


            GL.Color3(Color.LightBlue);
            paredeTextura(0, altura, 0, recepLarg, 0, 0, texParede);
            paredeTextura(0, altura, 0, recepLarg, recepCompr, 0, texParede);

            GL.Color3(Color.PaleVioletRed);
            paredeTextura(0, altura, 0, largBanheiro - portaBanheiro, recepCompr - 435, 0, texParede); //fazerParede(0, altura, 0, largBanheiro - portaBanheiro, recepCompr - 435, 0);


            paredeTextura(0, altura, portaBanheiro + largBanheiro2, largBanheiro - portaBanheiro, recepCompr - 435, 0, texParede); //fazerParede(0, altura, portaBanheiro + largBanheiro2, largBanheiro - portaBanheiro, recepCompr - 435, 0);

            paredeTextura(0, altura, 2 * portaBanheiro + 2 * largBanheiro2 + porta, largSalaTec - porta, recepCompr - 560, 0, texParede); //fazerParede(0, altura, 2 * portaBanheiro + 2 * largBanheiro2 + porta, largSalaTec - porta, recepCompr - 560, 0); //sala tecnica

            paredeTextura(0, altura, 0, 550 - porta, 534, 0, texParede); // fazerParede(0, altura, 0, 550 - porta, 534, 0);

            paredeTextura(0, 100, 550 + porta, 550 - porta, 534, 0, texParede); //fazerParede(0, 100, 550 + porta, 550 - porta, 534, 0); //balcao

            paredeTextura(0, 300, 1365, 600, 534, 0, texParede); //fazerParede(0, 300, 1365, 600, 534, 0); //parede depois do balcao no meio da recepção


            GL.Color3(Color.DarkGoldenrod);
            paredeTextura(0, altura, portaBanheiro + largBanheiro2, 0, recepCompr - 435, 435, texParede); // fazerParede(0, altura, portaBanheiro + largBanheiro2, 0, recepCompr - 435, 435);

            paredeTextura(0, altura, 2 * portaBanheiro + 2 * largBanheiro2, 0, recepCompr - 560, 560, texParede); //  fazerParede(0, altura, 2 * portaBanheiro + 2 * largBanheiro2, 0, recepCompr - 560, 560);

            paredeTextura(0, altura, 2 * portaBanheiro + 2 * largBanheiro2 + largSalaTec, 0, recepCompr - 560, 560 - porta,texParede); //  fazerParede(0, altura, 2 * portaBanheiro + 2 * largBanheiro2 + largSalaTec, 0, recepCompr - 560, 560 - porta);

            paredeTextura(0, altura, 550, 0, 0, 534,texParede); // fazerParede(0, altura, 550, 0, 0, 534);

            paredeTextura(0, 100, 1100, 0, 534, 550,texParede); //fazerParede(0, 100, 1100, 0, 534, 550); //balcao

            GL.Color3(Color.DarkSlateBlue);
            paredeTextura(0, altura, portaBanheiro, largBanheiro2, recepCompr - 315, 0,texParede); //fazerParede(0, altura, portaBanheiro, largBanheiro2, recepCompr - 315, 0); //banheiro 1
            paredeTextura(0, altura, 2 * portaBanheiro + largBanheiro2, largBanheiro2, recepCompr - 315, 0,texParede); //             fazerParede(0, altura, 2 * portaBanheiro + largBanheiro2, largBanheiro2, recepCompr - 315, 0); //banheiro 2

            paredeTextura(0, altura, 2 * portaBanheiro + 2 * largBanheiro2, largSalaTec, recepCompr - 315, 0,texParede); //  fazerParede(0, altura, 2 * portaBanheiro + 2 * largBanheiro2, largSalaTec, recepCompr - 315, 0); //arquivo/sala técnica

            paredeTextura(0, altura, 0, 550 - porta, 267, 0,texParede); //             fazerParede(0, altura, 0, 550 - porta, 267, 0);


            //paredeBuraco(0, 300, 50, 0, 0, -1000,  //DA ERRO QUANDO VARIA NO EIXO X
            //             0, 270, 50, 0, -500, -700);

            //paredeBuraco(0, 300, 0, 0, 0, -1000,  //DA ERRO QUANDO VARIA NO EIXO X
            //             0, 270, 0, 0, -500, -700);

            GL.Color3(Color.LightBlue);
            //paredeBuraco(0, 300, 1400, 0, 0, -277, 0, 270, recepCompr, 0, -300, -300);

            paredeTextura(0, altura, recepLarg, 0, 0, 620, texParede);
            paredeTextura(0, altura, recepLarg, 0, recepCompr, -620, texParede);
        }
        public void fazerSaguao(int texParede) //pular distancia do jardim
        {
            GL.Color3(Color.Gray);
            paredeTextura(0, altura, 2430, 1680, 0, texParede); // fazerParede(0, altura, 2430, 1680, 0);

            paredeTextura(0, altura, 4110, 0, 0, 1680, texParede); //  fazerParede(0, altura, 4110, 0, 0, 1680);

            paredeTextura(0, altura, 2430, 1680, 1680,texParede); //   fazerParede(0, altura, 2430, 1680, 1680);

            paredeTextura(0, altura, 2430, 0, 0, 570,texParede); //  fazerParede(0, altura, 2430, 0, 0, 570);

            paredeTextura(0, altura, 2430, 0, 1680, -570, texParede); //  fazerParede(0, altura, 2430, 0, 1680, -570);

        }
        public void fazerTV(int texParede, int texPorta)
        {
            GL.Color3(Color.DodgerBlue);
            //         (hi,     hf,  xi,  xf, yi,   if)
            paredeTextura(0, altura, -distRecepTV, 0, 800, tamMenorTV, texParede); //fazerParede(0, altura, -distRecepTV, 0, 800, tamMenorTV);//parede leste

            //parede sul
            paredeTextura(0, 270, -distRecepTV, -45, 800, texParede); //fazerParede(0, 270, -distRecepTV, -45, 800);
            paredeTextura(0, 270, -distRecepTV - 145, -tamMaiorTV - tamProd + 145, 800, texParede); //fazerParede(0, 270, -distRecepTV - 145, -tamMaiorTV - tamProd + 145, 800);
            paredeTextura(270, altura, -distRecepTV, -tamMaiorTV, 800, texParede); // fazerParede(270, altura, -distRecepTV, -tamMaiorTV, 800);//parte superior sul
            GL.Color3(Color.DodgerBlue);
            paredeTextura(270, altura, -distRecepTV - tamMaiorTV, -tamProd, 800, 0, texParede); //fazerParede(270, altura, -distRecepTV - tamMaiorTV, -tamProd, 800, 0); //superior sul sala producao

            GL.Color3(Color.LightSteelBlue);
            paredeTextura(0, altura, -distRecepTV - tamMaiorTV, 0, 800, 385, texParede); //fazerParede(0, altura, -distRecepTV - tamMaiorTV, 0, 800, 385);//parede interior curta
            GL.Color3(Color.MediumAquamarine);
            paredeTextura(0, altura, -distRecepTV - tamMaiorTV - tamProd, 0, 800, tamMenorTV, texParede); //fazerParede(0, altura, -distRecepTV - tamMaiorTV - tamProd, 0, 800, tamMenorTV);//parede oeste
            GL.Color3(Color.Gray);
            paredeTextura(0, altura, -distRecepTV, -tamMaiorTV, 800 + tamMenorTV, texParede);//fazerParede(0, altura, -distRecepTV, -tamMaiorTV, 800 + tamMenorTV); //parede norte tv
            paredeTextura(0, altura, -distRecepTV - tamMaiorTV - 100, -tamProd + 100, 800 + tamMenorTV, texParede); //fazerParede(0, altura, -distRecepTV - tamMaiorTV - 100, -tamProd + 100, 800 + tamMenorTV);
            paredeTextura(0, altura, -distRecepTV - tamMaiorTV + 100, 0, 800 + tamMenorTV, -165, texParede); //fazerParede(0, altura, -distRecepTV - tamMaiorTV + 100, 0, 800 + tamMenorTV, -165);
            paredeTextura(0, altura, -distRecepTV - tamMaiorTV - 100, 0, 800 + tamMenorTV, -165, texParede); //fazerParede(0, altura, -distRecepTV - tamMaiorTV - 100, 0, 800 + tamMenorTV, -165);

                        //TETO TV-MENOR
            GL.Color3(Color.White);
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texParede);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(0, 5); GL.Vertex3(-2225, 1940, altura);
            GL.TexCoord2(0, 0); GL.Vertex3(-2225, 1390, altura);
            GL.TexCoord2(5, 0); GL.Vertex3(-1125, 1390, altura);
            GL.TexCoord2(5, 5); GL.Vertex3(-1125, 1940, altura);
            GL.End();
            
                        //PORTA TV-MENOR
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPorta);
            GL.Color3(Color.White);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(0, 0); GL.Vertex3(-1680, 1510, portAltura + 60);
            GL.TexCoord2(0, 1); GL.Vertex3(-1680, 1510, 0);
            GL.TexCoord2(1, 1); GL.Vertex3(-1550, 1510, 0);
            GL.TexCoord2(1, 0); GL.Vertex3(-1550, 1510, portAltura + 60);
            GL.End();
            GL.Disable(EnableCap.Blend);
                        //PORTA TV-MAIOR
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPorta);
            GL.Color3(Color.White);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(0, 0); GL.Vertex3(-1680 - 100, 1390, portAltura + 60);
            GL.TexCoord2(0, 1); GL.Vertex3(-1680 - 100, 1390, 0);
            GL.TexCoord2(1, 1); GL.Vertex3(-1550 - 120, 1390, 0);
            GL.TexCoord2(1, 0); GL.Vertex3(-1550 - 120, 1390, portAltura + 60); //porta menor devido a parede ta mt grande
            GL.End();
            GL.Disable(EnableCap.Blend);
                        //PORTA ENTRADA
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPorta);
            GL.Color3(Color.White);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(0, 0); GL.Vertex3(-1125, 1390, portAltura + 60);
            GL.TexCoord2(0, 1); GL.Vertex3(-1125, 1390, 0);
            GL.TexCoord2(1, 1); GL.Vertex3(-1125, 1510, 0);
            GL.TexCoord2(1, 0); GL.Vertex3(-1125, 1510, portAltura + 60); //porta menor devido a parede ta mt grande
            GL.End();
            GL.Disable(EnableCap.Blend);

            //TETO TV-MAIOR
            GL.Color3(Color.White);
            GL.BindTexture(TextureTarget.Texture2D, texParede);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(0, 5); GL.Vertex3(-2225, 1390, altura);
            GL.TexCoord2(0, 0); GL.Vertex3(-2225, 800, altura);
            GL.TexCoord2(5, 0); GL.Vertex3(-550, 800, altura);
            GL.TexCoord2(5, 5); GL.Vertex3(-550, 1390, altura);
            GL.End();
            GL.Disable(EnableCap.Blend);

            GL.Color3(Color.BlueViolet);
            paredeTextura(0, altura, -distRecepTV - 575, -425, 800 + tamMenorTV + 120, texParede); //fazerParede(0, altura, -distRecepTV - 575, -425, 800 + tamMenorTV + 120);
            paredeTextura(0, altura, -distRecepTV - tamMaiorTV, -275, 800 + tamMenorTV + 120, texParede);// fazerParede(0, altura, -distRecepTV - tamMaiorTV, -275, 800 + tamMenorTV + 120);
            paredeTextura(0, altura, -distRecepTV - tamMaiorTV - tamProd, 0, 800 + tamMenorTV, 550, texParede);// fazerParede(0, altura, -distRecepTV - tamMaiorTV - tamProd, 0, 800+tamMenorTV,550);

            paredeTextura(0, altura, -distRecepTV - 575, 0, 800 + tamMenorTV + 120, 550 - 120, texParede);//fazerParede(0, altura, -distRecepTV - 575, 0, 800 + tamMenorTV + 120, 550 - 120);
            paredeTextura(0, altura, -distRecepTV - 575, -550, 800 + tamMenorTV + 550,texParede);// fazerParede(0, altura, -distRecepTV - 575, -550, 800 + tamMenorTV + 550);

            paredeTextura(0, altura, -distRecepTV - 575 - 550, 0, 800 + tamMenorTV + 550, -550 + 120, texParede);// fazerParede(0, altura, -distRecepTV - 575 - 550, 0, 800 + tamMenorTV + 550, -550 + 120);

            paredeTextura(0, altura, -distRecepTV - 575 - 550, -tamProd, 800 + tamMenorTV + 550, texParede);// fazerParede(0, altura, -distRecepTV - 575 - 550, -tamProd, 800 + tamMenorTV+ 550 );


        }

        public void fazerFotografia(int texParede, int texPiso, int textPortaFoto)
        {
            GL.Color3(Color.White);
            paredeTextura(0, altura, 950, 0, 2080, larguraEstudioFotografia - 200, texParede);             //fazerParede(0, altura, 950, 0, 1980, larguraEstudioFotografia - 100);  -- y


            paredeTextura(0, altura, 950, -400, 1880, 0, texParede);                                           //  fazerParede(0, altura, 950, -400, 1880);

            paredeTextura(0, altura, 950, comprimentoEstudioFotografia, 1880, 0, texParede);                  //fazerParede(0, altura, 950, comprimentoEstudioFotografia, 1880);
            paredeTextura(0, altura, 950 + comprimentoEstudioFotografia, 0, 1880, larguraEstudioFotografia, texParede);                                             //fazerParede(0, altura, 950 + comprimentoEstudioFotografia, 0, 1880, larguraEstudioFotografia);
            paredeTextura(400, altura, 950, 0, 1880, 200, texParede);

            portaTextura(0, 400, 800, 150, 2080, 0, textPortaFoto);
            portaTextura(0, 400, 950, 0, 1880, 200, textPortaFoto);
            portaTextura(0, 400, 600, 150, 2200, 0, textPortaFoto);

            chaoTextura(0, 0, 950, comprimentoEstudioFotografia, 1880, larguraEstudioFotografia - 500, texPiso);

            ////Estudio//

            paredeTextura(0, altura, 750, 50, 2080, 0, texParede);  // fazerParede(0, altura, 750, 130, 2040);
            paredeTextura(0, altura, 750, 0, 2080, 280, texParede); //fazerParede(0, altura, 750, 0, 2040, 320);
            paredeTextura(0, altura, 750, 200, 2360, 0, texParede); //fazerParede(0, altura, 750, 200, 2360);
            paredeTextura(0, altura, 950, -400, 2945, 0, texParede);  //  fazerParede(0, altura, 950, -400, 2945);  -- x
            paredeTextura(0, altura, 550, 0, 2080, larguraEstudioFotografia - 200, texParede);
            paredeTextura(0, altura, 550, 50, 2200, 0, texParede);
            paredeTextura(400, altura, 800, 150, 2080, 0, texParede);
            paredeTextura(400, altura, 600, 150, 2200, 0, texParede);
            paredeTextura(400, altura, 550, 0, 1880, 200, texParede);

           // paredeTextura(0, 400, 550, 0, 1880, 200, textPortaFoto);
            portaTextura(0, 400, 550, 0, 1880, 200, textPortaFoto);


            chaoTextura(0, 0, 550, 400, 1880, larguraEstudioFotografia, texPiso);

            chaoTextura(altura, altura, 550, comprimentoEstudioFotografia + 400, 1880, 1100, texParede);

            GL.Color3(Color.Red);
            fazerParede(0, altura, 950, comprimentoEstudioFotografia, 2945);
            fazerChao(0, 0, 950, comprimentoEstudioFotografia, 2445, 500);
        }
        public void FazerChaoComodos(int texGrama, int texPiso, int[] texPav,int texParede)
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
            GL.TexCoord2(1f, 0 / 568); GL.Vertex3(2230, 1680, 0);
            GL.TexCoord2(0 / 984, 0 / 568); GL.Vertex3(0, 1680, 0);
            GL.TexCoord2(0 / 984, 1f); GL.Vertex3(0, 0, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(2230, 0, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            GL.Color3(Color.Red);
            chaoTextura(altura, altura, 0, recepLarg, 0, recepCompr, texParede);




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


            chaoTextura(altura, altura, 2430, 1680, 1680, -1680,texParede);



           

            ////Chao do Estudio
            //GL.Enable(EnableCap.Texture2D);
            //GL.BindTexture(TextureTarget.Texture2D, texPiso);
            //GL.Color3(Color.Transparent);
            //GL.Begin(PrimitiveType.Quads);
            //GL.TexCoord2(1f, 0 / 568); GL.Vertex3(950 + comprimentoEstudioFotografia , 2945, 0);
            //GL.TexCoord2(0 / 984, 0 / 568); GL.Vertex3(950, 2945, 0);
            //GL.TexCoord2(0 / 984, 1f); GL.Vertex3(950, 1880, 0);
            //GL.TexCoord2(1f, 1f); GL.Vertex3(950 + comprimentoEstudioFotografia, 1880, 0);
            //GL.End();
            //GL.Disable(EnableCap.Texture2D);

            ////Chao do laboratório de fotografia
            //GL.Enable(EnableCap.Texture2D);
            //GL.BindTexture(TextureTarget.Texture2D, texPiso);
            //GL.Color3(Color.Transparent);
            //GL.Begin(PrimitiveType.Quads);
            //GL.TexCoord2(1f, 0 / 568); GL.Vertex3(950, 2945, 0);
            //GL.TexCoord2(0 / 984, 0 / 568); GL.Vertex3(550, 2945, 0);
            //GL.TexCoord2(0 / 984, 1f); GL.Vertex3(550, 1880, 0);
            //GL.TexCoord2(1f, 1f); GL.Vertex3(950, 1880, 0);
            //GL.End();
            //GL.Disable(EnableCap.Texture2D);

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

            //Chao auditório + TV 
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPiso);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0 / 568); GL.Vertex3(-550, 3090, 0);
            GL.TexCoord2(0 / 984, 0 / 568); GL.Vertex3(-2225, 3090, 0);
            GL.TexCoord2(0 / 984, 1f); GL.Vertex3(-2225, 800, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(-550, 800, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);


            //Jardim parte de baixo
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texGrama);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(5,0); GL.Vertex3(2430, 570, 0);
            GL.TexCoord2(0,0); GL.Vertex3(2230, 570, 0);
            GL.TexCoord2(0,5); GL.Vertex3(2230, 0, 0);
            GL.TexCoord2(5,5); GL.Vertex3(2430, 0, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);
            
            //Jardim parte de cima
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texGrama);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(5,0); GL.Vertex3(2430, 1680, 0);
            GL.TexCoord2(0,0); GL.Vertex3(2230, 1680, 0);
            GL.TexCoord2(0,5); GL.Vertex3(2230, 1110, 0);
            GL.TexCoord2(5,5); GL.Vertex3(2430, 1110, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);
            
            //Jardim parte de baixo da fotografia
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texGrama);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(5,0); GL.Vertex3(2430, 1880, 0);
            GL.TexCoord2(0,0); GL.Vertex3(1350, 1880, 0);
            GL.TexCoord2(0,5); GL.Vertex3(1350, 1680, 0);
            GL.TexCoord2(5,5); GL.Vertex3(2430, 1680, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);



            //Jardim parte de baixo da TV
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texGrama);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(5,0); GL.Vertex3(-1000, 450, 0);
            GL.TexCoord2(0,0); GL.Vertex3(-1000, -100, 0);
            GL.TexCoord2(0,5); GL.Vertex3(-100, -100, 0);
            GL.TexCoord2(5,5); GL.Vertex3(-100, 450, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //pavimento de fora 1
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[1]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(1f, 0f / 1066f); GL.Vertex3(-950, 800, 0);
            GL.TexCoord2(0 / 1600, 0f / 1066f); GL.Vertex3(-1300, 800, 0);
            GL.TexCoord2(0 / 1600, 1f); GL.Vertex3(-1300, 535, 0);
            GL.TexCoord2(1f, 1f); GL.Vertex3(-950, 535, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //2
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[1]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(3,0); GL.Vertex3(-1300, 800, 0);
            GL.TexCoord2(0,0); GL.Vertex3(-2200, 800, 0);
            GL.TexCoord2(0,1); GL.Vertex3(-2200, 750, 0);
            GL.TexCoord2(3,1); GL.Vertex3(-1300, 750, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //3
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[1]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(5,0); GL.Vertex3(-0, 535, 0);
            GL.TexCoord2(0,0); GL.Vertex3(-1000, 535, 0);
            GL.TexCoord2(0,1); GL.Vertex3(-1000, 450, 0);
            GL.TexCoord2(5,1); GL.Vertex3(0, 450, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //4
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[1]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(5,0); GL.Vertex3(-0, 535, 0);
            GL.TexCoord2(0,0); GL.Vertex3(-100, 535, 0);
            GL.TexCoord2(0,5); GL.Vertex3(-100, -100, 0);
            GL.TexCoord2(5,5); GL.Vertex3(-0, -100, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //5
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[1]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(10,0); GL.Vertex3(4115, 0, 0);
            GL.TexCoord2(0,0); GL.Vertex3(0, 0, 0);
            GL.TexCoord2(0,10); GL.Vertex3(0, -100, 0);
            GL.TexCoord2(10,10); GL.Vertex3(4115, -100, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //6
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[1]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(5, 0); GL.Vertex3(-1000, 535, 0);
            GL.TexCoord2(0, 0); GL.Vertex3(-1300, 535, 0);
            GL.TexCoord2(0, 5); GL.Vertex3(-1300, -1450, 0);
            GL.TexCoord2(5, 5); GL.Vertex3(-1000, -1450, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //7
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[1]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(5,0); GL.Vertex3(4115, -100, 0);
            GL.TexCoord2(0,0); GL.Vertex3(0, -100, 0);
            GL.TexCoord2(0,5); GL.Vertex3(0, -1000, -100);
            GL.TexCoord2(5,5); GL.Vertex3(4115, -1000, -100);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //8
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texPav[1]);
            GL.Color3(Color.Transparent);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(5,0); GL.Vertex3(0, -100, 0);
            GL.TexCoord2(0,0); GL.Vertex3(-1000, -100, 0);
            GL.TexCoord2(0,5); GL.Vertex3(-1000, -1000, 0);
            GL.TexCoord2(5,5); GL.Vertex3(0, -1000, -100);
            GL.End();
            GL.Disable(EnableCap.Texture2D);

            //Saguao
            GL.Color3(Color.LightGray);
            fazerChao2(0, 0, 2430, 1680, 0, 1680);
            //Fotografia
            GL.Color3(Color.LightGray);
           // fazerChao(0, 0, 950, comprimentoEstudioFotografia, 1880, larguraEstudioFotografia);

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


        }

    }
}