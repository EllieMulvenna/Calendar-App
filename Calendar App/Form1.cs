namespace Calendar_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Event myEvent = new Event()
            {
                Title           = txtTitle.Text,
                Description     = txtDescription.Text,
                Person          = txtPerson.Text,
                StartDateTime   = dtpStartDate.Value,
                EndDateTime     = dtpEndDate.Value
            };

            MessageBox.Show(myEvent.ToString());
        }
    }
}
