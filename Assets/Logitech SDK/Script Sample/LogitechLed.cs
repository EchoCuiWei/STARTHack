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

    /*int G810_KEY_GRID[7][23] = {
        {0x29,      0x02,  0x03,   0x04,   0x05,   0x06,   0x07,   0x08,   0x09,   0x0A,   0x0B,    0x0C},
        {0x0F,      0x10,  0x11,   0x12,   0x13,   0x14,   0x15,   0x16,   0x17,   0x18,   0x19,    0x1A},
        {0x3A,      0x1E,  0x1F,   0x20,   0x21,   0x22,   0x23,   0x24,   0x25,   0x26,   0x27,    0},
        {0x2A,      0X2B,  0,      0x14,   0x1A,   0x08,   0x15,   0x17,   0x1C,   0x18,   0x0C,   0x12,   0x13,   0x2F,   0x30,   0x31,      0x4C,   0x4D,   0x4E,       0x5F,   0x60,   0x61,   0    },
        {0x103,     0x39,  0,      0x04,   0x16,   0x07,   0x09,   0x0A,   0x0B,   0x0D,   0x0E,   0x0F,   0x33,   0x34,   0x32,   0x28,      0,      0,      0,          0x5C,   0x5D,   0x5E,   0x57 },
        {0x104,     0xE1,  0,      0x64,   0x1D,   0x1B,   0x06,   0x19,   0x05,   0x11,   0x10,   0x36,   0x37,   0x38,   0x87,   0xE5,      0,      0x52,   0,          0x59,   0x5A,   0x5B,   0    },
        {0x105,     0xE0,  0,      0xE3,   0xE2,   0x8b,   0,      0,      0,   0,      0,      0x8A,   0xE6,   0xE7,   0x65,   0xE4,      0x50,   0x51,   0x4F,       0x62,   0,      0x63,   0x58 }
    };
    */

    int score = 0;
    int ToPress1, ToPress2, red, green, blue;
    public string effectLabel;
    Boolean start = false;
    // Use this for initialization
    void Start()
    {

        blue = 0;
        red = 0;
        green = 0;
        LogitechGSDK.LogiLedInit();

        LogitechGSDK.LogiLedSetLighting(0, 0, 0);
        System.Random rnd = new System.Random();
        int key = new System.Random().Next(1, 26);
        Debug.Log(key);
        start = true;
        NewKey(key);
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
        System.Random rnd = new System.Random();
        int key = new System.Random().Next(1, 26);
        NewKey(key);
    }

    void Correct(LogitechGSDK.keyboardNames key)
    {

        switch(key)
        {
            case LogitechGSDK.keyboardNames.Q:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.W:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.E:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.R:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.T:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.Y:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.U:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.A:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.S:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.D:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.F:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.G:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.H:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.Z:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.X:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.C:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
            case LogitechGSDK.keyboardNames.V:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key + 0x03, 0, 100, 0);
                break;
        }
        
        System.Threading.Thread.Sleep(300);

        Stop();
        System.Random rnd = new System.Random();
        int key2 = new System.Random().Next(1, 26);
        NewKey(key2);
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
                ToPress2 = (int)KeyCode.R + 0x03;
                break;
            case 5:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.T;
                ToPress2 = (int)KeyCode.T + 0x03;
                break;
            case 6:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y, 100, 0, 0);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y + 0x03, 100, 0, 0);
                ToPress1 = (int)KeyCode.Y;
                ToPress2 = (int)KeyCode.U;
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
