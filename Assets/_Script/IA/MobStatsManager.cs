using System.Collections;
using UnityEngine;

public class MobStatsManager : MonoBehaviour
{
    public int maxHP;
    public int currentHP;
    public float movementSpeed;
    public float attackSpeed;
    public int damage;
    public float detectionRange;
    public bool isPassive;
    public bool isDead;

    private void Start()
    {
        isDead = false;
        currentHP = maxHP;
    }

    private void Update()
    {
        Death();
    }

    public void Death()
    {
        if(currentHP <= 0)
        {
            isDead = true;
            StartCoroutine(DeathTimer());
        }
    }

    IEnumerator DeathTimer()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}