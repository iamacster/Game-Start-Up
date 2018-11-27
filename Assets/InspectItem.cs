using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectItem : MonoBehaviour
{
    public Type inspect;
    Image image;
    Inventory inv;
    Canvas canvas;
    
    void Start ()
    {
        image = GameObject.Find("inspImage").GetComponent<Image>();
        inv = GameObject.Find("InventoryArmor").GetComponent<Inventory>();
        canvas = GameObject.Find("Inspector").GetComponent<Canvas>();
    }
	
	void Update ()
    {
		if(canvas.enabled)
        {
            image.sprite = inv.getItem(inspect).sprite;
        }
	}
}
