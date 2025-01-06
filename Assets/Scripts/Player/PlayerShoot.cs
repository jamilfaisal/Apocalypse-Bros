using Bullets;
using Managers;
using UnityEngine;

namespace Player
{
    public class PlayerShoot : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public Transform gunEnd;

        private double _shootTimer;

        private void Start()
        {
            if (!MetaManager.Instance.PlayerAttributesManager || !bulletPrefab || !gunEnd ||
                bulletPrefab.GetComponent<Bullet>() == null)
            {
                Debug.LogError("PlayerShoot is missing a reference!");
                Application.Quit();
            }
        }

        private void Update()
        {
            var attributes = MetaManager.Instance.PlayerAttributesManager.GetPlayerAttributes();
            if (ShootTimer(attributes.reloadRate))
            {
                ShootBullet(attributes.damage);
            }
        }

        private bool ShootTimer(double reloadRate)
        {
            if (_shootTimer >= reloadRate)
            {
                _shootTimer = 0;
                return true;
            }
            _shootTimer += Time.deltaTime;
            return false;
        }

        private void ShootBullet(int damage)
        {
            var bullet = Instantiate(bulletPrefab, gunEnd.position, gunEnd.rotation);
            SetBulletDamage(damage, bullet);
        }

        private static void SetBulletDamage(int damage, GameObject bullet)
        {
            var bulletScript = bullet.GetComponent<Bullet>();
            bulletScript.SetBulletDamage(damage);
        }
    }
}