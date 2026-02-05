using UnityEngine;

public class Coin : MonoBehaviour
{

    private CoinManager manager;

    private void Start()
    {

        manager = FindFirstObjectByType<CoinManager>();


    }

    private void OnTriggerEnter2D(Collider2D other){


        if (other.CompareTag("Player")){

            manager?.AddCoin();

            Destroy(gameObject);

        }


    }
    
}
