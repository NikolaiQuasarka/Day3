namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 5; dataGridView1.ColumnCount = 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Random rnd = new Random();
            int[,] mas = new int[5,8];
            List<int> negativ = new List<int>();

            for(int i = 0;i< mas.GetLength(0);i++)
                for(int j = 0;j< mas.GetLength(1);j++)
                {
                    mas[i,j] = rnd.Next(-50,50);
                    dataGridView1.Rows[i].Cells[j].Value = mas[i,j];
                    if (mas[i, j] < 0 & !negativ.Contains(j + 1))
                    {
                        negativ.Add(j + 1);
                        textBox1.Text += $"{j + 1}; ";
                    }
                }
            
        }
    }
}
