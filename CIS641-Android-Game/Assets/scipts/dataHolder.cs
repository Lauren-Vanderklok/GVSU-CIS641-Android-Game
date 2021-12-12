using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataHolder : MonoBehaviour
{


    public static dataHolder Instance;

    public Color TeamColor; // new variable declared

    public List<string> inventory;

    public string lastScene;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        inventory = new List<string>();
    }

}
