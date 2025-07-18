
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CompleteTrigger : MonoBehaviour
{
    public GameObject winPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ShowWinPanelWithDelay());
        }
    }

    IEnumerator ShowWinPanelWithDelay()
    {
        winPanel.SetActive(true); 
        yield return new WaitForSeconds(1f); 
        Time.timeScale = 0f; 
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
