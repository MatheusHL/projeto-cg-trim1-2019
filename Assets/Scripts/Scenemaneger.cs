﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions; 

public class Scenemaneger : MonoBehaviour
{
    public static Scenemaneger instance = null;

    [SerializeField]
    private Vector3 TapeSpeed = new Vector3(-2f, 0f ,0f);
    [SerializeField]
    private Transform Tape = null;

    public UIComponents uiComponents;

    SceneData sceneData = new SceneData();

    void Awake(){
        Assert.IsNotNull(Tape);
        if (instance == null)
        {
            instance = this;
        }
    }

    
    void Update()
    {
       Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
        DisplayHudData();
    }

    public void IncrementCoinCount()
    {
        sceneData.coinCount++;
    }

    void DisplayHudData()
    {
        uiComponents.hud.txtCoinCount.text = "X " + sceneData.coinCount;
    }
}
