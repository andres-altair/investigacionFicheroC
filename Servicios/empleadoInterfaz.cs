using investigacionFichero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigacionFichero.Servicios
{
    internal interface empleadoInterfaz
    {
        public void validarCliente(List<ClienteDto> listaClientes, string rutaArchivo);
        public void borrarCliente(List<ClienteDto> listaClientes, string rutaArchivo);
        public void mostrarClientes(List<ClienteDto> listaClientes, string rutaArchivo);
    }
}
