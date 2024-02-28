namespace Game
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        int[] Mas = new int[10];

        private void RandomButton_Click(object sender, EventArgs e)
        {
            StartListbox.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = rand.Next(-30, 30);
                StartListbox.Items.Add($"Mas[{i}] = " + Mas[i]);
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            FinalListbox.Items.Clear();
            //»щем индекс наименьшего элемента
            int imin = 0;
            for (int i = 0; i < Mas.Length; i++)
                if (Mas[i] < Mas[imin])
                    imin = i;
            (Mas[imin], Mas[Mas.Length - 2]) = (Mas[Mas.Length - 2], Mas[imin]);
            for (int i = 0; i < Mas.Length; i++)
            {
                FinalListbox.Items.Add($"Mas[{i}] = " + Mas[i]);
            }
        }
    }
}
