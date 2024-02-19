using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantAttack : MonoBehaviour
{
    public TowerStatsScriptableObject towerStats;
    public int hp;
    public float timer = 3f;
    public float attackTime;
    public Canvas battleCanvas;
    // Start is called before the first frame update
    void Start()
    {
        battleCanvas = GetComponentInParent<Canvas>();
        hp = towerStats.hp;
        attackTime = timer / towerStats.fireSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        attackTime -= Time.deltaTime;
        if (attackTime <= 0)
        {
            GameObject projectile = Instantiate(towerStats.projectile, battleCanvas.transform);
            projectile.transform.position = this.transform.position;
            attackTime = timer / towerStats.fireSpeed;
        }

    }
}
