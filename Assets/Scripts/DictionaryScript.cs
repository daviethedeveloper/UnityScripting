using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryScript : MonoBehaviour
{
    // Declaration of a Dictionary
    private Dictionary<string, int> inventoryDic = new Dictionary<string, int>()
    {
        { "sword", 100 },
        { "Magic wand", 24 },
        { "Health potion", 100 }
    };


    private void Start()
    {
        Debug.Log($"Original Cost of Magic Wand: {inventoryDic["Magic wand"]}");
        inventoryDic["Magic wand"] = 300;
        Debug.Log($"The new cost of Magic wand is: {inventoryDic["Magic wand"]}");
        
        // using the Add key word
        inventoryDic.Add("Knife", 20);
        
        // checking if the Key exists
        if (inventoryDic.ContainsKey("Bracelet"))
        {
            inventoryDic["Bracelet"] = 30;
        }
        else
        {
            Debug.Log("No such key exists in this dictionary ");
        }
        
        
        // remove from the dictionary use the Remove Keyword

        inventoryDic.Remove("Sword");
    }
}
