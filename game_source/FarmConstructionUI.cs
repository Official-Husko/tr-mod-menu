using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarmConstructionUI : ConstructionUI
{
	[CompilerGenerated]
	private sealed class HEJNMOAJABJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public HEJNMOAJABJ(int _003C_003E1__state)
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
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				if (!CommonReferences.GGFJGHHHEJC.farmConstructionTutorial)
				{
					TutorialFarmConstruction.instance.ConstructionTutorial();
					CommonReferences.GGFJGHHHEJC.farmConstructionTutorial = true;
				}
				else if ((FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL) && !CommonReferences.GGFJGHHHEJC.farmModificationsTutorial)
				{
					TutorialFarmConstruction.instance.UpgradeTutorial();
					CommonReferences.GGFJGHHHEJC.farmModificationsTutorial = true;
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
	private sealed class AGNJCNICOCK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FarmConstructionUI _003C_003E4__this;

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
		public AGNJCNICOCK(int _003C_003E1__state)
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
			FarmConstructionUI farmConstructionUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(farmConstructionUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(farmConstructionUI.JIIGOACEIKL).Select(((Component)FarmConstructionActionsUI.GGFJGHHHEJC.buildElementsUI[0]).gameObject);
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

	private static FarmConstructionUI IADEMLIIDPC;

	private bool GEMKMNPNNKK;

	public static FarmConstructionUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
			}
			return IADEMLIIDPC;
		}
	}

	public static int NLCDDFDGACP
	{
		get
		{
			if (Object.op_Implicit((Object)(object)GGFJGHHHEJC))
			{
				return GGFJGHHHEJC.JIIGOACEIKL;
			}
			return 1;
		}
	}

	public bool CanOpenUI(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO != 1) ? 1 : 2);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.IsInDialogue(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Error_CloseMenus"));
				return false;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Exit build mode"));
				return false;
			}
		}
		return true;
	}

	private IEnumerator DBMDFLFPLJK()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)FarmConstructionActionsUI.GGFJGHHHEJC.buildElementsUI[0]).gameObject);
		}
	}

	private IEnumerator CDLICPKEGLK()
	{
		yield return null;
		yield return null;
		yield return null;
		if (!CommonReferences.GGFJGHHHEJC.farmConstructionTutorial)
		{
			TutorialFarmConstruction.instance.ConstructionTutorial();
			CommonReferences.GGFJGHHHEJC.farmConstructionTutorial = true;
		}
		else if ((FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL) && !CommonReferences.GGFJGHHHEJC.farmModificationsTutorial)
		{
			TutorialFarmConstruction.instance.UpgradeTutorial();
			CommonReferences.GGFJGHHHEJC.farmModificationsTutorial = true;
		}
	}

	[SpecialName]
	public static FarmConstructionUI JFNOOMJMHCB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	private IEnumerator HMKOOMOBAKO()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)FarmConstructionActionsUI.GGFJGHHHEJC.buildElementsUI[0]).gameObject);
		}
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			base.Awake();
		}
	}

	[SpecialName]
	public static int DIFJMCBJDFF()
	{
		if (Object.op_Implicit((Object)(object)MIGKKKELOJO()))
		{
			return JFNOOMJMHCB().JIIGOACEIKL;
		}
		return 1;
	}

	public bool GHAIDJBFKJH(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO == 1) ? 1 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().IsInDialogue(jIIGOACEIKL))
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("Cant pay current: "), 1395f);
				return true;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/5/Dialogue Text"), 1625f);
				return false;
			}
		}
		return true;
	}

	public bool HEHNMCOINFB(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO == 0) ? 5 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().IsInDialogue(jIIGOACEIKL))
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_1058"), 229f);
				return true;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_596"), 1677f);
				return false;
			}
		}
		return false;
	}

	public override void CloseUI()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		if (LKOJBFMGMAE && !TutorialFarmConstruction.instance.inTutorial)
		{
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			if (GameManager.LocalCoop())
			{
				int num = ((base.JIIGOACEIKL == 2) ? 1 : 2);
				((Component)PlayerController.GetPlayer(num)).gameObject.SetActive(true);
				GameManager.GGFJGHHHEJC.UnblockPlayer(num);
				CameraTarget obj = ((num == 1) ? SceneReferences.GetPlayer1CameraTarget() : SceneReferences.GetPlayer2CameraTarget());
				((Component)obj).transform.position = ((Component)PlayerController.GetPlayer(num)).transform.position;
				((Component)obj.pixelPerfect).transform.position = ((Component)PlayerController.GetPlayer(num)).transform.position;
			}
			playerInfo.RemoveMaterialsFromPlayer(base.JIIGOACEIKL);
			GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(base.JIIGOACEIKL, NOKFNLBADMO: true);
			base.CloseUI();
			FarmConstructionManager.SetActived(EGFGNGJGBOP: false);
			if (!GEMKMNPNNKK)
			{
				TutorialManager.GGFJGHHHEJC.ShowLastPopUp();
			}
			PlayerInputs.GetPlayer(base.JIIGOACEIKL).SwitchMapCategoryNextFrame("Game");
			FarmConstructionManager.instance.UnblockBuzzInteractionWithDelay();
		}
	}

	private IEnumerator HEBJAODCNFI()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)FarmConstructionActionsUI.GGFJGHHHEJC.buildElementsUI[0]).gameObject);
		}
	}

	[SpecialName]
	public static int BHIDAEGHPLE()
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC))
		{
			return PFHFIJDDOME().JIIGOACEIKL;
		}
		return 1;
	}

	[SpecialName]
	public static int EALBMPCBPKK()
	{
		if (Object.op_Implicit((Object)(object)LKOABOAADCD()))
		{
			return KHMEGDIABBF().JIIGOACEIKL;
		}
		return 1;
	}

	[SpecialName]
	public static FarmConstructionUI JHKLPLPBKCI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static int OPHOGIAFCGL()
	{
		if (Object.op_Implicit((Object)(object)PFHFIJDDOME()))
		{
			return BGMJCCFNNDL().JIIGOACEIKL;
		}
		return 1;
	}

	[SpecialName]
	public static int NAFIKJBIGAB()
	{
		if (Object.op_Implicit((Object)(object)LKOABOAADCD()))
		{
			return JFNOOMJMHCB().JIIGOACEIKL;
		}
		return 0;
	}

	[SpecialName]
	public static FarmConstructionUI MIGKKKELOJO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	public bool AICLKAILACC(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO == 0) ? 4 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Loading obstacles"), 351f);
				return true;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("AceT_Quest"), 1728f);
				return true;
			}
		}
		return true;
	}

	public bool JPPPJNGMNHC(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO != 1) ? 1 : 5);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(jIIGOACEIKL))
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("Player left with right piece in inventory, dropping it on the ground."), 720f);
				return false;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/22/Dialogue Text"), 1716f);
				return true;
			}
		}
		return true;
	}

	[SpecialName]
	public static FarmConstructionUI LKOABOAADCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static int FPLHDKAAPEP()
	{
		if (Object.op_Implicit((Object)(object)KHMEGDIABBF()))
		{
			return LKOABOAADCD().JIIGOACEIKL;
		}
		return 1;
	}

	[SpecialName]
	public static int CFBHHGAFPBI()
	{
		if (Object.op_Implicit((Object)(object)MIGKKKELOJO()))
		{
			return PFHFIJDDOME().JIIGOACEIKL;
		}
		return 0;
	}

	public bool FDJEMOJODDE(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO != 0) ? 1 : 3);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(jIIGOACEIKL))
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("cloudy"), 589f);
				return true;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("UI2"), 97f);
				return true;
			}
		}
		return false;
	}

	private IEnumerator NBFLHKHCDBO()
	{
		return new AGNJCNICOCK(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		((MonoBehaviour)this).StartCoroutine(OPHNGHOGKDO());
		PlayerInputs.GetPlayer(base.JIIGOACEIKL).SwitchMapCategoryNextFrame("UI");
		FarmConstructionActionsUI.GGFJGHHHEJC.UpdateUIGamepadSelection();
	}

	[SpecialName]
	public static FarmConstructionUI EKDNJDJHONF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	public bool KBGEKGJDMBJ(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO == 0) ? 1 : 1);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.IsInDialogue(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("All bubbles in use!"), 1754f);
				return false;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("Interaction was initiated, but the object is not in range. Only possible in online."), 361f);
				return true;
			}
		}
		return false;
	}

	private IEnumerator BIHNDKPIPKL()
	{
		yield return null;
		yield return null;
		yield return null;
		if (!CommonReferences.GGFJGHHHEJC.farmConstructionTutorial)
		{
			TutorialFarmConstruction.instance.ConstructionTutorial();
			CommonReferences.GGFJGHHHEJC.farmConstructionTutorial = true;
		}
		else if ((FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL) && !CommonReferences.GGFJGHHHEJC.farmModificationsTutorial)
		{
			TutorialFarmConstruction.instance.UpgradeTutorial();
			CommonReferences.GGFJGHHHEJC.farmModificationsTutorial = true;
		}
	}

	public bool DEFNGIBDHBB(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO != 0) ? 1 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(jIIGOACEIKL))
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("itemCaramelWort"), 1284f);
				return true;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("Random"), 1726f);
				return true;
			}
		}
		return true;
	}

	private IEnumerator HEEPEHCLLON()
	{
		yield return null;
		yield return null;
		yield return null;
		if (!CommonReferences.GGFJGHHHEJC.farmConstructionTutorial)
		{
			TutorialFarmConstruction.instance.ConstructionTutorial();
			CommonReferences.GGFJGHHHEJC.farmConstructionTutorial = true;
		}
		else if ((FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL) && !CommonReferences.GGFJGHHHEJC.farmModificationsTutorial)
		{
			TutorialFarmConstruction.instance.UpgradeTutorial();
			CommonReferences.GGFJGHHHEJC.farmModificationsTutorial = true;
		}
	}

	private IEnumerator BKHMHMGGFIF()
	{
		return new HEJNMOAJABJ(1);
	}

	[SpecialName]
	public static int FBLHBEKPCLK()
	{
		if (Object.op_Implicit((Object)(object)EKDNJDJHONF()))
		{
			return BGMJCCFNNDL().JIIGOACEIKL;
		}
		return 1;
	}

	private IEnumerator KIHCACPCDMM()
	{
		yield return null;
		yield return null;
		yield return null;
		if (!CommonReferences.GGFJGHHHEJC.farmConstructionTutorial)
		{
			TutorialFarmConstruction.instance.ConstructionTutorial();
			CommonReferences.GGFJGHHHEJC.farmConstructionTutorial = true;
		}
		else if ((FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL) && !CommonReferences.GGFJGHHHEJC.farmModificationsTutorial)
		{
			TutorialFarmConstruction.instance.UpgradeTutorial();
			CommonReferences.GGFJGHHHEJC.farmModificationsTutorial = true;
		}
	}

	public bool AKGGHODACCC(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO != 1) ? 1 : 3);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(jIIGOACEIKL))
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Accept"), 488f);
				return true;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("No hemos encontrado una resolución"), 396f);
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static FarmConstructionUI MAIDHAPANEB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	private IEnumerator OPHNGHOGKDO()
	{
		yield return null;
		yield return null;
		yield return null;
		if (!CommonReferences.GGFJGHHHEJC.farmConstructionTutorial)
		{
			TutorialFarmConstruction.instance.ConstructionTutorial();
			CommonReferences.GGFJGHHHEJC.farmConstructionTutorial = true;
		}
		else if ((FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL) && !CommonReferences.GGFJGHHHEJC.farmModificationsTutorial)
		{
			TutorialFarmConstruction.instance.UpgradeTutorial();
			CommonReferences.GGFJGHHHEJC.farmModificationsTutorial = true;
		}
	}

	[SpecialName]
	public static int LNFFONMLCFH()
	{
		if (Object.op_Implicit((Object)(object)EKDNJDJHONF()))
		{
			return EKDNJDJHONF().JIIGOACEIKL;
		}
		return 0;
	}

	[SpecialName]
	public static int MLNFPHFFHKH()
	{
		if (Object.op_Implicit((Object)(object)JHKLPLPBKCI()))
		{
			return BGMJCCFNNDL().JIIGOACEIKL;
		}
		return 0;
	}

	[SpecialName]
	public static FarmConstructionUI OOKBNHMMFON()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	private IEnumerator JPPEPOACEOF()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)FarmConstructionActionsUI.GGFJGHHHEJC.buildElementsUI[0]).gameObject);
		}
	}

	public bool GAGFODDCFAP(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO == 1) ? 1 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(jIIGOACEIKL))
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("Error_CannotPickUp"), 449f);
				return true;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("AnimatorObjectStateRequest"), 850f);
				return true;
			}
		}
		return false;
	}

	private IEnumerator CKINAFEAPND()
	{
		return new HEJNMOAJABJ(1);
	}

	[SpecialName]
	public static int DBKBGNHAFOP()
	{
		if (Object.op_Implicit((Object)(object)PDECKLKPKCG()))
		{
			return PDECKLKPKCG().JIIGOACEIKL;
		}
		return 0;
	}

	[SpecialName]
	public static FarmConstructionUI NBKKEINELDN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	private IEnumerator EAGOCMJMBKA()
	{
		yield return null;
		yield return null;
		yield return null;
		if (!CommonReferences.GGFJGHHHEJC.farmConstructionTutorial)
		{
			TutorialFarmConstruction.instance.ConstructionTutorial();
			CommonReferences.GGFJGHHHEJC.farmConstructionTutorial = true;
		}
		else if ((FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL) && !CommonReferences.GGFJGHHHEJC.farmModificationsTutorial)
		{
			TutorialFarmConstruction.instance.UpgradeTutorial();
			CommonReferences.GGFJGHHHEJC.farmModificationsTutorial = true;
		}
	}

	[SpecialName]
	public static FarmConstructionUI KHMEGDIABBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	public bool BMBMFOEJIAN(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO != 1) ? 1 : 7);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(jIIGOACEIKL))
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Tutorial/T109/Dialogue1"), 85f);
				return false;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("No players at the start of the scene. Spawning..."), 289f);
				return false;
			}
		}
		return false;
	}

	private IEnumerator JDMOKOANDAA()
	{
		yield return null;
		yield return null;
		yield return null;
		if (!CommonReferences.GGFJGHHHEJC.farmConstructionTutorial)
		{
			TutorialFarmConstruction.instance.ConstructionTutorial();
			CommonReferences.GGFJGHHHEJC.farmConstructionTutorial = true;
		}
		else if ((FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL) && !CommonReferences.GGFJGHHHEJC.farmModificationsTutorial)
		{
			TutorialFarmConstruction.instance.UpgradeTutorial();
			CommonReferences.GGFJGHHHEJC.farmModificationsTutorial = true;
		}
	}

	public bool AJPCBFHADHG(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO == 1) ? 3 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.IsInDialogue(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_722"), 428f);
				return true;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("Correo Enviado. Tiempo: "), 985f);
				return false;
			}
		}
		return false;
	}

	[SpecialName]
	public static int DJJOMDNNHIF()
	{
		if (Object.op_Implicit((Object)(object)EKDNJDJHONF()))
		{
			return KHMEGDIABBF().JIIGOACEIKL;
		}
		return 1;
	}

	private IEnumerator NBJBDAFOOCA()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)FarmConstructionActionsUI.GGFJGHHHEJC.buildElementsUI[0]).gameObject);
		}
	}

	private IEnumerator GCKBLHLBOHB()
	{
		yield return null;
		yield return null;
		yield return null;
		if (!CommonReferences.GGFJGHHHEJC.farmConstructionTutorial)
		{
			TutorialFarmConstruction.instance.ConstructionTutorial();
			CommonReferences.GGFJGHHHEJC.farmConstructionTutorial = true;
		}
		else if ((FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL) && !CommonReferences.GGFJGHHHEJC.farmModificationsTutorial)
		{
			TutorialFarmConstruction.instance.UpgradeTutorial();
			CommonReferences.GGFJGHHHEJC.farmModificationsTutorial = true;
		}
	}

	[SpecialName]
	public static int EAIJOFGJDNE()
	{
		if (Object.op_Implicit((Object)(object)DGCNCEDIFOF()))
		{
			return JHKLPLPBKCI().JIIGOACEIKL;
		}
		return 0;
	}

	public bool IKLMJLGAPNC(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO != 0) ? 1 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(jIIGOACEIKL))
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("itemRedGrapeSeeds"), 33f);
				return false;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Hammer"), 1548f);
				return true;
			}
		}
		return false;
	}

	private IEnumerator KNNFEJOICMK()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)FarmConstructionActionsUI.GGFJGHHHEJC.buildElementsUI[0]).gameObject);
		}
	}

	private IEnumerator BJFMGNCKPIH()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)FarmConstructionActionsUI.GGFJGHHHEJC.buildElementsUI[0]).gameObject);
		}
	}

	[SpecialName]
	public static FarmConstructionUI PDECKLKPKCG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	public bool AHODENMFNIN(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO == 0) ? 6 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(jIIGOACEIKL))
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("full"), 1850f);
				return false;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_1447"), 912f);
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public static FarmConstructionUI PFHFIJDDOME()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	public bool NLADIFEIBJK(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO == 0) ? 2 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get(" "), 1065f);
				return true;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("ReceiveRemoveZone"), 1197f);
				return true;
			}
		}
		return false;
	}

	public override void OpenUI()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		if (LKOJBFMGMAE)
		{
			return;
		}
		base.OpenUI();
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		FarmConstructionManager.instance.BlockBuzzInteraction();
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((base.JIIGOACEIKL == 2) ? 1 : 2);
			if (PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA == Location.Road)
			{
				PlayerController.TeleportPlayer(jIIGOACEIKL, ((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road)).transform.position - Vector3.up * 0.5f, Location.Road);
				PlayerController.GetPlayer(jIIGOACEIKL).characterAnimation.FCGBJEIIMBC = Direction.Down;
			}
		}
		playerInfo.GetMaterialsFromPlayer(base.JIIGOACEIKL);
		GEMKMNPNNKK = TutorialManager.GGFJGHHHEJC.minimisePopUpsClosed;
		TutorialManager.GGFJGHHHEJC.ClosePopUp();
		FarmConstructionManager.SetActived(EGFGNGJGBOP: true);
		FarmConstructionActionsUI.GGFJGHHHEJC.ResetCurrentTab();
		if (!CommonReferences.GGFJGHHHEJC.farmConstructionTutorial)
		{
			FarmConstructionActionsUI.GGFJGHHHEJC.FocusTab(0);
		}
		else if ((FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL) && !CommonReferences.GGFJGHHHEJC.farmModificationsTutorial)
		{
			FarmConstructionActionsUI.GGFJGHHHEJC.FocusTab(1);
		}
		else
		{
			FarmConstructionActionsUI.GGFJGHHHEJC.FocusTab(0);
		}
		GraphicsMenuUI.GGFJGHHHEJC.ForceZoom(1, 550);
		if (Object.op_Implicit((Object)(object)Barn.instance))
		{
			Barn.instance.EntryAllAnimals();
		}
	}

	[SpecialName]
	public static FarmConstructionUI AAFOFNEHPLC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	public override void AcceptChanges()
	{
		CloseUI();
	}

	private IEnumerator HKLAKDIIHCH()
	{
		return new AGNJCNICOCK(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	public static FarmConstructionUI BGMJCCFNNDL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static int BMBFOMKAPEP()
	{
		if (Object.op_Implicit((Object)(object)NBKKEINELDN()))
		{
			return PFHFIJDDOME().JIIGOACEIKL;
		}
		return 1;
	}

	private IEnumerator LNFBIAFKPJM()
	{
		return new HEJNMOAJABJ(1);
	}

	private IEnumerator MLBIKCMCPGD()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)FarmConstructionActionsUI.GGFJGHHHEJC.buildElementsUI[0]).gameObject);
		}
	}

	[SpecialName]
	public static FarmConstructionUI DGCNCEDIFOF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionUI>();
		}
		return IADEMLIIDPC;
	}

	public bool PPEMENBLGJA(int GELMAIBEHDO)
	{
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO == 0) ? 3 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(jIIGOACEIKL))
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_1154"), 419f);
				return false;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("Select"), 757f);
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public static int KADFNONENEM()
	{
		if (Object.op_Implicit((Object)(object)NBKKEINELDN()))
		{
			return NBKKEINELDN().JIIGOACEIKL;
		}
		return 0;
	}
}
