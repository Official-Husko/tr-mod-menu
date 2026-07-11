using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class ToolUpgradeUI : UIWindow
{
	[CompilerGenerated]
	private sealed class KBKOAFJAPCE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ToolUpgradeUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public KBKOAFJAPCE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			ToolUpgradeUI toolUpgradeUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (PlayerInputs.IsGamepadActive(toolUpgradeUI.JIIGOACEIKL))
				{
					int num2 = 0;
					for (int i = 0; i < toolUpgradeUI.recipeSlots.Length; i++)
					{
						if (((Component)toolUpgradeUI.recipeSlots[i]).gameObject.activeSelf)
						{
							num2 = i;
							break;
						}
					}
					if (toolUpgradeUI.recipeSlots.Length != 0 && ((Component)toolUpgradeUI.recipeSlots[num2]).gameObject.activeSelf)
					{
						UISelectionManager.GetPlayer(toolUpgradeUI.JIIGOACEIKL).Select(((Component)toolUpgradeUI.recipeSlots[num2]).gameObject);
					}
				}
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public RecipeElementUI recipeElementInfo;

	public RecipeSlot[] recipeSlots;

	public static ToolUpgradeUI[] instances = new ToolUpgradeUI[3];

	private void ONHPCMIAIAJ()
	{
		OpenUI();
	}

	private void APGCPAMAMLO(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(0, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.AGFIIGGGBHC() && (Item.EKGNIODFJCO(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 1))))
			{
				continue;
			}
			while (num > 1)
			{
				Slot slot = CraftingInventory.OICKBPJPKPG(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: true, null);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.HBMBGCHGEGN(num2, CDPAMNIPPEC: true, 1);
				num -= num2;
			}
		}
	}

	private IEnumerator JKMCGONOMFJ()
	{
		return new KBKOAFJAPCE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EJMEAAHLKEP(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(1, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.IABMOBAKNAE() && (Item.GBMFCPGEJDK(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 0))))
			{
				continue;
			}
			while (num > 1)
			{
				Slot slot = CraftingInventory.MKNHIDCOHKK(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: false, null);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.JPACDDCJGPD(num2, CDPAMNIPPEC: false, 1);
				num -= num2;
			}
		}
	}

	public void OMIIKHIBKGC()
	{
		if (recipeElementInfo.HAFMNCODGLP())
		{
			NHAIOENADEO(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: false);
			ToolUpgradeManager.instance.AGFFCIELGPL(recipeElementInfo.GBJDNNCOIAC.output.item, CDPAMNIPPEC: true);
			BOBCIFEDJED();
			HallmundNPC.BAKPBHPNKPB().barkDialogue = true;
			HallmundNPC.MPJJAPCFENH().StartConversation(base.JIIGOACEIKL, "Winner", FLHBPHPKIML: true);
		}
	}

	private void OBHNMHDCKGO()
	{
		IDLAGJNLPJL();
	}

	private void ONNBIFOGOIK()
	{
		IDLAGJNLPJL();
	}

	private void CGOHGBAIHFF()
	{
		EDHEIFHAAKO();
	}

	private void ADBBFHGNELH()
	{
		DialogueLua.SetVariable("itemStick", (object)2);
	}

	private IEnumerator IJDKCIKHCHA()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		int num = 0;
		for (int i = 0; i < recipeSlots.Length; i++)
		{
			if (((Component)recipeSlots[i]).gameObject.activeSelf)
			{
				num = i;
				break;
			}
		}
		if (recipeSlots.Length != 0 && ((Component)recipeSlots[num]).gameObject.activeSelf)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)recipeSlots[num]).gameObject);
		}
	}

	public void KCHJKOENCOG()
	{
		if (recipeElementInfo.CanCraft())
		{
			NHAIOENADEO(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: true);
			ToolUpgradeManager.instance.IDDEEICFIPD(recipeElementInfo.GBJDNNCOIAC.output.item, CDPAMNIPPEC: true);
			BOBCIFEDJED();
			HallmundNPC.PFHFIJDDOME().barkDialogue = true;
			HallmundNPC.AFFGPMFKEFH().StartConversation(base.JIIGOACEIKL, "BeginChatFade");
		}
	}

	private void PDPABPHNJFL()
	{
		DialogueLua.SetVariable("Trying to add player but player list is full.", (object)4);
	}

	public void OFCEPINFLCM()
	{
		if (recipeElementInfo.HAFMNCODGLP())
		{
			MGOENBDPJBA(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: false);
			ToolUpgradeManager.instance.AHLPPNJELPA(recipeElementInfo.GBJDNNCOIAC.output.item);
			BOBCIFEDJED();
			HallmundNPC.MPJJAPCFENH().barkDialogue = true;
			HallmundNPC.EKDNJDJHONF().StartConversation(base.JIIGOACEIKL, "Left Trigger", FLHBPHPKIML: true);
		}
	}

	private void DCKNEJEKBKP()
	{
		DialogueLua.SetVariable("SprintHoldAction", (object)8);
	}

	protected void JCNOECLHOGL()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).IHDPOMIAKOO();
			((MonoBehaviour)this).StartCoroutine(GHLKHNEHAFF());
		}
	}

	public override void OnContentActivated()
	{
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		BBMMDEBJCEM();
	}

	protected void HKJHCIFLAPL()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).BIHHMCBFPNK();
			((MonoBehaviour)this).StartCoroutine(OFACPEFLGHI());
		}
	}

	public static ToolUpgradeUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ToolUpgradeUI COIEMAJLHAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ToolUpgradeUI NALKHGMLALJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected void BBMMDEBJCEM()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			((MonoBehaviour)this).StartCoroutine(IJDKCIKHCHA());
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public void Craft()
	{
		if (recipeElementInfo.CanCraft())
		{
			KAKOIEIIDHB(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: true);
			ToolUpgradeManager.instance.UpgradeTool(recipeElementInfo.GBJDNNCOIAC.output.item, CDPAMNIPPEC: true);
			CloseUI();
			HallmundNPC.GGFJGHHHEJC.barkDialogue = true;
			HallmundNPC.GGFJGHHHEJC.StartConversation(base.JIIGOACEIKL, "City/Hallmund/Bark/Tool", FLHBPHPKIML: true);
		}
	}

	private void DOGACDLINEC()
	{
		IDLAGJNLPJL();
	}

	protected void LBIEDJHAPNC()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).GGNLGAMLOKK();
			((MonoBehaviour)this).StartCoroutine(JKMCGONOMFJ());
		}
	}

	protected void CHNHEMPHMEJ()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).BEGCHMCDPOK();
			((MonoBehaviour)this).StartCoroutine(BMBKHJONDHB());
		}
	}

	private void MFMKMDLAHLM()
	{
		EDHEIFHAAKO();
	}

	public static ToolUpgradeUI MIFFCOMDIEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator JCCFFDAPEDD()
	{
		return new KBKOAFJAPCE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BMBKHJONDHB()
	{
		return new KBKOAFJAPCE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IHDCLJNPJOL()
	{
		DialogueLua.SetVariable("Tutorial/T131/Dialogue1", (object)4);
	}

	public static ToolUpgradeUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected void HCHPKDLFCMG()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).IHDPOMIAKOO();
			((MonoBehaviour)this).StartCoroutine(IJDKCIKHCHA());
		}
	}

	public static ToolUpgradeUI IEPGACAGIPO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FGDJBPDFPEG()
	{
		OpenUI();
	}

	private IEnumerator OFACPEFLGHI()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		int num = 0;
		for (int i = 0; i < recipeSlots.Length; i++)
		{
			if (((Component)recipeSlots[i]).gameObject.activeSelf)
			{
				num = i;
				break;
			}
		}
		if (recipeSlots.Length != 0 && ((Component)recipeSlots[num]).gameObject.activeSelf)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)recipeSlots[num]).gameObject);
		}
	}

	public static ToolUpgradeUI JDODHPEDACJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected void ALGOLHBOFMA()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).CKNJJKJDBGA();
			((MonoBehaviour)this).StartCoroutine(OFACPEFLGHI());
		}
	}

	protected void NIOJGHNJFJG()
	{
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).FJAKDODEIIF();
			((MonoBehaviour)this).StartCoroutine(AHPEBGGHCJO());
		}
	}

	private void HCLOGKPFEGF()
	{
		DialogueLua.SetVariable("Not enough ingredients", (object)0);
	}

	public static ToolUpgradeUI LAMFGLIGLOP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected void COIDFGFFHJP()
	{
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BEGCHMCDPOK();
			((MonoBehaviour)this).StartCoroutine(LABFGAOJLHO());
		}
	}

	public static ToolUpgradeUI MIAOGLENOHL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator AHPEBGGHCJO()
	{
		return new KBKOAFJAPCE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OKDHEIOEHBF(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(1, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.IABMOBAKNAE() && (Item.EKGNIODFJCO(recipeIngredient.mod, null) || item.JFHFEMDAHCD(JNLKEMLDFIM) > 0))))
			{
				continue;
			}
			while (num > 0)
			{
				Slot slot = CraftingInventory.OBAGDPEAAEI(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.BBHHJLIFNPP(num2, CDPAMNIPPEC: false, 1);
				num -= num2;
			}
		}
	}

	private void KEKPEEMEAEB()
	{
		DialogueLua.SetVariable("Tutorial_Objective_", (object)1);
	}

	public override void OpenUI()
	{
		base.OpenUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = false;
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		for (int i = 0; i < recipeSlots.Length; i++)
		{
			recipeSlots[i].recipeElementInfo = recipeElementInfo;
		}
		recipeSlots[0].OnClickToolUpgrade();
	}

	private void BCMGBKDHMOA()
	{
		DialogueLua.SetVariable("Player2", (object)3);
	}

	private void KJAGHPJBMGE()
	{
		DialogueLua.SetVariable("Pool Parent ", (object)2);
	}

	private void CLBHOAEOKID()
	{
		DialogueLua.SetVariable("-1", (object)0);
	}

	private IEnumerator GHLKHNEHAFF()
	{
		return new KBKOAFJAPCE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ONHIBPBEDOJ()
	{
		DialogueLua.SetVariable(" </mark>", (object)7);
	}

	private void ICBBCACPEKN(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(0, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.AGFIIGGGBHC() && (Item.EKMFELLJHFG(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 1))))
			{
				continue;
			}
			while (num > 0)
			{
				Slot slot = CraftingInventory.OBAGDPEAAEI(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: false, null);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.JPACDDCJGPD(num2, CDPAMNIPPEC: false, 1);
				num -= num2;
			}
		}
	}

	private void ADMKNICEJFF()
	{
		DialogueLua.SetVariable("Dialogue System/Conversation/EnterTavernDrink/Entry/2/Dialogue Text", (object)8);
	}

	public void MKIGPNHMNAH()
	{
		if (recipeElementInfo.CanCraft())
		{
			KAKOIEIIDHB(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: false);
			ToolUpgradeManager.instance.GAMHOHAJGHL(recipeElementInfo.GBJDNNCOIAC.output.item);
			BOBCIFEDJED();
			HallmundNPC.MPJJAPCFENH().barkDialogue = true;
			HallmundNPC.EKDNJDJHONF().StartConversation(base.JIIGOACEIKL, "Error_NoCatFoodOrWater");
		}
	}

	private void ECLMOGONMHD()
	{
		DialogueLua.SetVariable("On Simple Event ", (object)5);
	}

	protected void IMMOHMNCNGI()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).FBKDHHPNBIL();
			((MonoBehaviour)this).StartCoroutine(BMBKHJONDHB());
		}
	}

	private void EIOFAPAOECG()
	{
		DialogueLua.SetVariable("MineState", (object)2);
	}

	private void LIMJPECGMCI()
	{
		IDLAGJNLPJL();
	}

	public static ToolUpgradeUI NJOFJHCKGAL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FIECNCFPKDC(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(0, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.NGDPNIFFHKL() && (Item.EKMFELLJHFG(recipeIngredient.mod, null) || item.JFHFEMDAHCD(JNLKEMLDFIM) > 1))))
			{
				continue;
			}
			while (num > 1)
			{
				Slot slotWithItem = CraftingInventory.GetSlotWithItem(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
				if (slotWithItem == null)
				{
					break;
				}
				int num2 = Math.Min(slotWithItem.Stack, num);
				slotWithItem.JPACDDCJGPD(num2, CDPAMNIPPEC: true);
				num -= num2;
			}
		}
	}

	private void HBBGOMCHGPA()
	{
		OpenUI();
	}

	private void KAKOIEIIDHB(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(1, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.NGDPNIFFHKL() && (Item.NGIIPJDAMGP(recipeIngredient.mod, null) || item.JFHFEMDAHCD(JNLKEMLDFIM) > 1))))
			{
				continue;
			}
			while (num > 0)
			{
				Slot slotWithItem = CraftingInventory.GetSlotWithItem(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: true, null);
				if (slotWithItem == null)
				{
					break;
				}
				int num2 = Math.Min(slotWithItem.Stack, num);
				slotWithItem.FDOBDPPMMBH(num2, CDPAMNIPPEC: true);
				num -= num2;
			}
		}
	}

	private void MGOENBDPJBA(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(1, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.IABMOBAKNAE() && (Item.GBMFCPGEJDK(recipeIngredient.mod, null) || item.JFHFEMDAHCD(JNLKEMLDFIM) > 1))))
			{
				continue;
			}
			while (num > 1)
			{
				Slot slot = CraftingInventory.OICKBPJPKPG(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: true, null);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.BBHHJLIFNPP(num2, CDPAMNIPPEC: false, 1);
				num -= num2;
			}
		}
	}

	private void HOLBMINMGHB()
	{
		IDLAGJNLPJL();
	}

	private void JBJBEIJLJNA()
	{
		OpenUI();
	}

	public void GENKKHCFMFE()
	{
		if (recipeElementInfo.HAFMNCODGLP())
		{
			NHAIOENADEO(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: false);
			ToolUpgradeManager.instance.PDLPHBDPAEO(recipeElementInfo.GBJDNNCOIAC.output.item);
			CloseUI();
			HallmundNPC.EKDNJDJHONF().barkDialogue = true;
			HallmundNPC.KNOKBLFFNLM().StartConversation(base.JIIGOACEIKL, "Old crop ");
		}
	}

	protected override void Update()
	{
		base.Update();
		if (LKOJBFMGMAE && PlayerInputs.InputsEnabled(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UIAddRemove"))
		{
			Craft();
		}
	}

	public void MMCJNCPPAAB()
	{
		if (recipeElementInfo.HAFMNCODGLP())
		{
			NHAIOENADEO(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: true);
			ToolUpgradeManager.instance.KEFIHOBGOFL(recipeElementInfo.GBJDNNCOIAC.output.item);
			BOBCIFEDJED();
			HallmundNPC.AFFGPMFKEFH().barkDialogue = true;
			HallmundNPC.DCAEBALADIM().StartConversation(base.JIIGOACEIKL, "Miners/Mine/Clive/Intro");
		}
	}

	private void NHAIOENADEO(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(0, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.AGFIIGGGBHC() && (Item.EKMFELLJHFG(recipeIngredient.mod, null) || item.JFHFEMDAHCD(JNLKEMLDFIM) > 0))))
			{
				continue;
			}
			while (num > 0)
			{
				Slot slot = CraftingInventory.OBAGDPEAAEI(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: false, null);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.JPACDDCJGPD(num2, CDPAMNIPPEC: true, 1);
				num -= num2;
			}
		}
	}

	public override void CloseUI()
	{
		base.CloseUI();
		recipeElementInfo.GBJDNNCOIAC = null;
		MainUI.ResumeGame();
		GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
		SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = true;
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
	}

	private IEnumerator LABFGAOJLHO()
	{
		return new KBKOAFJAPCE(1)
		{
			_003C_003E4__this = this
		};
	}
}
