using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

/// <summary>
/// This is a singleton class that has its item and tilebase variables set by buttons with the setitembyclick script
/// It is called by the dragand drop script to set the tile of the tilemap that the player clicks on.
/// </summary>
public class SelectedItem : MonoBehaviour
{
    public static SelectedItem Instance { get; set; }

    //Get the item that the player just clicked on in the ui and sets it to the currently held item in the instance
    public GameObject item;
    public TileBase tileBase;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }
}
