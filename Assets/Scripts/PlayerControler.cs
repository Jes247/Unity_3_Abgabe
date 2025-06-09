using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5; // ich habe eine Variable gemacht um die geschwindigkeit zu regulieren. 
    private Rigidbody2D rb; // ich habe den Rigidbody2D von meinem Player hinzugefügt um zugriff zu haben.
    public float jump = 5; // ich habe eine Variable gamcht zum springen die ich auch auf den wert 5 gesetzt habe. 
    private bool isgrounded = false; // habe eine Variable (isgrounded) gamcht und einen bool den ich auf false gesetzt habe 
    public GameObject penel;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // ich habe den  Rigibody zugewisen. 
        //m = GameObject.FindWithTag("text").GetComponent<CoinScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float richtung = Input.GetAxis("Horizontal"); //
        transform.Translate(Vector2.right*speed*richtung*Time.deltaTime);
        // Ich habe die richtungen die der spieler beim drrücken von A oder D bestimmt. 
        // bei A geht der player nach hinten (-1) bei D geht der Player nach vorne (1) (der player steht auf 0) 
        // dazu habe ich erstmal eine Variable deffiniert die gleich bestimmt das der Player sich Horinzontal bewegt. 

        if (Input.GetKeyDown(KeyCode.Space)&& isgrounded) 
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            isgrounded = false;
        }
        // diese "Funktion" soll bestimmen das wenn ich auf Space drücke mein player springt 
        // dazu habe ich isground hinzugefügt beim if damit der player wirklich nur Springt wenn er auf dem Boden war.
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Ground") 
        {
            isgrounded = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Enemy")
        {
            penel.SetActive(true);
            Destroy(gameObject);
        }
    }
     // Ich habe eine neue Function gemacht inder der Player nur sprigen kann wenn er auf dem Boden ist und nichtm- 
     // - in der Luft 
    
        
    
}
