using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform muzzle;
    public Projectile projectile;
    public float span = 0.1f;
    public float delta = 0;
    public float muzzleVelocity = 35;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Shoot()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            delta = 0;
            Projectile newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation);
            newProjectile.SetSpeed(muzzleVelocity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
