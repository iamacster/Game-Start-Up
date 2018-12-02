using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public enum Type { Head, Chest, Arms, Legs, Feet, Melee, Ring, Necklace };



public class Item
{
    public Sprite sprite;
    public string name;
    public Type type;
    public float strength;
    public float defense;
    public float will;
    public float endurance;
    public float health;
    public float aira;
    public Item(string n, Type t, float s, float d, float w, float e, float h, float a, Sprite sp)
    {
        name = n;
        sprite = sp;
        type = t;
        strength = s;
        defense = d;
        will = w;
        endurance = e;
        health = h;
        aira = a;
    }
    public void newItem(string n,Sprite i,float s, float d, float w, float e, float h, float a, Sprite sp)
    {
        name = n;
        sprite = i;
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

    public Item Head;
    public Item Chest;
    public Item Arms;
    public Item Legs;
    public Item Feet;
    public Item Melee;
    public Item Ring;
    public Item Necklace;


    Canvas canvas;
    bool isDisable;
    public Sprite defaultSprite;
    void Start ()
    {
        Cursor.visible = false;
        Head = new Item("Nothing", Type.Head, 1f, 0f, 0f, 0f, 0f, 0f, defaultSprite);
        Chest = new Item("Nothing", Type.Chest, 0f, 1f, 0f, 0f, 0f, 0f, defaultSprite);
        Arms = new Item("Nothing", Type.Arms, 0f, 0f, 0f, 1f, 0f, 0f, defaultSprite);
        Legs = new Item("Nothing", Type.Legs, 0f, 0f, 0f, 0f, 1f, 0f, defaultSprite);
        Feet = new Item("Nothing", Type.Feet, 0f, 0f, 0f, 0f, 0f, 1f, defaultSprite);
        Melee = new Item("Nothing", Type.Melee, 0f, 0f, 0f, 0f, 0f, 0f, defaultSprite);
        Ring = new Item("Nothing", Type.Ring, 0f, 0f, 0f, 0f, 0f, 0f, defaultSprite);
        Necklace = new Item("Nothing", Type.Necklace, 0f, 0f, 0f, 0f, 0f, 0f, defaultSprite);
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
                Cursor.visible = true;
            }
            else
            {
                canvas.enabled = false;
                GameObject.Find("Inspector").GetComponent<Canvas>().enabled = false;
                Cursor.visible = false;
            }
            isDisable = !isDisable;
        }
	}
    public Item getItem(Type t)
    {
        switch(t)
        {
            case Type.Head:
                return Head;
            case Type.Chest:
                return Chest;
            case Type.Arms:
                return Arms;
            case Type.Legs:
                return Legs;
            case Type.Feet:
                return Feet;
            case Type.Melee:
                return Melee;
            case Type.Ring:
                return Ring;
            case Type.Necklace:
                return Necklace;
            default:
                return null;
        }
    }
}
