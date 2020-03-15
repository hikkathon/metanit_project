using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace metanit_async_await
{
    class Factorial
    {
        public delegate void FactorialHandler(string message);
        public event FactorialHandler Notify;

        public int Fact(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Thread.Sleep(8000);
            return result;
        }

        public void FactNotAsync(int n)
        {
            int result = 0;
            result = Fact(n);
            Notify?.Invoke($"Факториал равен: {result}");
        }

        public async void FactAsync(int n)
        {
            int result = 0;
            Notify?.Invoke("Начало метода FactorialAsync");
            await Task.Run(() => result = Fact(n));
            Notify?.Invoke($"Факториал равен: {result}");
            Notify?.Invoke("Конец метода FactorialAsync");
        }
    }
}
