using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMeneger : MonoBehaviour
{
   
    public GameObject losePanel;
    public GameObject winPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        losePanel.SetActive(false);
        winPanel.SetActive(false);
    }
    public void Retrybutton()
    {
        SceneManager.LoadScene(1);
        
    }
    public void OpenStartPanel()
    {
        SceneManager.LoadScene(0);
    }
    public void OpenlosePanel()
    {
        losePanel.SetActive(true);
        
        winPanel.SetActive(false);
    }

    public void OpenwinPanel()
    {
        winPanel.SetActive(true);
        
        losePanel.SetActive(false);
    }

    public void ClosestartPanel()
    {
       
    }
   
} 
