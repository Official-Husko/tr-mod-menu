using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NightStart : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class GJGFPDCMCBP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NightStart _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

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
		public GJGFPDCMCBP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			int num = _003C_003E1__state;
			NightStart nightStart = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				_003Cwait_003E5__2 = new WaitForSeconds((float)Random.Range(8, 12));
			}
			if (Random.Range(0, 100) >= nightStart.probability)
			{
				nightStart.Toggle(KDBOIBDPHKD: true);
				nightStart.HKFPBALPNNG = null;
				return false;
			}
			_003C_003E2__current = _003Cwait_003E5__2;
			_003C_003E1__state = 1;
			return true;
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

	public bool randomizeStart;

	public GameObject[] toEnable;

	public GameObject[] toDisable;

	public SpriteRenderer spriteRenderer;

	public Sprite daySprite;

	public Sprite nightSprite;

	public int probability = 90;

	private Coroutine HKFPBALPNNG;

	public void CHMJIMHBIDI()
	{
		PLJPPIHFBAD(KDBOIBDPHKD: true);
	}

	private IEnumerator BFCNPBKPPEF()
	{
		WaitForSeconds wait = new WaitForSeconds((float)Random.Range(8, 12));
		while (Random.Range(0, 100) < probability)
		{
			yield return wait;
		}
		Toggle(KDBOIBDPHKD: true);
		HKFPBALPNNG = null;
	}

	public void IPCMAEDMMGC()
	{
		DEIKABIIGDH(KDBOIBDPHKD: true);
	}

	private IEnumerator HCNHHENHMBH()
	{
		return new GJGFPDCMCBP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KKBHFJAMOPN()
	{
		WaitForSeconds wait = new WaitForSeconds((float)Random.Range(8, 12));
		while (Random.Range(0, 100) < probability)
		{
			yield return wait;
		}
		Toggle(KDBOIBDPHKD: true);
		HKFPBALPNNG = null;
	}

	private void IANGDMHMCEL()
	{
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(LMDMKLHDDMN));
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(FMJNALJAKMD));
		if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnObjectsView = (Action)Delegate.Combine(gameManager.OnObjectsView, new Action(AMNIHILOACI));
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnFloorWallView = (Action)Delegate.Combine(instance.OnFloorWallView, new Action(CKCCMOPFFNB));
		}
		NOLDEOOIMJB(WorldTime.isNight);
		if ((Object.op_Implicit((Object)(object)daySprite) || Object.op_Implicit((Object)(object)nightSprite)) && (Object)(object)spriteRenderer == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Bouncer/" + ((Object)((Component)this).gameObject).name));
			}
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	public void HOOAPLEOHPJ()
	{
		if (!randomizeStart || !Application.isPlaying)
		{
			PLJPPIHFBAD(KDBOIBDPHKD: true);
		}
		else
		{
			HKFPBALPNNG = ((MonoBehaviour)this).StartCoroutine(GNILHNGGCHM());
		}
	}

	public void AGAGAMAIKEG()
	{
		if (HKFPBALPNNG != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
		}
		Toggle(KDBOIBDPHKD: true);
	}

	public void FCMEEOPIEGC()
	{
		if (!randomizeStart || !Application.isPlaying)
		{
			DEIKABIIGDH(KDBOIBDPHKD: false);
		}
		else
		{
			HKFPBALPNNG = ((MonoBehaviour)this).StartCoroutine(KKOANDPCODK());
		}
	}

	public void OnObjectsView()
	{
		Toggle(WorldTime.isNight);
	}

	private void NBBFLJNPLEA()
	{
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(JKIDHHHHDAD));
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(NEAKJOHFPEL));
		if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnObjectsView = (Action)Delegate.Combine(gameManager.OnObjectsView, new Action(ABNHMLLHKFP));
			GameManager gameManager2 = GameManager.NJNFHEPLEHL();
			gameManager2.OnFloorWallView = (Action)Delegate.Combine(gameManager2.OnFloorWallView, new Action(JDEKIJAPDOC));
		}
		JAJCIJHCAAB(WorldTime.isNight);
		if ((Object.op_Implicit((Object)(object)daySprite) || Object.op_Implicit((Object)(object)nightSprite)) && (Object)(object)spriteRenderer == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Rummage" + ((Object)((Component)this).gameObject).name));
			}
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	public void ADLOJAJPFBJ()
	{
		if (!randomizeStart || !Application.isPlaying)
		{
			JAJCIJHCAAB(KDBOIBDPHKD: false);
		}
		else
		{
			HKFPBALPNNG = ((MonoBehaviour)this).StartCoroutine(JOEEEJOMHPO());
		}
	}

	public void GPIKABCCIBA()
	{
		Toggle(WorldTime.isNight);
	}

	private void HKNNKJKNAGL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			WorldTime.OnNightStart = (Action)Delegate.Remove(WorldTime.OnNightStart, new Action(IJGPLELMIBG));
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(DCFCKCOOOAF));
			if ((Object)(object)GameManager.NJNFHEPLEHL() != (Object)null)
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnObjectsView = (Action)Delegate.Remove(gameManager.OnObjectsView, new Action(DDJHDKOJGBE));
				GameManager gameManager2 = GameManager.NJNFHEPLEHL();
				gameManager2.OnFloorWallView = (Action)Delegate.Remove(gameManager2.OnFloorWallView, new Action(JDEKIJAPDOC));
			}
			if (HKFPBALPNNG != null)
			{
				((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
			}
		}
	}

	public void Toggle(bool KDBOIBDPHKD)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)toEnable[i]))
			{
				toEnable[i].SetActive(KDBOIBDPHKD);
			}
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)toDisable[j]))
			{
				toDisable[j].SetActive(!KDBOIBDPHKD);
			}
		}
		if (!KDBOIBDPHKD && (Object)(object)daySprite != (Object)null)
		{
			spriteRenderer.sprite = daySprite;
		}
		if (KDBOIBDPHKD && (Object)(object)nightSprite != (Object)null)
		{
			spriteRenderer.sprite = nightSprite;
		}
	}

	public void FPAGIHHJBBK(bool KDBOIBDPHKD)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)toEnable[i]))
			{
				toEnable[i].SetActive(KDBOIBDPHKD);
			}
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)toDisable[j]))
			{
				toDisable[j].SetActive(KDBOIBDPHKD);
			}
		}
		if (!KDBOIBDPHKD && (Object)(object)daySprite != (Object)null)
		{
			spriteRenderer.sprite = daySprite;
		}
		if (KDBOIBDPHKD && (Object)(object)nightSprite != (Object)null)
		{
			spriteRenderer.sprite = nightSprite;
		}
	}

	public void ECPJCEBLGMM()
	{
		DEIKABIIGDH(KDBOIBDPHKD: true);
	}

	public void NOLDEOOIMJB(bool KDBOIBDPHKD)
	{
		for (int i = 1; i < toEnable.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)toEnable[i]))
			{
				toEnable[i].SetActive(KDBOIBDPHKD);
			}
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)toDisable[j]))
			{
				toDisable[j].SetActive(!KDBOIBDPHKD);
			}
		}
		if (!KDBOIBDPHKD && (Object)(object)daySprite != (Object)null)
		{
			spriteRenderer.sprite = daySprite;
		}
		if (KDBOIBDPHKD && (Object)(object)nightSprite != (Object)null)
		{
			spriteRenderer.sprite = nightSprite;
		}
	}

	private IEnumerator ILNHHLIOJAH()
	{
		WaitForSeconds wait = new WaitForSeconds((float)Random.Range(8, 12));
		while (Random.Range(0, 100) < probability)
		{
			yield return wait;
		}
		Toggle(KDBOIBDPHKD: true);
		HKFPBALPNNG = null;
	}

	public void LMDMKLHDDMN()
	{
		if (!randomizeStart || !Application.isPlaying)
		{
			FPAGIHHJBBK(KDBOIBDPHKD: false);
		}
		else
		{
			HKFPBALPNNG = ((MonoBehaviour)this).StartCoroutine(BFCNPBKPPEF());
		}
	}

	public void JDMNLJOODPI()
	{
		DEIKABIIGDH(WorldTime.isNight);
	}

	public void JAJCIJHCAAB(bool KDBOIBDPHKD)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)toEnable[i]))
			{
				toEnable[i].SetActive(KDBOIBDPHKD);
			}
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)toDisable[j]))
			{
				toDisable[j].SetActive(KDBOIBDPHKD);
			}
		}
		if (!KDBOIBDPHKD && (Object)(object)daySprite != (Object)null)
		{
			spriteRenderer.sprite = daySprite;
		}
		if (KDBOIBDPHKD && (Object)(object)nightSprite != (Object)null)
		{
			spriteRenderer.sprite = nightSprite;
		}
	}

	public void AMNIHILOACI()
	{
		PLJPPIHFBAD(WorldTime.isNight);
	}

	public void FMJNALJAKMD()
	{
		if (HKFPBALPNNG != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
		}
		DEIKABIIGDH(KDBOIBDPHKD: true);
	}

	public void OALCLPOADFC()
	{
		FPAGIHHJBBK(WorldTime.isNight);
	}

	public void CKCCMOPFFNB()
	{
		JAJCIJHCAAB(KDBOIBDPHKD: true);
	}

	public void LDKKGKDGJLP()
	{
		Toggle(WorldTime.isNight);
	}

	public void KEMIPDKNFLP()
	{
		FPAGIHHJBBK(KDBOIBDPHKD: false);
	}

	public void PLJPPIHFBAD(bool KDBOIBDPHKD)
	{
		for (int i = 1; i < toEnable.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)toEnable[i]))
			{
				toEnable[i].SetActive(KDBOIBDPHKD);
			}
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)toDisable[j]))
			{
				toDisable[j].SetActive(KDBOIBDPHKD);
			}
		}
		if (!KDBOIBDPHKD && (Object)(object)daySprite != (Object)null)
		{
			spriteRenderer.sprite = daySprite;
		}
		if (KDBOIBDPHKD && (Object)(object)nightSprite != (Object)null)
		{
			spriteRenderer.sprite = nightSprite;
		}
	}

	private IEnumerator ONJJOPPGFDK()
	{
		WaitForSeconds wait = new WaitForSeconds((float)Random.Range(8, 12));
		while (Random.Range(0, 100) < probability)
		{
			yield return wait;
		}
		Toggle(KDBOIBDPHKD: true);
		HKFPBALPNNG = null;
	}

	public void DEIKABIIGDH(bool KDBOIBDPHKD)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)toEnable[i]))
			{
				toEnable[i].SetActive(KDBOIBDPHKD);
			}
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)toDisable[j]))
			{
				toDisable[j].SetActive(KDBOIBDPHKD);
			}
		}
		if (!KDBOIBDPHKD && (Object)(object)daySprite != (Object)null)
		{
			spriteRenderer.sprite = daySprite;
		}
		if (KDBOIBDPHKD && (Object)(object)nightSprite != (Object)null)
		{
			spriteRenderer.sprite = nightSprite;
		}
	}

	public void ABNHMLLHKFP()
	{
		DEIKABIIGDH(WorldTime.isNight);
	}

	public void ALMGHBJFHAM()
	{
		NOLDEOOIMJB(WorldTime.isNight);
	}

	public void HEMFFOJHAOK()
	{
		if (HKFPBALPNNG != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
		}
		DEIKABIIGDH(KDBOIBDPHKD: false);
	}

	public void IJGPLELMIBG()
	{
		if (!randomizeStart || !Application.isPlaying)
		{
			Toggle(KDBOIBDPHKD: true);
		}
		else
		{
			HKFPBALPNNG = ((MonoBehaviour)this).StartCoroutine(ONJJOPPGFDK());
		}
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			WorldTime.OnNightStart = (Action)Delegate.Remove(WorldTime.OnNightStart, new Action(NightStarted));
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(NightEnd));
			if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnObjectsView = (Action)Delegate.Remove(instance.OnObjectsView, new Action(OnObjectsView));
				GameManager instance2 = GameManager.GGFJGHHHEJC;
				instance2.OnFloorWallView = (Action)Delegate.Remove(instance2.OnFloorWallView, new Action(OnFloorWallView));
			}
			if (HKFPBALPNNG != null)
			{
				((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
			}
		}
	}

	private void FDGAGFIAPGJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WorldTime.OnNightStart = (Action)Delegate.Remove(WorldTime.OnNightStart, new Action(JKIDHHHHDAD));
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(AGAGAMAIKEG));
			if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnObjectsView = (Action)Delegate.Remove(instance.OnObjectsView, new Action(ABNHMLLHKFP));
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnFloorWallView = (Action)Delegate.Remove(gameManager.OnFloorWallView, new Action(CKCCMOPFFNB));
			}
			if (HKFPBALPNNG != null)
			{
				((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
			}
		}
	}

	public void NightEnd()
	{
		if (HKFPBALPNNG != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
		}
		Toggle(KDBOIBDPHKD: false);
	}

	private IEnumerator GNILHNGGCHM()
	{
		WaitForSeconds wait = new WaitForSeconds((float)Random.Range(8, 12));
		while (Random.Range(0, 100) < probability)
		{
			yield return wait;
		}
		Toggle(KDBOIBDPHKD: true);
		HKFPBALPNNG = null;
	}

	public void JDEKIJAPDOC()
	{
		FPAGIHHJBBK(KDBOIBDPHKD: false);
	}

	public void NEAKJOHFPEL()
	{
		if (HKFPBALPNNG != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
		}
		DEIKABIIGDH(KDBOIBDPHKD: false);
	}

	private void DDIBFALLCNO()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WorldTime.OnNightStart = (Action)Delegate.Remove(WorldTime.OnNightStart, new Action(LMDMKLHDDMN));
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(FMJNALJAKMD));
			if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnObjectsView = (Action)Delegate.Remove(instance.OnObjectsView, new Action(OALCLPOADFC));
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnFloorWallView = (Action)Delegate.Remove(gameManager.OnFloorWallView, new Action(KEMIPDKNFLP));
			}
			if (HKFPBALPNNG != null)
			{
				((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
			}
		}
	}

	private IEnumerator JOEEEJOMHPO()
	{
		return new GJGFPDCMCBP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ANMOAFFGEOE()
	{
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(FCMEEOPIEGC));
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(HEMFFOJHAOK));
		if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnObjectsView = (Action)Delegate.Combine(gameManager.OnObjectsView, new Action(LDKKGKDGJLP));
			GameManager gameManager2 = GameManager.NJNFHEPLEHL();
			gameManager2.OnFloorWallView = (Action)Delegate.Combine(gameManager2.OnFloorWallView, new Action(OnFloorWallView));
		}
		DEIKABIIGDH(WorldTime.isNight);
		if ((Object.op_Implicit((Object)(object)daySprite) || Object.op_Implicit((Object)(object)nightSprite)) && (Object)(object)spriteRenderer == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Not enough skill points" + ((Object)((Component)this).gameObject).name));
			}
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	public void OnFloorWallView()
	{
		Toggle(KDBOIBDPHKD: false);
	}

	public void DEPNMPEOFDL()
	{
		JAJCIJHCAAB(KDBOIBDPHKD: false);
	}

	public void CAHEIDJAKLD()
	{
		if (HKFPBALPNNG != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
		}
		NOLDEOOIMJB(KDBOIBDPHKD: false);
	}

	public void JKIDHHHHDAD()
	{
		if (!randomizeStart || !Application.isPlaying)
		{
			JAJCIJHCAAB(KDBOIBDPHKD: true);
		}
		else
		{
			HKFPBALPNNG = ((MonoBehaviour)this).StartCoroutine(GNILHNGGCHM());
		}
	}

	public void CCMNJCCIMFO()
	{
		if (HKFPBALPNNG != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
		}
		JAJCIJHCAAB(KDBOIBDPHKD: true);
	}

	private void DCCJBKGNAOP()
	{
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(LMDMKLHDDMN));
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(FMJNALJAKMD));
		if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnObjectsView = (Action)Delegate.Combine(instance.OnObjectsView, new Action(OnObjectsView));
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnFloorWallView = (Action)Delegate.Combine(gameManager.OnFloorWallView, new Action(DEPNMPEOFDL));
		}
		DEIKABIIGDH(WorldTime.isNight);
		if ((Object.op_Implicit((Object)(object)daySprite) || Object.op_Implicit((Object)(object)nightSprite)) && (Object)(object)spriteRenderer == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("BarkActor" + ((Object)((Component)this).gameObject).name));
			}
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	public void ALENKMOGAAD()
	{
		if (!randomizeStart || !Application.isPlaying)
		{
			DEIKABIIGDH(KDBOIBDPHKD: false);
		}
		else
		{
			HKFPBALPNNG = ((MonoBehaviour)this).StartCoroutine(ONJJOPPGFDK());
		}
	}

	public void DCFCKCOOOAF()
	{
		if (HKFPBALPNNG != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
		}
		FPAGIHHJBBK(KDBOIBDPHKD: false);
	}

	private IEnumerator JBCGLCDHEOL()
	{
		WaitForSeconds wait = new WaitForSeconds((float)Random.Range(8, 12));
		while (Random.Range(0, 100) < probability)
		{
			yield return wait;
		}
		Toggle(KDBOIBDPHKD: true);
		HKFPBALPNNG = null;
	}

	private void NBMJJFNKJBA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			WorldTime.OnNightStart = (Action)Delegate.Remove(WorldTime.OnNightStart, new Action(HOOAPLEOHPJ));
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(CAHEIDJAKLD));
			if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnObjectsView = (Action)Delegate.Remove(gameManager.OnObjectsView, new Action(LDKKGKDGJLP));
				GameManager gameManager2 = GameManager.NJNFHEPLEHL();
				gameManager2.OnFloorWallView = (Action)Delegate.Remove(gameManager2.OnFloorWallView, new Action(JDEKIJAPDOC));
			}
			if (HKFPBALPNNG != null)
			{
				((MonoBehaviour)this).StopCoroutine(HKFPBALPNNG);
			}
		}
	}

	private IEnumerator KKOANDPCODK()
	{
		return new GJGFPDCMCBP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OnEnable()
	{
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(NightStarted));
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(NightEnd));
		if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnObjectsView = (Action)Delegate.Combine(instance.OnObjectsView, new Action(OnObjectsView));
			GameManager instance2 = GameManager.GGFJGHHHEJC;
			instance2.OnFloorWallView = (Action)Delegate.Combine(instance2.OnFloorWallView, new Action(OnFloorWallView));
		}
		Toggle(WorldTime.isNight);
		if ((Object.op_Implicit((Object)(object)daySprite) || Object.op_Implicit((Object)(object)nightSprite)) && (Object)(object)spriteRenderer == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("SpriteRenderer not attached on " + ((Object)((Component)this).gameObject).name));
			}
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	public void JJDDAKEHBCD()
	{
		NOLDEOOIMJB(WorldTime.isNight);
	}

	public void NightStarted()
	{
		if (!randomizeStart || !Application.isPlaying)
		{
			Toggle(KDBOIBDPHKD: true);
		}
		else
		{
			HKFPBALPNNG = ((MonoBehaviour)this).StartCoroutine(ONJJOPPGFDK());
		}
	}

	public void DDJHDKOJGBE()
	{
		Toggle(WorldTime.isNight);
	}
}
