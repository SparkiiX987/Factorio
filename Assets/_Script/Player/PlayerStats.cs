using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private int maxHealth;
    [SerializeField] private int maxOxygen;
    private int health;
    private int oxygen;
    /*
    [SerializeField] private int maxHunger;
    private int hunger;
    */

    public void AddNMaxHealth(int n)
    {
        maxHealth += n;
        health += n;
    }

    public void AddNMaxOxygene(int n)
    {
        maxOxygen += n;
        oxygen += n;
    }

    public void AddNHealth(int n)
    {
        health += n;
        if (health > maxHealth)
            health = maxHealth;
        else if (health <= 0)
        {
            health = 0;
            //TODO add death
        }
    }

    public void AddOxygen(int n)
    {
        oxygen += n;
        if (oxygen > maxOxygen)
            oxygen = maxOxygen;
        else if (oxygen <= 0)
        {
            oxygen = 0;
            //TODO trigger damages + screen fade black
        }
    }

    public int GetHealth() { return health; }

    public int GetOxygen() { return oxygen; }

}
