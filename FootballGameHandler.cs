

using System;

public class FootballGameHandler
{
    public string TeamOneName;
    public string TeamTwoName;
    public int TeamOneScore;
    public int TeamTwoScore;
    public int CurrentYard;
    public int CurrentPlay;
    public Boolean Possession;

    public FootballGameHandler(String name1, String name2)
    {
        TeamOneName = name1;
        TeamTwoName = name2;
        TeamOneScore = 0;
        TeamTwoScore = 0;
        CurrentYard = 35;
        CurrentPlay = 4;
        Possession = false;
    }
}