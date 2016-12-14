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
    private list <zombie> deadZombieList;
    private list <ammo> ammoList;
    private list <weapon> weaponList;
    private character Player = new character();
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
                    for (int x=0; x < deadZombieList.Length ; x++){
                        character.shout;
                    }
                    GameTimer();
                    foreach (zombie z in deadZombieList)
                    {
                        score += (score*z.scoreMultiplyer);
                    }
                    foreach (weapon w in weaponList){
                        score = score * 2;
                    } 
                    Play();
                }
                break;

            default:
                Console.WriteLine(" is not a valid command.");
                Play();
                break;
        }
    }
    public static void GameTimer()
    {
        System.Threading.Thread.Sleep(2000);
    }
    private StoreBase Store = new StoreLevel();
    public static LevelBase 

    public string name;
    private int score;
}