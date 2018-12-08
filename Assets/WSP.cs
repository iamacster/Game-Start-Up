using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSP : MonoBehaviour {

    public int precision = 10000;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int weightedRandomInt(List<float> weights)
    {
        int randint = new System.Random().Next(1, precision);
        int index = 0;
        foreach(float f in weights)
        {
            int compare = (int)Math.Floor(f * precision);
            if(index == 0)
            {
                if (randint <= 1 && randint >= compare+1)
                {
                    return 0;
                }
                else
                {
                    int lowerval = (int)Math.Floor(weights[index-1] * precision);
                    if (randint < lowerval && randint > compare+1)
                    {
                        return index;
                    }
                }
            }
        }
        return 0;
    }
    public T RandomEnumValue<T>(List<float> f)
    {
        Array v = Enum.GetValues(typeof(T));
        return (T)v.GetValue(weightedRandomInt(f));
    }
}
