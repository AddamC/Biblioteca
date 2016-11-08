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
    public partial class Form1 : Form
    {
        int lateral = 0;
        int lateral2 = 0;
        Vector3d dir = new Vector3d(0, -450, 120);        //direção da câmera
        Vector3d pos = new Vector3d(0, -550, 120);     //posição da câmera
        float camera_rotation = 0;                     //rotação no eixo Z
        float camera_rotation2 = 0;
        float valor = 0f;
        Estruturas estrutura = new Estruturas();

        int texPorta;
        int texGrama;


        public Form1()
        {
            InitializeComponent();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.GhostWhite);         // definindo a cor de limpeza do fundo da tela
            GL.Enable(EnableCap.Light0);


            //texTelhado = LoadTexture("../../textura/telhado.jpg");
            texPorta = LoadTexture("../../Recursos/portaFEMA.png");
            texGrama = LoadTexture("../../Recursos/Grama.jpg");
            SetupViewport();                      //configura a janela de pintura
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); //limpa os buffers
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity(); //zera a matriz de projeção com a matriz identidade


            //                 Matrix4 lookat = Matrix4.LookAt(lateral, -500.0f, 1.5f,    
            //                                              1.5f, 5.0f, 1.5f,
            //                                           0.0f, 0.0f, 1.0f);
            Matrix4d lookat = Matrix4d.LookAt(pos.X, pos.Y, pos.Z, dir.X, dir.Y, dir.Z, 0, 0, 1);

            //aplica a transformacao na matriz de rotacao
            GL.LoadMatrix(ref lookat);
            //GL.Rotate(camera_rotation, 0, 0, 1);

            GL.Enable(EnableCap.DepthTest);

            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Red);
            GL.Vertex3(0, 0, 0); GL.Vertex3(500, 0, 0);
            GL.Color3(Color.Blue);
            GL.Vertex3(0, 0, 0); GL.Vertex3(0, 500, 0);
            GL.Color3(Color.Green);
            GL.Vertex3(0, 0, 0); GL.Vertex3(0, 0, 500);
            GL.End();

            GL.Color3(Color.Gray);
            GL.Begin(PrimitiveType.Quads);




            GL.End();
            GL.Disable(EnableCap.Blend);

            //EXEMPLO DE OBJETO TRANSPARENTE
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.Enable(EnableCap.Blend);
            GL.Color4(0.1f, 0.5f, 0.6f, 0.6f); //Último parâmetro é a porcentagem de trasparência

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(-80, 50, 0);
            GL.Vertex3(-80, 100, 0);
            GL.Vertex3(-80, 100, 50);
            GL.Vertex3(-80, 50, 50);
            GL.End();


            //GL.Enable(EnableCap.Texture2D);
            //GL.BindTexture(TextureTarget.Texture2D, texPorta);
            //GL.Color3(Color.Transparent);
            //GL.Begin(PrimitiveType.Quads);
            //GL.TexCoord2(213f / 819f, 57f / 460f); GL.Vertex3(100, 0, 140);
            //GL.TexCoord2(463f / 819f, 57f / 460f); GL.Vertex3(250, 0, 140);
            //GL.TexCoord2(213f / 819f, 412f / 460f); GL.Vertex3(250, 0, 60);
            //GL.TexCoord2(463f / 819f, 412f / 460f); GL.Vertex3(100, 0, 60);
            //GL.End();

            estrutura.fazerEntrada();
            estrutura.fazerAuditorio();
            estrutura.fazerRecepcao();
            estrutura.fazerFotografia();
            estrutura.fazerSaguao();
            estrutura.fazerTV();
            estrutura.FazerChaoComodos(texGrama);

            

            GL.Color3(Color.BlueViolet);
            //construcao.paredeBuraco(0, 300, 0, 300, 0, 0,
            //                        100, 200, 100, 200, 0, 0);

            //construcao.fazerEscada(12, 100, 200, 200, 200, 500, 500);

            GL.Disable(EnableCap.Blend);

            glControl1.SwapBuffers(); //troca os buffers de frente e de fundo 

        }
        private void SetupViewport() //configura a janela de projeção 
        {
            int w = glControl1.Width; //largura da janela
            int h = glControl1.Height; //altura da janela

            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(1f, w / (float)h, 0.1f, 30000.0f);
            GL.LoadIdentity(); //zera a matriz de projeção com a matriz identidade

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);

            GL.Viewport(0, 0, w, h); // usa toda area de pintura da glcontrol
            lateral = w / 2;
            lateral2 = h / 2;
        }

        static int LoadTexture(string filename)
        {
            if (String.IsNullOrEmpty(filename))
                throw new ArgumentException(filename);

            int id;//= GL.GenTexture(); 

            GL.GenTextures(1, out id);
            GL.BindTexture(TextureTarget.Texture2D, id);

            Bitmap bmp = new Bitmap(filename);

            BitmapData data = bmp.LockBits(new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0,
                OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);
            bmp.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);

            return id;
        }

        private void calcula_direcao()
        {
            dir.X = pos.X + (Math.Sin(camera_rotation * Math.PI / 180) * 1000);
            dir.Y = pos.Y + (Math.Cos(camera_rotation * Math.PI / 180) * 1000);
            dir.Z = pos.Z + (Math.Tan(camera_rotation2 * Math.PI / 180) * 1000);
        }

        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            Form1 frmBiblioteca = new Form1();
            if (e.X > lateral)
            {
                camera_rotation += 2;
            }
            if (e.X < lateral)
            {
                camera_rotation -= 2;
            }
            if (e.Y > lateral2)
            {
                camera_rotation2 -= 0.6f;
            }
            if (e.Y < lateral2)
            {
                camera_rotation2 += 0.6f;
            }

            //label2.Text = e.X.ToString();
            lateral = e.X;
            lateral2 = e.Y;
            calcula_direcao();
            glControl1.Invalidate();
        }

        private void glControl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            float a = camera_rotation;
            int tipoTecla = 0;
            int sinal = 1;

            if (e.KeyCode == Keys.M)
            {
                valor += 10;

                glControl1.Invalidate();
            }
            if (e.KeyCode == Keys.N)
            {
                valor -= 10;
                glControl1.Invalidate();
            }
            if (e.KeyCode == Keys.A)
            {
                sinal = 0;
                a -= 90;
                tipoTecla = 1;
            }
            if (e.KeyCode == Keys.D)
            {
                sinal = 0;
                a += 90;
                tipoTecla = 1;
            }
            if (e.KeyCode == Keys.W)
            {
                tipoTecla = 1;
            }
            if (e.KeyCode == Keys.S)
            {
                sinal = -1;
                a += 180;
                tipoTecla = 1;
            }

            if (e.KeyCode == Keys.E)
            {
                a += 3;
                tipoTecla = 2;
            }
            if (e.KeyCode == Keys.Q)
            {
                a -= 3;
                tipoTecla = 2;
            }
            if (e.KeyCode == Keys.Up)
            {
                pos.Z += 2;
            }
            if (e.KeyCode == Keys.Down)
            {
                pos.Z -= 2;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (tipoTecla == 1)
            {
                if (a < 0) a += 360;
                if (a > 360) a -= 360;
                //label2.Text = lateral.ToString();
                pos.X += (Math.Sin(a * Math.PI / 180) * 100);
                pos.Y += (Math.Cos(a * Math.PI / 180) * 100);
                pos.Z += (Math.Sin(camera_rotation2 * Math.PI / 180) * 100) * sinal;
                calcula_direcao();
                glControl1.Invalidate();
            }

            if (tipoTecla == 2)
            {
                camera_rotation = a;
                calcula_direcao();
                glControl1.Invalidate();
            }
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            //glControl1.Width = Form1.ActiveForm.Width - 10;
            //glControl1.Height = Form1.ActiveForm.Height - 10;
            SetupViewport();
            glControl1.Invalidate();
        }
    }
}
