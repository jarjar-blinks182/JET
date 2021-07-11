using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    public MasterArmyList masterArmyList;
    void Start()
    {
        Debug.Log("Number of Armies: " + masterArmyList.Armies.Count);
        if(masterArmyList.Armies.Count > 0)
        {
            for(int i = 0; i < masterArmyList.Armies.Count; i++)
            {
                Debug.Log($"Army {i+1}: {masterArmyList.Armies[i]}");
                StarterArmy army = masterArmyList.Armies[i];
                Debug.Log("The Army: "+army);
                Debug.Log("Army Name: "+army.name);
                Debug.Log("Army Length: "+army.Units.Count);
                for (int j = 0; j < army.Units.Count; j++)
                {
                    Debug.Log("Unit " + (j + 1) + " " + army.Units[j].FirstName + army.Units[j].Title);
                }
            }
        }
    }

}
