using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class StartScript : MonoBehaviour
{
    public GameObject startPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
        {
            startPanel.SetActive(true);
          
        }
    public void OnClickStart()
    {
        SceneManager.LoadScene(1);
    }
    

}
