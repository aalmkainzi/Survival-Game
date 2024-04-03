using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource chop;
    public AudioSource slash;
    public AudioSource mDie;
    public AudioSource mHit;
    public AudioSource bDie;
    public AudioSource bHit;
       
       

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void play_bHit()
    {
        bHit.Play();
    }
    public void play_mDie()
    {
        mDie.Play();
    }
    public void play_mHit()
    {
        mHit.Play();
    }
    public void play_bDie()
    {
        bDie.Play();
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
