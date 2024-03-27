class Reference
{
    public string _CTBook { get; private set; }
    public int _CTChapter { get; private set; }
    public int _CTStartVerse { get; private set; }
    public int? _CTEndVerse { get; private set; }

    public Reference(string _CTReference)
    {
        string[] _CTParts = _CTReference.Split(':', '-');
        _CTBook = _CTParts[0].Trim();
        _CTChapter = int.Parse(_CTParts[1]);
        _CTStartVerse = int.Parse(_CTParts[2]);

        if (_CTParts.Length > 3)
            _CTEndVerse = int.Parse(_CTParts[3]);
    }
}

