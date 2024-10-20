using UnityEngine;
using System.Collections;

public class AIGolfer : MonoBehaviour
{
    public GameObject golfBallPrefab;   
    public Transform hitPosition;       
    public float ballSpeed = 5f;        
    public float hitInterval = 10f;     

    void Start()
    {
        StartCoroutine(HitGolfBalls());
    }

    IEnumerator HitGolfBalls()
    {
        while (true)  
        {
            HitGolfBall();            
            yield return new WaitForSeconds(hitInterval);  
        }
    }

void HitGolfBall()
{
    GameObject newGolfBall = Instantiate(golfBallPrefab, hitPosition.position, Quaternion.identity);

    Rigidbody2D rb = newGolfBall.GetComponent<Rigidbody2D>();
    if (rb != null)
    {
        float randomSpeed = Random.Range(2f, 20f); 

        float randomAngle = Random.Range(-20f, 20f); 

        float angleInRadians = randomAngle * Mathf.Deg2Rad;

        float forceX = Mathf.Cos(angleInRadians) * randomSpeed;
        float forceY = Mathf.Sin(angleInRadians) * randomSpeed;

        rb.AddForce(new Vector2(forceX, forceY), ForceMode2D.Impulse);
    }
}

}
