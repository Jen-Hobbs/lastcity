using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *obsolete
 **/
public static class resourceslist
{
    private static Dictionary<Vector3, Material> resources;

    public static void setResources(Dictionary<Vector3, Material> r)
    {
        resources = r;
    }


    public static void deleteResource(Vector3 position)
    {
        resources.Remove(position);
    }

    public static Material getResource(Vector3 position)
    {
        return resources[position];
    }

    public static Boolean containsResource(Vector3 position)
    {
        Debug.Log(position);
        if (resources.ContainsKey(position))
        {
            Debug.Log("position contains building");
            return true;
        }
        Debug.Log("position doesnt contain building");
        return false;
    }
}
