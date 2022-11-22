namespace Patrones.AbstractFactory
{


    class LimonNatural : IProductoLimon
    {
        public string obtenerDatos()
        {
            return "Ague de Limon, 250ml";
        }

        public void producir()
        {
            Console.WriteLine("Ordeñar limones en la granja");
        }
    }
}