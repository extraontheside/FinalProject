using System;
public class StoreBase {
    public StoreBase(){
        Game.StartGame += RunStore;
    }

    private void RunStore()
    {
        Console.WriteLine("Survivor");
    }

    public string StartMessage;
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
                Console.WriteLine()
        }
    }
}