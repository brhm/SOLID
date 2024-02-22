// See https://aka.ms/new-console-template for more information
using OCP.App;

Console.WriteLine("Hello, World!");

SalaryCalculate calculate = new SalaryCalculate();

Console.WriteLine($"Low Salary:{calculate.Calculate(100, SalaryType.Low)}");
Console.WriteLine($"Middle Salary:{calculate.Calculate(100, SalaryType.Middle)}");
Console.WriteLine($"High Salary:{calculate.Calculate(100, SalaryType.High)}");

Console.ReadLine();