using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aortizproyectofinal
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection();
    }
}
