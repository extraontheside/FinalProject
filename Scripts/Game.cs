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
                Console.WriteLine("Your player name is " + name);
                Console.WriteLine("Play commands: Play, End, Help");

                gameState = Console.ReadLine();

                if(Enum.TryParse(gameState))
                    Play();

                break;

            case GameStateMachine.GameStates.Died:
                Console.WriteLine("You Died");
                GameStateMachine.currentGameState = GameStateMachine.GameStates.End;
                Play();
                break;

            case GameStateMachine.GameStates.End:
                Console.WriteLine("Game Over");
                Environment.Exit(0);
                break;

            case GameStateMachine.GameStates.Help:
                Console.WriteLine("Ask someone who lived in the 90's?");
                Play();
                break;

            case GameStateMachine.GameStates.Play:
                while (Game.canPlay)
                {
                    Store.Enter();
                    Random randomNum = new Random();
                    Cave.Encounter(randomNum.Next(0, Store.objects.Length), "walked");
                    GameTimer();
                    Play();
                }
                break;
        }
    }
}