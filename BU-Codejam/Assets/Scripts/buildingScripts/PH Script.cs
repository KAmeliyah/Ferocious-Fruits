using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHScript : MonoBehaviour
{
    public List<ScriptableObject> purchasedUpgrades;

    public void storePurchases(ScriptableObject _upgrade)
    {
        purchasedUpgrades.Add(_upgrade);
    }
}
