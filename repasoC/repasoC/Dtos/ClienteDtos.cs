using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoC.Dtos
{
    internal class ClienteDtos
    {

        long idCliente;

        string nombreCompletoCliente = "aaaaa";

        string nombreCliente = "aaaaa"; 

        string apellido01Cliente = "aaaaa";

        string apellido02Cliente = "aaaaa";

        DateTime FechaNacimiento;

        int edadCliente = 11111;

        public ClienteDtos(long idCliente, string nombreCompletoCliente, string nombreCliente, string apellido01Cliente, string apellido02Cliente, DateTime fechaNacimiento, int edadCliente)
        {
            this.idCliente = idCliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            this.nombreCliente = nombreCliente;
            this.apellido01Cliente = apellido01Cliente;
            this.apellido02Cliente = apellido02Cliente;
            FechaNacimiento = fechaNacimiento;
            this.edadCliente = edadCliente;
        }

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido01Cliente { get => apellido01Cliente; set => apellido01Cliente = value; }
        public string Apellido02Cliente { get => apellido02Cliente; set => apellido02Cliente = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public int EdadCliente { get => edadCliente; set => edadCliente = value; }

        public  ClienteDtos() { }
    }
}
