using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4AnalisisGuia9
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Programa que indica el mes con mayor venta, con menor venta, el promedio de ventas y los meses con ventas menores que el promedio";

        Double enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre, promedio;
        
        Console.WriteLine("Digite el total de ventas del mes de enero: ");
        Console.Write("$");
        enero = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite el total de ventas del mes de febrero: ");
        Console.Write("$");
        febrero = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite el total de ventas del mes de marzo: ");
        Console.Write("$");
        marzo = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite el total de ventas del mes de abril: ");
        Console.Write("$");
        abril = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite el total de ventas del mes de mayo: ");
        Console.Write("$");
        mayo = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite el total de ventas del mes de junio: ");
        Console.Write("$");
        junio = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite el total de ventas del mes de julio: ");
        Console.Write("$");
        julio = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite el total de ventas del mes de agosto: ");
        Console.Write("$");
        agosto = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite el total de ventas del mes de septiembre: ");
        Console.Write("$");
        septiembre = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite el total de ventas del mes de octubre: ");
        Console.Write("$");
        octubre = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite el total de ventas del mes de noviembre: ");
        Console.Write("$");
        noviembre = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite el total de ventas del mes de diciembre: ");
        Console.Write("$");
        diciembre = Double.Parse(Console.ReadLine());

        Console.WriteLine();

        if (enero > febrero && enero > marzo && enero > abril && enero > mayo && enero > junio && enero > julio && enero > agosto && enero > septiembre && enero > octubre && enero > noviembre && enero > diciembre)
        {
        Console.WriteLine("El mes con mayor venta fue enero.");
        }

        if (febrero > enero && febrero > marzo && febrero > abril && febrero > mayo && febrero > junio && febrero > julio && febrero > agosto && febrero > septiembre && febrero > octubre && febrero > noviembre && febrero > diciembre)
        {
        Console.WriteLine("El mes con mayor venta fue febrero.");
        }

        if (marzo > enero && marzo > febrero && marzo > abril && marzo > mayo && marzo > junio && marzo > julio && marzo > agosto && marzo > septiembre && marzo > octubre && marzo > noviembre && marzo > diciembre)
        {
        Console.WriteLine("El mes con mayor venta fue marzo.");
        }

        if (abril > enero && abril > febrero && abril > marzo && abril > mayo && abril > junio && abril > julio && abril > agosto && abril > septiembre && abril > octubre && abril > noviembre && abril > diciembre)
        {
        Console.WriteLine("El mes con mayor venta fue abril.");
        }

        if (mayo > enero && mayo > febrero && mayo > marzo && mayo > abril && mayo > junio && mayo > julio && mayo > agosto && mayo > septiembre && mayo > octubre && mayo > noviembre && mayo > diciembre)
        {
        Console.WriteLine("El mes con mayor venta fue mayo.");
        }
        
        if (junio > enero && junio > febrero && junio > marzo && junio > abril && junio > mayo && junio > julio && junio > agosto && junio > septiembre && junio > octubre && junio > noviembre && junio > diciembre)
        {
        Console.WriteLine("El mes con mayor venta fue junio.");
        }
        
        if (julio > enero && julio > febrero && julio > marzo && julio > abril && julio > mayo && julio > junio && julio > agosto && julio > septiembre && julio > octubre && julio > noviembre && julio > diciembre)
        {
        Console.WriteLine("El mes con mayor venta fue julio.");
        }

        
        if (agosto > enero && agosto > febrero && agosto > marzo && agosto > abril && agosto > mayo && agosto > junio && agosto > julio && agosto > septiembre && agosto > octubre && agosto > noviembre && agosto > diciembre)
        {
        Console.WriteLine("El mes con mayor venta fue agosto.");
        }

        if (septiembre > enero && septiembre > febrero && septiembre > marzo && septiembre > abril && septiembre > mayo && septiembre > junio && septiembre > julio && septiembre > agosto && septiembre > octubre && septiembre > noviembre && septiembre > diciembre)
        {
        Console.WriteLine("El mes con mayor venta fue septiembre.");
        }

        if (octubre > enero && octubre > febrero && octubre > marzo && octubre > abril && octubre > mayo && octubre > junio && octubre > julio && octubre > agosto && octubre > septiembre && octubre > noviembre && octubre > diciembre)
        {
        Console.WriteLine("El mes con mayor venta fue octubre.");
        }
                
        if (noviembre > enero && noviembre > febrero && noviembre > marzo && noviembre > abril && noviembre > mayo && noviembre > junio && noviembre > julio && noviembre > agosto && noviembre > septiembre && noviembre > octubre && noviembre > diciembre)
        {
        Console.WriteLine("El mes con mayor venta fue noviembre.");
        }

        if (diciembre > enero && diciembre > febrero && diciembre > marzo && diciembre > abril && diciembre > mayo && diciembre > junio && diciembre > julio && diciembre > agosto && diciembre > septiembre && diciembre > octubre && diciembre > noviembre)
        {
        Console.WriteLine("El mes con mayor venta fue diciembre.");
        }

        // apartir de aca todo igual solo cambiar el mayor que por menor que y la leyenda el mes con menor venta fue: 


        if (enero < febrero && enero < marzo && enero < abril && enero < mayo && enero < junio && enero < julio && enero < agosto && enero < septiembre && enero < octubre && enero < noviembre && enero < diciembre)
        {
        Console.WriteLine("El mes con menor venta fue enero.");
        }

        if (febrero < enero && febrero < marzo && febrero < abril && febrero < mayo && febrero < junio && febrero < julio && febrero < agosto && febrero < septiembre && febrero < octubre && febrero < noviembre && febrero < diciembre)
        {
        Console.WriteLine("El mes con menor venta fue febrero.");
        }

        if (marzo < enero && marzo < febrero && marzo < abril && marzo < mayo && marzo < junio && marzo < julio && marzo < agosto && marzo < septiembre && marzo < octubre && marzo < noviembre && marzo < diciembre)
        {
        Console.WriteLine("El mes con menor venta fue marzo.");
        }

        if (abril < enero && abril < febrero && abril < marzo && abril < mayo && abril < junio && abril < julio && abril < agosto && abril < septiembre && abril < octubre && abril < noviembre && abril < diciembre)
        {
        Console.WriteLine("El mes con menor venta fue abril.");
        }

        if (mayo < enero && mayo < febrero && mayo < marzo && mayo < abril && mayo < junio && mayo < julio && mayo < agosto && mayo < septiembre && mayo < octubre && mayo < noviembre && mayo < diciembre)
        {
        Console.WriteLine("El mes con menor venta fue mayo.");
        }

        if (junio < enero && junio < febrero && junio < marzo && junio < abril && junio < mayo && junio < julio && junio < agosto && junio < septiembre && junio < octubre && junio < noviembre && junio < diciembre)
        {
        Console.WriteLine("El mes con menor venta fue junio.");
        }

        if (julio < enero && julio < febrero && julio < marzo && julio < abril && julio < mayo && julio < junio && julio < agosto && julio < septiembre && julio < octubre && julio < noviembre && julio < diciembre)
        {
        Console.WriteLine("El mes con menor venta fue julio.");
        }

        if (agosto < enero && agosto < febrero && agosto < marzo && agosto < abril && agosto < mayo && agosto < junio && agosto < julio && agosto < septiembre && agosto < octubre && agosto < noviembre && agosto < diciembre)
        {
        Console.WriteLine("El mes con menor venta fue agosto.");
        }

        if (septiembre < enero && septiembre < febrero && septiembre < marzo && septiembre < abril && septiembre < mayo && septiembre < junio && septiembre < julio && septiembre < agosto && septiembre < octubre && septiembre < noviembre && septiembre < diciembre)
        {
        Console.WriteLine("El mes con menor venta fue septiembre.");
        }

        if (octubre < enero && octubre < febrero && octubre < marzo && octubre < abril && octubre < mayo && octubre < junio && octubre < julio && octubre < agosto && octubre < septiembre && octubre < noviembre && octubre < diciembre)
        {
        Console.WriteLine("El mes con menor venta fue octubre.");
        }

        if (noviembre < enero && noviembre < febrero && noviembre < marzo && noviembre < abril && noviembre < mayo && noviembre < junio && noviembre < julio && noviembre < agosto && noviembre < septiembre && noviembre < octubre && noviembre < diciembre)
        {
        Console.WriteLine("El mes con menor venta fue noviembre.");
        }

        if (diciembre < enero && diciembre < febrero && diciembre < marzo && diciembre < abril && diciembre < mayo && diciembre < junio && diciembre < julio && diciembre < agosto && diciembre < septiembre && diciembre < octubre && diciembre < noviembre)
        {
        Console.WriteLine("El mes con menor venta fue diciembre.");
        }

        // promedio
        
        promedio = (enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + noviembre + diciembre)/ 12;

        Console.WriteLine("El promedio de ventas del año es de: $" + promedio);

        // meses menores que el promedio
        Console.WriteLine("Los meses que generaron ventas menores que el promedio de $" + promedio + " fueron:");
        
        if (enero < promedio)
        {
        Console.WriteLine("Enero");
        }

        if (febrero < promedio)
        {
        Console.WriteLine("Febrero");
        }

        if (marzo < promedio)
        {
        Console.WriteLine("Marzo");
        }
        
        if (abril < promedio)
        {
        Console.WriteLine("Abril");
        }
        
        if (mayo < promedio)
        {
        Console.WriteLine("Mayo");
        }
        
        if (junio < promedio)
        {
        Console.WriteLine("Junio");
        }
        
        if (julio < promedio)
        {
        Console.WriteLine("Julio");
        }
        
        if (agosto < promedio)
        {
        Console.WriteLine("Agosto");
        }
        
        if (septiembre < promedio)
        {
        Console.WriteLine("Septiembre");
        }
        
        if (octubre < promedio)
        {
        Console.WriteLine("Octubre");
        }
        
        if (noviembre < promedio)
        {
        Console.WriteLine("Noviembre");
        }
        
        if (diciembre < promedio)
        {
        Console.WriteLine("Diciembre");
        }
        
        
        Console.ReadKey();
        }
    }
}
