using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene2 : MonoBehaviour
{
    public Text ScoreText;
    public static int scoa;
    // Start is called before the first frame update
    void Start()
    {
        scoa = Random.Range(0, 120);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text =scoa.ToString();
      
    }
}
