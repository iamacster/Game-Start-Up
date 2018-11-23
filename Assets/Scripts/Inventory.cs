using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public enum Type { Head, Chest, Arms, Legs, Feet, Melee, Ring, Necklace };



public class Item
{
    public Image image;
    public string name;
    public Type type;
    public float strength;
    public float defense;
    public float will;
    public float endurance;
    public float health;
    public float aira;
    public Item(string name, Type t, float s, float d, float w, float e, float h, float a)
    {
        image = (Image)AssetDatabase.LoadAssetAtPath("Assets/rpg-tutorial-assets/Sprites/Placeholder01.png", typeof(Image));
        type = t;
        strength = s;
        defense = d;
        will = w;
        endurance = e;
        health = h;
        aira = a;
    }
    public void newItem(string n,Image i,float s, float d, float w, float e, float h, float a)
    {
        name = n;
        image = i;
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
	void Start ()
    {
        Head = new Item("Nothing", Type.Head, 0f, 0f, 0f, 0f, 0f, 0f);
        Chest = new Item("Nothing", Type.Chest, 0f, 0f, 0f, 0f, 0f, 0f);
        Arms = new Item("Nothing", Type.Arms, 0f, 0f, 0f, 0f, 0f, 0f);
        Legs = new Item("Nothing", Type.Legs, 0f, 0f, 0f, 0f, 0f, 0f);
        Feet = new Item("Nothing", Type.Feet, 0f, 0f, 0f, 0f, 0f, 0f);
        Melee = new Item("Nothing", Type.Melee, 0f, 0f, 0f, 0f, 0f, 0f);
        Ring = new Item("Nothing", Type.Ring, 0f, 0f, 0f, 0f, 0f, 0f);
        Necklace = new Item("Nothing", Type.Necklace, 0f, 0f, 0f, 0f, 0f, 0f);
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
