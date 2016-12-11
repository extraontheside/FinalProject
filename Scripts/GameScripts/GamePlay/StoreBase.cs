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
    public void Encounter (int i, string walked){
        switch (i)
        {
            case 0:
                Console.WriteLine("You've " + walked + " some " + objects[i]);
            break;
        }
    }
}