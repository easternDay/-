using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{

    public Button PlayButton;

    // Start is called before the first frame update
    void Start()
    {
        PlayButton.onClick.AddListener(OnPlayButtonClick);//PlayButton点击事件监听
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnPlayButtonClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
