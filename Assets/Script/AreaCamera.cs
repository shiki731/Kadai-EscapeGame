using UnityEngine;

public class AreaCamera : MonoBehaviour
{
    private float CameraPosX;
    private float CameraPosY;
    void Update()
    {
        CameraPosX = Mathf.Clamp(transform.position.x, AreaSystem.camLeft + AreaSystem.AreaCenter.x, AreaSystem.camRight + AreaSystem.AreaCenter.x);
        CameraPosY = Mathf.Clamp(transform.position.y, AreaSystem.camDown + AreaSystem.AreaCenter.y, AreaSystem.camTop + AreaSystem.AreaCenter.y);

        Camera.main.transform.position = new Vector3(CameraPosX, CameraPosY, -10);
    }
}
