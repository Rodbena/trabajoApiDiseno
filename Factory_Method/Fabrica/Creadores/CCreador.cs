namespace MetodoFabrica02.Fabrica.Creadores
{
    internal class CCreador
    {
        internal static IComputadora MetodoFabrica(int dinero)
        {
            IComputadora temp = null;

            if (dinero > 1000)
            {
                temp = new CDesktop();
            }
            return temp;
        }

    }
}