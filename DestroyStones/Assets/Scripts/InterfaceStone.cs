﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceStone : MonoBehaviour
{
    public Text textThrown;
    public Text textDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textThrown.text = "Lives: " + GameManager.currentNumberLives;
        textDestroyed.text = "Destroyed: " + GameManager.currentNumberDestroyedStones;
    }
}
