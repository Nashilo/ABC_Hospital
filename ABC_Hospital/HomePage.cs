namespace ABC_Hospital
{
    public partial class HomePage : Form
    {
        public static HomePage HomePageInstance;
        public HomePage()
        {
            InitializeComponent();
            HomePageInstance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
 

            //To show Admin Login Page
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.ShowDialog();   

            

        }

        private void PatientB_Click(object sender, EventArgs e)
        {
            PatientLogin patientLogin = new PatientLogin();
            patientLogin.ShowDialog();

        }
    }
}