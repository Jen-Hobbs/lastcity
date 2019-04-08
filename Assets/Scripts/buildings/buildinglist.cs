using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  Author: Jennifer Hobbs
/// list of buildings
/// keeps track of the buildings built
/// </summary>
public static class buildinglist
{
    
    private static Dictionary<Vector3, GameObject> building;

    /// <summary>
    /// adds all buildings to building list
    /// </summary>
    /// <param name="r">dictionary of buildings</param>
    public static void setBuildings(Dictionary<Vector3, GameObject> r)
    {
        building = r;
    }
/// <summary>
/// sets a singl building to a the building list
/// </summary>
/// <param name="position">key of building position</param>
/// <param name="type">building game object</param>
    public static void addBuilding(Vector3 position, GameObject type)
    {
        building[position] = type;
    }
/// <summary>
/// gets all buildings in the building list
/// </summary>
/// <returns></returns>
    public static Dictionary<Vector3, GameObject> getAllBuildings()
    {
        return building;
    }
/// <summary>
/// checks if there is a building at the position
/// </summary>
/// <param name="position">position to check</param>
/// <returns>true if there is a building at the position</returns>
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
