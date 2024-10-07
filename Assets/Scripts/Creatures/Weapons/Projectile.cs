using UnityEngine;

namespace Creatures.Weapons
{
    public class Projectile : BaseProjectile
    {
        protected override void Start()
        {
            base.Start();
            
            var force = new Vector2(Direction * speed, 0);
            Rigidbody.AddForce(force, ForceMode2D.Impulse);
        }
    }

}
