using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    [SerializeField] Button resetBtn = null;
    [SerializeField] GameObject nextUp = null;

    private void OnEnable()
    {
        resetBtn.onClick.AddListener(Reload);
    }

    private void Reload()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    
    public void Finish()
    {
        nextUp.SetActive(true);
        Time.timeScale = 0;
    }
}
