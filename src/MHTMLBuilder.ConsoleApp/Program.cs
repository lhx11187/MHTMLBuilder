using System;
using System.Text.RegularExpressions;

namespace MHTMLBuilder.ConsoleApp
{
    class Program
    {
        static MHTMLBuilder.Builder _mht = new Builder();
        static void Main(string[] args)
        {
            string Url = "https://cfpage.sfcs.ml/";
            string SaveFileName = "";
            if (args.Length > 0)
            {
                Url = args[0];
            }
            Console.WriteLine(Url);
            SaveFileName = Regex.Replace(Url, "([^a-z0-9.])", "_", RegexOptions.IgnoreCase)+".mht";
            if (SaveFileName.Length > 100)
                SaveFileName = SaveFileName.Split('_')[SaveFileName.Split('_').Length];
            MHTMLBuilder.Builder.FileStorage st = Builder.FileStorage.Memory;
            st = MHTMLBuilder.Builder.FileStorage.Memory;
            //try 
            {
                _mht.SavePageArchive(SaveFileName, st, Url);
                Console.WriteLine("save ok:" + Url);
            }
            //catch (Exception e) 
            {
                //Console.WriteLine(e.Message);
            }            
        }
    }
}
