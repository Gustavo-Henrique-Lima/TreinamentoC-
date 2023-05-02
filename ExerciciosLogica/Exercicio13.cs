namespace ExerciciosLogica
{
    class Exercicio13
    {
        static void Main(string[]args)
        {
           int qtd=Convert.ToInt32(Console.ReadLine());
           int dentro=0;
           int fora=0;
           for (int i=0;i<qtd;i++)
           {
                int num=Convert.ToInt32(Console.ReadLine());
                if(num>=10 && num<=20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
           }
           Console.WriteLine(dentro+" in");
           Console.WriteLine(fora+" out");
        }
    }
}