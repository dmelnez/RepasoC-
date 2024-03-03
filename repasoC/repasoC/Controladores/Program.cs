using repasoC.Dtos;
using repasoC.Servicios;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;

namespace respasoC
{

    class Program
    {

        public static void Main(string[] args)
        {
           
            // Separacion de Elementos en Funcion de un caracter en Especifico.
            Console.WriteLine("Introduzca su Nombre: ");
            string nombreCliente = Console.ReadLine();


            String[] nombreArray;

            nombreArray = nombreCliente.Split(' ');

            Console.WriteLine(nombreArray[0]);
            Console.WriteLine(nombreArray[1]);
            Console.WriteLine(nombreArray[2]);


            // Creacion de un Fichero en Funcion a un Nombre
            string nombreFichero = nombreCliente + ".txt";


            using (StreamWriter sw = new StreamWriter(nombreFichero, true))
            {
                sw.WriteLine("HOLA ESTO ES UNA PRUEBA");
                
            }

            

            // Creacion de un ID Autoincremental
            List<ClienteDtos>listaCliente = new List<ClienteDtos>();
            OperativaInterfaz op = new OperativaImplementacion();


            ClienteDtos nuevoCliente = new ClienteDtos();

            Console.WriteLine("Nombre Cliente Completo: ");
            string nombreCompletoCliente = Console.ReadLine();

            String[] nombreSeparado = nombreCompletoCliente.Split(" ");

            nuevoCliente.NombreCliente = nombreSeparado[0];
            nuevoCliente.Apellido01Cliente = nombreSeparado[1];
            nuevoCliente.Apellido02Cliente = nombreSeparado[2];

            long idAutoincremental = op.idAutogenerado(listaCliente);
            Console.WriteLine(idAutoincremental);

            Console.WriteLine("Fecha de Nacimiento: ");
                
             DateTime fechaNacimientoCliente = Convert.ToDateTime(Console.ReadLine());
             nuevoCliente.FechaNacimiento1 = fechaNacimientoCliente;

            Console.WriteLine(fechaNacimientoCliente.ToString("dd-MM-yyyy HH-mm-ss"));

            // Creacion de un Formato de fecha, en base a una cultura en especifico
            CultureInfo cultureInfo = new CultureInfo("en-US");

            Console.WriteLine(fechaNacimientoCliente.ToString(cultureInfo));

            // Guardar una Fecha en un formato en Especifico

            DateTime formatoEEUU = Convert.ToDateTime(fechaNacimientoCliente, cultureInfo);

            CultureInfo cultureInfo1 = new CultureInfo("en-US");


            // Calculo de Edad del Cliente

            int aniosCliente = fechaNacimientoCliente.Year - DateTime.Now.Year;

           

            if (fechaNacimientoCliente.Month > DateTime.Now.Month )
            {
                if ( fechaNacimientoCliente.Day > DateTime.Now.Day)
                {
                    aniosCliente++;
                }
            }

            nuevoCliente.EdadCliente = Math.Abs(aniosCliente);

            
            // Saber la Diferencia entre dos Fechas Dias

            TimeSpan fechasDiferencia = fechaNacimientoCliente - DateTime.Now;

            long numeroDias = fechasDiferencia.Days;

            long numeroMilisegundos = fechasDiferencia.Milliseconds;

            Console.WriteLine(numeroDias);
            Console.WriteLine(numeroMilisegundos);


            listaCliente.Add(nuevoCliente);


            // Sacar El formato de una Cultura
            DateTimeFormatInfo infoFormatoCulturaEspecifica = CultureInfo.GetCultureInfo("en-US").DateTimeFormat;
            Type tipo = infoFormatoCulturaEspecifica.GetType();
            PropertyInfo[] propiedadesFormatos = tipo.GetProperties();
            DateTime fecha = new DateTime(2012, 5, 28, 11, 35, 0);
            foreach (var propiedad in propiedadesFormatos)
            {
                // Is this a format pattern-related property?
                if (propiedad.Name.Contains("Pattern"))
                {
                    string formato = propiedad.GetValue(infoFormatoCulturaEspecifica, null).ToString();
                    Console.WriteLine(propiedad.Name + ": " + formato + " " +
                                      fecha.ToString(formato));
                }
            }







        }

    }
}
