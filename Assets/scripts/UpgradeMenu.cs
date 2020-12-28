using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMenu : MonoBehaviour
{
    public GameObject Upgrades;
    public GameObject Upgrades_Outside;
    public GameObject pope;
    public void ToggleShop()
    {
        Upgrades.SetActive(!Upgrades.activeSelf);
        Upgrades_Outside.SetActive(!Upgrades_Outside.activeSelf);
        pope.SetActive(!pope.activeSelf);
    }
}
