using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class IconManager : MonoBehaviour
{
    // Start is called before the first frame update
    Image[] icons;

    void Start()
    {
        icons = GetComponents<Image>();
    }

    public Image get_icon(int id)
    {
        if (id == 0) return null;
        Image ret = Instantiate(icons[id - 1]);
        ret.sprite = Instantiate(ret.sprite);
        ret.material = new Material(ret.material);
        ret.material.color = new Color(ret.material.color.r, ret.material.color.g, ret.material.color.b, ret.material.color.a);
        return ret;
    }
}

