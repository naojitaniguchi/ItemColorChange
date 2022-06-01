using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject selected;
    public GameObject[] colorItems;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void colorItemSelected( GameObject obj)
    {
        for( int i = 0; i < colorItems.Length; i++)
        {
            if ( colorItems[i] == obj)
            {
                colorItems[i].GetComponent<ColorItemTop>().arrow.SetActive(true);
            }
            else
            {
                colorItems[i].GetComponent<ColorItemTop>().arrow.SetActive(false);
            }
            selected = obj;
        }
    }

    public void colorButtonPushed( ColorItemTop.COLOR_TYPE type)
    {
        selected.GetComponent<ColorItemTop>().selectColor(type);
    }
}
