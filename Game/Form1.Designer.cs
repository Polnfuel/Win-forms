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
            colorDialog1 = new ColorDialog();
            ColorButton = new Button();
            PickedColor = new Label();
            SuspendLayout();
            // 
            // colorDialog1
            // 
            colorDialog1.FullOpen = true;
            // 
            // ColorButton
            // 
            ColorButton.Location = new Point(12, 12);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(123, 29);
            ColorButton.TabIndex = 0;
            ColorButton.Text = "Выбрать цвет";
            ColorButton.UseVisualStyleBackColor = true;
            ColorButton.Click += ColorButton_Click;
            // 
            // PickedColor
            // 
            PickedColor.AutoSize = true;
            PickedColor.Location = new Point(150, 16);
            PickedColor.Name = "PickedColor";
            PickedColor.Size = new Size(45, 20);
            PickedColor.TabIndex = 1;
            PickedColor.Text = "         ";
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 502);
            Controls.Add(PickedColor);
            Controls.Add(ColorButton);
            Name = "Window";
            Text = "Game";
            Paint += Window_Paint;
            MouseDown += Window_MouseDown;
            MouseUp += Window_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ColorDialog colorDialog1;
        private Button ColorButton;
        private Label PickedColor;
    }
}
