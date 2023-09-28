using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Player
{
    public Sword(int HP, int critattack, string name) 
    { 
        HP = HP;
        Critattack = critattack;
        Name = name;
    }

    public override void Attack() {
        Debug.Log("Swordsman attacked you with sword");
    }


} //class
