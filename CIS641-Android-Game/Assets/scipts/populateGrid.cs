using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class populateGrid : MonoBehaviour
{

    public GameObject prefab; // This is our prefab object that will be exposed in the inspector

    public int numberToCreate; // number of objects to create. Exposed in inspector



    // Start is called before the first frame update
    void Start()
    {
        Populate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Populate()
    {
        GameObject newObj; // Create GameObject instance

        for (int i = 0; i < numberToCreate; i++)
        {
            // Create new instances of our prefab until we've created as many as we specified
            newObj = (GameObject)Instantiate(prefab, transform);

            // Randomize the color of our image
          //  newObj.GetComponent<Image>().color = Random.ColorHSV();
        }

    }
}
