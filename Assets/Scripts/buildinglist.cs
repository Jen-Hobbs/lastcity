using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class buildinglist
{
    
    private static Dictionary<Vector3, string> building;

    public static void setBuildings(Dictionary<Vector3, string> r)
    {
        building = r;
    }

    public static void addBuilding(Vector3 position, string type)
    {
        building[position] = type;
    }

    public static void deleteBuilding(Vector3 position)
    {
        building.Remove(position);
    }

    public static string getBuilding(Vector3 position)
    {
        return building[position];
    }
}
