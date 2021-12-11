using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class alienPlacer : MonoBehaviour
{
    public string currentScene;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        string lastScene = dataHolder.Instance.lastScene;
        if (lastScene != null)
        {
            if (currentScene == "maze")
            {
                if (lastScene == "meadow")
                {
                    gameObject.transform.position = new Vector3(-30.3f, 3.1f);
                }
                else if (lastScene == "Level one scene")
                {
                    gameObject.transform.position = new Vector3(67.5f, -28.8f);
                }
            }
            else if (currentScene == "Level one scene")
            {
                if (lastScene == "Lake")
                {
                    gameObject.transform.position = new Vector3(-44f, -13.1f);
                }
                else if (lastScene == "maze")
                {
                    gameObject.transform.position = new Vector3(-195f, -20.8f);
                }
                else if (lastScene == "City2")
                {
                    gameObject.transform.position = new Vector3(172.6f, 44.9f);
                }
            }
            else if (currentScene == "City2")
            {
                if (lastScene == "Level one scene")
                {
                    gameObject.transform.position = new Vector3(-20.9f, 28.7f);
                }
                else if (lastScene == "Planetarium")
                {
                    gameObject.transform.position = new Vector3(-1f, 8.2f);
                }
            }
        }

        dataHolder.Instance.lastScene = currentScene;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
