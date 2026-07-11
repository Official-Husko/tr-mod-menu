using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DecorationMode : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class HDKCLKANIJC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecorationMode _003C_003E4__this;

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
		public HDKCLKANIJC(int _003C_003E1__state)
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
			DecorationMode decorationMode = _003C_003E4__this;
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
				decorationMode.OnDecorationModeExit(decorationMode.JIIGOACEIKL);
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

	private static DecorationMode[] GJBBNHCMNJN = new DecorationMode[5];

	public Action<int> OnDecorationModeEnter = delegate
	{
	};

	public Action<int> OnDecorationModeExit = delegate
	{
	};

	[SerializeField]
	private Material outlineMaterial;

	[SerializeField]
	private Material outlineUnlitMaterial;

	[SerializeField]
	private Material outlineAtlas2WithTransparency;

	[SerializeField]
	private Material player2OutlineMaterial;

	[SerializeField]
	private Material player2OutlineUnlitMaterial;

	private int JIIGOACEIKL;

	private bool CDHCJPMLBEJ;

	public bool DMBFKFLDDLH
	{
		get
		{
			return CDHCJPMLBEJ;
		}
		set
		{
			if (!value)
			{
				if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL) != (Object)null && (Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).selectedGameObject != (Object)null && (Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).selectedGameObject.GetComponent<Placeable>() != (Object)null)
				{
					value = CDHCJPMLBEJ;
				}
				if (CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL) && !TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
				{
					CursorManager.SetControlCursorWithGamepad(JIIGOACEIKL, NKFPJPCFBJI: false);
					CursorManager.GetPlayer(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: false);
				}
			}
			if (CDHCJPMLBEJ != value)
			{
				CDHCJPMLBEJ = value;
				if (!CDHCJPMLBEJ)
				{
					OnDecorationModeExit(JIIGOACEIKL);
				}
				else
				{
					OnDecorationModeEnter(JIIGOACEIKL);
				}
				ButtonsContext.ResetAllCrafterAction();
				if (!CDHCJPMLBEJ)
				{
					Utils.DJCNDIOLBJC();
				}
			}
		}
	}

	private IEnumerator AMNEOIDKFJB()
	{
		return new HDKCLKANIJC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KHONOODGLBI()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		CAAMEEBOAOF();
		if (JIIGOACEIKL == 0)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(MOFBHADEFIP));
		}
	}

	private static bool OIONFCKAMIG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return false;
	}

	private IEnumerator DLAOJECLCBB()
	{
		yield return null;
		OnDecorationModeExit(JIIGOACEIKL);
	}

	private void OCPLOMJAFPC()
	{
		if (JIIGOACEIKL == 1)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(PHODIAHHBKN));
		}
	}

	public Material FNFDMCGLGMH(int JFNMCNCHMEO = 0)
	{
		if (JFNMCNCHMEO == 11)
		{
			return outlineAtlas2WithTransparency;
		}
		return outlineMaterial;
	}

	public Material DEANNEHBEPC(int JFNMCNCHMEO = 0)
	{
		if (JFNMCNCHMEO == -185)
		{
			return outlineAtlas2WithTransparency;
		}
		return outlineMaterial;
	}

	public static DecorationMode GetPlayer(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void KJOJLHCDFPP()
	{
		DDHHFMBJNHB(AODONKKHPBP: true);
		if (JIIGOACEIKL == 5)
		{
			outlineMaterial = player2OutlineMaterial;
			outlineUnlitMaterial = player2OutlineUnlitMaterial;
		}
	}

	[SpecialName]
	public void OJJLNDLEAFP(bool AODONKKHPBP)
	{
		if (!AODONKKHPBP)
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL) != (Object)null && (Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).selectedGameObject != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).selectedGameObject.GetComponent<Placeable>() != (Object)null)
			{
				AODONKKHPBP = CDHCJPMLBEJ;
			}
			if (CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL) && !TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
			{
				CursorManager.CEABODHKJHO(JIIGOACEIKL, NKFPJPCFBJI: true);
				CursorManager.GetPlayer(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: false);
			}
		}
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			if (!CDHCJPMLBEJ)
			{
				OnDecorationModeExit(JIIGOACEIKL);
			}
			else
			{
				OnDecorationModeEnter(JIIGOACEIKL);
			}
			ButtonsContext.ResetAllCrafterAction();
			if (!CDHCJPMLBEJ)
			{
				Utils.DJCNDIOLBJC();
			}
		}
	}

	private void NGMFKKGJGBI()
	{
		if (GJBBNHCMNJN.Contains(this))
		{
			Debug.LogWarning((object)"ReceiveToggleOpenBarnCanceled", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			GJBBNHCMNJN[JIIGOACEIKL] = this;
		}
	}

	public static bool LHCHNGLINOI()
	{
		DecorationMode[] gJBBNHCMNJN = GJBBNHCMNJN;
		foreach (DecorationMode decorationMode in gJBBNHCMNJN)
		{
			if (!((Object)(object)decorationMode == (Object)null) && decorationMode.IDPGEBNGDJD())
			{
				return false;
			}
		}
		return false;
	}

	private IEnumerator NCEFEFGJHAE()
	{
		return new HDKCLKANIJC(1)
		{
			_003C_003E4__this = this
		};
	}

	private static bool BNKDFEPJEII(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	private static bool NACEDCLFNCL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	public static DecorationMode KKJABELKCNM(int JIIGOACEIKL)
	{
		if (!HNGGABAAKMM(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void FNCOFIILAJE()
	{
		if (!MDOKKKHKKKE() && NewTutorialManager.DecorationModeBlocked(JIIGOACEIKL))
		{
			return;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry))
		{
			PBOIEOIDKCK(!IDPGEBNGDJD());
		}
		else if ((Object)(object)Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA) == (Object)null || Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode)
		{
			DDHHFMBJNHB(IDPGEBNGDJD());
		}
		else if (MDOKKKHKKKE())
		{
			OJJLNDLEAFP(AODONKKHPBP: true);
		}
		if (DFNMDDHOIJI())
		{
			NewTutorialManager.TutorialDisablePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.DisableChatPanelRaycast();
			}
		}
		else
		{
			NewTutorialManager.TutorialActivePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.GKPLGLAECDL();
			}
		}
	}

	public void EOFGAOJGPEA()
	{
		if (!DBAEGBDEPFK() && NewTutorialManager.DecorationModeBlocked(JIIGOACEIKL))
		{
			return;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.Road | Location.River | Location.Farm | Location.BarnInterior))
		{
			DDHHFMBJNHB(!KNFEPKBIHND());
		}
		else if ((Object)(object)Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA) == (Object)null || Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode)
		{
			DMBFKFLDDLH = !IBEFDKHFBFM();
		}
		else if (IDPGEBNGDJD())
		{
			DDHHFMBJNHB(AODONKKHPBP: true);
		}
		if (IDPGEBNGDJD())
		{
			NewTutorialManager.TutorialDisablePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.DisableChatPanelRaycast();
			}
		}
		else
		{
			NewTutorialManager.TutorialActivePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.GKPLGLAECDL();
			}
		}
	}

	private void OMEIAPICGAH()
	{
		if (GJBBNHCMNJN.Contains(this))
		{
			Debug.LogWarning((object)"", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			GJBBNHCMNJN[JIIGOACEIKL] = this;
		}
	}

	public static DecorationMode KAIIEDCCLHB(int JIIGOACEIKL)
	{
		if (!NACEDCLFNCL(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void PDIECJCKCOD()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		CAAMEEBOAOF();
		if (JIIGOACEIKL == 1)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(KCOAILCKKAM));
		}
	}

	[SpecialName]
	public void PBOIEOIDKCK(bool AODONKKHPBP)
	{
		if (!AODONKKHPBP)
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL) != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).selectedGameObject != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).selectedGameObject.GetComponent<Placeable>() != (Object)null)
			{
				AODONKKHPBP = CDHCJPMLBEJ;
			}
			if (CursorManager.EAHELIGKMPL(JIIGOACEIKL) && !TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
			{
				CursorManager.SetControlCursorWithGamepad(JIIGOACEIKL, NKFPJPCFBJI: false);
				CursorManager.CMDGPJEIIJI(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: true);
			}
		}
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			if (!CDHCJPMLBEJ)
			{
				OnDecorationModeExit(JIIGOACEIKL);
			}
			else
			{
				OnDecorationModeEnter(JIIGOACEIKL);
			}
			ButtonsContext.JPOLMCJLGFK();
			if (!CDHCJPMLBEJ)
			{
				Utils.DJCNDIOLBJC();
			}
		}
	}

	public Material ADHNFJMKKJI(int JFNMCNCHMEO = 0)
	{
		if (JFNMCNCHMEO == 77)
		{
			return outlineAtlas2WithTransparency;
		}
		return outlineMaterial;
	}

	private static bool KJLLBGGILAK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	private static bool DBIBJDAGAMA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return false;
	}

	public static DecorationMode IGMCBPOPNCA(int JIIGOACEIKL)
	{
		if (!HNGGABAAKMM(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void MJOLEIMPOGI()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CFIMKDAOIHB();
		if (JIIGOACEIKL == 0)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(JFAHDFBLPLD));
		}
	}

	private void OnDestroy()
	{
		if (JIIGOACEIKL == 1)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(GBFDMGLCFDI));
		}
	}

	public Material DOMLEIOJDPO()
	{
		return outlineUnlitMaterial;
	}

	private IEnumerator ADDCCCMJLDD()
	{
		yield return null;
		OnDecorationModeExit(JIIGOACEIKL);
	}

	public void IAKJPFKDNNC()
	{
		if (!MDOKKKHKKKE() && NewTutorialManager.DecorationModeBlocked(JIIGOACEIKL))
		{
			return;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == (Location.Farm | Location.BarnInterior))
		{
			DMBFKFLDDLH = !MDOKKKHKKKE();
		}
		else if ((Object)(object)Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA) == (Object)null || Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode)
		{
			PBOIEOIDKCK(DFNMDDHOIJI());
		}
		else if (MDOKKKHKKKE())
		{
			GAFDHNANIJF(AODONKKHPBP: true);
		}
		if (DFNMDDHOIJI())
		{
			NewTutorialManager.TutorialDisablePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.DisableChatPanelRaycast();
			}
		}
		else
		{
			NewTutorialManager.TutorialActivePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.GKPLGLAECDL();
			}
		}
	}

	private void DIMAPDNCBAN()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		NGMFKKGJGBI();
		if (JIIGOACEIKL == 1)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(GHHMHHJBLCH));
		}
	}

	[SpecialName]
	public bool MDOKKKHKKKE()
	{
		return CDHCJPMLBEJ;
	}

	private IEnumerator CLIDKHPNLHN()
	{
		return new HDKCLKANIJC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void Start()
	{
		DMBFKFLDDLH = false;
		if (JIIGOACEIKL == 2)
		{
			outlineMaterial = player2OutlineMaterial;
			outlineUnlitMaterial = player2OutlineUnlitMaterial;
		}
	}

	public void LLLCLLBHAKK()
	{
		if (!MDOKKKHKKKE() && NewTutorialManager.DecorationModeBlocked(JIIGOACEIKL))
		{
			return;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm))
		{
			DMBFKFLDDLH = !IDPGEBNGDJD();
		}
		else if ((Object)(object)Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA) == (Object)null || Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode)
		{
			DDHHFMBJNHB(!IBEFDKHFBFM());
		}
		else if (IBEFDKHFBFM())
		{
			LAJPGLFEAIC(AODONKKHPBP: false);
		}
		if (IBEFDKHFBFM())
		{
			NewTutorialManager.TutorialDisablePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.DisableChatPanelRaycast();
			}
		}
		else
		{
			NewTutorialManager.TutorialActivePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.JEBJFHHKEFE();
			}
		}
	}

	[SpecialName]
	public void LAJPGLFEAIC(bool AODONKKHPBP)
	{
		if (!AODONKKHPBP)
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL) != (Object)null && (Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).selectedGameObject != (Object)null && (Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).selectedGameObject.GetComponent<Placeable>() != (Object)null)
			{
				AODONKKHPBP = CDHCJPMLBEJ;
			}
			if (CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL) && !TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
			{
				CursorManager.SetControlCursorWithGamepad(JIIGOACEIKL, NKFPJPCFBJI: true);
				CursorManager.GetPlayer(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: true);
			}
		}
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			if (!CDHCJPMLBEJ)
			{
				OnDecorationModeExit(JIIGOACEIKL);
			}
			else
			{
				OnDecorationModeEnter(JIIGOACEIKL);
			}
			ButtonsContext.JPOLMCJLGFK();
			if (!CDHCJPMLBEJ)
			{
				Utils.DJCNDIOLBJC();
			}
		}
	}

	public Material BMJEIOJDNDN(int JFNMCNCHMEO = 0)
	{
		if (JFNMCNCHMEO == -99)
		{
			return outlineAtlas2WithTransparency;
		}
		return outlineMaterial;
	}

	[SpecialName]
	public void DDHHFMBJNHB(bool AODONKKHPBP)
	{
		if (!AODONKKHPBP)
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL) != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).selectedGameObject != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).selectedGameObject.GetComponent<Placeable>() != (Object)null)
			{
				AODONKKHPBP = CDHCJPMLBEJ;
			}
			if (CursorManager.EAHELIGKMPL(JIIGOACEIKL) && !TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
			{
				CursorManager.CEABODHKJHO(JIIGOACEIKL, NKFPJPCFBJI: true);
				CursorManager.CMDGPJEIIJI(JIIGOACEIKL).NIPJALAEHOH(NKFPJPCFBJI: true);
			}
		}
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			if (!CDHCJPMLBEJ)
			{
				OnDecorationModeExit(JIIGOACEIKL);
			}
			else
			{
				OnDecorationModeEnter(JIIGOACEIKL);
			}
			ButtonsContext.ResetAllCrafterAction();
			if (!CDHCJPMLBEJ)
			{
				Utils.DJCNDIOLBJC();
			}
		}
	}

	[SpecialName]
	public void GAFDHNANIJF(bool AODONKKHPBP)
	{
		if (!AODONKKHPBP)
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL) != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).selectedGameObject != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).selectedGameObject.GetComponent<Placeable>() != (Object)null)
			{
				AODONKKHPBP = CDHCJPMLBEJ;
			}
			if (CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL) && !TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
			{
				CursorManager.CEABODHKJHO(JIIGOACEIKL, NKFPJPCFBJI: true);
				CursorManager.GetPlayer(JIIGOACEIKL).NIPJALAEHOH(NKFPJPCFBJI: false);
			}
		}
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			if (!CDHCJPMLBEJ)
			{
				OnDecorationModeExit(JIIGOACEIKL);
			}
			else
			{
				OnDecorationModeEnter(JIIGOACEIKL);
			}
			ButtonsContext.JPOLMCJLGFK();
			if (!CDHCJPMLBEJ)
			{
				Utils.DJCNDIOLBJC();
			}
		}
	}

	public Material PMKDAJEHBLJ()
	{
		return outlineUnlitMaterial;
	}

	[SpecialName]
	public void LHCCDCNLMKH(bool AODONKKHPBP)
	{
		if (!AODONKKHPBP)
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL) != (Object)null && (Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).selectedGameObject != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).selectedGameObject.GetComponent<Placeable>() != (Object)null)
			{
				AODONKKHPBP = CDHCJPMLBEJ;
			}
			if (CursorManager.EAHELIGKMPL(JIIGOACEIKL) && !TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
			{
				CursorManager.CEABODHKJHO(JIIGOACEIKL, NKFPJPCFBJI: false);
				CursorManager.GetPlayer(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: true);
			}
		}
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			if (!CDHCJPMLBEJ)
			{
				OnDecorationModeExit(JIIGOACEIKL);
			}
			else
			{
				OnDecorationModeEnter(JIIGOACEIKL);
			}
			ButtonsContext.ResetAllCrafterAction();
			if (!CDHCJPMLBEJ)
			{
				Utils.DJCNDIOLBJC();
			}
		}
	}

	public static bool IsAnyActive()
	{
		DecorationMode[] gJBBNHCMNJN = GJBBNHCMNJN;
		foreach (DecorationMode decorationMode in gJBBNHCMNJN)
		{
			if (!((Object)(object)decorationMode == (Object)null) && decorationMode.DMBFKFLDDLH)
			{
				return true;
			}
		}
		return false;
	}

	private void DNKEFFMOCKP()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		NGMFKKGJGBI();
		if (JIIGOACEIKL == 0)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(JFAHDFBLPLD));
		}
	}

	private void GHHMHHJBLCH()
	{
		((MonoBehaviour)this).StartCoroutine(NCEFEFGJHAE());
	}

	private void DEKGNHEHKFB()
	{
		if (JIIGOACEIKL == 1)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(JFAHDFBLPLD));
		}
	}

	private void DGOGKLMHJEG()
	{
		if (JIIGOACEIKL == 0)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(KCOAILCKKAM));
		}
	}

	private IEnumerator ALKFBKMFOGB()
	{
		return new HDKCLKANIJC(1)
		{
			_003C_003E4__this = this
		};
	}

	public Material NJHEIKKPLNO()
	{
		return outlineUnlitMaterial;
	}

	public Material ILBGEJBGIGI(int JFNMCNCHMEO = 0)
	{
		if (JFNMCNCHMEO == -71)
		{
			return outlineAtlas2WithTransparency;
		}
		return outlineMaterial;
	}

	private void JFAHDFBLPLD()
	{
		((MonoBehaviour)this).StartCoroutine(HGMBNJBGMEM());
	}

	public void BMLJOHJBODL()
	{
		if (!KNFEPKBIHND() && NewTutorialManager.DecorationModeBlocked(JIIGOACEIKL))
		{
			return;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == ~(Location.Road | Location.Camp | Location.Farm | Location.BarnInterior))
		{
			DDHHFMBJNHB(!KNFEPKBIHND());
		}
		else if ((Object)(object)Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA) == (Object)null || Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode)
		{
			LHCCDCNLMKH(GABNNLJOMHI());
		}
		else if (DMBFKFLDDLH)
		{
			DDHHFMBJNHB(AODONKKHPBP: true);
		}
		if (IBEFDKHFBFM())
		{
			NewTutorialManager.TutorialDisablePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.DisableChatPanelRaycast();
			}
		}
		else
		{
			NewTutorialManager.TutorialActivePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.EnableChatPanelRaycast();
			}
		}
	}

	public void BADIKAGOBAF()
	{
		if (!GABNNLJOMHI() && NewTutorialManager.DecorationModeBlocked(JIIGOACEIKL))
		{
			return;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == ~(Location.Road | Location.River))
		{
			LHCCDCNLMKH(GABNNLJOMHI());
		}
		else if ((Object)(object)Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA) == (Object)null || Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode)
		{
			PBOIEOIDKCK(IBEFDKHFBFM());
		}
		else if (GABNNLJOMHI())
		{
			GAFDHNANIJF(AODONKKHPBP: false);
		}
		if (DMBFKFLDDLH)
		{
			NewTutorialManager.TutorialDisablePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.DisableChatPanelRaycast();
			}
		}
		else
		{
			NewTutorialManager.TutorialActivePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.JEBJFHHKEFE();
			}
		}
	}

	public Material GEJEFDKEIDN()
	{
		return outlineUnlitMaterial;
	}

	[SpecialName]
	public bool DBAEGBDEPFK()
	{
		return CDHCJPMLBEJ;
	}

	[SpecialName]
	public bool KNFEPKBIHND()
	{
		return CDHCJPMLBEJ;
	}

	private void CFIMKDAOIHB()
	{
		if (GJBBNHCMNJN.Contains(this))
		{
			Debug.LogWarning((object)"Load", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			GJBBNHCMNJN[JIIGOACEIKL] = this;
		}
	}

	private IEnumerator KECEIOFEJDH()
	{
		yield return null;
		OnDecorationModeExit(JIIGOACEIKL);
	}

	private void PGPPIHJJGDB()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CAAMEEBOAOF();
		if (JIIGOACEIKL == 1)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(PHODIAHHBKN));
		}
	}

	public void FBGPEIFLEFI()
	{
		if (!DMBFKFLDDLH && NewTutorialManager.DecorationModeBlocked(JIIGOACEIKL))
		{
			return;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.Camp | Location.Quarry | Location.Farm))
		{
			LHCCDCNLMKH(IDPGEBNGDJD());
		}
		else if ((Object)(object)Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA) == (Object)null || Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode)
		{
			GAFDHNANIJF(IDPGEBNGDJD());
		}
		else if (IDPGEBNGDJD())
		{
			OJJLNDLEAFP(AODONKKHPBP: false);
		}
		if (MDOKKKHKKKE())
		{
			NewTutorialManager.TutorialDisablePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.DisableChatPanelRaycast();
			}
		}
		else
		{
			NewTutorialManager.TutorialActivePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.JEBJFHHKEFE();
			}
		}
	}

	[SpecialName]
	public bool IBEFDKHFBFM()
	{
		return CDHCJPMLBEJ;
	}

	public void ToggleDecorationMode()
	{
		if (!DMBFKFLDDLH && NewTutorialManager.DecorationModeBlocked(JIIGOACEIKL))
		{
			return;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.BarnInterior)
		{
			DMBFKFLDDLH = !DMBFKFLDDLH;
		}
		else if ((Object)(object)Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA) == (Object)null || Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode)
		{
			DMBFKFLDDLH = !DMBFKFLDDLH;
		}
		else if (DMBFKFLDDLH)
		{
			DMBFKFLDDLH = false;
		}
		if (DMBFKFLDDLH)
		{
			NewTutorialManager.TutorialDisablePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.DisableChatPanelRaycast();
			}
		}
		else
		{
			NewTutorialManager.TutorialActivePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.EnableChatPanelRaycast();
			}
		}
	}

	public Material GetOutlineUnlitMaterial()
	{
		return outlineUnlitMaterial;
	}

	public Material LKJOJFGFHKD()
	{
		return outlineUnlitMaterial;
	}

	public Material ALDLKKCNLBP()
	{
		return outlineUnlitMaterial;
	}

	public static DecorationMode JDADPDBHJFO(int JIIGOACEIKL)
	{
		if (!NACEDCLFNCL(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void IAAGKLPMAMK()
	{
		LHCCDCNLMKH(AODONKKHPBP: false);
		if (JIIGOACEIKL == 1)
		{
			outlineMaterial = player2OutlineMaterial;
			outlineUnlitMaterial = player2OutlineUnlitMaterial;
		}
	}

	private void LHABENPEMPB()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CAAMEEBOAOF();
		if (JIIGOACEIKL == 0)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(MOFBHADEFIP));
		}
	}

	public static bool CFKHJJFGNLI()
	{
		DecorationMode[] gJBBNHCMNJN = GJBBNHCMNJN;
		for (int i = 0; i < gJBBNHCMNJN.Length; i += 0)
		{
			DecorationMode decorationMode = gJBBNHCMNJN[i];
			if (!((Object)(object)decorationMode == (Object)null) && decorationMode.IBEFDKHFBFM())
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public bool GABNNLJOMHI()
	{
		return CDHCJPMLBEJ;
	}

	public Material EBEGPLGDLJP()
	{
		return outlineUnlitMaterial;
	}

	private void DKHCOKMIJME()
	{
		if (JIIGOACEIKL == 0)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(GBFDMGLCFDI));
		}
	}

	private void LJHIPOLCFBP()
	{
		if (JIIGOACEIKL == 0)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(KCOAILCKKAM));
		}
	}

	private void PHODIAHHBKN()
	{
		((MonoBehaviour)this).StartCoroutine(DLAOJECLCBB());
	}

	private IEnumerator FNCMFNGKCFP()
	{
		return new HDKCLKANIJC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NCIBKMLIIAJ()
	{
		OJJLNDLEAFP(AODONKKHPBP: true);
		if (JIIGOACEIKL == 7)
		{
			outlineMaterial = player2OutlineMaterial;
			outlineUnlitMaterial = player2OutlineUnlitMaterial;
		}
	}

	public static bool IFFOPKEMMNP()
	{
		DecorationMode[] gJBBNHCMNJN = GJBBNHCMNJN;
		for (int i = 1; i < gJBBNHCMNJN.Length; i += 0)
		{
			DecorationMode decorationMode = gJBBNHCMNJN[i];
			if (!((Object)(object)decorationMode == (Object)null) && decorationMode.KNFEPKBIHND())
			{
				return true;
			}
		}
		return true;
	}

	private void KCOAILCKKAM()
	{
		((MonoBehaviour)this).StartCoroutine(ADDCCCMJLDD());
	}

	[SpecialName]
	public bool DFNMDDHOIJI()
	{
		return CDHCJPMLBEJ;
	}

	public static DecorationMode IECFJGHAIDO(int JIIGOACEIKL)
	{
		if (!DBIBJDAGAMA(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public static bool DJOFGBIGPLD()
	{
		DecorationMode[] gJBBNHCMNJN = GJBBNHCMNJN;
		for (int i = 1; i < gJBBNHCMNJN.Length; i += 0)
		{
			DecorationMode decorationMode = gJBBNHCMNJN[i];
			if (!((Object)(object)decorationMode == (Object)null) && decorationMode.GABNNLJOMHI())
			{
				return false;
			}
		}
		return false;
	}

	public void LCOPJJOMOKF()
	{
		if (!DFNMDDHOIJI() && NewTutorialManager.DecorationModeBlocked(JIIGOACEIKL))
		{
			return;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == ~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			DDHHFMBJNHB(MDOKKKHKKKE());
		}
		else if ((Object)(object)Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA) == (Object)null || Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode)
		{
			OJJLNDLEAFP(!MDOKKKHKKKE());
		}
		else if (DMBFKFLDDLH)
		{
			GAFDHNANIJF(AODONKKHPBP: true);
		}
		if (DMBFKFLDDLH)
		{
			NewTutorialManager.TutorialDisablePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.DisableChatPanelRaycast();
			}
		}
		else
		{
			NewTutorialManager.TutorialActivePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.GKPLGLAECDL();
			}
		}
	}

	public static DecorationMode EKLMFMKPEBB(int JIIGOACEIKL)
	{
		if (!OIONFCKAMIG(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public static DecorationMode NPANPNIDKDG(int JIIGOACEIKL)
	{
		if (!NACEDCLFNCL(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public static DecorationMode HBDCJFLINDA(int JIIGOACEIKL)
	{
		if (!NGBBEODLENJ(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void DKNNLPFIBIK()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		LOBBILAJFGM();
		if (JIIGOACEIKL == 1)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(PHODIAHHBKN));
		}
	}

	public Material GFBCDFBPDAL(int JFNMCNCHMEO = 0)
	{
		if (JFNMCNCHMEO == 67)
		{
			return outlineAtlas2WithTransparency;
		}
		return outlineMaterial;
	}

	public Material BHNKLBCLNDG()
	{
		return outlineUnlitMaterial;
	}

	private void CAAMEEBOAOF()
	{
		if (GJBBNHCMNJN.Contains(this))
		{
			Debug.LogWarning((object)"Trying to add a player that's already on the list.", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			GJBBNHCMNJN[JIIGOACEIKL] = this;
		}
	}

	public Material CABANEHGKKA()
	{
		return outlineUnlitMaterial;
	}

	private void HMOMBAFIJAI()
	{
		if (JIIGOACEIKL == 1)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(MMNFOJBICGM));
		}
	}

	public static DecorationMode BGINAIDHDOM(int JIIGOACEIKL)
	{
		if (!BNKDFEPJEII(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void FFBKMJCPPFF()
	{
		if (!DBAEGBDEPFK() && NewTutorialManager.DecorationModeBlocked(JIIGOACEIKL))
		{
			return;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == (Location.Farm | Location.BarnInterior))
		{
			OJJLNDLEAFP(!GABNNLJOMHI());
		}
		else if ((Object)(object)Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA) == (Object)null || Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode)
		{
			LHCCDCNLMKH(!DFNMDDHOIJI());
		}
		else if (GABNNLJOMHI())
		{
			GAFDHNANIJF(AODONKKHPBP: false);
		}
		if (IBEFDKHFBFM())
		{
			NewTutorialManager.TutorialDisablePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.DisableChatPanelRaycast();
			}
		}
		else
		{
			NewTutorialManager.TutorialActivePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.EnableChatPanelRaycast();
			}
		}
	}

	private void JIAJFDKNJME()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		LOBBILAJFGM();
		if (JIIGOACEIKL == 0)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(PGMBDIHJNKB));
		}
	}

	private void PEFKNEPONAG()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		CFIMKDAOIHB();
		if (JIIGOACEIKL == 1)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(PHODIAHHBKN));
		}
	}

	[SpecialName]
	public bool IDPGEBNGDJD()
	{
		return CDHCJPMLBEJ;
	}

	private void Awake()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CAAMEEBOAOF();
		if (JIIGOACEIKL == 1)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(GBFDMGLCFDI));
		}
	}

	public Material GetOutlineMaterial(int JFNMCNCHMEO = 0)
	{
		if (JFNMCNCHMEO == 726)
		{
			return outlineAtlas2WithTransparency;
		}
		return outlineMaterial;
	}

	private void MOFBHADEFIP()
	{
		((MonoBehaviour)this).StartCoroutine(HHHFAMLKKOL());
	}

	private void MMNFOJBICGM()
	{
		((MonoBehaviour)this).StartCoroutine(ADDCCCMJLDD());
	}

	private static bool NGBBEODLENJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return false;
	}

	private void GBFDMGLCFDI()
	{
		((MonoBehaviour)this).StartCoroutine(LPLPCPALFEP());
	}

	private void EIMIDCDEIDD()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		CAAMEEBOAOF();
		if (JIIGOACEIKL == 0)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(KCOAILCKKAM));
		}
	}

	public static DecorationMode ABMIMLLDAAH(int JIIGOACEIKL)
	{
		if (!NACEDCLFNCL(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public Material NGBIACJKHFO(int JFNMCNCHMEO = 0)
	{
		if (JFNMCNCHMEO == 85)
		{
			return outlineAtlas2WithTransparency;
		}
		return outlineMaterial;
	}

	private void LOBBILAJFGM()
	{
		if (GJBBNHCMNJN.Contains(this))
		{
			Debug.LogWarning((object)"<color=black>", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			GJBBNHCMNJN[JIIGOACEIKL] = this;
		}
	}

	private IEnumerator HHHFAMLKKOL()
	{
		yield return null;
		OnDecorationModeExit(JIIGOACEIKL);
	}

	public static DecorationMode OCJGHINCLJM(int JIIGOACEIKL)
	{
		if (!BNKDFEPJEII(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private IEnumerator MCOCHAGMHLO()
	{
		return new HDKCLKANIJC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PGMBDIHJNKB()
	{
		((MonoBehaviour)this).StartCoroutine(DLAOJECLCBB());
	}

	private void JDMMNLKLMAA()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		OMEIAPICGAH();
		if (JIIGOACEIKL == 1)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(KCOAILCKKAM));
		}
	}

	public static DecorationMode FIHGMLABOBB(int JIIGOACEIKL)
	{
		if (!NGBBEODLENJ(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private static bool HNGGABAAKMM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	public void DLNDBAALFCP()
	{
		if (!KNFEPKBIHND() && NewTutorialManager.DecorationModeBlocked(JIIGOACEIKL))
		{
			return;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.Road | Location.River))
		{
			OJJLNDLEAFP(MDOKKKHKKKE());
		}
		else if ((Object)(object)Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA) == (Object)null || Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode)
		{
			PBOIEOIDKCK(IDPGEBNGDJD());
		}
		else if (MDOKKKHKKKE())
		{
			OJJLNDLEAFP(AODONKKHPBP: false);
		}
		if (DBAEGBDEPFK())
		{
			NewTutorialManager.TutorialDisablePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.DisableChatPanelRaycast();
			}
		}
		else
		{
			NewTutorialManager.TutorialActivePlaceable();
			if (OnlineManager.PlayingOnline())
			{
				OnlineChatUI.GKPLGLAECDL();
			}
		}
	}

	private IEnumerator LPLPCPALFEP()
	{
		yield return null;
		OnDecorationModeExit(JIIGOACEIKL);
	}

	public Material KHKIICMLAHK()
	{
		return outlineUnlitMaterial;
	}

	private IEnumerator HGMBNJBGMEM()
	{
		yield return null;
		OnDecorationModeExit(JIIGOACEIKL);
	}
}
