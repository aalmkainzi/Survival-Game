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

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Tree"))
        {
            sound_man.play_chop();
            ChopTree t = collision.gameObject.GetComponent<ChopTree>();
            t.hp -= 1;
            if(t.hp <= 0)
            {
                GameObject log = collision.gameObject.transform.Find("Log").gameObject;
                log.SetActive(true);
                t.GetComponent<MeshRenderer>().enabled = false;

                BoxCollider[] bcs = t.GetComponents<BoxCollider>();

                foreach(BoxCollider box in bcs)
                {
                    box.enabled = false;
                }

                MeshCollider[] mcs = t.GetComponents<MeshCollider>();

                foreach (MeshCollider box in mcs)
                {
                    box.enabled = false;
                }
            }
        }
    }
}
