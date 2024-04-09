using System;
using System.Collections.Generic;

class _CTTable
{
    public int _CTTableNumber { get; private set; }
    public bool _CTIsOccupied { get; private set; }
    public int _CTCapacity { get; private set; }

    public _CTTable(int _CTTableNumber, int _CTCapacity)
    {
        this._CTTableNumber = _CTTableNumber;
        this._CTCapacity = _CTCapacity;
        _CTIsOccupied = false; // By default, the table is not occupied when initialized
    }

    // Method to mark the table as occupied
    public void MarkAsOccupied()
    {
        _CTIsOccupied = true;
    }

    // Method to mark the table as available
    public void MarkAsAvailable()
    {
        _CTIsOccupied = false;
    }

    // Method to display table information
    public void DisplayInfo()
    {
        Console.WriteLine($"Table Number: {_CTTableNumber}");
        Console.WriteLine($"Capacity: {_CTCapacity}");
        Console.WriteLine($"Occupied: {_CTIsOccupied}");
    }
}

