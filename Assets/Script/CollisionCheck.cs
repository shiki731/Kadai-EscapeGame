using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Wall")) return;
        if(gameObject.name == "TopCheck")
        {

        }
        else if (gameObject.name == "RightCheck")
        {

        }
        else if (gameObject.name == "DownCheck")
        {

        }
        else if (gameObject.name == "LeftCheck")
        {

        }
    }
}
