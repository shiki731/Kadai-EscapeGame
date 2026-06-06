using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMove : MonoBehaviour
{
    public Transform PlayerPos;
    private float angle;
    private float speed = 3.0f;
    // private float dx;
    // private float dy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private float PlayerSearch(Vector2 enePos, Vector2 plaPos)
    {
        float dx = enePos.x - plaPos.x;
        float dy = enePos.y - plaPos.y;
        float direction = Mathf.Atan2(dy, dx);
        return direction * Mathf.Rad2Deg;

    }

    // Update is called once per frame
    void Update()
    {
        angle = PlayerSearch(transform.position,PlayerPos.transform.position);
        //transform.rotation = Quaternion.Euler(0, 0, angle);



        //¶
        if (angle == 0) 
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        //‰º
        else if (angle == 90)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        //‰E
        else if (angle == 180 || angle == -180)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        //ã
        else if (angle == -90)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        //¶‰º
        else if (angle > 0 && angle < 90)
        {
            Debug.Log("lefDo");
            if (angle >= 0 && angle <= 45)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            else if (angle >= 45 && angle <= 90)
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
        }
        //‰E‰º
        else if (angle > 90 && angle < 180)
        {
            Debug.Log("rigDo");
            if (angle >= 90 && angle <= 135)
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
            else if (angle >= 135 && angle <= 180)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }
        //¶ã
        else if (angle > -90 && angle < 0)
        {
            Debug.Log("lefUp");
            if (angle >= -45 && angle <= 0)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
            else if (angle >= -90 && angle <= -45)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
        //‰Eã
        else if (angle > -180 && angle < -90)
        {
            Debug.Log("rigUp");
            if (angle >= -135 && angle <= -90)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
            else if (angle >= -180 && angle <= -135)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }




    }

    
}
