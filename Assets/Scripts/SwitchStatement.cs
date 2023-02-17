using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    [SerializeField] private int playerExperience;
    // Start is called before the first frame update
    void Start()
    {
        ComparePlayerExperience();
    }
    // right cases to follow where they are going
    private void ComparePlayerExperience()
    {
        // switch - condition - case statment for paths
        switch (playerExperience)
        {
            case 0: Debug.Log("Player experience is zero");
                break;
            case 1: Debug.Log("Player experience is one");
                break;
            case 2: Debug.Log("Player experience is two");
                break;
            default: Debug.Log("Null reference");
                break;
        }
    }

}
