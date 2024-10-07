using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Components.ColliderBased;
using Components;

public class BatController : MonoBehaviour
{
    public LayerMask targetLayer;
        [SerializeField] private GameObject Prefab;
        [SerializeField] private EnterEvent _action;
   
        public void OnTriggerEnter2D(Collider2D other)
        {
            Vector2 center = transform.position;
            Vector2 hitPoint = other.bounds.ClosestPoint(center);
            Vector2 direction = hitPoint - center;

            if (((1 << other.gameObject.layer) & targetLayer) != 0)
            {
                _action?.Invoke(other.gameObject);
                GameObject bullet = Instantiate(Prefab, center, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = direction.normalized * 5; 
            }
            
           
        }
}
