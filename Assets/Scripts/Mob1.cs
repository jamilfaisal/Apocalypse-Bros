using UnityEngine;

public class Mob1 : MobAbstract
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 4;
    }

    protected override void Die()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
