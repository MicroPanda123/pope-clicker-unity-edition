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
                PointsHandler.BuyPPS(5, 0.01f);
                break;
            case "sculpture":
                PointsHandler.BuyPPS(8, 0.1f);
                break;
            case "mary":
                PointsHandler.BuyPPS(11, 0.5f);
                break;
            case "spinach":
                PointsHandler.BuyPPS(14, 1f);
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
