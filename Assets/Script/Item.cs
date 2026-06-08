using UnityEngine;

public class Item : MonoBehaviour
{
    public int ItemNum;
    public static int ItemNumber;
    public static bool[] GetItems = new bool[10]; // アイテムをゲットしてるかを管理

    private bool IsEnter = false;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsEnter && Input.GetKey(KeyCode.Space))
        {
            ItemNumber = ItemNum;
            ItemGetProcess();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsEnter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsEnter = false;
    }

    void ItemGetProcess() // アイテムを手に入れた際の処理をする場所
    {
        GetItems[ItemNum - 1] = true;
    }
}
