public class ItemContainerData
{
    private Items itemContained;
    private int itemNumber;

    public Items GetItemContained() { return itemContained; }

    public bool TryAddItem(Items item, int number = 1)
    {
        if(itemContained == null)
        {
            itemContained = item;
            itemNumber = number;
            return true;
        }
        else if (itemContained.name == item.name && item.stackable)
        {
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
