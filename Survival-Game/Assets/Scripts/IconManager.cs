using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class IconManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] icons;

    void Start()
    {
    }

    public Sprite get_icon(int id)
    {
        if (id == 0) return null;
        Sprite tempi = icons[id - 1];
        return tempi;
    }
}

