var today = DateTime.UtcNow;

string output = today.DayOfWeek switch
{
    DayOfWeek.Monday =>     "é segunda-feira",
    DayOfWeek.Tuesday =>    "é terça-feira",
    DayOfWeek.Wednesday =>  "é quarta-feira",
    DayOfWeek.Thursday =>   "é quinta-feira",
    DayOfWeek.Friday =>     "sextou!!!",
    DayOfWeek.Saturday =>   "é sabadão",
    DayOfWeek.Sunday =>     "to triste, amanhã é segunda =X",
                    _ =>    "Ta malucão?"
};

Console.WriteLine($"Hoje {output}");