using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float Damage;
    public SoundManager sound_man;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("WEAPN COL" + Damage);
            sound_man.play_slash();
            Enemy e = collision.gameObject.GetComponent<Enemy>();
            e.eHealth -= Damage;
        }
    }
}
