using System;

class Entry
{
    public string _CTPrompt { get; }
    public string _CTResponse { get; }
    public string _CTDate { get; }

    public Entry(string prompt, string response, string date)
    {
        _CTPrompt = prompt;
        _CTResponse = response;
        _CTDate = date;
    }
}