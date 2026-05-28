using UnityEngine;

public class SpriteCharacterController : MonoBehaviour
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

    [Header("Array SpriteRender")]
    [SerializeField]
    private SpriteRenderer[] spriteRenderers;

    [Header("Array Sprite")]
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

    private void Update()
    {
        spriteRenderers[2].sprite = _tearsSprites[_tearsSpriteIndex];

        spriteRenderers[3].sprite = _mouthSprites[_mouthSpriteIndex];

        spriteRenderers[4].sprite = _graphicSprites[_graphicSpriteIndex];

        spriteRenderers[6].sprite = _eyedilsSprites[_eyedilsSpriteIndex];

        spriteRenderers[7].sprite = _pupilSprites[_pupilSpriteIndex];

        spriteRenderers[8].sprite = _eyebrowsSprites[_eyebrowsSpriteIndex];

        spriteRenderers[9].sprite = _cheeksSprites[_cheeksSpriteIndex];
    }

    // =========================
    // RECIBIR DATOS DEL CHARACTER SO
    // =========================

    public void ApplyCharacter(CharacterSO character)
    {
        if (character == null)
        {
            Debug.LogError("CharacterSO NULL");
            return;
        }

        _tearsSpriteIndex = character.tearsIndex;

        _mouthSpriteIndex = character.mouthIndex;

        _graphicSpriteIndex = character.graphicIndex;

        _eyedilsSpriteIndex = character.eyedilsIndex;

        _pupilSpriteIndex = character.pupilIndex;

        _eyebrowsSpriteIndex = character.eyebrowsIndex;

        _cheeksSpriteIndex = character.cheeksIndex;
    }
}