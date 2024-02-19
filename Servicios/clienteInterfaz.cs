using investigacionFichero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigacionFichero.Servicios
{
    internal interface clienteInterfaz
    {
        public void registroNuevoCliente(List<ClienteDto> listaClientes, string rutaArchivo);

        public void accesoCliente(List<ClienteDto> listaClientes, string rutaArchivo);
    }
}
