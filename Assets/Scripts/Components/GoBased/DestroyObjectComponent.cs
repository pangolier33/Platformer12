using UnityEngine;

namespace Components.GoBased
{
    public class DestroyObjectComponent : MonoBehaviour
    {
        [SerializeField] private GameObject _objectToDestroy;

        public void Destroyobject()
        {
            Destroy(_objectToDestroy);
        }
    }
}