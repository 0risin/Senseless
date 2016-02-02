using UnityEngine;
using System.Collections;

public class Root {

    private static Root instance;

    private SenseManager sensemanager;
    private InputBridge input;

    public static Root Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Root();
            }

            return instance;
        }
    }

    public InputBridge Input
    {
        get
        {
            if (input == null)
            {
                input = new InputBridge();
            }

            return input;
        }
    }

    public SenseManager SenseManager
    {
        get
        {
            if (sensemanager == null)
            {
                sensemanager = new SenseManager();
            }

            return sensemanager;
        }
    }
}
