using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayBattle : MonoBehaviour
{
    [SerializeField] //makes it show up in inspector window even if private
    private TMP_Text Army; //text mesh pro text object
    [SerializeField] 
    private TMP_Text player1Name;
    [SerializeField]
    private TMP_Text player1Title;
    [SerializeField]
    private TMP_Text player1Level;
    [SerializeField]
    private TMP_Text player2Name;
    [SerializeField]
    private TMP_Text player2Title;
    [SerializeField]
    private TMP_Text player2Level;
    public MasterArmyList masterArmyList;

    void Awake()
    {
        if (masterArmyList.Armies.Count > 0)
        {
            StarterArmy army = masterArmyList.Armies[0];
            Army.text = army.name;
            Debug.Log("Army Length: " + army.Units.Count);
            player1Name.text = army.Units[0].FirstName;
            player1Title.text = army.Units[0].Title;
            player1Level.text = army.Units[0].Level.ToString();
            player2Name.text = army.Units[1].FirstName;
            player2Title.text = army.Units[1].Title;
            player2Level.text = army.Units[1].Level.ToString();
        }
    }
}
