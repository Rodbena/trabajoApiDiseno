namespace Builder03
{
    class Program
    {
        static void Main(string[] args)
        {
            Director miDirector = new Director();
            BuilderNormal normal = new BuilderNormal();
            miDirector.Construye(normal);
            Producto compu1 = normal.ObtenProducto();
            compu1.MostrarCompu();
        }
    }
}