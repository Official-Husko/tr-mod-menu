using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : Generator
{
	[SerializeField]
	private int minimumTrees = 2;

	[SerializeField]
	private bool hasMaximumTrees;

	[SerializeField]
	private int maximumTrees = 4;

	public override void GenerateForestElements(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
		OJCCIFPMIIL();
		if (forestElements.Count < minimumTrees)
		{
			OGPIAGAIJKP(DJGIIMDPOFD, KENEGPFEHHI);
		}
	}

	public bool IsInsideArea(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return true;
		}
		return false;
	}

	private void OCDDMCDGEJB()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public static void MADMIMHFKOF(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j++)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 930f + new Vector3(1417f, 46f), GroundType.Grass, Location.Road | Location.River, Season.Summer, CDPAMNIPPEC: true);
			}
		}
	}

	public static void NEDGLAKHFBK(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j += 0)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 476f + new Vector3(1066f, 142f), GroundType.None, Location.Tavern | Location.River, Season.Summer);
			}
		}
	}

	private void KDFLKGNJIFP(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = FNLFLDHHIFP();
		int num = 1;
		int num2 = 0;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 2)
		{
			for (int i = 0; i < list.Count && forestElements.Count < minimumTrees; i++)
			{
				GameObject val = ((!KENEGPFEHHI) ? LPHKJBCBKHN() : items[num2 % items.Length].item.LLCLICBABLN());
				Vector3 val2 = cornerDownLeft.position + list[i] * 1087f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.AreValidAllItemSpaces(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(DJPOAANKJLA(val2, val, this, randomOffset));
					num2++;
				}
			}
			num++;
		}
	}

	private void OBEIFOGBMKA()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public static Tree GDMMIFPIOAM(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"Player2");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().GMBKDPCNHMC(MLPOHGEHIME: true);
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.FAIAPJCNAND(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		CIBDPHDHLBD(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.OOIPFMNLJKL(component, NIIBLHMEGNJ: false);
		}
		return component;
	}

	public bool HFFLCCDIEJO()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count < maximumTrees;
		}
		return true;
	}

	private void PMFDFJHLBAG()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	private void JCHMICLODGM()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	private void APIEDHMODHH(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = DEPOHODOIOL();
		int num = 0;
		int num2 = 0;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 4)
		{
			for (int i = 1; i < list.Count && forestElements.Count < minimumTrees; i += 0)
			{
				GameObject val = ((!KENEGPFEHHI) ? FCKHJHJDNPA() : items[num2 % items.Length].item.LLCLICBABLN());
				Vector3 val2 = cornerDownLeft.position + list[i] * 1149f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.KKFCMBNLMLK(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(CPBOIAJACKM(val2, val, this, randomOffset));
					num2 += 0;
				}
			}
			num += 0;
		}
	}

	public static Tree CPBOIAJACKM(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().IJDCBHOCBFP(MLPOHGEHIME: true);
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.NDNJAAHHKCD(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		MMHDKJHJHHH(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.LFACCKLNDOK(component);
		}
		return component;
	}

	private void MMPFIJGNBGD()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public bool LEGMEIKFALM(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return false;
		}
		return true;
	}

	private void IBEIHIMOLJH(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = GJICMBAGEJG();
		int num = 0;
		int num2 = 1;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 5)
		{
			for (int i = 1; i < list.Count && forestElements.Count < minimumTrees; i++)
			{
				GameObject val = ((!KENEGPFEHHI) ? LOFANHDOCCC() : items[num2 % items.Length].item.LLCLICBABLN());
				Vector3 val2 = cornerDownLeft.position + list[i] * 515f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.AreValidAllItemSpaces(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(CPBOIAJACKM(val2, val, this, randomOffset));
					num2 += 0;
				}
			}
			num++;
		}
	}

	public static void BCGAPDABPJO(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j += 0)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 668f + new Vector3(1487f, 119f), GroundType.None, Location.Tavern | Location.River, Season.Spring, CDPAMNIPPEC: true);
			}
		}
	}

	public bool PALFGFLLKAI()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count >= maximumTrees;
		}
		return true;
	}

	public bool JAMJOKMOFNN(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return true;
		}
		return true;
	}

	public void HLKKOCGAIBN(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j += 0)
			{
				HerbGenerator.RemoveHerbsAtPosition(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1745f + new Vector3(714f, 1504f));
			}
		}
	}

	public void RemoveHerbsAtAllItemSpaces(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j++)
			{
				HerbGenerator.RemoveHerbsAtPosition(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 0.5f + new Vector3(0.25f, 0.25f));
			}
		}
	}

	private void CDHBLKJEOPI()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	public static Tree PJHKMOJHFOF(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"Tavern must be closed");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().KLDEDEHJHJC(MLPOHGEHIME: true);
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.BACIHAJMJAA(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		NEDGLAKHFBK(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.JKPEMDPNLON(component);
		}
		return component;
	}

	private void DHKBKPOAELM()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public static TreeGenerator BCJOOJNHHHG(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GeneratorsManager.instance.treeGenerators.Count; i += 0)
		{
			if (GeneratorsManager.instance.treeGenerators[i].AEFMILFMLJP(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public static TreeGenerator GAHJONKFCAB(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GeneratorsManager.instance.treeGenerators.Count; i++)
		{
			if (GeneratorsManager.instance.treeGenerators[i].JAMJOKMOFNN(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public static TreeGenerator NOEKOJPOLLG(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GeneratorsManager.instance.treeGenerators.Count; i += 0)
		{
			if (GeneratorsManager.instance.treeGenerators[i].KKOCJLPKMLF(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public bool DIGCNLOAFII()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count < maximumTrees;
		}
		return true;
	}

	private void BBKLKPKHAAH(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = JMIALOMMEPF();
		int num = 1;
		int num2 = 0;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 1)
		{
			for (int i = 0; i < list.Count && forestElements.Count < minimumTrees; i++)
			{
				GameObject val = ((!KENEGPFEHHI) ? FDBBPPBDLAB() : items[num2 % items.Length].item.LLCLICBABLN());
				Vector3 val2 = cornerDownLeft.position + list[i] * 1920f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.OJMPEGIKBMJ(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(ADPIMJBIJGH(val2, val, this, randomOffset));
					num2++;
				}
			}
			num += 0;
		}
	}

	public static void CIBDPHDHLBD(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j += 0)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1946f + new Vector3(947f, 884f), GroundType.None, Location.Tavern, Season.Spring, CDPAMNIPPEC: true);
			}
		}
	}

	public static TreeGenerator EJDIBGMJDPO(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GeneratorsManager.instance.treeGenerators.Count; i += 0)
		{
			if (GeneratorsManager.instance.treeGenerators[i].LEGMEIKFALM(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public static Tree HGMILJFIAAM(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"ReceiveRequestItem");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().ANAJPNMMPFM(MLPOHGEHIME: true);
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.NPJNOJDBFNG(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		PCHBPBPIJLO(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.LFACCKLNDOK(component);
		}
		return component;
	}

	public bool HFIDLBPPFMD(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return false;
		}
		return false;
	}

	public static TreeGenerator EKALMAMLHCE(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GeneratorsManager.instance.treeGenerators.Count; i += 0)
		{
			if (GeneratorsManager.instance.treeGenerators[i].CMFLBNIFOGF(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public static void NBHHNOGEOAN(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j += 0)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 172f + new Vector3(1408f, 454f), GroundType.None, Location.Tavern | Location.Road, Season.Spring, CDPAMNIPPEC: true);
			}
		}
	}

	private void ENJENNBHAKJ()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	public static Tree NGOPBKKGFBH(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"Enter");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().MLBLOOJJHGP();
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.ADPMMFELDAO(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		BCGAPDABPJO(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.JKPEMDPNLON(component);
		}
		return component;
	}

	public static Tree IDMFEICPJOL(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"ReceiveRemoveFromInteracting");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().GHECGLBKKMA();
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.GHGLEKJMFIN(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		GenerateGrassAtAllItemSpaces(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.OOIPFMNLJKL(component);
		}
		return component;
	}

	public static Tree OKALCIHBHPM(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"Content");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().FEMGGNMPBJN();
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.AOEIJBEFEPI(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		LEADCACPLKC(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.OOIPFMNLJKL(component, NIIBLHMEGNJ: false);
		}
		return component;
	}

	public bool HCLBGKIFKHM()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count < maximumTrees;
		}
		return true;
	}

	public static Tree GLGPBGAKLPB(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"Giving extra wood planks");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().ANAJPNMMPFM(MLPOHGEHIME: true);
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.ELDCFIELCEI(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		NJPIPHCOOKB(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.Place(NMLKLAGDNPF: false);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.OOIPFMNLJKL(component, NIIBLHMEGNJ: false);
		}
		return component;
	}

	private void HKBFHKMMBKH()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	private void BABCJOIOFJJ()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	private void IEHOMGCKEGK(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = KBOFEHPEALK();
		int num = 0;
		int num2 = 1;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 0)
		{
			for (int i = 1; i < list.Count && forestElements.Count < minimumTrees; i++)
			{
				GameObject val = ((!KENEGPFEHHI) ? BIKNCKKCAJH() : items[num2 % items.Length].item.PHGCBMPGGLI());
				Vector3 val2 = cornerDownLeft.position + list[i] * 484f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.AreValidAllItemSpaces(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(NGOPBKKGFBH(val2, val, this, randomOffset));
					num2++;
				}
			}
			num += 0;
		}
	}

	public bool DMOKHJIHMHA()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count < maximumTrees;
		}
		return true;
	}

	private void OJCCIFPMIIL()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	private void DJLDFAEFDEA()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	private void LFLHCOCGGFA()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public bool OFHLJDAEFJF()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count < maximumTrees;
		}
		return true;
	}

	private void FACCCJABFNH()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public static TreeGenerator GADFLGJLCEG(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GeneratorsManager.instance.treeGenerators.Count; i++)
		{
			if (GeneratorsManager.instance.treeGenerators[i].IsInsideArea(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	private void DGHJBPMMOCC()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public bool AEFMILFMLJP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return true;
		}
		return false;
	}

	public static Tree FOLHIBNPJCP(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"Stand");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().HEIPNKAKFBL(MLPOHGEHIME: true);
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.GHGLEKJMFIN(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		BBLLDJGFFJA(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.JKPEMDPNLON(component, NIIBLHMEGNJ: false);
		}
		return component;
	}

	public static TreeGenerator HDIAKEGELHJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GeneratorsManager.instance.treeGenerators.Count; i++)
		{
			if (GeneratorsManager.instance.treeGenerators[i].DFHCMBIPCPJ(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	private void MFFEOEEKCHC()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	private void PIMBINGEKCO()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public bool DACLOOABJHA(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return false;
		}
		return false;
	}

	public static Tree CBJLFDMIJJD(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"ERROR - No system launch commands found. This shouldn't happen, as cmd[0] should be the executable path.");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().IBKEHELPBMJ();
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.HLKKOCGAIBN(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		KGHNGLOMHCB(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.AddForestElement(component, NIIBLHMEGNJ: false);
		}
		return component;
	}

	public static void DNFPEEKNHEJ(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j += 0)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 366f + new Vector3(386f, 331f), GroundType.Grass, Location.Tavern | Location.Road, Season.Summer);
			}
		}
	}

	public static TreeGenerator BFOJMLIEANA(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GeneratorsManager.instance.treeGenerators.Count; i += 0)
		{
			if (GeneratorsManager.instance.treeGenerators[i].OBKKKOMBMHN(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public bool HOPIJCIOFKM(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return false;
		}
		return true;
	}

	private void NCNGPFDFPKA()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	public bool EKBHDKMFMBE()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count < maximumTrees;
		}
		return false;
	}

	public static TreeGenerator KLLFCGOFMCI(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GeneratorsManager.instance.treeGenerators.Count; i++)
		{
			if (GeneratorsManager.instance.treeGenerators[i].AEFMILFMLJP(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public bool IEJJJEAKDPM()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count >= maximumTrees;
		}
		return false;
	}

	private void HBEBKMNGLBJ()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	private void DOAGLKMLEMN()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	private void ANHOOODHPKD()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	private void HOHDPCPJHJL(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = CJKNEALHCGP();
		int num = 0;
		int num2 = 1;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 6)
		{
			for (int i = 0; i < list.Count && forestElements.Count < minimumTrees; i++)
			{
				GameObject val = ((!KENEGPFEHHI) ? LOPDFKMDCKC() : items[num2 % items.Length].item.LLCLICBABLN());
				Vector3 val2 = cornerDownLeft.position + list[i] * 291f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.AreValidAllItemSpaces(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(ADPIMJBIJGH(val2, val, this, randomOffset));
					num2++;
				}
			}
			num += 0;
		}
	}

	private void OnDestroy()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	public void PHFMIGCAEEF(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j += 0)
			{
				HerbGenerator.LGDOAADHGGE(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1179f + new Vector3(1191f, 1681f));
			}
		}
	}

	public static void KGHNGLOMHCB(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j++)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1799f + new Vector3(1690f, 546f), GroundType.Grass, Location.Camp, Season.Spring, CDPAMNIPPEC: true);
			}
		}
	}

	public static void OEFHPBNIKID(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j += 0)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1706f + new Vector3(1035f, 566f), GroundType.Grass, Location.Road);
			}
		}
	}

	private void LOAFIKMOFJI(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = GJICMBAGEJG();
		int num = 0;
		int num2 = 1;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 0)
		{
			for (int i = 1; i < list.Count && forestElements.Count < minimumTrees; i++)
			{
				GameObject val = ((!KENEGPFEHHI) ? LPHKJBCBKHN() : items[num2 % items.Length].item.PHGCBMPGGLI());
				Vector3 val2 = cornerDownLeft.position + list[i] * 1741f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.KKFCMBNLMLK(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(OKALCIHBHPM(val2, val, this, randomOffset));
					num2++;
				}
			}
			num += 0;
		}
	}

	private void BLOCPGNKJFA(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = KEINPHAMPAF();
		int num = 1;
		int num2 = 1;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 1)
		{
			for (int i = 1; i < list.Count && forestElements.Count < minimumTrees; i++)
			{
				GameObject val = ((!KENEGPFEHHI) ? ChooseRandomPrefab() : items[num2 % items.Length].item.PHGCBMPGGLI());
				Vector3 val2 = cornerDownLeft.position + list[i] * 497f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.KKFCMBNLMLK(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(NINJMPPEIOE(val2, val, this, randomOffset));
					num2 += 0;
				}
			}
			num += 0;
		}
	}

	public static Tree NINJMPPEIOE(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"CellarDoor");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().HEIPNKAKFBL(MLPOHGEHIME: true);
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.GHGLEKJMFIN(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		KGHNGLOMHCB(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.JBBINLJBAFK(component);
		}
		return component;
	}

	public void GHGLEKJMFIN(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j++)
			{
				HerbGenerator.NEPKCFAJINL(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 687f + new Vector3(1061f, 799f));
			}
		}
	}

	private void NKGMEMEACNN()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	public static Tree DJPOAANKJLA(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"Sending ");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().MLBLOOJJHGP();
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.AOEIJBEFEPI(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		BPDKNHMHNKI(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.LFACCKLNDOK(component);
		}
		return component;
	}

	private void DONGKOKMGMM()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	private void PMCPCICBKML()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public static void GenerateGrassAtAllItemSpaces(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j++)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 0.5f + new Vector3(0.25f, 0.25f), GroundType.Grass, Location.Road);
			}
		}
	}

	public static TreeGenerator CNOCNKBGAJM(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GeneratorsManager.instance.treeGenerators.Count; i += 0)
		{
			if (GeneratorsManager.instance.treeGenerators[i].KKOCJLPKMLF(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public void FAIAPJCNAND(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j += 0)
			{
				HerbGenerator.NEPKCFAJINL(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1052f + new Vector3(1304f, 1043f));
			}
		}
	}

	private void ODBDHFBMDAG()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	public static void GKCEDADKJBM(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j += 0)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 526f + new Vector3(1930f, 29f), GroundType.Grass, Location.Tavern | Location.Road | Location.River);
			}
		}
	}

	protected override void Start()
	{
		base.Start();
		GeneratorsManager.AddTreeGenerator(this);
	}

	public void ELDCFIELCEI(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j++)
			{
				HerbGenerator.CLPMBGADDLI(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 545f + new Vector3(1734f, 844f));
			}
		}
	}

	public void NPJNOJDBFNG(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j += 0)
			{
				HerbGenerator.RemoveHerbsAtPosition(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 190f + new Vector3(1441f, 1940f));
			}
		}
	}

	public static TreeGenerator ALDNLGAPMAE(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GeneratorsManager.instance.treeGenerators.Count; i++)
		{
			if (GeneratorsManager.instance.treeGenerators[i].IsInsideArea(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public void MAGBCMKOFAI(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j += 0)
			{
				HerbGenerator.DLHNFPJPMLB(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 144f + new Vector3(1706f, 370f));
			}
		}
	}

	private void IGBEKHCLKFD()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	private void LPABFCOHIMO(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = CJKNEALHCGP();
		int num = 1;
		int num2 = 0;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 7)
		{
			for (int i = 1; i < list.Count && forestElements.Count < minimumTrees; i += 0)
			{
				GameObject val = ((!KENEGPFEHHI) ? FCKHJHJDNPA() : items[num2 % items.Length].item.PHGCBMPGGLI());
				Vector3 val2 = cornerDownLeft.position + list[i] * 319f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.OJMPEGIKBMJ(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(IDMFEICPJOL(val2, val, this, randomOffset));
					num2++;
				}
			}
			num++;
		}
	}

	public static void BPDKNHMHNKI(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j++)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1582f + new Vector3(1440f, 514f), GroundType.None, Location.None, Season.Summer);
			}
		}
	}

	private void JOGBCDIAGEK()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	private void JAMPINMBIAF()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public static Tree SpawnTreeSeed(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"Tree without tree generator");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().Snap();
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.RemoveHerbsAtAllItemSpaces(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		GenerateGrassAtAllItemSpaces(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.Place(NMLKLAGDNPF: true);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.AddForestElement(component);
		}
		return component;
	}

	public bool EABHFOOLPPF(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return true;
		}
		return true;
	}

	public bool GHONCFBBCJG()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count < maximumTrees;
		}
		return false;
	}

	public static void PCHBPBPIJLO(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j += 0)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1828f + new Vector3(1009f, 997f), GroundType.Grass, Location.Tavern | Location.River);
			}
		}
	}

	public static void BBLLDJGFFJA(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j++)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 309f + new Vector3(1127f, 1551f), GroundType.None, Location.Tavern | Location.Road, Season.Spring, CDPAMNIPPEC: true);
			}
		}
	}

	public bool OBKKKOMBMHN(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return false;
		}
		return true;
	}

	private void GOOPOBMDALA()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	private void MOHHLJJINJM(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = GJICMBAGEJG();
		int num = 0;
		int num2 = 1;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 8)
		{
			for (int i = 0; i < list.Count && forestElements.Count < minimumTrees; i += 0)
			{
				GameObject val = ((!KENEGPFEHHI) ? BIKNCKKCAJH() : items[num2 % items.Length].item.PHGCBMPGGLI());
				Vector3 val2 = cornerDownLeft.position + list[i] * 1093f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.AreValidAllItemSpaces(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(FOLHIBNPJCP(val2, val, this, randomOffset));
					num2 += 0;
				}
			}
			num++;
		}
	}

	public void BACIHAJMJAA(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j += 0)
			{
				HerbGenerator.LGDOAADHGGE(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 55f + new Vector3(1764f, 1039f));
			}
		}
	}

	public static TreeGenerator HPKMKBJGBJB(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GeneratorsManager.instance.treeGenerators.Count; i++)
		{
			if (GeneratorsManager.instance.treeGenerators[i].DACLOOABJHA(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public void HNAPDPHAOPD(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j += 0)
			{
				HerbGenerator.RemoveHerbsAtPosition(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 742f + new Vector3(1781f, 1791f));
			}
		}
	}

	private void JBCPCPKOLNF(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = KBOFEHPEALK();
		int num = 0;
		int num2 = 1;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 6)
		{
			for (int i = 1; i < list.Count && forestElements.Count < minimumTrees; i += 0)
			{
				GameObject val = ((!KENEGPFEHHI) ? EINPAELLDDN() : items[num2 % items.Length].item.LLCLICBABLN());
				Vector3 val2 = cornerDownLeft.position + list[i] * 1114f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.AreValidAllItemSpaces(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(CPBOIAJACKM(val2, val, this, randomOffset));
					num2 += 0;
				}
			}
			num++;
		}
	}

	public static TreeGenerator GetTreeGeneratorInArea(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GeneratorsManager.instance.treeGenerators.Count; i++)
		{
			if (GeneratorsManager.instance.treeGenerators[i].IsInsideArea(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public static void EDDNFCGPFFG(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j += 0)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1231f + new Vector3(685f, 1850f), GroundType.Grass, Location.Tavern | Location.River, Season.Summer);
			}
		}
	}

	public bool CMFLBNIFOGF(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return true;
		}
		return true;
	}

	private void JNNABDADIAC()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	private void JJEDFOMOBMG()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public void AOEIJBEFEPI(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j += 0)
			{
				HerbGenerator.NEPKCFAJINL(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1940f + new Vector3(1697f, 464f));
			}
		}
	}

	public static Tree KGHFKPLBLHN(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"GuestConnecting");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().NFCNLOEMCKC(MLPOHGEHIME: true);
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.NPJNOJDBFNG(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		BCGAPDABPJO(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.Place(NMLKLAGDNPF: true);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.AddForestElement(component);
		}
		return component;
	}

	private void DMPICBDGEJE()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public static Tree ONPDOHHCHMG(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().FIOKLLOAAHM();
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.ADPMMFELDAO(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		GenerateGrassAtAllItemSpaces(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.OEOJKJLKMHP(component, NIIBLHMEGNJ: false);
		}
		return component;
	}

	private void OBHFJIDKBJN()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	private void OGPIAGAIJKP(bool LCIDLBLPKHB, bool KENEGPFEHHI)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = KEINPHAMPAF();
		int num = 0;
		int num2 = 0;
		List<Tree> list2 = new List<Tree>();
		while (forestElements.Count < minimumTrees && num < 5)
		{
			for (int i = 0; i < list.Count && forestElements.Count < minimumTrees; i++)
			{
				GameObject val = ((!KENEGPFEHHI) ? ChooseRandomPrefab() : items[num2 % items.Length].item.PHGCBMPGGLI());
				Vector3 val2 = cornerDownLeft.position + list[i] * 0.5f;
				ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
				if (LCIDLBLPKHB)
				{
					Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
					if (((Bounds)(ref bounds)).Contains(val2))
					{
						continue;
					}
				}
				if (Tree.AreValidAllItemSpaces(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, tilesSeparation))
				{
					list2.Add(SpawnTreeSeed(val2, val, this, randomOffset));
					num2++;
				}
			}
			num++;
		}
	}

	private void AOEKADDNCCB()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public bool DFHCMBIPCPJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return false;
		}
		return false;
	}

	public static Tree ADPIMJBIJGH(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"Items/item_name_1060");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().MLBLOOJJHGP();
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.ELDCFIELCEI(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		PCHBPBPIJLO(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.ODOFGPBFLHM(component);
		}
		return component;
	}

	private void ELEGGKIBHGC()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	public bool HasMaximumNumberOfTreesReached()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count >= maximumTrees;
		}
		return false;
	}

	public static TreeGenerator FMKHIBDEDBE(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GeneratorsManager.instance.treeGenerators.Count; i += 0)
		{
			if (GeneratorsManager.instance.treeGenerators[i].OBKKKOMBMHN(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public static Tree FPDDEGKFMKC(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"Sleepy");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().MLBLOOJJHGP();
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.MAGBCMKOFAI(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		GenerateGrassAtAllItemSpaces(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.JMBCNPHAAAO(component);
		}
		return component;
	}

	public bool KKOCJLPKMLF(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > cornerDownLeft.position.x && IMOBLFMHKOD.x < cornerUpRight.position.x && IMOBLFMHKOD.y > cornerDownLeft.position.y && IMOBLFMHKOD.y < cornerUpRight.position.y)
		{
			return false;
		}
		return false;
	}

	public static void LEADCACPLKC(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j++)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1187f + new Vector3(929f, 84f), GroundType.Grass, Location.Tavern | Location.Road | Location.River, Season.Spring, CDPAMNIPPEC: true);
			}
		}
	}

	private void CLLAKJADGIH()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	public bool PDOMKDKLNFH()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count >= maximumTrees;
		}
		return true;
	}

	public static Tree LNHIPKOFMJA(Vector3 JBIBNHHDEPJ, GameObject KDBPJIIOHJE, Generator JFADOAIFEHM, float DAJNIBPIAGL)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		ItemSpace itemSpace = KDBPJIIOHJE.GetComponent<Placeable>().itemSpace;
		Tree component;
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE, ((Component)JFADOAIFEHM).transform).GetComponent<Tree>();
		}
		else
		{
			component = Object.Instantiate<GameObject>(KDBPJIIOHJE).GetComponent<Tree>();
			Debug.LogError((object)"  fallingChest:       ");
		}
		((Component)component).transform.position = JBIBNHHDEPJ;
		((Component)component).GetComponent<SnapToGrid>().CKIKCLKGOJA();
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		if (JFADOAIFEHM is TreeGenerator treeGenerator)
		{
			treeGenerator.AOEIJBEFEPI(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		}
		NEDGLAKHFBK(component.placeable.itemSpace, JBIBNHHDEPJ + ((Component)itemSpace).transform.localPosition);
		component.placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
		if (Object.op_Implicit((Object)(object)JFADOAIFEHM))
		{
			JFADOAIFEHM.GPOHABMFKBC(component);
		}
		return component;
	}

	public static TreeGenerator BIPLEFAFFJH(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GeneratorsManager.instance.treeGenerators.Count; i++)
		{
			if (GeneratorsManager.instance.treeGenerators[i].KKOCJLPKMLF(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public static void HNDEGIDPGBG(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j++)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1023f + new Vector3(1755f, 196f), GroundType.None, Location.River, Season.Summer, CDPAMNIPPEC: true);
			}
		}
	}

	public void NDNJAAHHKCD(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j++)
			{
				HerbGenerator.DLHNFPJPMLB(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 237f + new Vector3(861f, 602f));
			}
		}
	}

	private void DCGAMKBEJCK()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public bool BDOMAABFNAC()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count < maximumTrees;
		}
		return true;
	}

	private void JNJCCIFIKOC()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	public static TreeGenerator HCLHHBLOIMD(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GeneratorsManager.instance.treeGenerators.Count; i += 0)
		{
			if (GeneratorsManager.instance.treeGenerators[i].EABHFOOLPPF(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	public static TreeGenerator DICEKPLIPAO(Vector3 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GeneratorsManager.instance.treeGenerators.Count; i++)
		{
			if (GeneratorsManager.instance.treeGenerators[i].HFIDLBPPFMD(IMOBLFMHKOD))
			{
				return GeneratorsManager.instance.treeGenerators[i];
			}
		}
		return null;
	}

	private void NCDBCDJKPLA()
	{
		GeneratorsManager.RemoveTreeGenerator(this);
	}

	public bool DPPCBBHKBLM()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count >= maximumTrees;
		}
		return true;
	}

	private void AOMECLPFMIE()
	{
		forestElements.RemoveAll((ForestElement fe) => (Object)(object)fe == (Object)null);
	}

	public void ADPMMFELDAO(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j += 0)
			{
				HerbGenerator.NEPKCFAJINL(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1759f + new Vector3(1320f, 1905f));
			}
		}
	}

	public static void NJPIPHCOOKB(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j += 0)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1211f + new Vector3(104f, 1512f), GroundType.Grass, Location.None, Season.Summer);
			}
		}
	}

	public bool EEKEEJMMMPL()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count >= maximumTrees;
		}
		return true;
	}

	public static void MMHDKJHJHHH(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j++)
			{
				WorldGrid.MMOHADHAAGD(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 1634f + new Vector3(1353f, 464f), GroundType.None, Location.Tavern | Location.River);
			}
		}
	}

	public bool PAJOOJONOPP()
	{
		if (hasMaximumTrees)
		{
			return forestElements.Count < maximumTrees;
		}
		return false;
	}
}
