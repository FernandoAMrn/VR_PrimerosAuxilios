using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public HealthBar healthBar;

    public GameObject victoryScreen;

    public int maxHealth = 100;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
       
        healthBar.SetMaxHealth(maxHealth);
    }

  public void addHP()
    {
        currentHealth += 1;
        healthBar.SetHealth(currentHealth);
    }
    public void Update()
    {
        if (currentHealth == 20)
        {
            victoryScreen.SetActive(true);
        }
    }


}
