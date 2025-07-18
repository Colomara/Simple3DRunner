
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public LevelCompleteUI levelCompleteUI;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger touched: " +  other.name);
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player reached finish!");
            levelCompleteUI.ShowCompleteScreen();
            other.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
