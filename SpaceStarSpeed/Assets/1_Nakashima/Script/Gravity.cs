using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    //これをアタッチするのは引力に向かうオブジェクト

    //引力の発生場所
    public GameObject planet;
    
    //万有引力係数（よく分からんけど、適当にいれておけばおｋ）
    public float coefficient;
    //徐々に足すための変数、ごめんなさい変数名後で考えます
    public float a;

    bool isActive = false;

    public GameObject EX;
    // Start is called before the first frame update
    void Start()
    {
        EX.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (isActive)
        {
            a += Time.deltaTime;
            //引力の発生場所に向かうまでの距離
            var direction = planet.transform.position - transform.position;
            //引力発生場所に力を加える、徐々に速くなる
            GetComponent<Rigidbody>().AddForce(coefficient * direction * a, ForceMode.Force);
        }   
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Finish")
        {
            EX.SetActive(true);
            Destroy(gameObject);
        }   
    }

    void OnTriggerStay(Collider other)
    {
        //プレイヤーが範囲内にいるかの判定
        //Tag名きまってませーん、仮でPlayer
        if(other.gameObject.tag == "Player")
        {
            EX.SetActive(true);
            isActive = true;
        }
    }
}
