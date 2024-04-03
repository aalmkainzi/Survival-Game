using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float Damage;
    public SoundManager sound_man;

    private void Start()
    {
        if(sound_man == null)
        {
            sound_man = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("WEAPN COL" + Damage);
            sound_man.play_slash();
            sound_man.play_mHit();
            Enemy e = collision.gameObject.GetComponent<Enemy>();
            e.eHealth -= Damage;
            if (e.eHealth <= 0)
            {
                sound_man.play_mDie();
            }
            
        }
        else if (collision.gameObject.CompareTag("Bandit"))
            {
                Debug.Log("WEAPN COL" + Damage);
                sound_man.play_bHit();
                Enemy e = collision.gameObject.GetComponent<Enemy>();
                 e.eHealth -= Damage;
                 if(e.eHealth <= 0)
                 {
                     sound_man.play_bDie();
                 }
            }
             else if (collision.gameObject.CompareTag("Animals"))
            {
                Debug.Log("WEAPN COL" + Damage);
                
                animals a = collision.gameObject.GetComponent<animals>();
                // a.aHealth -= Damage;
                 
            }
    }
}
