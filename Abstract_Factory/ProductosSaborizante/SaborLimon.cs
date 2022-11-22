namespace Patrones.AbstractFactory
{


    class SaborLimon : IProductoSaborizante
    {
        public string informacion()
        {
            return "Limon natural";
        }

        public void obtener()
        {
            Console.WriteLine("Se produce LimonSD23");
        }
    }
}