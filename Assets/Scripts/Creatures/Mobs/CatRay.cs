using UnityEngine;

namespace Creatures.Mobs
{
    public class CatRay : MonoBehaviour
    {
        [SerializeField] private float distance = 3f;
        [SerializeField] private Vector2 direction;
        private int _layerMask;

        private void Start()
        {
            _layerMask = LayerMask.GetMask("Hero");
        }

        private void Update()
        {
            var position = transform.position;
        
            RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, _layerMask);
            Debug.DrawRay(position, direction * distance, Color.blue);
        
            if (hit.collider)
                Debug.Log("Герой");
        }
    }
}
