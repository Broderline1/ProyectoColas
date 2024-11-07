namespace ProyectoCola
{
    internal class Nodo
    {
        private int valor;

        private Nodo sig;

        public Nodo(int Valor)
        {
            this.Valor = Valor;
            Sig = null;
        }

        public int Valor { get => valor; set => valor = value; }
        internal Nodo Sig { get => sig; set => sig = value; }
    }
}