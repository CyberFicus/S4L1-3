namespace S4L1_3
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
            label_num = new Label();
            textBox_num = new TextBox();
            label_divs = new Label();
            label_even_divs = new Label();
            btn_analyze = new Button();
            SuspendLayout();
            // 
            // label_num
            // 
            label_num.AutoSize = true;
            label_num.Location = new Point(233, 80);
            label_num.Name = "label_num";
            label_num.Size = new Size(126, 15);
            label_num.TabIndex = 0;
            label_num.Text = "Input the number here";
            // 
            // textBox_num
            // 
            textBox_num.Location = new Point(365, 77);
            textBox_num.Name = "textBox_num";
            textBox_num.Size = new Size(143, 23);
            textBox_num.TabIndex = 1;
            textBox_num.Text = "10";
            // 
            // label_divs
            // 
            label_divs.AutoSize = true;
            label_divs.Location = new Point(305, 120);
            label_divs.Name = "label_divs";
            label_divs.Size = new Size(54, 15);
            label_divs.TabIndex = 2;
            label_divs.Text = "Divisors: ";
            // 
            // label_even_divs
            // 
            label_even_divs.AutoSize = true;
            label_even_divs.Location = new Point(430, 120);
            label_even_divs.Name = "label_even_divs";
            label_even_divs.Size = new Size(78, 15);
            label_even_divs.TabIndex = 3;
            label_even_divs.Text = "Even divisors:";
            // 
            // btn_analyze
            // 
            btn_analyze.Location = new Point(514, 76);
            btn_analyze.Name = "btn_analyze";
            btn_analyze.Size = new Size(102, 23);
            btn_analyze.TabIndex = 4;
            btn_analyze.Text = "Analyze number";
            btn_analyze.UseVisualStyleBackColor = true;
            btn_analyze.Click += btn_analyze_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_analyze);
            Controls.Add(label_even_divs);
            Controls.Add(label_divs);
            Controls.Add(textBox_num);
            Controls.Add(label_num);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_num;
        private TextBox textBox_num;
        private Label label_divs;
        private Label label_even_divs;
        private Button btn_analyze;
    }
}