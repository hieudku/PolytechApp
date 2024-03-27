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
            try
            {
                var testpolytech = new Polytech();
                //assign all field values from user inputs using propertestpolytech.Name = txtName.Text;
                if (testpolytech == null)
                {
                    throw new Exception("Some fields are empty! Please fill");
                }
                testpolytech.Name = txtName.Text;
                testpolytech.Address = txtAddress.Text;
                testpolytech.City = txtCity.Text;
                testpolytech.Region = txtRegion.Text;

                if (Int32.TryParse(txtPhone.Text, out int phone))
                {

                    testpolytech.PhoneNumber = Int32.Parse(txtPhone.Text);
                    txtPhone.Text.ToString().Trim();
                }
                else
                {
                    throw new Exception("Integer input for Phone number only.");
                }

                if (Int32.TryParse(txtPostcode.Text, out int postcode))
                {
                    testpolytech.Postcode = Int32.Parse(txtPostcode.Text);
                    txtPostcode.Text.ToString().Trim();
                }
                else
                {
                    throw new Exception("Integer input for Postcode only.");
                }


                testpolytech.TwitterAddress = txtTwitter.Text;
                MessageBox.Show(testpolytech.ToString());


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