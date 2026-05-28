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

    // BACKGROUND
    public int backgroundIndex;

    // LEFT CHARACTER
    public bool useLeftCharacter;

    public CharacterSO leftCharacterExpression;

    // RIGHT CHARACTER
    public bool useRightCharacter;

    public CharacterSO rightCharacterExpression;

    // CHOICES
    public Choice[] choices;
}