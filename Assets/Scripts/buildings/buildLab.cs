using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
/// <summary>
/// Builds Lab object based on cost
/// Author: Jennifer Hobbs
/// </summary>
public class buildLab : buildBuilding
{
    /// <summary>
    /// sets cost of food wood and stone
    /// </summary>
    public buildLab() : base()
    {
        woodCost = 200;
        stoneCost = 200;
    }
    /// <summary>
    /// deletes cost of building resource
    /// </summary>
    public override void build()
    {
        Player.wood -= woodCost;
        Player.stone -= stoneCost;
    }

    public override void countTurn()
    {
        if (counter == buildturns)
        {
            building = (GameObject)Instantiate(building, transform.position, Quaternion.identity);
            SceneManager.LoadScene("WinScreen");
            Destroy(this.gameObject);
        }
        counter++;

    }
}
