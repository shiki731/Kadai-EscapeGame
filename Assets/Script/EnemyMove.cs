using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMove : MonoBehaviour
{
    public Transform PlayerPos;
    private float angle;
    private float speed = 5.0f;
    public bool LefDowm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        angle = PlayerSearch(transform.position,PlayerPos.transform.position);
        //transform.rotation = Quaternion.Euler(0, 0, angle);

        //¶‰º
        if (angle >= 0 && angle < 90)
        {
            if (transform.position.x < PlayerPos.transform.position.x)
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
        //‰E‰º
        else if (angle >= 90 && angle < 180)
        {
            if (transform.position.x > PlayerPos.transform.position.x)
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }
        //¶ã
        else if (angle >= -90 && angle < 0)
        {
            if (transform.position.x > PlayerPos.transform.position.x)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
        //‰Eã
        else if (angle >= -180 && angle < -90)
        {
            if (transform.position.x > PlayerPos.transform.position.x)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }




    }

    private float PlayerSearch(Vector2 enePos, Vector2 plaPos)
    {
        float dx = enePos.x - plaPos.x;
        float dy = enePos.y - plaPos.y;
        float direction = Mathf.Atan2(dy, dx);
        return direction * Mathf.Rad2Deg;

    }
}
