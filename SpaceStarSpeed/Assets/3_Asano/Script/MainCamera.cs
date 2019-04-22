using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject M_Ca;

    private Vector3 Ca_pos;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        M_Ca = GetComponent<GameObject>();

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ca_pos = transform.position;

        if(Ca_pos.y == 200)
        {
            Debug.Log("あたたたーーーー");
            //Ca_pos.y = 100;
            Physics.gravity = new Vector3(0, 0, 0);
        }
    }
}
