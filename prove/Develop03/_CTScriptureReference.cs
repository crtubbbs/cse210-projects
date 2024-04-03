class _CTScriptureReference
{
    public string _CTBook { get; private set; }
    public int _CTChapter { get; private set; }
    public int _CTStartVerse { get; private set; }
    public int _CTEndVerse { get; private set; }

    public _CTScriptureReference(string _CTBook, int _CTChapter, int _CTStartVerse, int _CTEndVerse = -1)
    {
        this._CTBook = _CTBook;
        this._CTChapter = _CTChapter;
        this._CTStartVerse = _CTStartVerse;
        this._CTEndVerse = _CTEndVerse == -1 ? _CTStartVerse : _CTEndVerse;
    }

    public override string ToString()
    {
        return $"{_CTBook} {_CTChapter}:{_CTStartVerse}" + (_CTStartVerse != _CTEndVerse ? $"-{_CTEndVerse}" : "");
    }
}