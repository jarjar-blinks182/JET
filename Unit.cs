using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit
{
    #region vars
    private string firstName;
    private string title;
    private int exp = 0;
    private int expToNextLevel = 100; //thinking of using D&D Level up system, just setting it to something other than 1 for clarity
    private int level = 1;
    private float health = 60f;
    #endregion

    #region Properties
    public string FirstName { get => firstName; set => firstName = value; }
    public string Title { get => title; set => title = value; }
    public int Exp { get => exp; set => exp = value; }
    public int ExpToNextLevel { get => expToNextLevel; set => expToNextLevel = value; }
    public int Level { get => level; set => level = value; }
    public float Health { get => health; set => health = value; }
    #endregion

    #region const
    public Unit(string firstName, string title)
    {
        this.firstName = firstName;
        this.title = title;
    }
    #endregion
}
