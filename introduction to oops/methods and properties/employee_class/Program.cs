using System;

class Employee
{
    string name;
    decimal basicSalary;
    decimal hra, da, tax, grossPay, netPay;

    public Employee(string empName, decimal salary)
    {
        name = empName;
        basicSalary = salary;
    }

    public void CalculateSalary()
    {
        hra = basicSalary * 15 / 100;
        da = basicSalary * 10 / 100;
        grossPay = basicSalary + hra + da;
        tax = grossPay * 8 / 100;
        netPay = grossPay - tax;
    }

    public void Display()
    {
        Console.WriteLine("Employee Name : " + name);
        Console.WriteLine("Basic Salary  : " + basicSalary);
        Console.WriteLine("HRA           : " + hra);
        Console.WriteLine("DA            : " + da);
        Console.WriteLine("Gross Pay     : " + grossPay);
        Console.WriteLine("Tax           : " + tax);
        Console.WriteLine("Net Pay       : " + netPay);
    }

    static void Main()
    {
        Employee emp = new Employee("Vijay", 30000);

        emp.CalculateSalary();
        emp.Display();
    }
}
