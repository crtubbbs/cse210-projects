using System;
using System.Collections.Generic;

class _CTMenuItem
{
    public string _CTName { get; set; } // Change to public set
    public decimal _CTPrice { get; set; } // Change to public set

    public _CTMenuItem(string _CTName, decimal _CTPrice)
    {
        this._CTName = _CTName;
        this._CTPrice = _CTPrice;
    }
}
