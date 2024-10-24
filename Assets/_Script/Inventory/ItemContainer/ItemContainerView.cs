using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemContainerView
{
    private Image itemIamge;
    private TextMeshProUGUI numberText;

    private Sprite defaultSprite;

    public ItemContainerView(Image itemIamge, TextMeshProUGUI numberText, Sprite defaultSprite)
    {
        this.itemIamge = itemIamge;
        this.numberText = numberText;
        this.defaultSprite = defaultSprite;
    }

    public void Update(Sprite sprite, int number)
    {
        itemIamge.sprite = sprite;
        if(number > 0)
        {
            numberText.text = number.ToString();
        }
        else
        {
            numberText.text = string.Empty;
        }
        
    }

    public void Reset()
    {
        Update(defaultSprite, 0);
    }
}
