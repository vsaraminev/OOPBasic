using System;

public class StartUp
{
    public static void Main()
    {
        var command = Console.ReadLine();

        var studentSystem = new StudentSystem();

        while (command != "Exit")
        {
            studentSystem.ParseCommand(command, Console.WriteLine);

            command = Console.ReadLine();
        }
    }
}

