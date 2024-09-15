string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);


static string GetEnjoymentLevel()
{
    System.Console.WriteLine("Prompt the user for the enjoyment level of the game they want to atend");
    return Console.ReadLine().ToUpper();
}

static string GetStadiumRecommendation(string enjoymentLevel)
{
    if (enjoymentLevel == "BORING")
    {
        return "Neyland Stadium";
    }
    if (enjoymentLevel == "AVERAGE")
    {
        return "Jordan-Hare Stadium";
    }
    if (enjoymentLevel == "FUN")
    {
        return "Tiger Stadium";
    }
    if (enjoymentLevel == "EPIC")
    {
        return "Saban Field at Bryant-Denny Stadium";
    }
    else
    {
        return "";
    }
}

static string GetGameRecommendation(string stadium)
{
    if(stadium == "Neyland Stadium")
    {
        return "Kent State";
    }
    if(stadium == "Jordan Hare Stadium")
    {
        return "Kentucky";
    }
    if(stadium == "Tiger Stadium")
    {
        return "Alabama";
    }
    if(stadium == "Epic")
    {
        return "Auburn";
    }
    else{
        return "";
    }
}

static void DisplayStadiumDetails( string stadium, string game )
{
    System.Console.WriteLine(stadium + " " + game); 
}

