using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class TavernAmbienceController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class HEICPJFONLK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MultiAudioSource source;

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
		public HEICPJFONLK(int _003C_003E1__state)
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
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				source.Stop(false);
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
	private sealed class CLMAFJMHHJO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MultiAudioSource source;

		public float startVolume;

		public float endVolume;

		public float fadeTime;

		private float _003CclipStartTime_003E5__2;

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
		public CLMAFJMHHJO(int _003C_003E1__state)
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
				source.VolumeOverride = startVolume;
				_003CclipStartTime_003E5__2 = Time.realtimeSinceStartup;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (Time.realtimeSinceStartup - _003CclipStartTime_003E5__2 < fadeTime)
			{
				source.VolumeOverride = Mathf.Lerp(startVolume, endVolume, (Time.realtimeSinceStartup - _003CclipStartTime_003E5__2) / fadeTime);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
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

	private static TavernAmbienceController IADEMLIIDPC;

	public AudioObject crowd;

	public AudioObject smallCrowd;

	private MultiAudioSource MJOPJMNBABO;

	private MultiAudioSource KHDAJIONHOE;

	private float MJKKJOFBCKC;

	private Coroutine CBLCBMEGNII;

	private float DCDIJMHPPMH;

	private Coroutine DMMMMNEJLOJ;

	private bool EAEBDMAJNCP;

	public int numberOfCustomers;

	public static TavernAmbienceController GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
			}
			return IADEMLIIDPC;
		}
	}

	[SpecialName]
	public static TavernAmbienceController MAMKICHCPON()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private void AADEJPNOBHP()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			EHKKJCJIIAL();
		}
	}

	private IEnumerator DHLPONCMHKC(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		ODHLEHJPGKP.VolumeOverride = IJHEMHEOJLB;
		float clipStartTime = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup - clipStartTime < CBPHLLOGJAI)
		{
			ODHLEHJPGKP.VolumeOverride = Mathf.Lerp(IJHEMHEOJLB, KEHHFCGOJGF, (Time.realtimeSinceStartup - clipStartTime) / CBPHLLOGJAI);
			yield return null;
		}
	}

	private void LGJLKGKACAO()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(CLIINGHHEAF));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(LJCKJCKNNIP));
	}

	private IEnumerator INNONPGLHHB(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	[SpecialName]
	public static TavernAmbienceController LHKFIDJFPDB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private void OOIHNJHMBMC()
	{
		IADEMLIIDPC = this;
	}

	private IEnumerator ABODAOMDKDK(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	private void GONDLJKGLGO()
	{
		IADEMLIIDPC = this;
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(SetAmbience));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(SetAmbience));
		}
	}

	private IEnumerator NNLHNKMPCOH(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		ODHLEHJPGKP.VolumeOverride = IJHEMHEOJLB;
		float clipStartTime = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup - clipStartTime < CBPHLLOGJAI)
		{
			ODHLEHJPGKP.VolumeOverride = Mathf.Lerp(IJHEMHEOJLB, KEHHFCGOJGF, (Time.realtimeSinceStartup - clipStartTime) / CBPHLLOGJAI);
			yield return null;
		}
	}

	[SpecialName]
	public static TavernAmbienceController FMIDAFEGDCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private void NOKBAKEAJAD()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			JIJJKGEFNOO();
		}
	}

	private IEnumerator ICNKDOJKJOO(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	private void BIILFPDIADC()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			JIJJKGEFNOO();
		}
	}

	private IEnumerator ENBHFHDMKNM(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		ODHLEHJPGKP.VolumeOverride = IJHEMHEOJLB;
		float clipStartTime = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup - clipStartTime < CBPHLLOGJAI)
		{
			ODHLEHJPGKP.VolumeOverride = Mathf.Lerp(IJHEMHEOJLB, KEHHFCGOJGF, (Time.realtimeSinceStartup - clipStartTime) / CBPHLLOGJAI);
			yield return null;
		}
	}

	public void EDFKGFMMFDM()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.SendSetAmbience(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MJKKJOFBCKC = Mathf.Lerp(1466f, 1523f, Mathf.Min((float)(numberOfCustomers - 0) / 1494f, 1092f));
			DCDIJMHPPMH = Mathf.Lerp(1743f, 340f, Mathf.Min((float)(numberOfCustomers - 40) / 1072f, 1113f));
		}
		else
		{
			DCDIJMHPPMH = 1460f;
			MJKKJOFBCKC = 1992f;
		}
		if (DCDIJMHPPMH > 1437f && TavernZonesManager.NHKAFANMEJC().OKDDKEKOMDM(ZoneType.RentedRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.IECOPNFJBFD().MJBJDCNCDEE(ZoneType.None).CKBDPPMPGNJ()));
			MJOPJMNBABO.VolumeOverride = 1230f;
		}
		if (MJKKJOFBCKC > 1424f && TavernZonesManager.NHKAFANMEJC().ALLMAFJPLKO(ZoneType.DiningRoom | ZoneType.CraftingRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.HFHPMKJGMPA().GetFirstTavernZoneOfType(ZoneType.DiningRoom | ZoneType.CraftingRoom).OJLJLPLGNKD()));
			KHDAJIONHOE.VolumeOverride = 872f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1218f)
			{
				MJOPJMNBABO.FadeOut(719f, true);
				((MonoBehaviour)this).StartCoroutine(INNONPGLHHB(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(EOFJHLNLJMF(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 1200f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 1257f)
			{
				KHDAJIONHOE.FadeOut(823f, false);
				((MonoBehaviour)this).StartCoroutine(INNONPGLHHB(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(BKPBDFANOOL(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 637f));
			}
		}
	}

	public void EMMOJKPFBMF()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineTavernManager.instance.GBEPEHECNAH(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MJKKJOFBCKC = Mathf.Lerp(679f, 960f, Mathf.Min((float)(numberOfCustomers - 1) / 959f, 768f));
			DCDIJMHPPMH = Mathf.Lerp(585f, 688f, Mathf.Min((float)(numberOfCustomers - -18) / 23f, 1029f));
		}
		else
		{
			DCDIJMHPPMH = 1109f;
			MJKKJOFBCKC = 1456f;
		}
		if (DCDIJMHPPMH > 202f && TavernZonesManager.OIJLJKLMCBO().MJBJDCNCDEE(ZoneType.WithoutZone) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.EBAIHKJHCCA().ALLMAFJPLKO(ZoneType.WithoutZone | ZoneType.CraftingRoom).CKBDPPMPGNJ()));
			MJOPJMNBABO.VolumeOverride = 1376f;
		}
		if (MJKKJOFBCKC > 1455f && TavernZonesManager.OIJLJKLMCBO().OKDDKEKOMDM(ZoneType.DiningRoom | ZoneType.CraftingRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.JEEGOBGDLPE().OKDDKEKOMDM(ZoneType.DiningRoom | ZoneType.CraftingRoom).HCEFIGGDBOO()));
			KHDAJIONHOE.VolumeOverride = 1922f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1701f)
			{
				MJOPJMNBABO.FadeOut(1450f, false);
				((MonoBehaviour)this).StartCoroutine(JPNLIDPOCOF(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(NCDNFACBMBN(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 1399f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 1751f)
			{
				KHDAJIONHOE.FadeOut(659f, true);
				((MonoBehaviour)this).StartCoroutine(AJLNKPNAFOB(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(DMICLOOIOCJ(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 1693f));
			}
		}
	}

	private void OHGABHEDILE()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			JIJJKGEFNOO();
		}
	}

	public void KFEBCAEHCIC()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineTavernManager.instance.GBEPEHECNAH(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(636f, 1565f, Mathf.Min((float)(numberOfCustomers - 1) / 725f, 35f));
			DCDIJMHPPMH = Mathf.Lerp(1053f, 30f, Mathf.Min((float)(numberOfCustomers - -112) / 492f, 1837f));
		}
		else
		{
			DCDIJMHPPMH = 657f;
			MJKKJOFBCKC = 1736f;
		}
		if (DCDIJMHPPMH > 1060f && TavernZonesManager.LANAINBEMCM().OKDDKEKOMDM(ZoneType.RentedRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.HFHPMKJGMPA().GetFirstTavernZoneOfType(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom).CKBDPPMPGNJ()));
			MJOPJMNBABO.VolumeOverride = 1731f;
		}
		if (MJKKJOFBCKC > 1470f && TavernZonesManager.HFHPMKJGMPA().GetFirstTavernZoneOfType(ZoneType.WithoutZone) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.LANAINBEMCM().MJBJDCNCDEE(ZoneType.WithoutZone | ZoneType.DiningRoom).DANEEPEJNNG()));
			KHDAJIONHOE.VolumeOverride = 1888f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 930f)
			{
				MJOPJMNBABO.FadeOut(717f, false);
				((MonoBehaviour)this).StartCoroutine(PBDCDKHBEMK(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(ENBHFHDMKNM(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 84f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 1369f)
			{
				KHDAJIONHOE.FadeOut(997f, false);
				((MonoBehaviour)this).StartCoroutine(HDCDGGKFNOL(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(BCBFGBIIGNM(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 1230f));
			}
		}
	}

	private IEnumerator JPNLIDPOCOF(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	private void FGLCNIOLKKL()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(DOBJFJHJIHI));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(JIJJKGEFNOO));
		}
	}

	private void DDLLFPICOJK()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			EDFKGFMMFDM();
		}
	}

	private void PGMCCCNILND()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(LJCKJCKNNIP));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(IJFHHEPGFIG));
		}
	}

	private void MMANKOFCDGO()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(LJCKJCKNNIP));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(IPKFGPAOCLK));
	}

	private void FAKNILODPNH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(IJDGGAGMEFM));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(SetAmbience));
		}
	}

	private IEnumerator AJLNKPNAFOB(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	private IEnumerator HONDOGFJDNM(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	private void IAICCKPOBMJ()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PIBIEEAPDGA();
		}
	}

	private void IPMCBCCJAAJ()
	{
		IADEMLIIDPC = this;
	}

	private void GDKOIIEHKGO()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(IJFHHEPGFIG));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(LJCKJCKNNIP));
		}
	}

	private void CJDJDDNCNDJ()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(IPKFGPAOCLK));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(EEMDJHPCHGN));
	}

	private IEnumerator LDNEFDEFHBO(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	private void KJOCGLKMMOM()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(EMMOJKPFBMF));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(EDFKGFMMFDM));
		}
	}

	private void MPGPLILIJOD()
	{
		IADEMLIIDPC = this;
	}

	private IEnumerator POPJJFOKGJF(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	private void EMGJMHAJFDF()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(IJDGGAGMEFM));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(OHCNPKIJCOK));
	}

	private void FCLABOCLACJ()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(EHKKJCJIIAL));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(DOBJFJHJIHI));
	}

	private IEnumerator FAIMJJNHNPB(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	[SpecialName]
	public static TavernAmbienceController MKIEMMGGFEE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static TavernAmbienceController HKBJIIJHBJB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private void CCEKJEDMJAP()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			EHKKJCJIIAL();
		}
	}

	private IEnumerator BKPBDFANOOL(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		ODHLEHJPGKP.VolumeOverride = IJHEMHEOJLB;
		float clipStartTime = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup - clipStartTime < CBPHLLOGJAI)
		{
			ODHLEHJPGKP.VolumeOverride = Mathf.Lerp(IJHEMHEOJLB, KEHHFCGOJGF, (Time.realtimeSinceStartup - clipStartTime) / CBPHLLOGJAI);
			yield return null;
		}
	}

	private void BHAFCBHENPL()
	{
		IADEMLIIDPC = this;
	}

	private IEnumerator HMIOICGBPED(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		ODHLEHJPGKP.VolumeOverride = IJHEMHEOJLB;
		float clipStartTime = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup - clipStartTime < CBPHLLOGJAI)
		{
			ODHLEHJPGKP.VolumeOverride = Mathf.Lerp(IJHEMHEOJLB, KEHHFCGOJGF, (Time.realtimeSinceStartup - clipStartTime) / CBPHLLOGJAI);
			yield return null;
		}
	}

	private IEnumerator PBDCDKHBEMK(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	[SpecialName]
	public static TavernAmbienceController KHMEGDIABBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private void ADJHOLOIGJE()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(OGHPIABDMCB));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(EDFKGFMMFDM));
		}
	}

	private void HKJCLFHCMKC()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(IPKFGPAOCLK));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(JIJJKGEFNOO));
	}

	public void SetAmbience()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.SendSetAmbience(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(0f, 0.8f, Mathf.Min((float)(numberOfCustomers - 1) / 20f, 1f));
			DCDIJMHPPMH = Mathf.Lerp(0f, 0.8f, Mathf.Min((float)(numberOfCustomers - 15) / 20f, 1f));
		}
		else
		{
			DCDIJMHPPMH = 0f;
			MJKKJOFBCKC = 0f;
		}
		if (DCDIJMHPPMH > 0f && TavernZonesManager.GGFJGHHHEJC.GetFirstTavernZoneOfType(ZoneType.DiningRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.GGFJGHHHEJC.GetFirstTavernZoneOfType(ZoneType.DiningRoom).HCEFIGGDBOO()));
			MJOPJMNBABO.VolumeOverride = 0f;
		}
		if (MJKKJOFBCKC > 0f && TavernZonesManager.GGFJGHHHEJC.GetFirstTavernZoneOfType(ZoneType.DiningRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.GGFJGHHHEJC.GetFirstTavernZoneOfType(ZoneType.DiningRoom).HCEFIGGDBOO()));
			KHDAJIONHOE.VolumeOverride = 0f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 0f)
			{
				MJOPJMNBABO.FadeOut(5f, false);
				((MonoBehaviour)this).StartCoroutine(JKLABPFHBLL(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(PKIIAJGHOEH(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 5f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 0f)
			{
				KHDAJIONHOE.FadeOut(5f, false);
				((MonoBehaviour)this).StartCoroutine(JKLABPFHBLL(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(PKIIAJGHOEH(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 5f));
			}
		}
	}

	public void GHIPLNECJIA()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.IBAHKGKJHCB(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(849f, 15f, Mathf.Min((float)(numberOfCustomers - 0) / 550f, 1986f));
			DCDIJMHPPMH = Mathf.Lerp(592f, 1638f, Mathf.Min((float)(numberOfCustomers - 14) / 84f, 1062f));
		}
		else
		{
			DCDIJMHPPMH = 1308f;
			MJKKJOFBCKC = 1028f;
		}
		if (DCDIJMHPPMH > 1333f && TavernZonesManager.GGFJGHHHEJC.OKDDKEKOMDM(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.JEEGOBGDLPE().GetFirstTavernZoneOfType(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom).KBGOOHGDADC()));
			MJOPJMNBABO.VolumeOverride = 759f;
		}
		if (MJKKJOFBCKC > 82f && TavernZonesManager.GGFJGHHHEJC.ALLMAFJPLKO(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.IECOPNFJBFD().MJBJDCNCDEE(ZoneType.WithoutZone | ZoneType.CraftingRoom).NEKBEKCPJLP()));
			KHDAJIONHOE.VolumeOverride = 789f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1809f)
			{
				MJOPJMNBABO.FadeOut(1398f, false);
				((MonoBehaviour)this).StartCoroutine(EDKJBNKGPOJ(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(ENBHFHDMKNM(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 1899f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 1356f)
			{
				KHDAJIONHOE.FadeOut(446f, true);
				((MonoBehaviour)this).StartCoroutine(JJELNPPFIAN(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(DMICLOOIOCJ(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 310f));
			}
		}
	}

	private void OIHAMLCIFNH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(IPKFGPAOCLK));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(EGOANIIBGJK));
		}
	}

	private IEnumerator EDKJBNKGPOJ(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	public void IPKFGPAOCLK()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.SendSetAmbience(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(516f, 1193f, Mathf.Min((float)(numberOfCustomers - 1) / 1463f, 760f));
			DCDIJMHPPMH = Mathf.Lerp(1381f, 1554f, Mathf.Min((float)(numberOfCustomers - 26) / 526f, 514f));
		}
		else
		{
			DCDIJMHPPMH = 534f;
			MJKKJOFBCKC = 614f;
		}
		if (DCDIJMHPPMH > 62f && TavernZonesManager.EBAIHKJHCCA().ALLMAFJPLKO(ZoneType.WithoutZone) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.HFHPMKJGMPA().MJBJDCNCDEE(ZoneType.None).BCPPCDILJKD()));
			MJOPJMNBABO.VolumeOverride = 176f;
		}
		if (MJKKJOFBCKC > 4f && TavernZonesManager.IECOPNFJBFD().MJBJDCNCDEE(ZoneType.DiningRoom | ZoneType.CraftingRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.LANAINBEMCM().MJBJDCNCDEE(ZoneType.None).KBGOOHGDADC()));
			KHDAJIONHOE.VolumeOverride = 980f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1498f)
			{
				MJOPJMNBABO.FadeOut(1404f, false);
				((MonoBehaviour)this).StartCoroutine(HDCDGGKFNOL(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(PKIIAJGHOEH(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 1624f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 1240f)
			{
				KHDAJIONHOE.FadeOut(518f, false);
				((MonoBehaviour)this).StartCoroutine(ILIDCCLIFIK(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(DMICLOOIOCJ(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 1426f));
			}
		}
	}

	private IEnumerator BCCDHAGFGJF(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	private void HONFDJKKGJK()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			GHIPLNECJIA();
		}
	}

	private IEnumerator ILIDCCLIFIK(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	private void AHCPFICKFHA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(OGHPIABDMCB));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(MOADFKHADOB));
		}
	}

	private void FBHBEAJFBAH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(KFEBCAEHCIC));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(EHKKJCJIIAL));
		}
	}

	private IEnumerator EOFJHLNLJMF(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		return new CLMAFJMHHJO(1)
		{
			source = ODHLEHJPGKP,
			startVolume = IJHEMHEOJLB,
			endVolume = KEHHFCGOJGF,
			fadeTime = CBPHLLOGJAI
		};
	}

	private void BPNOIDBAPJE()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(EMMOJKPFBMF));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(DOBJFJHJIHI));
	}

	private void JJCDLIHLDMJ()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(EMMOJKPFBMF));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(PIBIEEAPDGA));
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
	}

	private void AFGJLAACCFN()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(EMMOJKPFBMF));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(EMMOJKPFBMF));
	}

	[SpecialName]
	public static TavernAmbienceController ABHIDHPMLLD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	public void MOADFKHADOB()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineTavernManager.instance.KFIEEOFDAFD(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(1245f, 1091f, Mathf.Min((float)(numberOfCustomers - 0) / 198f, 536f));
			DCDIJMHPPMH = Mathf.Lerp(1409f, 756f, Mathf.Min((float)(numberOfCustomers - 48) / 937f, 1001f));
		}
		else
		{
			DCDIJMHPPMH = 169f;
			MJKKJOFBCKC = 507f;
		}
		if (DCDIJMHPPMH > 756f && TavernZonesManager.OIJLJKLMCBO().GetFirstTavernZoneOfType(ZoneType.None) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.IECOPNFJBFD().ALLMAFJPLKO(ZoneType.CraftingRoom).OJLJLPLGNKD()));
			MJOPJMNBABO.VolumeOverride = 1686f;
		}
		if (MJKKJOFBCKC > 1438f && TavernZonesManager.IECOPNFJBFD().MJBJDCNCDEE(ZoneType.DiningRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.JEEGOBGDLPE().DNMIDKKJJEA(ZoneType.DiningRoom).KBGOOHGDADC()));
			KHDAJIONHOE.VolumeOverride = 816f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 123f)
			{
				MJOPJMNBABO.FadeOut(1663f, false);
				((MonoBehaviour)this).StartCoroutine(APNFLIGILKL(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(HMIOICGBPED(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 457f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 449f)
			{
				KHDAJIONHOE.FadeOut(611f, false);
				((MonoBehaviour)this).StartCoroutine(HONDOGFJDNM(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(DHLPONCMHKC(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 310f));
			}
		}
	}

	public void JDMOAJOFKGN()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.KFIEEOFDAFD(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(831f, 1987f, Mathf.Min((float)(numberOfCustomers - 1) / 511f, 703f));
			DCDIJMHPPMH = Mathf.Lerp(1448f, 338f, Mathf.Min((float)(numberOfCustomers - -68) / 365f, 1657f));
		}
		else
		{
			DCDIJMHPPMH = 1533f;
			MJKKJOFBCKC = 1837f;
		}
		if (DCDIJMHPPMH > 640f && TavernZonesManager.LANAINBEMCM().DNMIDKKJJEA(ZoneType.WithoutZone) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.GGFJGHHHEJC.GetFirstTavernZoneOfType(ZoneType.WithoutZone).DANEEPEJNNG()));
			MJOPJMNBABO.VolumeOverride = 1702f;
		}
		if (MJKKJOFBCKC > 1626f && TavernZonesManager.GGFJGHHHEJC.MJBJDCNCDEE(ZoneType.DiningRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.HFHPMKJGMPA().OKDDKEKOMDM(ZoneType.WithoutZone | ZoneType.DiningRoom).KBGOOHGDADC()));
			KHDAJIONHOE.VolumeOverride = 719f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1147f)
			{
				MJOPJMNBABO.FadeOut(706f, true);
				((MonoBehaviour)this).StartCoroutine(POPJJFOKGJF(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(BCBFGBIIGNM(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 1200f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 422f)
			{
				KHDAJIONHOE.FadeOut(1030f, false);
				((MonoBehaviour)this).StartCoroutine(INNONPGLHHB(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(NCDNFACBMBN(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 1176f));
			}
		}
	}

	private void OGGJNBCJGCE()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(IJFHHEPGFIG));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(GHIPLNECJIA));
		}
	}

	public void CLIINGHHEAF()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineTavernManager.instance.GBEPEHECNAH(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(565f, 332f, Mathf.Min((float)(numberOfCustomers - 1) / 1185f, 1983f));
			DCDIJMHPPMH = Mathf.Lerp(434f, 1669f, Mathf.Min((float)(numberOfCustomers - 16) / 1332f, 275f));
		}
		else
		{
			DCDIJMHPPMH = 1679f;
			MJKKJOFBCKC = 1008f;
		}
		if (DCDIJMHPPMH > 104f && TavernZonesManager.GGFJGHHHEJC.DNMIDKKJJEA(ZoneType.WithoutZone | ZoneType.DiningRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.EBAIHKJHCCA().GetFirstTavernZoneOfType(ZoneType.CraftingRoom).NBLOMNKMGCE()));
			MJOPJMNBABO.VolumeOverride = 359f;
		}
		if (MJKKJOFBCKC > 1593f && TavernZonesManager.IECOPNFJBFD().OKDDKEKOMDM(ZoneType.CraftingRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.LANAINBEMCM().OKDDKEKOMDM(ZoneType.None).NEKBEKCPJLP()));
			KHDAJIONHOE.VolumeOverride = 893f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 232f)
			{
				MJOPJMNBABO.FadeOut(828f, false);
				((MonoBehaviour)this).StartCoroutine(NNJKPLOCIAI(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(DMICLOOIOCJ(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 242f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 1450f)
			{
				KHDAJIONHOE.FadeOut(1806f, true);
				((MonoBehaviour)this).StartCoroutine(ABODAOMDKDK(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(BCBFGBIIGNM(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 806f));
			}
		}
	}

	private IEnumerator HDCDGGKFNOL(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	public void JIJJKGEFNOO()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.KFIEEOFDAFD(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(1530f, 335f, Mathf.Min((float)(numberOfCustomers - 0) / 1409f, 96f));
			DCDIJMHPPMH = Mathf.Lerp(1354f, 236f, Mathf.Min((float)(numberOfCustomers - -50) / 82f, 290f));
		}
		else
		{
			DCDIJMHPPMH = 967f;
			MJKKJOFBCKC = 198f;
		}
		if (DCDIJMHPPMH > 1725f && TavernZonesManager.IECOPNFJBFD().DNMIDKKJJEA(ZoneType.None) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.HFHPMKJGMPA().MJBJDCNCDEE(ZoneType.DiningRoom | ZoneType.CraftingRoom).BCPPCDILJKD()));
			MJOPJMNBABO.VolumeOverride = 1484f;
		}
		if (MJKKJOFBCKC > 176f && TavernZonesManager.JEEGOBGDLPE().DNMIDKKJJEA(ZoneType.DiningRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.JEEGOBGDLPE().ALLMAFJPLKO(ZoneType.None).HCEFIGGDBOO()));
			KHDAJIONHOE.VolumeOverride = 514f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1911f)
			{
				MJOPJMNBABO.FadeOut(1482f, true);
				((MonoBehaviour)this).StartCoroutine(CDPMLOJKEHE(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(BKPBDFANOOL(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 1307f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 473f)
			{
				KHDAJIONHOE.FadeOut(1612f, false);
				((MonoBehaviour)this).StartCoroutine(EOLBIGDPFBD(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(JOIPJOGOBLF(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 317f));
			}
		}
	}

	private void KHNGJFBMMCP()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			OHCNPKIJCOK();
		}
	}

	[SpecialName]
	public static TavernAmbienceController NEFIEJALANL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private IEnumerator JJELNPPFIAN(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	private void BHLHCOALABE()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			LJCKJCKNNIP();
		}
	}

	public void PIBIEEAPDGA()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.IBAHKGKJHCB(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(717f, 971f, Mathf.Min((float)(numberOfCustomers - 0) / 1712f, 470f));
			DCDIJMHPPMH = Mathf.Lerp(99f, 1182f, Mathf.Min((float)(numberOfCustomers - 59) / 1694f, 1829f));
		}
		else
		{
			DCDIJMHPPMH = 1973f;
			MJKKJOFBCKC = 281f;
		}
		if (DCDIJMHPPMH > 856f && TavernZonesManager.HFHPMKJGMPA().DNMIDKKJJEA(ZoneType.WithoutZone | ZoneType.CraftingRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.LANAINBEMCM().DNMIDKKJJEA(ZoneType.WithoutZone | ZoneType.CraftingRoom).DANEEPEJNNG()));
			MJOPJMNBABO.VolumeOverride = 1202f;
		}
		if (MJKKJOFBCKC > 1782f && TavernZonesManager.EBAIHKJHCCA().MJBJDCNCDEE(ZoneType.RentedRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.EBAIHKJHCCA().OKDDKEKOMDM(ZoneType.DiningRoom).NBLOMNKMGCE()));
			KHDAJIONHOE.VolumeOverride = 1093f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 479f)
			{
				MJOPJMNBABO.FadeOut(327f, false);
				((MonoBehaviour)this).StartCoroutine(LIHDFEPDAHJ(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(DFHKNNKIFGO(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 1894f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 1283f)
			{
				KHDAJIONHOE.FadeOut(917f, true);
				((MonoBehaviour)this).StartCoroutine(LDNEFDEFHBO(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(BCBFGBIIGNM(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 658f));
			}
		}
	}

	private IEnumerator JKLABPFHBLL(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	private IEnumerator EOLBIGDPFBD(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	[SpecialName]
	public static TavernAmbienceController LKOABOAADCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private IEnumerator GCBLPLPGFCA(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		ODHLEHJPGKP.VolumeOverride = IJHEMHEOJLB;
		float clipStartTime = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup - clipStartTime < CBPHLLOGJAI)
		{
			ODHLEHJPGKP.VolumeOverride = Mathf.Lerp(IJHEMHEOJLB, KEHHFCGOJGF, (Time.realtimeSinceStartup - clipStartTime) / CBPHLLOGJAI);
			yield return null;
		}
	}

	[SpecialName]
	public static TavernAmbienceController OFLELHKKNKC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private void MPLONAHPDNL()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			EMMOJKPFBMF();
		}
	}

	public void DOBJFJHJIHI()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.GBEPEHECNAH(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(1023f, 1880f, Mathf.Min((float)(numberOfCustomers - 0) / 1321f, 486f));
			DCDIJMHPPMH = Mathf.Lerp(1367f, 509f, Mathf.Min((float)(numberOfCustomers - -100) / 950f, 1304f));
		}
		else
		{
			DCDIJMHPPMH = 305f;
			MJKKJOFBCKC = 1277f;
		}
		if (DCDIJMHPPMH > 662f && TavernZonesManager.IECOPNFJBFD().MJBJDCNCDEE(ZoneType.CraftingRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.HFHPMKJGMPA().MJBJDCNCDEE(ZoneType.WithoutZone).DANEEPEJNNG()));
			MJOPJMNBABO.VolumeOverride = 1928f;
		}
		if (MJKKJOFBCKC > 1474f && TavernZonesManager.HFHPMKJGMPA().ALLMAFJPLKO(ZoneType.DiningRoom | ZoneType.CraftingRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.OIJLJKLMCBO().DNMIDKKJJEA(ZoneType.DiningRoom).KBGOOHGDADC()));
			KHDAJIONHOE.VolumeOverride = 401f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1608f)
			{
				MJOPJMNBABO.FadeOut(796f, true);
				((MonoBehaviour)this).StartCoroutine(LIHDFEPDAHJ(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(PKIIAJGHOEH(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 1783f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 718f)
			{
				KHDAJIONHOE.FadeOut(1895f, false);
				((MonoBehaviour)this).StartCoroutine(EOLBIGDPFBD(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(DHLPONCMHKC(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 887f));
			}
		}
	}

	private void LMPCDDGFBGD()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(SetAmbience));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(LNKHKPMNAGG));
	}

	[SpecialName]
	public static TavernAmbienceController PDECKLKPKCG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private void NNEBAHFHINE()
	{
		IADEMLIIDPC = this;
	}

	private void HFOCECKNDBG()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(IPKFGPAOCLK));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(EMMOJKPFBMF));
	}

	[SpecialName]
	public static TavernAmbienceController POINNCPMEIG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static TavernAmbienceController KIALFDOKABP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private void EOBODNOCKGA()
	{
		IADEMLIIDPC = this;
	}

	private void EPHDHKDCNOD()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(LNKHKPMNAGG));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(MOADFKHADOB));
		}
	}

	private void FDJIDOCMLHB()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(JIJJKGEFNOO));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(EMMOJKPFBMF));
	}

	private void EKCBGJJCDHB()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(EMMOJKPFBMF));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(LNKHKPMNAGG));
	}

	private IEnumerator NCDNFACBMBN(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		return new CLMAFJMHHJO(1)
		{
			source = ODHLEHJPGKP,
			startVolume = IJHEMHEOJLB,
			endVolume = KEHHFCGOJGF,
			fadeTime = CBPHLLOGJAI
		};
	}

	private void HKAMIGHHDEJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(IPKFGPAOCLK));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(KFEBCAEHCIC));
		}
	}

	private IEnumerator NNJKPLOCIAI(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	private IEnumerator APNFLIGILKL(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	private IEnumerator NKMOIDGOBAF(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	private IEnumerator NKHMLKAMCAB(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	private void NCFCFOKDGAB()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(LJCKJCKNNIP));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(PIBIEEAPDGA));
	}

	public void EGOANIIBGJK()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineTavernManager.instance.SendSetAmbience(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MJKKJOFBCKC = Mathf.Lerp(1317f, 63f, Mathf.Min((float)(numberOfCustomers - 1) / 397f, 655f));
			DCDIJMHPPMH = Mathf.Lerp(77f, 429f, Mathf.Min((float)(numberOfCustomers - 58) / 791f, 1191f));
		}
		else
		{
			DCDIJMHPPMH = 190f;
			MJKKJOFBCKC = 1084f;
		}
		if (DCDIJMHPPMH > 1846f && TavernZonesManager.LANAINBEMCM().GetFirstTavernZoneOfType(ZoneType.DiningRoom | ZoneType.CraftingRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.HFHPMKJGMPA().ALLMAFJPLKO(ZoneType.RentedRoom).DANEEPEJNNG()));
			MJOPJMNBABO.VolumeOverride = 1309f;
		}
		if (MJKKJOFBCKC > 406f && TavernZonesManager.GGFJGHHHEJC.OKDDKEKOMDM(ZoneType.DiningRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.JEEGOBGDLPE().MJBJDCNCDEE(ZoneType.CraftingRoom).OJLJLPLGNKD()));
			KHDAJIONHOE.VolumeOverride = 1183f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 486f)
			{
				MJOPJMNBABO.FadeOut(387f, false);
				((MonoBehaviour)this).StartCoroutine(ICNKDOJKJOO(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(BKPBDFANOOL(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 424f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 1009f)
			{
				KHDAJIONHOE.FadeOut(584f, true);
				((MonoBehaviour)this).StartCoroutine(NKHMLKAMCAB(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(GCBLPLPGFCA(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 619f));
			}
		}
	}

	public void OHCNPKIJCOK()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.KFIEEOFDAFD(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MJKKJOFBCKC = Mathf.Lerp(1512f, 51f, Mathf.Min((float)(numberOfCustomers - 0) / 203f, 836f));
			DCDIJMHPPMH = Mathf.Lerp(1611f, 1267f, Mathf.Min((float)(numberOfCustomers - -122) / 1907f, 1838f));
		}
		else
		{
			DCDIJMHPPMH = 1017f;
			MJKKJOFBCKC = 1407f;
		}
		if (DCDIJMHPPMH > 1058f && TavernZonesManager.JEEGOBGDLPE().DNMIDKKJJEA(ZoneType.None) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.EBAIHKJHCCA().DNMIDKKJJEA(ZoneType.DiningRoom | ZoneType.CraftingRoom).KBGOOHGDADC()));
			MJOPJMNBABO.VolumeOverride = 1415f;
		}
		if (MJKKJOFBCKC > 361f && TavernZonesManager.JEEGOBGDLPE().DNMIDKKJJEA(ZoneType.CraftingRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.OIJLJKLMCBO().OKDDKEKOMDM(ZoneType.WithoutZone).KBGOOHGDADC()));
			KHDAJIONHOE.VolumeOverride = 692f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 620f)
			{
				MJOPJMNBABO.FadeOut(1346f, false);
				((MonoBehaviour)this).StartCoroutine(POPJJFOKGJF(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(EOFJHLNLJMF(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 362f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 1455f)
			{
				KHDAJIONHOE.FadeOut(116f, true);
				((MonoBehaviour)this).StartCoroutine(ABODAOMDKDK(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(NNLHNKMPCOH(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 1173f));
			}
		}
	}

	private void BODICIENBEH()
	{
		IADEMLIIDPC = this;
	}

	private void BJBNBDJHMFN()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			EMMOJKPFBMF();
		}
	}

	private IEnumerator NBBKEANPLFP(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	private void HHHJPBBACLG()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			GHIPLNECJIA();
		}
	}

	private void CNFELPNGNOB()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(EHKKJCJIIAL));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(LNKHKPMNAGG));
		}
	}

	[SpecialName]
	public static TavernAmbienceController MOJDNGDNCCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private void ENGCLKEINDH()
	{
		IADEMLIIDPC = this;
	}

	private void LBNMAKPFDIF()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(LJCKJCKNNIP));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(MOADFKHADOB));
	}

	public void IJDGGAGMEFM()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.ECELJPIOJDP(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(20f, 279f, Mathf.Min((float)(numberOfCustomers - 0) / 217f, 801f));
			DCDIJMHPPMH = Mathf.Lerp(1202f, 1655f, Mathf.Min((float)(numberOfCustomers - -116) / 1234f, 953f));
		}
		else
		{
			DCDIJMHPPMH = 554f;
			MJKKJOFBCKC = 1441f;
		}
		if (DCDIJMHPPMH > 646f && TavernZonesManager.HFHPMKJGMPA().GetFirstTavernZoneOfType(ZoneType.CraftingRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.GGFJGHHHEJC.DNMIDKKJJEA(ZoneType.RentedRoom).BCPPCDILJKD()));
			MJOPJMNBABO.VolumeOverride = 572f;
		}
		if (MJKKJOFBCKC > 137f && TavernZonesManager.IECOPNFJBFD().DNMIDKKJJEA(ZoneType.DiningRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.JEEGOBGDLPE().GetFirstTavernZoneOfType(ZoneType.DiningRoom | ZoneType.CraftingRoom).DANEEPEJNNG()));
			KHDAJIONHOE.VolumeOverride = 1491f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 586f)
			{
				MJOPJMNBABO.FadeOut(482f, true);
				((MonoBehaviour)this).StartCoroutine(EOLBIGDPFBD(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(DFHKNNKIFGO(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 1579f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 497f)
			{
				KHDAJIONHOE.FadeOut(1754f, true);
				((MonoBehaviour)this).StartCoroutine(EDKJBNKGPOJ(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(PKIIAJGHOEH(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 1056f));
			}
		}
	}

	[SpecialName]
	public static TavernAmbienceController ILMPOAEALPP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	public void IJFHHEPGFIG()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineTavernManager.instance.IBAHKGKJHCB(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(1797f, 1410f, Mathf.Min((float)(numberOfCustomers - 0) / 33f, 1894f));
			DCDIJMHPPMH = Mathf.Lerp(1796f, 1751f, Mathf.Min((float)(numberOfCustomers - -37) / 578f, 1975f));
		}
		else
		{
			DCDIJMHPPMH = 390f;
			MJKKJOFBCKC = 60f;
		}
		if (DCDIJMHPPMH > 1387f && TavernZonesManager.HFHPMKJGMPA().OKDDKEKOMDM(ZoneType.RentedRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.LANAINBEMCM().ALLMAFJPLKO(ZoneType.CraftingRoom).OJLJLPLGNKD()));
			MJOPJMNBABO.VolumeOverride = 1433f;
		}
		if (MJKKJOFBCKC > 1743f && TavernZonesManager.JEEGOBGDLPE().OKDDKEKOMDM(ZoneType.WithoutZone | ZoneType.DiningRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.JEEGOBGDLPE().DNMIDKKJJEA(ZoneType.DiningRoom).NEKBEKCPJLP()));
			KHDAJIONHOE.VolumeOverride = 1519f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 384f)
			{
				MJOPJMNBABO.FadeOut(1324f, false);
				((MonoBehaviour)this).StartCoroutine(NKHMLKAMCAB(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(DMICLOOIOCJ(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 761f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 1290f)
			{
				KHDAJIONHOE.FadeOut(1741f, true);
				((MonoBehaviour)this).StartCoroutine(BCCDHAGFGJF(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(HMIOICGBPED(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 520f));
			}
		}
	}

	private void FCGJBDGOHPN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(CLIINGHHEAF));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(DOBJFJHJIHI));
		}
	}

	private void CBGPCEJFCHB()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(OGHPIABDMCB));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(JIJJKGEFNOO));
	}

	private void JMOFFCFIJOE()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(DOBJFJHJIHI));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(EHKKJCJIIAL));
	}

	public void LJCKJCKNNIP()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.SendSetAmbience(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MJKKJOFBCKC = Mathf.Lerp(48f, 1404f, Mathf.Min((float)(numberOfCustomers - 0) / 919f, 407f));
			DCDIJMHPPMH = Mathf.Lerp(1694f, 399f, Mathf.Min((float)(numberOfCustomers - 39) / 1319f, 14f));
		}
		else
		{
			DCDIJMHPPMH = 1688f;
			MJKKJOFBCKC = 1724f;
		}
		if (DCDIJMHPPMH > 542f && TavernZonesManager.IECOPNFJBFD().DNMIDKKJJEA(ZoneType.DiningRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.LANAINBEMCM().MJBJDCNCDEE(ZoneType.DiningRoom | ZoneType.CraftingRoom).NEKBEKCPJLP()));
			MJOPJMNBABO.VolumeOverride = 1213f;
		}
		if (MJKKJOFBCKC > 1752f && TavernZonesManager.OIJLJKLMCBO().OKDDKEKOMDM(ZoneType.RentedRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.EBAIHKJHCCA().GetFirstTavernZoneOfType(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom).BCPPCDILJKD()));
			KHDAJIONHOE.VolumeOverride = 1958f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1414f)
			{
				MJOPJMNBABO.FadeOut(1687f, false);
				((MonoBehaviour)this).StartCoroutine(EOLBIGDPFBD(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(NCDNFACBMBN(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 376f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 145f)
			{
				KHDAJIONHOE.FadeOut(837f, true);
				((MonoBehaviour)this).StartCoroutine(APNFLIGILKL(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(PKIIAJGHOEH(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 1210f));
			}
		}
	}

	private void DGBJJNAADCI()
	{
		IADEMLIIDPC = this;
	}

	private void OnEnable()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(SetAmbience));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(SetAmbience));
	}

	private void EIMIDCDEIDD()
	{
		IADEMLIIDPC = this;
	}

	private void MCLAJGDIIBK()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			EHKKJCJIIAL();
		}
	}

	public void EHKKJCJIIAL()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineTavernManager.instance.GBEPEHECNAH(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MJKKJOFBCKC = Mathf.Lerp(742f, 1793f, Mathf.Min((float)(numberOfCustomers - 0) / 1237f, 1994f));
			DCDIJMHPPMH = Mathf.Lerp(116f, 219f, Mathf.Min((float)(numberOfCustomers - 110) / 241f, 1540f));
		}
		else
		{
			DCDIJMHPPMH = 1265f;
			MJKKJOFBCKC = 1189f;
		}
		if (DCDIJMHPPMH > 980f && TavernZonesManager.IECOPNFJBFD().MJBJDCNCDEE(ZoneType.DiningRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.EBAIHKJHCCA().DNMIDKKJJEA(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom).KBGOOHGDADC()));
			MJOPJMNBABO.VolumeOverride = 159f;
		}
		if (MJKKJOFBCKC > 368f && TavernZonesManager.HFHPMKJGMPA().OKDDKEKOMDM(ZoneType.WithoutZone) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.IECOPNFJBFD().OKDDKEKOMDM(ZoneType.None).OJLJLPLGNKD()));
			KHDAJIONHOE.VolumeOverride = 1091f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1106f)
			{
				MJOPJMNBABO.FadeOut(1678f, false);
				((MonoBehaviour)this).StartCoroutine(ABODAOMDKDK(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(NNLHNKMPCOH(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 756f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 1290f)
			{
				KHDAJIONHOE.FadeOut(582f, true);
				((MonoBehaviour)this).StartCoroutine(AJLNKPNAFOB(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(JOIPJOGOBLF(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 1615f));
			}
		}
	}

	private IEnumerator BCBFGBIIGNM(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		ODHLEHJPGKP.VolumeOverride = IJHEMHEOJLB;
		float clipStartTime = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup - clipStartTime < CBPHLLOGJAI)
		{
			ODHLEHJPGKP.VolumeOverride = Mathf.Lerp(IJHEMHEOJLB, KEHHFCGOJGF, (Time.realtimeSinceStartup - clipStartTime) / CBPHLLOGJAI);
			yield return null;
		}
	}

	private void BFKCHCLJIPL()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(EDFKGFMMFDM));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(GDHCBEDKMLB));
	}

	public void GDHCBEDKMLB()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.IBAHKGKJHCB(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(802f, 1722f, Mathf.Min((float)(numberOfCustomers - 1) / 1255f, 1897f));
			DCDIJMHPPMH = Mathf.Lerp(957f, 1755f, Mathf.Min((float)(numberOfCustomers - -87) / 2f, 365f));
		}
		else
		{
			DCDIJMHPPMH = 1021f;
			MJKKJOFBCKC = 205f;
		}
		if (DCDIJMHPPMH > 477f && TavernZonesManager.IECOPNFJBFD().GetFirstTavernZoneOfType(ZoneType.None) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.LANAINBEMCM().OKDDKEKOMDM(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom).EFGNAHFCJAD()));
			MJOPJMNBABO.VolumeOverride = 1833f;
		}
		if (MJKKJOFBCKC > 818f && TavernZonesManager.JEEGOBGDLPE().DNMIDKKJJEA(ZoneType.WithoutZone) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.IECOPNFJBFD().ALLMAFJPLKO(ZoneType.WithoutZone | ZoneType.CraftingRoom).OJLJLPLGNKD()));
			KHDAJIONHOE.VolumeOverride = 232f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 721f)
			{
				MJOPJMNBABO.FadeOut(1280f, false);
				((MonoBehaviour)this).StartCoroutine(HONDOGFJDNM(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(DFHKNNKIFGO(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 618f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 116f)
			{
				KHDAJIONHOE.FadeOut(344f, false);
				((MonoBehaviour)this).StartCoroutine(PBDCDKHBEMK(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(NNLHNKMPCOH(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 421f));
			}
		}
	}

	private void PAHLKOCEEIH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(EEMDJHPCHGN));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(EEMDJHPCHGN));
		}
	}

	private void ECHHHBBHNLF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(KFEBCAEHCIC));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(EDFKGFMMFDM));
		}
	}

	private IEnumerator JOIPJOGOBLF(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		return new CLMAFJMHHJO(1)
		{
			source = ODHLEHJPGKP,
			startVolume = IJHEMHEOJLB,
			endVolume = KEHHFCGOJGF,
			fadeTime = CBPHLLOGJAI
		};
	}

	public void LNKHKPMNAGG()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.ECELJPIOJDP(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MJKKJOFBCKC = Mathf.Lerp(5f, 211f, Mathf.Min((float)(numberOfCustomers - 1) / 1664f, 886f));
			DCDIJMHPPMH = Mathf.Lerp(921f, 169f, Mathf.Min((float)(numberOfCustomers - -87) / 1755f, 1455f));
		}
		else
		{
			DCDIJMHPPMH = 1222f;
			MJKKJOFBCKC = 1209f;
		}
		if (DCDIJMHPPMH > 672f && TavernZonesManager.JEEGOBGDLPE().GetFirstTavernZoneOfType(ZoneType.None) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.LANAINBEMCM().DNMIDKKJJEA(ZoneType.CraftingRoom).DANEEPEJNNG()));
			MJOPJMNBABO.VolumeOverride = 400f;
		}
		if (MJKKJOFBCKC > 622f && TavernZonesManager.EBAIHKJHCCA().DNMIDKKJJEA(ZoneType.DiningRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.NHKAFANMEJC().OKDDKEKOMDM(ZoneType.None).DANEEPEJNNG()));
			KHDAJIONHOE.VolumeOverride = 1965f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1412f)
			{
				MJOPJMNBABO.FadeOut(1302f, false);
				((MonoBehaviour)this).StartCoroutine(EDKJBNKGPOJ(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(NNLHNKMPCOH(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 80f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 480f)
			{
				KHDAJIONHOE.FadeOut(184f, true);
				((MonoBehaviour)this).StartCoroutine(APNFLIGILKL(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(GCBLPLPGFCA(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 1740f));
			}
		}
	}

	private IEnumerator PKIIAJGHOEH(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		ODHLEHJPGKP.VolumeOverride = IJHEMHEOJLB;
		float clipStartTime = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup - clipStartTime < CBPHLLOGJAI)
		{
			ODHLEHJPGKP.VolumeOverride = Mathf.Lerp(IJHEMHEOJLB, KEHHFCGOJGF, (Time.realtimeSinceStartup - clipStartTime) / CBPHLLOGJAI);
			yield return null;
		}
	}

	private IEnumerator LIHDFEPDAHJ(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	private void PKPHKBMPJGJ()
	{
		IADEMLIIDPC = this;
	}

	private void KAANJGEDPIN()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnCustomerEnterTavern = (Action)Delegate.Combine(instance.OnCustomerEnterTavern, new Action(GHIPLNECJIA));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnCustomerLeaveTavern = (Action)Delegate.Combine(instance2.OnCustomerLeaveTavern, new Action(CLIINGHHEAF));
	}

	private void HBLJGDLKMOD()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			EEMDJHPCHGN();
		}
	}

	private IEnumerator DMICLOOIOCJ(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		ODHLEHJPGKP.VolumeOverride = IJHEMHEOJLB;
		float clipStartTime = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup - clipStartTime < CBPHLLOGJAI)
		{
			ODHLEHJPGKP.VolumeOverride = Mathf.Lerp(IJHEMHEOJLB, KEHHFCGOJGF, (Time.realtimeSinceStartup - clipStartTime) / CBPHLLOGJAI);
			yield return null;
		}
	}

	private void GOFJCKGJHJO()
	{
		IADEMLIIDPC = this;
	}

	private IEnumerator CDPMLOJKEHE(MultiAudioSource ODHLEHJPGKP)
	{
		return new HEICPJFONLK(1)
		{
			source = ODHLEHJPGKP
		};
	}

	private IEnumerator CHKKHPPPAMI(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	private void JMAHDPMEEHM()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(OHCNPKIJCOK));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(EEMDJHPCHGN));
		}
	}

	private void CACPOGPOKOJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(IPKFGPAOCLK));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(DOBJFJHJIHI));
		}
	}

	[SpecialName]
	public static TavernAmbienceController HEKFJEKFMNO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	public void EEMDJHPCHGN()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineTavernManager.instance.KFIEEOFDAFD(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MJKKJOFBCKC = Mathf.Lerp(1328f, 779f, Mathf.Min((float)(numberOfCustomers - 1) / 20f, 205f));
			DCDIJMHPPMH = Mathf.Lerp(513f, 647f, Mathf.Min((float)(numberOfCustomers - 61) / 527f, 39f));
		}
		else
		{
			DCDIJMHPPMH = 959f;
			MJKKJOFBCKC = 1276f;
		}
		if (DCDIJMHPPMH > 1086f && TavernZonesManager.OIJLJKLMCBO().MJBJDCNCDEE(ZoneType.WithoutZone | ZoneType.DiningRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.HFHPMKJGMPA().GetFirstTavernZoneOfType(ZoneType.WithoutZone).CKBDPPMPGNJ()));
			MJOPJMNBABO.VolumeOverride = 434f;
		}
		if (MJKKJOFBCKC > 1024f && TavernZonesManager.GGFJGHHHEJC.ALLMAFJPLKO(ZoneType.WithoutZone | ZoneType.CraftingRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.GGFJGHHHEJC.OKDDKEKOMDM(ZoneType.DiningRoom | ZoneType.CraftingRoom).BCPPCDILJKD()));
			KHDAJIONHOE.VolumeOverride = 508f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1323f)
			{
				MJOPJMNBABO.FadeOut(504f, true);
				((MonoBehaviour)this).StartCoroutine(ICNKDOJKJOO(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(ENBHFHDMKNM(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 128f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 330f)
			{
				KHDAJIONHOE.FadeOut(1181f, true);
				((MonoBehaviour)this).StartCoroutine(APNFLIGILKL(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(GCBLPLPGFCA(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 1455f));
			}
		}
	}

	private void PHLLBPLOLFO()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			GHIPLNECJIA();
		}
	}

	private void AMBJKHAFAFF()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			SetAmbience();
		}
	}

	private void JIAJFDKNJME()
	{
		IADEMLIIDPC = this;
	}

	private void OCDECHJNNCD()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnCustomerEnterTavern = (Action)Delegate.Remove(instance.OnCustomerEnterTavern, new Action(EGOANIIBGJK));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnCustomerLeaveTavern = (Action)Delegate.Remove(instance2.OnCustomerLeaveTavern, new Action(OHCNPKIJCOK));
		}
	}

	private void OCJOAHDNDIJ()
	{
		IADEMLIIDPC = this;
	}

	private void Update()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			SetAmbience();
		}
	}

	private IEnumerator DFHKNNKIFGO(MultiAudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI)
	{
		return new CLMAFJMHHJO(1)
		{
			source = ODHLEHJPGKP,
			startVolume = IJHEMHEOJLB,
			endVolume = KEHHFCGOJGF,
			fadeTime = CBPHLLOGJAI
		};
	}

	[SpecialName]
	public static TavernAmbienceController OMFKNGDCJFN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernAmbienceController>();
		}
		return IADEMLIIDPC;
	}

	private void GFLFDLIMOLI()
	{
		IADEMLIIDPC = this;
	}

	private void MFIBFFDBNGI()
	{
		if ((Object.op_Implicit((Object)(object)MJOPJMNBABO) || Object.op_Implicit((Object)(object)KHDAJIONHOE)) && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			GDHCBEDKMLB();
		}
	}

	private IEnumerator MMMHMGMFOBL(MultiAudioSource ODHLEHJPGKP)
	{
		yield return CommonReferences.wait5;
		ODHLEHJPGKP.Stop(false);
	}

	public void OGHPIABDMCB()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			numberOfCustomers = TavernManager.GGFJGHHHEJC.customers.Count;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.IBAHKGKJHCB(numberOfCustomers);
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MJKKJOFBCKC = Mathf.Lerp(1741f, 903f, Mathf.Min((float)(numberOfCustomers - 0) / 1100f, 1381f));
			DCDIJMHPPMH = Mathf.Lerp(423f, 1820f, Mathf.Min((float)(numberOfCustomers - 85) / 1569f, 1382f));
		}
		else
		{
			DCDIJMHPPMH = 1756f;
			MJKKJOFBCKC = 80f;
		}
		if (DCDIJMHPPMH > 6f && TavernZonesManager.GGFJGHHHEJC.OKDDKEKOMDM(ZoneType.CraftingRoom) != null && (Object)(object)MJOPJMNBABO == (Object)null)
		{
			MJOPJMNBABO = MultiAudioManager.PlayAudioObject(crowd, Vector2.op_Implicit(TavernZonesManager.LANAINBEMCM().DNMIDKKJJEA(ZoneType.WithoutZone | ZoneType.DiningRoom).DANEEPEJNNG()));
			MJOPJMNBABO.VolumeOverride = 687f;
		}
		if (MJKKJOFBCKC > 1445f && TavernZonesManager.JEEGOBGDLPE().DNMIDKKJJEA(ZoneType.DiningRoom | ZoneType.CraftingRoom) != null && (Object)(object)KHDAJIONHOE == (Object)null)
		{
			KHDAJIONHOE = MultiAudioManager.PlayAudioObject(smallCrowd, Vector2.op_Implicit(TavernZonesManager.NHKAFANMEJC().ALLMAFJPLKO(ZoneType.WithoutZone | ZoneType.DiningRoom).EFGNAHFCJAD()));
			KHDAJIONHOE.VolumeOverride = 1009f;
		}
		if (Object.op_Implicit((Object)(object)MJOPJMNBABO))
		{
			if (DMMMMNEJLOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(DMMMMNEJLOJ);
			}
			if (DCDIJMHPPMH <= 1097f)
			{
				MJOPJMNBABO.FadeOut(1041f, true);
				((MonoBehaviour)this).StartCoroutine(JJELNPPFIAN(MJOPJMNBABO));
				MJOPJMNBABO = null;
			}
			else
			{
				DMMMMNEJLOJ = ((MonoBehaviour)this).StartCoroutine(DMICLOOIOCJ(MJOPJMNBABO, MJOPJMNBABO.VolumeOverride, DCDIJMHPPMH, 1581f));
			}
		}
		if (Object.op_Implicit((Object)(object)KHDAJIONHOE))
		{
			if (CBLCBMEGNII != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBLCBMEGNII);
			}
			if (MJKKJOFBCKC <= 104f)
			{
				KHDAJIONHOE.FadeOut(242f, true);
				((MonoBehaviour)this).StartCoroutine(JPNLIDPOCOF(KHDAJIONHOE));
				KHDAJIONHOE = null;
			}
			else
			{
				CBLCBMEGNII = ((MonoBehaviour)this).StartCoroutine(BCBFGBIIGNM(KHDAJIONHOE, KHDAJIONHOE.VolumeOverride, MJKKJOFBCKC, 1757f));
			}
		}
	}
}
