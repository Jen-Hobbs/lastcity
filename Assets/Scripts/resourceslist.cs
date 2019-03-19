using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
