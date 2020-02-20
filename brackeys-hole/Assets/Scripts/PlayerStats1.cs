using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float maxHealth = 100;
    public int startCurrency = 0;
    public int startStrength = 1;
    public float startSpeed = 5f;
    public float actualMaxHealth;

    public static int currentMaxHealth;
    public static float currentSpeed;
    public static int currentStrength;
    public static float currentHealth;
    public static int currentCurrency;

    public HealthBar healthBar;

    void Start()
    {
        actualMaxHealth = maxHealth;
        currentStrength = startStrength;
        currentSpeed = startSpeed;
        currentCurrency = startCurrency;
        currentHealth = maxHealth;
        healthBar.MaxHealth(maxHealth);
    }

    void Update()
    {
        if (currentHealth == 0)
        {
            GameOver();
        }
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void GameOver()
    {
        Debug.Log("GG");
    }
}
