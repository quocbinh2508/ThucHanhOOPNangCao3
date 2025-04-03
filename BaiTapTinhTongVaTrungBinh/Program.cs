using System;
using System.ComponentModel.Design;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class MathOperations
{
    public double sum(double a, double b)
    {
        return a + b;
    }
    public double Average(double a, double b)
    {
        return (a + b) / 2.0;
    }

    public static double GetValidInput (string prompt, bool isInteger = false)
    {
        double value;
        Console.Write(prompt);
        while (true)
        {
            string input = Console.ReadLine();

            if (isInteger) 
            {
                if (int.TryParse(input, out int intvalue) && intvalue > 0)
                {
                    return intvalue;
                }
                else 
                {
                    Console.WriteLine("Gia tri nhap khong hop le, phai lon hon 0.");
                    Console.Write(prompt);
                }
            } 
            else 
            {
                if (double.TryParse(input, out value) && value > 0)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Gia tri nhap khong hop le, phai lon hon 0.");
                    Console.Write(prompt);
                }
            }
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        MathOperations mathOperations1 = new MathOperations();
        double num1 = MathOperations.GetValidInput("Nhap gia tri cua a: ");
        double num2 = MathOperations.GetValidInput("Nhap gia tri cua b: ");

        double sumResult = mathOperations1.sum(num1, num2);
        Console.WriteLine("Tong cua a va b la: " + sumResult);

        double averageResult = mathOperations1.Average(num1, num2);
        Console.WriteLine("Trung binh cong cua a va b la: " + averageResult);

    }
}