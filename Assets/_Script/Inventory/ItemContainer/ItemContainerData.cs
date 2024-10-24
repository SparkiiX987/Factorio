

using UnityEngine;

public class ItemContainerData
{
    private Items itemContained;
    private int itemNumber;

    public int GetNumber() {  return itemNumber; }

    public Items GetItemContained() { return itemContained; }

    public bool TryAddItem(Items item, int number = 1)
    {
        if(itemContained == null)
        {
            Debug.Log("ajout item");
            itemContained = item;
            itemNumber = number;
            return true;
        }
        if (itemContained.name == item.name && item.stackable)
        {
            Debug.Log("ajout nb");
            itemNumber += number;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        itemContained = null;
        itemNumber = 0;
    }
}
