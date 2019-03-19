using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//static class within grid that stores all objects
public class map : MonoBehaviour
{
    public GridLayout world;
    public GameObject check;
    private GameObject[] person;
    private GameObject[] tree;
    private GameObject[] rock;
    private GameObject[] house;
    private Dictionary<Vector3, Material> objects;

    
    // Start is called before the first frame update
    void Start()
    {
        //checks = GameObject.FindGameObjectsWithTag("tree");
        house = GameObject.FindGameObjectsWithTag("house");
        //check = GameObject.FindWithTag("house");
        tree = GameObject.FindGameObjectsWithTag("tree");
        rock = GameObject.FindGameObjectsWithTag("rock");
        person = GameObject.FindGameObjectsWithTag("person");
        if(house.Length == 0)
        {
            Debug.Log("no houses");
        }

        if (tree.Length == 0)
        {
            Debug.Log("no trees");
        }

        if (rock.Length == 0)
        {
            Debug.Log("no rocks");
        }

        if (person.Length == 0)
        {
            Debug.Log("no people");
        }
        objects = new Dictionary<Vector3, Material>();
        for (int i = 0; i < tree.Length; i++)
        {
            Material r = new Material(i);
            objects[world.WorldToCell(tree[i].transform.position)] = r;
        }

        for (int i = 0; i < rock.Length; i++)
        {
            Material r = new Material(i);
            objects[world.WorldToCell(rock[i].transform.position)] = r;
        }
/*
        for (int i = 0; i < house.Length; i++)
        {
            objects[world.WorldToCell(house[i].transform.position)] = "house";
        }*/
        resourceslist.setResources(objects);
        //Debug.Log(world.WorldToCell(check.transform.position));
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);
            if (objects.ContainsKey(world.WorldToCell(worldPoint)))
            {
                Debug.Log(objects[world.WorldToCell(worldPoint)].getResource());
                objects[world.WorldToCell(worldPoint)].farm();
                if (objects[world.WorldToCell(worldPoint)].getResource() == 0)
                {
                    
                    Destroy(tree[objects[world.WorldToCell(worldPoint)].getPosition()]);
                    objects.Remove(world.WorldToCell(worldPoint));
                }
            }
            
            
            /*
            if (objects.ContainsKey(world.WorldToCell(worldPoint)))
            {
                Debug.Log("check");
                Debug.Log(objects[world.WorldToCell(worldPoint)]);
            }
            */
            //Debug.Log(world.WorldToCell(check.transform.position));
            //Debug.Log(world.WorldToCell(worldPoint));
            
            //Destroy(checks[0]);
        }
    }
}
