/*
namespace ExerciciosLogica
{
    class Exercicio03
    {
        static void Main(string[]args)
        {
          string frase,novaFrase;
          Console.WriteLine("Informe sua frase");
          frase=Console.ReadLine();
          novaFrase=changeWord(frase);
          Console.WriteLine(novaFrase);
        }

        static string changeWord(string frase)
        {
          int total=frase.Length;
          string temp="";
          for (int i = 0; i <total; i++)
          {
            if(frase[i].Equals('A') || frase[i].Equals('a'))
            {
              temp+="&";
            }
            else
            {
              temp+=frase[i];
            }
          }
          return temp;
        }
    }
}*/