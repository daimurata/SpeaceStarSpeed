using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{
    //SubCameraを移動させて、一定の場所まで移動したらカメラをMainCameraに変更させるものです

    //メインカメラ
    [SerializeField] private GameObject MainCamera;
    //サブカメラ、ステージを見渡す際に使用するカメラ
    [SerializeField] private GameObject SubCamera;

    //移動場所、今は仮なので変更していきます
    public Vector3 target = new Vector3(0, 505, 0);
    //速度
    private float speed = 50.0f;
    //カメラの変更がループしないために用意
    bool CameraChangeBool = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraMove();    
    }

    void CameraMove()
    {
        if(CameraChangeBool == true)
        {
            
            float step = speed * Time.deltaTime;
            SubCamera.transform.position = Vector3.MoveTowards(SubCamera.transform.position, target, step);

            //ifで○○まで行ったらChangeCameraを呼び出す処理、targetと同じポジションを指定
            if (SubCamera.transform.position == target)
            {
                //Cameraの変更の呼び出し
                ChangeCamera();
                //ここで終了させる
                CameraChangeBool = false;
            }
        }
        
    }
    void ChangeCamera()
    {
        //Cameraの変更をする

        //!は送られてくる値の反転
        MainCamera.SetActive(!MainCamera.activeSelf);
        SubCamera.SetActive(!SubCamera.activeSelf);
    }
}
