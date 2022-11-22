namespace Patron.Prototype
{
    class CCompu : IPrototipo
    {
        private string marca;
        private int costo;

        public string Modelo { get => marca; set => marca = value; }

        public CCompu(string pMarca, int pCosto)
        {
            marca = pMarca;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", marca, costo);
        }
        public object Duplicar()
        {
            CCompu clon = new CCompu(marca, costo);

            return clon;
        }

    }
}