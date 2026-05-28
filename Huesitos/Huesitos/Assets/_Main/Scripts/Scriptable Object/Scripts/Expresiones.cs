using UnityEngine;

[CreateAssetMenu(
    fileName = "New Character",
    menuName = "Visual Novel/Character"
)]
public class CharacterSO : ScriptableObject
{
    [Header("Expresiones")]

    public int tearsIndex;

    public int mouthIndex;

    public int graphicIndex;

    public int eyedilsIndex;

    public int pupilIndex;

    public int eyebrowsIndex;

    public int cheeksIndex;
}