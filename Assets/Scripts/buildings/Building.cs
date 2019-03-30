using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *building created
 **/
public abstract class Building : MonoBehaviour
{
    

    private int resourceType;
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
}
