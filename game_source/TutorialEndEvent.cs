using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialEndEvent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class CMJNICMJNBC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEndEvent _003C_003E4__this;

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
		public CMJNICMJNBC(int _003C_003E1__state)
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
			TutorialEndEvent tutorialEndEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				PlayerController.AddMovementBlocker((Object)(object)tutorialEndEvent);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				CatNPC cat = tutorialEndEvent.cat;
				cat.OnCatSitBed = (Action)Delegate.Combine(cat.OnCatSitBed, new Action(tutorialEndEvent.EGHJFJIIKGA));
				((Component)tutorialEndEvent.cat).gameObject.SetActive(true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
				return true;
			}
			case 2:
				_003C_003E1__state = -1;
				tutorialEndEvent.emoter.StartEmote(Emote.Exclamation);
				Sound.GGFJGHHHEJC.PlayOneShot(Sound.GGFJGHHHEJC.exclaim[0]);
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

	[SerializeField]
	private CatNPC cat;

	[SerializeField]
	private Emoter emoter;

	private bool MKIDIKJPEAH;

	private GameDate FMNHELOFOGJ = new GameDate(1, Season.Spring, 0, MiscSetup.demoEndDay, 5, 0);

	private void IDBBMECPKNN()
	{
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Remove(catNPC.OnCatSitBed, new Action(KBFBDBCCBLM));
		((MonoBehaviour)this).StartCoroutine(MHHLJBLOKCI());
	}

	private IEnumerator EHNAKINJOEP()
	{
		PlayerController.AddMovementBlocker((Object)(object)this);
		yield return CommonReferences.wait1;
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Combine(catNPC.OnCatSitBed, new Action(EGHJFJIIKGA));
		((Component)cat).gameObject.SetActive(true);
		yield return CommonReferences.wait1;
		emoter.StartEmote(Emote.Exclamation);
		Sound.GGFJGHHHEJC.PlayOneShot(Sound.GGFJGHHHEJC.exclaim[0]);
	}

	private IEnumerator CGMPNOFPBJC()
	{
		PlayerController.AddMovementBlocker((Object)(object)this);
		yield return CommonReferences.wait1;
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Combine(catNPC.OnCatSitBed, new Action(EGHJFJIIKGA));
		((Component)cat).gameObject.SetActive(true);
		yield return CommonReferences.wait1;
		emoter.StartEmote(Emote.Exclamation);
		Sound.GGFJGHHHEJC.PlayOneShot(Sound.GGFJGHHHEJC.exclaim[0]);
	}

	private IEnumerator CCDJEIIENNC()
	{
		PlayerController.AddMovementBlocker((Object)(object)this);
		yield return CommonReferences.wait1;
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Combine(catNPC.OnCatSitBed, new Action(EGHJFJIIKGA));
		((Component)cat).gameObject.SetActive(true);
		yield return CommonReferences.wait1;
		emoter.StartEmote(Emote.Exclamation);
		Sound.GGFJGHHHEJC.PlayOneShot(Sound.GGFJGHHHEJC.exclaim[0]);
	}

	private void CEIIFHIBIFI()
	{
		SaveUI instance = SaveUI.instance;
		instance.OnUIClose = (Action<int>)Delegate.Combine(instance.OnUIClose, new Action<int>(MFPJAEMPKDC));
	}

	private IEnumerator PGBBMEFKGDM()
	{
		return new CMJNICMJNBC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GKGJAHDDBBH()
	{
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Remove(catNPC.OnCatSitBed, new Action(KBFBDBCCBLM));
		((MonoBehaviour)this).StartCoroutine(OIBGOHDHBKM());
	}

	private void HDENMHBLNOK()
	{
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Remove(catNPC.OnCatSitBed, new Action(HIIBBNDMGGL));
		((MonoBehaviour)this).StartCoroutine(BHGJBIJFGBP());
	}

	private IEnumerator OIBGOHDHBKM()
	{
		emoter.StartEmote(Emote.Smile);
		yield return CommonReferences.waitRealtime4;
	}

	private void DMFBPPHFLFJ()
	{
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Remove(catNPC.OnCatSitBed, new Action(MDOMPKOGMLJ));
		((MonoBehaviour)this).StartCoroutine(OIBGOHDHBKM());
	}

	private void Start()
	{
		SaveUI instance = SaveUI.instance;
		instance.OnUIClose = (Action<int>)Delegate.Combine(instance.OnUIClose, new Action<int>(MFPJAEMPKDC));
	}

	private IEnumerator JJNBKJNEPEJ()
	{
		return new CMJNICMJNBC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HIIBBNDMGGL()
	{
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Remove(catNPC.OnCatSitBed, new Action(MDOMPKOGMLJ));
		((MonoBehaviour)this).StartCoroutine(OIBGOHDHBKM());
	}

	private void KBFBDBCCBLM()
	{
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Remove(catNPC.OnCatSitBed, new Action(MPMCHELHJKO));
		((MonoBehaviour)this).StartCoroutine(BHGJBIJFGBP());
	}

	private IEnumerator GGCKKMAEHGD()
	{
		PlayerController.AddMovementBlocker((Object)(object)this);
		yield return CommonReferences.wait1;
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Combine(catNPC.OnCatSitBed, new Action(EGHJFJIIKGA));
		((Component)cat).gameObject.SetActive(true);
		yield return CommonReferences.wait1;
		emoter.StartEmote(Emote.Exclamation);
		Sound.GGFJGHHHEJC.PlayOneShot(Sound.GGFJGHHHEJC.exclaim[0]);
	}

	private IEnumerator HGCBEJCDMFH()
	{
		PlayerController.AddMovementBlocker((Object)(object)this);
		yield return CommonReferences.wait1;
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Combine(catNPC.OnCatSitBed, new Action(EGHJFJIIKGA));
		((Component)cat).gameObject.SetActive(true);
		yield return CommonReferences.wait1;
		emoter.StartEmote(Emote.Exclamation);
		Sound.GGFJGHHHEJC.PlayOneShot(Sound.GGFJGHHHEJC.exclaim[0]);
	}

	private void MPMCHELHJKO()
	{
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Remove(catNPC.OnCatSitBed, new Action(MPMCHELHJKO));
		((MonoBehaviour)this).StartCoroutine(BHGJBIJFGBP());
	}

	private void KACEOJDPLKB()
	{
		SaveUI instance = SaveUI.instance;
		instance.OnUIClose = (Action<int>)Delegate.Combine(instance.OnUIClose, new Action<int>(EOAHBNFPMAO));
	}

	private void PKBHEKHOAAA()
	{
		SaveUI instance = SaveUI.instance;
		instance.OnUIClose = (Action<int>)Delegate.Combine(instance.OnUIClose, new Action<int>(EOAHBNFPMAO));
	}

	private void EOAHBNFPMAO(int JIIGOACEIKL)
	{
		if (!MKIDIKJPEAH && MiscSetup.isDemo && GameDate.OHGGMAGNIFH(WorldTime.HGIBNMBJMOC()) > GameDate.GPPGKONILOE(FMNHELOFOGJ))
		{
			MKIDIKJPEAH = true;
			SaveUI instance = SaveUI.instance;
			instance.OnUIClose = (Action<int>)Delegate.Remove(instance.OnUIClose, new Action<int>(NNFMKMEMOIN));
			((MonoBehaviour)this).StartCoroutine(CGMPNOFPBJC());
		}
	}

	private IEnumerator BHGJBIJFGBP()
	{
		emoter.StartEmote(Emote.Smile);
		yield return CommonReferences.waitRealtime4;
	}

	private void MDOMPKOGMLJ()
	{
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Remove(catNPC.OnCatSitBed, new Action(MPMCHELHJKO));
		((MonoBehaviour)this).StartCoroutine(OIBGOHDHBKM());
	}

	private IEnumerator GHGFKJOBPEA()
	{
		return new CMJNICMJNBC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EGHJFJIIKGA()
	{
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Remove(catNPC.OnCatSitBed, new Action(EGHJFJIIKGA));
		((MonoBehaviour)this).StartCoroutine(INNPJMKLBIL());
	}

	private void NNFMKMEMOIN(int JIIGOACEIKL)
	{
		if (!MKIDIKJPEAH && MiscSetup.isDemo && GameDate.GPPGKONILOE(WorldTime.HGIBNMBJMOC()) > GameDate.DAFIFHBDNDF(FMNHELOFOGJ))
		{
			MKIDIKJPEAH = false;
			SaveUI instance = SaveUI.instance;
			instance.OnUIClose = (Action<int>)Delegate.Remove(instance.OnUIClose, new Action<int>(AMLKFFHLMNO));
			((MonoBehaviour)this).StartCoroutine(CCDJEIIENNC());
		}
	}

	private void AMLKFFHLMNO(int JIIGOACEIKL)
	{
		if (!MKIDIKJPEAH && MiscSetup.isDemo && GameDate.GPPGKONILOE(WorldTime.HGIBNMBJMOC()) > GameDate.JNBDOMFDJEH(FMNHELOFOGJ))
		{
			MKIDIKJPEAH = true;
			SaveUI instance = SaveUI.instance;
			instance.OnUIClose = (Action<int>)Delegate.Remove(instance.OnUIClose, new Action<int>(AMLKFFHLMNO));
			((MonoBehaviour)this).StartCoroutine(HGCBEJCDMFH());
		}
	}

	private void KJOJLHCDFPP()
	{
		SaveUI instance = SaveUI.instance;
		instance.OnUIClose = (Action<int>)Delegate.Combine(instance.OnUIClose, new Action<int>(MFPJAEMPKDC));
	}

	private IEnumerator MHHLJBLOKCI()
	{
		emoter.StartEmote(Emote.Smile);
		yield return CommonReferences.waitRealtime4;
	}

	private void OLEJOBPOIBI()
	{
		CatNPC catNPC = cat;
		catNPC.OnCatSitBed = (Action)Delegate.Remove(catNPC.OnCatSitBed, new Action(EGHJFJIIKGA));
		((MonoBehaviour)this).StartCoroutine(IADMPBPLHEG());
	}

	private void MFPJAEMPKDC(int JIIGOACEIKL)
	{
		if (!MKIDIKJPEAH && MiscSetup.isDemo && GameDate.GGNGGLHBMNA(WorldTime.NOAOJJLNHJJ) > GameDate.GGNGGLHBMNA(FMNHELOFOGJ))
		{
			MKIDIKJPEAH = true;
			SaveUI instance = SaveUI.instance;
			instance.OnUIClose = (Action<int>)Delegate.Remove(instance.OnUIClose, new Action<int>(MFPJAEMPKDC));
			((MonoBehaviour)this).StartCoroutine(GGCKKMAEHGD());
		}
	}

	private IEnumerator INNPJMKLBIL()
	{
		emoter.StartEmote(Emote.Smile);
		yield return CommonReferences.waitRealtime4;
	}

	private IEnumerator IADMPBPLHEG()
	{
		emoter.StartEmote(Emote.Smile);
		yield return CommonReferences.waitRealtime4;
	}
}
