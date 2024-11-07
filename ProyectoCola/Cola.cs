namespace ProyectoCola
{
    internal class Cola
    {
        private Nodo inicio;

        private int count = 0;

        private int Max;

        public Cola(int max)
        {
            Max = max;
            inicio = null;
        }

        private bool underflow()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        private bool overflow()
        {
            if (count == Max)
                return true;
            else
                return false;
        }


        public void Print()
        {

        }

        public int Count()
        {

        }

        public bool Insert()
        {
            /* regresa true al insertar exitosamente,
             * regresa false si la esta llena y no se
             * puso insertar
             */

        }

        public int Extract()
        {
            /* Regresa el valor extraido de la cola 
             * si la cola esta vacia regresa -1 por que
             * no puso extraer
             */

        }
    }
}