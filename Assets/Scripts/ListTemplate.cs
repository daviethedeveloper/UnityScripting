using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTemplate : MonoBehaviour
{
    public List<string> wishList = new List<string>() { "Lamb", "Rolex", "Apple" };

    private void Start()
    {
        wishList.Add("Mustang");
        wishList.Insert(1, "Mansion");
        Debug.Log($"There are: {wishList.Count} items in our list");
    }
}
