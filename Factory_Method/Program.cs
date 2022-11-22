using MetodoFabrica02.Fabrica;
using MetodoFabrica02.Fabrica.Creadores;

namespace MetodoFabrica02
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            IComputadora computadora;
            Console.WriteLine("Cuanto dinero tienes para tu computadora?");
            //dato = Console.ReadLine();
            dato = "1000000";
            dinero = Convert.ToInt32(dato);
            // Obtenemos el vehiculo de la fabrica
            computadora = CCreador.MetodoFabrica(dinero);
            computadora.Encender();
            computadora.Trabajar();
            computadora.Apagar();
            computadora.CambiarComponentes();
        }
    }
}