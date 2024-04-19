namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked;
            checkedListBox1.CheckOnClick = true;
            MessageBox.Show("Была нажата кнопка :)", "Кнопка нажиматель");

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Была нажат messageBox1", "NHFV GFV GFV");
        }
    }
}
