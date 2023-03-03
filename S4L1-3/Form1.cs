using System;

namespace S4L1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_analyze_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(textBox_num.Text);

                bool is_even(int num)
                {
                    return (num & 1) == 0 ? true : false;
                }

                if (num < 1)
                {
                    MessageBox.Show("Error! Incorrect input!");
                }
                else
                {
                    int divs = 2, even_divs = 0;
                    
                    if (num > 1)
                    {
                        if (is_even(num))
                        {
                            even_divs++;
                        }

                        for (int d = 2; d < num; d++)
                        {
                            if (num % d == 0)
                            {
                                divs++;
                                if (is_even(d))
                                    even_divs++;
                            }
                        }
                    }
                    else
                    {
                        divs = 1;
                    }

                    label_divs.Text = $"Divisors: {divs}";
                    label_even_divs.Text = $"Even divisors: {even_divs}";
                }
            }
            catch 
            {
                MessageBox.Show("Error! Incorrect input!");
            }
        }
    }
}