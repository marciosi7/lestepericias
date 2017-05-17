using LestePericiasMobile.Droid;
using LestePericiasMobile.Helpers;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelperDatabase))]
namespace LestePericiasMobile.Droid
{
    class FileHelperDatabase : IFileHelperDatabase
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}