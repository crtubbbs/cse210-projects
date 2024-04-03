class _CTWord
{
    public string _CTText { get; private set; }
    public bool _CTIsHidden { get; set; }

    public _CTWord(string _CTText)
    {
        this._CTText = _CTText;
        _CTIsHidden = false;
    }
}