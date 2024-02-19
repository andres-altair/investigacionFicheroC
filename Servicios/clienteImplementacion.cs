using investigacionFichero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigacionFichero.Servicios
{
    internal class clienteImplementacion : clienteInterfaz
    {
        public void registroNuevoCliente(List<ClienteDto> listaClientes , string rutaArchivo)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                string s = "";

                sw.WriteLine("regitro de nuevo cliente");
            }
            Console.WriteLine("REGISTRO DE NUEVO CLIENTE");
            long id = calcularNuevoId(listaClientes);
            Console.WriteLine("Indique el dni: ");
            string dni = Console.ReadLine();
            Console.WriteLine("Indique el nombre completo separado por espacios");
            string nombreConEspacios = Console.ReadLine();
            Console.WriteLine("Indique el email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Indique la contraseña: ");
            string contrasenia = Console.ReadLine();

            ClienteDto nuevoCliente = new ClienteDto(id, dni, nombreConEspacios, email, contrasenia);
            listaClientes.Add(nuevoCliente);
        }

        private long calcularNuevoId(List<ClienteDto> listaClientes)
        {
            
            long idCalculado;
            int tamanioLista = listaClientes.Count;
            if (tamanioLista == 0)
            {
                idCalculado = 1;
            }
            else
            {
                idCalculado = listaClientes[tamanioLista - 1].IdCliente + 1;
            }

            return idCalculado;
        }

        public void accesoCliente(List<ClienteDto> listaClientes, string rutaArchivo)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                string s = "";

                sw.WriteLine("acceso de cliente");
            }
            Console.WriteLine("ACCESO CLIENTE (LOGIN)");
            Console.WriteLine("Email: ");
            string emailAcceso = Console.ReadLine();
            Console.WriteLine("Contraseña: ");
            string contraseniaAcceso = Console.ReadLine();

            foreach (ClienteDto cliente in listaClientes)
            {
                if (cliente.EmailCliente.Equals(emailAcceso) &
                    cliente.ContraseniaCliente.Equals(contraseniaAcceso) &
                    cliente.EsValidado == true)
                {

                    Console.WriteLine("INICIO DE SESIÓN CORRECTO");

                }
                else
                {

                    Console.WriteLine("ERROR EN INICIO DE SESIÓN");

                }
            }

        }
    }
}
