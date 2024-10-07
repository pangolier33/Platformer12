using System;
using UnityEngine;

namespace Model.Data
{
    [Serializable]
    public class PlayerData : MonoBehaviour
    {
        [SerializeField] private InventoryData _inventory;
        public int Hp;

        public InventoryData Inventory => _inventory;
    }
}