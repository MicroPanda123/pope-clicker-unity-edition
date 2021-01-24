using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsHandler : MonoBehaviour
{
    private static float _points = 0;

    public static float Points
    {
        get { return _points; }
        set { _points = value;  }
    }

    private static float _pointsPerClick = 1;
    public static float PointsPerClick
    {
        get { return _pointsPerClick; }
        set { _pointsPerClick = value;  }
    }
    private static float pointsPerSecond = 0;

    public static float PointsPerSecond
    {
        get { return pointsPerSecond; }
        set { pointsPerSecond = value; }
    }

    private void Start()
    {
        InvokeRepeating("AdmitPointsPerSecond", 0.1f, 0.1f);
    }

    private void AdmitPointsPerSecond() //Submits points per second
    {
        Points += PointsPerSecond;
        Debug.Log(PointsPerSecond);
        Debug.Log(Points);
    }
    public static void BuyPpc(float cost, float value) //Increases Points Per Click value 
    {
        if (!(Points >= cost)) return;
        Points -= cost;
        PointsPerClick += value;
    }
    public static void BuyPps(float cost, float value, int upgrade) //Increases Points Per Second value
    {
        if (!(Points >= cost)) return;
        Points -= cost;
        PointsPerSecond += value;
        Debug.Log(PointsPerSecond);
        UAD.UpgradeArray[upgrade] = UAD.UpgradeArray[upgrade] * 1.3f;
        UAD.UpdateUpgradesText(upgrade);
    }
}
