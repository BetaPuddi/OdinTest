using UnityEngine;

[CreateAssetMenu(fileName = "AttributeValues", menuName = "Attributes and Stats/AttributeValues", order = 0)]
public class AttributeValues : ScriptableObject
{
    //Physical Attributes
    public int strengthAtt;
    public int dexterityAtt;
    public int constitutionAtt;
    //Magical Attributes
    public int intelligenceAtt;
    public int wisdomAtt;
    public int focusAtt;
    //Ethereal Attributes
    public int charismaAtt;
    public int luckAtt;
    public int mindAtt;
}