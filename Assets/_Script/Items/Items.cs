using UnityEngine;

public abstract class Items : ScriptableObject
{
    public string name;
    public bool stackable;
    public Sprite sprite;
}

public abstract class Equipables : Items
{
    public bool stackable = false;
}

public abstract class ToolsBarEquipable : Items
{
    public bool stackable = false;
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
    public bool stackable = true;
}