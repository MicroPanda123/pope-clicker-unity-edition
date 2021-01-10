using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UAD : MonoBehaviour //UAD stands for UpgradesAndDisplay
{   
    // Start is called before the first frame update
    public GameObject PointsDisplay;
    public GameObject PointsPerClickDisplay;
    public GameObject PointsPerSecondDisplay;
    static GameObject kremowkaText;
    static GameObject sculptureText; 
    static GameObject maryText;
    static GameObject spinachText;
    private static float[] upgradeArray = {5, 8, 11, 14};

    public void FindText()
    {
        kremowkaText = GameObject.FindWithTag("kremowka");
        Debug.Log(kremowkaText.name);
        sculptureText = GameObject.FindWithTag("rzezba");
        Debug.Log(sculptureText.name);
        maryText = GameObject.FindWithTag("marysia");
        Debug.Log(maryText.name);
        spinachText = GameObject.FindWithTag("szpinak");
        Debug.Log(spinachText.name);
    }

    public static float[] UpgradeArray
    {
        get { return upgradeArray; }
        set { upgradeArray = value; }
    }
    
    void Update()
    {
        PointsDisplay.GetComponent<Text>().text = "Punkty: " + Math.Round(PointsHandler.Points, 2);
        PointsPerClickDisplay.GetComponent<Text>().text = "Punkty za klikniecie: " + PointsHandler.PointsPerClick;
        PointsPerSecondDisplay.GetComponent<Text>().text = "Punkty co sekunde: " + Math.Round(PointsHandler.PointsPerSecond*10, 2);
    }

    public static void UpdateUpgradesText(int upgrade)
    {
        switch (upgrade)
        {
            case 0:
                kremowkaText.GetComponent<Text>().text = "Kremowka - " + UpgradeArray[0] + " pkt.";
                break;
            case 1:
                sculptureText.GetComponent<Text>().text = "Rzezba - " + UpgradeArray[1] + " pkt.";
                break;
            case 2:
                maryText.GetComponent<Text>().text = "Marysia - " + UpgradeArray[2] + " pkt.";
                break;
            case 3:
                spinachText.GetComponent<Text>().text = "Szpinak - " + UpgradeArray[3] + " pkt.";
                break;
            default:
                Debug.Log("Wrong upgrade");
                break;
        }
    }
    
}