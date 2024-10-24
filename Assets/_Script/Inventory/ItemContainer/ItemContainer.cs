using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemContainer : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI numberText;
    [SerializeField] private Sprite defaultSprite;

    private ItemContainerData data;
    private ItemContainerView view;

    private void Start()
    {
        data = new ItemContainerData();
        view = new ItemContainerView(itemImage, numberText, defaultSprite);
    }

    public void ResetItem()
    {
        data.Reset();
        view.Reset();
    }

    public Items GetItem() { return data.GetItemContained(); }

    public void AddItem(Items item, int number)
    {
        if(data.TryAddItem(item, number))
        {
            view.Update(item.sprite, data.GetNumber());
        }
    }

    public bool HasItem()
    {
        return data.GetItemContained() != null;
    }
}
