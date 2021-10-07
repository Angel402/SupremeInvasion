using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Threading;

namespace UI
{
    public class MainMenu : MonoBehaviour

    {
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