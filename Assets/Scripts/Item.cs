using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public abstract class Item
{
    [SerializeField] private string itemName;
    [SerializeField] private int itemPrice;
}
