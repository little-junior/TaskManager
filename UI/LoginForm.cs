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

namespace UI
{
    //public enum UserType
    //{
    //    Developer,
    //    TechLeader
    //}

    public partial class LoginForm : Form
    {
        private readonly IAuthenticationService _authenticationService;

        //private UserType _userType;

        public LoginForm(IAuthenticationService authenticationService)
        {
            InitializeComponent();
            _authenticationService = authenticationService;
        }

        //    public LoginForm(IAuthenticationService authenticationService)
        //    {
        //        InitializeComponent();
        //        _authenticationService = authenticationService;
        //    }

        private void button1_Click(object sender, EventArgs e)
        {

            //_userType = DetermineUserType(textBox1.Text);

            //OpenCorrespondingForm();



            string keyAccess = textBox1.Text;

            var AutenticatedTechLeader = _authenticationService.TechLeaderAuthenticate(keyAccess);
            var AutenticatedDeveloper = _authenticationService.DeveloperAuthenticate(keyAccess);

            bool isTechLeaderAutenticated = AutenticatedTechLeader != null;
            bool isDeveloperAutenticated = AutenticatedDeveloper != null;

            if (isTechLeaderAutenticated)
            {
                MessageBox.Show("BEM VINDO TECH LEADER");
                var techLeaderForm = new TechLeaderForm(AutenticatedTechLeader);
                techLeaderForm.Show();
                this.Hide();
            }
            else if (isDeveloperAutenticated)
            {
                MessageBox.Show("BEM VINDO DEVELOPER");
                var developerForm = new DeveloperForm(AutenticatedDeveloper);
                developerForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("USUARIO NAO ENCONTRADO. TENTE NOVAMENTE");
            }

            //private UserType DetermineUserType(string keyAccess)
            //{
            //    // Implemente a lógica para determinar o tipo de usuário com base no keyAccess
            //    // Pode ser algo simples, como verificar se o keyAccess começa com "tec" para TechLeader
            //    return keyAccess.StartsWith("tec") ? UserType.TechLeader : UserType.Developer;
            //}

            //private void OpenCorrespondingForm()
            //{
            //    // Abrir o formulário correspondente com base no tipo de usuário
            //    switch (_userType)
            //    {
            //        case UserType.Developer:
            //            var developerForm = new DeveloperForm();
            //            developerForm.Show();
            //            break;

            //        case UserType.TechLeader:
            //            var techLeaderForm = new TechLeaderForm();
            //            techLeaderForm.Show();
            //            break;

            //        // Adicione casos para outros tipos de usuário, se necessário

            //        default:
            //            break;
            //    }

            //    // Fechar o formulário de login após abrir o formulário correspondente
            //    this.Hide();
            //}
            //    }

        }
    }
}
