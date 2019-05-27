using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    //ただ星にアタッチするだけ、それだけで回転する、数字も適当に入れておいて
    public float rotatespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //回す
        transform.Rotate(0,rotatespeed,0);
    }
}
