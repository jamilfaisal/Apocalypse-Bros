using Bullets;
using Managers;
using UnityEngine;

namespace Player
{
    public class PlayerShoot : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform gun;

        private double _shootTimer;

        private void Start()
        {
            if (!MetaManager.Instance.PlayerAttributesManager || !bulletPrefab || !gun ||
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
            var bullet = Instantiate(bulletPrefab, gun.position, gun.rotation);
            SetBulletDamage(damage, bullet);
        }

        private static void SetBulletDamage(int damage, GameObject bullet)
        {
            var bulletScript = bullet.GetComponent<Bullet>();
            bulletScript.SetBulletDamage(damage);
        }
    }
}