using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    private bool isActive = false;

    void Update()
    {
        if (isActive == true)
        {
            OpenShop();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isActive == false)
        {
            isActive = true;
        }
        else
        {
            isActive = false;
        }
    }

    public void OpenShop()
    {

    }

    public void Heal()
    {
        if (PlayerStats.currentCurrency < 2)
        {
            return;
        }
        else
        {
            PlayerStats.currentCurrency -= 2;
            PlayerStats.currentHealth += 50;
        }
    }

    public void StrengthPlus()
    {
        if (PlayerStats.currentCurrency < 6)
        {
            return;
        }
        else
        {
            PlayerStats.currentCurrency -= 6;
            PlayerStats.currentStrength += 1;
        }
    }

    public void SpeedPlus()
    {
        if (PlayerStats.currentCurrency < 5)
        {
            return;
        }
        else
        {
            PlayerStats.currentCurrency -= 5;
            PlayerStats.currentSpeed += 2f;
        }
    }

    public void HealthPlus()
    {
        if (PlayerStats.currentCurrency < 6)
        {
            return;
        }
        else
        {
            PlayerStats.currentCurrency -= 6;
            PlayerStats.currentMaxHealth += 50;
        }
    }
}


