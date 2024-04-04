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
    public GameObject chest;

    void Start()
    {
        chest.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void stop_all_others()
    {
        for(int i = 0; i < cur_quest; i++)
        {
            AudioSource c = quests[i];
            if(c.isPlaying)
            {
                c.Stop();
            }
        }
        for (int i = cur_quest + 1; i < quests.Length; i++)
        {
            AudioSource c = quests[i];
            if (c.isPlaying)
            {
                c.Stop();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(cur_quest == 0)
        {
            if(other.gameObject.name.ToLower().StartsWith("tuatara"))
            {
                Destroy(other.gameObject);
                cur_quest++;
                stop_all_others();
                //quests[cur_quest].Play();
                AudioSource.PlayClipAtPoint(quests[cur_quest].clip, transform.position);
            }
            else
            {
                //quests[cur_quest].Play();
                AudioSource.PlayClipAtPoint(quests[cur_quest].clip, transform.position);
            }
        }
        else if(cur_quest == 1)
        {
            if(w2)
            {
                cur_quest++;
                stop_all_others();
                //quests[cur_quest].Play();
                AudioSource.PlayClipAtPoint(quests[cur_quest].clip, transform.position);
            }
        }
        else if(cur_quest == 2)
        {
            if(other.gameObject.name.ToLower().StartsWith("fang"))
            {
                Destroy(other.gameObject);
                cur_quest++;
                stop_all_others();
                //quests[cur_quest].Play();
                AudioSource.PlayClipAtPoint(quests[cur_quest].clip, transform.position);
                chest.SetActive(true);
            }
        }
    }
}
