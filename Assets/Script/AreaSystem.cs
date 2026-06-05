using System;
using UnityEngine;
using UnityEngine.UIElements;

public class AreaSystem : MonoBehaviour
{
    //enpty objectにつける
    //エリア番号に応じたカメラの移動範囲の制御ができるスクリプト

    public static int areaNum = 1;


    public static float camRight = 0.0f;
    public static float camLeft = 0.0f;
    public static float camTop = 0.0f;
    public static float camDown = 0.0f;

    public static Vector2 AreaCenter;

    [SerializeField, Header("AreaSize(sprite)でカメラの動く範囲を管理")]
    public Transform[] AreaSize;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camRight = Mathf.Clamp(AreaSize[areaNum - 1].localScale.x / 2 - 9.6f, 0, 1000);
        camLeft = Mathf.Clamp(AreaSize[areaNum - 1].localScale.x / 2 * -1 + 9.6f, -1000, 0);
        camTop = Mathf.Clamp(AreaSize[areaNum - 1].localScale.y / 2 - 5.4f, 0, 1000);
        camDown = Mathf.Clamp(AreaSize[areaNum - 1].localScale.y / 2 * -1 + 5.4f, -1000, 0);

        AreaCenter = new Vector2(AreaSize[areaNum - 1].position.x, AreaSize[areaNum - 1].position.y);
    }
}
