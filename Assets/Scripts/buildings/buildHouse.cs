using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// buildi building parent class
/// Author Jennifer Hobbs
/// </summary>
public class buildHouse : buildBuilding
{
    [SerializeField] internal GameObject worker;

    public buildHouse() : base()
    {
        foodCost = 10;
        woodCost = 10;
        stoneCost = 10;
    }
    // Start is called before the first frame update
    public override void build()
    {
        Player.food -= foodCost;
        Player.wood -= woodCost;
        Player.stone -= stoneCost;
    }


    public override void countTurn()
    {
        if (counter == buildturns)
        {
            building = (GameObject)Instantiate(building, transform.position, Quaternion.identity);
            worker = (GameObject)Instantiate(worker, transform.position, Quaternion.identity);
            Player.population += 5;
            Destroy(this.gameObject);
        }
        counter++;

    }
}
