using System.Diagnostics.CodeAnalysis;
using Managers;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Mob
{
    [SuppressMessage("ReSharper", "RedundantDefaultMemberInitializer")]
    public class Mob1 : MobAbstract
    {
        private const int MobDamage = 10;
        private const double TimeBetweenAttacks = 2;
        private double _timeTillNextAttack = 0;
        private void Start()
        {
            Health = 4;
        }

        private void Update()
        {
            if (_timeTillNextAttack < TimeBetweenAttacks)
            {
                _timeTillNextAttack += Time.deltaTime;
            }
        }

        private void OnCollisionStay(Collision other)
        {
            
            if (other.gameObject.CompareTag("Player") && CanHit())
            {
                MetaManager.Instance.PlayerAttributesManager.PlayerTakeDamage(MobDamage);
                Debug.Log("im hitting im ahhha hitting ahhh " + MobDamage);
                _timeTillNextAttack = 0;
            }
        }

        private bool CanHit()
        {
            return _timeTillNextAttack >= TimeBetweenAttacks;
        }

        protected override void Die()
        {
            MetaManager.Instance.LevelManager.AddXp(10);
            Destroy(gameObject);
        }
    }
}
