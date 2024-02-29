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
    public zoomClick zoomScript; //script

    public buildingScript buildingStoredPurchase;

    public Emissions emissionsScript;
    public Happiness happinessScript;

    public GameObject building;

    
    string bname;


    public void AwakenShop(zoomClick activator)
    {
        zoomScript = activator; //building = building
        bname = zoomScript.name; //bject name

        building = GameObject.Find($"/Buildings/{bname}");
        buildingStoredPurchase = building.GetComponent<buildingScript>();

        budgetText.text = "£" + BU.budget.ToString();

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
            budgetText.text = "£" + BU.budget.ToString();

           
            buildingStoredPurchase.storePurchases(shopItemsSO[btnNo]);
            
            LoadPanels();
            CheckPurchaseable();
            emissionsScript.updateWithPurchase(shopItemsSO[btnNo].emissionDecrease);
            happinessScript.change(-10);
        }
    }

    public void LoadPanels()
    {
        for(int i = 0; i < shopItemsSO.Length; i++) 
        {
            if (buildingStoredPurchase.purchasedUpgrades.Contains(shopItemsSO[i]))
            {
                shopPanelsGO[i].SetActive(false);
            }
            else
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
}



