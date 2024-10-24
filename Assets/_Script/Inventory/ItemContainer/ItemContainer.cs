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

    public void AddItem(Items item, int itemNumber)
    {
        if(data.TryAddItem(item, itemNumber))
        {
            view.Update(item.sprite, itemNumber);
        }
    }

    public bool HasItem()
    {
        return data.GetItemContained() != null;
    }
}
