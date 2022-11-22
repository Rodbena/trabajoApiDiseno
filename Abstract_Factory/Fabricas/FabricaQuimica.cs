
namespace Patrones.AbstractFactory
{
    class FabricaQuimica : IFabrica
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
            Console.WriteLine("Estamos produciendo tu limonada");
            limon = new LimonNatural();
            sabor = new SaborLimon();
        }
    }
}