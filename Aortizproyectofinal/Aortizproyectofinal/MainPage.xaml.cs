using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aortizproyectofinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        private SQLiteAsyncConnection con;
        public MainPage()
        {
            InitializeComponent();
            con = DependencyService.Get<DataBase>().GetConnection();
        }

        public static IEnumerable<usuario> select_where(SQLiteConnection db, string usuario, string contrasena)
        {
            return db.Query<usuario>("SELECT * FROM usuario where Usuario=? and Contrasena=?", usuario, contrasena);

        }

        private void btnlogin_Clicked(object sender, EventArgs e)
        {
            try
            {

                var ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "aortiz.db3");
                var db = new SQLiteConnection(ruta);


                db.CreateTable<usuario>();
                IEnumerable<usuario> resultado = select_where(db, txtusuario.Text, txtcontraseña.Text);

                if (resultado.Count() > 0)
                {
                    Navigation.PushAsync(new informacion());
                }
                else
                {
                    DisplayAlert("ERROR", "USUARIO/CONTRASEÑA INCORRECTA", "Cerrar");
                }
            }
            catch (Exception)
            {


            }

        }

        private void btnregistrar_Clicked(object sender, EventArgs e)
        {

        }
    }
}
