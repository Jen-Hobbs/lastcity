using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *list of buildings
 * obsolete
 **/
public static class buildinglist
{
    
    private static Dictionary<Vector3, GameObject> building;

    public static void setBuildings(Dictionary<Vector3, GameObject> r)
    {
        building = r;
    }

    public static void addBuilding(Vector3 position, GameObject type)
    {
        building[position] = type;
    }

    public static void deleteBuilding(Vector3 position)
    {
        building.Remove(position);
    }
/*
    public static GameObject getBuilding(Vector3 position)
    {
        return building[position];
    }
    */
    public static Boolean containsBuilding(Vector3 position)
    {
        Debug.Log(position);
        if (building.ContainsKey(position))
        {
            Debug.Log("position contains building");
            return true;
        }
        Debug.Log("position doesnt contain building");
        return false;
    }
}
