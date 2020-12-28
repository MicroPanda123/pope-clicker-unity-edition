using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsHandler : MonoBehaviour
{
    public static int Points = 0;
    public static int PointsPerClick = 1;
    public static int PointsPerSecond = 0;
    public GameObject PointsDisplay;
    public GameObject PointsPerClickDisplay;
    public GameObject PointsPerSecondDisplay;

    void Start()
    {
        InvokeRepeating("AdmitPointsPerSecond", 1f, 1f);
    }

    void Update()
    {
        PointsDisplay.GetComponent<Text>().text = "Punkty: " + Points;
        PointsPerClickDisplay.GetComponent<Text>().text = "Punkty za klikniecie: " + PointsPerClick;
        PointsPerSecondDisplay.GetComponent<Text>().text = "Punkty co sekunde: " + PointsPerSecond;
    }
    void AdmitPointsPerSecond()
    {
        Points += PointsPerSecond;
        Debug.Log(PointsPerSecond);
        Debug.Log(Points);
    }
    public static void BuyPPC(int Cost, int Value)
    {
        if (Points >= Cost)
        {
            Points -= Cost;
            PointsPerClick += Value;
        }
    }
    public static void BuyPPS(int Cost, int Value)
    {
        if (Points >= Cost)
        {
            Points -= Cost;
            PointsPerSecond += Value;
            Debug.Log(PointsPerSecond);
        }
    }
}
