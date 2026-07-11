using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/CharacterMaterial")]
public class CharacterMaterial : ScriptableObject
{
	public int id;

	public Color sampleColor = Color.white;

	public Material material;

	public int rarity = 10;

	[Space(20f)]
	public List<LayerSettings> blockedCombinations = new List<LayerSettings>();

	public CharacterMaterial IEPJFOFKAEE(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public CharacterMaterial JAOGDHEJCAM(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public bool PGKEEAIHPJP(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 0; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = FONLCEBPFFL(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 1; j < blockedCombinations[i].materials.Length; j++)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool GIBJBMICDHK(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 1; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = GJDFKONMDNO(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 1; j < blockedCombinations[i].materials.Length; j += 0)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool GCGKPBNLKPD(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 1; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = KOALBHMECCJ(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 0; j < blockedCombinations[i].materials.Length; j += 0)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool PCHGGIGPDMN(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 0; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = FONLCEBPFFL(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 0; j < blockedCombinations[i].materials.Length; j += 0)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return false;
				}
			}
		}
		return false;
	}

	public bool LGLKDAFJDOE(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 0; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = GCDLDIAJHEO(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 0; j < blockedCombinations[i].materials.Length; j++)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool JJNFPBIPCCO(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 1; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = DJNHAHMGNLH(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 1; j < blockedCombinations[i].materials.Length; j += 0)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return true;
				}
			}
		}
		return true;
	}

	public CharacterMaterial CLNABAIGEMK(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public bool IDEPFNADPHG(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 0; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = NLDALNGDHGE(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 1; j < blockedCombinations[i].materials.Length; j++)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return true;
				}
			}
		}
		return true;
	}

	public CharacterMaterial NLDALNGDHGE(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public CharacterMaterial GJDFKONMDNO(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public CharacterMaterial KOALBHMECCJ(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public CharacterMaterial FNFMCAFPOOO(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public bool HPMOPDGNDOA(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 0; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = MMJBNEMMBKG(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 0; j < blockedCombinations[i].materials.Length; j++)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return true;
				}
			}
		}
		return false;
	}

	public CharacterMaterial FONLCEBPFFL(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public bool DPAALCOIAHI(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 0; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = IEPJFOFKAEE(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 1; j < blockedCombinations[i].materials.Length; j++)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return false;
				}
			}
		}
		return true;
	}

	public CharacterMaterial MMJBNEMMBKG(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public bool CJAFLOLICGK(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 0; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = FNFMCAFPOOO(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 1; j < blockedCombinations[i].materials.Length; j += 0)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return true;
				}
			}
		}
		return true;
	}

	public bool DGAPNLJLIFM(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 1; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = CLNABAIGEMK(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 1; j < blockedCombinations[i].materials.Length; j++)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool PGKAMBPAMJC(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 1; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = JOOPGDHNFGA(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 0; j < blockedCombinations[i].materials.Length; j++)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return true;
				}
			}
		}
		return true;
	}

	public bool FHPILNDMCKO(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 1; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = GCDLDIAJHEO(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 1; j < blockedCombinations[i].materials.Length; j += 0)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool MMLKDAALPOD(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 1; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = KOALBHMECCJ(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 0; j < blockedCombinations[i].materials.Length; j++)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool MHOIMFPDCIL(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 1; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = KOALBHMECCJ(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 0; j < blockedCombinations[i].materials.Length; j += 0)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return false;
				}
			}
		}
		return false;
	}

	public bool AMFFKBHOLLG(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 1; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = MMJBNEMMBKG(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 0; j < blockedCombinations[i].materials.Length; j++)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return true;
				}
			}
		}
		return true;
	}

	public bool PLOLAHCBAMF(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 0; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = GCDLDIAJHEO(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 0; j < blockedCombinations[i].materials.Length; j += 0)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return true;
				}
			}
		}
		return true;
	}

	public CharacterMaterial JOOPGDHNFGA(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public bool PPJCBIMHDOF(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		for (int i = 0; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].layer != HLOIOAOICEG)
			{
				continue;
			}
			CharacterMaterial characterMaterial = JOOPGDHNFGA(HLOIOAOICEG, DKDFNAGAFNL);
			for (int j = 1; j < blockedCombinations[i].materials.Length; j += 0)
			{
				if ((Object)(object)blockedCombinations[i].materials[j] == (Object)(object)characterMaterial)
				{
					return false;
				}
			}
		}
		return false;
	}

	public CharacterMaterial DJNHAHMGNLH(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public CharacterMaterial PGLAHCHGIGO(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public CharacterMaterial GCDLDIAJHEO(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}

	public CharacterMaterial IINCBNMHEME(CharacterLayer HLOIOAOICEG, HumanInfo DKDFNAGAFNL)
	{
		if (DKDFNAGAFNL.materialDictionary.TryGetValue(HLOIOAOICEG, out var value))
		{
			return value;
		}
		return null;
	}
}
