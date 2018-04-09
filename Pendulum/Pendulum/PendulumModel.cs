using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendulum
{
    class PendulumModel
    {
        public Point origin { get; set; }
        public Point ballPos { get; set; }
        public Point endLine { get; set; }
        public int lenght { get; set; }
        public float mass { get; set; }
        public int radius { get; set; }
        public float angle { get; set; }
        public float aAcc { get; set; }
        public float aVel { get; set; }

        public PendulumModel()
        {
            angle = 0;
            aVel = 0;
            aAcc = 0;
        }
        public void DrawPendulum(Graphics g)
        {
            endLine = new Point(origin.X + (int)(lenght * Math.Sin(angle)), origin.Y + (int)(lenght * Math.Cos(angle)));
            ballPos = new Point(origin.X + (int)((lenght + radius) * Math.Sin(angle)), origin.Y + (int)((lenght + radius) * Math.Cos(angle)));

            g.DrawLine(new Pen(Color.Black), new Point(origin.X - 3, origin.Y), new Point(origin.X + 3, origin.Y));
            g.DrawLine(new Pen(Color.Black), origin, ballPos);
            g.DrawEllipse(new Pen(Color.Black), new Rectangle(ballPos.X - radius, ballPos.Y - radius, radius * 2, radius * 2));
        }
       
    }
}
