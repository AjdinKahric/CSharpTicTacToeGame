

namespace WinFormsApp1 {
    public partial class EntryForm : Form {
        public EntryForm() {
            InitializeComponent();
        }

        private void EntryForm_Load(object sender, EventArgs e) {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }

        private void label1_Click_1(object sender, EventArgs e) {
           
        }
        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            Form1 form1 = new Form1(textBox1.Text, textBox2.Text);
            form1.ShowDialog();
            form1.FormClosed += Form1_FormClosed;
            this.Dispose();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            this.Close(); 
        }
    }

  

}
