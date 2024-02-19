using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyEnemy : MonoBehaviour
{
    public int hp = 10;
    public float respawntime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            respawntime -= Time.deltaTime;
            if (respawntime <= 0)
            {
                this.gameObject.GetComponent<Collider>().enabled = true;
                this.gameObject.GetComponent<MeshRenderer>().enabled = true;
                hp = 10;
                respawntime = 10f;
            }
        }
    }
    public void Damaged()
    {
        if (hp <= 0)
        {
            Debug.Log("Deactivated");
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.GetComponent<Collider>().enabled = false;
            //Respawn();
        }
    }
    void Respawn()
    {
        Debug.Log("Invoked Respawn");
        respawntime -= Time.deltaTime;
        if (respawntime > 0f)
        {
            Respawn();
        }
        else
        {
            this.gameObject.GetComponent<Collider>().enabled = true;
            this.gameObject.GetComponent<MeshRenderer>().enabled = true;
            hp = 10;
            respawntime = 10f;
        }
    }
}
