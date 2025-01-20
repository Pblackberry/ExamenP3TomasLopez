using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP3TomasLopez
{
    public class Constants
    {
        public const string DBfilename = "Pais.db3";
        public const SQLiteOpenFlags Flags=
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public static string DBpath
        {
            get {
                return Path.Combine(FileSystem.AppDataDirectory, DBfilename);
            }
            
        }


    }
}
