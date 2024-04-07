using System;
using System.Collections.Generic;

class _CTOrder
{
    public int _CTTableNumber { get; private set; }
    public List<_CTMenuItem> _CTItems { get; private set; }
    public decimal _CTTotalPrice { get; private set; }
    public DateTime _CTOrderTime { get; private set; }

    public _CTOrder(int _CTTableNumber, List<_CTMenuItem> _CTItems)
    {
        this._CTTableNumber = _CTTableNumber;
        this._CTItems = _CTItems;
        _CTTotalPrice = CalculateTotalPrice();
        _CTOrderTime = DateTime.Now;
    }

    private decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var item in _CTItems)
        {
            totalPrice += item._CTPrice;
        }
        return totalPrice;
    }
}