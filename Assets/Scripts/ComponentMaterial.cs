﻿using UnityEngine;

[CreateAssetMenu(fileName = "ComponentMaterial", menuName = "Materials/Material", order = 0)]
public class ComponentMaterial : ScriptableObject
{
    public string componentMaterialName;
    public ResourceValues materialResourceValues;
    public AttributeValues materialAttributeValues;
}