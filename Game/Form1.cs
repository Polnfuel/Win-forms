namespace Game
{
    public partial class Window : Form
    {
        private static int x, y, wid = 38, hei = 5;
        private static double angle;

        private static Pen pen = new Pen(Color.Black, 1);
        private static Pen pennn = new Pen(Color.Green, 1);
        private static Point[] FirstRect = new Point[4];
        private static Point[] SecondRect = new Point[4];

        private static Point somepoint = new Point();
        public Window()
        {
            InitializeComponent();
        }

        private void Window_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawPolygon(pen, FirstRect);
            g.DrawPolygon(pen, SecondRect);
            g.DrawRectangle(pennn, somepoint.X, somepoint.Y, 1, 1);
        
        }

        private void Window_Resize(object sender, EventArgs e)
        {
            this.Text = "Game: " + this.ClientSize.Width + " x " + this.ClientSize.Height;
            
            x = this.ClientSize.Width / 2;
            y = this.ClientSize.Height / 2;
            int scale = Math.Min(x, y) / 3;
            wid = (int)scale;
            hei = (int)(scale / 5);
            somepoint.X = x - wid;
            somepoint.Y = y - hei;
            FirstRect = [new Point(x - wid, y + hei), new Point(x - wid, y - hei), new Point(x + wid, y + hei), new Point(x + wid, y - hei)];
            SecondRect = [new Point(x - hei, y + wid), new Point(x + hei, y + wid), new Point(x - hei, y - wid), new Point(x + hei, y - wid)];
            Invalidate();

        }
        private void Window_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(600, 600);
            
        }
        private void Rotate(ref Point p, double a)
        {
            double r = Math.Sqrt((Math.Pow((x - p.X), 2) + Math.Pow((y-p.Y), 2)));
            if (p.X > x)
                p.X = (int)(x + r * Math.Cos(a));
            else if (p.X <= x)
                p.X = (int)(x - r * Math.Cos(a));
            if (p.Y > y)
                p.Y = (int)(y + r * Math.Sin(a));
            else if (p.Y <= y)
                p.Y = (int)(y - r * Math.Sin(a));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            angle -= 0.1;
            for (int i = 0; i < FirstRect.Length; i++)
            {
                Rotate(ref FirstRect[i], angle);
            }
            for (int i = 0; i < SecondRect.Length; i++)
            {
                Rotate(ref SecondRect[i], angle);
            }
            Rotate(ref somepoint, angle);
            Invalidate();
        }
    }
}
