using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Exercicio02
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Olá, Digite seu nome:");
            String userName = Console.ReadLine();
            
            Console.WriteLine("Digite sua idade:");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            int userHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso:");
            int userWeight = int.Parse(Console.ReadLine());
             
            Console.WriteLine("Seu nome é " + userName + ", sua idade é " + userAge + (", sua altura é " + userHeight + " e seu peso é " + userWeight + "."));
        }
    }
}
