using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
