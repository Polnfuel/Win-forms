namespace Game
{
    public partial class Window : Form
    {
        private static int x, y, wid = 38, hei = 5;
        private static double angle;

        private static Pen pen = new Pen(Color.Black, 1);
        private static PointF[] FirstRect = new PointF[4];
        private static PointF[] SecondRect = new PointF[4];

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawPolygon(pen, FirstRect);
            g.DrawPolygon(pen, SecondRect);
        }

        private void Window_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(600, 600);
            x = this.ClientSize.Width / 2;
            y = this.ClientSize.Height / 2;
            int scale = Math.Min(x, y) / 3;
            wid = (int)scale;
            hei = (int)(scale / 5);
            FirstRect = [new Point(x - wid, y + hei), new Point(x - wid, y - hei), new Point(x + wid, y + hei), new Point(x + wid, y - hei)];
            SecondRect = [new Point(x - hei, y + wid), new Point(x + hei, y + wid), new Point(x - hei, y - wid), new Point(x + hei, y - wid)];
        }
        private void Rotate(ref PointF p, double a)
        {
            float nx = p.X - x;
            float ny = -(p.Y - y);

            p.X = (float)(nx*Math.Cos(a) + ny*Math.Sin(a) + x);
            p.Y = (float)(nx*Math.Sin(a) - ny*Math.Cos(a) + y);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 0.005f;
            if (angle > 2 * Math.PI)
                angle -= 2 * Math.PI;
            for (int i = 0; i < FirstRect.Length; i++)
            {
                Rotate(ref FirstRect[i], angle);
            }
            for (int i = 0; i < SecondRect.Length; i++)
            {
                Rotate(ref SecondRect[i], angle);
            }
            Invalidate();
        }
    }
}
