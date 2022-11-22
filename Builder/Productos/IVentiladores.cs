namespace Builder03
{
    interface IVentiladores
    {
        string caracteristicas();
    }

    class CarroceriaBasica : IVentiladores
    {
        public string caracteristicas()
        {
            return "ventilador fisico";
        }
    }
    class CarroceriaEspecial : IVentiladores
    {
        public string caracteristicas()
        {
            return "ventilador de agua";
        }
    }




}