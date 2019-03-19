using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class personlist {
    
    private static HashSet<Vector3> person;

    public static void setPeople(HashSet<Vector3> r)
    {
        person = r;
    }

    public static void addPerson(Vector3 position)
    {
        person.Add(position);
    }

    public static void deletePerson(Vector3 position)
    {
        person.Remove(position);
    }

}
