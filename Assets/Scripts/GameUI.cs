using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject configPanel, accessPanel;
    void Start()
    {
        configPanel.SetActive(false);
        accessPanel.SetActive(false);
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenConfig()
    {
        configPanel.SetActive(true);
    }

    public void OpenAccess()
    {
        configPanel.SetActive(false);
        accessPanel.SetActive(true);
    }

    public void CloseAccess()
    {
        accessPanel.SetActive(false);
        configPanel.SetActive(true);
    }

    public void CloseConfig()
    {
        configPanel.SetActive(false);
    }
}
