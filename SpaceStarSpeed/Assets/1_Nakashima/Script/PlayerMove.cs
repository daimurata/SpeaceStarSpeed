using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //ここでは主にプレイヤー周りに関することを追加していく予定（Moveってあるけど移動だけじゃないよ）

    //プレイヤー
    public GameObject player;   //オブジェクト
    private Vector3 player_pos;
    
    float alpha_Sin;    //色

    //加速させる速度を掛ける
    public float Speed;
    //これはPlayerを入れる
    public Rigidbody rb;
    //速度が足りているかの判定する為の変数
    public float Pmagnitude = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        //自キャラのオブジェクト取得
        player = GetComponent<GameObject>();

        

        //重力
        rb = this.GetComponent<Rigidbody>();
        rb.useGravity = true;   //重力ありに

        Speed = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        //移動制限
        Clamp();
    }
    void FixedUpdate()
    {
        Transform Pmove = this.transform;
        Vector3 player_pos = Pmove.position;

        //移動時に何かエフェクトを入れてどこに向かっているのかを分かるようにする？的な感じ

        //上下左右前後の移動になる追加予定、上下運動に対してはON,OFFの切り替えがしやすいようなプログラムを書く
        //注）Playerは現在星...角度を変更してあるので「upとdown」から「forwardとback」に変更
        //前後左右移動

        //パターン１（徐々に）
        //if (Input.GetKey(KeyCode.W))
        //{
        //    rb.AddForce(Vector3.forward * Speed,ForceMode.Force);           
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    rb.AddForce(Vector3.back * Speed, ForceMode.Force);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rb.AddForce(Vector3.left * Speed, ForceMode.Force);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    rb.AddForce(Vector3.right * Speed, ForceMode.Force);
        //}

        //パターン２（素早く）
        if (Input.GetKey(KeyCode.W))
        {
            player_pos.z += 5f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player_pos.z -= 5f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player_pos.x -= 5f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            player_pos.x += 5f * Time.deltaTime;
        }
        Pmove.position = player_pos;

        ////パターン３（PS4）
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        //if (Input.GetKey(KeyCode.W))
        //{
        //    player_pos.z += 5f * -h * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    player_pos.z -= 5f * h * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    player_pos.x -= 5f * -v *  Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    player_pos.x += 5f * v * Time.deltaTime;
        //}
        //Pmove.position = player_pos;


        //重力の変更
        //加速
        if (Input.GetKey(KeyCode.H))
        {
            rb.AddForce(0, -10, 0);

        }
        //減速
        if (Input.GetKey(KeyCode.G))
        {
            rb.AddForce(0, 10, 0);

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
        //自キャラのTagは"Player"
        //惑星のTagは"Finish"
        if (col.gameObject.tag == "Finish")
        {
            //速度の確認用
            Debug.Log(rb.velocity.magnitude);

            //自キャラを点滅させる
            alpha_Sin = Mathf.Sin(Time.time) / 2 + 0.5f;

            //速度を0にして、５の力を加える（簡単に言うと減速）
            rb.velocity = Vector3.zero;
            rb.AddForce(0, 10f, 0);

            //衝突したオブジェクトを消す、漂ってる星が消える
            Destroy(col.gameObject);

            //※いらないかも
            ////ここは一定以上の速度が出ているかの判定
            //if (rb.velocity.magnitude < Pmagnitude)
            //{
            //    //速度の確認用
            //    Debug.Log(rb.velocity.magnitude);
            //    //速度を0にする（今後変える可能性が高い）
            //    rb.velocity = Vector3.zero;
            //    rb.AddForce(0, 5f, 0);
            //    //衝突したオブジェクトを消す、漂ってる星が消えるはず
            //    Destroy(col.gameObject);
            //}
            //else
            //{
            //    //自キャラを消す
            //    //Destroy(gameObject);
            //    //速度の確認用
            //    Debug.Log(rb.velocity.magnitude);
            //}
        }

        //※ここの処理は必要があれば使う
        //これはブラックホール？に当たった際の処理、これもTag名については何も考えていない
        //if(col.gameObject.tag == "Finish")
        //{
        //    //自分を消す
        //    Destroy(gameObject);
        //    //ここで何かアクションを出すことになるはず

        //}
    }

    //移動制限
    void Clamp()
    {
        //PlayerのPosition
        player_pos = transform.position;

        //移動制限
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
