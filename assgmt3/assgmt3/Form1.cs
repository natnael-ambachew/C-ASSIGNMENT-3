using assgmt3.model;
namespace assgmt3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            product c = new product { name =txt_name.Text, Id =int.Parse(txt_id.Text), coast = int.Parse(txt_coast.Text), price = int.Parse(txt_price.Text), number = int.Parse(txtt_number.Text)};
            MessageBox.Show("the product " + txt_name.Text + "is successfuly saved");
            c.save();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}