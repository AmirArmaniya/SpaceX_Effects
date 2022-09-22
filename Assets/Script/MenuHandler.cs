using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] Button btn_Play;
    [SerializeField] Button btn_Mission;
    [SerializeField] Button btn_Upgrade;
    [SerializeField] Button btn_SpaceShips;
    [SerializeField] Button btn_Shop;

    [SerializeField] GameObject Panel_Play;
    [SerializeField] GameObject Panel_Mission;
    [SerializeField] GameObject Panel_upgrade;
    [SerializeField] GameObject Panel_SpaceShip;
    [SerializeField] GameObject Panel_Shop;


    void Start()
    {
        enable_Panel_Play(btn_Play);

    }

    public void enable_Panel_Play(Button button)
    {
        Panel_Play.SetActive(true);
        button.transform.localScale = new Vector3(1.1f, 1.1f, 1);

        btn_SpaceShips.transform.localScale = new Vector3(1, 1, 1);
        btn_Mission.transform.localScale = new Vector3(1, 1, 1);
        btn_Shop.transform.localScale = new Vector3(1, 1, 1);
        btn_Upgrade.transform.localScale = new Vector3(1, 1, 1);

        Panel_Mission.SetActive(false);
        Panel_Shop.SetActive(false);
        Panel_SpaceShip.SetActive(false);
        Panel_upgrade.SetActive(false);
    }

    public void enable_Panel_Mission(Button button)
    {
        Panel_Mission.SetActive(true);
        button.transform.localScale = new Vector3(1.1f, 1.1f, 1);

        btn_SpaceShips.transform.localScale = new Vector3(1, 1, 1);
        btn_Shop.transform.localScale = new Vector3(1, 1, 1);
        btn_Play.transform.localScale = new Vector3(1, 1, 1);
        btn_Upgrade.transform.localScale = new Vector3(1, 1, 1);

        Panel_Play.SetActive(false);
        Panel_Shop.SetActive(false);
        Panel_SpaceShip.SetActive(false);
        Panel_upgrade.SetActive(false);
    }

    public void enable_Panel_Shop(Button button)
    {
        Panel_Shop.SetActive(true);
        button.transform.localScale = new Vector3(1.1f, 1.1f, 1);

        btn_SpaceShips.transform.localScale = new Vector3(1, 1, 1);
        btn_Mission.transform.localScale = new Vector3(1, 1, 1);
        btn_Play.transform.localScale = new Vector3(1, 1, 1);
        btn_Upgrade.transform.localScale = new Vector3(1, 1, 1);

        Panel_Play.SetActive(false);
        Panel_Mission.SetActive(false);
        Panel_SpaceShip.SetActive(false);
        Panel_upgrade.SetActive(false);
    }

    public void enable_Panel_SpaceShip(Button button)
    {
        Panel_SpaceShip.SetActive(true);
        button.transform.localScale = new Vector3(1.1f, 1.1f, 1);

        btn_Mission.transform.localScale = new Vector3(1, 1, 1);
        btn_Shop.transform.localScale = new Vector3(1, 1, 1);
        btn_Play.transform.localScale = new Vector3(1, 1, 1);
        btn_Upgrade.transform.localScale = new Vector3(1, 1, 1);

        Panel_Play.SetActive(false);
        Panel_Mission.SetActive(false);
        Panel_Shop.SetActive(false);
        Panel_upgrade.SetActive(false);
    }

    public void enable_Panel_Upgrade(Button button)
    {
        Panel_upgrade.SetActive(true);
        button.transform.localScale = new Vector3(1.1f, 1.1f, 1);

        btn_Mission.transform.localScale = new Vector3(1, 1, 1);
        btn_Shop.transform.localScale = new Vector3(1, 1, 1);
        btn_Play.transform.localScale = new Vector3(1, 1, 1);
        btn_SpaceShips.transform.localScale = new Vector3(1, 1, 1);

        Panel_Play.SetActive(false);
        Panel_Mission.SetActive(false);
        Panel_Shop.SetActive(false);
        Panel_SpaceShip.SetActive(false);
    }
}
