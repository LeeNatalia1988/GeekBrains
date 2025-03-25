namespace ClinicDesktop
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void Client_Click(object sender, EventArgs e)
        {
            Form clients = new Clients();
            clients.Show();
        }

        private void Consultation_Click(object sender, EventArgs e)
        {
            Form consultation = new Consultations();
            consultation.Show();
        }

        private void Pet_Click(object sender, EventArgs e)
        {
            Form pet = new Pets();
            pet.Show();
        }
    }
}
