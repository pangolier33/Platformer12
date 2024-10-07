using UnityEngine;
using UnityEngine.UI;

namespace Components.Interactions
{
    public class SwitchIfComponent : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private bool _state;
        [SerializeField] private string _animationKey;
        [SerializeField] private Text _text;
        private int _calculateClick = 1;
        private int _desiredNumber;

        private void Start()
        {
            _desiredNumber = Random.Range(1, 10);
            _text.text = _desiredNumber.ToString();
        }

        public void SwitchIf()
        {
            if (_calculateClick < _desiredNumber)
            {
                _calculateClick++;
            }
            else
            {
                _state = !_state;
                _animator.SetBool(_animationKey, _state);
            }
        }
    }
}
