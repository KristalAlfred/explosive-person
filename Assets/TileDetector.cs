using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileDetector : MonoBehaviour
{
    private Tilemap tilemap;
    private Vector3Int currentTilePosCell;
    public Vector3 currentTilePos;

    void Start()
    {
        tilemap = FindObjectOfType<Tilemap>();
        currentTilePosCell = tilemap.WorldToCell(transform.position);
    }

    void Update()
    {
        Vector3Int pos = tilemap.WorldToCell(transform.position);
        if (pos != currentTilePos)
        {
            Color brown = new Color(74, 60, 44);
            tilemap.SetColor(currentTilePosCell, brown);
            tilemap.SetTileFlags(pos, TileFlags.None);
            tilemap.SetColor(pos, Color.cyan);
            currentTilePosCell = pos;
            currentTilePos = tilemap.CellToWorld(currentTilePosCell);
        }
        
    }
}
