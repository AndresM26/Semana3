using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoranAndresS1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLogin : ContentPage
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {

            String user = txtUser.Text;
            String pass = txtPass.Text;

            if ((user == "estudiante2021") && (pass == "uisrael2021"))
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
               DisplayAlert("Datos incorrectos", " Intentar nuevamente", "cerrar");

            }


        }
    }
}