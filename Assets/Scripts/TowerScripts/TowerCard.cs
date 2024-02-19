using UnityEngine;

[CreateAssetMenu(menuName = "Cards", fileName = "New Card")]
public class TowerCardScriptableObject : ScriptableObject
{
    public Sprite towerIcon;
    public int cost;
    public float cooldown;
}