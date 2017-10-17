using System.Threading;

namespace Paralelismo
{
    class Program
    {
        static void Main(string[] args)
        {
            FatorialEmParalelo(5);
        }

        public static long FatorialEmParalelo(int valor)
        {
            long resultado = 0;

            var t_calculo = new Thread(() => resultado = Fatorial(valor));
            t_calculo.Start();

            return resultado;
        }

        private static long Fatorial(int valor)
        {
            var resultado = 1L;
            for (int i = valor; i >= 2; i--)
                resultado *= i;
            return resultado;
        }
    }
}
