using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int numberOfSlots;

    [SerializeField] private GameObject slot;
    [SerializeField] private Transform slotsPanel;
    
    private InventoryData data;

    public Items testItem;
    public Items testItem2;

    void Start()
    {
        data = new(slot, slotsPanel);
        data.Initialize(numberOfSlots);
    }

    public void AddItem(Items item, int number)
    {
        for (int i = 0; i < data.GetItemContainerList().Count; i++)
        {
            if (!data.GetItemContainerList()[i].HasItem() || data.GetItemContainerList()[i].GetItem().name == item.name)
            {
                data.GetItemContainerList()[i].AddItem(item, number);
                return;
            }
        }
    }

    public void TestAddItem()
    {
        AddItem(testItem, 1);
    }

    public void TestAddItem2()
    {
        AddItem(testItem2, 1);
    }
}
