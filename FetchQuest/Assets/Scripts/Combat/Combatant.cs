﻿using UnityEngine;
using System.Collections;

public class Combatant : MonoBehaviour {

    // Use this for initialization
    /*
    Charisma
    Stamina
    Intelligence
    Perception
    Agility
    Luck
    Tool Use*
    Dexterity
    Defense
    Strength
    */
    double charisma { get; set; }
    double stamina { get; set; }
    double intelligence { get; set; }
    double perception { get; set; }
    double agility { get; set; }
    double luck { get; set; }
    double toolUse { get; set; }
    double dexterity { get; set; }
    double defense { get; set; }
    double strength { get; set; }

    double hp { get; set; }

    bool isAlive { get; set; }
    bool canAttack { get; set; }
    bool canItem { get; set; }
    bool canRun { get; set; }

    //a list for attacks
    //a list for items. 
    
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void TakeDamage(double damage)
    {
        hp -= damage;
    }
}
