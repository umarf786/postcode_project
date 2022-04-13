using backend;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections;
namespace frontend
{
    public partial class Form1 : MaterialForm
    {

        String pc1 = "s";
        String pc2 = "";
        double miles = 0;
        double km = 0;
        ArrayList data;
        Boolean isChecked = false;
        Boolean hasData = false;
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void postCode1Input_Click(object sender, EventArgs e)
        {
            
        }

        private void postCode2Input_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Frontend Running");
            pc1 = postCode1Input.Text;
            pc2 = postCode2Input.Text;
            data = Program1.grabInfo(pc1, pc2);
            if(data[4] is string)
            {
                materialLabel4.Text = "Distance: " + data[0] + " miles";
                materialLabel1.Text = "Origin: " + data[2];
                materialLabel2.Text = "Dest: " + data[3];
                materialLabel3.Text = "Driving Time: " + data[4];
                materialProgressBar1.Value = 1;
                materialProgressBar1.Maximum = 5;
                materialProgressBar1.Value = 5;
                hasData = true;
            }
            
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (hasData) {
                if (materialSwitch1.Checked == true)
                {
                    materialLabel4.Text = "Distance: " + data[1] + " km";
                }
                else
                {
                    materialLabel4.Text = "Distance: " + data[0] + " miles";
                }
            }
            else
            {
                materialSwitch1.Checked = false;
            }
        }
    }
}