using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Canvas : MonoBehaviour
{

    public GameObject te;
    int Fainaru = 0;
    public int MAX;
    void Start()
    {
        te.SetActive(false);
    }


    void Update()
    {
        if (Fainaru>=MAX)
        {
            te.SetActive(true);
            gameObject.SetActive(false);

        }

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Finish")
        {
            Fainaru += 1;
        }
    }
}
