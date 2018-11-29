using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InspectItem : MonoBehaviour
{
    public Type inspect;
    Image image;
    Inventory inv;
    Canvas canvas;
    GameObject insp;
    
    void Start ()
    {
        insp = GameObject.Find("Inspector");
        canvas = insp.GetComponent<Canvas>();
        image = GameObject.Find("inspImage").GetComponent<Image>();
        inv = GameObject.Find("InventoryArmor").GetComponent<Inventory>();
    }
	
	void Update ()
    {
		if(canvas.enabled)
        {
            image.sprite = inv.getItem(inspect).sprite;
            GameObject.Find("inspName").GetComponent<TextMeshProUGUI>().text = inv.getItem(inspect).name;
        }
	}
}
