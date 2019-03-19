using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Material
{
    
    private int resource = 20;
    private int resourceType;
    private int position;

    public Material(int pos)
    {
        position = pos;
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
