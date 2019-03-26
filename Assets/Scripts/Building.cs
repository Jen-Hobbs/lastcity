using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *building created
 **/
public class Building : MonoBehaviour
{

    private int resource = 20;
    private int resourceType;

    public Building()
    {
    }
    public virtual int build()
    {
        if (resource - 10 <= 0)
        {
            resource = 0;
            return resource;
        }
        resource -= 10;
        return 10;
    }
    public GameObject GetGameObject()
    {
        return gameObject;
    }


}
