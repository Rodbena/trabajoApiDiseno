namespace Builder03
{
    interface IHardDrive
    {
        string informacion();
    }

    class hardDrive12 : IHardDrive
    {
        public string informacion()
        {
            return "1 Tera";
        }
    }

    class hardDriveGrande : IHardDrive
    {
        public string informacion()
        {
            return "20 Teras";
        }
    }

}