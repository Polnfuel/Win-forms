namespace Game
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }
        private void Window_Load(object sender, EventArgs e)
        {
            ResultLabel.Text = string.Empty;
        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            int StringIndex = WordList.SelectedIndex;
            string SelectedString = (string)WordList.Items[StringIndex];
            int StringLength = SelectedString.Length;
            int Words = 0;
            int i = 0;
            char Prev = ' ';
            char Curr = SelectedString[0];
            while (i < StringLength)
            {
                if (Curr != ' ' && Prev == ' ')
                    Words++;
                Prev = SelectedString[i];
                if (i != StringLength - 1)
                    Curr = SelectedString[i + 1];
                i++;
            }
            ResultLabel.Text = "В этой строке " + Words.ToString();
            switch (Words)
            {
                case 1:
                    ResultLabel.Text += " слово"; break;
                case 2:
                case 3:
                case 4:
                    ResultLabel.Text += " слова"; break;
                default:
                    ResultLabel.Text += " слов"; break;
            }
        }

        
    }
}
