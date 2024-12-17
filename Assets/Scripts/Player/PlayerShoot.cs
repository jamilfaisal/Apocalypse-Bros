using Bullets;
using Managers;
using UnityEngine;

namespace Player
{
    public class PlayerShoot : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public Transform gunEnd;
        public PlayerAttributesManager attributesManager;

        private double _fireTimer;
    
        private void Update()
        {
            if (!attributesManager) return;
            
            var attributes = attributesManager.GetPlayerAttributes();
            _fireTimer += Time.deltaTime;
            if (_fireTimer >= attributes.reloadRate)
            {
                FireBullet(attributes);
                _fireTimer = 0;
            }
        }

        private void FireBullet(PlayerAttributes attributes)
        {
            if (!bulletPrefab || !gunEnd) return;
        
            var bullet = Instantiate(bulletPrefab, gunEnd.position, gunEnd.rotation);
            SetBulletDamage(attributes, bullet);
        }

        private static void SetBulletDamage(PlayerAttributes attributes, GameObject bullet)
        {
            var bulletScript = bullet.GetComponent<Bullet>();
            if (bulletScript)
            {
                bulletScript.SetBulletDamage(attributes.damage);
            }
        }
    }
}
