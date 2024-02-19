using UnityEngine;

[CreateAssetMenu(menuName = "Towers", fileName = "New Tower")]
public class TowerStatsScriptableObject : ScriptableObject
{
    public TowerCardScriptableObject towerCardScriptableObject;
    public GameObject tower;
    public int hp;
    public GameObject projectile;
    public float fireSpeed;
    public bool insta;
    public int sightRange;
}