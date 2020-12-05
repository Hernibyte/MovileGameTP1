using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dificulty : MonoBehaviour
{
    public static Dificulty instance;
    public bool easyMode;

    private void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void easyModeActivate()
    {
        easyMode = true;
    }

    public void normalModeActivate()
    {
        easyMode = false;
    }
}
