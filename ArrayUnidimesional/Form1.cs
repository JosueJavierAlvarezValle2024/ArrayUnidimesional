using System.Windows.Forms.VisualStyles;

namespace ArrayUnidimesional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int NumberOfPeoples;
        private int[] Ages;

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPersons.Text, out NumberOfPeoples))
            {
                Ages = new int[NumberOfPeoples];
                lblAges.Text = "Enter ages:";
                txtPersons.Enabled = false;
                btnAccept.Enabled = false;
                txtAges.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] agesEntered = txtAges.Text.Split(',');
            if (agesEntered.Length != NumberOfPeoples)
            {
                MessageBox.Show("The number of ages entered does not match the number of people.");
                return;
            }

            for (int i = 0; i < NumberOfPeoples; i++)
            {
                if (!int.TryParse(agesEntered[i], out Ages[i]))
                {
                    MessageBox.Show("Please enter valid ages for all people.");
                    return;
                }
            }

            Showages();
        }

        private void Showages()
        {
            string agesText = "Ages entered:\n";
            for (int i = 0; i < NumberOfPeoples; i++)
            {
                agesText += $"Person {i + 1}: {Ages[i]}\n";
            }
            lblAges.Text = agesText;
        }


    }
}


