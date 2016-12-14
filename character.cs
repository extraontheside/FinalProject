using system;
public class character
{
    private int health;
    private int strength;
    private int dexterity;

    public character(){
        Health = 100;
        strength = 20;
        dexterity = 10;
    } 
    public bool isDead(){
        if (health == 0) {
            return true;
        } else {
            return false;
        }
    }
    public void shout(){
        Console.WriteLine("Huzzah!");
    }
    public bool isStarved(){
        while (food) {
            stillAlive = false;
        }
    }
}