namespace Game
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void Window_MouseClick(object sender, MouseEventArgs e)
        {
            Button b = new Button();
            TextBox t = new TextBox();
            if (e.X < 350)
            {
                b.Parent = this;
                b.Location = new Point(e.X, e.Y);
                b.Size = new Size(40, 40);
                b.Text = "BB";
            }
            else if (e.X > 350)
            {
                t.Parent = this;
                t.Location = new Point(e.X, e.Y);
                t.Size = new Size(40, 40);
                t.Text = "TT";
            }

        }
    }
}
