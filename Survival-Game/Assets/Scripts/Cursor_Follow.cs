using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cursor_Follow : MonoBehaviour
{
    // Start is called before the first frame update
    public bool on;
    public Image icon;
    void Start()
    {
        icon = GetComponent<Image>();
        icon.enabled = false;
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
    }
    public void set_icon(Image ic)
    {
        icon.sprite = ic.sprite;
        icon.enabled = true;
        on = true;
    }

    public void unset_icon()
    {
        icon.sprite = null;
        icon.enabled = false;
        on = false;
    }
}
