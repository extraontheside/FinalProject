using system;
public class zombie;
{public zombie()
    {
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