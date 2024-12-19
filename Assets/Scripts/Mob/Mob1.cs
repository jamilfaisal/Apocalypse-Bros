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
            LevelManager.AddXp(10);
            Destroy(gameObject);
        }
    }
}
