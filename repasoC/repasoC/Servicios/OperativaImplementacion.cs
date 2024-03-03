using repasoC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoC.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public long idAutogenerado(List<ClienteDtos> listaClientes)
        {

            long id = 0;

            int tamnioLista = listaClientes.Count;

            if (listaClientes.Count == 0)
            {

                id = 1;

            }

            else
            {

                id = listaClientes[tamnioLista - 1].IdCliente;
                id = id + 1;

            }


            return id;

        }

    }
}

