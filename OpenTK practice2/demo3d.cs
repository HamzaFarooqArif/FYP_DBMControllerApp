using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.IO.Ports;

namespace OpenTK_practice2
{
    class demo3d
    {
        public static double rotateCAx = 0.0;
        public static double rotateCAy = 0.0;
        public static double rotateCAz = 0.0;
        
        public static double xRot = 0.0;
        public static double yRot = 0.0;
        public static double zRot = 0.0;
        
        GameWindow window;
        public demo3d(GameWindow window)
        {
            this.window = window;
            Start();
        }
        void Start()
        {
            window.Load += loaded;
            window.RenderFrame += renderF;
            window.Resize += resize;
            window.Run(1.0, 60.0);
        }

        void resize(object o, EventArgs e)
        {
            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(0.03f, window.Width / window.Height, 1.0f, 100.0f);
            GL.LoadMatrix(ref matrix);
            GL.Ortho(-50.0, 50.0, -50.0, 50.0, -1.0, 1.0);
            GL.MatrixMode(MatrixMode.Modelview);
        }
        
        void renderF(object o, EventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Translate(0.0f, 0.0f, 45.0f);

            GL.Rotate((float)xRot, getAxis(0));
            GL.Rotate((float)yRot, getAxis(1));
            GL.Rotate((float)zRot, getAxis(2));

            //GL.Rotate(xRot, 1.0f, 0.0f, 0.0f);
            //GL.Rotate(yRot, 0.0f, 1.0f, 0.0f);
            //GL.Rotate(zRot, 0.0f, 0.0f, 1.0f);

            //Draw Tip------------------------------------------------------------
            float triangleHeight = 30f;
            float triangleHeightB = 20f;
            float triangleBotArea = 2f;

            GL.Begin(BeginMode.Quads);

            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(triangleBotArea, -triangleBotArea, triangleHeightB);
            GL.Vertex3(triangleBotArea, triangleBotArea, triangleHeightB);
            GL.Vertex3(-triangleBotArea, triangleBotArea, triangleHeightB);
            GL.Vertex3(-triangleBotArea, -triangleBotArea, triangleHeightB);
            GL.End();

            GL.Begin(BeginMode.Triangles);

            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(0f, 0f, triangleHeight);
            GL.Vertex3(triangleBotArea, -triangleBotArea, triangleHeightB);
            GL.Vertex3(triangleBotArea, triangleBotArea, triangleHeightB);

            GL.Color3(0.0, 1.0, 0.0);
            GL.Vertex3(0f, 0f, triangleHeight);
            GL.Vertex3(triangleBotArea, triangleBotArea, triangleHeightB);
            GL.Vertex3(-triangleBotArea, triangleBotArea, triangleHeightB);

            GL.Color3(0.0, 0.0, 1.0);
            GL.Vertex3(0f, 0f, triangleHeight);
            GL.Vertex3(-triangleBotArea, triangleBotArea, triangleHeightB);
            GL.Vertex3(-triangleBotArea, -triangleBotArea, triangleHeightB);

            GL.Color3(1.0, 0.0, 1.0);
            GL.Vertex3(0f, 0f, triangleHeight);
            GL.Vertex3(triangleBotArea, -triangleBotArea, triangleHeightB);
            GL.Vertex3(-triangleBotArea, -triangleBotArea, triangleHeightB);
            
            GL.End();
            //Draw Body---------------------------------------------------------------

            float bodyHeight = 20f;
            float bodyHeightB = 0f;
            float bodyArea = 2f;

            GL.Begin(BeginMode.Quads);
            GL.Color3(0.0, 0.5, 0.0);
            GL.Vertex3(-bodyArea, bodyArea, bodyHeight);
            GL.Vertex3(-bodyArea, bodyArea, -bodyHeightB);
            GL.Vertex3(-bodyArea, -bodyArea, -bodyHeightB);
            GL.Vertex3(-bodyArea, -bodyArea, bodyHeight);

            GL.Color3(1.0, 0.0, 1.0);
            GL.Vertex3(bodyArea, bodyArea, bodyHeight);
            GL.Vertex3(bodyArea, bodyArea, -bodyHeightB);
            GL.Vertex3(bodyArea, -bodyArea, -bodyHeightB);
            GL.Vertex3(bodyArea, -bodyArea, bodyHeight);

            GL.Color3(0.0, 1.0, 1.0);
            GL.Vertex3(bodyArea, -bodyArea, bodyHeight);
            GL.Vertex3(bodyArea, -bodyArea, -bodyHeightB);
            GL.Vertex3(-bodyArea, -bodyArea, -bodyHeightB);
            GL.Vertex3(-bodyArea, -bodyArea, bodyHeight);

            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(bodyArea, bodyArea, bodyHeight);
            GL.Vertex3(bodyArea, bodyArea, -bodyHeightB);
            GL.Vertex3(-bodyArea, bodyArea, -bodyHeightB);
            GL.Vertex3(-bodyArea, bodyArea, bodyHeight);

            GL.Color3(0.0, 1.0, 0.0);
            GL.Vertex3(bodyArea, bodyArea, -bodyHeightB);
            GL.Vertex3(bodyArea, -bodyArea, -bodyHeightB);
            GL.Vertex3(-bodyArea, -bodyArea, -bodyHeightB);
            GL.Vertex3(-bodyArea, bodyArea, -bodyHeightB);

            GL.Color3(0.0, 0.0, 1.0);
            GL.Vertex3(bodyArea, bodyArea, bodyHeight);
            GL.Vertex3(bodyArea, -bodyArea, bodyHeight);
            GL.Vertex3(-bodyArea, -bodyArea, bodyHeight);
            GL.Vertex3(-bodyArea, bodyArea, bodyHeight);

            GL.End();
            //Draw Cap---------------------------------------------------------------

            float capHeight = 0f;
            float capHeightB = 5f;
            float capArea = 4f;

            GL.Begin(BeginMode.Quads);
            GL.Color3(1.0, 0.0, 1.0);
            GL.Vertex3(-capArea, capArea, capHeight);
            GL.Vertex3(-capArea, capArea, -capHeightB);
            GL.Vertex3(-capArea, -capArea, -capHeightB);
            GL.Vertex3(-capArea, -capArea, capHeight);

            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(capArea, capArea, capHeight);
            GL.Vertex3(capArea, capArea, -capHeightB);
            GL.Vertex3(capArea, -capArea, -capHeightB);
            GL.Vertex3(capArea, -capArea, capHeight);

            GL.Color3(0.0, 1.0, 1.0);
            GL.Vertex3(capArea, -capArea, capHeight);
            GL.Vertex3(capArea, -capArea, -capHeightB);
            GL.Vertex3(-capArea, -capArea, -capHeightB);
            GL.Vertex3(-capArea, -capArea, capHeight);

            GL.Color3(1.0, 0.0, 1.0);
            GL.Vertex3(capArea, capArea, capHeight);
            GL.Vertex3(capArea, capArea, -capHeightB);
            GL.Vertex3(-capArea, capArea, -capHeightB);
            GL.Vertex3(-capArea, capArea, capHeight);

            GL.Color3(0.5, 0.0, 0.2);
            GL.Vertex3(capArea, capArea, -capHeightB);
            GL.Vertex3(capArea, -capArea, -capHeightB);
            GL.Vertex3(-capArea, -capArea, -capHeightB);
            GL.Vertex3(-capArea, capArea, -capHeightB);

            GL.Color3(0.5, 0.0, 0.5);
            GL.Vertex3(capArea, capArea, capHeight);
            GL.Vertex3(capArea, -capArea, capHeight);
            GL.Vertex3(-capArea, -capArea, capHeight);
            GL.Vertex3(-capArea, capArea, capHeight);

            GL.End();

            window.SwapBuffers();    
        }

        void loaded(object o, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
        }

        Vector3 getAxis(int id)
        {
            double angX = (Math.PI / 180) * rotateCAx;
            double angY = (Math.PI / 180) * rotateCAy;
            double angZ = (Math.PI / 180) * rotateCAz;
            Vector3 result = new Vector3();

            if (id == 0)
            {
                result.X = 1;
                result.Y = 0;
                result.Z = 0;
            }
            else if (id == 1)
            {
                result.X = 0;
                result.Y = 1;
                result.Z = 0;
            }
            else if (id == 2)
            {
                result.X = 0;
                result.Y = 0;
                result.Z = 1;
            }

            if (rotateCAz != 0)
            {
                float tempX = result.X;
                float tempY = result.Y;

                result.X = tempX * (float)Math.Cos(angZ) - tempY * (float)Math.Sin(angZ);
                result.Y = tempX * (float)Math.Sin(angZ) + tempY * (float)Math.Cos(angZ);
            }

            if (rotateCAy != 0)
            {
                float tempX = result.X;
                float tempZ = result.Z;

                result.X = tempX * (float)Math.Cos(angY) + tempZ * (float)Math.Sin(angY);
                result.Z = tempX * (-(float)Math.Sin(angY)) + tempZ * (float)Math.Cos(angY);
            }

            if (rotateCAx != 0)
            {
                float tempY = result.Y;
                float tempZ = result.Z;

                result.Y = tempY * (float)Math.Cos(angX) - tempZ * (float)Math.Sin(angX);
                result.Z = tempY * (float)Math.Sin(angX) + tempZ * (float)Math.Cos(angX);
            }

            return result;
        }
    }
}
