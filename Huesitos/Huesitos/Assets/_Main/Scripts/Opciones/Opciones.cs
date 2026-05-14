using UnityEngine;
using static UnityEditor.Rendering.MaterialUpgrader;

public class Opciones : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text Dialogotexto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EstadosDelJuego(int numero)
    {
        switch (numero)
        {
            case 0:
                Dialogotexto.text = "No responde nada, se mantiene asustado";
                break;
            case 1:
                Dialogotexto.text = "A pesar de estar asustado, queda confundido y te mantiene observando";
                break;
            case 2:
                Dialogotexto.text = "Se asusta mas y se hecha a correr";
                break;

            case 3:
                Dialogotexto.text = "Sostiene una roca y se prepara para atacarte";
                break;








        }
    }
}
