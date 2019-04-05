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
    }
    public Building()
    {
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }
    public virtual void gather() { }

}
