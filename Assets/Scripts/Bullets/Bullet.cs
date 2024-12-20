using Mob;
using UnityEngine;

namespace Bullets
{
    public abstract class Bullet : MonoBehaviour
    {
        private int _bulletDamage;
        private const int BulletSpeed = 100;

        private void Update()
        {
            transform.Translate(BulletSpeed * Time.deltaTime * Vector3.up);
        }
    
        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.CompareTag("Mob")) return;
            var mob = other.gameObject.GetComponent<MobAbstract>();
            mob.TakeDamage(_bulletDamage);
            Destroy(gameObject);
        }
    
        public void SetBulletDamage(int damage)
        {
            _bulletDamage = damage;
        }
    }
}
