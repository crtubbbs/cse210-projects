class Scripture
{
    private List<Word> _CTWords = new List<Word>();

    public bool _CTAllWordsHidden => _CTWords.All(w => w._CTHidden);

    public Scripture(string _CTReference, string _CTText)
    {
        Reference _CTScriptureReference = new Reference(_CTReference);
        string[] _CTTextWords = _CTText.Split(' ');
        foreach (string _CTWord in _CTTextWords)
        {
            _CTWords.Add(new Word(_CTWord));
        }
    }

    public void _CTHideRandomWord()
    {
        Random _CTRandom = new Random();
        int _CTIndex = _CTRandom.Next(_CTWords.Count);
        _CTWords[_CTIndex]._CTHidden = true;
    }

    public string _CTGetHiddenText()
    {
        string _CTHiddenText = "";
        foreach (Word _CTWord in _CTWords)
        {
            _CTHiddenText += _CTWord._CTHidden ? "______ " : _CTWord._CTText + " ";
        }
        return _CTHiddenText;
    }
}