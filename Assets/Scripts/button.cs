using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public void closeInspector()
    {
        GameObject.Find("Inspector").GetComponent<Canvas>().enabled = false;
    }
    public void obp(string t)
    {
        switch (t)
        {
            case "Head":
                GameObject.Find("inspector").GetComponent<InspectItem>().inspect = Type.Head;
                GameObject.Find("Inspector").GetComponent<Canvas>().enabled = true;
                break;
            case "Chest":
                GameObject.Find("inspector").GetComponent<InspectItem>().inspect = Type.Chest;
                GameObject.Find("Inspector").GetComponent<Canvas>().enabled = true;
                break;
            case "Legs":
                GameObject.Find("inspector").GetComponent<InspectItem>().inspect = Type.Legs;
                GameObject.Find("Inspector").GetComponent<Canvas>().enabled = true;
                break;
            case "Feet":
                GameObject.Find("inspector").GetComponent<InspectItem>().inspect = Type.Feet;
                GameObject.Find("Inspector").GetComponent<Canvas>().enabled = true;
                break;
            case "Weapon":
                GameObject.Find("inspector").GetComponent<InspectItem>().inspect = Type.Melee;
                GameObject.Find("Inspector").GetComponent<Canvas>().enabled = true;
                break;
            case "Ring":
                GameObject.Find("inspector").GetComponent<InspectItem>().inspect = Type.Ring;
                GameObject.Find("Inspector").GetComponent<Canvas>().enabled = true;
                break;
            case "Necklace":
                GameObject.Find("inspector").GetComponent<InspectItem>().inspect = Type.Necklace;
                GameObject.Find("Inspector").GetComponent<Canvas>().enabled = true;
                break;
        }
    }
	void Start ()
    {
        
        
	}
	
	void Update ()
    {
		
	}
}
