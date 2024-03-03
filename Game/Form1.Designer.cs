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
            Grid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Compute = new Button();
            label1 = new Label();
            label2 = new Label();
            TextSum = new TextBox();
            label3 = new Label();
            TextMult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // Grid
            // 
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid.BackgroundColor = Color.FloralWhite;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            Grid.Location = new Point(49, 62);
            Grid.Name = "Grid";
            Grid.RowHeadersWidth = 51;
            Grid.RowTemplate.DefaultCellStyle.NullValue = null;
            Grid.Size = new Size(200, 200);
            Grid.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Compute
            // 
            Compute.Location = new Point(49, 285);
            Compute.Name = "Compute";
            Compute.Size = new Size(107, 41);
            Compute.TabIndex = 1;
            Compute.Text = "Вычислить";
            Compute.UseVisualStyleBackColor = true;
            Compute.Click += Compute_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(301, 50);
            label1.TabIndex = 2;
            label1.Text = "Вычислить сумму второй строки и \r\nпроизведение первого столбца";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 59);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 3;
            label2.Text = "Сумма второй строки: ";
            // 
            // TextSum
            // 
            TextSum.Location = new Point(365, 82);
            TextSum.Name = "TextSum";
            TextSum.Size = new Size(54, 27);
            TextSum.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 139);
            label3.Name = "label3";
            label3.Size = new Size(237, 20);
            label3.TabIndex = 5;
            label3.Text = "Произведение первого столбца:";
            // 
            // TextMult
            // 
            TextMult.Location = new Point(344, 162);
            TextMult.Name = "TextMult";
            TextMult.Size = new Size(102, 27);
            TextMult.TabIndex = 6;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 424);
            Controls.Add(TextMult);
            Controls.Add(label3);
            Controls.Add(TextSum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Compute);
            Controls.Add(Grid);
            Name = "Window";
            Text = "Game";
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grid;
        private Button Compute;
        private Label label1;
        private Label label2;
        private TextBox TextSum;
        private Label label3;
        private TextBox TextMult;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
