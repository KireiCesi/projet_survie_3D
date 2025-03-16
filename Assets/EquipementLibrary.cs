using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipementLibrary : MonoBehaviour
{
    public List<EquipmentLibraryItem> content = new List<EquipmentLibraryItem>();
}

[System.Serializable]
public class EquipmentLibraryItem
{
    public ItemData itemData;
    public GameObject itemPrefab;
    public GameObject [] elementsToDisable;
}
