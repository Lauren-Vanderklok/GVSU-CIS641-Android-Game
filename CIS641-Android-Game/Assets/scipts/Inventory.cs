using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;

using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    public string InventoryPanelName = "Inventory_Panel";
    public string InventoryContentName = "Content";


    
    public GameObject panel;
    public GameObject content;
    public GameObject imagePrefab;
    

    private List<string> inventory;
    private List<string> alreadyDisplayed;
 //   private string savedInventoryPath = "test.txt";

    public void addKey(Key key)
    {
        inventory.Add(key.ID);

        //using (StreamWriter writer = new StreamWriter(savedInventoryPath))
        //{
        //    foreach (string k in inventory)
        //    {
        //        writer.WriteLine(k);
        //    }
            
        //}

    }

    public bool hasKey(string ID)
    {
        foreach (string k in inventory)
        {
            if (k == ID)
            {
                return true;
            }
        }
        return false;
    }

    public void displayInventory()
    {


        if (panel.activeSelf)
        {
            panel.SetActive(false);
            
        }
        else
        {
            panel.SetActive(true);

            foreach (string key in inventory)
            {
                bool displayed = false;
                foreach (string prevKey in alreadyDisplayed)
                {
                    if (key == prevKey)
                    {
                        displayed = true;
                        break;
                    }
                }
                if (!displayed)
                {
                    Transform contentTransform = content.GetComponent<Transform>();

                    GameObject newObj = (GameObject)Instantiate(imagePrefab, contentTransform);

                    Image NewImage = newObj.GetComponent<Image>();
                    NewImage.sprite = Resources.Load<Sprite>("Keys/" + key);
                    alreadyDisplayed.Add(key);
                }

            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {

       // Destroy(GameObject.Find("Oar"));

        inventory = dataHolder.Instance.inventory;

        alreadyDisplayed = new List<string>();

        if (panel == null)
        {
            panel = GameObject.Find(InventoryPanelName);
        }

        if (content == null)
        {
            content = GameObject.Find(InventoryContentName);
        }

        panel.SetActive(false);

        foreach (string key in inventory)
        {
            Destroy(GameObject.Find(key));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
