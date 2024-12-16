public class PlayerAttributes
{
    private string name;
    private int level;
    private int exp;
    private int maxHealth;
    private int currentHealth;
    private int healthRegenerationRate;
    private int damage;
    private double reloadRate;

    public PlayerAttributes()
    {
        level = 1;
        exp = 0;
        maxHealth = 100;
        currentHealth = 100;
        healthRegenerationRate = 0;
        damage = 1;
        reloadRate = .5;
    }
}