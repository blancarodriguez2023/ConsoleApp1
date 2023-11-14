using System.Text.RegularExpressions;
public class Operaciones
{
    public double Resp { get; set; }
    public Operaciones(double num1, double num2, String Operador)
    {
        

        if (Operador == "+")
        {

          

            Resp = num1 + num2;
            Console.WriteLine("La suma de " + num1 + " + " + num2 + " es igual " + Resp);

        } else if (Operador == "-")
        {
            Resp = num1 - num2;
            Console.WriteLine("La resta de " + num1 + " - " + num2 + " es igual " + Resp);
        }
        else if (Operador == "*")
        {
            Resp = num1 * num2;
            Console.WriteLine("La mulpiplicasion de " + num1 + " * " + num2 + " es igual " + Resp);
        }
        else if (Operador == "/")
        {
            Resp = num1 / num2;
            Console.WriteLine("La divicion de " + num1 + " / " + num2 + " es igual " + Resp);
        }

    }
   


}



class Program
{
    static void Main(string[] args)
    {
        try
        { 
            double a = 0;
            double b = 0;
            string c = "";

       

            Console.WriteLine("Ingrese un número:");
            a = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Ingrese otro número:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese operador  , ej + - / *  :");
            c = Console.ReadLine();

            Operaciones operaciones =  new Operaciones(a,b,c);

        }
        catch (Exception ex) 
        {
          Console.WriteLine("Ingrese un valor valido");
        }

    }



}
