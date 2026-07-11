using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActivateOnOnline : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class FCEPBCPGDKJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActivateOnOnline _003C_003E4__this;

		public bool value;

		public bool _tutorialDoor;

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
		public FCEPBCPGDKJ(int _003C_003E1__state)
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
			ActivateOnOnline activateOnOnline = _003C_003E4__this;
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
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				activateOnOnline.ActivateOrDeactivate(value, _tutorialDoor);
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

	public GameObject[] toEnable;

	public GameObject[] toDisable;

	public GameObject tutorialDoor;

	private void CLIIABIEEOC()
	{
		EMLBINJPPNK(AODONKKHPBP: false, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(BJCBMGGBNJG(AODONKKHPBP: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(HFBLKCEICEI));
	}

	public void BNJNPPNCCEJ(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && !MissionsManager.instance.LLOBLPDJNJE(163) && NCCKMIDHPCG)
		{
			Debug.Log((object)"ReceiveSetLife");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(false);
			toEnable[0].SetActive(false);
			toEnable[1].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Null shop in database: ");
			tutorialDoor.SetActive(true);
		}
	}

	private void IAAGKLPMAMK()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(HFBLKCEICEI));
	}

	public IEnumerator FLDNGFJILCG(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void GLLMDGIIPBB()
	{
		COKHNCLCDBE(AODONKKHPBP: false);
		((MonoBehaviour)this).StartCoroutine(MNAPCCJAHFP(AODONKKHPBP: true));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(LGOAKJGBMCG));
	}

	public void ONBCGHJNKJB(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || !MissionsManager.instance.IsMissionComplete(-17)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Name: ");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[1].SetActive(false);
			toEnable[7].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"ordersDelivered");
			tutorialDoor.SetActive(true);
		}
	}

	public IEnumerator BJCBMGGBNJG(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void CGLIGKKCKCG()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(NHLCIOKDMJD));
	}

	public void FBPPCMCLCGF(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && !MissionsManager.instance.IsMissionComplete(-24) && NCCKMIDHPCG)
		{
			Debug.Log((object)"ReceiveAddMoney");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(false);
			toEnable[0].SetActive(true);
			toEnable[1].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"ReceiveCastleFormStartLucenDialogue");
			tutorialDoor.SetActive(true);
		}
	}

	public IEnumerator CIGKILCOBJM(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	public IEnumerator OJNAIEJLMHP(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	public void AHKNKAEDMKL(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || !MissionsManager.instance.LLOBLPDJNJE(166)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Mai/Talk{0}");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[1].SetActive(false);
			toEnable[4].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Tavern must be closed");
			tutorialDoor.SetActive(false);
		}
	}

	public void PBAKNMHJKGM(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && MissionsManager.instance.IsMissionComplete(104) && NCCKMIDHPCG)
		{
			Debug.Log((object)"<br>");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(false);
			toEnable[0].SetActive(false);
			toEnable[6].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"UISelectGamepad");
			tutorialDoor.SetActive(false);
		}
	}

	private void FPDPAJHNGHK()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(MMIPBHNJLOH));
	}

	public void DNKCKGIAGKH(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || MissionsManager.instance.BMFOFINGDLK(39)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Bouncer");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[0].SetActive(false);
			toEnable[2].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"ReceiveBasics");
			tutorialDoor.SetActive(false);
		}
	}

	private void CCMCMODEBKL()
	{
		CBJBFMCIPKJ(AODONKKHPBP: false, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(MKNLKLJBNAF(AODONKKHPBP: true));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
	}

	private void NLFHFPHDNCF()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(IBBMBCHLGMD));
	}

	public void PNHHPCBFOCG(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && MissionsManager.instance.LLOBLPDJNJE(122) && NCCKMIDHPCG)
		{
			Debug.Log((object)"ReceiveObjects");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(false);
			toEnable[1].SetActive(false);
			toEnable[5].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Fireplace not attached on OnlineFireplace of placeable ");
			tutorialDoor.SetActive(true);
		}
	}

	public void MGHFFBKFGHK(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && MissionsManager.instance.BMFOFINGDLK(138) && NCCKMIDHPCG)
		{
			Debug.Log((object)"CanBePlanted");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(true);
			toEnable[0].SetActive(false);
			toEnable[0].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"add item ");
			tutorialDoor.SetActive(false);
		}
	}

	private void EBNKNEIDDDI()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(NEMBDGGDPKN));
	}

	private void MAOJJPECDAG()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(LGOAKJGBMCG));
	}

	private void NNBIAIMPNGL()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(CLIIABIEEOC));
	}

	public void GIDALAPIDEA(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || !MissionsManager.instance.BMFOFINGDLK(-181)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Bucket");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(true);
			toEnable[1].SetActive(false);
			toEnable[8].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"ReceiveEggIncrement");
			tutorialDoor.SetActive(false);
		}
	}

	public IEnumerator PKDGDHPNFGO(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	public void CIPPDGCPCMF(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || MissionsManager.instance.BMFOFINGDLK(-175)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"<sprite name=\"woodIcon\">");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[1].SetActive(true);
			toEnable[4].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"dirty info");
			tutorialDoor.SetActive(true);
		}
	}

	public IEnumerator BBPBEAECLKN(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	private void GNJHFMOIFAK()
	{
		ONBCGHJNKJB(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(LDDKJLFJGNI(AODONKKHPBP: false, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(IDHCLDEEHJN));
	}

	private void IBBMBCHLGMD()
	{
		CIONOAICBAE(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(NEGJIANLDEF(AODONKKHPBP: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(FFMCHLIDCHD));
	}

	public IEnumerator OMJLHGMMBDL(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	private void ODNGBEOKEFK()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(LGOAKJGBMCG));
	}

	public void BBJCMAEOCID(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && !MissionsManager.instance.BMFOFINGDLK(-97) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Eyebrows");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(false);
			toEnable[0].SetActive(false);
			toEnable[4].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"BarIdleNumber");
			tutorialDoor.SetActive(true);
		}
	}

	public IEnumerator GCJNBPGAJGD(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	public IEnumerator LHCAEMIBIGC(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	private void KGPOCJEHHHH()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(LGOAKJGBMCG));
	}

	public IEnumerator IJODHGPCHDJ(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void HOKAPOOCJCC()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(JDGHNGBMOGM));
	}

	private void DHOCKOBHAOH()
	{
		CELPPJMBFCI(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(IJHNBDCGKBC(AODONKKHPBP: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NHLCIOKDMJD));
	}

	public IEnumerator MKNLKLJBNAF(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void JPOLFKMLHNH()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(OFCKBEFGJCD));
	}

	private void GCPOLHOADCK()
	{
		AKCEOAMGFHI(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(OMJLHGMMBDL(AODONKKHPBP: true, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(ADDDNMHODIK));
	}

	public IEnumerator DFDJPKEGLKA(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	public void HEOPIMHFDMA(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && !MissionsManager.instance.BMFOFINGDLK(104) && NCCKMIDHPCG)
		{
			Debug.Log((object)"FinalTest/MainEvent");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(true);
			toEnable[1].SetActive(false);
			toEnable[8].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Error_CloseMenus");
			tutorialDoor.SetActive(true);
		}
	}

	private void LGOAKJGBMCG()
	{
		BBJCMAEOCID(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(PKDGDHPNFGO(AODONKKHPBP: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NDIDJFEEEPO));
	}

	public IEnumerator CPLKNFLFENA(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void JDGHNGBMOGM()
	{
		CIONOAICBAE(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(CNCGBNMGJLE(AODONKKHPBP: true));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(HEDINFOGKKP));
	}

	public IEnumerator HHHFFNACPIL(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	public IEnumerator NEGJIANLDEF(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	public void NBLCMLPGILA(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || !MissionsManager.instance.IsMissionComplete(-16)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Items/item_name_1141");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[1].SetActive(true);
			toEnable[4].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Select");
			tutorialDoor.SetActive(false);
		}
	}

	private void HEDINFOGKKP()
	{
		HEOPIMHFDMA(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(LAOPIBDBMLL(AODONKKHPBP: false, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NEMBDGGDPKN));
	}

	private void LANGHIOBJIH()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(GCPOLHOADCK));
	}

	private void MLNDHCBBFGB()
	{
		OFFGLGHKPDA(AODONKKHPBP: false, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(NIHJAFOIJEI(AODONKKHPBP: true, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(IBBMBCHLGMD));
	}

	public IEnumerator CJICHDPIAIK(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	private void JPMFAEMADHC()
	{
		ONBCGHJNKJB(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(MJKCMGNOGHN(AODONKKHPBP: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(FNFDIMJONCH));
	}

	private void IJIKHGBDECE()
	{
		NDMNDPPAOCJ(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(LAOPIBDBMLL(AODONKKHPBP: true, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(PDONILMHKIC));
	}

	public IEnumerator HECNCEJBCNG(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void PGAOOIJJMME()
	{
		OFFGLGHKPDA(AODONKKHPBP: false);
		((MonoBehaviour)this).StartCoroutine(GCJNBPGAJGD(AODONKKHPBP: false, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(GLLMDGIIPBB));
	}

	public IEnumerator LAOPIBDBMLL(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	public void KONJIGFFEMN(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && MissionsManager.instance.IsMissionComplete(-165) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Error_NoCatFood");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[1].SetActive(false);
			toEnable[4].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Player");
			tutorialDoor.SetActive(true);
		}
	}

	public void OFFGLGHKPDA(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && MissionsManager.instance.IsMissionComplete(-175) && NCCKMIDHPCG)
		{
			Debug.Log((object)"SendNPCDirection");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[0].SetActive(false);
			toEnable[6].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"ReceiveUpdateContentsRoom");
			tutorialDoor.SetActive(true);
		}
	}

	private void HJDPMDDOGEG()
	{
		HEOPIMHFDMA(AODONKKHPBP: false, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(OMJLHGMMBDL(AODONKKHPBP: false, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(HABGLBIJINF));
	}

	public void PPHDLGOGEBH(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && MissionsManager.instance.BMFOFINGDLK(13) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Error in DialogueNPCBase.EndConversation: ");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(false);
			toEnable[1].SetActive(false);
			toEnable[3].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"/");
			tutorialDoor.SetActive(false);
		}
	}

	private void FEDJBKOEEME()
	{
		CELPPJMBFCI(AODONKKHPBP: false, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(HHHFFNACPIL(AODONKKHPBP: true, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(PDONILMHKIC));
	}

	public void CPFKKNGOIIJ(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && !MissionsManager.instance.LLOBLPDJNJE(-135) && NCCKMIDHPCG)
		{
			Debug.Log((object)"SetSnapshot Location: ");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[1].SetActive(true);
			toEnable[6].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"questNameFermenting");
			tutorialDoor.SetActive(false);
		}
	}

	public void KHKEALBPEFH(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || !MissionsManager.instance.LLOBLPDJNJE(-133)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Level ");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(false);
			toEnable[1].SetActive(false);
			toEnable[3].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Error in StaffManager.StaffInstantGoHome: ");
			tutorialDoor.SetActive(false);
		}
	}

	private void OIBDBLCLACB()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(CCMCMODEBKL));
	}

	public IEnumerator LDDKJLFJGNI(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	private void HFMJPMEALMO()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(IJIKHGBDECE));
	}

	private void HNEGFBCKIIJ()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(ALAICDGMIAE));
	}

	public IEnumerator GPMHJIDPCLO(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void FNFDIMJONCH()
	{
		KEOKBGMMCHN(AODONKKHPBP: false, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(PKDGDHPNFGO(AODONKKHPBP: true));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NHLCIOKDMJD));
	}

	public void KEOKBGMMCHN(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || MissionsManager.instance.LLOBLPDJNJE(85)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"UpgradeToLevel");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(false);
			toEnable[0].SetActive(true);
			toEnable[8].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Correo Enviado. Tiempo: ");
			tutorialDoor.SetActive(true);
		}
	}

	private void AKPKLFJACCJ()
	{
		FBPPCMCLCGF(AODONKKHPBP: false, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(OJHLFMFDDNK(AODONKKHPBP: false, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NEMBDGGDPKN));
	}

	private void OKAPGNGLOHO()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(IDHCLDEEHJN));
	}

	public void ActivateOrDeactivate(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && !MissionsManager.instance.IsMissionComplete(301) && NCCKMIDHPCG)
		{
			Debug.Log((object)"ActiveMultiDoor");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(false);
			toEnable[1].SetActive(false);
			toEnable[2].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"NoActiveMultiDoor");
			tutorialDoor.SetActive(false);
		}
	}

	public void COKHNCLCDBE(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || MissionsManager.instance.IsMissionComplete(34)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"[ControllerType");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(false);
			toEnable[0].SetActive(false);
			toEnable[7].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Fortitude/MainEvent 5");
			tutorialDoor.SetActive(false);
		}
	}

	private void ADDDNMHODIK()
	{
		GIDALAPIDEA(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(OKDBONEDMHI(AODONKKHPBP: true, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NDIDJFEEEPO));
	}

	public IEnumerator OAJJINPJBFG(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	public IEnumerator MMHKLPAKPCG(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	public void GAPJFPOFGID(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || !MissionsManager.instance.LLOBLPDJNJE(-133)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Thurs");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(false);
			toEnable[1].SetActive(false);
			toEnable[3].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Dynamic Intensity:");
			tutorialDoor.SetActive(false);
		}
	}

	public IEnumerator IJHNBDCGKBC(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	public IEnumerator DMECGNINPCO(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void BELOIFKPNMM()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(DHOCKOBHAOH));
	}

	public void CBJBFMCIPKJ(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || MissionsManager.instance.BMFOFINGDLK(28)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Steam Lobby received on launch command: {0}");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(false);
			toEnable[1].SetActive(false);
			toEnable[2].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"ReceiveHeldItem");
			tutorialDoor.SetActive(false);
		}
	}

	private void FPGCDCIFONG()
	{
		ActivateOrDeactivate(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(CheckActivateOrDeactivate(AODONKKHPBP: true));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
	}

	private void MHNPMAGLOPI()
	{
		OFFGLGHKPDA(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(DHOMOHDCMMO(AODONKKHPBP: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(DHOCKOBHAOH));
	}

	public IEnumerator AEMBGCAKEFK(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	public void CELPPJMBFCI(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || MissionsManager.instance.IsMissionComplete(-47)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"[WaiterGender=");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(true);
			toEnable[0].SetActive(false);
			toEnable[8].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"\n<color=#BF0000>");
			tutorialDoor.SetActive(false);
		}
	}

	private void OFCKBEFGJCD()
	{
		CBJBFMCIPKJ(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(GCJNBPGAJGD(AODONKKHPBP: true));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(MMIPBHNJLOH));
	}

	public IEnumerator MJKCMGNOGHN(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void ICANNGIPKCD()
	{
		BHKDKILOJCD(AODONKKHPBP: false);
		((MonoBehaviour)this).StartCoroutine(BBPBEAECLKN(AODONKKHPBP: false, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(ALAICDGMIAE));
	}

	public IEnumerator DBIMHNDJLPN(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void NDIDJFEEEPO()
	{
		FBPPCMCLCGF(AODONKKHPBP: false, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(MMHKLPAKPCG(AODONKKHPBP: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NDIDJFEEEPO));
	}

	private void JPHEOLEEAPB()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(NDIDJFEEEPO));
	}

	private void PLHPEMNDAFB()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(FNFDIMJONCH));
	}

	public IEnumerator PJBDNHKODPF(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void DAEJLBJDEIM()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(OFCKBEFGJCD));
	}

	private void MMIPBHNJLOH()
	{
		ActivateOrDeactivate(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(DFDJPKEGLKA(AODONKKHPBP: true, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(HJDPMDDOGEG));
	}

	public void NDMNDPPAOCJ(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || MissionsManager.instance.IsMissionComplete(-46)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Error in ProceduralMine.OnPlayerSleep: ");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[1].SetActive(false);
			toEnable[3].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)", ");
			tutorialDoor.SetActive(false);
		}
	}

	public void OBDECOLELAE(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || !MissionsManager.instance.LLOBLPDJNJE(119)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Pause");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(false);
			toEnable[0].SetActive(true);
			toEnable[3].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Hot");
			tutorialDoor.SetActive(false);
		}
	}

	public IEnumerator DHOMOHDCMMO(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void NEMBDGGDPKN()
	{
		EMLBINJPPNK(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(JJIHLBCFPAP(AODONKKHPBP: true, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(JPMFAEMADHC));
	}

	private void JLCFNPBBKEK()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(HJDPMDDOGEG));
	}

	private void EOGHJNGJFID()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(IJIKHGBDECE));
	}

	private void FFMCHLIDCHD()
	{
		GKIDGCIEDOI(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(PJBDNHKODPF(AODONKKHPBP: true));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(CLIIABIEEOC));
	}

	public IEnumerator OKDBONEDMHI(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	public IEnumerator MNAPCCJAHFP(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	public IEnumerator JIMGHOOELHM(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	private void NHLCIOKDMJD()
	{
		HEOPIMHFDMA(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(MJKCMGNOGHN(AODONKKHPBP: true));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(ICCEOHMHACF));
	}

	private void HFBLKCEICEI()
	{
		AHKNKAEDMKL(AODONKKHPBP: false);
		((MonoBehaviour)this).StartCoroutine(CheckActivateOrDeactivate(AODONKKHPBP: true));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(LGOAKJGBMCG));
	}

	public IEnumerator PBAPFLILGOA(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	private void ICCEOHMHACF()
	{
		BHKDKILOJCD(AODONKKHPBP: false);
		((MonoBehaviour)this).StartCoroutine(GCJNBPGAJGD(AODONKKHPBP: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
	}

	private void IDHCLDEEHJN()
	{
		AKCEOAMGFHI(AODONKKHPBP: false);
		((MonoBehaviour)this).StartCoroutine(DBIMHNDJLPN(AODONKKHPBP: false, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
	}

	public IEnumerator JJIHLBCFPAP(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	public void CIONOAICBAE(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || !MissionsManager.instance.IsMissionComplete(-32)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Key2");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(false);
			toEnable[0].SetActive(true);
			toEnable[3].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"talentPeppers");
			tutorialDoor.SetActive(false);
		}
	}

	private void FJDOHKDOLKC()
	{
		GIDALAPIDEA(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(AEMBGCAKEFK(AODONKKHPBP: true));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(DHOCKOBHAOH));
	}

	private void IIDPFCKPCDC()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(GLLMDGIIPBB));
	}

	private void ALAICDGMIAE()
	{
		EMOJOOIEDHP(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(IJHNBDCGKBC(AODONKKHPBP: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(CCMCMODEBKL));
	}

	private void PFIFBJCAHMD()
	{
		KEOKBGMMCHN(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(CPLKNFLFENA(AODONKKHPBP: false, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(PGAOOIJJMME));
	}

	public void EMOJOOIEDHP(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && !MissionsManager.instance.BMFOFINGDLK(-14) && NCCKMIDHPCG)
		{
			Debug.Log((object)"LE_10");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[0].SetActive(false);
			toEnable[7].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"AsyncLoaders");
			tutorialDoor.SetActive(true);
		}
	}

	private void GGOOGHGHNJI()
	{
		BNJNPPNCCEJ(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(CNCGBNMGJLE(AODONKKHPBP: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(PFIFBJCAHMD));
	}

	public void EMLBINJPPNK(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || MissionsManager.instance.LLOBLPDJNJE(155)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Listen");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(false);
			toEnable[0].SetActive(true);
			toEnable[7].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Collect");
			tutorialDoor.SetActive(true);
		}
	}

	private void DAJBODPOKIP()
	{
		BBJCMAEOCID(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(MNAPCCJAHFP(AODONKKHPBP: true, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(IDHCLDEEHJN));
	}

	private void NDGFPPOBCNP()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(IJIKHGBDECE));
	}

	private void ICFHPJHBPDN()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(MLNDHCBBFGB));
	}

	private void GBFPCABGAII()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(GGOOGHGHNJI));
	}

	public IEnumerator OJHLFMFDDNK(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		return new FCEPBCPGDKJ(1)
		{
			_003C_003E4__this = this,
			value = AODONKKHPBP,
			_tutorialDoor = NCCKMIDHPCG
		};
	}

	private void HABGLBIJINF()
	{
		AHDNAOCHEDL(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(NEGJIANLDEF(AODONKKHPBP: true, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(GGOOGHGHNJI));
	}

	private void FKBKKHFOIEP()
	{
		NDMNDPPAOCJ(AODONKKHPBP: true);
		((MonoBehaviour)this).StartCoroutine(OAJJINPJBFG(AODONKKHPBP: true));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(JPMFAEMADHC));
	}

	public IEnumerator NIHJAFOIJEI(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	public void AHDNAOCHEDL(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || !MissionsManager.instance.LLOBLPDJNJE(-181)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"City/PetShop/Nessy/Intro2");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[1].SetActive(false);
			toEnable[3].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"East");
			tutorialDoor.SetActive(false);
		}
	}

	public void BDKDFPLIJKK(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || MissionsManager.instance.IsMissionComplete(109)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Disabled");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(false);
			toEnable[1].SetActive(false);
			toEnable[3].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"questNameMalting");
			tutorialDoor.SetActive(true);
		}
	}

	private void HCEDMLJNOBL()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(MHNPMAGLOPI));
	}

	private void OIDCKGOCGKB()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(IJIKHGBDECE));
	}

	public void BHKDKILOJCD(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || !MissionsManager.instance.BMFOFINGDLK(196)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"CutSceneMode/ButtonConfigure");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(false);
			toEnable[1].SetActive(false);
			toEnable[8].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"BarIdleNumber");
			tutorialDoor.SetActive(false);
		}
	}

	public void NPMOMDFJEPA(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((Object)(object)tutorialDoor != (Object)null && !MissionsManager.instance.BMFOFINGDLK(-173) && NCCKMIDHPCG)
		{
			Debug.Log((object)"");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(true);
			toEnable[1].SetActive(false);
			toEnable[5].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Items/item_description_647");
			tutorialDoor.SetActive(true);
		}
	}

	private void OLDDEAJMHNI()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(NHLCIOKDMJD));
	}

	public IEnumerator GHHFJBGKPNE(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void PDONILMHKIC()
	{
		PNHHPCBFOCG(AODONKKHPBP: false);
		((MonoBehaviour)this).StartCoroutine(NIHJAFOIJEI(AODONKKHPBP: true, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
	}

	private void KILDJCPLOPP()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(FKBKKHFOIEP));
	}

	public void GKIDGCIEDOI(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(!AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || MissionsManager.instance.LLOBLPDJNJE(-171)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"Error_OccupiedRoom");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[1].SetActive(false);
			toEnable[1].SetActive(false);
			toEnable[0].SetActive(false);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"Not ready to create room");
			tutorialDoor.SetActive(true);
		}
	}

	private void Start()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
	}

	public IEnumerator CheckActivateOrDeactivate(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}

	private void HEOJEJGBDCA()
	{
		NBLCMLPGILA(AODONKKHPBP: true, NCCKMIDHPCG: false);
		((MonoBehaviour)this).StartCoroutine(LAOPIBDBMLL(AODONKKHPBP: true, NCCKMIDHPCG: false));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(MMIPBHNJLOH));
	}

	public void AKCEOAMGFHI(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(AODONKKHPBP);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(AODONKKHPBP);
		}
		if ((!((Object)(object)tutorialDoor != (Object)null) || !MissionsManager.instance.IsMissionComplete(159)) && NCCKMIDHPCG)
		{
			Debug.Log((object)"DontWalk");
			tutorialDoor.SetActive(AODONKKHPBP);
			toEnable[0].SetActive(false);
			toEnable[0].SetActive(false);
			toEnable[5].SetActive(true);
		}
		else if ((Object)(object)tutorialDoor != (Object)null)
		{
			Debug.Log((object)"ReceiveProgressQuestInfo");
			tutorialDoor.SetActive(false);
		}
	}

	public IEnumerator CNCGBNMGJLE(bool AODONKKHPBP, bool NCCKMIDHPCG = true)
	{
		yield return null;
		yield return CommonReferences.wait2;
		yield return null;
		ActivateOrDeactivate(AODONKKHPBP, NCCKMIDHPCG);
	}
}
