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
            RandomButton = new Button();
            TitleLabel1 = new Label();
            label1 = new Label();
            RunButton = new Button();
            StartListbox = new ListBox();
            FinalListbox = new ListBox();
            SuspendLayout();
            // 
            // RandomButton
            // 
            RandomButton.Location = new Point(51, 356);
            RandomButton.Name = "RandomButton";
            RandomButton.Size = new Size(155, 40);
            RandomButton.TabIndex = 1;
            RandomButton.Text = "Заполнить";
            RandomButton.UseVisualStyleBackColor = true;
            RandomButton.Click += RandomButton_Click;
            // 
            // TitleLabel1
            // 
            TitleLabel1.AutoSize = true;
            TitleLabel1.Font = new Font("Segoe UI", 10F);
            TitleLabel1.Location = new Point(51, 21);
            TitleLabel1.Name = "TitleLabel1";
            TitleLabel1.Size = new Size(155, 23);
            TitleLabel1.TabIndex = 2;
            TitleLabel1.Text = "Исходный массив:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(218, 21);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 5;
            label1.Text = "Полученный массив:";
            // 
            // RunButton
            // 
            RunButton.Location = new Point(218, 356);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(155, 40);
            RunButton.TabIndex = 7;
            RunButton.Text = "Замена";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // StartListbox
            // 
            StartListbox.FormattingEnabled = true;
            StartListbox.Location = new Point(51, 56);
            StartListbox.Name = "StartListbox";
            StartListbox.Size = new Size(155, 284);
            StartListbox.TabIndex = 8;
            // 
            // FinalListbox
            // 
            FinalListbox.FormattingEnabled = true;
            FinalListbox.Location = new Point(218, 56);
            FinalListbox.Name = "FinalListbox";
            FinalListbox.Size = new Size(155, 284);
            FinalListbox.TabIndex = 9;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 453);
            Controls.Add(FinalListbox);
            Controls.Add(StartListbox);
            Controls.Add(RunButton);
            Controls.Add(label1);
            Controls.Add(TitleLabel1);
            Controls.Add(RandomButton);
            Name = "Window";
            Text = "Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button RandomButton;
        private Label TitleLabel1;
        private Label label1;
        private Button RunButton;
        private ListBox StartListbox;
        private ListBox FinalListbox;
    }
}
