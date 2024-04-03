class _CTScripture
{
    public _CTScriptureReference _CTReference { get; private set; }
    public List<_CTWord> _CTWords { get; private set; }

    public _CTScripture(_CTScriptureReference _CTReference, string _CTText)
    {
        this._CTReference = _CTReference;
        _CTWords = _CTText.Split(' ').Select(_CTWord => new _CTWord(_CTWord)).ToList();
    }

    public bool _CTAllWordsHidden()
    {
        return _CTWords.All(_CTWord => _CTWord._CTIsHidden);
    }
}