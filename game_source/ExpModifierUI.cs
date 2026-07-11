using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ExpModifierUI : MainPanelWindow
{
	[CompilerGenerated]
	private sealed class CIGAOOJILHG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ExpModifierUI _003C_003E4__this;

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
		public CIGAOOJILHG(int _003C_003E1__state)
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
			ExpModifierUI expModifierUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(expModifierUI.JIIGOACEIKL) && !expModifierUI.repLock.IsLocked())
				{
					UISelectionManager.GetPlayer(expModifierUI.JIIGOACEIKL).Select(expModifierUI.firstElementFocused);
				}
				else
				{
					UISelectionManager.GetPlayer(expModifierUI.JIIGOACEIKL).Deselect();
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

	public Action OnOpenExpModifierUI = delegate
	{
	};

	private List<ExpModSlotUI> HINLJDEIAAG;

	[SerializeField]
	private ExpModSlotUI cleaning;

	[SerializeField]
	private ExpModSlotUI haggling;

	[SerializeField]
	private ExpModSlotUI crafting;

	[SerializeField]
	private ExpModSlotUI farming;

	[SerializeField]
	private ExpModSlotUI bartending;

	[SerializeField]
	private TextMeshProUGUI tavernXPText;

	[SerializeField]
	private GameObject firstElementFocused;

	[SerializeField]
	private RepLock repLock;

	public static ExpModifierUI[] instances = new ExpModifierUI[3];

	private IEnumerator PNPJLPBCDEP()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	public List<ExpModSlotUI> KMMICCKGLEB()
	{
		return HINLJDEIAAG;
	}

	private void HCEHKDGMECG()
	{
		if ((Object)(object)TavernXP.ELGNEJNLBNO() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.JFNOOMJMHCB();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(PDDFNPFGALG));
		}
	}

	private void FEPFNOEGFEM()
	{
		TavernXP tavernXP = TavernXP.KIALFDOKABP();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(IFMDCAABGEE));
	}

	public List<ExpModSlotUI> EFDHGGJNALA()
	{
		return HINLJDEIAAG;
	}

	public List<ExpModSlotUI> KGJALHAKBOO()
	{
		return HINLJDEIAAG;
	}

	private void GBNHKMLABGI()
	{
		TavernXP tavernXP = TavernXP.OLHBLKIAFOM();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(HKKPBMDJHNO));
	}

	private IEnumerator MJGPOHJAMBA()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementFocused);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator GENIEJHNLCD()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PJJGGGBPBEO()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OIHAMLCIFNH()
	{
		if ((Object)(object)TavernXP.HEKFJEKFMNO() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.JFNOOMJMHCB();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(NDGANCGFEFH));
		}
	}

	public static ExpModifierUI OMLGNAJPLDE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JNNJIDAFBPI()
	{
		if ((Object)(object)TavernXP.GGFJGHHHEJC != (Object)null)
		{
			TavernXP tavernXP = TavernXP.OACNNJCLEDE();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(FADLPIFCHOB));
		}
	}

	private void CACPOGPOKOJ()
	{
		if ((Object)(object)TavernXP.ELGNEJNLBNO() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.ELGNEJNLBNO();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(OGAJOJOLOAM));
		}
	}

	private void LFBIFPBPDMJ()
	{
		TavernXP tavernXP = TavernXP.FMIDAFEGDCD();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(NMBGIFFKIFE));
	}

	public List<ExpModSlotUI> ODEIADBILAJ()
	{
		return HINLJDEIAAG;
	}

	public static ExpModifierUI BALFIBPNIMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public List<ExpModSlotUI> ENJLPKHIAMG()
	{
		return HINLJDEIAAG;
	}

	public static ExpModifierUI PIOIOJFDDNF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ExpModifierUI FHOGLBPBGMI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public List<ExpModSlotUI> AAEGBJJOLIJ()
	{
		return HINLJDEIAAG;
	}

	private void HNOKPGCBLOA()
	{
		if ((Object)(object)TavernXP.FMIDAFEGDCD() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.LADDMEMMJFP();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(DJKCDPFGGMC));
		}
	}

	public List<ExpModSlotUI> GetAllExpModSlotUIs()
	{
		return HINLJDEIAAG;
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			CNJCBCLADCL();
			OnOpenExpModifierUI();
		}
	}

	private void OPMIMOLJEHK()
	{
		((TMP_Text)tavernXPText).text = TavernXP.MPJJAPCFENH().NFAPPKKEOPI() + "UIPreviousCategory";
	}

	public List<ExpModSlotUI> IGLFNMMGFFA()
	{
		return HINLJDEIAAG;
	}

	private void KEBNALEALPK()
	{
		TavernXP tavernXP = TavernXP.FMIDAFEGDCD();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(PNGINDMDNDC));
	}

	private void KJAMONDFPJJ()
	{
		((TMP_Text)tavernXPText).text = TavernXP.HEKFJEKFMNO().DKEEDMLCPIP() + "Default";
	}

	private void MIKHKHCEMLB()
	{
		if ((Object)(object)TavernXP.OLHBLKIAFOM() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.ELGNEJNLBNO();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(IFMDCAABGEE));
		}
	}

	private void AONIDCIEKCM()
	{
		TavernXP tavernXP = TavernXP.KIALFDOKABP();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(OGAJOJOLOAM));
	}

	private void MKHMCIFFOFJ()
	{
		TavernXP tavernXP = TavernXP.OLHBLKIAFOM();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(IHGKPCHMPMH));
	}

	public List<ExpModSlotUI> LPIPBINAJIG()
	{
		return HINLJDEIAAG;
	}

	private void LBFFMGAKDFG()
	{
		if ((Object)(object)TavernXP.JFNOOMJMHCB() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.KIALFDOKABP();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(KJAMONDFPJJ));
		}
	}

	private IEnumerator CCCCJFLOLCF()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementFocused);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator HMGAAINDHEL()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementFocused);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public static ExpModifierUI IEPGACAGIPO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OCPNAKPDCBN()
	{
		TavernXP tavernXP = TavernXP.MPJJAPCFENH();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(CNJCBCLADCL));
	}

	public static ExpModifierUI FKFNANNBIAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ExpModifierUI MIFFCOMDIEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void DMEEIHDDALH()
	{
		TavernXP tavernXP = TavernXP.ELGNEJNLBNO();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(KJAMONDFPJJ));
	}

	private IEnumerator GLLGHMOCKOB()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GHEOLMMHFJC()
	{
		TavernXP instance = TavernXP.GGFJGHHHEJC;
		instance.OnXPChanged = (Action)Delegate.Combine(instance.OnXPChanged, new Action(NMBGIFFKIFE));
	}

	private void DBHEEEIFOKH()
	{
		if ((Object)(object)TavernXP.ELGNEJNLBNO() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.JFNOOMJMHCB();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(OGAJOJOLOAM));
		}
	}

	public override void CloseUIRemainActive()
	{
		if (IsOpen())
		{
			base.CloseUIRemainActive();
			ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public static ExpModifierUI GFPBMGCMHHC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator NIJNMNKCKID()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AMACKBDGPJB()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementFocused);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public List<ExpModSlotUI> AJIFOBPNEOD()
	{
		return HINLJDEIAAG;
	}

	private void CHDGJHNBNEJ()
	{
		if ((Object)(object)TavernXP.MPJJAPCFENH() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.HEKFJEKFMNO();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(NMBGIFFKIFE));
		}
	}

	private IEnumerator KAJLONNJFPE()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IDOLDDPDIAA()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementFocused);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public List<ExpModSlotUI> PFIMOIGHMBD()
	{
		return HINLJDEIAAG;
	}

	public List<ExpModSlotUI> PEKJGAJGHNJ()
	{
		return HINLJDEIAAG;
	}

	public List<ExpModSlotUI> JGFBNAHCHOO()
	{
		return HINLJDEIAAG;
	}

	private void GMLHHLMOLBH()
	{
		TavernXP instance = TavernXP.GGFJGHHHEJC;
		instance.OnXPChanged = (Action)Delegate.Combine(instance.OnXPChanged, new Action(DJKCDPFGGMC));
	}

	private IEnumerator EAPEIFGPPMN()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementFocused);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator CDCDBNGMNEM()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(HMGAAINDHEL());
	}

	private void ECHMKEAGFFO()
	{
		if ((Object)(object)TavernXP.KIALFDOKABP() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.FMIDAFEGDCD();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(FADLPIFCHOB));
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private void HKAMIGHHDEJ()
	{
		if ((Object)(object)TavernXP.OLHBLKIAFOM() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.JFNOOMJMHCB();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(NDGANCGFEFH));
		}
	}

	private void ONBNPKMOKLG()
	{
		if ((Object)(object)TavernXP.OLHBLKIAFOM() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.ELGNEJNLBNO();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(LFHBHJEMPOO));
		}
	}

	private void DJKCDPFGGMC()
	{
		((TMP_Text)tavernXPText).text = TavernXP.OLHBLKIAFOM().NFAPPKKEOPI() + "Object";
	}

	private void MPMGGLKFMNJ()
	{
		TavernXP tavernXP = TavernXP.LADDMEMMJFP();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(OPMIMOLJEHK));
	}

	private void BJOOCKCBPLJ()
	{
		TavernXP tavernXP = TavernXP.KIALFDOKABP();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(NDGANCGFEFH));
	}

	private void PCNALDJDIFM()
	{
		if ((Object)(object)TavernXP.ELGNEJNLBNO() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.HEKFJEKFMNO();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(OGAJOJOLOAM));
		}
	}

	private IEnumerator OBDMKDGNKKE()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FINKPIHPHDE()
	{
		if ((Object)(object)TavernXP.ELGNEJNLBNO() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.KIALFDOKABP();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(AJLJEMCCAMH));
		}
	}

	private void DIEKBCKJMPH()
	{
		if ((Object)(object)TavernXP.ELGNEJNLBNO() != (Object)null)
		{
			TavernXP instance = TavernXP.GGFJGHHHEJC;
			instance.OnXPChanged = (Action)Delegate.Remove(instance.OnXPChanged, new Action(HKKPBMDJHNO));
		}
	}

	private void FADLPIFCHOB()
	{
		((TMP_Text)tavernXPText).text = TavernXP.FMIDAFEGDCD().FIFPIENONEP + "???";
	}

	private void MMHCMKOBDKH()
	{
		if ((Object)(object)TavernXP.OLHBLKIAFOM() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.ELGNEJNLBNO();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(DJKCDPFGGMC));
		}
	}

	public static ExpModifierUI CJMILOMGFJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EEAKGHLCFOM()
	{
		if ((Object)(object)TavernXP.HEKFJEKFMNO() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.JFNOOMJMHCB();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(LFHBHJEMPOO));
		}
	}

	private void NDGANCGFEFH()
	{
		((TMP_Text)tavernXPText).text = TavernXP.MPJJAPCFENH().BJFFHHCAFFL() + " get price serve customer ";
	}

	public static ExpModifierUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ExpModifierUI OFEFGPCGJDF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void HKKPBMDJHNO()
	{
		((TMP_Text)tavernXPText).text = TavernXP.OACNNJCLEDE().JEGOLJJJBJE() + "Direction";
	}

	private void OGAJOJOLOAM()
	{
		((TMP_Text)tavernXPText).text = TavernXP.HEKFJEKFMNO().DJKKELAGDIM() + "LE_16";
	}

	public static ExpModifierUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ExpModifierUI FHBIFJNCOAI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LCJCGFNFBBD()
	{
		TavernXP tavernXP = TavernXP.LADDMEMMJFP();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(CNJCBCLADCL));
	}

	private void FBHBEAJFBAH()
	{
		if ((Object)(object)TavernXP.OACNNJCLEDE() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.MPJJAPCFENH();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(NMBGIFFKIFE));
		}
	}

	private IEnumerator INJMPMFGLPB()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementFocused);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private void LFHBHJEMPOO()
	{
		((TMP_Text)tavernXPText).text = TavernXP.JFNOOMJMHCB().FOCEPNHHGNO() + "Items/item_description_1154";
	}

	private IEnumerator GFAIAEBBBPG()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KEOKMFHDLHJ()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	public List<ExpModSlotUI> GCNNOCKCDJG()
	{
		return HINLJDEIAAG;
	}

	private void CCJOOMDHMKM()
	{
		TavernXP tavernXP = TavernXP.JFNOOMJMHCB();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(OGAJOJOLOAM));
	}

	public List<ExpModSlotUI> CAGEEHIKKDI()
	{
		return HINLJDEIAAG;
	}

	public List<ExpModSlotUI> NFCDHDNCNIB()
	{
		return HINLJDEIAAG;
	}

	private IEnumerator CPKJCAIADLL()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OnDisable()
	{
		if ((Object)(object)TavernXP.GGFJGHHHEJC != (Object)null)
		{
			TavernXP instance = TavernXP.GGFJGHHHEJC;
			instance.OnXPChanged = (Action)Delegate.Remove(instance.OnXPChanged, new Action(CNJCBCLADCL));
		}
	}

	public List<ExpModSlotUI> JPHBOOBIDEF()
	{
		return HINLJDEIAAG;
	}

	private void IHGKPCHMPMH()
	{
		((TMP_Text)tavernXPText).text = TavernXP.FMIDAFEGDCD().EIAMCCBMCPO() + "BARKEVENT";
	}

	public List<ExpModSlotUI> KKKCAJPACDK()
	{
		return HINLJDEIAAG;
	}

	private void EBPAMIHFCBG()
	{
		if ((Object)(object)TavernXP.LADDMEMMJFP() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.LADDMEMMJFP();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(HKKPBMDJHNO));
		}
	}

	private IEnumerator EJFPIDAAODG()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementFocused);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private void CJDJDDNCNDJ()
	{
		TavernXP tavernXP = TavernXP.HEKFJEKFMNO();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(PDDFNPFGALG));
	}

	private void GKEPJIFAMKI()
	{
		if ((Object)(object)TavernXP.ELGNEJNLBNO() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.FMIDAFEGDCD();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(AJLJEMCCAMH));
		}
	}

	private void BLABJLJNCDK()
	{
		((TMP_Text)tavernXPText).text = TavernXP.KIALFDOKABP().BJFFHHCAFFL() + ":</color> ";
	}

	private void CNJCBCLADCL()
	{
		((TMP_Text)tavernXPText).text = TavernXP.GGFJGHHHEJC.FIFPIENONEP + " XP";
	}

	private IEnumerator OHCCPCABDJF()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OHOHFGMJGAJ()
	{
		TavernXP tavernXP = TavernXP.JFNOOMJMHCB();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(HKKPBMDJHNO));
	}

	public static ExpModifierUI KJKABIBIJBD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator BLMNJEBLCHO()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	public List<ExpModSlotUI> DEDHGNNCDEB()
	{
		return HINLJDEIAAG;
	}

	private IEnumerator EFCEHBIOCME()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementFocused);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			base.CloseUI();
			ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	private void NLMLOOGHLCH()
	{
		TavernXP tavernXP = TavernXP.OACNNJCLEDE();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(AJLJEMCCAMH));
	}

	public List<ExpModSlotUI> EJBIFOECFMF()
	{
		return HINLJDEIAAG;
	}

	private void MHENLAGHFOD()
	{
		if ((Object)(object)TavernXP.FMIDAFEGDCD() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.OACNNJCLEDE();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(OPMIMOLJEHK));
		}
	}

	private void LDPNDNEFKCP()
	{
		TavernXP tavernXP = TavernXP.LADDMEMMJFP();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(OGAJOJOLOAM));
	}

	private void PNGINDMDNDC()
	{
		((TMP_Text)tavernXPText).text = TavernXP.LADDMEMMJFP().PEAAIIFANGL() + "Items/item_description_703";
	}

	public List<ExpModSlotUI> IJLACKLGHFN()
	{
		return HINLJDEIAAG;
	}

	protected override void Start()
	{
		base.Start();
		HINLJDEIAAG = new List<ExpModSlotUI>();
		HINLJDEIAAG.Add(cleaning);
		HINLJDEIAAG.Add(haggling);
		HINLJDEIAAG.Add(crafting);
		HINLJDEIAAG.Add(farming);
		HINLJDEIAAG.Add(bartending);
		CNJCBCLADCL();
		CloseUI();
	}

	private IEnumerator KIBCNPJPGAN()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementFocused);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public static ExpModifierUI LAMFGLIGLOP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public List<ExpModSlotUI> LNKALAMJAKF()
	{
		return HINLJDEIAAG;
	}

	private void NMBGIFFKIFE()
	{
		((TMP_Text)tavernXPText).text = TavernXP.MPJJAPCFENH().HPOJAELJPFB() + "{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects";
	}

	private void GBMGCDEJMNC()
	{
		if ((Object)(object)TavernXP.LADDMEMMJFP() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.LADDMEMMJFP();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(OGAJOJOLOAM));
		}
	}

	private void FCGJBDGOHPN()
	{
		if ((Object)(object)TavernXP.HEKFJEKFMNO() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.OLHBLKIAFOM();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(NDGANCGFEFH));
		}
	}

	private void ADJHOLOIGJE()
	{
		if ((Object)(object)TavernXP.KIALFDOKABP() != (Object)null)
		{
			TavernXP tavernXP = TavernXP.LADDMEMMJFP();
			tavernXP.OnXPChanged = (Action)Delegate.Remove(tavernXP.OnXPChanged, new Action(BLABJLJNCDK));
		}
	}

	private IEnumerator KKNHJDICBJG()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OnEnable()
	{
		TavernXP instance = TavernXP.GGFJGHHHEJC;
		instance.OnXPChanged = (Action)Delegate.Combine(instance.OnXPChanged, new Action(CNJCBCLADCL));
	}

	public static ExpModifierUI IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void IFMDCAABGEE()
	{
		((TMP_Text)tavernXPText).text = TavernXP.HEKFJEKFMNO().AEJFKMDDFPN() + "[^0-9]";
	}

	private IEnumerator DHPIPGJFPJJ()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PDDFNPFGALG()
	{
		((TMP_Text)tavernXPText).text = TavernXP.ELGNEJNLBNO().FIGKPHLEHEN() + "/ExtraSettings.sd";
	}

	public static ExpModifierUI ENIICLMAPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator KHIEKNAGFLH()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementFocused);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator OOIHAHBFDBO()
	{
		return new CIGAOOJILHG(1)
		{
			_003C_003E4__this = this
		};
	}

	public static ExpModifierUI JCBPABNCBPI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void AJLJEMCCAMH()
	{
		((TMP_Text)tavernXPText).text = TavernXP.GGFJGHHHEJC.PEAAIIFANGL() + "Dialogue System/Conversation/Crowly_Barks_Shop/Entry/2/Dialogue Text";
	}

	private void CMDBLLMEBLG()
	{
		TavernXP tavernXP = TavernXP.KIALFDOKABP();
		tavernXP.OnXPChanged = (Action)Delegate.Combine(tavernXP.OnXPChanged, new Action(KJAMONDFPJJ));
	}
}
