using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int numberOfSlots;
    [SerializeField] private GameObject slot;
    [SerializeField] private Transform slotsPanel;
    InventoryData data;

    void Start()
    {
        data = new(slot, slotsPanel);
        data.Initialize(numberOfSlots);
    }

    public ItemContainer AddItem(Items item, int number)
    {
        for (int i = 0; i < data.GetItemContainerList().Count; i++)
        {
            if (!data.GetItemContainerList()[i].HasItem())
            {
                data.GetItemContainerList()[i].AddItem(item, number);
                return data.GetItemContainerList()[i];
            }
        }
        return null;
    }

}
