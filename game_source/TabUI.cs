using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TabUI : MonoBehaviour, IHoverable
{
	[CompilerGenerated]
	private sealed class IJCEBJADHNP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TabUI _003C_003E4__this;

		public int playerNum;

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
		public IJCEBJADHNP(int _003C_003E1__state)
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
			TabUI tabUI = _003C_003E4__this;
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
				if (((Component)tabUI).gameObject.activeInHierarchy)
				{
					UISelectionManager.GetPlayer(playerNum).Deselect();
					if ((Object)(object)tabUI.repLock != (Object)null && tabUI.repLock.IsLocked())
					{
						UISelectionManager.GetPlayer(playerNum).Deselect();
					}
					else if (Object.op_Implicit((Object)(object)tabUI.firstFocusedElement) && PlayerInputs.IsGamepadActive(playerNum))
					{
						UISelectionManager.GetPlayer(playerNum).Select(tabUI.firstFocusedElement);
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

	public int defaultSortOrder;

	public int selectedSortOrder;

	public Animator animatorUI;

	public Image image;

	public Sprite spriteFocusCategories;

	public Sprite spriteNotFocusCategories;

	[SerializeField]
	private GameObject talentsParent;

	[SerializeField]
	private Selectable firstFocusedElement;

	[SerializeField]
	private RepLock repLock;

	public bool OFMJFMILDJP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void NMOHHPFONIN(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger(" not found");
			animatorUI.ResetTrigger("Welcome to {0}!");
		}
	}

	public bool FDGKGBMKFEH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = " locked due to reputation level required is ";
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
		return false;
	}

	private IEnumerator DHJEFDJBKML(int JIIGOACEIKL)
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public bool CEDAKHPPLLG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool ONAOLIEIMHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void EOICNOKEMFN(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("bed instance not assigned");
			animatorUI.ResetTrigger("</color>");
		}
	}

	private IEnumerator GFAIAEBBBPG(int JIIGOACEIKL)
	{
		yield return null;
		if (((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			if ((Object)(object)repLock != (Object)null && repLock.IsLocked())
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			}
			else if (Object.op_Implicit((Object)(object)firstFocusedElement) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(firstFocusedElement);
			}
		}
	}

	public bool LDFBGJOFCHB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void HNKGFKFELJC()
	{
		BJIHNCGPNFL(spriteNotFocusCategories);
	}

	private IEnumerator EEKDCHGNDDC(int JIIGOACEIKL)
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void EJLCLMCOPML(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("[MinePuzzleManager] Activating puzzle of type {0}");
			animatorUI.ResetTrigger("Christmas/Ace/Intro");
		}
	}

	public void GKLIANGHJKM(int JIIGOACEIKL)
	{
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
	}

	public void LDNBBEHHOAO(int JIIGOACEIKL)
	{
		IKNDAKBMKNB(JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
	}

	public void BIGONMIJCMH(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger(" not found. Cannot add to surface");
			animatorUI.SetTrigger("UIPreviousCategory");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(CJIPEGFPJDC(JIIGOACEIKL));
		}
	}

	public bool OAJPKKIFGGP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "SetNPCPositionAndParent";
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
		return true;
	}

	public void PIEMFOPBJNL(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("</color> to inventory");
			animatorUI.SetTrigger("Selected");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(PNJELIJAOFP(JIIGOACEIKL));
		}
	}

	public void ShowTab(int JIIGOACEIKL)
	{
		ShowTab(JIIGOACEIKL, spriteFocusCategories);
	}

	public void KAGFMPOFCCP(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Fading out music over ");
			animatorUI.ResetTrigger("mainMenuMultiplayerButton");
		}
	}

	public void KDGHNDFNHNC(int JIIGOACEIKL)
	{
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
	}

	public bool JNAJCPAENBC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "itemCucumberSeeds";
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
		return true;
	}

	public void HDJHEGPJKDM(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Disappear");
			animatorUI.ResetTrigger(" ");
		}
	}

	public void GDMIIMPJGNO(int JIIGOACEIKL)
	{
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
	}

	public void HideTab()
	{
		HideTab(spriteNotFocusCategories);
	}

	public bool CGBBGIFMMDB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void JPNPODBAMOK()
	{
		BMANHBFCGNE(spriteNotFocusCategories);
	}

	public void IILCHLHOPBF(int JIIGOACEIKL)
	{
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
	}

	public void IIFCKDAMIPI(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("levelRequired");
			animatorUI.ResetTrigger(":</color> <sprite name=\"ChristmasTicket\">");
		}
	}

	public void JNFIBAIJBEN(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("OutHereRowdyCustomer");
			animatorUI.ResetTrigger("LE_10");
		}
	}

	public bool AFOBLAONEDM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "UIPreviousPage";
		ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
		return false;
	}

	public void DKFODKJNNJN(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Inventory full");
			animatorUI.ResetTrigger("Accept order");
		}
	}

	public void DOAIJCAKENH(int JIIGOACEIKL)
	{
		FKNDNHJBLHB(JIIGOACEIKL, spriteFocusCategories);
	}

	public bool ELBECLGGFGD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void PIIMGGGNAOM(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Cat");
			animatorUI.ResetTrigger("itemSickle");
		}
	}

	private IEnumerator MJMHFIDPPGH(int JIIGOACEIKL)
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void AONCFBJLJAD(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Items/item_name_1230");
			animatorUI.ResetTrigger(" ");
		}
	}

	public bool GKJKEDDHMCO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private IEnumerator MECEGFFEBNE(int JIIGOACEIKL)
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public bool LAIMPCCHFCH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "Hay {0} destructibles y {1} agujeros para cavar disponibles para el puzzle {2}";
		ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
		return true;
	}

	private IEnumerator HMGAAINDHEL(int JIIGOACEIKL)
	{
		yield return null;
		if (((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			if ((Object)(object)repLock != (Object)null && repLock.IsLocked())
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			}
			else if (Object.op_Implicit((Object)(object)firstFocusedElement) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(firstFocusedElement);
			}
		}
	}

	public bool MJEHNKDKBBF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "BathhouseEntrace/Main 3";
		ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		return true;
	}

	public void HideTab(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Normal");
			animatorUI.ResetTrigger("Selected");
		}
	}

	public void DLBFFPOEBLN()
	{
		ELEHNHEOMDK(spriteNotFocusCategories);
	}

	public void BCLBIIPCGIG()
	{
		LEJGHAGGOEH(spriteNotFocusCategories);
	}

	public void JNAJGCOCPBA()
	{
		HideTab(spriteNotFocusCategories);
	}

	public void EENGCHMPDNA(int JIIGOACEIKL)
	{
		IIBANMLPDAA(JIIGOACEIKL, spriteFocusCategories);
	}

	public void DFHFPOIPCLK(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Christmas event recieved, continue joining room");
			animatorUI.ResetTrigger("Animator is null or has been destroyed.");
		}
	}

	private IEnumerator DJAFJFMPFBM(int JIIGOACEIKL)
	{
		yield return null;
		if (((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			if ((Object)(object)repLock != (Object)null && repLock.IsLocked())
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			}
			else if (Object.op_Implicit((Object)(object)firstFocusedElement) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(firstFocusedElement);
			}
		}
	}

	public bool KJBLDGILHJI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "No hay ningún PipeTile de tipo '{0}'. El generador necesita al menos uno.";
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
		return false;
	}

	public void HJECLCIOMGE()
	{
		NEFLMNAEEMD(spriteNotFocusCategories);
	}

	public bool PIBDCFENPHE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "MainProgress";
		ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
		return false;
	}

	public void NAEEPFEOGAI(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Travelling time increased to ");
			animatorUI.ResetTrigger("itemWheatAle");
		}
	}

	private IEnumerator CJIPEGFPJDC(int JIIGOACEIKL)
	{
		yield return null;
		if (((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			if ((Object)(object)repLock != (Object)null && repLock.IsLocked())
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			}
			else if (Object.op_Implicit((Object)(object)firstFocusedElement) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(firstFocusedElement);
			}
		}
	}

	public void EGOAICDKBHH(int JIIGOACEIKL)
	{
		KPAAJFPAEAH(JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
	}

	private IEnumerator OHJLHCBLPHM(int JIIGOACEIKL)
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public bool OLCIHEGGHDE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool IBGDPEAIOLK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "Items/item_name_1230";
		ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		return true;
	}

	public bool DPFFFEGPJDN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void HJFEJHCIGDN()
	{
		LEJGHAGGOEH(spriteNotFocusCategories);
	}

	public void FKNDNHJBLHB(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("DecorationTile_16");
			animatorUI.SetTrigger("Aging Rack");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.DGCNCEDIFOF()).StartCoroutine(PNJELIJAOFP(JIIGOACEIKL));
		}
	}

	private IEnumerator GCGPGNJGEFF(int JIIGOACEIKL)
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void OHOCOHIKHPA(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("UISelectGamepad");
			animatorUI.ResetTrigger("Mission with id ");
		}
	}

	public void LEJGHAGGOEH(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("");
			animatorUI.ResetTrigger("LearnPrecision");
		}
	}

	public void CJJBOJJLIOD(int JIIGOACEIKL)
	{
		PIEMFOPBJNL(JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
	}

	public void EJEJNJGBBEO(int JIIGOACEIKL)
	{
		ADNJKEAPMIC(JIIGOACEIKL, spriteFocusCategories);
	}

	private IEnumerator FOILPJJIHLI(int JIIGOACEIKL)
	{
		yield return null;
		if (((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			if ((Object)(object)repLock != (Object)null && repLock.IsLocked())
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			}
			else if (Object.op_Implicit((Object)(object)firstFocusedElement) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(firstFocusedElement);
			}
		}
	}

	public void GEKNEIAKMIL(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("CellarDoor");
			animatorUI.SetTrigger(" to local storage for reason: ");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.KIALFDOKABP()).StartCoroutine(CECEPGPFECO(JIIGOACEIKL));
		}
	}

	public void NEFLMNAEEMD(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Waiting for other players");
			animatorUI.ResetTrigger("Cut");
		}
	}

	public bool AECFPJALDGD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void PICAPHOJNEK(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Received pipe tile swap: indexA={0}, indexB={1}, mineLevel={2}");
			animatorUI.ResetTrigger("Dialogue System/Conversation/Crowly_Standar/Entry/27/Dialogue Text");
		}
	}

	public void NNKJNKJMDKA(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger(" : 00");
			animatorUI.ResetTrigger("itemFishSteak");
		}
	}

	public void OOMDONCBOII(int JIIGOACEIKL)
	{
		ShowTab(JIIGOACEIKL, spriteFocusCategories);
	}

	public void NLAJENGKLIL()
	{
		EIFFFFFIJEP(spriteNotFocusCategories);
	}

	public void KHJLGGKPHLH(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("xpModDescHaggling");
			animatorUI.SetTrigger("hForHours");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StartCoroutine(OBDMKDGNKKE(JIIGOACEIKL));
		}
	}

	public void HEKPFPNLBJO(int JIIGOACEIKL)
	{
		BIGONMIJCMH(JIIGOACEIKL, spriteFocusCategories);
	}

	public void CIEAJPJILOL(int JIIGOACEIKL)
	{
		IIBANMLPDAA(JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
	}

	public void PDPMLNIPJJG(int JIIGOACEIKL)
	{
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
	}

	public bool OACAPFIFIOC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "cameraZoom";
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		return true;
	}

	public void JGGHFHOAKAM()
	{
		NHLPJIBOANJ(spriteNotFocusCategories);
	}

	public void FMAPCFMEIHN()
	{
		BMANHBFCGNE(spriteNotFocusCategories);
	}

	public void LGIOIOCLOLN(int JIIGOACEIKL)
	{
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
	}

	public bool NKJBDLANNIF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "Value null of key: ";
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
		return false;
	}

	private IEnumerator PNJELIJAOFP(int JIIGOACEIKL)
	{
		yield return null;
		if (((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			if ((Object)(object)repLock != (Object)null && repLock.IsLocked())
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			}
			else if (Object.op_Implicit((Object)(object)firstFocusedElement) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(firstFocusedElement);
			}
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
		ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
	}

	public void BAOIIHPOKLP(int JIIGOACEIKL)
	{
		KHJLGGKPHLH(JIIGOACEIKL, spriteFocusCategories);
	}

	public void EIFFFFFIJEP(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("sForSeconds");
			animatorUI.ResetTrigger("Dialogue System/Conversation/TavernClean/Entry/1/Dialogue Text");
		}
	}

	public void HLJLOBHLMNM(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("ReceiveTreeInfo");
			animatorUI.ResetTrigger("UINextCategory");
		}
	}

	public void OCEFLLCCGPK()
	{
		ELEHNHEOMDK(spriteNotFocusCategories);
	}

	public void IIBANMLPDAA(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("openShop");
			animatorUI.SetTrigger("SendRPC: '");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.DICHPHEOINO()).StartCoroutine(MJMHFIDPPGH(JIIGOACEIKL));
		}
	}

	public void MLOBKOONNMH(int JIIGOACEIKL)
	{
		ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
	}

	public void ILLNIDNJGJH(int JIIGOACEIKL)
	{
		PIEMFOPBJNL(JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
	}

	public void CNNKPLFBBAJ()
	{
		BJIHNCGPNFL(spriteNotFocusCategories);
	}

	private IEnumerator CECEPGPFECO(int JIIGOACEIKL)
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void AMNMHCKOKAJ()
	{
		HLJLOBHLMNM(spriteNotFocusCategories);
	}

	public bool LLJFKOEKMEH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void KJPDHEFECGE(int JIIGOACEIKL)
	{
		KPAAJFPAEAH(JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
	}

	public void AFOPKGPBOHE(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Seat without table (sendOnline -> ");
			animatorUI.ResetTrigger("[OnlineMineManager] ReceiveGenerateMineLevel: Client doesnt have scene loaded. Level={0} Seed={1}");
		}
	}

	public void NHLPJIBOANJ(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Day");
			animatorUI.ResetTrigger("Items/item_description_627");
		}
	}

	public bool EECAFNEAGPN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void GHJNDIDNJKA(int JIIGOACEIKL)
	{
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
	}

	public bool EPKNOICDOIE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool FHDFKMOIKBM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private IEnumerator OBDMKDGNKKE(int JIIGOACEIKL)
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator MNIBNCIBAKI(int JIIGOACEIKL)
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void FBBAOFGNEKO(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("LE_21");
			animatorUI.ResetTrigger("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/22/Dialogue Text");
		}
	}

	public bool DOFBPGOCNEN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "ReceiveRemoveAllItemsOnTray";
		ItemTooltip.Get(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
		return true;
	}

	public void NIPHFNAJKBN(int JIIGOACEIKL)
	{
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
	}

	public bool HINGCLJLHJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void KPAAJFPAEAH(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("Item NULL in index ");
			animatorUI.SetTrigger("AimDirection");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(PNJELIJAOFP(JIIGOACEIKL));
		}
	}

	public bool LIKJBMGDKGA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "ReceiveFinishBathhouseMinigame";
		ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
		return false;
	}

	public void MIJFMCMHAKF(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("UI2");
			animatorUI.ResetTrigger("add letter");
		}
	}

	public bool CODLFHDKMHC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "Error in FarmBuilding.OnPlayerSleep: ";
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
		return false;
	}

	public void APGDHFACKMA(int JIIGOACEIKL)
	{
		PMAIDBCLDFO(JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
	}

	public void IKNDAKBMKNB(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("RecieveMothersRecipeEventCof");
			animatorUI.SetTrigger("UIAddRemove");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.DICHPHEOINO()).StartCoroutine(BAHEKCOOHPC(JIIGOACEIKL));
		}
	}

	public void ADNJKEAPMIC(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("ReceiveDeclineRoom");
			animatorUI.SetTrigger("ClosePopUp");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.BAKPBHPNKPB()).StartCoroutine(PFBPDLNHHGD(JIIGOACEIKL));
		}
	}

	public void CJOLCLDGFMB(int JIIGOACEIKL)
	{
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
	}

	private IEnumerator LMFLJEENODD(int JIIGOACEIKL)
	{
		yield return null;
		if (((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			if ((Object)(object)repLock != (Object)null && repLock.IsLocked())
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			}
			else if (Object.op_Implicit((Object)(object)firstFocusedElement) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(firstFocusedElement);
			}
		}
	}

	private IEnumerator PFBPDLNHHGD(int JIIGOACEIKL)
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "";
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		return true;
	}

	public void ShowTab(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("Normal");
			animatorUI.SetTrigger("Selected");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(HMGAAINDHEL(JIIGOACEIKL));
		}
	}

	public void OEIKFIHLDHO(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("FallLeft");
			animatorUI.SetTrigger("Name...");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.DBJCACLEFGK()).StartCoroutine(GCGPGNJGEFF(JIIGOACEIKL));
		}
	}

	public void NOPPMKKDNLE(int JIIGOACEIKL)
	{
		FKNDNHJBLHB(JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
	}

	public void EAJEMHIEDMI(int JIIGOACEIKL)
	{
		KPAAJFPAEAH(JIIGOACEIKL, spriteFocusCategories);
	}

	public void KODCGEJPFPN(int JIIGOACEIKL)
	{
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
	}

	public bool DMFALJDJAMP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "Down";
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
		return true;
	}

	public void NNIBKIDJGGG(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger(" has null in occupy nodes with colliders list.");
			animatorUI.ResetTrigger("Bomb");
		}
	}

	private IEnumerator BAHEKCOOHPC(int JIIGOACEIKL)
	{
		yield return null;
		if (((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			if ((Object)(object)repLock != (Object)null && repLock.IsLocked())
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			}
			else if (Object.op_Implicit((Object)(object)firstFocusedElement) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(firstFocusedElement);
			}
		}
	}

	public void BMANHBFCGNE(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("ActiveDecoMode");
			animatorUI.ResetTrigger("Seat without table (sendOnline -> ");
		}
	}

	public void LDFIMGKJGHA(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("Tutorial/T119/Dialogue1");
			animatorUI.SetTrigger("talentStew");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(FOILPJJIHLI(JIIGOACEIKL));
		}
	}

	public bool OPEOJMLFPMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "ClosePopUp";
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
		return true;
	}

	public bool GIDIDGMFLAE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "Perks/playerPerk_description_";
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
		return true;
	}

	public void PMAIDBCLDFO(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("Disconnected from network. Cause: ");
			animatorUI.SetTrigger("All:");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(BAHEKCOOHPC(JIIGOACEIKL));
		}
	}

	public bool PKKHHNOPEPH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void JMDABNIHCPK(int JIIGOACEIKL)
	{
		FKNDNHJBLHB(JIIGOACEIKL, spriteFocusCategories);
	}

	public void LLMENFMMLLJ(int JIIGOACEIKL)
	{
		IIBANMLPDAA(JIIGOACEIKL, spriteFocusCategories);
	}

	public void MCBHIOOAIAM(int JIIGOACEIKL)
	{
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
	}

	private IEnumerator CKAKOHCHPHH(int JIIGOACEIKL)
	{
		yield return null;
		if (((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			if ((Object)(object)repLock != (Object)null && repLock.IsLocked())
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			}
			else if (Object.op_Implicit((Object)(object)firstFocusedElement) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(firstFocusedElement);
			}
		}
	}

	public void AEFOGEIIFLK(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("Received RPC SetAnimatorStateRPC with hash: {0} on {1}, but the state was not found.");
			animatorUI.SetTrigger("Serve");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.DBJCACLEFGK()).StartCoroutine(PFBPDLNHHGD(JIIGOACEIKL));
		}
	}

	public void GGMOINLJNGE()
	{
		HDJHEGPJKDM(spriteNotFocusCategories);
	}

	public void BJIHNCGPNFL(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("UIPreviousCategory");
			animatorUI.ResetTrigger("CliveProgress");
		}
	}

	public void AGCIHGAHONK(int JIIGOACEIKL)
	{
		PIEMFOPBJNL(JIIGOACEIKL, spriteFocusCategories);
	}

	public void LKHEKAJNMAI(int JIIGOACEIKL)
	{
		BIGONMIJCMH(JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
	}

	public void JADHPAHNPJO(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(false);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("OnlinePlayer");
			animatorUI.ResetTrigger("Bother");
		}
	}

	public void NOLDPGNMEAM(int JIIGOACEIKL, Sprite MNLOMCJPCEK, bool BPFKBPPKMKM = true)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = MNLOMCJPCEK;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.ResetTrigger("BarkActor");
			animatorUI.SetTrigger("PlayerDisconnected_F");
		}
		if (BPFKBPPKMKM)
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StartCoroutine(OBDMKDGNKKE(JIIGOACEIKL));
		}
	}

	public void LEKOFMMFKBN(int JIIGOACEIKL)
	{
		OEIKFIHLDHO(JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
	}

	private IEnumerator LGMGANPOKDE(int JIIGOACEIKL)
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void ELEHNHEOMDK(Sprite ABLDCBFOIHG)
	{
		if (Object.op_Implicit((Object)(object)talentsParent))
		{
			talentsParent.SetActive(true);
		}
		image.sprite = ABLDCBFOIHG;
		if (Object.op_Implicit((Object)(object)animatorUI))
		{
			animatorUI.SetTrigger("Close");
			animatorUI.ResetTrigger("scaleUI");
		}
	}

	public bool BLGIKKBBFKF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)((Component)this).gameObject).name);
		tooltipInfo.mainBody = "LE_16";
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		return true;
	}
}
