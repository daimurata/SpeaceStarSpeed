using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //弾？多分弾
    public GameObject bullet;

    //上の弾の速度
    public float Bspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //←キーで射撃的なもの、照準的なものはないもので考える
        //今は空のオブジェクトから発射してる
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject bullets = Instantiate(bullet, transform.position, Quaternion.identity);

            Rigidbody bullet_rb = bullets.GetComponent<Rigidbody>();

            bullet_rb.AddForce(transform.forward * Bspeed);
        }
    }
}
