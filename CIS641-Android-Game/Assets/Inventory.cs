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
    private string savedInventoryPath = "test.txt";

    public void addKey(Key key)
    {
        inventory.Add(key.ID);

        using (StreamWriter writer = new StreamWriter(savedInventoryPath))
        {
            foreach (string k in inventory)
            {
                writer.WriteLine(k);
            }
            
        }

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

        inventory = new List<string>();
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

        // FileStream F = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.Read);

        if (!File.Exists(savedInventoryPath))
        {
            StreamWriter writer = File.CreateText(savedInventoryPath);
        }
        else
        {
            using (StreamReader reader = File.OpenText(savedInventoryPath))
            {
                string s = reader.ReadToEnd();

                string[] keyIDs = s.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                //int count = 0;
                foreach (string id in keyIDs)
                {
                    inventory.Add(id);

                    //Key key = new Key(id);
                    //addKey(key);
                   // count++;
                }

                string o = reader.ReadToEnd();

                //foreach (var token in s.Tokenize('\n'))
                //{
                //    // Access the tokens here...
                //}

                //while ((s = reader.ReadLine()) != null)
                //{
                //    Console.WriteLine(s);

                //}
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
