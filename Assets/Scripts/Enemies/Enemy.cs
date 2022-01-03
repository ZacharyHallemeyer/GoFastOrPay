using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds common stats for enemies
/// </summary>
public class Enemy : MonoBehaviour
{
    public int health;
    public int damage;
    
    public Enemy()
    {

    }

    public Enemy(int _health, int _damage)
    {
        health = _health;
        damage = _damage;
    }

    public void Move()
    {

    }

    public void Damage(int _damage)
    {
        health -= _damage;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {

    }


}
