using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementManager : MonoBehaviour
{
    public GameManager gameManager;
    public void PlaceHere()
    {
        if (gameManager.currentlySelectedTower != null  && UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.childCount <= 0)
        {
            gameManager.MoneyManager.money -= gameManager.currentCost;
            GameObject tower = Instantiate(gameManager.currentlySelectedTower, UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform);
            gameManager.currentlySelectedTower = null;
            tower.transform.position = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.position;
            gameManager.MoneyManager.moneyText.text = "" + gameManager.MoneyManager.money;
        }
        else
        {
            Debug.Log("Cannot Place Tower");
        }
    }
}
