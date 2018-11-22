using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Type { Head, Chest, Arms, Legs, Feet, Melee, Ring, Necklace };
public class Item
{
    Type type;
    float strength;
    float defense;
    float will;
    float endurance;
    float health;
    float aira;
    public Item(Type t, float s, float d, float w, float e, float h, float a)
    {
        type = t;
        strength = s;
        defense = d;
        will = w;
        endurance = e;
        health = h;
        aira = a;
    }
}
public class Inventory : MonoBehaviour
{
    
    Canvas canvas;
    bool isDisable;
	void Start ()
    {

        isDisable = true;
        canvas = GetComponent<Canvas>();
	}
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(isDisable)
            {
                canvas.enabled = true;
            }
            else
            {
                canvas.enabled = false;
            }
            isDisable = !isDisable;
        }
	}
}
