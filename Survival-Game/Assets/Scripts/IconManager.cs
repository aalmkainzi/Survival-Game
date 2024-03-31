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
        Material temp = new Material(icons[id - 1].material);
        temp.color = new Color(temp.color.r, temp.color.g, temp.color.b, temp.color.a);
        Image tempi = icons[id - 1];
        tempi.material = temp;
        return tempi;
    }
}

