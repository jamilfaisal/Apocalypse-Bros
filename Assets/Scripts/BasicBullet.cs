using System;
using UnityEngine;

public class BasicBullet : MonoBehaviour
{
    private int bulletDamage;
    private int bulletSpeed = 200;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*bulletSpeed*Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Mob"))
        {
            MobAbstract mob = other.gameObject.GetComponent<MobAbstract>();
            mob.TakeDamage(bulletDamage);
        }
    }
}
