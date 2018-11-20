using UnityEngine;
using UnityEngine.UI;

public class PlayerAttributes : MonoBehaviour {

    public Image healthBar;
    public Image airaBar;

    //Playible Attributes
    public float maxHealth = 1000f;
    public float currentHealth = 1000f;
    public float maxAira = 500f;
    public float currentAira = 500f;
    //Stat Attributes
    public int strength = 3;
    public int defense = 3;
    public int will = 3;
    public int endurance = 3;
    //Soft Skills
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float healthPercentage = currentHealth / maxHealth;
        healthBar.fillAmount = healthPercentage;
        float airaPercentage = currentAira / maxAira;
        airaBar.fillAmount = airaPercentage;

    }
}
