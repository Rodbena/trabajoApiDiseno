namespace Patrones.AbstractFactory
{


    class SaborLimonMora : IProductoSaborizante
    {
        public string informacion()
        {
            return "Limon con Mora Azul";
        }

        public void obtener()
        {
            Console.WriteLine("Se produce LimonMora12WER");
        }
    }
}