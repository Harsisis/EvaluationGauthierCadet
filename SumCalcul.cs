using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationGauthierCadet {
    public static class SumCalcul {
        public static int SumListNumbersUsingParallelInvokeAndAggregate(int limit) {
            int sum = 0;
            Parallel.Invoke(() => {
                var numbers = Enumerable.Range(1, limit);
                sum = numbers.Aggregate((a, b) => a + b);
            });
            Console.WriteLine("Sum numbers from 1 to {0} is : {1}", limit, sum);
            return sum;
        }
    }
}
