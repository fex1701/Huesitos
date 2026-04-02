using UnityEngine;
public class Daño : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private int _Damage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.RestarVida(_Damage);
        }

    }


}