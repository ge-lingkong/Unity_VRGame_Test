using UnityEngine;

public class NewBall : MonoBehaviour
{
    [Header("�y�y")]
    public GameObject ball;
    [Header("�ͦ��I")]
    public Transform point;
    public void newBall()
    {
        Instantiate(ball, point.position, point.rotation, point);
    }
}
