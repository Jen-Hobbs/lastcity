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

    public Building()
    {
    }
    public abstract int build();
    public GameObject GetGameObject()
    {
        return gameObject;
    }


}
