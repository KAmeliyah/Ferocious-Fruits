using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePurchase : MonoBehaviour
{
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
}
