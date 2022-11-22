
namespace Patrones.AbstractFactory
{
    class FabricaNatural : IFabrica
    {
        private IProductoLimon limon;
        private IProductoSaborizante sabor;
       
        public IProductoLimon ObtenerProductoLimon
        {
            get { return limon; }
        }

        public IProductoSaborizante ObtenerSabor
        {
            get { return sabor; }
        }

        public void crearProducto()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string selection = "";
            Console.WriteLine("Estamos creando tu bebida");
            Console.WriteLine("1) Natural\n2)Genetico\n");
            selection = "2";

            switch (selection)
            {
                case "1":
                    limon = new LimonNoNatural();
                    break;
                
                case "2":
                    limon = new LimonGenetico();
                break;
                
                default:
                    limon = new LimonGenetico();
            }

            limon.producir();
            Console.WriteLine("Ahora extraemos el sabor");
            sabor = new SaborLimonMora();
            sabor.obtener();
        }
    }
}