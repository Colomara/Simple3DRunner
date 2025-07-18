using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteUI : MonoBehaviour
{
    
   public GameObject completeUI;

    public void ShowCompleteScreen()
    {
        completeUI.SetActive(true);
    }
}
