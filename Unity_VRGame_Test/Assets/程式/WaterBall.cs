using UnityEngine;

public class WaterBall : MonoBehaviour
{
    [Header("�y�y�C��")]
    public GameObject ballColor;
    [Header("�y�y�S��")]
    public GameObject ballEffect;
    [Header("�y�y����")]
    public AudioClip ballSound;
    [Header("�C�ƨ���")]
    public Vector3 colorAngle;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "�e��")
        {
            //Instantiate(ballEffect, transform.position, transform.rotation, transform);
            Instantiate(ballColor, transform.position, Quaternion.Euler(colorAngle), collision.transform);
            Destroy(gameObject);
        }
    }
}
