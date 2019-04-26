using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //ここでは主にプレイヤー周りに関することを追加していく予定（Moveってあるけど移動だけじゃないよ）

    //プレイヤー
    public GameObject player;   //オブジェクト
    private Vector3 player_pos;


    //加速させる速度を掛ける
    public float Speed;
    //これはPlayerを入れる
    public Rigidbody rb;
    //速度が足りているかの判定する為の変数
    public float Pmagnitude = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<GameObject>();

        rb = GetComponent<Rigidbody>();

        Speed = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        Clamp();
    }
    void FixedUpdate()
    {
        //移動時に何かエフェクトを入れてどこに向かっているのかを分かるようにする？的な感じ

        //上下左右前後の移動になる追加予定、上下運動に対してはON,OFFの切り替えがしやすいようなプログラムを書く
        //前後左右移動
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.up * Speed,ForceMode.Force);           
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.down * Speed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * Speed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * Speed, ForceMode.Force);
        }
        //上下移動
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    rb.AddForce(Vector3.up * Speed, ForceMode.Force);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    rb.AddForce(Vector3.down * Speed, ForceMode.Force);
        //}
    }
    void OnCollisionEnter(Collision col)
    {
        //現状Tagの設定をしていないので今後加えることになるんだと思う
        //↓のPlayerは初期からあったものを使っているだけ、まだTag名については考えていない
        if (col.gameObject.tag == "Player")
        {
            //ここは一定以上の速度が出ているかの判定
            if (rb.velocity.magnitude < Pmagnitude)
            {
                //速度の確認用
                Debug.Log(rb.velocity.magnitude);
                //速度を0にする（今後変える可能性が高い）
                rb.velocity = Vector3.zero;
                //衝突したオブジェクトを消す、漂ってる星が消えるはず
                Destroy(col.gameObject);
            }
            else
            {
                //自キャラを消す
                Destroy(gameObject);
                //速度の確認用
                Debug.Log(rb.velocity.magnitude);
            }
        }
        
        //これはブラックホール？に当たった際の処理、これもTag名については何も考えていない
        if(col.gameObject.tag == "Finish")
        {
            //消す
            Destroy(gameObject);
            //ここで何かアクションを出すことになるはず

        }
    }
    void Clamp()
    {
        player_pos = transform.position;

        player_pos.x = Mathf.Clamp(player_pos.x, -5f, 5f);
        player_pos.z = Mathf.Clamp(player_pos.z, -3f, 3f);
        transform.position = new Vector3(player_pos.x, player_pos.y, player_pos.z);

        //if (player_pos.x >= 5 || player_pos.x <= -5)
        //{
        //    Speed -= 2f;
        //    if (Speed == 0)
        //    {
        //        Speed = 5f;
        //    }
        //}
    }
}
