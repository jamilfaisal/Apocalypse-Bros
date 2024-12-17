using UnityEngine;

public abstract class MobAbstract : MonoBehaviour
{
    protected int health;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    protected abstract void Die();
}
