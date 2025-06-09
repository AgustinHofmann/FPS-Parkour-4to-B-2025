using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtHealth;

    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }

    public void UpdateHealthText(string health)
    {
        txtHealth.text = health;
    }
}
