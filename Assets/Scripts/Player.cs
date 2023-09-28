using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int _HP;
    public int HP 
    {
        get {
            return _HP;
        }
        set {
            _HP = value;
        }
    }

    
    
    
    private int _critattack;
    public int Critattack 
    {
        get {
            return _critattack;
        }
        set {
            _critattack = value;
        }
    }



    private string _name;
    public string Name 
    {
        get {
            return _name;
        }
        set {
            _name = value;
        }
    }



    public Player() { }





    public Player(int HP, int critattack, string name) {
        HP = HP;
        Critattack = critattack;
        Name = name;
    }

    public virtual void Attack() {
        Debug.Log("Player attacked you with ice");
    }

    public void Info(){
        Debug.Log("HP is: " + HP);
        Debug.Log("Critattack is: " + Critattack);
        Debug.Log("Name is: " + Name);
    }


} //class
