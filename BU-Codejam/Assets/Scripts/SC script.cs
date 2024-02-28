using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCscript : MonoBehaviour
{
    public List<ScriptableObject> purchasedUpgrades;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void storePurchased(ScriptableObject _upgrade)
    {
        purchasedUpgrades.Add(_upgrade);
    }
}
