using UnityEngine;

public class BallCollector: MonoBehaviour
{
   public int ballsCollected = 0;

   void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.CompareTag("Golf Ball"))
      {
         ballsCollected++;
         Destroy(other.gameObject);
         Debug.Log("Balls Collected: " + ballsCollected);
      }
   } 
}
