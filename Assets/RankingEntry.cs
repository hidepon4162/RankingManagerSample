using System;

[Serializable]
public class RankingEntry
{
    public string name;
    public int score;
    public DateTime date;

    public RankingEntry(string name, int score, DateTime date)
    {
        this.name = name;
        this.score = score;
        this.date = date;
    }
}