using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.UIElements;


public class movement : MonoBehaviour
{
    public float speed = 1.0f;
    public float Hinput = 1.0f;
    public float Vinput = 1.0f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      /*  Hinput = Input.GetAxis("Horizontal");
        Vinput = Input.GetAxis("Vertical");*/
        rb.velocity = new Vector3(Hinput * speed, 0f, Vinput * speed);

    }
}
