using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.UI;

public class FerroShopUI : UIWindow
{
	[CompilerGenerated]
	private sealed class EGFKFEGJGFP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FerroShopUI _003C_003E4__this;

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
		public EGFKFEGJGFP(int _003C_003E1__state)
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
			FerroShopUI ferroShopUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(ferroShopUI.JIIGOACEIKL))
				{
					int num2 = 0;
					for (int i = 0; i < ferroShopUI.recipeSlots.Length; i++)
					{
						if (((Component)ferroShopUI.recipeSlots[i]).gameObject.activeSelf)
						{
							num2 = i;
							break;
						}
					}
					if (ferroShopUI.recipeSlots.Length != 0 && ((Component)ferroShopUI.recipeSlots[num2]).gameObject.activeSelf)
					{
						UISelectionManager.GetPlayer(ferroShopUI.JIIGOACEIKL).Select(((Component)ferroShopUI.recipeSlots[num2]).gameObject);
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

	[CompilerGenerated]
	private sealed class NLCJLDBOEKN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string conversation;

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
		public NLCJLDBOEKN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				DialogueManager.StartConversation(conversation);
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

	public GameObject[] black;

	public GameObject[] block;

	public static FerroShopUI[] instances = new FerroShopUI[3];

	private IEnumerator GONMNLHCLBL(string IBGMEKCHEKH)
	{
		return new NLCJLDBOEKN(1)
		{
			conversation = IBGMEKCHEKH
		};
	}

	protected void BBMMDEBJCEM()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			((MonoBehaviour)this).StartCoroutine(IJDKCIKHCHA());
		}
	}

	private void PMCGMAAGIEA()
	{
		OpenUI();
	}

	private IEnumerator BMHFLEDPPJN(string IBGMEKCHEKH)
	{
		return new NLCJLDBOEKN(1)
		{
			conversation = IBGMEKCHEKH
		};
	}

	protected void OLHHCPNNMIB()
	{
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).LBFFIBKMLGO();
			((MonoBehaviour)this).StartCoroutine(AKIMPFNCHHO());
		}
	}

	public static FerroShopUI IEABDMDELFO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JGJPKMMDNGG()
	{
		EDHEIFHAAKO();
	}

	private void JGAABAJBOAI()
	{
		OpenUI();
	}

	public void LFLLOBFCCII()
	{
		if (recipeElementInfo.CanCraft())
		{
			OKJLDLMEGFN(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: false);
			CloseUI();
			if (MineManager.GGFJGHHHEJC.unlockedLevels == 1)
			{
				((MonoBehaviour)this).StartCoroutine(EGFJPKMEJOA(" "));
			}
			MineManager.OOKBNHMMFON().CHKKKBGALKB(CDPAMNIPPEC: false);
		}
	}

	private IEnumerator DHJODDBHCAO(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	private IEnumerator PLGKJMBLBPM(string IBGMEKCHEKH)
	{
		return new NLCJLDBOEKN(1)
		{
			conversation = IBGMEKCHEKH
		};
	}

	public override void OnContentActivated()
	{
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		BBMMDEBJCEM();
	}

	private IEnumerator POKLFFOEOFO()
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

	private void DFJCEFICHDG()
	{
		EDHEIFHAAKO();
	}

	private void GDBDOOMLMBG()
	{
		EDHEIFHAAKO();
	}

	private IEnumerator OFACPEFLGHI()
	{
		return new EGFKFEGJGFP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GBJJDCAADEP(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(0, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.IABMOBAKNAE() && (Item.NGIIPJDAMGP(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 0))))
			{
				continue;
			}
			while (num > 1)
			{
				Slot slot = CraftingInventory.EKBDKPCHPKN(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.FDOBDPPMMBH(num2);
				num -= num2;
			}
		}
	}

	protected void ODFEDPABKJL()
	{
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).CKNJJKJDBGA();
			((MonoBehaviour)this).StartCoroutine(IMOFCOKLDIG());
		}
	}

	public static FerroShopUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator LMPMBLPDNKN(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	private IEnumerator KNOGMIDOHOC()
	{
		return new EGFKFEGJGFP(1)
		{
			_003C_003E4__this = this
		};
	}

	protected void LKHKPNAINCC()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			((MonoBehaviour)this).StartCoroutine(AHPEBGGHCJO());
		}
	}

	public static FerroShopUI FHBIFJNCOAI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator ECDKEMGKAFP(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	protected void LJCKDDLOCBF()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).FBKDHHPNBIL();
			((MonoBehaviour)this).StartCoroutine(LFNKKHPPAJL());
		}
	}

	private IEnumerator HMIDBEPILOE()
	{
		return new EGFKFEGJGFP(1)
		{
			_003C_003E4__this = this
		};
	}

	public static FerroShopUI LPJPJMPOHPG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PKJONHKOIEB(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.IABMOBAKNAE() && (Item.NGIIPJDAMGP(recipeIngredient.mod, null) || item.JFHFEMDAHCD(JNLKEMLDFIM) > 0))))
			{
				continue;
			}
			while (num > 1)
			{
				Slot slot = CraftingInventory.OICKBPJPKPG(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: false, null);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.FDOBDPPMMBH(num2);
				num -= num2;
			}
		}
	}

	protected void CHNHEMPHMEJ()
	{
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).FJAKDODEIIF();
			((MonoBehaviour)this).StartCoroutine(FEBMFNOBPFA());
		}
	}

	protected void LCMHOOGPHGK()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).FPLPECHEGGI();
			((MonoBehaviour)this).StartCoroutine(HMIDBEPILOE());
		}
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

	public void JJIAMNDFAEL()
	{
		if (recipeElementInfo.HAFMNCODGLP())
		{
			GBJJDCAADEP(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: false);
			CloseUI();
			if (MineManager.GGFJGHHHEJC.unlockedLevels == 1)
			{
				((MonoBehaviour)this).StartCoroutine(ECDKEMGKAFP("FocusedMod"));
			}
			MineManager.GGFJGHHHEJC.PlaceCharges();
		}
	}

	public static FerroShopUI OFEFGPCGJDF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected void PFLCGDMLACB()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).FPLPECHEGGI();
			((MonoBehaviour)this).StartCoroutine(AHPEBGGHCJO());
		}
	}

	private IEnumerator MAKDDBIHGAE()
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

	public static FerroShopUI HICGKNJMGOE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FHCOCGEEPFJ()
	{
		if (recipeElementInfo.HAFMNCODGLP())
		{
			PKJONHKOIEB(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: true);
			CloseUI();
			if (MineManager.GGFJGHHHEJC.unlockedLevels == 0)
			{
				((MonoBehaviour)this).StartCoroutine(LMPMBLPDNKN("BuzzNPC: ChangeState called with invalid state: "));
			}
			MineManager.OOKBNHMMFON().CHKKKBGALKB();
		}
	}

	public void Craft()
	{
		if (recipeElementInfo.CanCraft())
		{
			KAKOIEIIDHB(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: true);
			CloseUI();
			if (MineManager.GGFJGHHHEJC.unlockedLevels == 1)
			{
				((MonoBehaviour)this).StartCoroutine(PHKGCOBJDCG("Miners/Mine/Ferro/Bomb"));
			}
			MineManager.GGFJGHHHEJC.PlaceCharges();
		}
	}

	private IEnumerator FGBEEMIONLD(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	private void FAMJLAGLFMA()
	{
		EDHEIFHAAKO();
	}

	private void IBOAPOGFLLL()
	{
		EDHEIFHAAKO();
	}

	private IEnumerator AICANOMNEFD(string IBGMEKCHEKH)
	{
		return new NLCJLDBOEKN(1)
		{
			conversation = IBGMEKCHEKH
		};
	}

	protected void BFEFLAOMPNO()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).OKEACDGEJIB();
			((MonoBehaviour)this).StartCoroutine(IJDKCIKHCHA());
		}
	}

	public void LFGGDBHONAL()
	{
		if (recipeElementInfo.CanCraft())
		{
			KCBHEIIEAMK(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: true);
			BOBCIFEDJED();
			if (MineManager.AGGAGCBAGLL().unlockedLevels == 1)
			{
				((MonoBehaviour)this).StartCoroutine(MOMDEBNDBOE("Invalid playerNum"));
			}
			MineManager.AGGAGCBAGLL().DNEGOPDNJHF(CDPAMNIPPEC: false);
		}
	}

	public void IHDIGBHJJGK()
	{
		if (recipeElementInfo.CanCraft())
		{
			KCBHEIIEAMK(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: true);
			BOBCIFEDJED();
			if (MineManager.GGFJGHHHEJC.unlockedLevels == 1)
			{
				((MonoBehaviour)this).StartCoroutine(GONMNLHCLBL("<br/>Maximum Texture Size: "));
			}
			MineManager.OOKBNHMMFON().LOPPDFFCFKA();
		}
	}

	private IEnumerator EFMFIEJNBFC()
	{
		return new EGFKFEGJGFP(1)
		{
			_003C_003E4__this = this
		};
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
			((Selectable)recipeSlots[i].buttonExtended).interactable = false;
		}
		((Selectable)recipeSlots[MineManager.GGFJGHHHEJC.unlockedLevels - 1].buttonExtended).interactable = true;
		recipeSlots[MineManager.GGFJGHHHEJC.unlockedLevels - 1].OnClickToolUpgrade();
		for (int j = 0; j < MineManager.GGFJGHHHEJC.unlockedLevels - 1; j++)
		{
			black[j].SetActive(true);
		}
		for (int k = MineManager.GGFJGHHHEJC.unlockedLevels - 1; k < block.Length; k++)
		{
			block[k].SetActive(true);
		}
	}

	private void NBOMOKPCIEG()
	{
		IDLAGJNLPJL();
	}

	private IEnumerator EJBFJNJLEMJ(string IBGMEKCHEKH)
	{
		return new NLCJLDBOEKN(1)
		{
			conversation = IBGMEKCHEKH
		};
	}

	public static FerroShopUI MGLNAMHAIDG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator PHKGCOBJDCG(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	private void OMEPNLIPBHF(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.IABMOBAKNAE() && (Item.NGIIPJDAMGP(recipeIngredient.mod, null) || item.JFHFEMDAHCD(JNLKEMLDFIM) > 0))))
			{
				continue;
			}
			while (num > 1)
			{
				Slot slotWithItem = CraftingInventory.GetSlotWithItem(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: true, null);
				if (slotWithItem == null)
				{
					break;
				}
				int num2 = Math.Min(slotWithItem.Stack, num);
				slotWithItem.FDOBDPPMMBH(num2);
				num -= num2;
			}
		}
	}

	private void GCKPGIJGDNJ()
	{
		IDLAGJNLPJL();
	}

	private void IKPPALCMNHD(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.AGFIIGGGBHC() && (Item.EKMFELLJHFG(recipeIngredient.mod, null) || item.JFHFEMDAHCD(JNLKEMLDFIM) > 1))))
			{
				continue;
			}
			while (num > 1)
			{
				Slot slot = CraftingInventory.MKNHIDCOHKK(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.FDOBDPPMMBH(num2, CDPAMNIPPEC: true);
				num -= num2;
			}
		}
	}

	protected void HGNLJPFOKDA()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).FPLPECHEGGI();
			((MonoBehaviour)this).StartCoroutine(KKAKIDOCCPN());
		}
	}

	protected void OFJOOABKNBH()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).FJAKDODEIIF();
			((MonoBehaviour)this).StartCoroutine(MAKDDBIHGAE());
		}
	}

	public static FerroShopUI PCEEOGGDBFB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator DDLFNAEIIGF()
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

	private IEnumerator MPFPNHDHPPJ(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	private void PPEBGMJDNMI()
	{
		IDLAGJNLPJL();
	}

	private void CNLHPINAGIM()
	{
		EDHEIFHAAKO();
	}

	private IEnumerator IMOFCOKLDIG()
	{
		return new EGFKFEGJGFP(1)
		{
			_003C_003E4__this = this
		};
	}

	protected void HNCEAOHNILJ()
	{
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).FPLPECHEGGI();
			((MonoBehaviour)this).StartCoroutine(HMIDBEPILOE());
		}
	}

	private IEnumerator LFNKKHPPAJL()
	{
		return new EGFKFEGJGFP(1)
		{
			_003C_003E4__this = this
		};
	}

	protected void GHGILLADKGP()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).CKMLGHPIEEK();
			((MonoBehaviour)this).StartCoroutine(DDLFNAEIIGF());
		}
	}

	private void GGLCIPJHIPG(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.IABMOBAKNAE() && (Item.GBMFCPGEJDK(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 1))))
			{
				continue;
			}
			while (num > 0)
			{
				Slot slotWithItem = CraftingInventory.GetSlotWithItem(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: false, null);
				if (slotWithItem == null)
				{
					break;
				}
				int num2 = Math.Min(slotWithItem.Stack, num);
				slotWithItem.FDOBDPPMMBH(num2);
				num -= num2;
			}
		}
	}

	public static FerroShopUI COIEMAJLHAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FerroShopUI NIGDBMAOAEN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FerroShopUI DIMABMEHNNI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void KCBHEIIEAMK(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.AGFIIGGGBHC() && (Item.EKGNIODFJCO(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 0))))
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
				slot.JPACDDCJGPD(num2, CDPAMNIPPEC: true);
				num -= num2;
			}
		}
	}

	private IEnumerator AKIMPFNCHHO()
	{
		return new EGFKFEGJGFP(1)
		{
			_003C_003E4__this = this
		};
	}

	protected void NOJAPLLACEJ()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).GGNLGAMLOKK();
			((MonoBehaviour)this).StartCoroutine(IJDKCIKHCHA());
		}
	}

	protected override void Update()
	{
		base.Update();
		if (LKOJBFMGMAE && PlayerInputs.InputsEnabled(base.JIIGOACEIKL) && (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UIAddRemove") || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp")))
		{
			Craft();
		}
	}

	private IEnumerator EGFJPKMEJOA(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	protected void BLHKHHLNMFE()
	{
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).OKEACDGEJIB();
			((MonoBehaviour)this).StartCoroutine(MAKDDBIHGAE());
		}
	}

	public static FerroShopUI KDLDGFBDDCN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FGDJBPDFPEG()
	{
		OpenUI();
	}

	public static FerroShopUI EAONFFENMCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected void CKFFIEGOEEJ()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BEGCHMCDPOK();
			((MonoBehaviour)this).StartCoroutine(KKAKIDOCCPN());
		}
	}

	private void PFFHDLJPCAH(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.JGJLNHAKJIJ() && (Item.NGIIPJDAMGP(recipeIngredient.mod, null) || item.POFOEOJHPML(JNLKEMLDFIM) > 1))))
			{
				continue;
			}
			while (num > 0)
			{
				Slot slotWithItem = CraftingInventory.GetSlotWithItem(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: false, null);
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

	private void NEFKDFIGMPB(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(0, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.AGFIIGGGBHC() && (Item.EKMFELLJHFG(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 0))))
			{
				continue;
			}
			while (num > 1)
			{
				Slot slot = CraftingInventory.MKNHIDCOHKK(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.HBMBGCHGEGN(num2, CDPAMNIPPEC: false, 1);
				num -= num2;
			}
		}
	}

	private void OJDMPCENODH()
	{
		OpenUI();
	}

	private void KLKPKIOJBKI(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.AGFIIGGGBHC() && (Item.EKGNIODFJCO(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 1))))
			{
				continue;
			}
			while (num > 0)
			{
				Slot slot = CraftingInventory.MKNHIDCOHKK(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: true, null);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.HBMBGCHGEGN(num2, CDPAMNIPPEC: false, 1);
				num -= num2;
			}
		}
	}

	public static FerroShopUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JNLOEINIAOD(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.NGDPNIFFHKL() && (Item.EKMFELLJHFG(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 0))))
			{
				continue;
			}
			while (num > 0)
			{
				Slot slot = CraftingInventory.EKBDKPCHPKN(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: false, null);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.BBHHJLIFNPP(num2);
				num -= num2;
			}
		}
	}

	private void IONHKEOHAID(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.IABMOBAKNAE() && (Item.EKMFELLJHFG(recipeIngredient.mod, null) || item.JFHFEMDAHCD(JNLKEMLDFIM) > 1))))
			{
				continue;
			}
			while (num > 1)
			{
				Slot slot = CraftingInventory.OICKBPJPKPG(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: false, null);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.JPACDDCJGPD(num2, CDPAMNIPPEC: true);
				num -= num2;
			}
		}
	}

	public void IFIHFFIDGDP()
	{
		if (recipeElementInfo.CanCraft())
		{
			NEFKDFIGMPB(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: true);
			BOBCIFEDJED();
			if (MineManager.AGGAGCBAGLL().unlockedLevels == 1)
			{
				((MonoBehaviour)this).StartCoroutine(CJAOMOOGMHD("Perks/playerPerk_description_"));
			}
			MineManager.BGMJCCFNNDL().LOPPDFFCFKA(CDPAMNIPPEC: false);
		}
	}

	public void BGMEBCBGDIL()
	{
		if (recipeElementInfo.CanCraft())
		{
			IONHKEOHAID(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: true);
			CloseUI();
			if (MineManager.PDECKLKPKCG().unlockedLevels == 0)
			{
				((MonoBehaviour)this).StartCoroutine(CJAOMOOGMHD("ChatLogRequest"));
			}
			MineManager.BGMJCCFNNDL().PlaceCharges();
		}
	}

	private IEnumerator FEBMFNOBPFA()
	{
		return new EGFKFEGJGFP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CIIGIINLEOD()
	{
		if (recipeElementInfo.CanCraft())
		{
			OKJLDLMEGFN(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: false);
			CloseUI();
			if (MineManager.OOKBNHMMFON().unlockedLevels == 1)
			{
				((MonoBehaviour)this).StartCoroutine(EGFJPKMEJOA("InstantiateGameObject: snapToPosition has items and instantiateGOs arrays, but no match was found for item "));
			}
			MineManager.AGGAGCBAGLL().JKNOFKDANMN();
		}
	}

	private void NCIEFKLICDL()
	{
		OpenUI();
	}

	private IEnumerator KKAKIDOCCPN()
	{
		return new EGFKFEGJGFP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IGNJJAMNLHN()
	{
		if (recipeElementInfo.HAFMNCODGLP())
		{
			KLKPKIOJBKI(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: false);
			BOBCIFEDJED();
			if (MineManager.OOKBNHMMFON().unlockedLevels == 0)
			{
				((MonoBehaviour)this).StartCoroutine(AMDMFHHBLEB("ActiveMaiInBar"));
			}
			MineManager.OOKBNHMMFON().LOPPDFFCFKA(CDPAMNIPPEC: false);
		}
	}

	private void LIMJPECGMCI()
	{
		IDLAGJNLPJL();
	}

	private IEnumerator JEGADEDPPJM()
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

	private void HPFOKIFMBBO()
	{
		IDLAGJNLPJL();
	}

	public static FerroShopUI NMCJELBLKBB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void KHGJIAJLIHE()
	{
		EDHEIFHAAKO();
	}

	private void NGFMMGEAAFB()
	{
		EDHEIFHAAKO();
	}

	private IEnumerator LICJGJBOKLO(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	private void MAFIPNFFIKN()
	{
		OpenUI();
	}

	private void PCFBJAAMBMI(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.JGJLNHAKJIJ() && (Item.GBMFCPGEJDK(recipeIngredient.mod, null) || item.JFHFEMDAHCD(JNLKEMLDFIM) > 0))))
			{
				continue;
			}
			while (num > 0)
			{
				Slot slot = CraftingInventory.EKBDKPCHPKN(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: false, null);
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

	private IEnumerator GHAMNBGMHOE(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	private IEnumerator AHPEBGGHCJO()
	{
		return new EGFKFEGJGFP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JOFAFPNCPNP()
	{
		IDLAGJNLPJL();
	}

	private IEnumerator MOMDEBNDBOE(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private IEnumerator AMDMFHHBLEB(string IBGMEKCHEKH)
	{
		return new NLCJLDBOEKN(1)
		{
			conversation = IBGMEKCHEKH
		};
	}

	private void CPJJBBMNKNA(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.JGJLNHAKJIJ() && (Item.NGIIPJDAMGP(recipeIngredient.mod, null) || item.JFHFEMDAHCD(JNLKEMLDFIM) > 0))))
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
				slotWithItem.BBHHJLIFNPP(num2, CDPAMNIPPEC: true, 1);
				num -= num2;
			}
		}
	}

	private IEnumerator CJAOMOOGMHD(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	public void AJGJICHGHPC()
	{
		if (recipeElementInfo.CanCraft())
		{
			PFFHDLJPCAH(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: true);
			BOBCIFEDJED();
			if (MineManager.PDECKLKPKCG().unlockedLevels == 1)
			{
				((MonoBehaviour)this).StartCoroutine(AICANOMNEFD("intensity:"));
			}
			MineManager.AGGAGCBAGLL().DNEGOPDNJHF();
		}
	}

	protected void ILDBNEODLHN()
	{
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).LBFFIBKMLGO();
			((MonoBehaviour)this).StartCoroutine(FEBMFNOBPFA());
		}
	}

	private void LCKEGLGJLAF(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(1, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.JGJLNHAKJIJ() && (Item.NGIIPJDAMGP(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 0))))
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
				slotWithItem.JPACDDCJGPD(num2, CDPAMNIPPEC: false, 1);
				num -= num2;
			}
		}
	}

	private IEnumerator JNGDNJHCEEG(string IBGMEKCHEKH)
	{
		return new NLCJLDBOEKN(1)
		{
			conversation = IBGMEKCHEKH
		};
	}

	private void OLDINPENGNA(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
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
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.AGFIIGGGBHC() && (Item.GBMFCPGEJDK(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 1))))
			{
				continue;
			}
			while (num > 1)
			{
				Slot slot = CraftingInventory.OICKBPJPKPG(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.BBHHJLIFNPP(num2);
				num -= num2;
			}
		}
	}

	public static FerroShopUI FFBJPAJKOJH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JHMJOINPNCA()
	{
		OpenUI();
	}

	public void MMCJNCPPAAB()
	{
		if (recipeElementInfo.CanCraft())
		{
			OLDINPENGNA(base.JIIGOACEIKL, recipeElementInfo.GBJDNNCOIAC, GFNHAMCPEAK: true);
			BOBCIFEDJED();
			if (MineManager.GGFJGHHHEJC.unlockedLevels == 1)
			{
				((MonoBehaviour)this).StartCoroutine(PHKGCOBJDCG("AnimationControllerIndexRequest"));
			}
			MineManager.AGGAGCBAGLL().LOPPDFFCFKA(CDPAMNIPPEC: false);
		}
	}

	public static FerroShopUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator JKEKIJOHCDE(string IBGMEKCHEKH)
	{
		yield return CommonReferences.wait05;
		DialogueManager.StartConversation(IBGMEKCHEKH);
	}

	private void OKJLDLMEGFN(int JIIGOACEIKL, Recipe JNLKEMLDFIM, bool GFNHAMCPEAK)
	{
		if (!GFNHAMCPEAK)
		{
			return;
		}
		RecipeIngredient[] ingredientsNeeded = JNLKEMLDFIM.ingredientsNeeded;
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			RecipeIngredient recipeIngredient = ingredientsNeeded[i];
			int num = Math.Max(1, recipeIngredient.amount);
			Item item = recipeIngredient.item;
			if (JNLKEMLDFIM.usingNewRecipesSystem && (item is IngredientGroup || (item.AGFIIGGGBHC() && (Item.EKMFELLJHFG(recipeIngredient.mod, null) || item.HOLLKKLBNML(JNLKEMLDFIM) > 0))))
			{
				continue;
			}
			while (num > 0)
			{
				Slot slot = CraftingInventory.EKBDKPCHPKN(JIIGOACEIKL, item, recipeIngredient.mod, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
				if (slot == null)
				{
					break;
				}
				int num2 = Math.Min(slot.Stack, num);
				slot.JPACDDCJGPD(num2);
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
		for (int i = 0; i < black.Length; i++)
		{
			black[i].SetActive(false);
		}
		for (int j = 0; j < block.Length; j++)
		{
			block[j].SetActive(false);
		}
	}

	protected void ENMBCFJNGJA()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).CKMLGHPIEEK();
			((MonoBehaviour)this).StartCoroutine(DDLFNAEIIGF());
		}
	}

	private IEnumerator ODPDDLPEBCD(string IBGMEKCHEKH)
	{
		return new NLCJLDBOEKN(1)
		{
			conversation = IBGMEKCHEKH
		};
	}
}
