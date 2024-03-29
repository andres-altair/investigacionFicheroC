﻿using investigacionFichero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigacionFichero.Servicios
{
    internal class menuImplementacion  :menuInterfaz
    {
        List<ClienteDto> listaClientes = new List<ClienteDto>();
        public int menu()
        {
            int opcion;

            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Versión empleado");
            Console.WriteLine("2. Versión cliente");
            Console.WriteLine("Escriba la opción deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public void accederVersionEmpleado()
        {
            empleadoInterfaz ei = new empleadoImplementacion();

            int opcionEmpleado;
            opcionEmpleado = mostrarMenuEmpleadoYSeleccion();

            switch (opcionEmpleado)
            {
                case 0:
                    break;
                case 1:
                    ei.validarCliente(listaClientes);
                    break;
                case 2:
                    ei.borrarCliente(listaClientes);
                    break;
                case 3:
                    ei.mostrarClientes(listaClientes);
                    break;
                default:
                    Console.WriteLine("No ha seleccionado una opción aceptable vuelve al menú inicial.");
                    break;
            }
        }
        private int mostrarMenuEmpleadoYSeleccion()
        {
            int opcion;

            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Validar cliente");
            Console.WriteLine("2. Borrar cliente");
            Console.WriteLine("3. Mostrar clientes");
            Console.WriteLine("Escriba la opción deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public void accederVersionCliente()
        {
            clienteInterfaz ci = new clienteImplementacion();

            int opcionCliente;
            opcionCliente = mostrarMenuClienteYSeleccion();

            switch (opcionCliente)
            {
                case 0:
                    break;
                case 1:
                    ci.registroNuevoCliente(listaClientes);
                    break;
                case 2:
                    ci.accesoCliente(listaClientes);
                    break;
                default:
                    Console.WriteLine("No ha seleccionado una opción aceptable vuelve al menú inicial.");
                    break;
            }
        }
        private int mostrarMenuClienteYSeleccion()
        {
            int opcion;

            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Registro cliente");
            Console.WriteLine("2. Acceso cliente (login)");
            Console.WriteLine("Escriba la opción deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
