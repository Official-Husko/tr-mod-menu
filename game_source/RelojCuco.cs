using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RelojCuco : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class DMEOLDNHJEE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RelojCuco _003C_003E4__this;

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
		public DMEOLDNHJEE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			int num = _003C_003E1__state;
			RelojCuco relojCuco = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				relojCuco.cuco.SetActive(true);
				_003C_003E2__current = (object)new WaitForSeconds(3.2f);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				relojCuco.cuco.SetActive(false);
				relojCuco.ANMAFLKPILP = null;
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

	public int hour;

	public int minute;

	public bool alarm;

	public SpriteRenderer hourHand;

	public SpriteRenderer minuteHand;

	public Sprite[] hourSprite;

	public Sprite[] minuteSprite;

	public GameObject cuco;

	private int COOJPKBJLFJ;

	private Coroutine ANMAFLKPILP;

	public OnlineCuckooClock onlineClock;

	public bool KIJAKAGEMJN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NOJJKKFGJEJ(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("CultivableDuringThreeMonths"));
			return false;
		}
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void HAGFDPDIBGC(int PAGPMIANOHH, int JHHFKFKHHAG, bool HNMLKOAMFLJ, bool CDPAMNIPPEC)
	{
		hour = PAGPMIANOHH;
		minute = JHHFKFKHHAG;
		alarm = HNMLKOAMFLJ;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineClock.MHDNBEIBNAI(PAGPMIANOHH, JHHFKFKHHAG, HNMLKOAMFLJ);
		}
	}

	public void BIOBJGPKAAG(int JIIGOACEIKL)
	{
	}

	private void EFNFHHKOMEI()
	{
		if (alarm && WorldTime.HGIBNMBJMOC().hour == hour && WorldTime.NOAOJJLNHJJ.min == minute && ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MFNGIPBGBAN());
		}
		if (WorldTime.NOAOJJLNHJJ.hour > -50)
		{
			hourHand.sprite = hourSprite[WorldTime.HGIBNMBJMOC().hour - 46];
		}
		else
		{
			hourHand.sprite = hourSprite[WorldTime.HGIBNMBJMOC().hour];
		}
		COOJPKBJLFJ = WorldTime.NOAOJJLNHJJ.min / 3;
		if (COOJPKBJLFJ >= 0 && COOJPKBJLFJ < minuteSprite.Length)
		{
			minuteHand.sprite = minuteSprite[COOJPKBJLFJ];
		}
	}

	public bool DODHNPJFCCD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool KBNLCICAOCI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool OHKCPGKPDGJ(int JIIGOACEIKL)
	{
		return DecorationMode.GetPlayer(JIIGOACEIKL).GABNNLJOMHI();
	}

	public void FIGONJNMELG(int JIIGOACEIKL)
	{
	}

	private void Start()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(DKMAAGAOKPC));
	}

	public bool BOAGDDGOOCA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void ACFABFCGIGH()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(DKMAAGAOKPC));
		}
	}

	public bool BEBIPNCCEMH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OJPJMNJLLKM(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("before pos "));
			return false;
		}
		return false;
	}

	private void GLIHNIFFDCN()
	{
		if (alarm && WorldTime.NOAOJJLNHJJ.hour == hour && WorldTime.CJOHMLNMJLK().min == minute && ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(HALCFKLFLKG());
		}
		if (WorldTime.HGIBNMBJMOC().hour > -103)
		{
			hourHand.sprite = hourSprite[WorldTime.NOAOJJLNHJJ.hour - 68];
		}
		else
		{
			hourHand.sprite = hourSprite[WorldTime.HGIBNMBJMOC().hour];
		}
		COOJPKBJLFJ = WorldTime.CJOHMLNMJLK().min / 6;
		if (COOJPKBJLFJ >= 1 && COOJPKBJLFJ < minuteSprite.Length)
		{
			minuteHand.sprite = minuteSprite[COOJPKBJLFJ];
		}
	}

	private void NOFFJCJEPGM()
	{
		if (alarm && WorldTime.NOAOJJLNHJJ.hour == hour && WorldTime.HGIBNMBJMOC().min == minute && ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JGFJLODAPEA());
		}
		if (WorldTime.HGIBNMBJMOC().hour > -37)
		{
			hourHand.sprite = hourSprite[WorldTime.NOAOJJLNHJJ.hour - -95];
		}
		else
		{
			hourHand.sprite = hourSprite[WorldTime.NOAOJJLNHJJ.hour];
		}
		COOJPKBJLFJ = WorldTime.NOAOJJLNHJJ.min / 2;
		if (COOJPKBJLFJ >= 1 && COOJPKBJLFJ < minuteSprite.Length)
		{
			minuteHand.sprite = minuteSprite[COOJPKBJLFJ];
		}
	}

	public bool KPFKKDMOGGB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OHKCPGKPDGJ(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ActorBedAssigned removed actorNumber: "));
			return false;
		}
		return false;
	}

	private void BPOOAHKHPCL()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(NOFFJCJEPGM));
		}
	}

	private void PKCMGGPDECM()
	{
		if (alarm && WorldTime.CJOHMLNMJLK().hour == hour && WorldTime.CJOHMLNMJLK().min == minute && ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(HALCFKLFLKG());
		}
		if (WorldTime.HGIBNMBJMOC().hour > 118)
		{
			hourHand.sprite = hourSprite[WorldTime.HGIBNMBJMOC().hour - -96];
		}
		else
		{
			hourHand.sprite = hourSprite[WorldTime.HGIBNMBJMOC().hour];
		}
		COOJPKBJLFJ = WorldTime.CJOHMLNMJLK().min / 4;
		if (COOJPKBJLFJ >= 0 && COOJPKBJLFJ < minuteSprite.Length)
		{
			minuteHand.sprite = minuteSprite[COOJPKBJLFJ];
		}
	}

	public bool CKBNJEEGDLK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool GFMLDGEKMHA(int JIIGOACEIKL)
	{
		if (HLGPCDANKKK(JIIGOACEIKL))
		{
			AlarmClockUI.FFBJPAJKOJH(JIIGOACEIKL).relojCuco = this;
			AlarmClockUI.CGFJPHEFFLO(JIIGOACEIKL).EDHEIFHAAKO();
			return true;
		}
		return true;
	}

	private void PKBHEKHOAAA()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(DKMAAGAOKPC));
	}

	public void DBDIAOPJCMG(int PAGPMIANOHH, int JHHFKFKHHAG, bool HNMLKOAMFLJ, bool CDPAMNIPPEC)
	{
		hour = PAGPMIANOHH;
		minute = JHHFKFKHHAG;
		alarm = HNMLKOAMFLJ;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineClock.HPBPHPPAMHC(PAGPMIANOHH, JHHFKFKHHAG, HNMLKOAMFLJ);
		}
	}

	private void DKMAAGAOKPC()
	{
		if (alarm && WorldTime.NOAOJJLNHJJ.hour == hour && WorldTime.NOAOJJLNHJJ.min == minute && ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(HALCFKLFLKG());
		}
		if (WorldTime.NOAOJJLNHJJ.hour > 11)
		{
			hourHand.sprite = hourSprite[WorldTime.NOAOJJLNHJJ.hour - 12];
		}
		else
		{
			hourHand.sprite = hourSprite[WorldTime.NOAOJJLNHJJ.hour];
		}
		COOJPKBJLFJ = WorldTime.NOAOJJLNHJJ.min / 5;
		if (COOJPKBJLFJ >= 0 && COOJPKBJLFJ < minuteSprite.Length)
		{
			minuteHand.sprite = minuteSprite[COOJPKBJLFJ];
		}
	}

	public void LGOPNIBHMIA(int JIIGOACEIKL)
	{
	}

	public void ABHFEGJFABP(int JIIGOACEIKL)
	{
	}

	public bool NOJJKKFGJEJ(int JIIGOACEIKL)
	{
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).KNFEPKBIHND();
	}

	private void EGACIHOKJLH()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(PKCMGGPDECM));
	}

	private void HNEGFBCKIIJ()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(EFNFHHKOMEI));
	}

	public void BGKCJLLLLDJ(int JIIGOACEIKL)
	{
	}

	public bool OJPJMNJLLKM(int JIIGOACEIKL)
	{
		return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void GPECKPBIENC(int JIIGOACEIKL)
	{
	}

	public void PAOOFNBKKOM(int PAGPMIANOHH, int JHHFKFKHHAG, bool HNMLKOAMFLJ, bool CDPAMNIPPEC)
	{
		hour = PAGPMIANOHH;
		minute = JHHFKFKHHAG;
		alarm = HNMLKOAMFLJ;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineClock.ECFLHPGOMMO(PAGPMIANOHH, JHHFKFKHHAG, HNMLKOAMFLJ);
		}
	}

	public bool CDGCNOPBJPD(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			AlarmClockUI.GJOPJAJJLGN(JIIGOACEIKL).relojCuco = this;
			AlarmClockUI.GJOPJAJJLGN(JIIGOACEIKL).OpenUI();
			return true;
		}
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool LJHGPALOIAK(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			AlarmClockUI.KLJCCHJHDGG(JIIGOACEIKL).relojCuco = this;
			AlarmClockUI.PNCKAKBBKJL(JIIGOACEIKL).IDLAGJNLPJL();
			return true;
		}
		return false;
	}

	public bool CHAGCELLLOJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OJPJMNJLLKM(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("OldMansDuelEvent OnTravelZoneTo"));
			return false;
		}
		return true;
	}

	private IEnumerator HALCFKLFLKG()
	{
		cuco.SetActive(true);
		yield return (object)new WaitForSeconds(3.2f);
		cuco.SetActive(false);
		ANMAFLKPILP = null;
	}

	public void COBJAAGGBAJ(int JIIGOACEIKL)
	{
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(DKMAAGAOKPC));
		}
	}

	private void PCEFNHADDIG()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(DKMAAGAOKPC));
		}
	}

	public bool LDFBGJOFCHB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void FGMNEKLCFNE(int PAGPMIANOHH, int JHHFKFKHHAG, bool HNMLKOAMFLJ, bool CDPAMNIPPEC)
	{
		hour = PAGPMIANOHH;
		minute = JHHFKFKHHAG;
		alarm = HNMLKOAMFLJ;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineClock.SendSetAlarm(PAGPMIANOHH, JHHFKFKHHAG, HNMLKOAMFLJ);
		}
	}

	public void LGCEJLOIKBK(int JIIGOACEIKL)
	{
	}

	public void EHPONEHFNAM(int PAGPMIANOHH, int JHHFKFKHHAG, bool HNMLKOAMFLJ, bool CDPAMNIPPEC)
	{
		hour = PAGPMIANOHH;
		minute = JHHFKFKHHAG;
		alarm = HNMLKOAMFLJ;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineClock.IKENOMPNGGO(PAGPMIANOHH, JHHFKFKHHAG, HNMLKOAMFLJ);
		}
	}

	public bool IALLCPMIGDP(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).GABNNLJOMHI();
	}

	private void OAKCEPEMEAP()
	{
		if (alarm && WorldTime.NOAOJJLNHJJ.hour == hour && WorldTime.CJOHMLNMJLK().min == minute && ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(HALCFKLFLKG());
		}
		if (WorldTime.CJOHMLNMJLK().hour > -5)
		{
			hourHand.sprite = hourSprite[WorldTime.CJOHMLNMJLK().hour - 3];
		}
		else
		{
			hourHand.sprite = hourSprite[WorldTime.HGIBNMBJMOC().hour];
		}
		COOJPKBJLFJ = WorldTime.NOAOJJLNHJJ.min / 8;
		if (COOJPKBJLFJ >= 1 && COOJPKBJLFJ < minuteSprite.Length)
		{
			minuteHand.sprite = minuteSprite[COOJPKBJLFJ];
		}
	}

	public void GKLIANGHJKM(int JIIGOACEIKL)
	{
	}

	public void BIKILBEOGAD(int JIIGOACEIKL)
	{
	}

	public bool GKCBFBDBNON(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private IEnumerator JGFJLODAPEA()
	{
		cuco.SetActive(true);
		yield return (object)new WaitForSeconds(3.2f);
		cuco.SetActive(false);
		ANMAFLKPILP = null;
	}

	public void GOIMNNEEDCI(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool DMFALJDJAMP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AEPCKAPLLJP(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("<b>"));
			return false;
		}
		return false;
	}

	private void DCKKIDMJKJM()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(NOFFJCJEPGM));
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool HLGPCDANKKK(int JIIGOACEIKL)
	{
		return DecorationMode.OCJGHINCLJM(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void FNOGBJNLJMF(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Use"));
			return true;
		}
		return false;
	}

	public bool JEHOCIKPEJD(int JIIGOACEIKL)
	{
		if (HLGPCDANKKK(JIIGOACEIKL))
		{
			AlarmClockUI.PNCKAKBBKJL(JIIGOACEIKL).relojCuco = this;
			AlarmClockUI.KLJCCHJHDGG(JIIGOACEIKL).IDLAGJNLPJL();
			return false;
		}
		return true;
	}

	public bool JPAEPFAIAON(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void SetAlarm(int PAGPMIANOHH, int JHHFKFKHHAG, bool HNMLKOAMFLJ, bool CDPAMNIPPEC)
	{
		hour = PAGPMIANOHH;
		minute = JHHFKFKHHAG;
		alarm = HNMLKOAMFLJ;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineClock.SendSetAlarm(PAGPMIANOHH, JHHFKFKHHAG, HNMLKOAMFLJ);
		}
	}

	public bool DOGBEDLPOMJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void DIFNFNJOPKP(int JIIGOACEIKL)
	{
	}

	public bool JONCEAPNGEC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Player2"));
			return true;
		}
		return false;
	}

	public bool LCABCHMEDOK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AEPCKAPLLJP(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Walking"));
			return true;
		}
		return false;
	}

	public void NLLENLLOBLH(int JIIGOACEIKL)
	{
	}

	public bool NMKPOMCPJPB(int JIIGOACEIKL)
	{
		return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool GDOPOFNFLEB(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			AlarmClockUI.Get(JIIGOACEIKL).relojCuco = this;
			AlarmClockUI.Get(JIIGOACEIKL).OpenUI();
			return true;
		}
		return false;
	}

	public void COMGONICNIN(int JIIGOACEIKL)
	{
	}

	public void FFFAMACMKLI(int JIIGOACEIKL)
	{
	}

	private IEnumerator MFNGIPBGBAN()
	{
		return new DMEOLDNHJEE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PLKFEPAHAEK(int JIIGOACEIKL)
	{
	}

	public bool AEPCKAPLLJP(int JIIGOACEIKL)
	{
		return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool DHGKDOGEJPF(int JIIGOACEIKL)
	{
		return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool OBHILJEDGFC(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool BDNKFLJNNEL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}
}
