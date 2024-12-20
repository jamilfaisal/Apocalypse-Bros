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
            MetaManager.Instance.LevelManager.AddXp(10);
            Destroy(gameObject);
        }
    }
}
