// See https://aka.ms/new-console-template for more information
using OCP.App;
using OCP.App.Bad;
using good = OCP.App.Good;
using good2 = OCP.App.Good2;


Console.WriteLine("Hello, World!");

SalaryCalculate calculate = new SalaryCalculate();

Console.WriteLine($"Low Salary:{calculate.Calculate(100, SalaryType.Low)}");
Console.WriteLine($"Middle Salary:{calculate.Calculate(100, SalaryType.Middle)}");
Console.WriteLine($"High Salary:{calculate.Calculate(100, SalaryType.High)}");

Console.WriteLine("---------------------------");
//Good way 1 with interface
good.SalaryCalculate calculateGood = new good.SalaryCalculate();

Console.WriteLine($"Low Salary:{calculateGood.Calculate(100, new good.LowSalaryCalculate())}");
Console.WriteLine($"Middle Salary:{calculateGood.Calculate(100, new good.MiddleSalaryCalculate())}");
Console.WriteLine($"High Salary:{calculateGood.Calculate(100, new good.HighSalaryCalculate())}");
Console.WriteLine($"Manager Salary:{calculateGood.Calculate(100, new good.ManagerSalaryCalculate())}");



Console.WriteLine("---------------------------");
//Good way 2 with delegate.
good2.SalaryCalculate calculateGood2 = new good2.SalaryCalculate();

Console.WriteLine($"Low Salary:{calculateGood2.Calculate(100, new good2.LowSalaryCalculate().Calculate)}");
Console.WriteLine($"Middle Salary:{calculateGood2.Calculate(100, new good2.MiddleSalaryCalculate().Calculate)}");
Console.WriteLine($"High Salary:{calculateGood2.Calculate(100, new good2.HighSalaryCalculate().Calculate)}");
Console.WriteLine($"Manager Salary:{calculateGood2.Calculate(100, new good2.ManagerSalaryCalculate().Calculate)}");

Console.WriteLine($"Custom Salary:{calculateGood2.Calculate(100, x=>
{
    return x * 10;
})}");



Console.ReadLine();