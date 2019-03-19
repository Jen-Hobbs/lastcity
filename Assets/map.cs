using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//static class within grid that stores all objects
public class map : MonoBehaviour
{
    public GridLayout world;
    public GameObject check;
    private GameObject[] checks;
    // Start is called before the first frame update
    void Start()
    {
        checks = GameObject.FindGameObjectsWithTag("house");
        check = GameObject.FindWithTag("house");
        if(checks.Length == 0)
        {
            Debug.Log("error");
        }
        Debug.Log(checks.Length);
        Debug.Log(world.WorldToCell(checks[0].transform.position));
        //Debug.Log(world.WorldToCell(check.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);
            Debug.Log(world.WorldToCell(check.transform.position));
            Debug.Log(world.WorldToCell(worldPoint));
        }
    }
}
