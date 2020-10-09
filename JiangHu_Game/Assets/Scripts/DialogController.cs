using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//引入命名空间

public class DialogController : MonoBehaviour
{
    public Text DialogRoleName;
    public Text DialogContent;

    public void ShowDialog(string name, string content)
    {
        gameObject.SetActive(true);
        DialogRoleName.text = name;
        DialogContent.text = content;
    }
}