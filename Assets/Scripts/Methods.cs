using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    [SerializeField] private int playerHealth = 100;
    [SerializeField] private int damagePoint = 10;

    // methods - will take health off player damage

    private void Start()
    {
        playerHealth = DamagePlayer(playerHealth, damagePoint);
    }

    private int DamagePlayer(int num1, int num2)
    {
        var result = num1 - num2;
        return result;
    }
}
