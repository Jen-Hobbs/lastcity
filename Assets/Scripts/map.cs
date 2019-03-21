using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Tilemaps;

//static class within grid that stores all objects
public class map : MonoBehaviour
{
    public GridLayout world;
    public GameObject[] person;
    public GameObject[] tree;
    public GameObject[] rock;
    public GameObject[] house;
    public Dictionary<Vector3, Material> materials;
    public Dictionary<Vector3, Building> buildings;
    public HashSet<Vector3> people;
    public GameObject trials;

    private Vector2 mousePos;
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
            Material r = new tree(i, tree[i]);
            materials[world.WorldToCell(tree[i].transform.position)] = r;
        }

        for (int i = 0; i < rock.Length; i++)
        {
            Material r = new Rock(i, rock[i]);
            materials[world.WorldToCell(rock[i].transform.position)] = r;
        }
        Debug.Log("house" + house.Length);
        buildings = new Dictionary<Vector3, Building>();
        for (int i = 0; i < house.Length; i++)
        {
            Debug.Log(i);
            Building b = new Building(i, house[i]);
            //buildings[world.WorldToCell(house[i].transform.position)] = b;
        }

        people = new HashSet<Vector3>();
        for (int i = 0; i < person.Length; i++)
        {
            people.Add(world.WorldToCell(person[i].transform.position));
        }
        //resourceslist.setResources(materials);
        //personlist.setPeople(people);
        //buildinglist.setBuildings(buildings);
        //Debug.Log(world.WorldToCell(check.transform.position));
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            //mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // transform.position = new Vector2(Mathf.Round(mousePos.x/2)*2, Mathf.Round(mousePos.y/2)*2);

            
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);
            Vector3 cellPoint = world.WorldToCell(worldPoint);
            if (materials.ContainsKey(cellPoint))
            {
                Debug.Log(materials[cellPoint].getResource());
                materials[cellPoint].farm();
                if (materials[cellPoint].getResource() == 0)
                {
                    if (materials[cellPoint].type() == "tree")
                    {
                        Destroy(materials[cellPoint].GetGameObject());
                        //Debug.Log(resourceslist.getResource(world.WorldToCell(worldPoint)));
                        materials.Remove((cellPoint));
                    }
                    else if (materials[cellPoint].type() == "rock")
                    {
                        Destroy(materials[cellPoint].GetGameObject());
                        materials.Remove(cellPoint);
                    }
                }
                
            }
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            //mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //transform.position = new Vector2(Mathf.Round(mousePos.x/2)*2, Mathf.Round(mousePos.y/2)*2);
                Debug.Log("check");
                if (hit != null && hit.collider == null)
                {
                    Debug.Log("cell" + cellPoint);
                    Debug.Log("mouse" + worldPoint);
                    Debug.Log("check");
                    GameObject tile = Instantiate(trials, new Vector3((Mathf.Round((worldPoint.x)/2)*2), (Mathf.Round((worldPoint.y/2))*2)), Quaternion.identity);
                    Building r = new Building(buildings.Count, tile);
                    buildings.Add(cellPoint, r);
                    //Debug.Log(GameObject.FindWithTag("building"));
                    //GameObject tile = Instantiate(GameObject.FindWithTag("building"), world.WorldToCell(worldPoint), Quaternion.identity);
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
