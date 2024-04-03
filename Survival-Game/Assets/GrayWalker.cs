using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrayWalker : MonoBehaviour
{
    Enemy e;
    public KingQuests kingQuests;
    private void Start()
    {
        e = gameObject.GetComponent<Enemy>();
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(e.eHealth <= 0)
        {
            kingQuests.w2 = true;
        }
    }
}
