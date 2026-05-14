using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]

    private int _tearsSpriteIndex;

    [SerializeField]
    private int _mouthSpriteIndex;

    [SerializeField]

    private int _graphicSpriteIndex;

    [SerializeField]

    private int _eyedilsSpriteIndex;


    [SerializeField]

    private int _pupilSpriteIndex;

    [SerializeField]

    private int _eyebrowsSpriteIndex;

    [SerializeField]

    private int _cheeksSpriteIndex;

    [SerializeField]
    private int _whiteSpriteIndex;








    [Header("Array SpriteRender")]

    [SerializeField]
    private SpriteRenderer[] spriteRenderers;

    [Header("Sprite")]

    [SerializeField]
    private Sprite _mainSprite;


    [SerializeField]
    private Sprite _hairSprite;





    [Header("Array Sprite")]


    [SerializeField]
    private Sprite[] _whiteSprites;

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

    private void Update()
    {


        spriteRenderers[2].sprite = _tearsSprites[_tearsSpriteIndex];
        spriteRenderers[3].sprite = _mouthSprites[_mouthSpriteIndex];
        spriteRenderers[4].sprite = _graphicSprites[_graphicSpriteIndex];
        spriteRenderers[5].sprite = _eyedilsSprites[_eyedilsSpriteIndex];
        spriteRenderers[6].sprite = _pupilSprites[_pupilSpriteIndex];
        spriteRenderers[7].sprite = _whiteSprites[_whiteSpriteIndex];
        spriteRenderers[8].sprite = _cheeksSprites[_cheeksSpriteIndex];
        spriteRenderers[9].sprite = _eyebrowsSprites[_eyebrowsSpriteIndex];






    }

}
