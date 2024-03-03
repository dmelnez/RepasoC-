using repasoC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoC.Servicios
{
    internal interface OperativaInterfaz
    {
        public long idAutogenerado(List<ClienteDtos>listaClientes);
    }
}
