using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OnlyBarkNPC : MonoBehaviour, IProximity, IHoverable
{
	[CompilerGenerated]
	private sealed class MFCJEMPPDNI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnlyBarkNPC _003C_003E4__this;

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
		public MFCJEMPPDNI(int _003C_003E1__state)
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
			OnlyBarkNPC onlyBarkNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait03;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				onlyBarkNPC.inDialogue = false;
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

	[HideInInspector]
	public bool inDialogue;

	public void PGOIMGKKPAP(int JIIGOACEIKL)
	{
	}

	public virtual void FBIPEGDJHIL()
	{
	}

	public bool KPFKKDMOGGB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && NBHLBCHHKBC(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ReceiveCollectItems"));
			return false;
		}
		return true;
	}

	public void OGJIHMFODNC(int JIIGOACEIKL)
	{
	}

	public void FFFAMACMKLI(int JIIGOACEIKL)
	{
	}

	public bool NBHLBCHHKBC(int JIIGOACEIKL)
	{
		return DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public void CCGMBIPHNKK(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void GHJNDIDNJKA(int JIIGOACEIKL)
	{
	}

	public void HOPNBDKPJJI(int JIIGOACEIKL)
	{
	}

	private IEnumerator NDLLBPMOKFN()
	{
		yield return CommonReferences.wait03;
		inDialogue = false;
	}

	public virtual void MKEPGHFNLFD()
	{
	}

	public void FHEGMGFAIPM(int JIIGOACEIKL)
	{
	}

	public bool ONMFMJGODIM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("itemFermentationTank"));
			return false;
		}
		return true;
	}

	public bool MNDDOAAODLI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void COBJAAGGBAJ(int JIIGOACEIKL)
	{
	}

	public void HDLGAPIAEPP(int JIIGOACEIKL)
	{
	}

	public void IMFDDHFICNF(int JIIGOACEIKL)
	{
	}

	private void DOEOKPBFMJE(Transform actor)
	{
		inDialogue = true;
		ButtonsContext.GetPlayer(CommonReferences.GGFJGHHHEJC.playerDialogue).ResetButtons();
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Talk"));
			return true;
		}
		return false;
	}

	public bool CFGOGPBMEKL(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).MDOKKKHKKKE();
	}

	private void PJMBDEECHGA(Transform actor)
	{
		inDialogue = false;
		ButtonsContext.GetPlayer(CommonReferences.MNFMOEKMJKN().playerDialogue).DKCMJENPPFA();
	}

	public virtual void KIJDJDHOOJD()
	{
	}

	private void LGNABHHEMHG(Transform actor)
	{
		inDialogue = true;
		ButtonsContext.GetPlayer(CommonReferences.MNFMOEKMJKN().playerDialogue).ResetButtons();
	}

	public bool FKGGJMDADLA(int JIIGOACEIKL)
	{
		return DecorationMode.OCJGHINCLJM(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool DEEFMMKDBJB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && BHMMBNIFKHD(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Dialogue System/Conversation/TooHot/Entry/5/Dialogue Text"));
			return true;
		}
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool EEPBLLACPCG(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool NKJBDLANNIF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("hour"));
			return false;
		}
		return true;
	}

	public void KOANHOFAJMA(int JIIGOACEIKL)
	{
	}

	public void MHACBHAENBB(int JIIGOACEIKL)
	{
	}

	private IEnumerator OPNMGAJJAHJ()
	{
		yield return CommonReferences.wait03;
		inDialogue = false;
	}

	public virtual void BCAJMNDOKII()
	{
	}

	private void MHMEICKBLND(Transform actor)
	{
		((MonoBehaviour)this).StartCoroutine(NDLLBPMOKFN());
	}

	public virtual void MBPMDBMENHM()
	{
	}

	public bool BHMMBNIFKHD(int JIIGOACEIKL)
	{
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public void IHIIIPGGPPF(int JIIGOACEIKL)
	{
	}

	public bool CHAGCELLLOJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && FCEPPMAEAJA(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Player2"));
			return false;
		}
		return false;
	}

	public bool DOFBPGOCNEN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && JMPMCJDDKGD(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_name_"));
			return true;
		}
		return true;
	}

	public void CIBAGJHJDDF(int JIIGOACEIKL)
	{
	}

	private void LJMOIIAOBLE(Transform actor)
	{
		((MonoBehaviour)this).StartCoroutine(OPNMGAJJAHJ());
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private IEnumerator JKPBOHAHANA()
	{
		yield return CommonReferences.wait03;
		inDialogue = false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool FCEPPMAEAJA(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IBEFDKHFBFM();
	}

	private void AGEKLNAKNLK(Transform actor)
	{
		((MonoBehaviour)this).StartCoroutine(JKPBOHAHANA());
	}

	private void ICIHCCIBKDP(Transform actor)
	{
		inDialogue = true;
		ButtonsContext.GetPlayer(CommonReferences.MNFMOEKMJKN().playerDialogue).ResetButtons();
	}

	public void NEBIAJNDDOC(int JIIGOACEIKL)
	{
	}

	public bool CNCFMOJHNID(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && NBHLBCHHKBC(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Smell"));
			return false;
		}
		return false;
	}

	public bool BCGBODLPDEB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && GDOPOFNFLEB(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("RentingRooms"));
			return true;
		}
		return false;
	}

	public void EPADOBKDNKG(int JIIGOACEIKL)
	{
	}

	public void GJKMPLHIDFC(int JIIGOACEIKL)
	{
	}

	public bool KBLEJDFHIHJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && CFGOGPBMEKL(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Disabled"));
			return true;
		}
		return true;
	}

	private void LBOAEIOHIKH(Transform actor)
	{
		((MonoBehaviour)this).StartCoroutine(NDLLBPMOKFN());
	}

	public void GDDBCDEMHNH(int JIIGOACEIKL)
	{
	}

	public bool NOEEFMEKOMN(int JIIGOACEIKL)
	{
		return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool HPBOMGJLECN(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void BPEBGBHCCEN(int JIIGOACEIKL)
	{
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void ANPNIBGMKJE(int JIIGOACEIKL)
	{
	}

	public bool JMPMCJDDKGD(int JIIGOACEIKL)
	{
		return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool LDFBGJOFCHB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool GKJKEDDHMCO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool BEBIPNCCEMH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && FKGGJMDADLA(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("P1Cam"));
			return true;
		}
		return false;
	}

	public bool EOBECMHBLCK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && EEPBLLACPCG(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Last"));
			return true;
		}
		return true;
	}

	public void HGLIICHGPHH(int JIIGOACEIKL)
	{
	}

	public virtual void EBAPBAJHIIO()
	{
	}

	public bool KIJAKAGEMJN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("itemPaperCoaster"));
			return false;
		}
		return true;
	}

	public void DFFCCILMAHN(int JIIGOACEIKL)
	{
	}

	private void JHBMEGFPDPK(Transform actor)
	{
		((MonoBehaviour)this).StartCoroutine(ELCFKJJIKHA());
	}

	public void CJGDFDJMAAA(int JIIGOACEIKL)
	{
	}

	private IEnumerator CELALGHDNCE()
	{
		return new MFCJEMPPDNI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KMAPBDCGIDK(int JIIGOACEIKL)
	{
	}

	public void MMDJIDCALJB(int JIIGOACEIKL)
	{
	}

	public void PGMHNADJMMH(int JIIGOACEIKL)
	{
	}

	public bool KNGDGMPGEBH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void IOGBHDBMIAD(Transform actor)
	{
		inDialogue = true;
		ButtonsContext.GetPlayer(CommonReferences.MNFMOEKMJKN().playerDialogue).ResetButtons();
	}

	private void OnBarkStart(Transform actor)
	{
		inDialogue = true;
		ButtonsContext.GetPlayer(CommonReferences.GGFJGHHHEJC.playerDialogue).ResetButtons();
	}

	private IEnumerator CFIOAOJMPCL()
	{
		return new MFCJEMPPDNI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CMGOGMJOOLK(Transform actor)
	{
		inDialogue = false;
		ButtonsContext.GetPlayer(CommonReferences.MNFMOEKMJKN().playerDialogue).DKCMJENPPFA();
	}

	private void CNPACPADPKM(Transform actor)
	{
		inDialogue = true;
		ButtonsContext.GetPlayer(CommonReferences.GGFJGHHHEJC.playerDialogue).DKCMJENPPFA();
	}

	private void EOPFKHFJMPD(Transform actor)
	{
		((MonoBehaviour)this).StartCoroutine(BHLKKLMKCDL());
	}

	public void LAEDMIPNGPJ(int JIIGOACEIKL)
	{
	}

	public void JKMLKBPAHHO(int JIIGOACEIKL)
	{
	}

	private IEnumerator BHLKKLMKCDL()
	{
		yield return CommonReferences.wait03;
		inDialogue = false;
	}

	public void KAEJBPBKDGI(int JIIGOACEIKL)
	{
	}

	private void OnBarkEnd(Transform actor)
	{
		((MonoBehaviour)this).StartCoroutine(NDLLBPMOKFN());
	}

	public virtual void RandomBark()
	{
	}

	public bool GDOPOFNFLEB(int JIIGOACEIKL)
	{
		return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).GABNNLJOMHI();
	}

	private IEnumerator ELCFKJJIKHA()
	{
		return new MFCJEMPPDNI(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool OIICHHNIBMC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void FCMABHCNJMM(Transform actor)
	{
		inDialogue = true;
		ButtonsContext.GetPlayer(CommonReferences.GGFJGHHHEJC.playerDialogue).ResetButtons();
	}

	public bool CODLFHDKMHC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!inDialogue && FKGGJMDADLA(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Community_Translation"));
			return false;
		}
		return false;
	}
}
