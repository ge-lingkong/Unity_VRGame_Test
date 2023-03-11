using UnityEngine;

public class NewBall : MonoBehaviour
{
    [Header("球球")]
    public GameObject ball;
    [Header("生成點")]
    public Transform point;
    public void newBall()
    {
        Instantiate(ball, point.position, point.rotation, point);
    }
}
