using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Items/New item")]
public class ItemData : ScriptableObject
{
    public string name;
    public string description;
    public Sprite visual;
    public GameObject prefab;

    public ItemType itemType;
    public EquipementType equipementType;
}


public enum ItemType
{
    Ressource,
    Equipement,
    Consumable
}

public enum EquipementType
{
    Head,
    Chest,
    Hands,
    Legs,
    Feet
}
