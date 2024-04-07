using System;
using System.Collections.Generic;

class _CTInventoryItem
{
    public string _CTName { get; private set; }
    public int _CTQuantity { get; private set; }

    public _CTInventoryItem(string _CTName, int _CTQuantity)
    {
        this._CTName = _CTName;
        this._CTQuantity = _CTQuantity;
    }
}
