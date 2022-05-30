using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileDetector : MonoBehaviour
{
    private Tilemap tilemap;
    private Vector3Int currentTilePos;
    // Start is called before the first frame update
    void Start()
    {
        tilemap = GameObject.FindObjectOfType<Tilemap>();
        currentTilePos = tilemap.WorldToCell(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3Int pos = tilemap.WorldToCell(transform.position);
        if (pos != currentTilePos)
        {
            Color brown = new Color(74, 60, 44);
            tilemap.SetColor(currentTilePos, brown);
            tilemap.SetTileFlags(pos, TileFlags.None);
            tilemap.SetColor(pos, Color.cyan);
            currentTilePos = pos;
        }
        
    }
}
