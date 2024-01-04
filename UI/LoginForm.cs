using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Services.Interfaces;
using DataLayer.DataAccess;
using UI.Developer;
using UI.AdminFolder;

namespace UI
{
    public partial class LoginForm : Form
    {
        private readonly IAuthenticationService _authenticationService;

        

        public LoginForm(IAuthenticationService authenticationService)
        {
            InitializeComponent();
            _authenticationService = authenticationService;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string keyAccess = textBox1.Text;

            var AuthenticatedTechLeader = _authenticationService.TechLeaderAuthenticate(keyAccess);
            var AuthenticatedDeveloper = _authenticationService.DeveloperAuthenticate(keyAccess);

            bool isTechLeaderAuthenticated = AuthenticatedTechLeader != null;
            bool isDeveloperAuthenticated = AuthenticatedDeveloper != null;
            bool isAdminAuthenticated = _authenticationService.AdminAuthenticate(keyAccess);

            if (isTechLeaderAuthenticated)
            {
                MessageBox.Show("BEM VINDO TECH LEADER");
                var techLeaderForm = new TechLeaderForm(AuthenticatedTechLeader);
                techLeaderForm.Show();
                this.Hide();
            }
            else if (isDeveloperAuthenticated)
            {
                MessageBox.Show("BEM VINDO DEVELOPER");
                var developerForm = new DeveloperForm(AuthenticatedDeveloper);
                developerForm.Show();
                this.Hide();
            }
            else if (isAdminAuthenticated)
            {
                MessageBox.Show("BEM VINDO ADMIN");
                var adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("USUARIO NAO ENCONTRADO. TENTE NOVAMENTE");
            }

            

        }
    }
}
