using Managers;

namespace Mob
{
    public class Mob1 : MobAbstract
    {
        private void Start()
        {
            Health = 4;
        }

        protected override void Die()
        {
            GameManager.Instance.LevelManager.AddXp(10);
            Destroy(gameObject);
        }
    }
}
