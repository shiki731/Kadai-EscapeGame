using UnityEngine;
using UnityEngine.UIElements;

public class EnemyAction1 : MonoBehaviour
{
    public Transform PlayerPos;
    private float angle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        angle = PlayerSearch(transform.position,PlayerPos.transform.position);
        
    }

    private float PlayerSearch(Vector2 enePos, Vector2 plaPos)
    {
        float dx = enePos.x - plaPos.x;
        float dy = enePos.y - plaPos.y;
        float direction = Mathf.Atan2(dy, dx);
        return direction * Mathf.Rad2Deg;

    }
}
