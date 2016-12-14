using system;
public class zombie;
{
    public int scoreMultiplyer = 2;
    public zombie(){
        switch(type)
        {
            case 0:
                zombie.walker;
            break;
            case 1:
                zombie.runner;
            break;
            default: zombie.corpse;
        }
    }
}