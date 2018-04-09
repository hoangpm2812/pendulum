using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendulum
{
    public partial class Form1 : Form
    {
        //private Point origin;
        //private Point endLine;
        //private Point ballPos;
        //private int lenght;
        //private int radius;
        //private float angle = 0;

        //private float aVel = 0;
        //private float aAcc = 0;

        private PendulumModel pendulum = new PendulumModel();

        private bool hasForce;
        private bool startAnimation;

        private float force;
        //private float mass;
        private bool isRight;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pendulum.angle = 0;
            pendulum.aVel = 0;
            pendulum.aAcc = 0;

            pendulum.origin = new Point(ptbMain.Width / 2, ptbMain.Height / 4);
            pendulum.radius = (int)nudRadius.Value;
            pendulum.lenght = (int)nudLenght.Value;
            btnRun.Enabled = true;
            btnStop.Enabled = false;
            ckbForce.Enabled = true;
            nudAngle.Value = 0;
            cmbDirection.Text = "Right";

            if (ckbForce.Checked)
            {
                hasForce = true;
            }
            else
            {
                hasForce = false;
            }
            DrawPendulum();
        }

        private void DrawPendulum()
        {
            //1. create a new bitmap   
            Bitmap bm = new Bitmap(ptbMain.Width, ptbMain.Height);
            Graphics g = Graphics.FromImage(bm);

            //2. clear screen
            g.Clear(Color.White);

            //3. draw
            pendulum.DrawPendulum(g);
            ptbMain.Image = bm;

            //4. update

            //5. dispose
            g.Dispose();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pendulum.lenght = (int)nudLenght.Value;
            pendulum.radius = (int)nudRadius.Value;
            DrawPendulum();
        }

        private void nudRadius_ValueChanged(object sender, EventArgs e)
        {
            pendulum.lenght = (int)nudLenght.Value;
            pendulum.radius = (int)nudRadius.Value;
            DrawPendulum();
        }

        private void nudAngle_ValueChanged(object sender, EventArgs e)
        {
            if (!hasForce)
            {
                pendulum.angle = (float)nudAngle.Value * (float)Math.PI / 180;
                DrawPendulum();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (startAnimation)
            {
                startRunning();
            }
        }
        private void startRunning()
        {
            if (hasForce)
            {
                //angular accelerayion formula
                pendulum.aAcc = (float)(force * Math.Cos(Math.Abs(pendulum.angle)) / pendulum.mass) - (float)(0.01 * Math.Sin(Math.Abs(pendulum.angle)));
                if (isRight == false)   //force direction is left
                {
                    pendulum.angle -= pendulum.aVel;
                }
                else
                {
                    pendulum.angle += pendulum.aVel;      //force direction is right
                }
                pendulum.aVel += pendulum.aAcc;

                if (pendulum.aVel <= 0)
                {
                    hasForce = false;
                    pendulum.aVel = 0;
                }
            }
            else
            {
                pendulum.aAcc = (float)(-0.01 * Math.Sin(pendulum.angle));
                pendulum.angle += pendulum.aVel;
                pendulum.aVel += pendulum.aAcc;

                //damping
                pendulum.aVel *= 0.99f;
            }

            DrawPendulum();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if ((hasForce && nudForceValue.Value != 0) || nudAngle.Value != 0)
            {
                if (cmbDirection.SelectedItem.ToString() == "Left")
                {
                    isRight = false;   
                }
                else
                {
                    isRight = true;
                }
                pendulum.mass = (float)nudMass.Value;
                force = (float)nudForceValue.Value / 1000;
                startAnimation = true;
                timer1.Start();
                btnRun.Enabled = false;
                btnStop.Enabled = true;
                ckbForce.Enabled = false;   
            }
            
        }

        private void ckbForce_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbForce.Checked)
            {
                hasForce = true;
                nudAngle.Value = 0;
                pendulum.angle = 0;
                DrawPendulum();
                nudAngle.Enabled = false;
                grbForce.Visible = true;
                btnRun.Location = new Point(657, 227);
                btnStop.Location = new Point(736, 227);
            }
            else
            {
                hasForce = false;
                nudAngle.Enabled = true;
                grbForce.Visible = false;
                btnRun.Location = new Point(654, 140);
                btnStop.Location = new Point(733, 140);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Form1_Load(sender, e);
        }
    }
}
