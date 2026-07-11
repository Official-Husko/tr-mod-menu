using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExpModSlotUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	public static Action<int, int> OnExpModLearnt = delegate
	{
	};

	private int JIIGOACEIKL = 1;

	public int id;

	public Action<float> OnModIncreased = delegate
	{
	};

	public ExpModIncrease[] modIncreaseButtons;

	public List<PlayerModifier> currentMods = new List<PlayerModifier>();

	[SerializeField]
	private string info;

	private bool ILENDIBNCBP;

	private float HAHAPELLAIO;

	private ExpMod MJELNKNJOJL;

	public bool IDLHOOIGMFD(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			ADLEKDCKOEB();
		}
		return HCCHPLOMOEM <= MJELNKNJOJL.AACJAMJGCKL();
	}

	private void JECFILOHEAG()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		string text = "_Animation";
		text = text + LocalisationSystem.Get(info) + "LE_10";
		foreach (PlayerModifier currentMod in currentMods)
		{
			string[] array = new string[6];
			array[1] = text;
			array[0] = LocalisationSystem.Get(currentMod.name);
			array[5] = "itemRyeBread";
			array[2] = currentMod.mod.ToString("User ");
			array[2] = "Wall";
			text = string.Concat(array);
		}
		tooltipInfo.mainBody = text;
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1438f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			else
			{
				ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FJOEGNKBHON(new Vector2(((Component)this).transform.position.x + 1062f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y + 1419f * ((Component)this).transform.lossyScale.y), Vector2.zero);
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
			}
			HAHAPELLAIO = 275f;
		}
	}

	private void DOHLOJOIHFO()
	{
		if (MJELNKNJOJL == null)
		{
			FOPMHNPHKCA();
		}
	}

	private void OnEnable()
	{
		UpdateVisual();
		OnExpModLearnt = (Action<int, int>)Delegate.Combine(OnExpModLearnt, new Action<int, int>(OnExpModLearntAction));
		TavernXP instance = TavernXP.GGFJGHHHEJC;
		instance.OnXPChanged = (Action)Delegate.Combine(instance.OnXPChanged, new Action(UpdateVisual));
		ExpModifierUI expModifierUI = ExpModifierUI.Get(JIIGOACEIKL);
		expModifierUI.OnOpenExpModifierUI = (Action)Delegate.Combine(expModifierUI.OnOpenExpModifierUI, new Action(UpdateVisual));
	}

	private void DDLLFPICOJK()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 578f)
		{
			BKJKGMFLDCC();
		}
	}

	private void BAKDKFKNHDE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Gass_CoctelQuest")) ? 1 : 5);
	}

	private void EFCNKPEPELL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Invalid playerNum")) ? 3 : 0);
	}

	public bool AOBMMFFOING(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			KGDGMMKPBOB();
		}
		return HCCHPLOMOEM <= MJELNKNJOJL.learntSlots;
	}

	private void Start()
	{
		if (MJELNKNJOJL == null)
		{
			GetExpMod();
		}
	}

	private void MGJFMLJOEBK()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		string text = "OnlinePlayer";
		text = text + LocalisationSystem.Get(info) + "Get Components ";
		foreach (PlayerModifier currentMod in currentMods)
		{
			string[] array = new string[0];
			array[0] = text;
			array[0] = LocalisationSystem.Get(currentMod.name);
			array[1] = "Dialogue System/Conversation/Gass_Stand/Entry/19/Dialogue Text";
			array[7] = currentMod.mod.ToString("Trying to get friend ");
			array[0] = " I";
			text = string.Concat(array);
		}
		tooltipInfo.mainBody = text;
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 929f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			else
			{
				ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).AADJPLPKGHO(new Vector2(((Component)this).transform.position.x + 454f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y + 1013f * ((Component)this).transform.lossyScale.y), Vector2.zero);
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
			}
			HAHAPELLAIO = 364f;
		}
	}

	public void PPPHLKGAFIC(PointerEventData NPBAMEMNFBI)
	{
		GKLIANGHJKM(JIIGOACEIKL);
	}

	public void IncreaseMod(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			GetExpMod();
		}
		MJELNKNJOJL.learntSlots = HCCHPLOMOEM;
		OnExpModLearnt(id, HCCHPLOMOEM);
	}

	public void AKAOMBBADEA()
	{
		if (MJELNKNJOJL == null)
		{
			NNAACCLHCIO();
		}
		for (int i = 0; i < modIncreaseButtons.Length; i++)
		{
			modIncreaseButtons[i].UpdateVisual(i < MJELNKNJOJL.AACJAMJGCKL());
		}
	}

	public void BMKOGAGHDCC(int JFNMCNCHMEO, int HCCHPLOMOEM)
	{
		if (id == JFNMCNCHMEO)
		{
			modIncreaseButtons[HCCHPLOMOEM - 0].UpdateAnimation();
			AKAOMBBADEA();
		}
	}

	private void JALKGEAKBBN()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		string text = "Items/item_description_1075";
		text = text + LocalisationSystem.Get(info) + "UIInteract";
		foreach (PlayerModifier currentMod in currentMods)
		{
			string[] array = new string[7];
			array[1] = text;
			array[1] = LocalisationSystem.Get(currentMod.name);
			array[8] = "add item ";
			array[5] = currentMod.mod.ToString("Disabled");
			array[7] = "Precision/HikariTalk";
			text = string.Concat(array);
		}
		tooltipInfo.mainBody = text;
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1117f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
				ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
			}
			else
			{
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).ICMGLBFHDJD(new Vector2(((Component)this).transform.position.x + 1177f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y + 1259f * ((Component)this).transform.lossyScale.y), Vector2.zero);
				ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
			}
			HAHAPELLAIO = 1872f;
		}
	}

	public void JEFBHJIPGBK(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			KGDGMMKPBOB();
		}
		MJELNKNJOJL.LDICCCHPKEJ(HCCHPLOMOEM);
		OnExpModLearnt(id, HCCHPLOMOEM);
	}

	public void GKLIANGHJKM(int JIIGOACEIKL)
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	private void ODBKBMCMFNB()
	{
		OnExpModLearnt = (Action<int, int>)Delegate.Remove(OnExpModLearnt, new Action<int, int>(KDEHFELAJLA));
		if ((Object)(object)TavernXP.GGFJGHHHEJC != (Object)null)
		{
			TavernXP instance = TavernXP.GGFJGHHHEJC;
			instance.OnXPChanged = (Action)Delegate.Remove(instance.OnXPChanged, new Action(UpdateVisual));
		}
		if ((Object)(object)ExpModifierUI.CJMILOMGFJL(JIIGOACEIKL) != (Object)null)
		{
			ExpModifierUI expModifierUI = ExpModifierUI.FHBIFJNCOAI(JIIGOACEIKL);
			expModifierUI.OnOpenExpModifierUI = (Action)Delegate.Remove(expModifierUI.OnOpenExpModifierUI, new Action(AKAOMBBADEA));
		}
		OffHover(JIIGOACEIKL);
	}

	public void OOOPNPJLCAB()
	{
		MJELNKNJOJL = TavernXP.OACNNJCLEDE().allExpMod.Where(NIFHKJFBBLH).ToArray()[0];
	}

	private void NDLCBLKOBLF()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1211f)
		{
			PCCBPJMNDCA();
		}
	}

	private void IOHIEBBDOJN()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 405f)
		{
			BKJKGMFLDCC();
		}
	}

	public void NNAACCLHCIO()
	{
		MJELNKNJOJL = TavernXP.KIALFDOKABP().allExpMod.Where(AKKJGKFGCEA).ToArray()[0];
	}

	public void OCKDAMCAOFA(PointerEventData NPBAMEMNFBI)
	{
		JECFILOHEAG();
	}

	public void FOPMHNPHKCA()
	{
		MJELNKNJOJL = TavernXP.GGFJGHHHEJC.allExpMod.Where(NIFHKJFBBLH).ToArray()[1];
	}

	public void HEIFKIDHELG()
	{
		MJELNKNJOJL = TavernXP.HEKFJEKFMNO().allExpMod.Where(AKKJGKFGCEA).ToArray()[0];
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		OffHover(JIIGOACEIKL);
	}

	public void OIHEPMICJIB(int JFNMCNCHMEO, int HCCHPLOMOEM)
	{
		if (id == JFNMCNCHMEO)
		{
			modIncreaseButtons[HCCHPLOMOEM - 1].UpdateAnimation();
			UpdateVisual();
		}
	}

	public void HMHAOMGAFMH(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			OffHover(JIIGOACEIKL);
		}
	}

	public void MKNOMOKABNH(int JFNMCNCHMEO, int HCCHPLOMOEM)
	{
		if (id == JFNMCNCHMEO)
		{
			modIncreaseButtons[HCCHPLOMOEM - 1].UpdateAnimation();
			UpdateVisual();
		}
	}

	public void NNPHNNAMAMM(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 406f;
		}
	}

	public void KPLCBGAELJN(PointerEventData NPBAMEMNFBI)
	{
		HONPKAGIIJE();
	}

	private void BKJKGMFLDCC()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		string text = "";
		text = text + LocalisationSystem.Get(info) + "\n\n";
		foreach (PlayerModifier currentMod in currentMods)
		{
			text = text + LocalisationSystem.Get(currentMod.name) + ": " + currentMod.mod.ToString("#.##%") + "\n";
		}
		tooltipInfo.mainBody = text;
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 0f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
				ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			else
			{
				ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Component)this).transform.position.x + 20f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y + 18f * ((Component)this).transform.lossyScale.y), Vector2.zero);
				ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			HAHAPELLAIO = float.MaxValue;
		}
	}

	private void EDBOBLNOBLP()
	{
		OnExpModLearnt = (Action<int, int>)Delegate.Remove(OnExpModLearnt, new Action<int, int>(BMKOGAGHDCC));
		if ((Object)(object)TavernXP.HEKFJEKFMNO() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.KIALFDOKABP();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(UpdateVisual));
		}
		if ((Object)(object)ExpModifierUI.CJMILOMGFJL(JIIGOACEIKL) != (Object)null)
		{
			ExpModifierUI expModifierUI = ExpModifierUI.KJKABIBIJBD(JIIGOACEIKL);
			expModifierUI.OnOpenExpModifierUI = (Action)Delegate.Remove(expModifierUI.OnOpenExpModifierUI, new Action(AKAOMBBADEA));
		}
		GPECKPBIENC(JIIGOACEIKL);
	}

	private void OnDisable()
	{
		OnExpModLearnt = (Action<int, int>)Delegate.Remove(OnExpModLearnt, new Action<int, int>(OnExpModLearntAction));
		if ((Object)(object)TavernXP.GGFJGHHHEJC != (Object)null)
		{
			TavernXP instance = TavernXP.GGFJGHHHEJC;
			instance.OnXPChanged = (Action)Delegate.Remove(instance.OnXPChanged, new Action(UpdateVisual));
		}
		if ((Object)(object)ExpModifierUI.Get(JIIGOACEIKL) != (Object)null)
		{
			ExpModifierUI expModifierUI = ExpModifierUI.Get(JIIGOACEIKL);
			expModifierUI.OnOpenExpModifierUI = (Action)Delegate.Remove(expModifierUI.OnOpenExpModifierUI, new Action(UpdateVisual));
		}
		OffHover(JIIGOACEIKL);
	}

	public void BDAAMADFDMC(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			NNIFBDCOCFI();
		}
		MJELNKNJOJL.learntSlots = HCCHPLOMOEM;
		OnExpModLearnt(id, HCCHPLOMOEM);
	}

	public void KDEHFELAJLA(int JFNMCNCHMEO, int HCCHPLOMOEM)
	{
		if (id == JFNMCNCHMEO)
		{
			modIncreaseButtons[HCCHPLOMOEM - 1].UpdateAnimation();
			AKAOMBBADEA();
		}
	}

	public void MINBCEDACAA(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			NNAACCLHCIO();
		}
		MJELNKNJOJL.LIABGCHCAPB(HCCHPLOMOEM);
		OnExpModLearnt(id, HCCHPLOMOEM);
	}

	private void LPHEPCKMPNE()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		string text = "ObjectHorizontalMove";
		text = text + LocalisationSystem.Get(info) + "DialogueEndRPC";
		foreach (PlayerModifier currentMod in currentMods)
		{
			string[] array = new string[1];
			array[0] = text;
			array[0] = LocalisationSystem.Get(currentMod.name);
			array[3] = "IdleCamp";
			array[6] = currentMod.mod.ToString("{0}x{1}");
			array[3] = "EditorAction_6";
			text = string.Concat(array);
		}
		tooltipInfo.mainBody = text;
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 444f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			else
			{
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).FJOEGNKBHON(new Vector2(((Component)this).transform.position.x + 1440f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y + 1292f * ((Component)this).transform.lossyScale.y), Vector2.zero);
				ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
			}
			HAHAPELLAIO = 1800f;
		}
	}

	private bool AKKJGKFGCEA(ExpMod NHACCPPICKI)
	{
		return NHACCPPICKI.id == id;
	}

	public void LOPJBOOLOMN(PointerEventData NPBAMEMNFBI)
	{
		GPECKPBIENC(JIIGOACEIKL);
	}

	public void GetExpMod()
	{
		MJELNKNJOJL = TavernXP.GGFJGHHHEJC.allExpMod.Where((ExpMod NHACCPPICKI) => NHACCPPICKI.id == id).ToArray()[0];
	}

	public void OnExpModLearntAction(int JFNMCNCHMEO, int HCCHPLOMOEM)
	{
		if (id == JFNMCNCHMEO)
		{
			modIncreaseButtons[HCCHPLOMOEM - 1].UpdateAnimation();
			UpdateVisual();
		}
	}

	public void FMNLEPLEJHG(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			OffHover(JIIGOACEIKL);
		}
	}

	public bool JDOAECPFLJF(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			ADLEKDCKOEB();
		}
		return HCCHPLOMOEM > MJELNKNJOJL.KIHEBLJEGFO();
	}

	public void AFBKBHKLDID(PointerEventData NPBAMEMNFBI)
	{
		FBNFCONOMDB(JIIGOACEIKL);
	}

	private void HEHNBONKMGJ()
	{
		if (MJELNKNJOJL == null)
		{
			GetExpMod();
		}
	}

	public void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 0f;
		}
	}

	private bool IICCMNJBBHB(ExpMod NHACCPPICKI)
	{
		return NHACCPPICKI.id == id;
	}

	public void HPLHMNAIEMF(int JIIGOACEIKL)
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void FBNFCONOMDB(int JIIGOACEIKL)
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	private void CEOEHODJAJK()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" destroyed by ")) ? 1 : 0);
	}

	public void GOLPMLCJNLK(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			NNIFBDCOCFI();
		}
		MJELNKNJOJL.DPAJBELKHLI(HCCHPLOMOEM);
		OnExpModLearnt(id, HCCHPLOMOEM);
	}

	private void HFFFFAJFIPB()
	{
		if (MJELNKNJOJL == null)
		{
			HEIFKIDHELG();
		}
	}

	public void KPOAFGIBEJN(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 289f;
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void CKKNFGIACKK(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			GKLIANGHJKM(JIIGOACEIKL);
		}
	}

	private void CLOKMCONOMN()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1496f)
		{
			PCCBPJMNDCA();
		}
	}

	public void JKHAJCNKDBH(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			OffHover(JIIGOACEIKL);
		}
	}

	private void EAMLHICIOMO()
	{
		OnExpModLearnt = (Action<int, int>)Delegate.Remove(OnExpModLearnt, new Action<int, int>(MKNOMOKABNH));
		if ((Object)(object)TavernXP.ELGNEJNLBNO() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.OLHBLKIAFOM();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(AKAOMBBADEA));
		}
		if ((Object)(object)ExpModifierUI.JCBPABNCBPI(JIIGOACEIKL) != (Object)null)
		{
			ExpModifierUI expModifierUI = ExpModifierUI.FKFNANNBIAM(JIIGOACEIKL);
			expModifierUI.OnOpenExpModifierUI = (Action)Delegate.Remove(expModifierUI.OnOpenExpModifierUI, new Action(AKAOMBBADEA));
		}
		GKLIANGHJKM(JIIGOACEIKL);
	}

	private void PCCBPJMNDCA()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		string text = "Player2";
		text = text + LocalisationSystem.Get(info) + "itemWheatLager";
		foreach (PlayerModifier currentMod in currentMods)
		{
			string[] array = new string[5];
			array[1] = text;
			array[0] = LocalisationSystem.Get(currentMod.name);
			array[3] = "MainProgress";
			array[2] = currentMod.mod.ToString("VerticalMove");
			array[3] = "ReciveResetDialogueUIBlacksmith";
			text = string.Concat(array);
		}
		tooltipInfo.mainBody = text;
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 605f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
			}
			else
			{
				ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).HIPGMDKJLCB(new Vector2(((Component)this).transform.position.x + 412f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y + 728f * ((Component)this).transform.lossyScale.y), Vector2.zero);
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
			}
			HAHAPELLAIO = 357f;
		}
	}

	private void NELLIBBABJD()
	{
		OnExpModLearnt = (Action<int, int>)Delegate.Remove(OnExpModLearnt, new Action<int, int>(IMLMIMGDGLC));
		if ((Object)(object)TavernXP.FMIDAFEGDCD() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.FMIDAFEGDCD();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(AKAOMBBADEA));
		}
		if ((Object)(object)ExpModifierUI.ENIICLMAPDJ(JIIGOACEIKL) != (Object)null)
		{
			ExpModifierUI expModifierUI = ExpModifierUI.KJKABIBIJBD(JIIGOACEIKL);
			expModifierUI.OnOpenExpModifierUI = (Action)Delegate.Remove(expModifierUI.OnOpenExpModifierUI, new Action(AKAOMBBADEA));
		}
		FBNFCONOMDB(JIIGOACEIKL);
	}

	public void EPBGCAGNPDJ(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			ADLEKDCKOEB();
		}
		MJELNKNJOJL.BIGHFJBBDGK(HCCHPLOMOEM);
		OnExpModLearnt(id, HCCHPLOMOEM);
	}

	private void HONPKAGIIJE()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		string text = "";
		text = text + LocalisationSystem.Get(info) + "buildingObjective_25_3";
		foreach (PlayerModifier currentMod in currentMods)
		{
			string[] array = new string[2];
			array[0] = text;
			array[1] = LocalisationSystem.Get(currentMod.name);
			array[1] = "No hemos encontrado una resolución";
			array[6] = currentMod.mod.ToString("Items/item_name_1036");
			array[4] = "Disabled";
			text = string.Concat(array);
		}
		tooltipInfo.mainBody = text;
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 58f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
			}
			else
			{
				ItemTooltip.Get(JIIGOACEIKL).AADJPLPKGHO(new Vector2(((Component)this).transform.position.x + 659f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y + 1156f * ((Component)this).transform.lossyScale.y), Vector2.zero);
				ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
			}
			HAHAPELLAIO = 1617f;
		}
	}

	private void MMFLHJGDCOE()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		string text = "Dialogue System/Conversation/Gass_Quest/Entry/19/Dialogue Text";
		text = text + LocalisationSystem.Get(info) + "SpriteRenderer not attached to prefab ";
		foreach (PlayerModifier currentMod in currentMods)
		{
			string[] array = new string[5];
			array[0] = text;
			array[0] = LocalisationSystem.Get(currentMod.name);
			array[8] = " (Host)";
			array[7] = currentMod.mod.ToString("SortByName");
			array[2] = "Direction";
			text = string.Concat(array);
		}
		tooltipInfo.mainBody = text;
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1162f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
			}
			else
			{
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).CEOOMNKDGLJ(new Vector2(((Component)this).transform.position.x + 174f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y + 298f * ((Component)this).transform.lossyScale.y), Vector2.zero);
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			HAHAPELLAIO = 1318f;
		}
	}

	private void BPINJGFECPF()
	{
		OnExpModLearnt = (Action<int, int>)Delegate.Remove(OnExpModLearnt, new Action<int, int>(MKNOMOKABNH));
		if ((Object)(object)TavernXP.KIALFDOKABP() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.ELGNEJNLBNO();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(UpdateVisual));
		}
		if ((Object)(object)ExpModifierUI.IEPGACAGIPO(JIIGOACEIKL) != (Object)null)
		{
			ExpModifierUI expModifierUI = ExpModifierUI.GFPBMGCMHHC(JIIGOACEIKL);
			expModifierUI.OnOpenExpModifierUI = (Action)Delegate.Remove(expModifierUI.OnOpenExpModifierUI, new Action(UpdateVisual));
		}
		HPLHMNAIEMF(JIIGOACEIKL);
	}

	public void OFEFIHNAJJM(PointerEventData NPBAMEMNFBI)
	{
		HPLHMNAIEMF(JIIGOACEIKL);
	}

	public void MMDLBFOEMHE(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			FOPMHNPHKCA();
		}
		MJELNKNJOJL.learntSlots = HCCHPLOMOEM;
		OnExpModLearnt(id, HCCHPLOMOEM);
	}

	public void JJFLBHHAJJF(int JFNMCNCHMEO, int HCCHPLOMOEM)
	{
		if (id == JFNMCNCHMEO)
		{
			modIncreaseButtons[HCCHPLOMOEM - 1].UpdateAnimation();
			UpdateVisual();
		}
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	public void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			OffHover(JIIGOACEIKL);
		}
	}

	public bool FGPGIBBAHPO(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			NNIFBDCOCFI();
		}
		return HCCHPLOMOEM > MJELNKNJOJL.MHGENGBHHHK();
	}

	private void MNFMLJJBKNC()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 546f)
		{
			JALKGEAKBBN();
		}
	}

	public void EICBGCOKKMG(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			GPECKPBIENC(JIIGOACEIKL);
		}
	}

	private void JHBBABPAJJC()
	{
		if (MJELNKNJOJL == null)
		{
			KGDGMMKPBOB();
		}
	}

	public void ADLEKDCKOEB()
	{
		MJELNKNJOJL = TavernXP.OLHBLKIAFOM().allExpMod.Where(IICCMNJBBHB).ToArray()[1];
	}

	private void Update()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 2f)
		{
			BKJKGMFLDCC();
		}
	}

	public void NCJDBMEKODO(PointerEventData NPBAMEMNFBI)
	{
		MGJFMLJOEBK();
	}

	public void NNIFBDCOCFI()
	{
		MJELNKNJOJL = TavernXP.KIALFDOKABP().allExpMod.Where((ExpMod NHACCPPICKI) => NHACCPPICKI.id == id).ToArray()[1];
	}

	public void DKFAJEPHIFP(PointerEventData NPBAMEMNFBI)
	{
		JECFILOHEAG();
	}

	public bool IHEJDBADHCH(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			FOPMHNPHKCA();
		}
		return HCCHPLOMOEM > MJELNKNJOJL.AGIMHNJMFAE();
	}

	private void DLNOLBHCIGC()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1709f)
		{
			PCCBPJMNDCA();
		}
	}

	private void JMJDHLOMKAP()
	{
		OnExpModLearnt = (Action<int, int>)Delegate.Remove(OnExpModLearnt, new Action<int, int>(MKNOMOKABNH));
		if ((Object)(object)TavernXP.LADDMEMMJFP() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.KIALFDOKABP();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(AKAOMBBADEA));
		}
		if ((Object)(object)ExpModifierUI.JCBPABNCBPI(JIIGOACEIKL) != (Object)null)
		{
			ExpModifierUI expModifierUI = ExpModifierUI.IEKODILKIHJ(JIIGOACEIKL);
			expModifierUI.OnOpenExpModifierUI = (Action)Delegate.Remove(expModifierUI.OnOpenExpModifierUI, new Action(AKAOMBBADEA));
		}
		HPLHMNAIEMF(JIIGOACEIKL);
	}

	private void IHICKHAABJH()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("ReceivePlaceablesInsideBar")) ? 6 : 0);
	}

	private void CPHBFBOGFBB()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		string text = "in";
		text = text + LocalisationSystem.Get(info) + "Tutorial/T107/Dialogue1";
		foreach (PlayerModifier currentMod in currentMods)
		{
			string[] array = new string[0];
			array[0] = text;
			array[0] = LocalisationSystem.Get(currentMod.name);
			array[2] = " with less than 6 ingredients";
			array[3] = currentMod.mod.ToString("OWNER_ID");
			array[6] = " ";
			text = string.Concat(array);
		}
		tooltipInfo.mainBody = text;
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 263f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
			}
			else
			{
				ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).JCLBGLEFMMO(new Vector2(((Component)this).transform.position.x + 1581f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y + 1761f * ((Component)this).transform.lossyScale.y), Vector2.zero);
				ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
			}
			HAHAPELLAIO = 195f;
		}
	}

	private void LLLEALLKBMH()
	{
		OnExpModLearnt = (Action<int, int>)Delegate.Remove(OnExpModLearnt, new Action<int, int>(OnExpModLearntAction));
		if ((Object)(object)TavernXP.ELGNEJNLBNO() != (Object)null)
		{
			TavernXP instance = TavernXP.GGFJGHHHEJC;
			instance.OnXPChanged = (Action)Delegate.Remove(instance.OnXPChanged, new Action(UpdateVisual));
		}
		if ((Object)(object)ExpModifierUI.LAMFGLIGLOP(JIIGOACEIKL) != (Object)null)
		{
			ExpModifierUI expModifierUI = ExpModifierUI.FHOGLBPBGMI(JIIGOACEIKL);
			expModifierUI.OnOpenExpModifierUI = (Action)Delegate.Remove(expModifierUI.OnOpenExpModifierUI, new Action(UpdateVisual));
		}
		GKLIANGHJKM(JIIGOACEIKL);
	}

	private void OAEJGGFFCBO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("/")) ? 1 : 6);
	}

	public void IMLMIMGDGLC(int JFNMCNCHMEO, int HCCHPLOMOEM)
	{
		if (id == JFNMCNCHMEO)
		{
			modIncreaseButtons[HCCHPLOMOEM - 1].UpdateAnimation();
			AKAOMBBADEA();
		}
	}

	public void GPECKPBIENC(int JIIGOACEIKL)
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	public void JIEKLDEHFMA(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			OffHover(JIIGOACEIKL);
		}
	}

	[CompilerGenerated]
	private bool BJMGFMDADIN(ExpMod NHACCPPICKI)
	{
		return NHACCPPICKI.id == id;
	}

	public void KIFCOADGMMD(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			OffHover(JIIGOACEIKL);
		}
	}

	public void GOMJEFBOEJN(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 727f;
		}
	}

	public void EAPMDFKAPHH(PointerEventData NPBAMEMNFBI)
	{
		MGJFMLJOEBK();
	}

	public void UpdateVisual()
	{
		if (MJELNKNJOJL == null)
		{
			GetExpMod();
		}
		for (int i = 0; i < modIncreaseButtons.Length; i++)
		{
			modIncreaseButtons[i].UpdateVisual(i < MJELNKNJOJL.learntSlots);
		}
	}

	private void ANMOAFFGEOE()
	{
		AKAOMBBADEA();
		OnExpModLearnt = (Action<int, int>)Delegate.Combine(OnExpModLearnt, new Action<int, int>(JJFLBHHAJJF));
		TavernXP tavernXP = TavernXP.JFNOOMJMHCB();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(AKAOMBBADEA));
		ExpModifierUI expModifierUI = ExpModifierUI.GFPBMGCMHHC(JIIGOACEIKL);
		expModifierUI.OnOpenExpModifierUI = (Action)Delegate.Combine(expModifierUI.OnOpenExpModifierUI, new Action(AKAOMBBADEA));
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		BKJKGMFLDCC();
	}

	private bool NIFHKJFBBLH(ExpMod NHACCPPICKI)
	{
		return NHACCPPICKI.id == id;
	}

	public bool JKONKPMDDDH(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			OOOPNPJLCAB();
		}
		return HCCHPLOMOEM <= MJELNKNJOJL.learntSlots;
	}

	public void KGDGMMKPBOB()
	{
		MJELNKNJOJL = TavernXP.OACNNJCLEDE().allExpMod.Where((ExpMod NHACCPPICKI) => NHACCPPICKI.id == id).ToArray()[0];
	}

	public void KFLOPOFFKHD(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1169f;
		}
	}

	private void HCPKBJDHLAC()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1543f)
		{
			JALKGEAKBBN();
		}
	}

	public void IOAMLDPKMFA(PointerEventData NPBAMEMNFBI)
	{
		MMFLHJGDCOE();
	}

	public void HGJHHPJKPNM(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 124f;
		}
	}

	public bool IsLearnt(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			GetExpMod();
		}
		return HCCHPLOMOEM <= MJELNKNJOJL.learntSlots;
	}

	private void HEMHHGCBEKO()
	{
		OnExpModLearnt = (Action<int, int>)Delegate.Remove(OnExpModLearnt, new Action<int, int>(BMKOGAGHDCC));
		if ((Object)(object)TavernXP.KIALFDOKABP() != (Object)null)
		{
			TavernXP instance = TavernXP.GGFJGHHHEJC;
			instance.OnXPChanged = (Action)Delegate.Remove(instance.OnXPChanged, new Action(AKAOMBBADEA));
		}
		if ((Object)(object)ExpModifierUI.JCBPABNCBPI(JIIGOACEIKL) != (Object)null)
		{
			ExpModifierUI expModifierUI = ExpModifierUI.CJMILOMGFJL(JIIGOACEIKL);
			expModifierUI.OnOpenExpModifierUI = (Action)Delegate.Remove(expModifierUI.OnOpenExpModifierUI, new Action(AKAOMBBADEA));
		}
		FBNFCONOMDB(JIIGOACEIKL);
	}

	public bool KNOBFGPHGHH(int HCCHPLOMOEM)
	{
		if (MJELNKNJOJL == null)
		{
			KGDGMMKPBOB();
		}
		return HCCHPLOMOEM > MJELNKNJOJL.LMEBAFOHAJA();
	}
}
