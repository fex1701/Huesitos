using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Huesitos : MonoBehaviour
{
    [SerializeField] private int _Huesitos = 0;
    [SerializeField] public int Puntos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Puntos += _Huesitos;
            Debug.Log("+1");
            Destroy(this.gameObject);

            }
        }
}
    
