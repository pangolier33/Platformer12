using Components.GoBased;
using UnityEngine;

namespace Creatures.Weapons
{
    public class CannonFire : MonoBehaviour
    {
        [SerializeField] protected SpawnListComponent _particles;
    
        public void FireParticles()
        {
            _particles.Spawn("Fire");
        }
    }
}
