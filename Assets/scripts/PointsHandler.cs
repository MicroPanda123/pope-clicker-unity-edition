using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsHandler : MonoBehaviour
{
    public static float Points = 0;
    public static float PointsPerClick = 1;
    public static float PointsPerSecond = 0;
    public GameObject PointsDisplay;
    public GameObject PointsPerClickDisplay;
    public GameObject PointsPerSecondDisplay;

    void Start()
    {
        InvokeRepeating("AdmitPointsPerSecond", 0.1f, 0.1f);
    }

    void Update()
    {
        PointsDisplay.GetComponent<Text>().text = "Punkty: " + Math.Round(Points, 2);
        PointsPerClickDisplay.GetComponent<Text>().text = "Punkty za klikniecie: " + PointsPerClick;
        PointsPerSecondDisplay.GetComponent<Text>().text = "Punkty co sekunde: " + Math.Round(PointsPerSecond*10, 2);
    }
    void AdmitPointsPerSecond()
    {
        Points += PointsPerSecond;
        Debug.Log(PointsPerSecond);
        Debug.Log(Points);
    }
    public static void BuyPpc(int Cost, float Value)
    {
        if (Points >= Cost)
        {
            Points -= Cost;
            PointsPerClick += Value;
        }
    }
    public static void BuyPps(int Cost, float Value)
    {
        if (Points >= Cost)
        {
            Points -= Cost;
            PointsPerSecond += Value;
            Debug.Log(PointsPerSecond);
        }
    }
}
