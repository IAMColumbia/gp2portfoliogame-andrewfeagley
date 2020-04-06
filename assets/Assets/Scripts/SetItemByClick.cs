using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class SetItemByClick : MonoBehaviour
{
    [SerializeField]
    TileBase tileBase;
    [SerializeField]
    GameObject objectToPlace;
    [SerializeField]
    Sprite objectImage;

    Button button;

    private void Awake()
    {
        button = this.gameObject.GetComponent<Button>();
        this.button.image.sprite = objectImage;
    }

    public void SetTile()
    {
        SelectedItem.Instance.item = objectToPlace;
        SelectedItem.Instance.tileBase = tileBase;
    }
}
