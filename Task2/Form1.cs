using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(this.textBox_count.Text, out uint n))
            {
                dataGridView1.Rows.Clear();
                int[] mas = new int[n];
                Random rnd = new Random();

                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next(-100, 100);
                }

                for (int i =0; i<mas.Length; i++)
                {
                    dataGridView1.Rows.Add(i, mas[i]);
                }

                int? r=null;
                for (int i =0; i<mas.Length; i++)
                {
                    if (r == null)
                    {
                        if (mas[i] % 2 == 0) r = 0;
                        else r = 1;
                    }
                    else if ((mas[i] % 2 == 0 & r == 0) | (mas[i] % 2 != 0 & r == 1))
                    {
                        textBox_res.Text = i.ToString(); break;
                    }
                    else
                    { if (r == 0) r = 1; else r = 0; textBox_res.Text = "0"; }
                }

            }
        }
    }
}
