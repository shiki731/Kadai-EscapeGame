using System.Threading.Tasks;
using UnityEngine;

public class door : MonoBehaviour
{
    public Transform ExitDoor;
    public Transform Player;
    public Transform Enemy;
    public int NextAreaNum;

    public bool KeyDoor = false;
    public int useItemNum;

    [SerializeField, Header("扉から出る位置(1なら左、2なら下、3なら右、4なら上)")]
    public int ExitDirection;

    


    public static int NumSet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (KeyDoor == true)
            {
                if (Item.GetItems[useItemNum])
                {

                }
            }
            else if(KeyDoor == false)
            {
                NumSet = NextAreaNum;
                warp();
            }
            
        }
    }
    async void warp()
    {
        AreaSystem.areaNum = NumSet;
        if (ExitDirection == 1)
        {
            Player.transform.position = new Vector2(ExitDoor.transform.position.x - 1, ExitDoor.transform.position.y);
        }
        else if (ExitDirection == 2)
        {
            Player.transform.position = new Vector2(ExitDoor.transform.position.x, ExitDoor.transform.position.y - 1);
        }
        else if (ExitDirection == 3)
        {
            Player.transform.position = new Vector2(ExitDoor.transform.position.x + 1, ExitDoor.transform.position.y);
        }
        else if (ExitDirection == 4)
        {
            Player.transform.position = new Vector2(ExitDoor.transform.position.x, ExitDoor.transform.position.y + 1);
        }
        
        await Task.Delay(1000);
        
        if (ExitDirection == 1)
        {
            Enemy.transform.position = new Vector2(ExitDoor.transform.position.x - 1, ExitDoor.transform.position.y);
        }
        else if (ExitDirection == 2)
        {
            Enemy.transform.position = new Vector2(ExitDoor.transform.position.x, ExitDoor.transform.position.y - 1);
        }
        else if (ExitDirection == 3)
        {
            Enemy.transform.position = new Vector2(ExitDoor.transform.position.x + 1, ExitDoor.transform.position.y);
        }
        else if (ExitDirection == 4)
        {
            Enemy.transform.position = new Vector2(ExitDoor.transform.position.x, ExitDoor.transform.position.y + 1);
        }
    }
}
