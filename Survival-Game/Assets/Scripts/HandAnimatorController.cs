using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class HandAnimatorController : MonoBehaviour
{
    public InputActionProperty grip;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float gripped = grip.action.ReadValue<float>();
        anim.SetFloat("Grip", gripped);
    }
}
