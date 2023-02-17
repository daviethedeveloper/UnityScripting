using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour
{
    // type - name - value ;
    // [SerializeField] will allow to be manipulated
    // in the inspector window, but will not be accesible to any other classes "private"
    // public and private is how encapsulated you want your methods/variables to be to other classes
    [SerializeField] private int playerHealth = 10;
    [SerializeField] private float playerExperience = 120f;
    [SerializeField] private string playerName = "LevelUp";
    [SerializeField] private bool isPlayerAlive = true;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Health: " + playerHealth);
        Debug.Log("Player Experience: " + playerExperience);
        Debug.Log("Player Name: "+ playerName);
        Debug.Log("Player alive? " + isPlayerAlive);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
