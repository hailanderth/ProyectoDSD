using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD.GA.SERVICES;
using MD.GA.GUI.Session;
using System.Threading;

namespace MD.GA.GUI.GA
{
    public partial class login : Form
    {

        private String user;
        private String pass;
        public login()
        {
            InitializeComponent();

        }


        private void capturarDatos() {
            user = txtlogin1.Text;
            pass = txtlogin2.Text;
        }

        private async void iniciarSesion()
        {
            try
            {
                using (IServiceAlmacen service = new ServiceAlmacen())
                {
                    capturarDatos();
                    var response = await service.UsuarioValidarLoginAsync(user, pass);
                    if (response.IsValid)
                    {
                        CurrentSession.Usuario = response.Value;
                        this.Hide();
                        GA.Menu_Principal menuprincipal = new Menu_Principal();
                        menuprincipal.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show(response.ErrorMensaje, "Aviso");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }
        private void btnlogin1_Click(object sender, EventArgs e)
        {
            iniciarSesion(); 
        }


        private async void login_Load(object sender, EventArgs e)
        {
            using (IServiceAlmacen service = new ServiceAlmacen())
            {
                var response = await service.UsuarioGetServerDateAsync();
            }
        }

        private void txtlogin2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToString(e.KeyChar) == "\r")
            {
                iniciarSesion();
            }
        }

    }
}
