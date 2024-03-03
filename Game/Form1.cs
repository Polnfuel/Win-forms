namespace Game
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }
        
        private void Compute_Click(object sender, EventArgs e)
        {
            int rows = 3;
            int cols = 3;
            int[,] mas = new int[rows, cols];
            Grid.RowCount = rows;
            Grid.ColumnCount = cols;
            Random rand = new Random();
            int i, j;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    mas[i, j] = rand.Next(-100, 100);
                    Grid.Rows[i].Cells[j].Value = mas[i, j];
                }
            }
            int s = 0;
            for (i = 0; i < Grid.ColumnCount; i++)
                s += mas[1, i];

            int p = 1;
            for (i = 0; i < Grid.RowCount; i++)
                p *= mas[i, 0];
            TextSum.Text = s.ToString();
            TextMult.Text = p.ToString();

        }
    }
}
