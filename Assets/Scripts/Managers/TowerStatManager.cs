using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TowerStatManager : MonoBehaviour
{
    //Creating variables so we can set certain parameters

    [Header("Tower Parameters")]
    public TowerStatsScriptableObject towerStatsSO;
    public GameObject towerPrefab;
    public GameObject towerProjectilePefab;
    public int towerSightRange;
    public float towerFireSpeed;
    public bool insta;
    public int cost;
    public TMP_Text costText;
    public GameManager gameManager;

    [Header("Where on Map?")]
    public Transform towerPlacement;

    private void Start()
    {
        towerPrefab = towerStatsSO.tower;
        towerProjectilePefab = towerStatsSO.projectile;
        towerSightRange = towerStatsSO.sightRange;
        towerFireSpeed = towerStatsSO.fireSpeed;
        insta = towerStatsSO.insta;
        cost = towerStatsSO.towerCardScriptableObject.cost;
        costText.text = "" + cost;
    }

    public void PlaceTower()
    {
        if (gameManager.MoneyManager.money >= cost)
        {
            Debug.Log("Selected!");
            gameManager.currentlySelectedTower = towerPrefab;
            gameManager.currentCost = cost;
        }
    }
}
