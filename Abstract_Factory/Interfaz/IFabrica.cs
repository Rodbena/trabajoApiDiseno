// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    interface IFabrica
    {
        void crearProducto();
        IProductoLimon ObtenerProductoLimon { get; }
        IProductoSaborizante ObtenerSabor { get; }
        

    }
}

