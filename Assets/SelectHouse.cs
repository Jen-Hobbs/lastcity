using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *select house
 **/
public class SelectHouse : MonoBehaviour
{
    // Start is called before the first frame update
    public void createhouse(GameObject house)
    {
        Debug.Log("it clicked");
        Instantiate<GameObject>(house, transform.position, Quaternion.identity);
    }
    
}
