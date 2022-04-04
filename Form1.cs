using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TaskAboutRandomWalking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int Count = 0;
            //Кнопка "Рассчитать
            int.TryParse(CountOfChallenge.Text, out int N);
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                int x = 0, y = 0;
                for (int j = 0; j < 10; j++)
                {
                    int v = rnd.Next(1, 5);
                    switch (v)
                    {
                        case 1:
                            x--;
                            break;
                        case 2:
                            y++;
                            break;
                        case 3:
                            x++;
                            break;
                        case 4:
                            y--;
                            break;
                    }
                }
                if (Math.Abs(x) <= 2 && Math.Abs(y) <= 2) Count++;
            }
            double r = Convert.ToDouble(Count) / Convert.ToDouble(N);
            probability.Text =  r.ToString();
        }
    }
}
