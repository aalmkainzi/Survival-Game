using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource chop;
    public AudioSource slash;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play_chop()
    {
        chop.Play();
    }
    public void play_slash()
    {
        slash.Play();
    }
}
