using UnityEngine;
using UnityEngine.SceneManagement;
using System;

namespace UI
{
    public class GameMenuWindow : WindowController
    {
        public void ShowGameMenu()
        {
            var window = Resources.Load<GameObject>("UI/GameMenu/GameMenu");
            var canvas = FindObjectOfType<Canvas>();
            Instantiate(window, canvas.transform);
        }
    }
}