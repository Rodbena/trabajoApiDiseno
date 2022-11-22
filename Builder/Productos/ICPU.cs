namespace Builder03
{
    internal interface ICPU
    {
        string especificaciones();

        class MotorBasico : ICPU
        {
            public string especificaciones()
            {
                return "4 RAM";
            }
        }
        class MotorGrande : ICPU
        {
            public string especificaciones()
            {
                return "8 RAM";
            }
        }
    }
}