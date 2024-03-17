using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    //This is will be a panel that stores everything else for the shop
    [SerializeField] GameObject shopUI;
    private bool shopOpen;
    [SerializeField] List<GameObject> allItems, currentItems;

    void Start()
    {
        shopUI.SetActive(false);
        shopOpen = false;
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
        if(coll.gameObject.tag == "Player")
        {
            OpenCloseShop();
        }
    }

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

}
