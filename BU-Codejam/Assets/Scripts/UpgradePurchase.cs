using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradePurchase : MonoBehaviour
{
    public ShopItemSO[] shopItemsSO;
    public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] purchaseButtons;

    public TMP_Text budgetText;
    public universityManager BU;
    public zoomClick building; //script
    string bname;


    public void AwakenShop(zoomClick activator)
    {
        building = activator; //building = building
        bname = building.name; //bject name

        budgetText.text = "Budget: £" + BU.budget.ToString();

        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            shopPanelsGO[i].SetActive(true);
        }
        LoadPanels();
        CheckPurchaseable();
    }

    public void CheckPurchaseable()
    {
        for(int i = 0;i < shopItemsSO.Length;i++) 
        {
            if (BU.budget >= shopItemsSO[i].cost)
            {
                purchaseButtons[i].interactable = true;
            }
            else
            {
                purchaseButtons[i].interactable = false;
            }
        }
    }

    public void PurchaseProject(int btnNo)
    {
        if (BU.budget >= shopItemsSO[btnNo].cost)
        {

            BU.budget -= shopItemsSO[btnNo].cost;
            budgetText.text = "Budget: £" + BU.budget.ToString();

            CheckPurchaseable();
        }
    }


    public void LoadPanels()
    {
        for(int i = 0; i < shopItemsSO.Length; i++) 
        {
            if (shopItemsSO[i].name == "Change_Operate_Hours" || shopItemsSO[i].name == "Air_source_heat_pump")
            {
                if ((building.name == "PGB" && shopItemsSO[i].name == "Change_Operate_Hours") || (building.name == "Dorset" && shopItemsSO[i].name == "Air_source_heat_pump"))
                {
                    shopPanels[i].projectName.text = shopItemsSO[i].projectName;
                    shopPanels[i].costText.text = shopItemsSO[i].cost.ToString();
                }
                else
                {
                    shopPanelsGO[i].SetActive(false);
                }
            }
            else
            {
                shopPanels[i].projectName.text = shopItemsSO[i].projectName;
                shopPanels[i].costText.text = shopItemsSO[i].cost.ToString();
            }
        }
    }
}







/*
    private int EV_ChargerInstall = 750; //per charger
    
    private int LED_Light_Bulb_Replacement = 5000; //per building
    private int LED_Light_Fixture_Replacement = 85000; //per building
    //these two can only be one per building (not both)

    private int Lighting_Controls = 8000;
    private int Computer_Monitor_Upgrades = 200; //per monitor

    private int Monitor_Per_Building;
    //we can set that per building but just putting it here for now

    private int Pump_Upgrades = 40000; //per building
    private int IT_Server_Upgrades = 15000; //per building
    private int Boiler_Upgrades = 15000; //per building
    private int Insulate_Walls = 40000; //per building
    private int Insulate_Roof = 75000; //per building
    private int Insulate_Pipe_Ducts = 2000; //per building
    private int Air_source_heat_pump = 175000; //per building
    private int Heating_Vent_Cooling_Controls = 35000; //per building
    private int Glazing_Windows_Doors = 250000; //per building

    private int University_Wide_Campaign = 500; //each time

    //stuff that would reduce student satisfaction but not cost anything
    private int Heating_Lower;
    private int Change_Operate_Hours;
    private int Lights_off_Night;

    */