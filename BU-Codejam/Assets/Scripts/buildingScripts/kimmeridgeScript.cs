using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kimmeridgeScript : MonoBehaviour
{
    public List<ScriptableObject> purchasedUpgrades;
    // Start is called before the first frame update

    public void storePurchases(ScriptableObject _upgrade)
    {
        purchasedUpgrades.Add(_upgrade);
    }
}
