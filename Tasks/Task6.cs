using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    public class Task6
    {
        /*
         * Dada uma lista de inteiros, crie um método que devolva a proporção de números positos, negativos e zeros, respectivamente.
         * Obs.: Retornar valores com 6 casas decimais
         * Ex.:
         * Entrada:
         * -4 3 -9 0 4 1    
         * Saída: 
         * 0.500000
         * 0.333333
         * 0.166667
         */
        public static List<decimal> GetRatios(List<int> numbers) 
        {
            int total, tPos, tNeg, tZero;
            decimal pos, neg, zero;
            List<decimal> lista;

            total = numbers.Count;

            tPos = numbers.Where(p => p > 0).Count();
            tNeg = numbers.Where(p => p < 0).Count();
            tZero = numbers.Where(p => p == 0).Count();

            pos = tPos / (decimal)total;
            neg = tNeg / (decimal)total;
            zero = tZero / (decimal)total;

            lista = new List<decimal>();
            lista.Add(decimal.Round(pos,6));
            lista.Add(decimal.Round(neg,6));
            lista.Add(decimal.Round(zero,6));

            return (lista);
        }
    }
}
