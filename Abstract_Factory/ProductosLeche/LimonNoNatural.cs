namespace Patrones.AbstractFactory
{


    class LimonNoNatural : IProductoLimon
    {
        public string obtenerDatos()
        {
            return "Limons no naturales (geneticamente cambiados), 250ml";
        }

        public void producir()
        {
            Console.WriteLine("Procesar los limones");
        }
    }
}