using TMPro;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Llave : MonoBehaviour
{
   [SerializeField] private Collider2D puerta;
   [SerializeField] private TMP_Text LlaveText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LlaveText.text = "Llave Obtenida";
            puerta.isTrigger = true;

            Destroy(this.gameObject);


  
        }
}   }