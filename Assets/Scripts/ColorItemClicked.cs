using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorItemClicked : MonoBehaviour
{
    public GameObject colorTop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked()
    {
        colorTop.GetComponent<ColorItemTop>().Selected();
    }
}
