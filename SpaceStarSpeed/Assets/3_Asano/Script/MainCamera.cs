using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject M_Ca;

    public Vector3 Ca_pos;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        M_Ca = GetComponent<GameObject>();

        rb = GetComponent<Rigidbody>();
        Transform Ca_pos = GameObject.Find("Main Camera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Ca_pos.y < 200)
        {
            Ca_Stop();
        }
    }
    void Ca_Stop()
    {
        Debug.Log("あたたたーーーー");
        //Ca_pos.y = 200;
        rb.useGravity = false;
    }
}
