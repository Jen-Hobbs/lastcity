using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Grid : MonoBehaviour
{
    /// <summary>
    /// obsolete
    /// </summary>
    public Tilemap tilemap;
    public GridLayout world;
    public TileBase tile;
    TileBase[] allTiles;

    public GameObject bluehouse;
    // Start is called before the first frame update
    void Start()
    {
        /*
        BoundsInt bounds = tilemap.cellBounds;
        allTiles = tilemap.GetTilesBlock(bounds);

        for (int x = 0; x < bounds.size.x; x++)
        {
            for (int y = 0; y < bounds.size.y; y++)
            {
                tile = allTiles[x + y * bounds.size.x];
                if (tile != null)
                {
                    Debug.Log("x:" + x + " y:" + y + " tile:" + tile.name);
                }
                else
                {
                    Debug.Log("x:" + x + " y:" + y + " tile: (null)");
                }
            }
        }
        */
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
           
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);
            Debug.Log(world.WorldToCell(worldPoint));
            //GameObject tile = Instantiate(bluehouse, worldPoint, Quaternion.identity);

            //tilemap.SetTile(new Vector3Int((int)worldPoint.x, (int)worldPoint.y, (int)worldPoint.z), null);
            
            var tilePos = world.WorldToCell(worldPoint);
            print("test" + tilePos);
            tilemap.SetTile(new Vector3Int((int)worldPoint.x, (int)worldPoint.y, (int)worldPoint.z), tile);
            /*
            Vector3 pos = Camera.main.ScreenToWorldPoint((Vector3)Input.mousePosition);
            Vector3Int position = new Vector3Int((int)pos.x, (int)pos.y, (int)pos.z);

            tilemap.GetTile(position);
            if (tilemap.GetTile(position) != null)
            {
                Debug.Log("contains tile" + position);
            }
            else
            {
                Debug.Log(position);
            }
            
            //Debug.Log(Camera.main.ScreenToWorldPoint((Vector3)Input.mousePosition));
            
            */
        }
    }
}
