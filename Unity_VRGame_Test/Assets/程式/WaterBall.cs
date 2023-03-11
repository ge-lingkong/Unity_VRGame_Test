using UnityEngine;

public class WaterBall : MonoBehaviour
{
    [Header("球球顏料")]
    public GameObject ballColor;
    [Header("球球特效")]
    public GameObject ballEffect;
    [Header("球球音效")]
    public AudioClip ballSound;
    [Header("顏料角度")]
    public Vector3 colorAngle;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "畫布")
        {
            //Instantiate(ballEffect, transform.position, transform.rotation, transform);
            Instantiate(ballColor, transform.position, Quaternion.Euler(colorAngle), collision.transform);
            Destroy(gameObject);
        }
    }
}
