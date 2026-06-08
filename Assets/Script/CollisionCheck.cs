using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public static bool topCheck = false;
    public static bool rightCheck = false;
    public static bool dowCheck = false;
    public static bool leftCheck = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (topCheck)
        {
            //Debug.Log("TopCheck");

        }
        if (rightCheck)
        {
            //Debug.Log("RightCheck");

        }
        if (dowCheck)
        {
            //Debug.Log("DownCheck");

        }
        if (leftCheck)
        {
            //Debug.Log("LeftCheck");

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!collision.CompareTag("Wall")) return;
        if(gameObject.name == "TopCheck")
        {
            topCheck = true;
        }
        else if (gameObject.name == "RightCheck")
        {
            rightCheck = true;
        }
        else if (gameObject.name == "DownCheck")
        {
            dowCheck = true;
        }
        else if (gameObject.name == "LeftCheck")
        {
            leftCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Wall")) return;
        if (gameObject.name == "TopCheck")
        {
            topCheck = false;
        }
        else if (gameObject.name == "RightCheck")
        {
            rightCheck = false;
        }
        else if (gameObject.name == "DownCheck")
        {
            dowCheck = false;
        }
        else if (gameObject.name == "LeftCheck")
        {
            leftCheck = false;
        }
    }
}
