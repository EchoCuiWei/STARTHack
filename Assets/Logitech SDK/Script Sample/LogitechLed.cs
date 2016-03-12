// Logitech Gaming SDK
//
// Copyright (C) 2011-2014 Logitech. All rights reserved.
// Author: Tiziano Pigliucci
// Email: devtechsupport@logitech.com

using UnityEngine;
using System.Collections;
using System;

public class LogitechLed : MonoBehaviour
{


    int K_P = 0;
    int[] FUNC = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
    int score = 0;
    int ToPress1, ToPress2, red, green, blue;
    public string effectLabel;
    Boolean start = false;
    private int Streak;
    private int START_F = 0x3b;
    private int MAX_STREAK = 8;
    private GameObject player;
    private PlayerController pc;
    // Use this for initialization
    void Start()
    {

        blue = 0;
        red = 0;
        green = 0;
        LogitechGSDK.LogiLedInit();
        player = GameObject.Find("player");
        pc = player.GetComponent<PlayerController>();
        LogitechGSDK.LogiLedSetLighting(0, 0, 0);
        System.Random rnd = new System.Random();
        K_P = new System.Random().Next(1, 26);
        start = true;
        NewKey(K_P);
    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 250, 500, 200), effectLabel);
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.R))
            {
                if ((ToPress1 == (int)KeyCode.Q && ToPress2 == (int)KeyCode.R) || (ToPress1 == (int)KeyCode.R && ToPress2 == (int)KeyCode.Q)) Correct(LogitechGSDK.keyboardNames.Q);
                else Error();
            }
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.T))
            {
                if ((ToPress1 == (int)KeyCode.W && ToPress2 == (int)KeyCode.T) || (ToPress1 == (int)KeyCode.T && ToPress2 == (int)KeyCode.W)) Correct(LogitechGSDK.keyboardNames.W);
                else Error();
            }
            if (Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.Y))
            {
                if ((ToPress1 == (int)KeyCode.E && ToPress2 == (int)KeyCode.Y) || (ToPress1 == (int)KeyCode.Y && ToPress2 == (int)KeyCode.E)) Correct(LogitechGSDK.keyboardNames.E);
                else Error();
            }
            if (Input.GetKey(KeyCode.R) && Input.GetKey(KeyCode.U))
            {
                if ((ToPress1 == (int)KeyCode.R && ToPress2 == (int)KeyCode.U) || (ToPress1 == (int)KeyCode.U && ToPress2 == (int)KeyCode.R)) Correct(LogitechGSDK.keyboardNames.R);
                else Error();
            }
            if (Input.GetKey(KeyCode.T) && Input.GetKey(KeyCode.I))
            {
                if ((ToPress1 == (int)KeyCode.T && ToPress2 == (int)KeyCode.I) || (ToPress1 == (int)KeyCode.I && ToPress2 == (int)KeyCode.T)) Correct(LogitechGSDK.keyboardNames.T);
                else Error();
            }
             if (Input.GetKey(KeyCode.Y) && Input.GetKey(KeyCode.O))
            {
                if ((ToPress1 == (int)KeyCode.Y && ToPress2 == (int)KeyCode.O) || (ToPress1 == (int)KeyCode.O && ToPress2 == (int)KeyCode.Y)) Correct(LogitechGSDK.keyboardNames.Y);
                else Error();
            }
             if (Input.GetKey(KeyCode.U) && Input.GetKey(KeyCode.P))
            {
                if ((ToPress1 == (int)KeyCode.U && ToPress2 == (int)KeyCode.P) || (ToPress1 == (int)KeyCode.P && ToPress2 == (int)KeyCode.U)) Correct(LogitechGSDK.keyboardNames.U);
                else Error();
            }
             if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.F))
            {
                if ((ToPress1 == (int)KeyCode.A && ToPress2 == (int)KeyCode.F) || (ToPress1 == (int)KeyCode.F && ToPress2 == (int)KeyCode.A)) Correct(LogitechGSDK.keyboardNames.A);
                else Error();
            }
             if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.G))
            {
                if ((ToPress1 == (int)KeyCode.S && ToPress2 == (int)KeyCode.G) || (ToPress1 == (int)KeyCode.G && ToPress2 == (int)KeyCode.S)) Correct(LogitechGSDK.keyboardNames.S);
                else Error();
            }
             if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.H))
            {
                if ((ToPress1 == (int)KeyCode.D && ToPress2 == (int)KeyCode.H) || (ToPress1 == (int)KeyCode.H && ToPress2 == (int)KeyCode.D)) Correct(LogitechGSDK.keyboardNames.D);
                else Error();
            }
             if (Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.J))
            {
                if ((ToPress1 == (int)KeyCode.F && ToPress2 == (int)KeyCode.J) || (ToPress1 == (int)KeyCode.J && ToPress2 == (int)KeyCode.F)) Correct(LogitechGSDK.keyboardNames.F);
                else Error();
            }
             if (Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.K))
            {
                if ((ToPress1 == (int)KeyCode.G && ToPress2 == (int)KeyCode.K) || (ToPress1 == (int)KeyCode.K && ToPress2 == (int)KeyCode.G)) Correct(LogitechGSDK.keyboardNames.G);
                else Error();
            }
             if (Input.GetKey(KeyCode.H) && Input.GetKey(KeyCode.L))
            {
                if ((ToPress1 == (int)KeyCode.H && ToPress2 == (int)KeyCode.L) || (ToPress1 == (int)KeyCode.L && ToPress2 == (int)KeyCode.H)) Correct(LogitechGSDK.keyboardNames.H);
                else Error();
            }
             if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.V))
            {
                if ((ToPress1 == (int)KeyCode.Z && ToPress2 == (int)KeyCode.V) || (ToPress1 == (int)KeyCode.V && ToPress2 == (int)KeyCode.Z)) Correct(LogitechGSDK.keyboardNames.Z);
                else Error();
            }
             if (Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.B))
            {
                if ((ToPress1 == (int)KeyCode.X && ToPress2 == (int)KeyCode.B) || (ToPress1 == (int)KeyCode.B && ToPress2 == (int)KeyCode.X)) Correct(LogitechGSDK.keyboardNames.X);
            else Error();
            }
             if (Input.GetKey(KeyCode.C) && Input.GetKey(KeyCode.N))
            {
                if ((ToPress1 == (int)KeyCode.C && ToPress2 == (int)KeyCode.N) || (ToPress1 == (int)KeyCode.N && ToPress2 == (int)KeyCode.C)) Correct(LogitechGSDK.keyboardNames.C);
                else Error();
            }
             if (Input.GetKey(KeyCode.V) && Input.GetKey(KeyCode.M))
            {
                if ((ToPress1 == (int)KeyCode.V && ToPress2 == (int)KeyCode.M) || (ToPress1 == (int)KeyCode.M && ToPress2 == (int)KeyCode.V)) Correct(LogitechGSDK.keyboardNames.V);
                else Error();
            }
    }



    private void Error()
    {
        LogitechGSDK.LogiLedSetLighting(100, 0, 0);
        System.Threading.Thread.Sleep(200);
        LogitechGSDK.LogiLedSetLighting(0, 0, 0);
        System.Threading.Thread.Sleep(200);
        LogitechGSDK.LogiLedSetLighting(100, 0, 0);
        System.Threading.Thread.Sleep(200);
        LogitechGSDK.LogiLedSetLighting(0, 0, 0);
        System.Threading.Thread.Sleep(500);
        score = 0;
        Streak = 0;
        for (int i = 0; i < 8; ++i) FUNC[i] = 0;
        System.Random rnd = new System.Random();
        int key = new System.Random().Next(1, 26);

        NewKey(key);
    }

    void Correct(LogitechGSDK.keyboardNames key)
    {
        pc.speed += 0.25f;
        switch(key)
        {
            case LogitechGSDK.keyboardNames.Q:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.ONE, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.TWO, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.W, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.A, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.TAB, 100, 100, 100); 
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.CAPS_LOCK, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.FOUR, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.FIVE, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.E, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.D, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T, 100, 100, 100);

                break;
            case LogitechGSDK.keyboardNames.W:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);

                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.TWO, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Q, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.A, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.S, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.E, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.THREE, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.FIVE, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.R, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.SIX, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.E:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);

                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.THREE, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.W, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.S, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.D, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.R, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.FOUR, 100, 100, 100);

                
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.SIX, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.U, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.SEVEN, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.R:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);

                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.FOUR, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.FIVE, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.E, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.D, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.SEVEN, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.J, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.I, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.EIGHT, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.T:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);

                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.FIVE, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.R, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.SIX, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.EIGHT, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.U, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.J, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.K, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.O, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.NINE, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.Y:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);

                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.SIX, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.U, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.SEVEN, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.NINE, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.I, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.K, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.L, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.P, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.ZERO, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.U:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.SEVEN, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.J, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.I, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.EIGHT, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.ZERO, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.O, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.L, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.SEMICOLON, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.MINUS, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.OPEN_BRACKET, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.A:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Q, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.W, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.S, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Z, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.LEFT_SHIFT, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.CAPS_LOCK, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.R, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.D, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.C, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.V, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.S:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.W, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.A, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Z, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.X, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.D, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.E, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.V, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.B, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.D:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.E, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.S, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.X, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.C, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.R, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.B, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.N, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.J, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.U, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.F:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.R, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.D, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.C, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.V, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.U, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.N, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.M, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.K, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.I, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.G:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.V, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.B, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.I, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.J, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.M, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.COMMA, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.L, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.O, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.H:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.B, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.N, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.J, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.U, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.O, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.K, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.COMMA, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.PERIOD, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.SEMICOLON, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.P, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.Z:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.A, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.S, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.X, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.LEFT_ALT, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.LEFT_WINDOWS, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.BACKSLASH, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.C, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.B, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.X:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.S, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Z, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.LEFT_ALT, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.C, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.D, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.V, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.N, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.C:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.D, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.X, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.V, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.B, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.M, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.J, 100, 100, 100);
                break;
            case LogitechGSDK.keyboardNames.V:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.C, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.B, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 100, 100);


                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.J, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.N, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.COMMA, 100, 100, 100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.K, 100, 100, 100);
                break;
        }
        score += 10;
        FUNC[Streak] = score;
        System.Threading.Thread.Sleep(300);
        Stop();
        for (int i = 0; i < 8; ++i)
        {
            if (FUNC[i] >= 0 && FUNC[i] < 30) LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((LogitechGSDK.keyboardNames)START_F + i, 0, 0, 0);
            else if (FUNC[i] >= 30 && FUNC[i] < 60)LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((LogitechGSDK.keyboardNames)START_F + i, 80, 80, 100);
            else if (FUNC[i] >= 60 && FUNC[i] < 90)LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((LogitechGSDK.keyboardNames)START_F + i, 40, 40, 100);
            else if (FUNC[i] >= 90 && FUNC[i] < 100)LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((LogitechGSDK.keyboardNames)START_F + i, 0, 0, 100);
            else if (FUNC[i] == 100) 
            {
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((LogitechGSDK.keyboardNames)START_F + i, 0, 0, 60);
                if (i >= Streak)
                {                      
                    score = 0;
                    Streak++;
                    if (Streak >= MAX_STREAK) Streak = 7;
                    System.Random rnd = new System.Random();
                    K_P = new System.Random().Next(1, 26);
                }
            }
        }
        NewKey(K_P);
    }

    private void Stop()
    {
        LogitechGSDK.LogiLedSetLighting(0, 0, 0);
    }

    void NewKey(int key)
    {
        switch (key)
        {
            case 1:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Q, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Q+0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.Q;
                ToPress2 = (int)KeyCode.R;
                break;
            case 2:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.W, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.W + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.W;
                ToPress2 = (int)KeyCode.T;
                break;
            case 3:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.E, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.E + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.E;
                ToPress2 = (int)KeyCode.Y;
                break;
            case 4:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.R, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.R + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.R;
                ToPress2 = (int)KeyCode.U;
                break;
            case 5:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.T;
                ToPress2 = (int)KeyCode.I;
                break;
            case 6:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.Y;
                ToPress2 = (int)KeyCode.O;
                break;
            case 7:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.U, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.U + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.U;
                ToPress2 = (int)KeyCode.P;
                break;
            case 8:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.I, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.I - 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.I;
                ToPress2 = (int)KeyCode.T;
                break;
            case 9:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.O, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.O - 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.O;
                ToPress2 = (int)KeyCode.Y;
                break;
            case 10:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.P, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.P - 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.P;
                ToPress2 = (int)KeyCode.U;
                break;
            case 11:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.A, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.A + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.A;
                ToPress2 = (int)KeyCode.F;
                break;
            case 12:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.S, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.S + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.S;
                ToPress2 = (int)KeyCode.G;
                break;
            case 13:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.D, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.D + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.D;
                ToPress2 = (int)KeyCode.H;
                break;
            case 14:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.F;
                ToPress2 = (int)KeyCode.J;
                break;
            case 15:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.G;
                ToPress2 = (int)KeyCode.K;
                break;
            case 16:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.H;
                ToPress2 = (int)KeyCode.L;
                break;
            case 17:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.J, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.J - 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.J;
                ToPress2 = (int)KeyCode.F;
                break;
            case 18:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.K, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.K - 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.K;
                ToPress2 = (int)KeyCode.G;
                break;
            case 19:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.L, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.L - 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.L;
                ToPress2 = (int)KeyCode.H;
                break;
            case 20:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Z, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Z + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.Z;
                ToPress2 = (int)KeyCode.V;
                break;
            case 21:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.X, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.X + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.X;
                ToPress2 = (int)KeyCode.B;
                break;
            case 22:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.C, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.C + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.C;
                ToPress2 = (int)KeyCode.N;
                break;
            case 23:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.V, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.V + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.V;
                ToPress2 = (int)KeyCode.M;
                break;
            case 24:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.B, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.B - 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.B;
                ToPress2 = (int)KeyCode.X;
                break;
            case 25:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.N, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.N - 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.N;
                ToPress2 = (int)KeyCode.C;
                break;
            case 26:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.M, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.M - 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.M;
                ToPress2 = (int)KeyCode.V;
                break;

        }
    }

    void OnDestroy()
    {
        //Before quitting, we need to restore the user's backlighting settings
        LogitechGSDK.LogiLedRestoreLighting();
        LogitechGSDK.LogiLedShutdown();
    }
}
