using System;
using System.IO;
using System.Linq;
using System.Text;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Local
    {
        public void SaveData(CE_Time t)
        {
            string pathString = @".\Data";

            System.IO.Directory.CreateDirectory(pathString);

            string fileName = $"Registro.txt";

            pathString = System.IO.Path.Combine(pathString, fileName);

            using (System.IO.FileStream fs = new System.IO.FileStream(pathString, FileMode.Truncate))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    string text = $"{t.UsuarioId}#{t.AutoId}";
                    sw.WriteLine(text);
                }
            }
        }
        public CE_Time LoadData(CE_Time t)
        {
            string pathString = @".\Data";

            string fileName = $"Registro.txt";

            pathString = System.IO.Path.Combine(pathString, fileName);

            using (FileStream fs = new FileStream(pathString, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Default))
                {
                    string cadena = string.Empty;
                    while ((cadena = sr.ReadLine()) != null)
                    {
                        string[] Decoded = cadena.Split('#').ToArray();
                        t.UsuarioId = Convert.ToInt64(Decoded[0]);
                        t.AutoId = Convert.ToInt64(Decoded[1]);
                    }
                }
            }
            return t;
        }
    }
}
