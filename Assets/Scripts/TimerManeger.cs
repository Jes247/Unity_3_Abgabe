using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class TimerManeger : MonoBehaviour
{
    public GameObject losePanel; 

    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime;


    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        timerText.text = elapsedTime.ToString();
        int minute = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minute, seconds);

        if(elapsedTime == 60)
        {
            losePanel.SetActive(true);
        }
    }


} 
