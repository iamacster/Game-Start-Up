﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class head : MonoBehaviour
{
    Image image;
    Inventory inv;
	void Start ()
    {
        image = GetComponent<Image>();
        inv = GameObject.Find("InventoryArmor").GetComponent<Inventory>();
	}
	
	void Update ()
    {
        image.sprite = inv.Head.sprite;
	}
}
