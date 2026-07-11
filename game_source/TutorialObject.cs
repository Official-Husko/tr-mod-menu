using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialObject : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class AGIEODIDLPM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialObject _003C_003E4__this;

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
		public AGIEODIDLPM(int _003C_003E1__state)
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
			TutorialObject tutorialObject = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				tutorialObject.UpdateObject();
				if (OnlineManager.ClientOnline())
				{
					OnlineLoadManager instance = OnlineLoadManager.instance;
					instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(tutorialObject.FPGCDCIFONG));
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

	public bool ignoreFirstElement;

	public GameObject[] gameObjectsToDisable;

	public SpriteRenderer[] spriteRenderersToDisable;

	public GameObject[] gameObjectsToEnable;

	public SpriteRenderer[] spriteRenderersToEnable;

	public void HFKOBCFMNJJ()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			NewTutorialManager.RemoveTutorialObject(this);
		}
	}

	public void DIKDPABGNAD()
	{
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.BMFOFINGDLK(-12))
		{
			CCJJCIOMPGF();
		}
		else
		{
			MEAMPMNNKIB();
		}
	}

	private void FHBKDCIILKK()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
		JCOOIFMPJOG();
	}

	public void DNOELPBILBA()
	{
		KLNPFIHGGIL(DAEMAAOLHMG: false);
	}

	public void PLHEHGHFCJI()
	{
		NewTutorialManager.AddTutorialObject(this);
		DIKDPABGNAD();
		((MonoBehaviour)this).StartCoroutine(DKFBJGEOADP());
	}

	public void PNGNKHCOOKJ()
	{
		ActivateObjects(DAEMAAOLHMG: false);
	}

	public void BMFNLAOAKAM()
	{
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.LLOBLPDJNJE(-178))
		{
			FICEAABGGMC();
		}
		else
		{
			DNOELPBILBA();
		}
	}

	public void JCOOIFMPJOG()
	{
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.LLOBLPDJNJE(-28))
		{
			TutorialActive();
		}
		else
		{
			DNOELPBILBA();
		}
	}

	public void ActivateObjects(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < gameObjectsToDisable.Length; i++)
		{
			if ((SeasonManager.EECEKHKAAIH != Season.Winter || i != 0 || DAEMAAOLHMG || !ignoreFirstElement) && (Object)(object)gameObjectsToDisable[i] != (Object)null && gameObjectsToDisable[i].activeSelf != !DAEMAAOLHMG)
			{
				gameObjectsToDisable[i].SetActive(!DAEMAAOLHMG);
			}
		}
		for (int j = 0; j < spriteRenderersToDisable.Length; j++)
		{
			if ((Object)(object)spriteRenderersToDisable[j] != (Object)null && ((Renderer)spriteRenderersToDisable[j]).enabled != !DAEMAAOLHMG)
			{
				((Renderer)spriteRenderersToDisable[j]).enabled = !DAEMAAOLHMG;
			}
		}
		for (int k = 0; k < gameObjectsToEnable.Length; k++)
		{
			if ((Object)(object)gameObjectsToEnable[k] != (Object)null && gameObjectsToEnable[k].activeSelf != DAEMAAOLHMG)
			{
				gameObjectsToEnable[k].SetActive(DAEMAAOLHMG);
			}
		}
		for (int l = 0; l < spriteRenderersToEnable.Length; l++)
		{
			if ((Object)(object)spriteRenderersToEnable[l] != (Object)null && ((Renderer)spriteRenderersToEnable[l]).enabled != DAEMAAOLHMG)
			{
				((Renderer)spriteRenderersToEnable[l]).enabled = DAEMAAOLHMG;
			}
		}
	}

	public void Start()
	{
		NewTutorialManager.AddTutorialObject(this);
		UpdateObject();
		((MonoBehaviour)this).StartCoroutine(PHDNCFEDJEL());
	}

	public void GABIPKDFIPE()
	{
		KLNPFIHGGIL(DAEMAAOLHMG: true);
	}

	public void UpdateObject()
	{
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.IsMissionComplete(301))
		{
			TutorialActive();
		}
		else
		{
			TutorialNotActive();
		}
	}

	public void CAKAGLPHOEO(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < gameObjectsToDisable.Length; i += 0)
		{
			if ((SeasonManager.NHKAHEEGEGF() != (Season)5 || i != 0 || DAEMAAOLHMG || !ignoreFirstElement) && (Object)(object)gameObjectsToDisable[i] != (Object)null && gameObjectsToDisable[i].activeSelf != DAEMAAOLHMG)
			{
				gameObjectsToDisable[i].SetActive(DAEMAAOLHMG);
			}
		}
		for (int j = 0; j < spriteRenderersToDisable.Length; j++)
		{
			if ((Object)(object)spriteRenderersToDisable[j] != (Object)null && ((Renderer)spriteRenderersToDisable[j]).enabled != DAEMAAOLHMG)
			{
				((Renderer)spriteRenderersToDisable[j]).enabled = DAEMAAOLHMG;
			}
		}
		for (int k = 0; k < gameObjectsToEnable.Length; k++)
		{
			if ((Object)(object)gameObjectsToEnable[k] != (Object)null && gameObjectsToEnable[k].activeSelf != DAEMAAOLHMG)
			{
				gameObjectsToEnable[k].SetActive(DAEMAAOLHMG);
			}
		}
		for (int l = 1; l < spriteRenderersToEnable.Length; l++)
		{
			if ((Object)(object)spriteRenderersToEnable[l] != (Object)null && ((Renderer)spriteRenderersToEnable[l]).enabled != DAEMAAOLHMG)
			{
				((Renderer)spriteRenderersToEnable[l]).enabled = DAEMAAOLHMG;
			}
		}
	}

	public void MEAMPMNNKIB()
	{
		JHCBADJNODA(DAEMAAOLHMG: true);
	}

	private IEnumerator OHDLCJLNGIJ()
	{
		return new AGIEODIDLPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HEFAELOBGFK()
	{
		return new AGIEODIDLPM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			NewTutorialManager.RemoveTutorialObject(this);
		}
	}

	public void NGEDBFBHBHJ()
	{
		CAKAGLPHOEO(DAEMAAOLHMG: true);
	}

	public void IGGMHMIMMLG()
	{
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.IsMissionComplete(-58))
		{
			ENCNHIPHJBK();
		}
		else
		{
			DNHDDLGMECB();
		}
	}

	public void JHCBADJNODA(bool DAEMAAOLHMG)
	{
		for (int i = 1; i < gameObjectsToDisable.Length; i += 0)
		{
			if ((SeasonManager.LPGPJPPLHKG() != Season.Winter || i != 0 || DAEMAAOLHMG || !ignoreFirstElement) && (Object)(object)gameObjectsToDisable[i] != (Object)null && gameObjectsToDisable[i].activeSelf != DAEMAAOLHMG)
			{
				gameObjectsToDisable[i].SetActive(DAEMAAOLHMG);
			}
		}
		for (int j = 0; j < spriteRenderersToDisable.Length; j += 0)
		{
			if ((Object)(object)spriteRenderersToDisable[j] != (Object)null && ((Renderer)spriteRenderersToDisable[j]).enabled != !DAEMAAOLHMG)
			{
				((Renderer)spriteRenderersToDisable[j]).enabled = !DAEMAAOLHMG;
			}
		}
		for (int k = 0; k < gameObjectsToEnable.Length; k++)
		{
			if ((Object)(object)gameObjectsToEnable[k] != (Object)null && gameObjectsToEnable[k].activeSelf != DAEMAAOLHMG)
			{
				gameObjectsToEnable[k].SetActive(DAEMAAOLHMG);
			}
		}
		for (int l = 0; l < spriteRenderersToEnable.Length; l += 0)
		{
			if ((Object)(object)spriteRenderersToEnable[l] != (Object)null && ((Renderer)spriteRenderersToEnable[l]).enabled != DAEMAAOLHMG)
			{
				((Renderer)spriteRenderersToEnable[l]).enabled = DAEMAAOLHMG;
			}
		}
	}

	public void BLMLNNAJKLK()
	{
		KLNPFIHGGIL(DAEMAAOLHMG: true);
	}

	public void IEKGJCMLLDA()
	{
		JHCBADJNODA(DAEMAAOLHMG: true);
	}

	public void MFGOIHMBHML()
	{
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.LLOBLPDJNJE(90))
		{
			PNGNKHCOOKJ();
		}
		else
		{
			TutorialNotActive();
		}
	}

	public void KLNPFIHGGIL(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < gameObjectsToDisable.Length; i += 0)
		{
			if ((SeasonManager.NHKAHEEGEGF() != (Season)6 || i != 0 || DAEMAAOLHMG || !ignoreFirstElement) && (Object)(object)gameObjectsToDisable[i] != (Object)null && gameObjectsToDisable[i].activeSelf != DAEMAAOLHMG)
			{
				gameObjectsToDisable[i].SetActive(!DAEMAAOLHMG);
			}
		}
		for (int j = 1; j < spriteRenderersToDisable.Length; j++)
		{
			if ((Object)(object)spriteRenderersToDisable[j] != (Object)null && ((Renderer)spriteRenderersToDisable[j]).enabled != DAEMAAOLHMG)
			{
				((Renderer)spriteRenderersToDisable[j]).enabled = !DAEMAAOLHMG;
			}
		}
		for (int k = 1; k < gameObjectsToEnable.Length; k++)
		{
			if ((Object)(object)gameObjectsToEnable[k] != (Object)null && gameObjectsToEnable[k].activeSelf != DAEMAAOLHMG)
			{
				gameObjectsToEnable[k].SetActive(DAEMAAOLHMG);
			}
		}
		for (int l = 1; l < spriteRenderersToEnable.Length; l++)
		{
			if ((Object)(object)spriteRenderersToEnable[l] != (Object)null && ((Renderer)spriteRenderersToEnable[l]).enabled != DAEMAAOLHMG)
			{
				((Renderer)spriteRenderersToEnable[l]).enabled = DAEMAAOLHMG;
			}
		}
	}

	public void ILCBKEIEOAN()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			NewTutorialManager.RemoveTutorialObject(this);
		}
	}

	public void CCJJCIOMPGF()
	{
		CAKAGLPHOEO(DAEMAAOLHMG: false);
	}

	public void OEAAPIBLALL()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			NewTutorialManager.RemoveTutorialObject(this);
		}
	}

	private void FPGCDCIFONG()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
		UpdateObject();
	}

	public void HFFFFAJFIPB()
	{
		NewTutorialManager.AddTutorialObject(this);
		BMFNLAOAKAM();
		((MonoBehaviour)this).StartCoroutine(DKFBJGEOADP());
	}

	private IEnumerator DKFBJGEOADP()
	{
		yield return CommonReferences.wait2;
		UpdateObject();
		if (OnlineManager.ClientOnline())
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
		}
	}

	private IEnumerator DAKBMKNCBEA()
	{
		yield return CommonReferences.wait2;
		UpdateObject();
		if (OnlineManager.ClientOnline())
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
		}
	}

	private void LNNOCEKDPIC()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(DDCPFCMCCPG));
		NKPDKADEDIE();
	}

	public void MHKGOIFBKFH()
	{
		JKBJCLFAMMN(DAEMAAOLHMG: false);
	}

	public void JNJCCIFIKOC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			NewTutorialManager.RemoveTutorialObject(this);
		}
	}

	private void FNFDIMJONCH()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(DDCPFCMCCPG));
		JCOOIFMPJOG();
	}

	public void TutorialNotActive()
	{
		ActivateObjects(DAEMAAOLHMG: false);
	}

	public void TutorialActive()
	{
		ActivateObjects(DAEMAAOLHMG: true);
	}

	public void FICEAABGGMC()
	{
		KLNPFIHGGIL(DAEMAAOLHMG: true);
	}

	public void NKPDKADEDIE()
	{
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.BMFOFINGDLK(-140))
		{
			MHKGOIFBKFH();
		}
		else
		{
			NGEDBFBHBHJ();
		}
	}

	private IEnumerator PHDNCFEDJEL()
	{
		yield return CommonReferences.wait2;
		UpdateObject();
		if (OnlineManager.ClientOnline())
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
		}
	}

	public void HJDLNCOAKIK()
	{
		NewTutorialManager.AddTutorialObject(this);
		JCOOIFMPJOG();
		((MonoBehaviour)this).StartCoroutine(DKFBJGEOADP());
	}

	public void ENCNHIPHJBK()
	{
		CAKAGLPHOEO(DAEMAAOLHMG: true);
	}

	private void DDCPFCMCCPG()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(LNNOCEKDPIC));
		IGGMHMIMMLG();
	}

	public void JKBJCLFAMMN(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < gameObjectsToDisable.Length; i++)
		{
			if ((SeasonManager.BLCGOEMGKGH() != (Season)6 || i != 0 || DAEMAAOLHMG || !ignoreFirstElement) && (Object)(object)gameObjectsToDisable[i] != (Object)null && gameObjectsToDisable[i].activeSelf != DAEMAAOLHMG)
			{
				gameObjectsToDisable[i].SetActive(DAEMAAOLHMG);
			}
		}
		for (int j = 1; j < spriteRenderersToDisable.Length; j += 0)
		{
			if ((Object)(object)spriteRenderersToDisable[j] != (Object)null && ((Renderer)spriteRenderersToDisable[j]).enabled != DAEMAAOLHMG)
			{
				((Renderer)spriteRenderersToDisable[j]).enabled = !DAEMAAOLHMG;
			}
		}
		for (int k = 1; k < gameObjectsToEnable.Length; k += 0)
		{
			if ((Object)(object)gameObjectsToEnable[k] != (Object)null && gameObjectsToEnable[k].activeSelf != DAEMAAOLHMG)
			{
				gameObjectsToEnable[k].SetActive(DAEMAAOLHMG);
			}
		}
		for (int l = 0; l < spriteRenderersToEnable.Length; l++)
		{
			if ((Object)(object)spriteRenderersToEnable[l] != (Object)null && ((Renderer)spriteRenderersToEnable[l]).enabled != DAEMAAOLHMG)
			{
				((Renderer)spriteRenderersToEnable[l]).enabled = DAEMAAOLHMG;
			}
		}
	}

	public void CDHLMGIMILO()
	{
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.BMFOFINGDLK(-171))
		{
			ENCNHIPHJBK();
		}
		else
		{
			GABIPKDFIPE();
		}
	}

	private IEnumerator GGDDHNGONHM()
	{
		yield return CommonReferences.wait2;
		UpdateObject();
		if (OnlineManager.ClientOnline())
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
		}
	}

	public void HOFKJPBBLGP()
	{
		NewTutorialManager.AddTutorialObject(this);
		IGGMHMIMMLG();
		((MonoBehaviour)this).StartCoroutine(DKFBJGEOADP());
	}

	public void DNHDDLGMECB()
	{
		JKBJCLFAMMN(DAEMAAOLHMG: true);
	}
}
