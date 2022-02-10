using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindTestLibrary.Models
{
    public  class WegSchrijven
    {
        public static void WriteListToFile<T>(List<T> list, string path)
        {
            using (var fs = new FileStream(path, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    list.ForEach(x => sw.WriteLine(x));
                }
            }
        }
    }
}
