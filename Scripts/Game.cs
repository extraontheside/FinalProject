using System;
public class Game
{
    public satic Action StartGame;
    public static bool canPlay = true;
    public Game()
    {
        Health.power = 100;
        
    }

    private string gameState = "Start";
    private GameStateMachine.GameStates toEnum;
    public void Play()
    {
        switch (toEnum)
        {
            case GameStateMachine.GameStates.Start:
                Console.WriteLine("Please type in your name:");
                name = Console.ReadLine();
        }
    }
}