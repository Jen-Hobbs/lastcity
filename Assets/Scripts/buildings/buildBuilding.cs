using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Author Jennifer Hobbs
/// builds building by counting how many turns it has been then builds the building
/// once built the buildbuilding object is deleted
/// </summary>
public abstract class buildBuilding : MonoBehaviour
{

    [SerializeField]internal GameObject building;
    [SerializeField] internal int buildturns;
    internal int counter;
    internal int woodCost;
    internal int stoneCost;

    /// <summary>
    /// start buy calling build method and instantiate counter
    /// </summary>
    void Start()
    {
        build();
        counter = 0;
    }
    /// <summary>
    ///
    /// takes costs of building building away from player
    /// </summary>
    public abstract void build();
   /// <summary>
   /// checks if building is buildable based on play food wook and stone
   /// </summary>
   /// <returns>true if buildable</returns>
    public bool buildable()
    {
        if (woodCost > Player.wood || stoneCost > Player.stone)
        {
            return false;
        }
        return true;
    }
    /// <summary>
    /// turn counter until built
    /// </summary>
    public virtual void countTurn()
    {
        if (counter == buildturns)
        {
            building = (GameObject) Instantiate(building, transform.position, Quaternion.identity);
            
            Destroy(this.gameObject);
        }
        counter++;
        
    }
}
