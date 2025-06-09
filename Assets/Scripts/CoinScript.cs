using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinScript : MonoBehaviour
{
    public int money;
    public TMP_Text geld;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "fire")
        {
            Addmoney();
            Destroy(other.gameObject);
        }
            
       
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        geld.text= money.ToString();
    }

    public void Addmoney()
    {
        money++;
    }
}    
    
