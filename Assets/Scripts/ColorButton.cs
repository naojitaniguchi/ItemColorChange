using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton : MonoBehaviour
{
    public ColorItemTop.COLOR_TYPE type;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPushed()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("GameController");
        obj.GetComponent<GameController>().colorButtonPushed(type);

    }
}
