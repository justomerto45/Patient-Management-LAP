using MyPatientManager.Services;
using MyPatientManager.View;

namespace MyPatientManager
{
    public partial class FormLogin : Form
    {
        private ServiceLogin serviceLogin;

        public FormLogin()
        {
            InitializeComponent();
            serviceLogin = new ServiceLogin(new MyPatientManagerDbContext());
            textBoxPasswort.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPasswort.Text;
            bool loginSuccess = serviceLogin.Login(username, password);

            if (loginSuccess)
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var formHome = new FormHome(username);
                formHome.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
