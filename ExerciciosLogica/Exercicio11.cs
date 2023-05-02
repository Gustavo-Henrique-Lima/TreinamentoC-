/*namespace ExerciciosLogica
{
    class Exercicio11
    {
        static void Main(string[]args)
        {
         double a=Convert.ToDouble(Console.ReadLine());
         double b=Convert.ToDouble(Console.ReadLine());
         double c=Convert.ToDouble(Console.ReadLine());
         double delta=(b*b)-4*a*c;
         if(a==0 || delta<0)
         {
          Console.WriteLine("Impossível Calcular");
         }
         else
         {
          Console.WriteLine("X1= "+string.Format("{0:0.00000}",(-b+Math.Sqrt(delta))/(2*a)));
          Console.WriteLine("X2= "+string.Format("{0:0.00000}",(-b-Math.Sqrt(delta))/(2*a)));
         }
        }
    }
}*/