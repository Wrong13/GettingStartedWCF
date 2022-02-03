using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using GettingStartedClient.ServiceReference1;

namespace GettingStartedClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создал экземпляр клиента
            CalculatorClient client = new CalculatorClient();

            // Вызов операций
            double value1 = 100.00D;
            double value2 = 15.99D;
            double rezult = client.Add(value1, value2);
            Console.WriteLine("(Сложение {0},{1}) = {2}",value1,value2,rezult);

            value1 = 145.00D;
            value2 = 76.54D;
            rezult = client.Substract(value1, value2);
            Console.WriteLine("(Вычитание {0},{1}) = {2}", value1, value2, rezult);

            value1 = 9.00D;
            value2 = 81.25D;
            rezult = client.Multiply(value1, value2);
            Console.WriteLine("(Умножение {0},{1}) = {2}", value1, value2, rezult);

            value1 = 22.00D;
            value2 = 7.00D;
            rezult = client.Divide(value1, value2);
            Console.WriteLine("(Деление {0},{1}) = {2}", value1, value2, rezult);

            // Закрытие
            Console.WriteLine("Тыкни чтоб выйти");
            Console.ReadLine();
            client.Close();
        }
    }
}
