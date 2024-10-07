using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class WindowController : MonoBehaviour
    {
        private Animator _animator;
        private static readonly int Show = Animator.StringToHash("Show");
        private static readonly int Hide = Animator.StringToHash("Hide");

        protected virtual void Start()
        {
            if (gameObject.GetComponent<Animator>() != null)
            {
                _animator = GetComponent<Animator>();
                _animator.SetTrigger(Show);
            }
        }

        public void Close()
        {
            if (gameObject.GetComponent<Animator>() != null) _animator.SetTrigger(Hide);
        }

        public virtual void OnCloseAnimationComplete()
        {
            Destroy(gameObject);
        }
    }
}