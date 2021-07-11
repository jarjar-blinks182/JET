using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class createPlayer : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField Input_armyName;
    [SerializeField]
    private TMP_InputField Input_unit1Name;
    [SerializeField]
    private TMP_InputField Input_unit1Title;
    [SerializeField]
    private TMP_InputField Input_unit2Name;
    [SerializeField]
    private TMP_InputField Input_unit2Title;
    private string armyName;
    private string unit1Name;
    private string unit1Title;
    private string unit2Name;
    private string unit2Title;
    public StarterArmy tempArmy;
    public MasterArmyList masterArmyList;

    public void SetName()
    {
        armyName = Input_armyName.text;
        tempArmy = ScriptableObject.CreateInstance<StarterArmy>();
        tempArmy.name = armyName;
        //Debug.Log("plain: " + tempArmy);
        //Debug.Log("name: " + tempArmy.name);
        unit1Name = Input_unit1Name.text;
        unit1Title = Input_unit1Title.text;
        unit2Name = Input_unit2Name.text;
        unit2Title = Input_unit2Title.text;
        Unit player1 = new Unit(unit1Name, unit1Title);
        Unit player2 = new Unit(unit2Name, unit2Title);
        //Debug.Log(player1.Level);
        tempArmy.AddUnit(player1);
        tempArmy.AddUnit(player2);
        //Debug.Log("The Player 1 Name: "+player2.FirstName);
        //Debug.Log("Number of Units in army: "+ tempArmy.Units.Count);
        masterArmyList.Add(tempArmy);
        UnityEngine.SceneManagement.SceneManager.LoadScene("OpenWorld");
    }
}
