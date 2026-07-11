using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorPickerUI : UIWindow
{
	public static ColorPickerUI[] instances = new ColorPickerUI[3];

	[SerializeField]
	private GameObject panel;

	[SerializeField]
	private Image panelImage;

	[SerializeField]
	private GameObject[] advancedGameObjects;

	[SerializeField]
	private GameObject[] simpleGameObjects;

	private RectTransform GFOGBONOCIP;

	private RectTransform PGBKFNPCPDE;

	private ColorButton EKIEKAJMOON;

	public ColorButton colorButtonPrefab;

	public CharacterMaterial lastMaterial;

	public SpriteColor lastSpriteColor;

	[HideInInspector]
	public Color lastColour;

	[HideInInspector]
	public int lastButtonColour;

	public List<ColorButton> exampleColors = new List<ColorButton>();

	public ColorButton HGOLAEMONPI
	{
		get
		{
			return EKIEKAJMOON;
		}
		set
		{
			EKIEKAJMOON = value;
			CharacterMaterial[] nMNNHGLLFMD = null;
			SpriteColor[] iLCJHEDFPPO = null;
			if (EKIEKAJMOON.useCharacterMaterial)
			{
				nMNNHGLLFMD = EKIEKAJMOON.GetMaterialsAvailable(CharacterCreatorUI.Get(base.JIIGOACEIKL).characterCreator);
			}
			else
			{
				iLCJHEDFPPO = DrinkDispensersManager.GGFJGHHHEJC.GetPossibleColors();
			}
			LOMFCKAHOGJ(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
		}
	}

	public void LFIIJOMBKIL(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
	}

	[SpecialName]
	public ColorButton NDHAENIONJB()
	{
		return EKIEKAJMOON;
	}

	private void CEDPGDCOCDN(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}

	private void AHFMIOFAOAM(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i++)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	[SpecialName]
	public ColorButton KFILDGLMNJK()
	{
		return EKIEKAJMOON;
	}

	public static ColorPickerUI MDINEPBJFKG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PGFJNJLMOKK(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.IJLMMBMPALC(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.IJLMMBMPALC(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.FCKNPOACOPA(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)1;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 8)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 3].button;
				navigation2 = ((Selectable)exampleColors[i - 3].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 2].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].AIMFODMDLJD(DCPNDPLOHHL().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].NCHKDCMNDAD = i;
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].CPDDKLKOEHA(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		IDLAGJNLPJL();
		POKJOGIIMEL(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	[SpecialName]
	public ColorButton AMOJCIGDHPP()
	{
		return EKIEKAJMOON;
	}

	private void CANKMCNAPCN(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!HDEPMJIDJEM() || PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	private void KBPDNGECKJN(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 8)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 4), 38f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 100f));
	}

	private void LKGINJBGJJG(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 8)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 3), 725f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 420f));
	}

	[SpecialName]
	public void CCMADEEPPHH(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.POGJNCEMPFD(CharacterCreatorUI.PCEEOGGDBFB(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.GGFJGHHHEJC.OPMEMMGNBGD();
		}
		KIHINKBBFCL(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	[SpecialName]
	public void KKNHOJIIFNO(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.FNGPICOLLML(CharacterCreatorUI.PCEEOGGDBFB(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.OLHBLKIAFOM().LEOGLDGHECE();
		}
		HNPMDOEEOPO(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void LCNKCFOMGAP(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 3)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 0), 595f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 1944f));
	}

	private void DBPOGBJDBFI(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.AKFPBELHLNF(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.EICFBFELOPD(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.FCKNPOACOPA(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)6;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 3].button;
				navigation2 = ((Selectable)exampleColors[i - 7].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 4].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].GCJNJDPHIHM(OKIHALELCBL().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].DLPFOPBFJEN(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].FCKNPOACOPA(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(false);
		}
		IDLAGJNLPJL();
		BBDPLPMGGDI(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void DFNCOPJDLBN(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i++)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	[SpecialName]
	public void PAFLIPMEFBD(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.PMGNHJLMLBG(CharacterCreatorUI.DPBGKDNKDGM(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.JHMAMLIPBNN().OPMEMMGNBGD();
		}
		DHFCNLIJCJP(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	public static ColorPickerUI EOPIEMLAPFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void MLHLPPKJHLK(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!BGLJFMHCFJF() || PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	[SpecialName]
	public ColorButton NFAOOGPOPPA()
	{
		return EKIEKAJMOON;
	}

	private void DGBNOBNAFCD(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 3)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 8), 721f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 1861f));
	}

	private void HCPGPKACGJK(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!HDEPMJIDJEM() || PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	public static ColorPickerUI DOGBDIOJAHO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void KIHINKBBFCL(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.AKFPBELHLNF(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.NGFHDHNFAEG(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.FCKNPOACOPA(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)7;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 6].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 2].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].AMHBOHLPDMJ(OMADFMLDBCP().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].EBMGIGLIKDL(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].NGFHDHNFAEG(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		EDHEIFHAAKO();
		POKJOGIIMEL(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	[SpecialName]
	public ColorButton DGMBNHPOCHB()
	{
		return EKIEKAJMOON;
	}

	[SpecialName]
	public ColorButton DKHDHEPKGKA()
	{
		return EKIEKAJMOON;
	}

	private void MPODDJIFBAF(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i++)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}

	private void PFNDAEEEKBP(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!BGLJFMHCFJF() || PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i++)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	private void FJBELGIKCNA(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 4)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 6), 1095f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 403f));
	}

	private void DMPDPCOMFJA(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.EICFBFELOPD(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.NGFHDHNFAEG(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.AKFPBELHLNF(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)8;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 6)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 5].button;
				navigation2 = ((Selectable)exampleColors[i - 4].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 3].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].EFPOJMHPIDI(EFCDHLHIIAM().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].DLPFOPBFJEN(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].NGFHDHNFAEG(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		OpenUI();
		JMEPKMFCFAB(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void ILPEMGCBFEJ(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.FCKNPOACOPA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.CPDDKLKOEHA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.EICFBFELOPD(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)4;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 1)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 4].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 5].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].GCJNJDPHIHM(KFILDGLMNJK().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].GOMENLPLGCH(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].CPDDKLKOEHA(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		EDHEIFHAAKO();
		KAMHLAKLCGO(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	[SpecialName]
	public ColorButton OKIHALELCBL()
	{
		return EKIEKAJMOON;
	}

	public void OOCMPCOOACI(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].SetActive(!NPFFKCPFLGD);
		}
	}

	public void ToggleAdvanced(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(!NPFFKCPFLGD);
		}
	}

	private void KIBKCJHIKIA(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.CPDDKLKOEHA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.AKFPBELHLNF(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.GGHLHODEPIK = null;
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)3;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 1)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 6].button;
				navigation2 = ((Selectable)exampleColors[i - 5].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 4].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].GCJNJDPHIHM(KFILDGLMNJK().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].LNCBMJKOMFE(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].EICFBFELOPD(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(false);
		}
		IDLAGJNLPJL();
		AKJEIDAMCCF(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void OFNPPDBGFOJ(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!HDEPMJIDJEM() || PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i++)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}

	private void AKANFCJEPME(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 8)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 8), 1933f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 1938f));
	}

	private void IIPKOKHEKHD(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.IJLMMBMPALC(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.FCKNPOACOPA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.AKFPBELHLNF(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)8;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 2)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 2].button;
				navigation2 = ((Selectable)exampleColors[i - 5].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 5].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].UpdateColor(DKHDHEPKGKA().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].GOMENLPLGCH(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].NGFHDHNFAEG(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		IDLAGJNLPJL();
		AKANFCJEPME(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	[SpecialName]
	public ColorButton DOEDBIGMKBG()
	{
		return EKIEKAJMOON;
	}

	private void EDCFGLKENMP(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.NGFHDHNFAEG(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.FCKNPOACOPA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.AKFPBELHLNF(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)1;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 8)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 8].button;
				navigation2 = ((Selectable)exampleColors[i - 5].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 7].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].EFPOJMHPIDI(DOEDBIGMKBG().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].EBMGIGLIKDL(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].IJLMMBMPALC(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		IDLAGJNLPJL();
		AKJEIDAMCCF(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	public void EADIABAFODM(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].SetActive(!NPFFKCPFLGD);
		}
	}

	private void EAEEOLGMKBK(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i++)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	private void DJBFMHDABBG(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.EICFBFELOPD(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.NGFHDHNFAEG(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.CPDDKLKOEHA(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)2;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 4)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 2].button;
				navigation2 = ((Selectable)exampleColors[i - 3].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 4].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].GFNEBAPGFNP(BNCLELJDNLN().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].NCHKDCMNDAD = i;
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].EICFBFELOPD(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		IDLAGJNLPJL();
		NEELPKPDMGK(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void JMEPKMFCFAB(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 3)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 6), 1425f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 324f));
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			base.CloseUI();
			content.SetActive(false);
			InteractObject player = InteractObject.GetPlayer(base.JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Remove(player.OnClick, new Action<List<IInteractable>>(EAEEOLGMKBK));
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)EKIEKAJMOON.button);
			}
		}
	}

	[SpecialName]
	public void BNHDNKPLOMI(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.GetMaterialsAvailable(CharacterCreatorUI.PCEEOGGDBFB(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.JHMAMLIPBNN().BIHCEJPEKPI();
		}
		DHFCNLIJCJP(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void HNLDMAGFPBN(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 0)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 6), 449f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 242f));
	}

	private void DBEPOEJKPPB(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 6)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 0), 67f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 360f));
	}

	[SpecialName]
	public void DDGPNPMIMMP(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.PMGNHJLMLBG(CharacterCreatorUI.PCEEOGGDBFB(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.JHMAMLIPBNN().BIHCEJPEKPI();
		}
		CMBBANPEALC(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void BBNGJKFIANA(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 3)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 4), 118f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 1737f));
	}

	private void DHFCNLIJCJP(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.GGHLHODEPIK = null;
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.CPDDKLKOEHA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.NGFHDHNFAEG(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)7;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 7].button;
				navigation2 = ((Selectable)exampleColors[i - 8].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].AMHBOHLPDMJ(DOEDBIGMKBG().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].PNOBFHPHBCA(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].GGHLHODEPIK = NMNNHGLLFMD[i];
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		EDHEIFHAAKO();
		LKGINJBGJJG(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void LOLHOIPDBLH(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.GGHLHODEPIK = null;
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.CPDDKLKOEHA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.AKFPBELHLNF(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)5;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 2)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 7].button;
				navigation2 = ((Selectable)exampleColors[i - 2].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 8].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].AMHBOHLPDMJ(JBBKMBEJCBO().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].LNCBMJKOMFE(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].IJLMMBMPALC(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		EDHEIFHAAKO();
		DGBNOBNAFCD(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void JFAGEFDOELN(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	public static ColorPickerUI BMFHCBOFHCN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ColorPickerUI LAMFGLIGLOP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void ADEBOGDDCFF(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.FCKNPOACOPA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.NGFHDHNFAEG(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.GGHLHODEPIK = null;
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)5;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 2)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 3].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 3].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].NAEGOPAEJID(HGOLAEMONPI.colourCollection.colourSelections[i].mainColor);
				exampleColors[i].GOMENLPLGCH(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].AKFPBELHLNF(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		EDHEIFHAAKO();
		HNLDMAGFPBN(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	public void LALJBJLHBMN(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].SetActive(!NPFFKCPFLGD);
		}
	}

	[SpecialName]
	public void GNGMCNGEAMI(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.CNFNJPKLDFF(CharacterCreatorUI.MENPEHNHFOA(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.JHMAMLIPBNN().CLDOEINCMAE();
		}
		OCFBEBDPBLP(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	[SpecialName]
	public ColorButton OMADFMLDBCP()
	{
		return EKIEKAJMOON;
	}

	private void JBFDJKCKCPJ(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 2)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 2), 0f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 0f));
	}

	public static ColorPickerUI MENPEHNHFOA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	public void IAPJOKKILJE(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.POGJNCEMPFD(CharacterCreatorUI.DPBGKDNKDGM(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.OPILDPFDFKJ().FGJAGFFIOPD();
		}
		HNPMDOEEOPO(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	public void JFAMPFCAIKN(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(!NPFFKCPFLGD);
		}
	}

	public static ColorPickerUI NAGEHKBLJDL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	public void DLFAJFDDCJF(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.MCNNAAIIDKP(CharacterCreatorUI.PCEEOGGDBFB(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.BNDNMBGJEKP().INDFCFMOLBI();
		}
		DHFCNLIJCJP(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void LKFEBIPOPOJ(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!HDEPMJIDJEM() || PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}

	public static ColorPickerUI IEPGACAGIPO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void AKBHLPPBNGJ(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.AKFPBELHLNF(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.IJLMMBMPALC(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.CPDDKLKOEHA(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)7;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 2)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 4].button;
				navigation2 = ((Selectable)exampleColors[i - 4].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].UpdateColor(EFCDHLHIIAM().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].JBFIDCLMIJF(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].CPDDKLKOEHA(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		EDHEIFHAAKO();
		BCCEOFFJOBE(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void BJGJDIFHILP(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.IJLMMBMPALC(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.EICFBFELOPD(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.GGHLHODEPIK = null;
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)5;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 3)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 3].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].BLOJJBPEELJ(OKIHALELCBL().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].EBMGIGLIKDL(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].AKFPBELHLNF(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		IDLAGJNLPJL();
		KAMHLAKLCGO(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	public void PAIKFPGHOIA(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
	}

	private void BNEDMLNEAKL(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!HDEPMJIDJEM() || PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	public override void OpenUI()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			base.OpenUI();
			content.SetActive(true);
			OnContentActivated();
			InteractObject player = InteractObject.GetPlayer(base.JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Combine(player.OnClick, new Action<List<IInteractable>>(EAEEOLGMKBK));
			content.transform.position = CursorManager.GetPlayer(base.JIIGOACEIKL).GetCursorScreenPosition();
		}
	}

	[SpecialName]
	public ColorButton BNCLELJDNLN()
	{
		return EKIEKAJMOON;
	}

	[SpecialName]
	public void LDLLLFLKNCB(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.LKMHIKDBLGK(CharacterCreatorUI.DPBGKDNKDGM(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.GGFJGHHHEJC.FGJAGFFIOPD();
		}
		IIPKOKHEKHD(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	[SpecialName]
	public ColorButton EFCDHLHIIAM()
	{
		return EKIEKAJMOON;
	}

	public static ColorPickerUI BPBMLNJGGII(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	public ColorButton KLHGJLAHPDL()
	{
		return EKIEKAJMOON;
	}

	private void JGGMEGPELNC(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 5)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 2), 790f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 100f));
	}

	[SpecialName]
	public void CDABKGNNILO(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.HNMPCANLANB(CharacterCreatorUI.Get(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.OLHBLKIAFOM().OPMEMMGNBGD();
		}
		IIPKOKHEKHD(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void CMKFBDEMFAA(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.AKFPBELHLNF(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.AKFPBELHLNF(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.CPDDKLKOEHA(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)6;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 7)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 6].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 4].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].EFPOJMHPIDI(OMADFMLDBCP().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].JBFIDCLMIJF(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].AKFPBELHLNF(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		IDLAGJNLPJL();
		JMEPKMFCFAB(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void KAMHLAKLCGO(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 5)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 0), 1057f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 248f));
	}

	private void FKJMOOIHLFJ(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.IJLMMBMPALC(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.IJLMMBMPALC(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.IJLMMBMPALC(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)1;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 3].button;
				navigation2 = ((Selectable)exampleColors[i - 4].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].GCJNJDPHIHM(OKIHALELCBL().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].JBFIDCLMIJF(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].NGFHDHNFAEG(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(false);
		}
		EDHEIFHAAKO();
		EJMCGHEDBAG(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void BAKMMFFGOFN(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.NGFHDHNFAEG(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.IJLMMBMPALC(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.EICFBFELOPD(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)2;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 2)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 8].button;
				navigation2 = ((Selectable)exampleColors[i - 3].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 6].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].AMHBOHLPDMJ(OMADFMLDBCP().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].JBFIDCLMIJF(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].IJLMMBMPALC(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(false);
		}
		OpenUI();
		LKGINJBGJJG(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	public void PENFPBBPMDH(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(!NPFFKCPFLGD);
		}
	}

	public static ColorPickerUI MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void NEPCPNIPLPD(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(!NPFFKCPFLGD);
		}
	}

	[SpecialName]
	public void CJOOHDOILME(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.IBABGHFEPHE(CharacterCreatorUI.Get(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.JFNOOMJMHCB().CLDOEINCMAE();
		}
		PJIPNJCIBBN(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void EHHOFBJMDKF(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!BGLJFMHCFJF() || PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	private void NCJMIGPGFDL(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 0)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 0), 1935f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 1048f));
	}

	private void FDJKEBBGKAA(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.EICFBFELOPD(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.AKFPBELHLNF(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.NGFHDHNFAEG(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)2;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 2)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 7].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 5].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].EFPOJMHPIDI(BNCLELJDNLN().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].JBFIDCLMIJF(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].AKFPBELHLNF(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(false);
		}
		IDLAGJNLPJL();
		AKANFCJEPME(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void LGOPLCJHPIE(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!BGLJFMHCFJF() || PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i++)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}

	public static ColorPickerUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void APJCBLNPKFA(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	private void JPKMIJJGMKL(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!HDEPMJIDJEM() || PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}

	public void FJHFCGBNAPD(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
	}

	private void HFPMFMANPKO(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.NGFHDHNFAEG(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.EICFBFELOPD(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.GGHLHODEPIK = null;
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)7;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 4)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 5].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 6].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].NAEGOPAEJID(DCPNDPLOHHL().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].NCHKDCMNDAD = i;
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].EICFBFELOPD(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		OpenUI();
		JMEPKMFCFAB(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void POJDKOADINO(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!BGLJFMHCFJF() || PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	private void CMBBANPEALC(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.AKFPBELHLNF(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.CPDDKLKOEHA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.IJLMMBMPALC(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)5;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 8)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 3].button;
				navigation2 = ((Selectable)exampleColors[i - 2].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].AMHBOHLPDMJ(DKHDHEPKGKA().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].JBFIDCLMIJF(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].EICFBFELOPD(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(false);
		}
		OpenUI();
		KAMHLAKLCGO(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void HNPMDOEEOPO(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.CPDDKLKOEHA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.GGHLHODEPIK = null;
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.NGFHDHNFAEG(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)7;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 5)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 3].button;
				navigation2 = ((Selectable)exampleColors[i - 7].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 7].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].EFPOJMHPIDI(KFILDGLMNJK().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].PNOBFHPHBCA(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].EICFBFELOPD(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		IDLAGJNLPJL();
		JGGMEGPELNC(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	public void MAJABDHGOOG(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
	}

	private void HIPELIJFNAB(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.CPDDKLKOEHA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.IJLMMBMPALC(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.IJLMMBMPALC(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)8;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 6)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 8].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 8].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].BLOJJBPEELJ(BNCLELJDNLN().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].EBMGIGLIKDL(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].GGHLHODEPIK = NMNNHGLLFMD[i];
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = true;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(false);
		}
		EDHEIFHAAKO();
		BBDPLPMGGDI(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	[SpecialName]
	public void EINIAFEDFMC(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.HNMPCANLANB(CharacterCreatorUI.FKFNANNBIAM(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.OPILDPFDFKJ().BIHCEJPEKPI();
		}
		CMBBANPEALC(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	protected override void Start()
	{
		base.Start();
		PGBKFNPCPDE = ((Component)GameplayUI.GGFJGHHHEJC).GetComponent<RectTransform>();
	}

	private void AKJEIDAMCCF(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 5)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 4), 1000f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 1972f));
	}

	[SpecialName]
	public void JKMJIDKDGAN(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.IBABGHFEPHE(CharacterCreatorUI.FKFNANNBIAM(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.BNDNMBGJEKP().CLDOEINCMAE();
		}
		KIBKCJHIKIA(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void NEKDBDAGKEI(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!BGLJFMHCFJF() || PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i++)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}

	public void ELPKALBEDLI(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
		GFOGBONOCIP = content.GetComponent<RectTransform>();
	}

	[SpecialName]
	public ColorButton DCPNDPLOHHL()
	{
		return EKIEKAJMOON;
	}

	[SpecialName]
	public ColorButton MJIHBJMENJL()
	{
		return EKIEKAJMOON;
	}

	[SpecialName]
	public ColorButton JBBKMBEJCBO()
	{
		return EKIEKAJMOON;
	}

	private void IHGPHCLEOKN(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.NGFHDHNFAEG(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.CPDDKLKOEHA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.FCKNPOACOPA(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)0;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 1)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 7].button;
				navigation2 = ((Selectable)exampleColors[i - 4].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 8].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].GCJNJDPHIHM(HGOLAEMONPI.colourCollection.colourSelections[i].mainColor);
				exampleColors[i].NCHKDCMNDAD = i;
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].NGFHDHNFAEG(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(false);
		}
		OpenUI();
		AKJEIDAMCCF(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void NEELPKPDMGK(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 1)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 7), 1395f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 33f));
	}

	private void AOIPJOBNCHN(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}

	[SpecialName]
	public void IIHANLINBDH(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.POGJNCEMPFD(CharacterCreatorUI.FKFNANNBIAM(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.BNDNMBGJEKP().OPMEMMGNBGD();
		}
		IHGPHCLEOKN(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void EJMCGHEDBAG(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 1)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 8), 489f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 1940f));
	}

	private void NHEOOLGHFJH(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.CPDDKLKOEHA(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.NGFHDHNFAEG(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.AKFPBELHLNF(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)5;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 1)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 4].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].GCJNJDPHIHM(NFAOOGPOPPA().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].DLPFOPBFJEN(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].EICFBFELOPD(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		IDLAGJNLPJL();
		DBEPOEJKPPB(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	[SpecialName]
	public void NPCPEBLMHLP(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.HNMPCANLANB(CharacterCreatorUI.PCEEOGGDBFB(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.GGFJGHHHEJC.OPMEMMGNBGD();
		}
		DJBFMHDABBG(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void DLHHPHDMFIF(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 8)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 2), 1065f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 1759f));
	}

	[SpecialName]
	public void OJLFPOMINKE(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.LKMHIKDBLGK(CharacterCreatorUI.FKFNANNBIAM(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.BNDNMBGJEKP().GetPossibleColors();
		}
		DHFCNLIJCJP(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void BBDPLPMGGDI(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 1)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 3), 1872f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 186f));
	}

	[SpecialName]
	public void HJBNHJOFOHA(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.BBFBEMMDNNP(CharacterCreatorUI.MENPEHNHFOA(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.OPILDPFDFKJ().GetPossibleColors();
		}
		CMKFBDEMFAA(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	public void KOICEFOGFPJ(bool NPFFKCPFLGD)
	{
		GameObject[] array = advancedGameObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
		array = simpleGameObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(NPFFKCPFLGD);
		}
	}

	[SpecialName]
	public void MNJCEPNPPGI(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.IBABGHFEPHE(CharacterCreatorUI.Get(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.BNDNMBGJEKP().FGJAGFFIOPD();
		}
		NHEOOLGHFJH(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void NOEFGHJNIPK(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!HDEPMJIDJEM() || PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	[SpecialName]
	public void JOALMGFFJEB(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.POGJNCEMPFD(CharacterCreatorUI.MENPEHNHFOA(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.OPILDPFDFKJ().OPMEMMGNBGD();
		}
		BAKMMFFGOFN(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void OIHPOMNDDLH(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}

	public static ColorPickerUI EGBMJGOCIJJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	public void EBBNLDENNMG(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.PMGNHJLMLBG(CharacterCreatorUI.PCEEOGGDBFB(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.OLHBLKIAFOM().BIHCEJPEKPI();
		}
		KIBKCJHIKIA(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void IAOEJDOIGLM(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!BGLJFMHCFJF() || PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		for (int i = 0; i < exampleColors.Count; i++)
		{
			if ((Object)(object)exampleColors[i].GGHLHODEPIK == (Object)(object)EKIEKAJMOON.GGHLHODEPIK)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)exampleColors[i].button);
				return;
			}
		}
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)exampleColors[0].button);
	}

	[SpecialName]
	public void JLBOFOFMGAA(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.POGJNCEMPFD(CharacterCreatorUI.Get(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.GGFJGHHHEJC.INDFCFMOLBI();
		}
		DJBFMHDABBG(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void BGCEJMKPLFM(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 0)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 0), 1949f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 1479f));
	}

	private void DFCJCGEFMGE(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!BGLJFMHCFJF() || PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i++)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}

	private void CKHNHNJABLH(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	private void JLPLNOBPJHC(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!HDEPMJIDJEM() || PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}

	[SpecialName]
	public void PPLMJGLFMGL(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.MCNNAAIIDKP(CharacterCreatorUI.DPBGKDNKDGM(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.GGFJGHHHEJC.BIHCEJPEKPI();
		}
		ADEBOGDDCFF(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void INIDFOGPAHJ(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	[SpecialName]
	public void KIFACIJDDDC(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.BBFBEMMDNNP(CharacterCreatorUI.PCEEOGGDBFB(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.JHMAMLIPBNN().CLDOEINCMAE();
		}
		HIPELIJFNAB(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	private void PJIPNJCIBBN(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.GGHLHODEPIK = null;
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.EICFBFELOPD(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.IJLMMBMPALC(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)3;
			Navigation navigation2;
			if (i > 1)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 0].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 6)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 4].button;
				navigation2 = ((Selectable)exampleColors[i - 8].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 3].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].AIMFODMDLJD(EFCDHLHIIAM().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].DLPFOPBFJEN(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].GGHLHODEPIK = NMNNHGLLFMD[i];
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(false);
		}
		EDHEIFHAAKO();
		AKJEIDAMCCF(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	[SpecialName]
	public void GDJIAABAHNE(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.PMGNHJLMLBG(CharacterCreatorUI.PCEEOGGDBFB(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.BNDNMBGJEKP().FGJAGFFIOPD();
		}
		LOLHOIPDBLH(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	[SpecialName]
	public ColorButton PHOLBILDCAC()
	{
		return EKIEKAJMOON;
	}

	public static ColorPickerUI CCGPMEADLDG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BCCEOFFJOBE(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 6)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 8), 1735f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 602f));
	}

	private void MJFKKPJGOLI(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!BGLJFMHCFJF() || PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	public static ColorPickerUI LAIEKOOCNPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void IEDIPPPEMKN(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		CloseUI();
	}

	private void LOMFCKAHOGJ(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.GGHLHODEPIK = null;
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.GGHLHODEPIK = null;
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.GGHLHODEPIK = null;
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)4;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 1].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 6)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 6].button;
				navigation2 = ((Selectable)exampleColors[i - 6].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 6].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].UpdateColor(HGOLAEMONPI.colourCollection.colourSelections[i].mainColor);
				exampleColors[i].NCHKDCMNDAD = i;
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].GGHLHODEPIK = NMNNHGLLFMD[i];
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(false);
		}
		OpenUI();
		JBFDJKCKCPJ(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	private void FCDGENJICDI(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.EICFBFELOPD(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.GGHLHODEPIK = null;
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.FCKNPOACOPA(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 1; i < num; i += 0)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(false);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)7;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 0].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 8)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 7].button;
				navigation2 = ((Selectable)exampleColors[i - 6].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 5].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].AIMFODMDLJD(AMOJCIGDHPP().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].PNOBFHPHBCA(i);
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].GGHLHODEPIK = NMNNHGLLFMD[i];
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j += 0)
		{
			((Component)exampleColors[j]).gameObject.SetActive(true);
		}
		IDLAGJNLPJL();
		FJBELGIKCNA(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	public static ColorPickerUI OCCEHEMCGJF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void MGBGFAJBFOJ(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 1)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 8), 1743f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 1218f));
	}

	public static ColorPickerUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void POKJOGIIMEL(Vector2 DAADKDLNAGE)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 8)
		{
			DAADKDLNAGE -= new Vector2((float)(Screen.width / 3), 1302f);
		}
		Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(DAADKDLNAGE)));
		GFOGBONOCIP.anchoredPosition = Vector2.op_Implicit(new Vector3(val.x * PGBKFNPCPDE.sizeDelta.x, val.y * PGBKFNPCPDE.sizeDelta.y, 184f));
	}

	public static ColorPickerUI HEGPDGJEOPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ColorPickerUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OCFBEBDPBLP(CharacterMaterial[] NMNNHGLLFMD, SpriteColor[] ILCJHEDFPPO, bool BDAJICEDFFN, bool EODGOHFKIAK)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		if (EODGOHFKIAK)
		{
			if (EKIEKAJMOON.colourCollection.colourSelections == null || EKIEKAJMOON.colourCollection.colourSelections.Length == 0)
			{
				EKIEKAJMOON.AKFPBELHLNF(null);
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (BDAJICEDFFN)
		{
			if (NMNNHGLLFMD == null || NMNNHGLLFMD.Length == 0)
			{
				EKIEKAJMOON.GGHLHODEPIK = null;
				EKIEKAJMOON = null;
				return;
			}
		}
		else if (ILCJHEDFPPO == null || ILCJHEDFPPO.Length == 0)
		{
			EKIEKAJMOON.IJLMMBMPALC(null);
			EKIEKAJMOON = null;
			return;
		}
		int num = (EODGOHFKIAK ? EKIEKAJMOON.colourCollection.colourSelections.Length : (BDAJICEDFFN ? NMNNHGLLFMD.Length : ILCJHEDFPPO.Length));
		for (int i = 0; i < num; i++)
		{
			if (i >= exampleColors.Count)
			{
				exampleColors.Add(Object.Instantiate<ColorButton>(colorButtonPrefab, panel.transform));
			}
			((Component)exampleColors[i]).gameObject.layer = ((Component)this).gameObject.layer;
			((Component)exampleColors[i]).gameObject.SetActive(true);
			Navigation navigation = ((Selectable)exampleColors[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)4;
			Navigation navigation2;
			if (i > 0)
			{
				((Navigation)(ref navigation)).selectOnLeft = (Selectable)(object)exampleColors[i - 0].button;
				navigation2 = ((Selectable)exampleColors[i - 1].button).navigation;
				((Navigation)(ref navigation2)).selectOnRight = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 1].button).navigation = navigation2;
			}
			((Navigation)(ref navigation)).selectOnDown = null;
			if (i >= 7)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)exampleColors[i - 7].button;
				navigation2 = ((Selectable)exampleColors[i - 4].button).navigation;
				((Navigation)(ref navigation2)).selectOnDown = (Selectable)(object)exampleColors[i].button;
				((Selectable)exampleColors[i - 5].button).navigation = navigation2;
			}
			((Selectable)exampleColors[i].button).navigation = navigation;
			if (EODGOHFKIAK)
			{
				exampleColors[i].AMHBOHLPDMJ(DOEDBIGMKBG().colourCollection.colourSelections[i].mainColor);
				exampleColors[i].NCHKDCMNDAD = i;
			}
			else if (BDAJICEDFFN)
			{
				exampleColors[i].IJLMMBMPALC(NMNNHGLLFMD[i]);
			}
			else
			{
				exampleColors[i].FJAHJEMPPKH = ILCJHEDFPPO[i];
			}
			exampleColors[i].openPicker = false;
		}
		for (int j = num; j < exampleColors.Count; j++)
		{
			((Component)exampleColors[j]).gameObject.SetActive(false);
		}
		EDHEIFHAAKO();
		BBDPLPMGGDI(Vector2.op_Implicit(((Component)EKIEKAJMOON).transform.position));
	}

	[SpecialName]
	public void KIBPLCBNKOP(ColorButton AODONKKHPBP)
	{
		EKIEKAJMOON = AODONKKHPBP;
		CharacterMaterial[] nMNNHGLLFMD = null;
		SpriteColor[] iLCJHEDFPPO = null;
		if (EKIEKAJMOON.useCharacterMaterial)
		{
			nMNNHGLLFMD = EKIEKAJMOON.BGAABFNPNJO(CharacterCreatorUI.FKFNANNBIAM(base.JIIGOACEIKL).characterCreator);
		}
		else
		{
			iLCJHEDFPPO = DrinkDispensersManager.BNDNMBGJEKP().CLDOEINCMAE();
		}
		PGFJNJLMOKK(nMNNHGLLFMD, iLCJHEDFPPO, EKIEKAJMOON.useCharacterMaterial, EKIEKAJMOON.useColourCollection);
	}

	public static ColorPickerUI JDODHPEDACJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EINCMCKNHGL(List<IInteractable> JGDIEMODGLI)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!BGLJFMHCFJF() || PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			ColorButton component = ((RaycastResult)(ref val)).gameObject.GetComponent<ColorButton>();
			val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)panelImage).gameObject || (Object.op_Implicit((Object)(object)component) && ((object)component).Equals((object?)EKIEKAJMOON)))
			{
				return;
			}
		}
		BOBCIFEDJED();
	}
}
