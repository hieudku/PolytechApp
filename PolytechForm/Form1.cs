using PolytechLibrary;

namespace PolytechForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var testpolytech = new Polytech();
            //assign all field values from user inputs using propertestpolytech.Name = txtName.Text;
            testpolytech.Name = txtName.Text;
            testpolytech.Address = txtAddress.Text;
            testpolytech.City = txtCity.Text;
            testpolytech.Region = txtRegion.Text;
            testpolytech.PhoneNumber = txtPhone.Text;
            testpolytech.Postcode = Int32.Parse(txtPostcode.Text);
            testpolytech.TwitterAddress = txtTwitter.Text;
            try
            {
                testpolytech.TwitterAddress = txtTwitter.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}