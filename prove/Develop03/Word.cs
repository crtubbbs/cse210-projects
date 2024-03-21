class Word
{
    public string _CTText { get; private set; }
    public bool _CTHidden { get; set; }

    public Word(string _CTText)
    {
        this._CTText = _CTText;
        _CTHidden = false;
    }
}