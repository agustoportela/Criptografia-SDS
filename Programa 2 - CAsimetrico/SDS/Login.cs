using SDS.back.colecciones;
using SDS.back.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDS
{
    public partial class Login : Form
    {

        private Coleccion_usuarios colecionUsuarios;

        public Login()
        {
            InitializeComponent();
            colecionUsuarios = new Coleccion_usuarios();
        }

 
        private void login(object sender, EventArgs e)
        {

            var usuario = colecionUsuarios.Login(txt_nick.Text, txt_pass.Text);

            if (usuario.Count == 0)
            {
                MessageBox.Show("te confunduste pichon");
                return;
            }
            

            var user = usuario.First();

            var principal = new Principal(user);
            principal.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
