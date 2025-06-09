using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool HealthUpdate(int damageAmount)
    {
        if (healthPoints <= damageAmount)
        {
            Debug.Log("Game over");
            return false;
        }
        healthPoints -= damageAmount;
        uiManager.UpdateHealthText(healthPoints.ToString());
        return true;
    }



}
