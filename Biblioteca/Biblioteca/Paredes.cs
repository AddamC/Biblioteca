using System;

private void fazerParede(float hi, float hf, float xi,
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
private void fazerParede(float hi, float hf, float xi,
                         float xf, float posY)
{
    GL.Color3(Color.Gray);

    GL.Begin(PrimitiveType.Quads);
    GL.Vertex3(xi, posY, hi);
    GL.Vertex3(xi, posY, hf);
    GL.Vertex3(xi + xf, posY, hf);
    GL.Vertex3(xi + xf, posY, hi);
    GL.End();
}
