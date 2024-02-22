// See https://aka.ms/new-console-template for more information
using OCP.App;
using OCP.App.Bad;
using good = OCP.App.Good;


Console.WriteLine("Hello, World!");

SalaryCalculate calculate = new SalaryCalculate();

Console.WriteLine($"Low Salary:{calculate.Calculate(100, SalaryType.Low)}");
Console.WriteLine($"Middle Salary:{calculate.Calculate(100, SalaryType.Middle)}");
Console.WriteLine($"High Salary:{calculate.Calculate(100, SalaryType.High)}");

Console.WriteLine("---------------------------");
//Good vay
good.SalaryCalculate calculateGood = new good.SalaryCalculate();

Console.WriteLine($"Low Salary:{calculateGood.Calculate(100, new good.LowSalaryCalculate())}");
Console.WriteLine($"Middle Salary:{calculateGood.Calculate(100, new good.MiddleSalaryCalculate())}");
Console.WriteLine($"High Salary:{calculateGood.Calculate(100, new good.HighSalaryCalculate())}");


Console.ReadLine();