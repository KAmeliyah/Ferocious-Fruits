using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopMenu", menuName = "SciptableObjects/New Shop Item",order = 1)]
public class ShopItemSO : ScriptableObject
{
    public string projectName;
    public int cost;
}
