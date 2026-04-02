using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    [SerializeField] private Text _textocontador;
    [SerializeField] private int Minutos;
    [SerializeField] private float Segundos;

    private void Start()
    {
        ActualizarContador();
    }

    private void FixedUpdate()
    {
        Segundos += Time.deltaTime;

        if (Segundos >= 60)
        {
            Segundos = 0;
            Minutos += 1;
        }

        ActualizarContador();
    }
    private void ActualizarContador()
    {
        if (Segundos < 9.5f)
        {
            _textocontador.text = Minutos.ToString() + ":0" + Segundos.ToString("f0");

        }

        else
        {
            _textocontador.text = Minutos.ToString() + ":" + Segundos.ToString("f0");
        }
    }
}