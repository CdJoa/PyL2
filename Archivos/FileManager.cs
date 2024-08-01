using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Archivos
{
    public static class FileManager
    {
        private static string path;
        static FileManager()
        {
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "");
            ValidaExitenciaDeDirectorio();

        }

        public static void Guardar<T>(T elemento, string nombreArhivo) where T : class
        {
            if (elemento is not null && nombreArhivo is not null)
            {
                string extension = Path.GetExtension(nombreArhivo);
                if (extension == ".json")
                {
                    try
                    {
                        string ruta = Path.Combine(path, nombreArhivo);

                        bool apenda = false;
                        using (StreamWriter stream = new StreamWriter(ruta, apenda))
                        {
                            JsonSerializerOptions opciones = new JsonSerializerOptions();
                            opciones.WriteIndented = true;

                            string json = JsonSerializer.Serialize(elemento, opciones);
                            stream.WriteLine(json);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new FileManagerException("Error al guardar JSON", ex);
                    }
                }
                else if (extension == ".txt")
                {
                    try
                    {
                        string ruta = Path.Combine(path, nombreArhivo);

                        bool apenda = true;
                        using (StreamWriter stream = new StreamWriter(ruta, apenda))
                        {
                            stream.WriteLine($"{elemento}{Environment.NewLine}");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new FileManagerException("Error al guardar Texto", ex);
                    }
                }
                else
                {
                    throw new FileManagerException("Extension no permitida");
                }
            }
        }

        public static void ValidaExitenciaDeDirectorio()
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception ex)
            {
                throw new FileManagerException("Error al crear el directorio", ex);
            }
        }

    }
}

}
