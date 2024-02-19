using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float speed = 2f;
    public int dmg = 1;
    void Update()
    {
        transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime), transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DummyEnemy>())
        {
            DummyEnemy enemyHit = other.GetComponent<DummyEnemy>();
            enemyHit.hp -= dmg;
            enemyHit.Invoke("Damaged", 0f);
        }
        Destroy(this.gameObject);
    }
}
