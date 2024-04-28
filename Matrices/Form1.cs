namespace Matrices
{
    public partial class Form1 : Form
    {
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            n = (int)numericUpDown1.Value;
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();

            for (int i = 0; i < n; i++)
            {
                DataGridViewColumn columna1 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna1.Name = (i + 1).ToString();
                columna1.Width = 24;
                dataGridView1.Columns.Add(columna1);
                DataGridViewColumn columna2 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna2.Name = (i + 1).ToString();
                columna2.Width = 24;
                dataGridView2.Columns.Add(columna2);
                DataGridViewColumn columna3 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna3.Name = (i + 1).ToString();
                columna3.Width = 24;
                dataGridView3.Columns.Add(columna3);

            }
            dataGridView1.Rows.Add(n);
            dataGridView2.Rows.Add(n);
            dataGridView3.Rows.Add(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1[i, j].Value = r.Next(10) + 1;
                    dataGridView2[i, j].Value = r.Next(10) + 1;
                    dataGridView3[i, j].Value = r.Next(10) + 1;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView3[i, j].Value = int.Parse(dataGridView1[i, j].Value.ToString())
                    + int.Parse(dataGridView2[i, j].Value.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView3[i, j].Value = int.Parse(dataGridView1[i, j].Value.ToString())
                    - int.Parse(dataGridView2[i, j].Value.ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView3[i, j].Value = int.Parse(dataGridView1[i, j].Value.ToString())
                    * int.Parse(dataGridView2[i, j].Value.ToString());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView3[i, j].Value = int.Parse(dataGridView1[i, j].Value.ToString())
                    / int.Parse(dataGridView2[i, j].Value.ToString());
                }
            }
        }
    }
}
