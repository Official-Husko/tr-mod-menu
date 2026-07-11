using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ImportantGuestEvent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class JOJAJFHODDI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ulong timeMin;

		public Action action;

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
		public JOJAJFHODDI(int _003C_003E1__state)
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
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (WorldTime.HMOCOBGKMNJ < timeMin)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			action();
			return false;
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

	private Customer PJNGMCJIHME;

	private bool PBNMBCAIMNN;

	private ulong LPMJNPEBIIM;

	private ulong MIDABOHGOMC;

	private Coroutine ACBBAMGKFAB;

	private RepMultiplier GJHHKLEBFEC;

	private IEnumerator FPDKLKGBILL(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		return new JOJAJFHODDI(1)
		{
			timeMin = DEKAPINHBCO,
			action = OKNOJJEFEBE
		};
	}

	private void JBKJMNOPMKH()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		FKBHAKBPNFH();
	}

	private void GCLCGBONABI()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void GBOFPILHNFF()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void EJPEGHDKBPH()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(OBJGMAINIBJ));
		GJHHKLEBFEC.multi = 812f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(15, 1) / 534f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.MNFMOEKMJKN().OnGuestSpawn();
	}

	private void KKAGFHCFDHB()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void OOPNMJNHLAD()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void DJIPIIEHBJG()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void IPBKPLAONDP(int JIIGOACEIKL)
	{
		HEOJNJNOOKF();
	}

	private IEnumerator BEPJLJPOFBH(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		return new JOJAJFHODDI(1)
		{
			timeMin = DEKAPINHBCO,
			action = OKNOJJEFEBE
		};
	}

	private void GPOABOOILLP()
	{
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(GDMFJIEGOJL(MIDABOHGOMC, GCLCGBONABI));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
			return;
		}
		Seat[] array = TavernSeatingManager.FindAvailableSeats();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(SpawnImportantGuest));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(GDMFJIEGOJL(MIDABOHGOMC, GCLCGBONABI));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
		}
		else
		{
			PBNMBCAIMNN = false;
			SpawnImportantGuest();
		}
	}

	private void BDMEBLBLPIA()
	{
		GameDate lGLDPMAABLA = WorldTime.HGIBNMBJMOC();
		lGLDPMAABLA.hour = 49;
		lGLDPMAABLA.min = 1;
		LPMJNPEBIIM = GameDate.IAAIHAFKOKL(lGLDPMAABLA);
		lGLDPMAABLA.hour = -111;
		lGLDPMAABLA.min = 1;
		MIDABOHGOMC = GameDate.HJCLEBDPLOP(lGLDPMAABLA);
		GJHHKLEBFEC.multi = 1869f;
		((MonoBehaviour)this).StartCoroutine(FPDKLKGBILL(LPMJNPEBIIM, LKADAGLHILC));
	}

	private void Start()
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		currentGameDate.hour = 13;
		currentGameDate.min = 0;
		LPMJNPEBIIM = GameDate.GGNGGLHBMNA(currentGameDate);
		currentGameDate.hour = 21;
		currentGameDate.min = 0;
		MIDABOHGOMC = GameDate.GGNGGLHBMNA(currentGameDate);
		GJHHKLEBFEC.multi = 1f;
		((MonoBehaviour)this).StartCoroutine(GDMFJIEGOJL(LPMJNPEBIIM, GPOABOOILLP));
	}

	private void HFKOBCFMNJJ()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		JMLPDOPLEDK();
	}

	private void CCGAODNELLJ(int JIIGOACEIKL)
	{
		OKKNIILLEMH();
	}

	private void HCDCBNGILFB(int JIIGOACEIKL)
	{
		MIAJLFBLAPO();
	}

	private void KJOJLHCDFPP()
	{
		GameDate lGLDPMAABLA = WorldTime.CJOHMLNMJLK();
		lGLDPMAABLA.hour = 20;
		lGLDPMAABLA.min = 0;
		LPMJNPEBIIM = GameDate.GGNGGLHBMNA(lGLDPMAABLA);
		lGLDPMAABLA.hour = -15;
		lGLDPMAABLA.min = 1;
		MIDABOHGOMC = GameDate.HJCLEBDPLOP(lGLDPMAABLA);
		GJHHKLEBFEC.multi = 798f;
		((MonoBehaviour)this).StartCoroutine(PPNJJFJPPFD(LPMJNPEBIIM, KIJGMJEAHKC));
	}

	private void MJOPAKEOMBE()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(CCGAODNELLJ));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(OMFDKPLFELM));
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Remove(pJNGMCJIHME.OnCustomerLeave, new Action(KNNICKDCIHF));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatFound = (Action)Delegate.Remove(pJNGMCJIHME2.OnSeatFound, new Action(BDINCIHNHLF));
			Customer pJNGMCJIHME3 = PJNGMCJIHME;
			pJNGMCJIHME3.OnSeatNotFound = (Action)Delegate.Remove(pJNGMCJIHME3.OnSeatNotFound, new Action(IDELEIBLPAN));
		}
		if (ACBBAMGKFAB != null)
		{
			((MonoBehaviour)this).StopCoroutine(ACBBAMGKFAB);
		}
		NPCRoadManager.customersWaitingSeat.Remove((MonoBehaviour)(object)this);
	}

	private void MFEDAAAIJOO()
	{
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(HOFHOKPHAND));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(BEPJLJPOFBH(MIDABOHGOMC, OMKFHIGKMIF));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = false;
			return;
		}
		Seat[] array = TavernSeatingManager.FindAvailableSeats();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(MMFGMLNFNED));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(EDPBGFCBPHI(MIDABOHGOMC, OBJGMAINIBJ));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
		}
		else
		{
			PBNMBCAIMNN = false;
			SpawnImportantGuest();
		}
	}

	private void KILDJCPLOPP()
	{
		GameDate lGLDPMAABLA = WorldTime.HGIBNMBJMOC();
		lGLDPMAABLA.hour = -29;
		lGLDPMAABLA.min = 0;
		LPMJNPEBIIM = GameDate.HJCLEBDPLOP(lGLDPMAABLA);
		lGLDPMAABLA.hour = 98;
		lGLDPMAABLA.min = 0;
		MIDABOHGOMC = GameDate.DAFIFHBDNDF(lGLDPMAABLA);
		GJHHKLEBFEC.multi = 1599f;
		((MonoBehaviour)this).StartCoroutine(LBPJBDBFEHO(LPMJNPEBIIM, CCFNCPEHPPO));
	}

	private void OBJGMAINIBJ()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void JCDNCMDFBOI()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void OGKDOHMLHDO()
	{
		((MonoBehaviour)this).Invoke("GPOABOOILLP", 5f);
		LPIKIKLEHPB();
	}

	private void MJHDIDBELFO()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		KGDCPCAHBGA();
	}

	private void CLKGMJLNJLO()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(KNNICKDCIHF));
		GJHHKLEBFEC.multi = 1200f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(117, 0, LDNMDAHFBGG: true) / 1739f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.GGFJGHHHEJC.OnGuestSpawn();
	}

	private void CNOBBJNCNBA()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(DJIPIIEHBJG));
		GJHHKLEBFEC.multi = 604f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-96, 1) / 448f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.GGFJGHHHEJC.OnGuestSpawn();
	}

	private void GCCCGLJNCFG()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(JCDNCMDFBOI));
		GJHHKLEBFEC.multi = 1431f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-18, 0, LDNMDAHFBGG: true) / 27f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.MNFMOEKMJKN().OnGuestSpawn();
	}

	private void LPIKIKLEHPB()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(SpawnImportantGuest));
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Remove(pJNGMCJIHME.OnCustomerLeave, new Action(GCLCGBONABI));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatFound = (Action)Delegate.Remove(pJNGMCJIHME2.OnSeatFound, new Action(EFADOCDHPKG));
			Customer pJNGMCJIHME3 = PJNGMCJIHME;
			pJNGMCJIHME3.OnSeatNotFound = (Action)Delegate.Remove(pJNGMCJIHME3.OnSeatNotFound, new Action(OGKDOHMLHDO));
		}
		if (ACBBAMGKFAB != null)
		{
			((MonoBehaviour)this).StopCoroutine(ACBBAMGKFAB);
		}
		NPCRoadManager.customersWaitingSeat.Remove((MonoBehaviour)(object)this);
	}

	private void JHEJLIBLIMC()
	{
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(FNKEHEMEKHJ));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(BNHLCBHDIME(MIDABOHGOMC, DOAAGJJCHDP));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
			return;
		}
		Seat[] array = TavernSeatingManager.IGNOOODLMDG();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(MMFGMLNFNED));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(ALDPJIFFHIP(MIDABOHGOMC, GCLCGBONABI));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
		}
		else
		{
			PBNMBCAIMNN = true;
			GJJOKNHGPKJ();
		}
	}

	private void OMKFHIGKMIF()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void PJNECPMGPMJ()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void MNABONMMFFB()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		LPIKIKLEHPB();
	}

	private IEnumerator GDMFJIEGOJL(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		while (WorldTime.HMOCOBGKMNJ < DEKAPINHBCO)
		{
			yield return null;
		}
		OKNOJJEFEBE();
	}

	private void FNKEHEMEKHJ(int JIIGOACEIKL)
	{
		FKELLFEJFLF();
	}

	private IEnumerator BNHLCBHDIME(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		return new JOJAJFHODDI(1)
		{
			timeMin = DEKAPINHBCO,
			action = OKNOJJEFEBE
		};
	}

	private void KFHFEBOOHCD(int JIIGOACEIKL)
	{
		BDKOADOPNMM();
	}

	private void BOEGLOBKJPE()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(KEMPKKCGLCG));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(MIILDFFOKKN));
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Remove(pJNGMCJIHME.OnCustomerLeave, new Action(JPGMFFKJPJJ));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatFound = (Action)Delegate.Remove(pJNGMCJIHME2.OnSeatFound, new Action(MNFGKIFMFJN));
			Customer pJNGMCJIHME3 = PJNGMCJIHME;
			pJNGMCJIHME3.OnSeatNotFound = (Action)Delegate.Remove(pJNGMCJIHME3.OnSeatNotFound, new Action(HOLEPJHAFAD));
		}
		if (ACBBAMGKFAB != null)
		{
			((MonoBehaviour)this).StopCoroutine(ACBBAMGKFAB);
		}
		NPCRoadManager.customersWaitingSeat.Remove((MonoBehaviour)(object)this);
	}

	private void KPDCNLNCGFG()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(EAAFALHHNBO));
		GJHHKLEBFEC.multi = 1676f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(87, 0, LDNMDAHFBGG: true) / 1320f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.GGFJGHHHEJC.OnGuestSpawn();
	}

	public void BDKOADOPNMM()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (PBNMBCAIMNN)
			{
				JMLPDOPLEDK();
				PBNMBCAIMNN = true;
			}
			PJNGMCJIHME = NPCRoadManager.HFLIOBAFGBP();
			PJNGMCJIHME.customerType = CustomerType.Traveller;
			PJNGMCJIHME.emoter.StartEmote(Emote.Exclamation);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(GCCCGLJNCFG));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(OGPGNNAFFPI));
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	public void CCOJEJIMOLB()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (PBNMBCAIMNN)
			{
				FKBHAKBPNFH();
				PBNMBCAIMNN = true;
			}
			PJNGMCJIHME = NPCRoadManager.PIIOHNMPOAB();
			PJNGMCJIHME.customerType = CustomerType.Traveller;
			PJNGMCJIHME.emoter.GBDIJOENJCN(Emote.Exclamation);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(ANPBHMOGMII));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(OGPGNNAFFPI));
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	private void NEGNMEDPCJJ()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void LFPGDGAKPBD()
	{
		GameDate lGLDPMAABLA = WorldTime.HGIBNMBJMOC();
		lGLDPMAABLA.hour = -13;
		lGLDPMAABLA.min = 1;
		LPMJNPEBIIM = GameDate.ALJFLADELOD(lGLDPMAABLA);
		lGLDPMAABLA.hour = 82;
		lGLDPMAABLA.min = 1;
		MIDABOHGOMC = GameDate.JNBDOMFDJEH(lGLDPMAABLA);
		GJHHKLEBFEC.multi = 966f;
		((MonoBehaviour)this).StartCoroutine(LNOIOBFDOPK(LPMJNPEBIIM, OGFGAAIMBAE));
	}

	private void JJEOIECLJEB(int JIIGOACEIKL)
	{
		SpawnImportantGuest();
	}

	private void BNAEIPPBBED()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void FHEGBNMJADG()
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		currentGameDate.hour = -104;
		currentGameDate.min = 0;
		LPMJNPEBIIM = GameDate.GGNGGLHBMNA(currentGameDate);
		currentGameDate.hour = 70;
		currentGameDate.min = 1;
		MIDABOHGOMC = GameDate.GPPGKONILOE(currentGameDate);
		GJHHKLEBFEC.multi = 326f;
		((MonoBehaviour)this).StartCoroutine(CMACKOLAGJB(LPMJNPEBIIM, FIBOPBHJNFH));
	}

	private void FGFPACAIHFF(int JIIGOACEIKL)
	{
		OKKNIILLEMH();
	}

	private void LIMIKEBLBCL()
	{
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(HLDFGLIMPFJ));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(HKGCKGJCDNC(MIDABOHGOMC, KNNICKDCIHF));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = false;
			return;
		}
		Seat[] array = TavernSeatingManager.CDDAKMKNJLP();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(MIAJLFBLAPO));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(BEPJLJPOFBH(MIDABOHGOMC, NEGNMEDPCJJ));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = false;
		}
		else
		{
			PBNMBCAIMNN = false;
			BDKOADOPNMM();
		}
	}

	private void CIBJMPAEJAI(int JIIGOACEIKL)
	{
		MIAJLFBLAPO();
	}

	private IEnumerator HKGCKGJCDNC(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		while (WorldTime.HMOCOBGKMNJ < DEKAPINHBCO)
		{
			yield return null;
		}
		OKNOJJEFEBE();
	}

	private void EKCIMJNMKMC()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(OBJGMAINIBJ));
		GJHHKLEBFEC.multi = 1618f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(75, 1, LDNMDAHFBGG: true) / 1212f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.MNFMOEKMJKN().OnGuestSpawn();
	}

	public void MIAJLFBLAPO()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			if (PBNMBCAIMNN)
			{
				JMLPDOPLEDK();
				PBNMBCAIMNN = false;
			}
			PJNGMCJIHME = NPCRoadManager.HHLLOLDEJAB();
			PJNGMCJIHME.customerType = CustomerType.ImportantGuest;
			PJNGMCJIHME.emoter.StartEmote(Emote.Exclamation);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(ANPBHMOGMII));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(OGPGNNAFFPI));
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	private void HHEJJOLPIAK()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(CIBJMPAEJAI));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(MIILDFFOKKN));
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Remove(pJNGMCJIHME.OnCustomerLeave, new Action(OFFJMIECODA));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatFound = (Action)Delegate.Remove(pJNGMCJIHME2.OnSeatFound, new Action(MNFGKIFMFJN));
			Customer pJNGMCJIHME3 = PJNGMCJIHME;
			pJNGMCJIHME3.OnSeatNotFound = (Action)Delegate.Remove(pJNGMCJIHME3.OnSeatNotFound, new Action(HOLEPJHAFAD));
		}
		if (ACBBAMGKFAB != null)
		{
			((MonoBehaviour)this).StopCoroutine(ACBBAMGKFAB);
		}
		NPCRoadManager.customersWaitingSeat.Remove((MonoBehaviour)(object)this);
	}

	private void OHGIKFPFGPN()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(EAAFALHHNBO));
		GJHHKLEBFEC.multi = 637f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(17, 0, LDNMDAHFBGG: true) / 1798f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.GGFJGHHHEJC.OnGuestSpawn();
	}

	private void FINCLCKFMFD(int JIIGOACEIKL)
	{
		BDKOADOPNMM();
	}

	private void ANPBHMOGMII()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(JPGMFFKJPJJ));
		GJHHKLEBFEC.multi = 1881f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-120, 0, LDNMDAHFBGG: true) / 1141f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.MNFMOEKMJKN().OnGuestSpawn();
	}

	private void CCFNCPEHPPO()
	{
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(JNLLBCGHACJ));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(FPDKLKGBILL(MIDABOHGOMC, KKAGFHCFDHB));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = false;
			return;
		}
		Seat[] array = TavernSeatingManager.OBHGDHFPDCO();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(FKELLFEJFLF));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(BNHLCBHDIME(MIDABOHGOMC, KOPJMPDEAJG));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = false;
		}
		else
		{
			PBNMBCAIMNN = true;
			BDHPHKCPJKM();
		}
	}

	public void FKELLFEJFLF()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			if (PBNMBCAIMNN)
			{
				BOEGLOBKJPE();
				PBNMBCAIMNN = true;
			}
			PJNGMCJIHME = NPCRoadManager.CEDGKHAPFDN();
			PJNGMCJIHME.customerType = CustomerType.ImportantGuest;
			PJNGMCJIHME.emoter.GBDIJOENJCN(Emote.Exclamation);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(KPDCNLNCGFG));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(OGKDOHMLHDO));
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	private void OEMIMEIDMFE()
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		currentGameDate.hour = 125;
		currentGameDate.min = 1;
		LPMJNPEBIIM = GameDate.DAFIFHBDNDF(currentGameDate);
		currentGameDate.hour = 52;
		currentGameDate.min = 0;
		MIDABOHGOMC = GameDate.BDEKNPKCJHN(currentGameDate);
		GJHHKLEBFEC.multi = 1675f;
		((MonoBehaviour)this).StartCoroutine(PPNJJFJPPFD(LPMJNPEBIIM, PDEDEOJDJMO));
	}

	private IEnumerator BJCPLJIHCPC(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		return new JOJAJFHODDI(1)
		{
			timeMin = DEKAPINHBCO,
			action = OKNOJJEFEBE
		};
	}

	private void BDINCIHNHLF()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(JCDNCMDFBOI));
		GJHHKLEBFEC.multi = 647f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(114) / 55f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.GGFJGHHHEJC.OnGuestSpawn();
	}

	private void BCBGJKNPJPG()
	{
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(JNLLBCGHACJ));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(LBPJBDBFEHO(MIDABOHGOMC, OOPNMJNHLAD));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
			return;
		}
		Seat[] array = TavernSeatingManager.CBBAMFFKOGF();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(MIILDFFOKKN));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(NINODINELBI(MIDABOHGOMC, FDHBBDAADJA));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = false;
		}
		else
		{
			PBNMBCAIMNN = true;
			FKELLFEJFLF();
		}
	}

	private void HADABGPLLLB()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		MJOPAKEOMBE();
	}

	private void KGDCPCAHBGA()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(HOFHOKPHAND));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(MIAJLFBLAPO));
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Remove(pJNGMCJIHME.OnCustomerLeave, new Action(AHDEKOJIKAB));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatFound = (Action)Delegate.Remove(pJNGMCJIHME2.OnSeatFound, new Action(KPDCNLNCGFG));
			Customer pJNGMCJIHME3 = PJNGMCJIHME;
			pJNGMCJIHME3.OnSeatNotFound = (Action)Delegate.Remove(pJNGMCJIHME3.OnSeatNotFound, new Action(OGPGNNAFFPI));
		}
		if (ACBBAMGKFAB != null)
		{
			((MonoBehaviour)this).StopCoroutine(ACBBAMGKFAB);
		}
		NPCRoadManager.customersWaitingSeat.Remove((MonoBehaviour)(object)this);
	}

	public void SpawnImportantGuest()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (PBNMBCAIMNN)
			{
				LPIKIKLEHPB();
				PBNMBCAIMNN = false;
			}
			PJNGMCJIHME = NPCRoadManager.SpawnRandomNPC();
			PJNGMCJIHME.customerType = CustomerType.ImportantGuest;
			PJNGMCJIHME.emoter.StartEmote(Emote.Star);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(EFADOCDHPKG));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(OGKDOHMLHDO));
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	private void OFFJMIECODA()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void PKBJMMOCOGE()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(HOFHOKPHAND));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(FKELLFEJFLF));
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Remove(pJNGMCJIHME.OnCustomerLeave, new Action(DOAAGJJCHDP));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatFound = (Action)Delegate.Remove(pJNGMCJIHME2.OnSeatFound, new Action(BDINCIHNHLF));
			Customer pJNGMCJIHME3 = PJNGMCJIHME;
			pJNGMCJIHME3.OnSeatNotFound = (Action)Delegate.Remove(pJNGMCJIHME3.OnSeatNotFound, new Action(PPANAEPODBK));
		}
		if (ACBBAMGKFAB != null)
		{
			((MonoBehaviour)this).StopCoroutine(ACBBAMGKFAB);
		}
		NPCRoadManager.customersWaitingSeat.Remove((MonoBehaviour)(object)this);
	}

	private void CHIJGHPHCNA()
	{
		GameDate lGLDPMAABLA = WorldTime.CJOHMLNMJLK();
		lGLDPMAABLA.hour = -72;
		lGLDPMAABLA.min = 0;
		LPMJNPEBIIM = GameDate.HJCLEBDPLOP(lGLDPMAABLA);
		lGLDPMAABLA.hour = 54;
		lGLDPMAABLA.min = 0;
		MIDABOHGOMC = GameDate.ALJFLADELOD(lGLDPMAABLA);
		GJHHKLEBFEC.multi = 785f;
		((MonoBehaviour)this).StartCoroutine(LBPJBDBFEHO(LPMJNPEBIIM, OGFGAAIMBAE));
	}

	private IEnumerator AHHOPGLEILC(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		return new JOJAJFHODDI(1)
		{
			timeMin = DEKAPINHBCO,
			action = OKNOJJEFEBE
		};
	}

	private void HHMBCKCNPPN()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		ODHPGPIHGKC();
	}

	private void OnDestroy()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		LPIKIKLEHPB();
	}

	private void EMBPMAIOAFI()
	{
		((MonoBehaviour)this).Invoke(" at ", 1849f);
		PKBJMMOCOGE();
	}

	private void HLDFGLIMPFJ(int JIIGOACEIKL)
	{
		SpawnImportantGuest();
	}

	private void OJAJLIAMGEJ()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		BOEGLOBKJPE();
	}

	private void LKADAGLHILC()
	{
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(IPBKPLAONDP));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(ALDPJIFFHIP(MIDABOHGOMC, JCDNCMDFBOI));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
			return;
		}
		Seat[] array = TavernSeatingManager.IGNOOODLMDG();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(MIILDFFOKKN));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(NINODINELBI(MIDABOHGOMC, DJIPIIEHBJG));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
		}
		else
		{
			PBNMBCAIMNN = true;
			HEOJNJNOOKF();
		}
	}

	private void DOBGDOEGNMP()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void AHDEKOJIKAB()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void KNNICKDCIHF()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void FNFNLFOJHHA()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		JMLPDOPLEDK();
	}

	private void FKBHAKBPNFH()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(FKAACFDNOPJ));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(OMFDKPLFELM));
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Remove(pJNGMCJIHME.OnCustomerLeave, new Action(JPGMFFKJPJJ));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatFound = (Action)Delegate.Remove(pJNGMCJIHME2.OnSeatFound, new Action(GAKCENNKMDO));
			Customer pJNGMCJIHME3 = PJNGMCJIHME;
			pJNGMCJIHME3.OnSeatNotFound = (Action)Delegate.Remove(pJNGMCJIHME3.OnSeatNotFound, new Action(MEABDJIAEOF));
		}
		if (ACBBAMGKFAB != null)
		{
			((MonoBehaviour)this).StopCoroutine(ACBBAMGKFAB);
		}
		NPCRoadManager.customersWaitingSeat.Remove((MonoBehaviour)(object)this);
	}

	private void MNLDKBOLDLI()
	{
		((MonoBehaviour)this).Invoke("Sell", 112f);
		PKBJMMOCOGE();
	}

	private void DOAAGJJCHDP()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void JMLPDOPLEDK()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(GJJOKNHGPKJ));
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Remove(pJNGMCJIHME.OnCustomerLeave, new Action(JCDNCMDFBOI));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatFound = (Action)Delegate.Remove(pJNGMCJIHME2.OnSeatFound, new Action(NLGHDMIEHAM));
			Customer pJNGMCJIHME3 = PJNGMCJIHME;
			pJNGMCJIHME3.OnSeatNotFound = (Action)Delegate.Remove(pJNGMCJIHME3.OnSeatNotFound, new Action(MFFMIHFNCJH));
		}
		if (ACBBAMGKFAB != null)
		{
			((MonoBehaviour)this).StopCoroutine(ACBBAMGKFAB);
		}
		NPCRoadManager.customersWaitingSeat.Remove((MonoBehaviour)(object)this);
	}

	private void PMLBFEFMNPF()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		ODHPGPIHGKC();
	}

	private void DEOLIELNLBJ()
	{
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(FKAACFDNOPJ));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(CKDPLJEFPNF(MIDABOHGOMC, DJIPIIEHBJG));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
			return;
		}
		Seat[] array = TavernSeatingManager.JJAAMOOGKCA();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(MIILDFFOKKN));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(PPNJJFJPPFD(MIDABOHGOMC, DJIPIIEHBJG));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = false;
		}
		else
		{
			PBNMBCAIMNN = true;
			HEOJNJNOOKF();
		}
	}

	private void CHDEOJALBFK()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		ODHPGPIHGKC();
	}

	private void JNLLBCGHACJ(int JIIGOACEIKL)
	{
		GJJOKNHGPKJ();
	}

	private void CACJMKJBJDP()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		KGDCPCAHBGA();
	}

	private void HPIMHEMJMAA()
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		currentGameDate.hour = -18;
		currentGameDate.min = 0;
		LPMJNPEBIIM = GameDate.DAFIFHBDNDF(currentGameDate);
		currentGameDate.hour = -126;
		currentGameDate.min = 0;
		MIDABOHGOMC = GameDate.ALJFLADELOD(currentGameDate);
		GJHHKLEBFEC.multi = 1769f;
		((MonoBehaviour)this).StartCoroutine(LBPJBDBFEHO(LPMJNPEBIIM, CCFNCPEHPPO));
	}

	private void EFADOCDHPKG()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(GCLCGBONABI));
		GJHHKLEBFEC.multi = 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(28) / 100f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.GGFJGHHHEJC.OnGuestSpawn();
	}

	private void EAEKKBEJMFC()
	{
		GameDate lGLDPMAABLA = WorldTime.HGIBNMBJMOC();
		lGLDPMAABLA.hour = -73;
		lGLDPMAABLA.min = 1;
		LPMJNPEBIIM = GameDate.GGNGGLHBMNA(lGLDPMAABLA);
		lGLDPMAABLA.hour = -91;
		lGLDPMAABLA.min = 1;
		MIDABOHGOMC = GameDate.JNBDOMFDJEH(lGLDPMAABLA);
		GJHHKLEBFEC.multi = 86f;
		((MonoBehaviour)this).StartCoroutine(NINODINELBI(LPMJNPEBIIM, MFEDAAAIJOO));
	}

	private void EAAFALHHNBO()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private IEnumerator EOJAJHPKIHI(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		while (WorldTime.HMOCOBGKMNJ < DEKAPINHBCO)
		{
			yield return null;
		}
		OKNOJJEFEBE();
	}

	private IEnumerator CMACKOLAGJB(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		return new JOJAJFHODDI(1)
		{
			timeMin = DEKAPINHBCO,
			action = OKNOJJEFEBE
		};
	}

	private void KFLHMIOCKNE()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	public void MMFGMLNFNED()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (PBNMBCAIMNN)
			{
				FKBHAKBPNFH();
				PBNMBCAIMNN = false;
			}
			PJNGMCJIHME = NPCRoadManager.CHCCNCNNELI();
			PJNGMCJIHME.customerType = CustomerType.Traveller;
			PJNGMCJIHME.emoter.StartEmote(Emote.Star);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(EJPEGHDKBPH));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(MNLDKBOLDLI));
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	private void MEABDJIAEOF()
	{
		((MonoBehaviour)this).Invoke("Pants_L", 1634f);
		HHEJJOLPIAK();
	}

	public void OMFDKPLFELM()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (PBNMBCAIMNN)
			{
				PKBJMMOCOGE();
				PBNMBCAIMNN = false;
			}
			PJNGMCJIHME = NPCRoadManager.OMKDMGBFAMM();
			PJNGMCJIHME.customerType = CustomerType.Traveller;
			PJNGMCJIHME.emoter.StartEmote(Emote.Exclamation);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(EFADOCDHPKG));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(PPANAEPODBK));
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	public void GJJOKNHGPKJ()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (PBNMBCAIMNN)
			{
				LPIKIKLEHPB();
				PBNMBCAIMNN = true;
			}
			PJNGMCJIHME = NPCRoadManager.IENMNPMLAOL();
			PJNGMCJIHME.customerType = CustomerType.ImportantGuest;
			PJNGMCJIHME.emoter.StartEmote(Emote.Star);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(NLGHDMIEHAM));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(MEABDJIAEOF));
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	public void OKKNIILLEMH()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (PBNMBCAIMNN)
			{
				PKBJMMOCOGE();
				PBNMBCAIMNN = false;
			}
			PJNGMCJIHME = NPCRoadManager.IENMNPMLAOL();
			PJNGMCJIHME.customerType = CustomerType.Traveller;
			PJNGMCJIHME.emoter.StartEmote(Emote.Exclamation);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(IKKEMIAJGIG));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(MNLDKBOLDLI));
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	private void NOILIOLOOBJ()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		HHEJJOLPIAK();
	}

	private void DKHCOKMIJME()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		JMLPDOPLEDK();
	}

	private void PPANAEPODBK()
	{
		((MonoBehaviour)this).Invoke("Items/item_name_678", 938f);
		KGDCPCAHBGA();
	}

	private void ODHPGPIHGKC()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(KFHFEBOOHCD));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(MIILDFFOKKN));
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Remove(pJNGMCJIHME.OnCustomerLeave, new Action(DOBGDOEGNMP));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatFound = (Action)Delegate.Remove(pJNGMCJIHME2.OnSeatFound, new Action(KPDCNLNCGFG));
			Customer pJNGMCJIHME3 = PJNGMCJIHME;
			pJNGMCJIHME3.OnSeatNotFound = (Action)Delegate.Remove(pJNGMCJIHME3.OnSeatNotFound, new Action(HOLEPJHAFAD));
		}
		if (ACBBAMGKFAB != null)
		{
			((MonoBehaviour)this).StopCoroutine(ACBBAMGKFAB);
		}
		NPCRoadManager.customersWaitingSeat.Remove((MonoBehaviour)(object)this);
	}

	private void HDLPPNEBNEM(int JIIGOACEIKL)
	{
		CCOJEJIMOLB();
	}

	private void IDELEIBLPAN()
	{
		((MonoBehaviour)this).Invoke("HandUp", 1754f);
		PKBJMMOCOGE();
	}

	private void FKAACFDNOPJ(int JIIGOACEIKL)
	{
		MMFGMLNFNED();
	}

	private IEnumerator PPNJJFJPPFD(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		while (WorldTime.HMOCOBGKMNJ < DEKAPINHBCO)
		{
			yield return null;
		}
		OKNOJJEFEBE();
	}

	private IEnumerator LBPJBDBFEHO(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		while (WorldTime.HMOCOBGKMNJ < DEKAPINHBCO)
		{
			yield return null;
		}
		OKNOJJEFEBE();
	}

	private void KCLKEAHGGEK()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		HHEJJOLPIAK();
	}

	private void FINACLBODFD()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(KFLHMIOCKNE));
		GJHHKLEBFEC.multi = 1075f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(35, 1) / 609f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.GGFJGHHHEJC.OnGuestSpawn();
	}

	private void JPGMFFKJPJJ()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void ODKGLIDMCNP()
	{
		GameDate lGLDPMAABLA = WorldTime.CJOHMLNMJLK();
		lGLDPMAABLA.hour = 3;
		lGLDPMAABLA.min = 0;
		LPMJNPEBIIM = GameDate.GPPGKONILOE(lGLDPMAABLA);
		lGLDPMAABLA.hour = 106;
		lGLDPMAABLA.min = 0;
		MIDABOHGOMC = GameDate.DAFIFHBDNDF(lGLDPMAABLA);
		GJHHKLEBFEC.multi = 1760f;
		((MonoBehaviour)this).StartCoroutine(CMACKOLAGJB(LPMJNPEBIIM, OGFGAAIMBAE));
	}

	private void HOFHOKPHAND(int JIIGOACEIKL)
	{
		MIAJLFBLAPO();
	}

	private void DFFDKIPCCKK()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		HHEJJOLPIAK();
	}

	private IEnumerator ALDPJIFFHIP(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		while (WorldTime.HMOCOBGKMNJ < DEKAPINHBCO)
		{
			yield return null;
		}
		OKNOJJEFEBE();
	}

	private void PDEDEOJDJMO()
	{
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(KFHFEBOOHCD));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(BEPJLJPOFBH(MIDABOHGOMC, NEGNMEDPCJJ));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
			return;
		}
		Seat[] array = TavernSeatingManager.OBHGDHFPDCO();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(GJJOKNHGPKJ));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(BEPJLJPOFBH(MIDABOHGOMC, JPGMFFKJPJJ));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
		}
		else
		{
			PBNMBCAIMNN = true;
			BDHPHKCPJKM();
		}
	}

	private void GAKCENNKMDO()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(JPGMFFKJPJJ));
		GJHHKLEBFEC.multi = 1297f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(4, 0, LDNMDAHFBGG: true) / 124f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.GGFJGHHHEJC.OnGuestSpawn();
	}

	private void IKKEMIAJGIG()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(JPGMFFKJPJJ));
		GJHHKLEBFEC.multi = 381f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(0) / 1099f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.MNFMOEKMJKN().OnGuestSpawn();
	}

	private void KEMPKKCGLCG(int JIIGOACEIKL)
	{
		OKKNIILLEMH();
	}

	private void LEMPHHNCNKH()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(JPGMFFKJPJJ));
		GJHHKLEBFEC.multi = 351f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(29, 0, LDNMDAHFBGG: true) / 252f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.GGFJGHHHEJC.OnGuestSpawn();
	}

	private void IABEJCPMJOF()
	{
		GameDate lGLDPMAABLA = WorldTime.CJOHMLNMJLK();
		lGLDPMAABLA.hour = 6;
		lGLDPMAABLA.min = 0;
		LPMJNPEBIIM = GameDate.HJCLEBDPLOP(lGLDPMAABLA);
		lGLDPMAABLA.hour = -69;
		lGLDPMAABLA.min = 0;
		MIDABOHGOMC = GameDate.IAAIHAFKOKL(lGLDPMAABLA);
		GJHHKLEBFEC.multi = 1163f;
		((MonoBehaviour)this).StartCoroutine(MCBMIGKOKGL(LPMJNPEBIIM, JHEJLIBLIMC));
	}

	private void FKPNIHJGFBJ()
	{
		GameDate lGLDPMAABLA = WorldTime.HGIBNMBJMOC();
		lGLDPMAABLA.hour = -74;
		lGLDPMAABLA.min = 1;
		LPMJNPEBIIM = GameDate.HJCLEBDPLOP(lGLDPMAABLA);
		lGLDPMAABLA.hour = 29;
		lGLDPMAABLA.min = 0;
		MIDABOHGOMC = GameDate.HJCLEBDPLOP(lGLDPMAABLA);
		GJHHKLEBFEC.multi = 302f;
		((MonoBehaviour)this).StartCoroutine(PPNJJFJPPFD(LPMJNPEBIIM, CCFNCPEHPPO));
	}

	private IEnumerator CKDPLJEFPNF(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		while (WorldTime.HMOCOBGKMNJ < DEKAPINHBCO)
		{
			yield return null;
		}
		OKNOJJEFEBE();
	}

	private void FDHBBDAADJA()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void OGFGAAIMBAE()
	{
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(HDLPPNEBNEM));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(PPNJJFJPPFD(MIDABOHGOMC, NEGNMEDPCJJ));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = false;
			return;
		}
		Seat[] array = TavernSeatingManager.OBHGDHFPDCO();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(BDKOADOPNMM));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(HKGCKGJCDNC(MIDABOHGOMC, KFLHMIOCKNE));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = false;
		}
		else
		{
			PBNMBCAIMNN = true;
			FKELLFEJFLF();
		}
	}

	private void MNFGKIFMFJN()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(DOBGDOEGNMP));
		GJHHKLEBFEC.multi = 974f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(105, 0, LDNMDAHFBGG: true) / 726f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.GGFJGHHHEJC.OnGuestSpawn();
	}

	private void BCJFEHPIOCG(int JIIGOACEIKL)
	{
		MIILDFFOKKN();
	}

	private void JCLFBHBBOKD()
	{
		TavernManager.GGFJGHHHEJC.RemoveRepMultiplier(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private void OGPGNNAFFPI()
	{
		((MonoBehaviour)this).Invoke("in", 715f);
		LPIKIKLEHPB();
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		SpawnImportantGuest();
	}

	private IEnumerator MCBMIGKOKGL(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		while (WorldTime.HMOCOBGKMNJ < DEKAPINHBCO)
		{
			yield return null;
		}
		OKNOJJEFEBE();
	}

	private void HOLEPJHAFAD()
	{
		((MonoBehaviour)this).Invoke("Items/item_description_683", 1477f);
		JMLPDOPLEDK();
	}

	private void FIBOPBHJNFH()
	{
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(FINCLCKFMFD));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(MCBMIGKOKGL(MIDABOHGOMC, KNNICKDCIHF));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
			return;
		}
		Seat[] array = TavernSeatingManager.JJAAMOOGKCA();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(MMFGMLNFNED));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(EDPBGFCBPHI(MIDABOHGOMC, DOBGDOEGNMP));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
		}
		else
		{
			PBNMBCAIMNN = true;
			MIILDFFOKKN();
		}
	}

	private void KOPJMPDEAJG()
	{
		TavernManager.GGFJGHHHEJC.PKAJCAKPBAF(GJHHKLEBFEC);
		Object.Destroy((Object)(object)this);
	}

	private IEnumerator LNOIOBFDOPK(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		return new JOJAJFHODDI(1)
		{
			timeMin = DEKAPINHBCO,
			action = OKNOJJEFEBE
		};
	}

	private void PFKLMHPNNPE()
	{
		((MonoBehaviour)this).Invoke("Direction", 1823f);
		BOEGLOBKJPE();
	}

	private IEnumerator EDPBGFCBPHI(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		return new JOJAJFHODDI(1)
		{
			timeMin = DEKAPINHBCO,
			action = OKNOJJEFEBE
		};
	}

	public void BDHPHKCPJKM()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			if (PBNMBCAIMNN)
			{
				PKBJMMOCOGE();
				PBNMBCAIMNN = true;
			}
			PJNGMCJIHME = NPCRoadManager.PIIOHNMPOAB();
			PJNGMCJIHME.customerType = CustomerType.ImportantGuest;
			PJNGMCJIHME.emoter.StartEmote(Emote.Exclamation);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(KPDCNLNCGFG));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(PFKLMHPNNPE));
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	private void MFFMIHFNCJH()
	{
		((MonoBehaviour)this).Invoke("quest_description_24", 225f);
		LPIKIKLEHPB();
	}

	public void MIILDFFOKKN()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (PBNMBCAIMNN)
			{
				BOEGLOBKJPE();
				PBNMBCAIMNN = true;
			}
			PJNGMCJIHME = NPCRoadManager.IENMNPMLAOL();
			PJNGMCJIHME.customerType = CustomerType.ImportantGuest;
			PJNGMCJIHME.emoter.GBDIJOENJCN(Emote.Star, NAILNAHFJFD: true);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(CNOBBJNCNBA));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(MFFMIHFNCJH));
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	private void KIJGMJEAHKC()
	{
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(JNLLBCGHACJ));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(CMACKOLAGJB(MIDABOHGOMC, DOBGDOEGNMP));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = false;
			return;
		}
		Seat[] array = TavernSeatingManager.IGNOOODLMDG();
		if (array == null || array.Length == 0)
		{
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(BDHPHKCPJKM));
			ACBBAMGKFAB = ((MonoBehaviour)this).StartCoroutine(CMACKOLAGJB(MIDABOHGOMC, PJNECPMGPMJ));
			NPCRoadManager.customersWaitingSeat.Add((MonoBehaviour)(object)this);
			PBNMBCAIMNN = true;
		}
		else
		{
			PBNMBCAIMNN = true;
			GJJOKNHGPKJ();
		}
	}

	private IEnumerator NINODINELBI(ulong DEKAPINHBCO, Action OKNOJJEFEBE)
	{
		while (WorldTime.HMOCOBGKMNJ < DEKAPINHBCO)
		{
			yield return null;
		}
		OKNOJJEFEBE();
	}

	public void HEOJNJNOOKF()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (PBNMBCAIMNN)
			{
				MJOPAKEOMBE();
				PBNMBCAIMNN = true;
			}
			PJNGMCJIHME = NPCRoadManager.HHLLOLDEJAB();
			PJNGMCJIHME.customerType = CustomerType.Traveller;
			PJNGMCJIHME.emoter.GBDIJOENJCN(Emote.Exclamation, NAILNAHFJFD: true);
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.OnSeatFound = (Action)Delegate.Combine(pJNGMCJIHME.OnSeatFound, new Action(BDINCIHNHLF));
			Customer pJNGMCJIHME2 = PJNGMCJIHME;
			pJNGMCJIHME2.OnSeatNotFound = (Action)Delegate.Combine(pJNGMCJIHME2.OnSeatNotFound, new Action(IDELEIBLPAN));
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
			if (OnlineManager.PlayingOnline())
			{
				PJNGMCJIHME.LJOHCJAOADD?.SendActivateVIP();
			}
		}
	}

	private void NLGHDMIEHAM()
	{
		Customer pJNGMCJIHME = PJNGMCJIHME;
		pJNGMCJIHME.OnCustomerLeave = (Action)Delegate.Combine(pJNGMCJIHME.OnCustomerLeave, new Action(OOPNMJNHLAD));
		GJHHKLEBFEC.multi = 817f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(31, 1) / 1227f;
		TavernManager.GGFJGHHHEJC.AddRepMultiplier(GJHHKLEBFEC);
		CommonReferences.MNFMOEKMJKN().OnGuestSpawn();
	}

	private void OPCMBKGAINC(int JIIGOACEIKL)
	{
		OKKNIILLEMH();
	}
}
