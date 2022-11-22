namespace Patrones.AbstractFactory
{


    class LimonGenetico : IProductoLimon
    {
        public string obtenerDatos()
        {
            return "Limon cambiado geneticamente, 250ml";
        }

        public void producir()
        {
            Console.WriteLine("Buscando Limones");
        }
    }
}