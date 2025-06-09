using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float speed = 3f;
    public float right;
    public float left;
    private Vector3 rotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        right = transform.position.x + right;
        left = transform.position.x - left;
        rotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < left)
        {
            transform.eulerAngles = rotation - new Vector3(0, 180, 0);
        }
        if (transform.position.x < right)
        {
            transform.eulerAngles = rotation;
        }
        
    }
}
