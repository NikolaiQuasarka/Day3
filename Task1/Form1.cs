using System.Collections.ObjectModel;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(uint.TryParse(this.textBox1.Text, out uint n))
            {
                listBox1.Items.Clear(); listBox2.Items.Clear(); listBox3.Items.Clear();
                int[] mas = new int[n];
                Random rnd = new Random();

                for(int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next(-100,100);
                }

                foreach(int i in mas)
                {
                    listBox1.Items.Add(i.ToString());
                    if(i%2==0)
                        listBox2.Items.Add(i.ToString());
                    else listBox3.Items.Insert(0,i.ToString());
                }


            }
        }
    }
}
