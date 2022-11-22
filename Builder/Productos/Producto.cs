namespace Builder03
{
    internal class Producto
    {
        private ICPU cpu;
        private IVentiladores ventilador;
        private IHardDrive hardDrive;

        internal void Colocarcpu(ICPU _cpu)
        {
            cpu = _cpu;
            Console.WriteLine("Se ha colocado el cpu {0} ", cpu);
        }

        

        internal void MostrarCompu()
        {
            Console.WriteLine("cpu: {0}", cpu);
        }
    }
}