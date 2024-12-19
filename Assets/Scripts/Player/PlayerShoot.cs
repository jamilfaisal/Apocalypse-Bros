using Bullets;
using Managers;
using UnityEngine;

namespace Player
{
    public class PlayerShoot : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public Transform gunEnd;
        private PlayerAttributesManager _attributesManager;

        private double _fireTimer;

        private void Start()
        {
            _attributesManager = GameManager.Instance.AttributesManager;
            if (!_attributesManager || !bulletPrefab || !gunEnd || bulletPrefab.GetComponent<Bullet>() == null)
            {
                Debug.LogError("PlayerShoot is missing a reference!");
                Application.Quit();
            }
        }

        private void Update()
        {
            var attributes = _attributesManager.GetPlayerAttributes();
            _fireTimer += Time.deltaTime;
            if (_fireTimer >= attributes.reloadRate)
            {
                FireBullet(attributes);
                _fireTimer = 0;
            }
        }

        private void FireBullet(PlayerAttributes attributes)
        {
        
            var bullet = Instantiate(bulletPrefab, gunEnd.position, gunEnd.rotation);
            SetBulletDamage(attributes, bullet);
        }

        private static void SetBulletDamage(PlayerAttributes attributes, GameObject bullet)
        {
            var bulletScript = bullet.GetComponent<Bullet>();
            bulletScript.SetBulletDamage(attributes.damage);
        }
    }
}
