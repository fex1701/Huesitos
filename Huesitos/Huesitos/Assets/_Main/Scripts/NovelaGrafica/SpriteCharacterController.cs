using UnityEditor.Rendering;
using UnityEngine;

public class SpriteCharacterController : MonoBehaviour
{

    [Header("Array SpriteRender")]

    [SerializeField]
    private SpriteRenderer[] spriteRenderers;

    [Header("Sprite")]

    [SerializeField]
    private Sprite _mainSprite;


    [SerializeField]
    private Sprite _hairSprite;

    [SerializeField]
    private Sprite _whiteSprite;

   



    [Header ("Array Sprite")]
    [SerializeField]
    private Sprite[] _tearsSprites;

    [SerializeField]
    private Sprite[] _mouthSprites;

    [SerializeField]
    private Sprite[] _graphicSprites;

    [SerializeField]
    private Sprite[] _eyedilsSprites;

    [SerializeField]
    private Sprite[] _pupilSprites;

    [SerializeField]
    private Sprite[] _eyebrowsSprites;

    [SerializeField]
    private Sprite[] _cheeksSprites;





    private void Start()
    {
        
    }
}
