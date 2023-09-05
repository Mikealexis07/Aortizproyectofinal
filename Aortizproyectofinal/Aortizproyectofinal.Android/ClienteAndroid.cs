using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using Aortizproyectofinal.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(ClienteAndroid))]

namespace Aortizproyectofinal.Droid
{
    public class ClienteAndroid : DataBase
    {
        public SQLiteAsyncConnection GetConnection()
        {
            
            
            var ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
          
            var baseDatos = Path.Combine(ruta, "aortiz.db3");
            return new SQLiteAsyncConnection(baseDatos);
            
        }
    }
}