using backend;
using helpers;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections;

namespace frontend
{
    public partial class main : MaterialForm
    {
        /// <summary>
        /// Initialisation of global variables
        /// </summary>
        String pc1 = "";
        String pc2 = "";
        double miles = 0;
        double km = 0;
        ArrayList data;
        Boolean hasData = false;
        public main()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
        }   

        /// <summary>
        /// This is ran when the enter key is pressed or when the submit button is pressed
        /// Shows all of the information from the ArrayList from the backend
        /// </summary>
        private void submitButton_Click(object sender, EventArgs e)
        {
            pc1 = postCode1Input.Text;
            pc2 = postCode2Input.Text;
            data = backend.main.grabInfo(pc1, pc2);
            try
            {
                if (data[4] is string)
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
            } catch (Exception ex)
            {
                backend.main.logger.Fatal("No data has been retrieved from the API");
                hasData = false;
            }
            
            
        }

        /// <summary>
        /// This method toggles the distance measure of KM and Miles
        /// </summary>
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