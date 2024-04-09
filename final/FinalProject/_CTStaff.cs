using System;
using System.Collections.Generic;

class _CTStaff
{
    public string _CTName { get; private set; }
    public string _CTRole { get; private set; }
    public decimal _CTSalary { get; private set; }
    public DateTime _CTStartDate { get; private set; }

    public _CTStaff(string _CTName, string _CTRole, decimal _CTSalary, DateTime _CTStartDate)
    {
        this._CTName = _CTName;
        this._CTRole = _CTRole;
        this._CTSalary = _CTSalary;
        this._CTStartDate = _CTStartDate;
    }

    // Method to calculate staff member's years of service
    public int CalculateYearsOfService()
    {
        TimeSpan serviceTime = DateTime.Now - _CTStartDate;
        return (int)(serviceTime.TotalDays / 365);
    }

    // Method to increase staff member's salary
    public void IncreaseSalary(decimal amount)
    {
        _CTSalary += amount;
    }

    // Method to display staff member's information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {_CTName}");
        Console.WriteLine($"Role: {_CTRole}");
        Console.WriteLine($"Salary: {_CTSalary:C}");
        Console.WriteLine($"Start Date: {_CTStartDate.ToShortDateString()}");
        Console.WriteLine($"Years of Service: {CalculateYearsOfService()} years");
    }
}