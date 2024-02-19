using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyMaking : MonoBehaviour
{
    public int money = 0;
    public int moneyMade = 25;
    public TMP_Text moneyText;

    private void Start()
    {
        moneyText.text = "" + money;
    }

    public void MakeMoney()
    {
        money += moneyMade;
        moneyText.text = "" + money;
    }
}
