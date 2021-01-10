using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popescript : MonoBehaviour
{
    void OnMouseDown()
    {
        //Debug.Log("Papeiz");
        Debug.Log(name);
        switch (name) //Detects what object was clicked and determines what to do
        {
            case "pope":
                PointsHandler.Points += PointsHandler.PointsPerClick;
                Debug.Log(PointsHandler.Points);
                break;
            case "kremowka":
                PointsHandler.BuyPps(UAD.UpgradeArray[0], 0.01f, 0);
                break;
            case "sculpture":
                PointsHandler.BuyPps(UAD.UpgradeArray[1], 0.1f, 1);
                break;
            case "mary":
                PointsHandler.BuyPps(UAD.UpgradeArray[2], 0.5f, 2);
                break;
            case "spinach":
                PointsHandler.BuyPps(UAD.UpgradeArray[3], 1f, 3);
                break;
            default:
                Debug.Log("Invalid name");
                break;
        }

        //if (name == "pope")
        //{
        //    PointsHandler.Points += PointsHandler.PointsPerClick;
        //    Debug.Log(PointsHandler.Points);
        //}
        //else
        //PointsHandler.BuyPPC(10, 10);
        //Debug.Log();
    }

}
