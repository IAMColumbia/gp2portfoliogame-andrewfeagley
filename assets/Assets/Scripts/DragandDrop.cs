using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class DragandDrop : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase swappedTile;

    // Update is called once per frame
    void Update()
    {
        //swappedTile = SelectedItem.instance.tileBase;
        if(Input.GetMouseButtonDown(0))
        {
            ChangeTile();
        }
    }

    void ChangeTile()
    {
        Vector3 pos = Input.mousePosition;
        Vector3Int tilePos = tilemap.WorldToCell(Camera.main.ScreenToWorldPoint(pos));

        //make sure there isn't a tile where you clicked already
        if(!tilemap.HasTile(tilePos))
        {
            tilemap.SetTile(tilePos, SelectedItem.Instance.tileBase);
            Instantiate(SelectedItem.Instance.item, tilePos, Quaternion.identity);
        }
    }
}
