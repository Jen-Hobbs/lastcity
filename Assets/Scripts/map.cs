using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//static class within grid that stores all objects
public class map : MonoBehaviour
{
    public GridLayout world;
    private GameObject[] person;
    private GameObject[] tree;
    private GameObject[] rock;
    private GameObject[] house;
    private Dictionary<Vector3, Material> materials;
    private Dictionary<Vector3, string> buildings;
    private HashSet<Vector3> people;

    
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
        materials = new Dictionary<Vector3, Material>();
        for (int i = 0; i < tree.Length; i++)
        {
            Material r = new tree(i);
            materials[world.WorldToCell(tree[i].transform.position)] = r;
        }

        for (int i = 0; i < rock.Length; i++)
        {
            Material r = new Rock(i);
            materials[world.WorldToCell(rock[i].transform.position)] = r;
        }

        for (int i = 0; i < house.Length; i++)
        {
            buildings[world.WorldToCell(house[i].transform.position)] = "house";
        }

        for (int i = 0; i < people.Count; i++)
        {
            people.Add(world.WorldToCell(house[i].transform.position));
        }
        resourceslist.setResources(materials);
        personlist.setPeople(people);
        buildinglist.setBuildings(buildings);
        //Debug.Log(world.WorldToCell(check.transform.position));
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);
            if (materials.ContainsKey(world.WorldToCell(worldPoint)))
            {
                Debug.Log(materials[world.WorldToCell(worldPoint)].getResource());
                materials[world.WorldToCell(worldPoint)].farm();
                if (materials[world.WorldToCell(worldPoint)].getResource() == 0)
                {
                    if (materials[world.WorldToCell(worldPoint)].type() == "tree")
                    {
                        Destroy(tree[materials[world.WorldToCell(worldPoint)].getPosition()]);
                        resourceslist.deleteResource(world.WorldToCell(worldPoint));
                    }
                    else if (materials[world.WorldToCell(worldPoint)].type() == "rock")
                    {
                        Destroy(rock[materials[world.WorldToCell(worldPoint)].getPosition()]);
                        resourceslist.deleteResource(world.WorldToCell(worldPoint));
                    }
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
