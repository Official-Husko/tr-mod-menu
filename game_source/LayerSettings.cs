using System;

[Serializable]
public struct LayerSettings
{
	public CharacterLayer layer;

	public bool selectable;

	public CharacterMaterial[] materials;

	public CharacterSprite sameColor;

	public CharacterLayer sameColorLayer;
}
