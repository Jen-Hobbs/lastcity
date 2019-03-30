using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *building created
 **/
public abstract class Building : MonoBehaviour
{
    internal int foodCost;
    internal int woodCost;
    internal int stoneCost;

    void Start()
    {
        build();
    }
    public Building()
    {
    }
    public abstract void build();
    public GameObject GetGameObject()
    {
        return gameObject;
    }
    public virtual void gather() { }
    public bool buildable()
    {
        if (foodCost > Player.food || woodCost > Player.wood || stoneCost > Player.stone)
        {
            return false;
        }
        return true;
    }
}
