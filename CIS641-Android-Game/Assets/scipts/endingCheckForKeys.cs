using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endingCheckForKeys : MonoBehaviour
{
    public string[] shipParts = { "StarMap", "SteeringWheel", "gascan", "plant" };

    void OnTriggerEnter2D(Collider2D other)
    {
        Inventory i = GameObject.Find("Alien").GetComponent<Inventory>();

        int numNeededKeys = 0;
        foreach (string id in shipParts)
        {
            if (i.hasKey(id))
            {
                numNeededKeys++;
            }
        }

        if (numNeededKeys == shipParts.Length)
        {
            dataHolder.Instance.inventory = new List<string>();
            SceneManager.LoadScene("Closing");
        }


    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
