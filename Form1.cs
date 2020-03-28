using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FIRfilter
{
    public partial class Form1 : Form
    {
        public float[] xk = new float[500];
        public float[] yk = new float[500];
        float[]  h= new float[500];
        int M = 56;
        int N0 = 500;
        float w1=20;
        float w2=60;
        public Form1()
        {
            InitializeComponent();
        }

        public void Draw(int k, int N, PointF pt0, PointF ptmin, PointF ptmax, float[] xs, PictureBox pb)
        {
            Graphics gr = pb.CreateGraphics();

            float h = pb.Height;
            float w = pb.Width;
            float x, y, y1, y2, x1, x2;
            float K;

            PointF scaleXY;
            //scaleXY = new PointF(ptmax.X / 10, ptmax.Y * 2);
            scaleXY = new PointF(((w - 2 * pt0.X) / (ptmax.X - ptmin.X)), ((h) / (ptmax.Y - ptmin.Y)));

            DrawAxes(k, N, pt0, scaleXY, ptmax, pb);

            Pen p = new Pen(Color.Red);
            //  scaleXY= new PointF (((w - 2*pt0.X) / (ptmax.X - ptmin.X)),((h) / (ptmax.Y - ptmin.Y)));

            if (k == 1) K = ptmax.X - 1;
            else K = ptmax.X;

            for (int i = 0; i < K; i++)
            {
                if (k == 1) { y1 = xs[i]; y2 = xs[i + 1]; x1 = i; x2 = i + 1; }
                else { y1 = 0; y2 = xs[i]; x1 = i; x2 = i; }
                x = x1 * scaleXY.X + pt0.X;
                y = pt0.Y - y2 * scaleXY.Y;
                gr.DrawLine(p, x1 * scaleXY.X + pt0.X, pt0.Y - (y1 * scaleXY.Y), pt0.X + x2 * scaleXY.X, pt0.Y - y2 * scaleXY.Y);

            }
            gr.Dispose();
        }

        public void DrawAxes(int k, int N, PointF pt0, PointF scaleXY, PointF ptmax, PictureBox pb)
        {
            Graphics gr = pb.CreateGraphics();
            Pen p = new Pen(Color.Black);
            //p.Color = Color.Black;
            float h = pb.Height;
            float w = pb.Width;
            float dx = scaleXY.X;
            float dy = scaleXY.Y;
            float x = 0;
            float y = 0;
            float y1, y2;

            //tmp = new float[(int)scaleXY.X];
            gr.DrawLine(p, pt0.X, 0, pt0.X, h);
            gr.DrawLine(p, pt0.X, pt0.Y, w - pt0.X, pt0.Y);
            if ((k == 1) && (N == 5)) { y1 = 0; y2 = h; }
            else { y1 = pt0.Y + 6; y2 = pt0.Y - 6; }
            //p.Width = 2F;
            for (int i = 0; i <= N; i++)
            {

                x = dx * ptmax.X * i / N;
                // tmp[i] = x;
                gr.DrawLine(p, x + pt0.X, y1, x + pt0.X, y2);

            }
            for (int i = 0; i < ptmax.Y * 2; i++)
            {
                gr.DrawLine(p, pt0.X, y, pt0.X + 10, y);
                y += dy;
            }
            gr.Dispose();
        }

        public void ImpResponse(float[] xs, float[] h, float M, float N0, float w1, float w2)
        {
            double hk;
            for (int k = 0; k < M; k++)
			{


                if (k != (M / 2 + 1)) { hk = (1 / (Math.PI * (k - M / 2 - 1))) * (Math.Sin(w2 / (2*N0) * Math.PI * (k - M / 2 - 1)) - Math.Sin(w1 / (2*N0) * Math.PI * (k - M / 2 - 1))); h[k] = (float)hk; }
                else h[k] = 40f / (2*N0);

        
            }
        }

        public void FIR(float[] yk, float[] h, int M, int N0)
        {
            for (int i = M/2; i<=(N0-M/2-1) ; i++)
            {
                yk[i] = 0;
                for (int j = 0; j <= M; j++)
                {
                    yk[i] += xk[i - M / 2 + j] * h[j];
                }
            }
        }        

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void signalButton_Click(object sender, EventArgs e)
        {
            
            float h = signalPictureBox.Height;
            
            PointF pt0 = new PointF(10, h / 2);
            PointF ptmax = new PointF(500, ((float)Math.Round(xk.Max())));
            if (ptmax.Y < xk.Max()) ptmax.Y++;
            PointF ptmin = new PointF(0, -ptmax.Y);
            
            signalPictureBox.Refresh();
            Draw(1, 10, pt0, ptmin, ptmax, xk, signalPictureBox);
        }

        private void irButton_Click(object sender, EventArgs e)
        {
            //float w1 = 140;
            //float w2 = 180;
            ImpResponse(xk, h, M, N0, w1, w2);
            for (int i = 0; i < M; i++)
            {
                listBox2.Items.Add(Convert.ToString(i) + "       " + Convert.ToString(h[i]));
            }
            PointF pt0 = new PointF(10, irPictureBox.Height/2);
            PointF ptmin = new PointF(0, -0.05f);
            PointF ptmax = new PointF(M, 0.05f);
            irPictureBox.Refresh();
            Draw(0, 1, pt0, ptmin, ptmax, h, irPictureBox);

        }

        private void dfButton_Click(object sender, EventArgs e)
        {
            FIR(yk, h, M, N0);
            PointF pt0 = new PointF(10, dfPictureBox.Height/2);
            PointF ptmin = new PointF(0, -2);
            PointF ptmax = new PointF(500, 2);
            dfPictureBox.Refresh();
            Draw(1, 5,pt0, ptmin, ptmax, yk, dfPictureBox);
            for (int i = M/2; i<=(N0-M/2-1) ; i++)
            {
                listBox3.Items.Add(Convert.ToString(i) + "       " + Convert.ToString(yk[i]));
            }
        }

        private void signalPictureBox_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader b = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.Open)))
                {
                    this.Text = "Цифровая фильтрация методом ДПФ";
                    int pos = 0;
                    int i = 0;
                    float length = b.BaseStream.Length;
                    while (pos < length)
                    {

                        xk[i] = b.ReadSingle();
                        listBox1.Items.Add(Convert.ToString(i + 1) + "       " + Convert.ToString(xk[i]));
                        i++;
                        pos += sizeof(float);

                    }
                    b.Close();
                    signalButton.Enabled = true;
                    irButton.Enabled = true;
                    dfButton.Enabled = true;

                    int k = openFileDialog1.FileName.LastIndexOf('\\');
                    this.Text += "              " + openFileDialog1.FileName.Substring(k + 1);
                    b.Dispose();
                    openFileDialog1.Reset();
                }
            }
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            w1 = 20;
            w2 = 60;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            w1 = 60;
            w2 = 100;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            w1 = 100;
            w2 = 140;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            w1 = 140;
            w2 = 180;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            w1 = 180;
            w2 = 220;
        }

        }
    }

