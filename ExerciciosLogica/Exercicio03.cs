
namespace ExerciciosLogica
{
    class Exercicio03
    {
      static void menu()
      {
          Console.WriteLine("Bem vindo a super calculadora 2000, temos algumas opções: ");
          Console.WriteLine("A- Para adição");
          Console.WriteLine("B- Para subtração");
          Console.WriteLine("C- Para multiplicação");
          Console.WriteLine("D- Para divisão");
      }
        static void Main(string[]args)
        {
          bool cont=true;
          while(cont)
          {
            menu();
            char opcao=Console.ReadKey().KeyChar;
            Console.WriteLine("");
            Console.WriteLine("Agora digite o primeiro número ");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por fim o segundo número");
            double num2=Convert.ToDouble(Console.ReadLine());
            switch (opcao)
            {
                case 'A':
                    Console.WriteLine("A soma dos número é "+(num1+num2));
                    break;
                case 'B':
                    Console.WriteLine("A subtração dos número é "+(num1-num2));
                    break;
                case 'C':
                    Console.WriteLine("A multiplicação dos número é "+(num1*num2));
                    break;
                case 'D':
                    Console.WriteLine("A divisão dos número é "+(num1/num2));
                    break;
                default:
                    Console.WriteLine("A opção escolhida é inválida, tente novamente");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Deseja continuar?\n1-Sim   2-Não");
            int choose=Convert.ToInt32(Console.ReadLine());
            if(choose==2)
            {
              cont=false;
            }
          }
        }
    }
}