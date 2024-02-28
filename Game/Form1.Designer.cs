namespace Game
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WordList = new ListBox();
            RunButton = new Button();
            TitleLabel = new Label();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // WordList
            // 
            WordList.FormattingEnabled = true;
            WordList.Items.AddRange(new object[] { "Обычное предложение", "Тут  между    словами  несколько    пробелов!", "Слово", "Два слова", "Это самая длинная строка в этом списке - в ней 12 слов", " ", "В предыдущей строке стоит пробел." });
            WordList.Location = new Point(104, 69);
            WordList.Name = "WordList";
            WordList.Size = new Size(446, 264);
            WordList.TabIndex = 0;
            // 
            // RunButton
            // 
            RunButton.Location = new Point(138, 350);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(140, 40);
            RunButton.TabIndex = 1;
            RunButton.Text = "Считать слова";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 10F);
            TitleLabel.Location = new Point(46, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(602, 46);
            TitleLabel.TabIndex = 2;
            TitleLabel.Text = "Подсчитаем количество слов в выбранной строке\r\n(считается что слово - любой набор символов ограниченный пробелами)";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(342, 360);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(85, 20);
            ResultLabel.TabIndex = 3;
            ResultLabel.Text = "ResultLabel";
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(ResultLabel);
            Controls.Add(TitleLabel);
            Controls.Add(RunButton);
            Controls.Add(WordList);
            Name = "Window";
            Text = "Game";
            Load += Window_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox WordList;
        private Button RunButton;
        private Label TitleLabel;
        private Label ResultLabel;
    }
}
