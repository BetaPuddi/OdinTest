using UnityEngine;
using System.Collections;

public abstract class InventoryItem : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public int sortingPosition;
}