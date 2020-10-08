using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
    public Text dialogContent;

    public void ShowDialog(string content)
    {
        dialogContent.text = content;
    }
}
