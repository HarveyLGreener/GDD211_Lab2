using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Get variables for each other manager
    public MoneyMaking MoneyManager;
    public GameObject currentlySelectedTower;
    public int currentCost;
    //Get managers
    void Start()
    {
        MoneyManager = GetComponentInChildren<MoneyMaking>();
    }
}
