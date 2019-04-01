using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerMovement : MonoBehaviour
{
    [SerializeField] private GridLayout world;
    public map map;
    [SerializeField] private GameObject worker;
    private Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mousePos.x / 2) * 2, Mathf.Round(mousePos.y / 2) * 2);
    }

    private void OnMouseDown()
    {
        Vector3 position = world.WorldToCell(transform.position);
        if (!map.people.Contains(position))
        {
            map.people.Add(position);
            worker = (GameObject)Instantiate(worker, transform.position, Quaternion.identity);
            worker.GetComponent<CreateWorker>().map = map;
            Destroy(this.gameObject);
        }
    }
}
