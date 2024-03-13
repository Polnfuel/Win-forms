namespace Game
{
    public partial class Window : Form
    {
        private Color linecolor = Color.Black;
        private Point startPoint;
        private Point endPoint;
        private List<Line> lines = new List<Line>();
        public Window()
        {
            InitializeComponent();
            this.Paint += Window_Paint;
            this.MouseDown += Window_MouseDown;
            this.MouseUp += Window_MouseUp;
        }
        
        private void Window_Paint(object sender, PaintEventArgs e)
        {
            foreach(var line in lines)
            {
                using (Pen pen = new Pen(line.Color, 2))
                {
                    e.Graphics.DrawLine(pen, line.StartPoint, line.EndPoint);
                }
            }
            
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            linecolor = colorDialog1.Color;
            PickedColor.BackColor = linecolor;
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            
        }

        private void Window_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint = e.Location;
            lines.Add(new Line(startPoint, endPoint, linecolor));
            this.Invalidate();
        }
        private class Line
        {
            public Point StartPoint { get; }
            public Point EndPoint { get; }
            public Color Color { get; }
            public Line(Point startPoint, Point endPoint, Color color)
            {
                StartPoint = startPoint;
                EndPoint = endPoint;
                Color = color;
            }
        }
    }
}
