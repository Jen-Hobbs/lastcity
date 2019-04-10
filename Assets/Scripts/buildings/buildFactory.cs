using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildFactory : buildBuilding
{
    /// <summary>
    /// sets cost to buld factory
    /// author : Jennifer Hobbs
    /// </summary>
    public buildFactory() : base()
    {
        stoneCost = 50;
    }
    /// <summary>
    /// takes costs away from player
    /// </summary>
    public override void build()
    {
        Player.stone -= stoneCost;
    }

    public override void countTurn()
    {
        if (counter == buildturns)
        {
            building = (GameObject)Instantiate(building, transform.position, Quaternion.identity);
            Player.yieldMultiplier += 0.1;
            Destroy(this.gameObject);
        }
        counter++;

    }
}
