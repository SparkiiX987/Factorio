using UnityEngine;

public class Items : ScriptableObject
{
    public string name;
    public bool stackable;
    public Sprite sprite;
}

public class Equipables : Items
{

}

public class ToolsBarEquipable : Items
{

}


[CreateAssetMenu(fileName = "Tool", menuName = "Items/Tool")]
public class Tool : ToolsBarEquipable
{
    public int damages;
}

[CreateAssetMenu(fileName = "StructureItem", menuName = "Items/StructureItem")]
public class Structure : ToolsBarEquipable
{
    public int width, height;
}

[CreateAssetMenu(fileName = "Feet", menuName = "Items/Feet")]
public class Feet : Equipables
{
    public int velocityAdded;
}

[CreateAssetMenu(fileName = "Back", menuName = "Items/Back")]
public class Back : Equipables
{
    public int o2Added;
}

[CreateAssetMenu(fileName = "Armor", menuName = "Items/Armor")]
public class Armor : Equipables
{
    public int healthAdded;
}


[CreateAssetMenu(fileName = "Ressource", menuName = "Items/Ressource")]
public class Ressource : Items
{

}