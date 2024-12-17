using UnityEngine;

namespace Mob
{
    public abstract class MobAbstract : MonoBehaviour
    {
        protected int Health;

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Die();
            }
        }

        protected abstract void Die();
    }
}
