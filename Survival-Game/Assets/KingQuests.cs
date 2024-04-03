using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingQuests : MonoBehaviour
{
    // Start is called before the first frame update
    int cur_quest = 0;
    public AudioSource[] quests;

    public Item w1;
    public bool w2;
    public Item w3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(cur_quest == 0)
        {
            if(other.gameObject.name.ToLower().StartsWith("meat"))
            {
                cur_quest++;
                quests[cur_quest].Play();
            }
            else
            {
                quests[cur_quest].Play();
            }
        }
        else if(cur_quest == 1)
        {
            if(w2)
            {
                cur_quest++;
                quests[cur_quest].Play();
            }
        }
        else if(cur_quest == 2)
        {
            if(other.gameObject.name.ToLower().StartsWith("fang"))
            {
                cur_quest++;
                quests[cur_quest].Play();
            }
        }
    }
}
