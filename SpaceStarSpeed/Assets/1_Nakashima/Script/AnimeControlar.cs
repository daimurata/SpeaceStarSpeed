using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimeControlar : MonoBehaviour
{
    public GameObject[] AnimeObj = new GameObject[3];
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("InvokeAnime1", 6f);
    }

    void InvokeAnime1()
    {
        //２つ目
        AnimeObj[1].SetActive(true);
        //１つ目false
        Destroy(AnimeObj[0]);
        //AnimeObj[0].SetActive(false);
        //3s後
        Invoke("InvokeAnime2", 3f);
    }
    void InvokeAnime2()
    {
        //３つ目
        AnimeObj[2].SetActive(true);
        //２つ目false
        Destroy(AnimeObj[1]);
        //AnimeObj[1].SetActive(false);
        Invoke("SceneMove",6f);
    }
    void SceneMove()
    {
        SceneManager.LoadScene("SelectScene");
    }

}
