using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *resources information parent of different resources
 **/
public abstract class Material
{
    
    private int resource = 50;
    private int resourceType;
    private int position;
    private GameObject gameObject;

    public Material(int pos, GameObject g)
    {
        position = pos;
        gameObject = g;
    }
    public int farm()
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
    public int getPosition()
    {
        return position;
    }

    public abstract string type();

    public int getResource()
    {
        return resource;
    }
}
