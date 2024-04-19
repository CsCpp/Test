namespace Test
{
    partial class Form1
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
            label1 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small Semibold", 28.1999989F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point, 204);
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(746, 68);
            label1.TabIndex = 0;
            label1.Text = "Просто текст для проверки!";
            // 
            // button1
            // 
            button1.Location = new Point(46, 110);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "ЖМЯК";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(185, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(157, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Нажата ли кнопка";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(56, 160);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(192, 268);
            checkedListBox1.TabIndex = 3;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 482);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Test PROGA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private CheckBox checkBox1;
        private CheckedListBox checkedListBox1;
    }
}
