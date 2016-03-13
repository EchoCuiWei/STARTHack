using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;
using System.IO;

public class LogitechArxControl : MonoBehaviour
{

    private String descriptionLabel;
    IntPtr ctx_flags;
    // Use this for initialization
    void Start()
    {

        LogitechGSDK.logiArxCbContext cbContext;
        LogitechGSDK.logiArxCB cbInstance = new LogitechGSDK.logiArxCB(this.ArxSDKCallback);
        ctx_flags = Marshal.AllocHGlobal(sizeof(int));
        cbContext.arxCallBack = cbInstance;
        cbContext.arxContext = ctx_flags;

        LogitechGSDK.LogiArxInit("com.logitech.unitysample", "Unity Sample", ref cbContext);
//dos xaiets anaven a passeig i van trobar una flor molt bonñica molt bonica. Era una Rosella, i el seu vermell els va deixar bocabadats. Oh, que bonic!!!!!
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 350, 500, 50), descriptionLabel);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            //On left-mouse click set random value on applet's progress bar
            System.Random random = new System.Random();
            int val = random.Next(0, 100);
            LogitechGSDK.LogiArxSetTagPropertyById("progressbarProgress", "style.width", "" + val + "%");
        }
        ///Switch index file on right-mouse down and up
        if (Input.GetKey(KeyCode.I))
        {
            LogitechGSDK.LogiArxSetIndex("applet.html");
        }
        if (Input.GetKey(KeyCode.G))
        {
            LogitechGSDK.LogiArxSetIndex("gameover.html");
        }

        if (Marshal.ReadInt32(ctx_flags) == 1)
        {
            Marshal.WriteInt32(ctx_flags, 0);
            Debug.Log("Marshal works");
            transform.position += new Vector3(1, 0, 0);
        }
    }

    public static string getHtmlString()
    {
        string retStr = "";
        retStr += "<html><center><body bgcolor='black'><a href='applet.html'><img src='gameover.png'/></a></body></center></html>";
        return retStr;
    }

    void ArxSDKCallback(int eventType, int eventValue, String eventArg, IntPtr context)
    {

        Marshal.WriteInt32(context, 1);
        Debug.Log("CALLBACK: type:" + eventType + ", value:" + eventValue + ", arg:" + eventArg);
        if (eventType == LogitechGSDK.LOGI_ARX_EVENT_MOBILEDEVICE_ARRIVAL)
        {
            if (!LogitechGSDK.LogiArxAddFileAs("Assets//Logitech SDK//AppletData//applet.html", "applet.html", ""))
            {
                Debug.Log("Could not send applet.html : " + LogitechGSDK.LogiArxGetLastError());
            }
            if (!LogitechGSDK.LogiArxAddFileAs("Assets//Logitech SDK//AppletData//background.png", "background.png", ""))
            {
                Debug.Log("Could not send background.png : " + LogitechGSDK.LogiArxGetLastError());
            }
            if (!LogitechGSDK.LogiArxAddUTF8StringAs(getHtmlString(), "gameover.html"))
            {
                Debug.Log("Could not send gameover.html  : " + LogitechGSDK.LogiArxGetLastError());
            }

            byte[] gameoverImageBytes = File.ReadAllBytes("Assets//Logitech SDK//AppletData//gameover.png");
            if (!LogitechGSDK.LogiArxAddContentAs(gameoverImageBytes, gameoverImageBytes.Length, "gameover.png"))
            {
                Debug.Log("Could not send gameover.png  : " + LogitechGSDK.LogiArxGetLastError());
            }

            if (!LogitechGSDK.LogiArxSetIndex("applet.html"))
            {
                Debug.Log("Could not set index : " + LogitechGSDK.LogiArxGetLastError());
            }

        }
        else if (eventType == LogitechGSDK.LOGI_ARX_EVENT_MOBILEDEVICE_REMOVAL)
        {
            Debug.Log("NO DEVICES");
        }
        else if (eventType == LogitechGSDK.LOGI_ARX_EVENT_TAP_ON_TAG)
        {
            Debug.Log("Tap on tag with id :" + eventArg);
        }
    }

    void OnDestroy()
    {
        //Free G-Keys SDKs before quitting the game
        LogitechGSDK.LogiArxShutdown();
    }
}