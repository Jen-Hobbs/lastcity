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

        woodCost = 50;

    }
    // Start is called before the first frame update
    public override void build()
    {
        Player.wood -= woodCost;
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
