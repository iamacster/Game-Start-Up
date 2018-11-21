using UnityEngine;
using UnityEngine.UI;

public class PlayerAttributes : MonoBehaviour {

    public Image healthBar;
    public Image airaBar;

    //Playible Attributes
    public static float maxHealth = 1000f;
    public static float currentHealth = 1000f;
    public static float maxAira = 500f;
    public static float currentAira = 500f;
    //Stat Attributes
    public static float strength = 0;
    public static float defense = 0;
    public static float will = 0;
    public static float endurance = 0;
    //Soft Skills
    // Use this for initialization
    void Start ()
    {
        maxHealth = Mathf.Clamp(maxHealth, 0, Mathf.Infinity);
        maxAira = Mathf.Clamp(maxAira, 0, Mathf.Infinity);
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        currentAira = Mathf.Clamp(currentAira, 0, maxAira);
        strength = Mathf.Clamp(strength, 0, Mathf.Infinity);
        defense = Mathf.Clamp(defense, 0, Mathf.Infinity);
        will = Mathf.Clamp(will, 0, Mathf.Infinity);
        endurance = Mathf.Clamp(endurance, 0, Mathf.Infinity);
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
