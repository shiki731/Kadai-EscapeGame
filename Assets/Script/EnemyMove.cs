using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMove : MonoBehaviour
{
    public Transform PlayerPos;
    private float angle;
    private float speed = 5.0f;
    private float dx;
    private float dy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector2(100, 100);
    }

    private float PlayerSearch(Vector2 enePos, Vector2 plaPos)
    {
        dx = enePos.x - plaPos.x;
        dy = enePos.y - plaPos.y;
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
            if (CollisionCheck.leftCheck == true) return;
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        //‰º
        else if (angle == 90)
        {
            if (CollisionCheck.dowCheck == true) return;
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        //‰E
        else if (angle == 180 || angle == -180)
        {
            if (CollisionCheck.rightCheck == true) return;
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        //ã
        else if (angle == -90)
        {
            if (CollisionCheck.topCheck == true) return;
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        //¶‰º
        else if (angle >= 0 && angle <= 90)
        {
            //Debug.Log("lefDo");
            if (CollisionCheck.leftCheck == true) 
            {
                if (CollisionCheck.dowCheck == true) return;
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
            else if (CollisionCheck.dowCheck == true)
            {
                if (CollisionCheck.leftCheck == true) return;
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            else
            {
                if (angle >= 0 && angle <= 45)
                {
                    if (CollisionCheck.leftCheck == true) return;
                    transform.Translate(Vector2.left * speed * Time.deltaTime);
                }
                else if (angle >= 45 && angle <= 90)
                {
                    if (CollisionCheck.dowCheck == true) return;
                    transform.Translate(Vector2.down * speed * Time.deltaTime);
                }
            }
        }
        //‰E‰º
        else if (angle >= 90 && angle <= 180)
        {
            //Debug.Log("rigDo");
            if (CollisionCheck.rightCheck == true)
            {
                if (CollisionCheck.dowCheck == true) return;
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
            else if (CollisionCheck.dowCheck == true)
            {
                if (CollisionCheck.rightCheck == true) return;
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else
            {
                if (angle >= 90 && angle <= 135)
                {
                    if (CollisionCheck.dowCheck == true) return;
                    transform.Translate(Vector2.down * speed * Time.deltaTime);
                }
                else if (angle >= 135 && angle <= 180)
                {
                    if (CollisionCheck.rightCheck == true) return;
                    transform.Translate(Vector2.right * speed * Time.deltaTime);
                }
            }
            
        }
        //¶ã
        else if (angle >= -90 && angle <= 0)
        {
            //Debug.Log("lefUp");
            if (CollisionCheck.leftCheck == true)
            {
                if (CollisionCheck.topCheck == true) return;
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
            else if (CollisionCheck.topCheck == true)
            {
                if (CollisionCheck.leftCheck == true) return;
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            else
            {
                if (angle >= -45 && angle <= 0)
                {
                    if (CollisionCheck.topCheck == true) return;
                    transform.Translate(Vector2.up * speed * Time.deltaTime);
                }
                else if (angle >= -90 && angle <= -45)
                {
                    if (CollisionCheck.leftCheck == true) return;
                    transform.Translate(Vector2.left * speed * Time.deltaTime);
                }
            }
            
        }
        //‰Eã
        else if (angle >= -180 && angle <= -90)
        {
            //Debug.Log("rigUp");
            if (CollisionCheck.rightCheck == true)
            {
                if (CollisionCheck.topCheck == true) return;
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
            else if(CollisionCheck.topCheck == true)
            {
                if (CollisionCheck.rightCheck == true) return;
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else
            {
                if (angle >= -135 && angle <= -90)
                {
                    if (CollisionCheck.topCheck == true) return;
                    transform.Translate(Vector2.up * speed * Time.deltaTime);
                }
                else if (angle >= -180 && angle <= -135)
                {
                    if (CollisionCheck.rightCheck == true) return;
                    transform.Translate(Vector2.right * speed * Time.deltaTime);
                }
            }
            
        }
    }
}
