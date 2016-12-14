using System;
public class StoreBase {
    public StoreBase(){
        Game.StartGame += RunStore;
    }

    private void RunStore()
    {
        Console.WriteLine("Survivor");
    }

    public string StartMessage = "Hi";
    public string EndMessage = "Later";
    public string VictoryMessage "Congratulations";
    public string DeathMessage "You have met a terrible fate";
    public bool entranceOpen = true;
    public string[] objects;
    public void Enter (){
        Console.WriteLine(StartMessage);
    }
    public void Encounter (int i, string found){
        switch (i)
        {
            case 0:
                Console.WriteLine("You've " + found + " some " + objects[i]);
            break;

            case 1:
                Console.WriteLine("You've " + found + " some " + objects[i]);
            break;

            case 2:
                Console.WriteLine("You've encountered a zombie!");
                Game.
            break;

            default:
                Console.WriteLine("There's hardly anything here.");
        }
    }
}