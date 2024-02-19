using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class TowerCardManager : MonoBehaviour
{
    //Creating variables so we can set certain parameters

    [Header("Card Parameters")]
    int currAmrCards = 0;
    public int amtOfCards = 5;
    public TowerCardScriptableObject towerCardSO;
    public GameObject cardPrefab;
    public GameObject[] cardlocations;
    public Transform cardHolderTransform;

    [Header("Tower Parameters")]
    public GameObject[] towerCards;
    public float cooldown;
    public int cost;
    public Sprite towerIcon;

    [Header("Other Parameters")]
    public GameObject start;

    private void Start()
    {
        //Sets the amount of different cards the player can have
        towerCards = new GameObject[amtOfCards];
    }

    public void AddTowerCard(TowerCardScriptableObject chosenTower)
    {
        if (currAmrCards < amtOfCards)
        {
            GameObject currentPos = cardlocations[currAmrCards];
            cardHolderTransform = currentPos.transform;
            towerCardSO = chosenTower;
            GameObject card = Instantiate(cardPrefab, cardHolderTransform);

            towerCards[currAmrCards] = card;

            //Getting Variables for tower, Cost, and Cooldown
            towerIcon = towerCardSO.towerIcon;
            cost = towerCardSO.cost;
            cooldown = towerCardSO.cooldown;

            //Updating UI
            card.GetComponentInChildren<Image>().sprite = towerIcon;
            card.GetComponentInChildren<TMP_Text>().text = "" + cost;
            UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.SetActive(false);

            currAmrCards++;
        }
        if (currAmrCards == amtOfCards)
        {
            start.SetActive(true);
        }
    }

    public void RemoveTowerCard(TowerCardScriptableObject chosenTower)
    {

    }
}