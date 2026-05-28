using UnityEngine;

[CreateAssetMenu(
    fileName = "New Visual Novel Node",
    menuName = "Visual Novel/Node"
)]
public class VisualNovelNodeSO : ScriptableObject
{
    [Header("Texto principal")]
    [TextArea(3, 8)]
    public string sceneText;

    // =========================
    // PERSONAJE IZQUIERDO
    // =========================

    [Header("Left Character")]
    public bool useLeftCharacter;

    public CharacterSO leftCharacterExpression;

    // =========================
    // PERSONAJE DERECHO
    // =========================

    [Header("Right Character")]
    public bool useRightCharacter;

    public CharacterSO rightCharacterExpression;

    // =========================
    // CHOICES
    // =========================

    [Header("Choices")]
    public Choice[] choices;
}