using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour, ISelectHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	public Action<SpriteColor> OnColorChanged = delegate
	{
	};

	public Action OnColorIndexChanged = delegate
	{
	};

	public Action<CharacterLayer, CharacterMaterial> OnMaterialChanged = delegate
	{
	};

	public bool useCharacterMaterial = true;

	public bool useColourCollection;

	[HideInInspector]
	public SO_ColourCollection colourCollection;

	[HideInInspector]
	public int _buttonColour;

	[SerializeField]
	private SpriteColor _spriteColor;

	[SerializeField]
	private CharacterMaterial _material;

	public BodyPart bodyPart;

	public CharacterLayer layer;

	[SerializeField]
	private Image image;

	public Button button;

	public bool openPicker = true;

	private int JIIGOACEIKL = 1;

	public CharacterMaterial GGHLHODEPIK
	{
		get
		{
			return _material;
		}
		set
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			_material = value;
			if ((Object)(object)_material != (Object)null)
			{
				UpdateColor(_material.sampleColor);
			}
			else
			{
				UpdateColor(Color.black);
			}
			OnMaterialChanged(layer, _material);
		}
	}

	public SpriteColor FJAHJEMPPKH
	{
		get
		{
			return _spriteColor;
		}
		set
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			_spriteColor = value;
			UpdateColor(_spriteColor.color);
		}
	}

	public int NCHKDCMNDAD
	{
		get
		{
			return _buttonColour;
		}
		set
		{
			_buttonColour = value;
			OnColorIndexChanged();
		}
	}

	[SpecialName]
	public void NGFHDHNFAEG(CharacterMaterial AODONKKHPBP)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_material = AODONKKHPBP;
		if ((Object)(object)_material != (Object)null)
		{
			GFNEBAPGFNP(_material.sampleColor);
		}
		else
		{
			EFPOJMHPIDI(Color.black);
		}
		OnMaterialChanged(layer, _material);
	}

	[SpecialName]
	public void GOMENLPLGCH(int AODONKKHPBP)
	{
		_buttonColour = AODONKKHPBP;
		OnColorIndexChanged();
	}

	[SpecialName]
	public int OGPAFJJBADA()
	{
		return _buttonColour;
	}

	[SpecialName]
	public CharacterMaterial IFIBANEOMEP()
	{
		return _material;
	}

	public CharacterMaterial[] FNGPICOLLML(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 0; i < characterSprite.layerSettings.Length; i += 0)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 0; j < characterSprite.layerSettings[i].materials.Length; j += 0)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	public void AAOKBDMLCFO(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.Get(JIIGOACEIKL).EFCDHLHIIAM()))
		{
			if (ColorPickerUI.HEGPDGJEOPC(JIIGOACEIKL).KFILDGLMNJK().useColourCollection)
			{
				((Graphic)ColorPickerUI.MENNLOGFNOK(JIIGOACEIKL).KFILDGLMNJK().image).color = ((Graphic)image).color;
				ColorPickerUI.MENPEHNHFOA(JIIGOACEIKL).JBBKMBEJCBO().NCHKDCMNDAD = BJKLKHLOLCF();
			}
			else if (ColorPickerUI.LAIEKOOCNPC(JIIGOACEIKL).PHOLBILDCAC().useCharacterMaterial)
			{
				ColorPickerUI.NDJAMDLOIJL(JIIGOACEIKL).DKHDHEPKGKA().CPDDKLKOEHA(JJJDGHLBODC());
			}
			else
			{
				ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).DKHDHEPKGKA().FJAHJEMPPKH = GGONDBGBKHM();
			}
		}
	}

	[SpecialName]
	public SpriteColor DKACEGLCNDB()
	{
		return _spriteColor;
	}

	[SpecialName]
	public SpriteColor GGONDBGBKHM()
	{
		return _spriteColor;
	}

	[SpecialName]
	public void PNOBFHPHBCA(int AODONKKHPBP)
	{
		_buttonColour = AODONKKHPBP;
		OnColorIndexChanged();
	}

	[SpecialName]
	public CharacterMaterial GMAMIFEJOJC()
	{
		return _material;
	}

	public void FJLCLJMKJGL(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.Get(JIIGOACEIKL).KLHGJLAHPDL()))
		{
			if (ColorPickerUI.MENNLOGFNOK(JIIGOACEIKL).PHOLBILDCAC().useColourCollection)
			{
				((Graphic)ColorPickerUI.Get(JIIGOACEIKL).DCPNDPLOHHL().image).color = ((Graphic)image).color;
				ColorPickerUI.MENPEHNHFOA(JIIGOACEIKL).JBBKMBEJCBO().LNCBMJKOMFE(OGPAFJJBADA());
			}
			else if (ColorPickerUI.BPBMLNJGGII(JIIGOACEIKL).DCPNDPLOHHL().useCharacterMaterial)
			{
				ColorPickerUI.JDODHPEDACJ(JIIGOACEIKL).JBBKMBEJCBO().CPDDKLKOEHA(AFPDBMKOEAE());
			}
			else
			{
				ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).AMOJCIGDHPP().FJAHJEMPPKH = FNOKNEOHJKG();
			}
		}
	}

	[SpecialName]
	public SpriteColor NJCEBDGHGJE()
	{
		return _spriteColor;
	}

	[SpecialName]
	public SpriteColor CKCBDOLPFGC()
	{
		return _spriteColor;
	}

	private void IMIONHLAKIH()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("UpgradeObjectConfirmation")) ? 7 : 0);
	}

	private void JPOLFKMLHNH()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" ")) ? 1 : 7);
	}

	[SpecialName]
	public CharacterMaterial LNKGMCOFLBM()
	{
		return _material;
	}

	public void NAEGOPAEJID(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public int IFDEEGLBIEM()
	{
		return _buttonColour;
	}

	public void AIMFODMDLJD(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public SpriteColor OAAPLEHDDKL()
	{
		return _spriteColor;
	}

	public CharacterMaterial[] PMGNHJLMLBG(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 1; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 0; j < characterSprite.layerSettings[i].materials.Length; j++)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	[SpecialName]
	public void IJLMMBMPALC(CharacterMaterial AODONKKHPBP)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_material = AODONKKHPBP;
		if ((Object)(object)_material != (Object)null)
		{
			UpdateColor(_material.sampleColor);
		}
		else
		{
			BLOJJBPEELJ(Color.black);
		}
		OnMaterialChanged(layer, _material);
	}

	[SpecialName]
	public void LNCBMJKOMFE(int AODONKKHPBP)
	{
		_buttonColour = AODONKKHPBP;
		OnColorIndexChanged();
	}

	[SpecialName]
	public CharacterMaterial GLDAIICHHEC()
	{
		return _material;
	}

	[SpecialName]
	public void FCKNPOACOPA(CharacterMaterial AODONKKHPBP)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_material = AODONKKHPBP;
		if ((Object)(object)_material != (Object)null)
		{
			BLOJJBPEELJ(_material.sampleColor);
		}
		else
		{
			AMHBOHLPDMJ(Color.black);
		}
		OnMaterialChanged(layer, _material);
	}

	public CharacterMaterial[] IBABGHFEPHE(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 1; i < characterSprite.layerSettings.Length; i += 0)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 1; j < characterSprite.layerSettings[i].materials.Length; j += 0)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	public void EFPOJMHPIDI(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = FLABEDBELMF;
		}
	}

	public void GFNEBAPGFNP(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = FLABEDBELMF;
		}
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker)
		{
			if (ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.useColourCollection)
			{
				((Graphic)ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.image).color = ColorPickerUI.Get(JIIGOACEIKL).lastColour;
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.NCHKDCMNDAD = ColorPickerUI.Get(JIIGOACEIKL).lastButtonColour;
			}
			else if (ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.useCharacterMaterial)
			{
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.GGHLHODEPIK = ColorPickerUI.Get(JIIGOACEIKL).lastMaterial;
			}
			else
			{
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.FJAHJEMPPKH = ColorPickerUI.Get(JIIGOACEIKL).lastSpriteColor;
			}
		}
	}

	public CharacterMaterial[] LKMHIKDBLGK(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 0; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 1; j < characterSprite.layerSettings[i].materials.Length; j += 0)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	[SpecialName]
	public int OLFEAIHLMKH()
	{
		return _buttonColour;
	}

	public void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI))
		{
			if (ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.useColourCollection)
			{
				((Graphic)ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.image).color = ((Graphic)image).color;
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.NCHKDCMNDAD = NCHKDCMNDAD;
			}
			else if (ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.useCharacterMaterial)
			{
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.GGHLHODEPIK = GGHLHODEPIK;
			}
			else
			{
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.FJAHJEMPPKH = FJAHJEMPPKH;
			}
		}
	}

	[SpecialName]
	public SpriteColor DGNHFNFAAIN()
	{
		return _spriteColor;
	}

	public void KALCDFPLIKA(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).OKIHALELCBL()))
		{
			if (ColorPickerUI.NDJAMDLOIJL(JIIGOACEIKL).KLHGJLAHPDL().useColourCollection)
			{
				((Graphic)ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).HGOLAEMONPI.image).color = ((Graphic)image).color;
				ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).MJIHBJMENJL().PNOBFHPHBCA(NCHKDCMNDAD);
			}
			else if (ColorPickerUI.Get(JIIGOACEIKL).PHOLBILDCAC().useCharacterMaterial)
			{
				ColorPickerUI.MENPEHNHFOA(JIIGOACEIKL).HGOLAEMONPI.IJLMMBMPALC(LNAJFLGDACJ());
			}
			else
			{
				ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).EFCDHLHIIAM().FJAHJEMPPKH = FNOKNEOHJKG();
			}
		}
	}

	[SpecialName]
	public int MHKAFJMAEGC()
	{
		return _buttonColour;
	}

	[SpecialName]
	public void AKFPBELHLNF(CharacterMaterial AODONKKHPBP)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_material = AODONKKHPBP;
		if ((Object)(object)_material != (Object)null)
		{
			GCJNJDPHIHM(_material.sampleColor);
		}
		else
		{
			GFNEBAPGFNP(Color.black);
		}
		OnMaterialChanged(layer, _material);
	}

	[SpecialName]
	public void CPDDKLKOEHA(CharacterMaterial AODONKKHPBP)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_material = AODONKKHPBP;
		if ((Object)(object)_material != (Object)null)
		{
			AMHBOHLPDMJ(_material.sampleColor);
		}
		else
		{
			AIMFODMDLJD(Color.black);
		}
		OnMaterialChanged(layer, _material);
	}

	[SpecialName]
	public int AHGLCFFOBMI()
	{
		return _buttonColour;
	}

	private void IDPHKHGHJGN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" not found in OnlineEventsManager.")) ? 1 : 6);
	}

	public void MJLHJBOBDOL(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).DKHDHEPKGKA()))
		{
			if (ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).KLHGJLAHPDL().useColourCollection)
			{
				((Graphic)ColorPickerUI.IEPGACAGIPO(JIIGOACEIKL).PHOLBILDCAC().image).color = ((Graphic)image).color;
				ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).OMADFMLDBCP().EBMGIGLIKDL(LGMJDCFHPJL());
			}
			else if (ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).KLHGJLAHPDL().useCharacterMaterial)
			{
				ColorPickerUI.LAIEKOOCNPC(JIIGOACEIKL).NFAOOGPOPPA().AKFPBELHLNF(LNKGMCOFLBM());
			}
			else
			{
				ColorPickerUI.MENPEHNHFOA(JIIGOACEIKL).BNCLELJDNLN().FJAHJEMPPKH = DGNHFNFAAIN();
			}
		}
	}

	[SpecialName]
	public CharacterMaterial JJJDGHLBODC()
	{
		return _material;
	}

	private void AEPBFPCHGPP()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Finding by name also failed.")) ? 6 : 0);
	}

	[SpecialName]
	public void JBFIDCLMIJF(int AODONKKHPBP)
	{
		_buttonColour = AODONKKHPBP;
		OnColorIndexChanged();
	}

	[SpecialName]
	public CharacterMaterial LDLEJGCFGAB()
	{
		return _material;
	}

	public void GFGLFNNDIDC()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker)
		{
			if (ColorPickerUI.MDINEPBJFKG(JIIGOACEIKL).AMOJCIGDHPP().useColourCollection)
			{
				ColorPickerUI.MDINEPBJFKG(JIIGOACEIKL).KLHGJLAHPDL().GFNEBAPGFNP(((Graphic)image).color);
				ColorPickerUI.IEPGACAGIPO(JIIGOACEIKL).BOBCIFEDJED();
			}
			else
			{
				ColorPickerUI.NDJAMDLOIJL(JIIGOACEIKL).BNCLELJDNLN().OnColorChanged(_spriteColor);
				ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).CloseUI();
			}
		}
		else if (ColorPickerUI.MENPEHNHFOA(JIIGOACEIKL).HDEPMJIDJEM())
		{
			if ((Object)(object)ColorPickerUI.MDFIDKHOPDJ(JIIGOACEIKL).DOEDBIGMKBG() == (Object)(object)this)
			{
				ColorPickerUI.BPBMLNJGGII(JIIGOACEIKL).CloseUI();
			}
			else
			{
				ColorPickerUI.Get(JIIGOACEIKL).JKMJIDKDGAN(this);
			}
		}
		else
		{
			ColorPickerUI.EGBMJGOCIJJ(JIIGOACEIKL).JKMJIDKDGAN(this);
		}
	}

	public CharacterMaterial[] BBFBEMMDNNP(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 0; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 1; j < characterSprite.layerSettings[i].materials.Length; j += 0)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	public void KDAJGEFFPJI(PointerEventData NPBAMEMNFBI)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker)
		{
			if (ColorPickerUI.MDFIDKHOPDJ(JIIGOACEIKL).AMOJCIGDHPP().useColourCollection)
			{
				ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).lastColour = ((Graphic)ColorPickerUI.Get(JIIGOACEIKL).OKIHALELCBL().image).color;
				((Graphic)ColorPickerUI.LAMFGLIGLOP(JIIGOACEIKL).DKHDHEPKGKA().image).color = ((Graphic)image).color;
				ColorPickerUI.IEPGACAGIPO(JIIGOACEIKL).lastButtonColour = ColorPickerUI.HEGPDGJEOPC(JIIGOACEIKL).DKHDHEPKGKA().AHGLCFFOBMI();
				ColorPickerUI.BPBMLNJGGII(JIIGOACEIKL).KLHGJLAHPDL().NCHKDCMNDAD = LGMJDCFHPJL();
			}
			else if (ColorPickerUI.DOGBDIOJAHO(JIIGOACEIKL).DCPNDPLOHHL().useCharacterMaterial)
			{
				ColorPickerUI.DOGBDIOJAHO(JIIGOACEIKL).lastMaterial = ColorPickerUI.EOPIEMLAPFN(JIIGOACEIKL).MJIHBJMENJL().GGHLHODEPIK;
				ColorPickerUI.LAMFGLIGLOP(JIIGOACEIKL).EFCDHLHIIAM().IJLMMBMPALC(_material);
			}
			else
			{
				ColorPickerUI.MENNLOGFNOK(JIIGOACEIKL).lastSpriteColor = ColorPickerUI.EOPIEMLAPFN(JIIGOACEIKL).OKIHALELCBL().DGNHFNFAAIN();
				ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).PHOLBILDCAC().FJAHJEMPPKH = _spriteColor;
			}
		}
	}

	public CharacterMaterial[] CNFNJPKLDFF(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 1; i < characterSprite.layerSettings.Length; i += 0)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 1; j < characterSprite.layerSettings[i].materials.Length; j += 0)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	public void IEFLHJKFEHP(PointerEventData NPBAMEMNFBI)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker)
		{
			if (ColorPickerUI.MENNLOGFNOK(JIIGOACEIKL).MJIHBJMENJL().useColourCollection)
			{
				ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).lastColour = ((Graphic)ColorPickerUI.HEGPDGJEOPC(JIIGOACEIKL).DCPNDPLOHHL().image).color;
				((Graphic)ColorPickerUI.HEGPDGJEOPC(JIIGOACEIKL).EFCDHLHIIAM().image).color = ((Graphic)image).color;
				ColorPickerUI.MENNLOGFNOK(JIIGOACEIKL).lastButtonColour = ColorPickerUI.NAGEHKBLJDL(JIIGOACEIKL).DOEDBIGMKBG().AHGLCFFOBMI();
				ColorPickerUI.Get(JIIGOACEIKL).KLHGJLAHPDL().GOMENLPLGCH(BJKLKHLOLCF());
			}
			else if (ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).HGOLAEMONPI.useCharacterMaterial)
			{
				ColorPickerUI.HEGPDGJEOPC(JIIGOACEIKL).lastMaterial = ColorPickerUI.LAMFGLIGLOP(JIIGOACEIKL).DKHDHEPKGKA().LNAJFLGDACJ();
				ColorPickerUI.EOPIEMLAPFN(JIIGOACEIKL).DOEDBIGMKBG().EICFBFELOPD(_material);
			}
			else
			{
				ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).lastSpriteColor = ColorPickerUI.HEGPDGJEOPC(JIIGOACEIKL).KLHGJLAHPDL().FNOKNEOHJKG();
				ColorPickerUI.LAMFGLIGLOP(JIIGOACEIKL).MJIHBJMENJL().FJAHJEMPPKH = _spriteColor;
			}
		}
	}

	[SpecialName]
	public void HNAIFDIBDNH(int AODONKKHPBP)
	{
		_buttonColour = AODONKKHPBP;
		OnColorIndexChanged();
	}

	public void UpdateColor(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public int LGMJDCFHPJL()
	{
		return _buttonColour;
	}

	public void DKCODHHNDBI(PointerEventData NPBAMEMNFBI)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker)
		{
			if (ColorPickerUI.NAGEHKBLJDL(JIIGOACEIKL).OMADFMLDBCP().useColourCollection)
			{
				((Graphic)ColorPickerUI.NAGEHKBLJDL(JIIGOACEIKL).DKHDHEPKGKA().image).color = ColorPickerUI.IEPGACAGIPO(JIIGOACEIKL).lastColour;
				ColorPickerUI.MENPEHNHFOA(JIIGOACEIKL).OMADFMLDBCP().DLPFOPBFJEN(ColorPickerUI.LAMFGLIGLOP(JIIGOACEIKL).lastButtonColour);
			}
			else if (ColorPickerUI.NAGEHKBLJDL(JIIGOACEIKL).DOEDBIGMKBG().useCharacterMaterial)
			{
				ColorPickerUI.BPBMLNJGGII(JIIGOACEIKL).DOEDBIGMKBG().CPDDKLKOEHA(ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).lastMaterial);
			}
			else
			{
				ColorPickerUI.MDINEPBJFKG(JIIGOACEIKL).PHOLBILDCAC().FJAHJEMPPKH = ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).lastSpriteColor;
			}
		}
	}

	public void HMJBIFAAIPB(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).KFILDGLMNJK()))
		{
			if (ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).DGMBNHPOCHB().useColourCollection)
			{
				((Graphic)ColorPickerUI.LAIEKOOCNPC(JIIGOACEIKL).OKIHALELCBL().image).color = ((Graphic)image).color;
				ColorPickerUI.EOPIEMLAPFN(JIIGOACEIKL).BNCLELJDNLN().PNOBFHPHBCA(IFDEEGLBIEM());
			}
			else if (ColorPickerUI.LAIEKOOCNPC(JIIGOACEIKL).DKHDHEPKGKA().useCharacterMaterial)
			{
				ColorPickerUI.MENPEHNHFOA(JIIGOACEIKL).NFAOOGPOPPA().NGFHDHNFAEG(GLDAIICHHEC());
			}
			else
			{
				ColorPickerUI.IEPGACAGIPO(JIIGOACEIKL).HGOLAEMONPI.FJAHJEMPPKH = CKCBDOLPFGC();
			}
		}
	}

	public CharacterMaterial[] POGJNCEMPFD(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 1; i < characterSprite.layerSettings.Length; i += 0)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 1; j < characterSprite.layerSettings[i].materials.Length; j += 0)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	[SpecialName]
	public void EICFBFELOPD(CharacterMaterial AODONKKHPBP)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_material = AODONKKHPBP;
		if ((Object)(object)_material != (Object)null)
		{
			AIMFODMDLJD(_material.sampleColor);
		}
		else
		{
			AIMFODMDLJD(Color.black);
		}
		OnMaterialChanged(layer, _material);
	}

	public void FCFOCGMJBNJ(PointerEventData NPBAMEMNFBI)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker)
		{
			if (ColorPickerUI.NDJAMDLOIJL(JIIGOACEIKL).DKHDHEPKGKA().useColourCollection)
			{
				((Graphic)ColorPickerUI.DOGBDIOJAHO(JIIGOACEIKL).KFILDGLMNJK().image).color = ColorPickerUI.IEPGACAGIPO(JIIGOACEIKL).lastColour;
				ColorPickerUI.MDFIDKHOPDJ(JIIGOACEIKL).DGMBNHPOCHB().JBFIDCLMIJF(ColorPickerUI.MENPEHNHFOA(JIIGOACEIKL).lastButtonColour);
			}
			else if (ColorPickerUI.NDJAMDLOIJL(JIIGOACEIKL).EFCDHLHIIAM().useCharacterMaterial)
			{
				ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).MJIHBJMENJL().CPDDKLKOEHA(ColorPickerUI.NAGEHKBLJDL(JIIGOACEIKL).lastMaterial);
			}
			else
			{
				ColorPickerUI.NDJAMDLOIJL(JIIGOACEIKL).NDHAENIONJB().FJAHJEMPPKH = ColorPickerUI.HEGPDGJEOPC(JIIGOACEIKL).lastSpriteColor;
			}
		}
	}

	public void ACOIDIGHENN(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).DCPNDPLOHHL()))
		{
			if (ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).DGMBNHPOCHB().useColourCollection)
			{
				((Graphic)ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).JBBKMBEJCBO().image).color = ((Graphic)image).color;
				ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).MJIHBJMENJL().PNOBFHPHBCA(IFDEEGLBIEM());
			}
			else if (ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).DCPNDPLOHHL().useCharacterMaterial)
			{
				ColorPickerUI.HEGPDGJEOPC(JIIGOACEIKL).EFCDHLHIIAM().GGHLHODEPIK = LDLEJGCFGAB();
			}
			else
			{
				ColorPickerUI.LAIEKOOCNPC(JIIGOACEIKL).NDHAENIONJB().FJAHJEMPPKH = GGONDBGBKHM();
			}
		}
	}

	public CharacterMaterial[] KJKCMOHGDPF(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 0; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 1; j < characterSprite.layerSettings[i].materials.Length; j++)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	private void OIBDBLCLACB()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("secret_token")) ? 8 : 0);
	}

	public CharacterMaterial[] BGAABFNPNJO(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 1; i < characterSprite.layerSettings.Length; i += 0)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 0; j < characterSprite.layerSettings[i].materials.Length; j += 0)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	[SpecialName]
	public CharacterMaterial JEMPOAFJPNK()
	{
		return _material;
	}

	public CharacterMaterial[] HNMPCANLANB(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 1; i < characterSprite.layerSettings.Length; i += 0)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 0; j < characterSprite.layerSettings[i].materials.Length; j += 0)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	[SpecialName]
	public int BJKLKHLOLCF()
	{
		return _buttonColour;
	}

	[SpecialName]
	public int NNDPGCDFELA()
	{
		return _buttonColour;
	}

	public void BLOJJBPEELJ(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public CharacterMaterial BHGGOPGIEJK()
	{
		return _material;
	}

	public void KHKBMIAMNCD(PointerEventData NPBAMEMNFBI)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker)
		{
			if (ColorPickerUI.MENNLOGFNOK(JIIGOACEIKL).OKIHALELCBL().useColourCollection)
			{
				ColorPickerUI.MDFIDKHOPDJ(JIIGOACEIKL).lastColour = ((Graphic)ColorPickerUI.NAGEHKBLJDL(JIIGOACEIKL).DGMBNHPOCHB().image).color;
				((Graphic)ColorPickerUI.NAGEHKBLJDL(JIIGOACEIKL).NFAOOGPOPPA().image).color = ((Graphic)image).color;
				ColorPickerUI.MDFIDKHOPDJ(JIIGOACEIKL).lastButtonColour = ColorPickerUI.Get(JIIGOACEIKL).NFAOOGPOPPA().LGMJDCFHPJL();
				ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).BNCLELJDNLN().PNOBFHPHBCA(OGPAFJJBADA());
			}
			else if (ColorPickerUI.MDFIDKHOPDJ(JIIGOACEIKL).OKIHALELCBL().useCharacterMaterial)
			{
				ColorPickerUI.DOGBDIOJAHO(JIIGOACEIKL).lastMaterial = ColorPickerUI.MENPEHNHFOA(JIIGOACEIKL).OKIHALELCBL().BHGGOPGIEJK();
				ColorPickerUI.MENPEHNHFOA(JIIGOACEIKL).DGMBNHPOCHB().AKFPBELHLNF(_material);
			}
			else
			{
				ColorPickerUI.EOPIEMLAPFN(JIIGOACEIKL).lastSpriteColor = ColorPickerUI.JDODHPEDACJ(JIIGOACEIKL).AMOJCIGDHPP().OAAPLEHDDKL();
				ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).DGMBNHPOCHB().FJAHJEMPPKH = _spriteColor;
			}
		}
	}

	public void OIOFPCBGBAI(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.LAIEKOOCNPC(JIIGOACEIKL).DCPNDPLOHHL()))
		{
			if (ColorPickerUI.JDODHPEDACJ(JIIGOACEIKL).MJIHBJMENJL().useColourCollection)
			{
				((Graphic)ColorPickerUI.LAIEKOOCNPC(JIIGOACEIKL).MJIHBJMENJL().image).color = ((Graphic)image).color;
				ColorPickerUI.MDINEPBJFKG(JIIGOACEIKL).NDHAENIONJB().GOMENLPLGCH(LGMJDCFHPJL());
			}
			else if (ColorPickerUI.LAMFGLIGLOP(JIIGOACEIKL).DGMBNHPOCHB().useCharacterMaterial)
			{
				ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).AMOJCIGDHPP().AKFPBELHLNF(GLDAIICHHEC());
			}
			else
			{
				ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).AMOJCIGDHPP().FJAHJEMPPKH = FNOKNEOHJKG();
			}
		}
	}

	private void Start()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	[SpecialName]
	public SpriteColor FNOKNEOHJKG()
	{
		return _spriteColor;
	}

	public void HCKCEJLCLMF(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.BPBMLNJGGII(JIIGOACEIKL).HGOLAEMONPI))
		{
			if (ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).NDHAENIONJB().useColourCollection)
			{
				((Graphic)ColorPickerUI.MENNLOGFNOK(JIIGOACEIKL).DOEDBIGMKBG().image).color = ((Graphic)image).color;
				ColorPickerUI.LAMFGLIGLOP(JIIGOACEIKL).NFAOOGPOPPA().EBMGIGLIKDL(OGPAFJJBADA());
			}
			else if (ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).DOEDBIGMKBG().useCharacterMaterial)
			{
				ColorPickerUI.NDJAMDLOIJL(JIIGOACEIKL).KFILDGLMNJK().NGFHDHNFAEG(LDLEJGCFGAB());
			}
			else
			{
				ColorPickerUI.IEPGACAGIPO(JIIGOACEIKL).DKHDHEPKGKA().FJAHJEMPPKH = DGNHFNFAAIN();
			}
		}
	}

	public CharacterMaterial[] MCNNAAIIDKP(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 0; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 0; j < characterSprite.layerSettings[i].materials.Length; j += 0)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	public void ABEAKPEJKID(PointerEventData NPBAMEMNFBI)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker)
		{
			if (ColorPickerUI.MENNLOGFNOK(JIIGOACEIKL).NDHAENIONJB().useColourCollection)
			{
				ColorPickerUI.BPBMLNJGGII(JIIGOACEIKL).lastColour = ((Graphic)ColorPickerUI.JDODHPEDACJ(JIIGOACEIKL).PHOLBILDCAC().image).color;
				((Graphic)ColorPickerUI.JDODHPEDACJ(JIIGOACEIKL).OKIHALELCBL().image).color = ((Graphic)image).color;
				ColorPickerUI.LAIEKOOCNPC(JIIGOACEIKL).lastButtonColour = ColorPickerUI.DOGBDIOJAHO(JIIGOACEIKL).DOEDBIGMKBG().NNDPGCDFELA();
				ColorPickerUI.LAMFGLIGLOP(JIIGOACEIKL).PHOLBILDCAC().PNOBFHPHBCA(NCHKDCMNDAD);
			}
			else if (ColorPickerUI.LAMFGLIGLOP(JIIGOACEIKL).DOEDBIGMKBG().useCharacterMaterial)
			{
				ColorPickerUI.EOPIEMLAPFN(JIIGOACEIKL).lastMaterial = ColorPickerUI.NDJAMDLOIJL(JIIGOACEIKL).DKHDHEPKGKA().JEMPOAFJPNK();
				ColorPickerUI.MDFIDKHOPDJ(JIIGOACEIKL).NDHAENIONJB().IJLMMBMPALC(_material);
			}
			else
			{
				ColorPickerUI.HEGPDGJEOPC(JIIGOACEIKL).lastSpriteColor = ColorPickerUI.MENPEHNHFOA(JIIGOACEIKL).DCPNDPLOHHL().DGNHFNFAAIN();
				ColorPickerUI.OCCEHEMCGJF(JIIGOACEIKL).JBBKMBEJCBO().FJAHJEMPPKH = _spriteColor;
			}
		}
	}

	public CharacterMaterial[] GetMaterialsAvailable(CharacterCreator FBDKDGBBPKI)
	{
		CharacterSprite characterSprite = FBDKDGBBPKI.humanInfo.CONPDKDNOBO(bodyPart);
		List<CharacterMaterial> list = new List<CharacterMaterial>();
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 0; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer != layer)
				{
					continue;
				}
				list.Clear();
				for (int j = 0; j < characterSprite.layerSettings[i].materials.Length; j++)
				{
					if (!list.Contains(characterSprite.layerSettings[i].materials[j]))
					{
						list.Add(characterSprite.layerSettings[i].materials[j]);
					}
				}
				return list.ToArray();
			}
		}
		return null;
	}

	public void GEBNHOAGNAI(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.Get(JIIGOACEIKL).NDHAENIONJB()))
		{
			if (ColorPickerUI.EOPIEMLAPFN(JIIGOACEIKL).DGMBNHPOCHB().useColourCollection)
			{
				((Graphic)ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).NDHAENIONJB().image).color = ((Graphic)image).color;
				ColorPickerUI.JDODHPEDACJ(JIIGOACEIKL).OKIHALELCBL().NCHKDCMNDAD = OLFEAIHLMKH();
			}
			else if (ColorPickerUI.EGBMJGOCIJJ(JIIGOACEIKL).BNCLELJDNLN().useCharacterMaterial)
			{
				ColorPickerUI.LAIEKOOCNPC(JIIGOACEIKL).OMADFMLDBCP().FCKNPOACOPA(JEMPOAFJPNK());
			}
			else
			{
				ColorPickerUI.DOGBDIOJAHO(JIIGOACEIKL).DOEDBIGMKBG().FJAHJEMPPKH = OAAPLEHDDKL();
			}
		}
	}

	[SpecialName]
	public CharacterMaterial LNAJFLGDACJ()
	{
		return _material;
	}

	public void AMHBOHLPDMJ(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = FLABEDBELMF;
		}
	}

	public void GCJNJDPHIHM(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = FLABEDBELMF;
		}
	}

	public void FBEFBJAHNIL(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.Get(JIIGOACEIKL).OMADFMLDBCP()))
		{
			if (ColorPickerUI.CCGPMEADLDG(JIIGOACEIKL).DOEDBIGMKBG().useColourCollection)
			{
				((Graphic)ColorPickerUI.JDODHPEDACJ(JIIGOACEIKL).KLHGJLAHPDL().image).color = ((Graphic)image).color;
				ColorPickerUI.HEGPDGJEOPC(JIIGOACEIKL).EFCDHLHIIAM().HNAIFDIBDNH(AHGLCFFOBMI());
			}
			else if (ColorPickerUI.IEPGACAGIPO(JIIGOACEIKL).KFILDGLMNJK().useCharacterMaterial)
			{
				ColorPickerUI.Get(JIIGOACEIKL).DKHDHEPKGKA().FCKNPOACOPA(AFPDBMKOEAE());
			}
			else
			{
				ColorPickerUI.MDFIDKHOPDJ(JIIGOACEIKL).AMOJCIGDHPP().FJAHJEMPPKH = DKACEGLCNDB();
			}
		}
	}

	private void FHEGBNMJADG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("ThemeTriggerCanvas")) ? 0 : 0);
	}

	[SpecialName]
	public void DLPFOPBFJEN(int AODONKKHPBP)
	{
		_buttonColour = AODONKKHPBP;
		OnColorIndexChanged();
	}

	[SpecialName]
	public void EBMGIGLIKDL(int AODONKKHPBP)
	{
		_buttonColour = AODONKKHPBP;
		OnColorIndexChanged();
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker)
		{
			if (ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.useColourCollection)
			{
				ColorPickerUI.Get(JIIGOACEIKL).lastColour = ((Graphic)ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.image).color;
				((Graphic)ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.image).color = ((Graphic)image).color;
				ColorPickerUI.Get(JIIGOACEIKL).lastButtonColour = ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.NCHKDCMNDAD;
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.NCHKDCMNDAD = NCHKDCMNDAD;
			}
			else if (ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.useCharacterMaterial)
			{
				ColorPickerUI.Get(JIIGOACEIKL).lastMaterial = ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.GGHLHODEPIK;
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.GGHLHODEPIK = _material;
			}
			else
			{
				ColorPickerUI.Get(JIIGOACEIKL).lastSpriteColor = ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.FJAHJEMPPKH;
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.FJAHJEMPPKH = _spriteColor;
			}
		}
	}

	private void OKAPGNGLOHO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Open")) ? 0 : 0);
	}

	public void ToggleColorPicker()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker)
		{
			if (ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.useColourCollection)
			{
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.UpdateColor(((Graphic)image).color);
				ColorPickerUI.Get(JIIGOACEIKL).CloseUI();
			}
			else
			{
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI.OnColorChanged(_spriteColor);
				ColorPickerUI.Get(JIIGOACEIKL).CloseUI();
			}
		}
		else if (ColorPickerUI.Get(JIIGOACEIKL).IsOpen())
		{
			if ((Object)(object)ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI == (Object)(object)this)
			{
				ColorPickerUI.Get(JIIGOACEIKL).CloseUI();
			}
			else
			{
				ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI = this;
			}
		}
		else
		{
			ColorPickerUI.Get(JIIGOACEIKL).HGOLAEMONPI = this;
		}
	}

	[SpecialName]
	public CharacterMaterial AFPDBMKOEAE()
	{
		return _material;
	}

	public void LCPLABOGGML(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.BPBMLNJGGII(JIIGOACEIKL).OMADFMLDBCP()))
		{
			if (ColorPickerUI.LAMFGLIGLOP(JIIGOACEIKL).EFCDHLHIIAM().useColourCollection)
			{
				((Graphic)ColorPickerUI.DOGBDIOJAHO(JIIGOACEIKL).KFILDGLMNJK().image).color = ((Graphic)image).color;
				ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).OKIHALELCBL().JBFIDCLMIJF(IFDEEGLBIEM());
			}
			else if (ColorPickerUI.LAIEKOOCNPC(JIIGOACEIKL).DKHDHEPKGKA().useCharacterMaterial)
			{
				ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).OKIHALELCBL().NGFHDHNFAEG(LDLEJGCFGAB());
			}
			else
			{
				ColorPickerUI.EOPIEMLAPFN(JIIGOACEIKL).EFCDHLHIIAM().FJAHJEMPPKH = CKCBDOLPFGC();
			}
		}
	}

	public void NOANJAOCDDC(BaseEventData NPBAMEMNFBI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!openPicker && Object.op_Implicit((Object)(object)ColorPickerUI.Get(JIIGOACEIKL).DOEDBIGMKBG()))
		{
			if (ColorPickerUI.BMFHCBOFHCN(JIIGOACEIKL).DKHDHEPKGKA().useColourCollection)
			{
				((Graphic)ColorPickerUI.LAIEKOOCNPC(JIIGOACEIKL).DOEDBIGMKBG().image).color = ((Graphic)image).color;
				ColorPickerUI.EOPIEMLAPFN(JIIGOACEIKL).NDHAENIONJB().JBFIDCLMIJF(BJKLKHLOLCF());
			}
			else if (ColorPickerUI.EOPIEMLAPFN(JIIGOACEIKL).EFCDHLHIIAM().useCharacterMaterial)
			{
				ColorPickerUI.LAMFGLIGLOP(JIIGOACEIKL).KFILDGLMNJK().EICFBFELOPD(BHGGOPGIEJK());
			}
			else
			{
				ColorPickerUI.MENNLOGFNOK(JIIGOACEIKL).JBBKMBEJCBO().FJAHJEMPPKH = FJAHJEMPPKH;
			}
		}
	}
}
