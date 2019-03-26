using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *select house
 **/
public class selectHouse : MonoBehaviour
{
    [SerializeField]
    private Transform house;
    public GameObject house2;
    Vector2 spawn;
    bool houseSpawned = true;
    
    bool objectspawned = false;
    // Start is called before the first frame update
    public void selecthouse()
    {
        Instantiate(house, transform.position, Quaternion.identity);
    }
    
}
