using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pStatus : MonoBehaviour
{

    public float Health;
    public float maxHealth;
    public float Hunger;
    public float maxHunger;
    public float hungerOT = 0.025f;
    public Image healthBar;
    public Image hungerBar;

    // Start isat called before the first frame update
    void Start()
    {
        //Health = maxHealth;
        //Hunger = maxHunger;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(Health / maxHealth, 0, 1);
        hungerBar.fillAmount = Mathf.Clamp(Hunger / maxHunger, 0, 1);

        if (Hunger <= 0)
        {
            Health = Health - 2 * Time.deltaTime;
        }
        else if(Hunger >= 70)
        {
            Health = Health + 4 * Time.deltaTime;
        }

        if(Health >= 100)
        {
            Health = maxHealth;
        }

        if (Hunger >= 100)
        {
            Hunger = maxHunger;
        }
        /*
        if (Health <= 0)
        {
            transform.position = transform.position + new vector3(-0.0006477062,0.0027,004024557);
            Health = maxHealth;
            Hunger = maxHunger;
        }
        */
        Hunger = Hunger - hungerOT * Time.deltaTime;
    }

    
}
