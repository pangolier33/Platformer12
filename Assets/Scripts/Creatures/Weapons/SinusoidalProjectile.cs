using UnityEngine;

namespace Creatures.Weapons
{
    public class SinusoidalProjectile : BaseProjectile
    {
        [SerializeField] private float _frequency = 10f;
        [SerializeField] private float _amplitude = 0.2f;
        private float _originalY;
        private float _time;
        
        protected override void Start()
        {
            base.Start();
            _originalY = Rigidbody.position.y;
        }

        private void FixedUpdate()
        {
            var position = Rigidbody.position;
            position.x += Direction * speed;
            position.y = _originalY + Mathf.Sin(Time.time * _frequency) * _amplitude;
            Rigidbody.MovePosition(position);
            _time += Time.fixedDeltaTime;
        }
    }
}
