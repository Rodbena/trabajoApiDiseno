// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fabrica 1
            IFabrica mifabrica = new FabricaQuimica();
            mifabrica.crearProducto();

            IProductoLimon _limon_ = mifabrica.ObtenerProductoLimon;
            IProductoSaborizante _sabor_ = mifabrica.ObtenerSabor;

            _limon_.producir();
            _limon_.obtenerDatos();

            Console.WriteLine("_Mi limonada es de {0} y {1}", _limon_.obtenerDatos(), _sabor_.informacion());
            Console.WriteLine("---");
            

            
            // Fabrica 2
            mifabrica = new FabricaNatural();
            mifabrica.crearProducto();

            _limon_ = mifabrica.ObtenerProductoLimon;
            _sabor_ = mifabrica.ObtenerSabor;

            _limon_.producir();
            _limon_.obtenerDatos();

            Console.WriteLine("-Mi limonada es de {0} y {1}", _limon_.obtenerDatos(), _sabor_.informacion());


        }
    }
}

