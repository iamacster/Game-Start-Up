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
            GameObject.Find("inspHealth").GetComponent<TextMeshProUGUI>().text = inv.getItem(inspect).health.ToString();
            GameObject.Find("inspAira").GetComponent<TextMeshProUGUI>().text = inv.getItem(inspect).aira.ToString();
            GameObject.Find("inspStrength").GetComponent<TextMeshProUGUI>().text = inv.getItem(inspect).strength.ToString();
            GameObject.Find("inspDefense").GetComponent<TextMeshProUGUI>().text = inv.getItem(inspect).defense.ToString();
            GameObject.Find("inspWill").GetComponent<TextMeshProUGUI>().text = inv.getItem(inspect).will.ToString();
            GameObject.Find("inspEndurance").GetComponent<TextMeshProUGUI>().text = inv.getItem(inspect).endurance.ToString();
        }
	}
}
