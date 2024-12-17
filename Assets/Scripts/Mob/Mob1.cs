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
            Destroy(gameObject);
        }
    }
}
