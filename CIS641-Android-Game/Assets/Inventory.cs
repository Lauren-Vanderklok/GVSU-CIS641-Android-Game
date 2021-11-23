using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public string InventoryPanelName = "Inventory_Panel";
    public string InventoryContentName = "Content";


    
    public GameObject panel;
    public GameObject content;
    public GameObject imagePrefab;

    private List<Key> inventory;

    public void addKey(Key key)
    {
        inventory.Add(key);
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

            foreach (Key key in inventory)
            {
                Transform contentTransform = content.GetComponent<Transform>();

                GameObject newObj = (GameObject)Instantiate(imagePrefab, contentTransform);

                Image NewImage = newObj.GetComponent<Image>();
                NewImage.sprite = Resources.Load<Sprite>("Keys/" + key.ID);

            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        inventory = new List<Key>();

        if (panel == null)
        {
            panel = GameObject.Find(InventoryPanelName);
        }

        if (content == null)
        {
            content = GameObject.Find(InventoryContentName);
        }

        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
