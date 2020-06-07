using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.IO.Ports;
using DBMControllerApp_TK.Utilities;
using DBMControllerApp_TK.Forms;

namespace DBMControllerApp_TK
{
    class demo3d
    {
        public static double calibX = 0.0;
        public static double calibY = 0.0;
        public static double calibZ = 0.0;
        public static double pressure = 0.0;

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
            window.Visible = OrientationSettings.getInstance().showDemo3d;

            rotateCAx = OrientationSettings.getInstance().offsetX;
            rotateCAy = OrientationSettings.getInstance().offsetY;
            rotateCAz = OrientationSettings.getInstance().offsetZ;

            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Translate(0.0f, 0.0f, 45.0f);

            GL.Rotate(rotateCAx, new Vector3d(1, 0, 0));
            GL.Rotate(rotateCAy, new Vector3d(0, 1, 0));
            GL.Rotate(rotateCAz, new Vector3d(0, 0, 1));

            GL.Rotate(xRot, new Vector3d(1, 0, 0));
            GL.Rotate(yRot, new Vector3d(0, 1, 0));
            GL.Rotate(zRot, new Vector3d(0, 0, 1));

            Matrix4 currentModelView;
            GL.GetFloat(GetPName.ModelviewMatrix, out currentModelView);
            Quaternion q = currentModelView.ExtractRotation();
            //const double epsi = 0.0001;
            //double y = 2.0 * (q.Y * q.Z + q.W * q.X);
            //double x = q.W * q.W - q.X * q.X - q.Y * q.Y + q.Z * q.Z;
            //double pitch = (Math.Abs(q.X) < epsi && Math.Abs(q.Y) < epsi) ? 2.0 * Math.Atan2(q.X, q.W) : Math.Atan2(y, x);
            //double yaw = Math.Asin(Math.Min(Math.Max(-2.0 * (q.X * q.Z - q.W * q.Y), -1.0), 1.0));
            //double roll = Math.Atan2(2.0 * (q.X * q.Y + q.W * q.Z), q.W * q.W + q.X * q.X - q.Y * q.Y - q.Z * q.Z);
            //Console.WriteLine(q);
            Vector3 calibVect = Utility.ToEulerAngles(q);
            calibX = calibVect.Z;
            calibY = calibVect.Y;
            calibZ = calibVect.X;

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

            //xRot += 10;
        }

        void loaded(object o, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
        }

        Vector3 getAxis(int id)
        {
            double angX = (Math.PI / 180) * 0;
            double angY = (Math.PI / 180) * 0;
            double angZ = (Math.PI / 180) * 0;
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
