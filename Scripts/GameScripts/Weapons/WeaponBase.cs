using System;
public class WeaponBase {
    public int power = 10;
    public int range = 10;
    public int ammo = 12;
}

public bool ammoEmpty(){ 
    if (ammo == 0){
    return true;} 
    else {
        return false;
    }
}