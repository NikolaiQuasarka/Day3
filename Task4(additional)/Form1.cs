namespace Task4_additional_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox_n.Text, out int n) & n >0)
            {
                int[,] mas = new int[n,n];
                Random rnd = new Random();
                dataGridView1.RowCount = n; dataGridView1.ColumnCount = n;

                for(int i = 0; i < n; i++) 
                for(int j=0; j<n; j++)
                    {
                        mas[i,j] = rnd.Next(-50,50);
                        dataGridView1.Rows[i].Cells[j].Value = mas[i,j];
                    }

                int sum =0;
                for (int i = 0, j = n - 1; i < n; i++, j--)            
                    for (int k = i; k < n; k++)
                    {
                        sum += mas[k, j];
                    }               
                textBox_sum.Text = sum.ToString();


            }
        }
    }
}
