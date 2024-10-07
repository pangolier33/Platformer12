using System;
using Components.ColliderBased;
using Components.GoBased;
using UnityEngine;
using Utils;

namespace Creatures.Mobs
{
    public class ShootingTrapAI : MonoBehaviour
    {
        [SerializeField] private LayerCheck _vision;
        
        [Header ("Melee")]
        [SerializeField] private LayerCheck _meleeCanAttack;
        [SerializeField] private CheckCircleOverlap _meleeAttack;
        [SerializeField] private Cooldown _meleeCooldown;
        
        [Header ("Range")]
        [SerializeField] private SpawnComponent _rangeCanAttack;
        [SerializeField] private Cooldown _rangeCooldown;
        
        private static readonly int Melee = Animator.StringToHash("melee");
        private static readonly int Range = Animator.StringToHash("range");
        
        
        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }
        
        
        private void Update()
        {
            if (_vision.IsTouchingLayer)
            {
                if (_meleeCanAttack.IsTouchingLayer)
                {
                    if (_meleeCooldown.IsReady)
                        MeleeAttack();
                    return;
                }

                if (_rangeCooldown.IsReady)
                    RangeCanAttack();
            }
        }

        private void MeleeAttack()
        {
            _meleeCooldown.Reset();
            _animator.SetTrigger(Melee);
        }
        
        private void RangeCanAttack()
        {
            _rangeCooldown.Reset();
            _animator.SetTrigger(Range);
        }
        
        private void OnMeleeAttack()
        {
            _meleeAttack.Check();
        }
        
        private void OnRangeAttack()
        {
            _rangeCanAttack.Spawn();
        }
    }
}
