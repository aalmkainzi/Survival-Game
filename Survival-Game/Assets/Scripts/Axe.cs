using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Item
{
    // Start is called before the first frame update

    public SoundManager sound_man;

    void Start()
    {
        icon_id = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Tree"))
        {
            sound_man.play_chop();
            Destroy(collision.gameObject);
        }
    }
}
