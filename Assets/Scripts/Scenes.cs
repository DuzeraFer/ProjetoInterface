using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public GameObject configPanel, menuPanel, accessPanel, inventPanel, rankPanel;  
    void Start()
    {
        configPanel.SetActive(false);
        menuPanel.SetActive(true);
        accessPanel.SetActive(false);
        inventPanel.SetActive(false);
        rankPanel.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
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
    public void OpenInventory()
    {
        inventPanel.SetActive(true);
    }

    public void CloseInventory() 
    {
        inventPanel.SetActive(false);
    }

    public void OpenRank() 
    {
        rankPanel.SetActive(true);
    }

    public void CloseRank() 
    {
        rankPanel.SetActive(false);
    }
}
