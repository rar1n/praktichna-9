namespace _123123123
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            dataGridView1.Rows.Clear();
            Random ran = new Random();
            try
            {
                n = Convert.ToInt32(textBox1.Text);
                Arrays a = new Arrays(n);
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = ran.Next(-100, 100);
                    dataGridView1.Rows.Add(a[i].ToString());
                }
                if (a.error) MessageBox.Show("Помилка обробки даних");
                label2.Text = "Мінімальний елемент массива: " + a.Min.ToString();
            }
            catch
            {
                MessageBox.Show("Помилка введення даних");
            }
        }
    }
}
