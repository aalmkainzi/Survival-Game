using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float eHealth = 100f;
    public pStatus HP;
    public float Damage;
    private Transform Player;
    //private float speed;
    //private float dist;
    //public float moveSpeed;
    //public float howClose;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        gameObject.transform.Find("Loot").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*dist = Vector3.Distance(Player.position, transform.position);
        if (dist <= howClose)
        {
            transform.LookAt(Player);
            GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed);
        }*/

        /* if (eHealth <= 0)
         {
             Destroy(gameObject);
         }*/
        
    }

    /*public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Attack0");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Attack");

            HP.Health -= Damage;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Attack1");
            eHealth -= wDamage;
        }



    }*/

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("HEALTH: " + eHealth);
        if (other.gameObject.CompareTag("Player"))
        {
            HP.Health -= Damage;
        }
    }
}
