using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    //This is will be a panel that stores everything else for the shop
    [SerializeField] GameObject shopUI, itemButtonPrefab;
    private bool shopOpen;
    [SerializeField] List<Item> allItems, currentItems;

    void Start()
    {
        shopUI.SetActive(false);
        shopOpen = false;
        GenerateShopUI();
    }

    private void Update()
    {
        //testing the time scale works
        if(Input.GetKeyDown(KeyCode.Space))
        {
            OpenCloseShop();
        }
    }

    //Detecting when player enters the shop
    private void OnCollisionEnter2D(Collision2D coll)
    {
        //check if it's the player
        if(coll.gameObject.tag == "Player")
        {
            OpenCloseShop();
        }
    }

    //Opening and closing the shop
    private void OpenCloseShop()
    {
        //local var to get the time scale
        int timeSpeed;

        //will invert the bool so if the shops open, itll close and the other way
        shopOpen = !shopOpen;

        //Open the shop's ui, thisll be a panel that holds all the UI in a lil box.
        shopUI.SetActive(shopOpen);

        //thisll set the time scale so player cant move when shopping or can move when not shopping
        if(shopOpen)
        {
            timeSpeed = 0;
        }
        else
        {
            timeSpeed = 1;
        }
        Time.timeScale = timeSpeed;
    }

    private void GenerateShopUI()
    {
        //null check
        if(currentItems != null)
        {
            //generate a button for individual item in the store
            for(int i = 0; i < currentItems.Count; i++) 
            {
                //set some local boxes for the item it's currently working on
                Item thisItem = currentItems[i];
                GameObject thisButton = Instantiate(itemButtonPrefab, shopUI.transform);

                //Grab the script off the button
                ButtonScript thisButtonScript = thisButton.GetComponent<ButtonScript>();

                //set the name and price (icon to be added) on the button
                thisButtonScript.itemName.text = thisItem.itemName;
                thisButtonScript.price.text = thisItem.price.ToString();
            }
        }
        else
        {
            Debug.Log("No Items in store");

            //refill store
        }
    }

}
