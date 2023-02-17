using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    // set the size of an array
    public int[] firstArray = new int[3];

    public int[] playerScores = new int[3];

    // public int[] topThreeScores = new int[] { 1, 4, 5 };

    public int[] topThreeScores = { 500, 200, 300 };

    private void Start()
    {
        topThreeScores[1] = 25;
        Debug.Log(topThreeScores[1]);
    }
}
