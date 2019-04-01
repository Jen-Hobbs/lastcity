﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWorker : MonoBehaviour

{
    [SerializeField] private GameObject worker;
    [SerializeField] private GridLayout world;
    public map map;

    private void OnMouseDown()
    {
        Vector3 position = world.WorldToCell(transform.position);
        map.people.Remove(position);
        Destroy(gameObject);
        GameObject movingWorker = Instantiate<GameObject>(worker, transform.position, Quaternion.identity);
        movingWorker.GetComponent<WorkerMovement>().map = map;
    }
}
