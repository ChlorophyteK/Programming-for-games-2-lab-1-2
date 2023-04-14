using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    [SerializeField] private List<Item> items = new List<Item>();

    private void Start()
    {
        items.Add(new Keys(1));
        items.Add(new Keys(2));
        items.Add(new Keys(3));

        List<Item> Keys  = GetItemsByItemType<Keys>();

        Debug.Log("Heya");
    }
    private List<Item> GetItemsByItemType<T>() where T : Item
    {
        List<Item> itemsToReturn = new List<Item>();
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] is T)
            {
                itemsToReturn.Add(items[i]);
            }
        }
        return itemsToReturn;
    }
}
