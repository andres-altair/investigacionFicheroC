using investigacionFichero.Servicios;
using System.IO;
namespace investigacionFichero
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaArchivo = "log-ddMMyy.txt";
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                string s = "";

                sw.WriteLine("inicio");
            }
            menuInterfaz mi = new menuImplementacion();

            int opcion;
            bool cerrar = false;

            do
            {
                Console.WriteLine("MENÚ INICIAL");
                opcion = mi.menu();
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    string s = "";

                    sw.WriteLine("eleccion de la opcion del menu");
                }
                switch (opcion)
                {

                    case 0:
                        using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                        {
                            string s = "";

                            sw.WriteLine("cierre aplicacion");
                        }
                        Console.WriteLine("Se cierra la aplicación");
                        cerrar = true;
                        break;
                    case 1:
                        using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                        {
                            string s = "";

                            sw.WriteLine("version empleado");
                        }
                        Console.WriteLine("VERSIÓN EMPLEADO");
                        mi.accederVersionEmpleado();

                        break;
                    case 2:
                        using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                        {
                            string s = "";

                            sw.WriteLine("version cliente");
                        }
                        Console.WriteLine("VERSIÓN CLIENTE");
                        mi.accederVersionCliente();
                        break;
                    default:
                        using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                        {
                            string s = "";

                            sw.WriteLine("opcion no coincidente");
                        }
                        Console.WriteLine("No se ha elegido una opción aceptable");
                        break;
                }

            } while (!cerrar);
        }
    }
    
}