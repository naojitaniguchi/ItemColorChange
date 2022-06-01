using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorItemTop : MonoBehaviour
{
    public GameObject arrow;
    public enum COLOR_TYPE
    {
        BW,
        RED,
        GREEN,
        BLUE
    }

    public GameObject[] items;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Selected()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("GameController");
        obj.GetComponent<GameController>().colorItemSelected(gameObject);
    }

    public void selectColor( COLOR_TYPE type )
    {
        for ( int i = 0; i < items.Length; i ++)
        {
            if ( i == (int)type)
            {
                items[i].SetActive(true);
            }
            else
            {
                items[i].SetActive(false);
            }
        }
    }
}
