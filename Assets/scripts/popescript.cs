using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popescript : MonoBehaviour
{

    void OnMouseDown()
    {
        //Debug.Log("Papeiz");
        Debug.Log(name);
        switch (name)
        {
            case "pope":
                PointsHandler.Points += PointsHandler.PointsPerClick;
                //Debug.Log(PointsHandler.Points);
                break;
            case "kremowka":
                PointsHandler.BuyPPS(5, 1);
                break;
            case "sculpture":
                PointsHandler.BuyPPS(8, 2);
                break;
            case "mary":
                PointsHandler.BuyPPS(11, 3);
                break;
            case "spinach":
                PointsHandler.BuyPPS(14, 4);
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
