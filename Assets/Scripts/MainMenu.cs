using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using static UnityEngine.InputSystem.Mouse;

namespace UI
{
    public class MainMenu : MonoBehaviour

    {
        /*private void Update()
        {
            Debug.Log((current.position.x.ReadValue() - _latsMousePosition.x)/1920*17.78f - 8.89f + (current.position.y.ReadValue() - _latsMousePosition.y)/1080*10-5);
        }
        */

        [SerializeField] private Animator animator;
        public void FadeIn()
        {
            animator.Play("FadeIn");
        }

        public void EndGame()
        {
            FadeIn();
            StartCoroutine(WaitForEndGame());
        }

        public void StartGame()
        {
            FadeIn();
            StartCoroutine(WaitForStartGame());
        }

        private IEnumerator WaitForStartGame()
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
        private IEnumerator WaitForEndGame()
        {
            yield return new WaitForSeconds(1);
            Application.Quit();
            Debug.Log("Game Ended");
        }
    }
}