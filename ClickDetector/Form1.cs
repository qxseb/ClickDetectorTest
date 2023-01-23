namespace ClickDetector
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            this.label1.Text = "Ai apasat de: " + i + " ori";
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.Green;
                this.button1.BackColor = Color.Red;
            } else
            {
                this.BackColor = Color.Red;
                this.button1.BackColor = Color.Green;
            }
        }
    }
}