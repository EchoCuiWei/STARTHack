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
    int ToPress, red, green, blue;
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
        effectLabel = "Press Space bar to start";
    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 250, 500, 200), effectLabel);
    }

    // Update is called once per frame
    void Update()
    {



        /*if (Input.GetKey(KeyCode.Mouse0))
        {
            //On mouse click set random color backlighting. In the monochrome backlighting devices it will change the brightness.
            System.Random random = new System.Random();
            red = random.Next(0, 100);
            blue = random.Next(0, 100);
            green = random.Next(0, 100);
            LogitechGSDK.LogiLedSetLighting(red, blue, green);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            byte[] bitmap = new byte[LogitechGSDK.LOGI_LED_BITMAP_SIZE];
            System.Random random = new System.Random();
            for (int i = 0; i < LogitechGSDK.LOGI_LED_BITMAP_SIZE; i++)
            {
                bitmap[i] = (byte)random.Next(0, 255);
            }
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        }*/
        if (Input.GetKey(KeyCode.Space))
        {
            System.Random rnd = new System.Random();
            int key = new System.Random().Next(1, 26);
            NewKey(key);
            start = true;
        }
        else if (start)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                if (ToPress == (int)KeyCode.Q) Correct(LogitechGSDK.keyboardNames.Q);
                else Error();
            }
            else if (Input.GetKey(KeyCode.W))
            {
                if (ToPress == (int)KeyCode.W) Correct(LogitechGSDK.keyboardNames.W);
                else Error();
            }
            else if (Input.GetKey(KeyCode.E))
            {
                if (ToPress == (int)KeyCode.E) Correct(LogitechGSDK.keyboardNames.E);
                else Error();
            }
            else if (Input.GetKey(KeyCode.R))
            {
                if (ToPress == (int)KeyCode.R) Correct(LogitechGSDK.keyboardNames.R);
                else Error();
            }
            else if (Input.GetKey(KeyCode.T))
            {
                if (ToPress == (int)KeyCode.T) Correct(LogitechGSDK.keyboardNames.T);
                else Error();
            }
            else if (Input.GetKey(KeyCode.Y))
            {
                if (ToPress == (int)KeyCode.Y) Correct(LogitechGSDK.keyboardNames.Y);
                else Error();
            }
            else if (Input.GetKey(KeyCode.U))
            {
                if (ToPress == (int)KeyCode.U) Correct(LogitechGSDK.keyboardNames.U);
                else Error();
            }
            else if (Input.GetKey(KeyCode.I))
            {
                if (ToPress == (int)KeyCode.I) Correct(LogitechGSDK.keyboardNames.I);
                else Error();
            }
            else if (Input.GetKey(KeyCode.O))
            {
                if (ToPress == (int)KeyCode.O) Correct(LogitechGSDK.keyboardNames.O);
                else Error();
            }
            else if (Input.GetKey(KeyCode.P))
            {
                if (ToPress == (int)KeyCode.P) Correct(LogitechGSDK.keyboardNames.P);
                else Error();
            }
            else if (Input.GetKey(KeyCode.A))
            {
                if (ToPress == (int)KeyCode.A) Correct(LogitechGSDK.keyboardNames.A);
                else Error();
            }
            else if (Input.GetKey(KeyCode.S))
            {
                if (ToPress == (int)KeyCode.S) Correct(LogitechGSDK.keyboardNames.S);
                else Error();
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (ToPress == (int)KeyCode.D) Correct(LogitechGSDK.keyboardNames.D);
                else Error();
            }
            else if (Input.GetKey(KeyCode.F))
            {
                if (ToPress == (int)KeyCode.F) Correct(LogitechGSDK.keyboardNames.F);
                else Error();
            }
            else if (Input.GetKey(KeyCode.G))
            {
                if (ToPress == (int)KeyCode.G) Correct(LogitechGSDK.keyboardNames.G);
                else Error();
            }
            else if (Input.GetKey(KeyCode.H))
            {
                if (ToPress == (int)KeyCode.H) Correct(LogitechGSDK.keyboardNames.H);
                else Error();
            }
            else if (Input.GetKey(KeyCode.J))
            {
                if (ToPress == (int)KeyCode.J) Correct(LogitechGSDK.keyboardNames.J);
                else Error();
            }
            else if (Input.GetKey(KeyCode.K))
            {
                if (ToPress == (int)KeyCode.K) Correct(LogitechGSDK.keyboardNames.K);
                else Error();
            }
            else if (Input.GetKey(KeyCode.L))
            {
                if (ToPress == (int)KeyCode.L) Correct(LogitechGSDK.keyboardNames.L);
                else Error();
            }
            else if (Input.GetKey(KeyCode.Z))
            {
                if (ToPress == (int)KeyCode.Z) Correct(LogitechGSDK.keyboardNames.Z);
                else Error();
            }
            else if (Input.GetKey(KeyCode.X))
            {
                if (ToPress == (int)KeyCode.X) Correct(LogitechGSDK.keyboardNames.X);
                else Error();
            }
            else if (Input.GetKey(KeyCode.C))
            {
                if (ToPress == (int)KeyCode.C) Correct(LogitechGSDK.keyboardNames.C);
                else Error();
            }
            else if (Input.GetKey(KeyCode.V))
            {
                if (ToPress == (int)KeyCode.V) Correct(LogitechGSDK.keyboardNames.V);
                else Error();
            }
            else if (Input.GetKey(KeyCode.B))
            {
                if (ToPress == (int)KeyCode.B) Correct(LogitechGSDK.keyboardNames.B);
                else Error();
            }
            else if (Input.GetKey(KeyCode.N))
            {
                if (ToPress == (int)KeyCode.N) Correct(LogitechGSDK.keyboardNames.N);
                else Error();
            }
            else if (Input.GetKey(KeyCode.M))
            {
                if (ToPress == (int)KeyCode.M) Correct(LogitechGSDK.keyboardNames.M);
                else Error();
            }
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
        LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, 0, 100, 0);
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
                ToPress = (int)KeyCode.Q;
                break;
            case 2:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.W, 100, 0, 0);
                ToPress = (int)KeyCode.W;
                break;
            case 3:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.E, 100, 0, 0);
                ToPress = (int)KeyCode.E;
                break;
            case 4:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.R, 100, 0, 0);
                ToPress = (int)KeyCode.R;
                break;
            case 5:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.T, 100, 0, 0);
                ToPress = (int)KeyCode.T;
                break;
            case 6:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Y, 100, 0, 0);
                ToPress = (int)KeyCode.Y;
                break;
            case 7:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.U, 100, 0, 0);
                ToPress = (int)KeyCode.U;
                break;
            case 8:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.I, 100, 0, 0);
                ToPress = (int)KeyCode.I;
                break;
            case 9:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.O, 100, 0, 0);
                ToPress = (int)KeyCode.O;
                break;
            case 10:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.P, 100, 0, 0);
                ToPress = (int)KeyCode.P;
                break;
            case 11:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.A, 100, 0, 0);
                ToPress = (int)KeyCode.A;
                break;
            case 12:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.S, 100, 0, 0);
                ToPress = (int)KeyCode.S;
                break;
            case 13:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.D, 100, 0, 0);
                ToPress = (int)KeyCode.D;
                break;
            case 14:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.F, 100, 0, 0);
                ToPress = (int)KeyCode.F;
                break;
            case 15:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.G, 100, 0, 0);
                ToPress = (int)KeyCode.G;
                break;
            case 16:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.H, 100, 0, 0);
                ToPress = (int)KeyCode.H;
                break;
            case 17:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.J, 100, 0, 0);
                ToPress = (int)KeyCode.J;
                break;
            case 18:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.K, 100, 0, 0);
                ToPress = (int)KeyCode.K;
                break;
            case 19:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.L, 100, 0, 0);
                ToPress = (int)KeyCode.L;
                break;
            case 20:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.Z, 100, 0, 0);
                ToPress = (int)KeyCode.Z;
                break;
            case 21:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.X, 100, 0, 0);
                ToPress = (int)KeyCode.X;
                break;
            case 22:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.C, 100, 0, 0);
                ToPress = (int)KeyCode.C;
                break;
            case 23:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.V, 100, 0, 0);
                ToPress = (int)KeyCode.V;
                break;
            case 24:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.B, 100, 0, 0);
                ToPress = (int)KeyCode.B;
                break;
            case 25:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.N, 100, 0, 0);
                ToPress = (int)KeyCode.N;
                break;
            case 26:
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.M, 100, 0, 0);
                ToPress = (int)KeyCode.M;
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
