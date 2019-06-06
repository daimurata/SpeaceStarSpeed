using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class YesNoSelect : MonoBehaviour
{
    //ここは
    bool tekito = true;
    // Start is called before the first frame update
    void Start()
    {
        if (tekito)
        {          
            tekito = false;
            Invoke("tekitomeso", 4.0f);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void tekitomeso()
    {
        var eventSystem = GameObject.FindObjectOfType<StandaloneInputModule>();
        eventSystem.enabled = true;
        tekito = true;
    }
}
