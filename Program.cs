namespace CalculadoraTabajara
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double primeiroN, segundoN;

            Console.WriteLine("Calculadora Tabajara");

            Console.WriteLine("Digite o primeiro número:");
            primeiroN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            segundoN = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

           
            switch (Console.ReadLine())

            {
                case "1":
                        Console.WriteLine($"O resultado é {primeiroN + segundoN}"); 
                    break;

                case "2":
                        Console.WriteLine($"O resultado é {primeiroN - segundoN}");
                    break;

                case "3":
                        Console.WriteLine($"O resultado é {primeiroN * segundoN}");
                    break;

                case "4":
                        Console.WriteLine($"O resultado é {primeiroN / segundoN}");
                    break;
              
                default: 
                    break;


            }
            

          

            

        }


    }
}
