using static Builder03.ICPU;

namespace Builder03
{
    internal class BuilderNormal : IBuilder
    {
        private Producto compu = new Producto();
        public void ConstrulleVentiladores()
        {
            throw new NotImplementedException();
        }

        public void ConstrulleHardDrive()
        {
            throw new NotImplementedException();
        }

        public void ConstrulleCPU()
        {
            compu.ColocarMotor(new MotorBasico());
        }

        internal Producto ObtenProducto()
        {
            return compu;
        }
    }
}