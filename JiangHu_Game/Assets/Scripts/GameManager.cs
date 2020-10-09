using UnityEngine;
using System.Collections;
//-----------------------------------------
//Sample Game Manager class - Singleton Object
public class GameManager : MonoBehaviour
{
    //-----------------------------------------
    //C# Property to get access to singleton instance
    //Read only - only has get accessor
    public static GameManager Instance
    {
        //return reference to private instance
        get
        {
            return instance;
        }
    }

    //-----------------------------------------
    private static GameManager instance = null;
    //-----------------------------------------
    public DialogController Dialog;
    //-----------------------------------------
    // Use this for initialization
    void Awake()
    {
        //Check if any existing instance of the class exists in the scene
        //If so, then destroy this instance
        if (instance)
        {
            DestroyImmediate(gameObject);
            return;
        }

        //Make this active and only instance
        instance = this;

        //Make game manager persistent
        DontDestroyOnLoad(gameObject);

        //instance.Dialog.gameObject.SetActive(false);
    }
    //-----------------------------------------
}