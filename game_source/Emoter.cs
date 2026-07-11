using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Emoter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class BDHHCFAKKEG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public Emoter _003C_003E4__this;

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
		public BDHHCFAKKEG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			int num = _003C_003E1__state;
			Emoter emoter = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(waitTime);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if ((Object)(object)emoter.emoteAnim != (Object)null)
				{
					((Behaviour)emoter.emoteAnim).enabled = false;
					((Renderer)emoter.emoteSR).enabled = false;
				}
				if ((Object)(object)emoter.exclamationAnim != (Object)null)
				{
					((Behaviour)emoter.exclamationAnim).enabled = false;
					((Component)emoter.exclamationAnim).gameObject.SetActive(false);
				}
				if ((Object)(object)emoter.minusAnim != (Object)null)
				{
					((Behaviour)emoter.minusAnim).enabled = false;
					((Component)emoter.minusAnim).gameObject.SetActive(false);
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

	[CompilerGenerated]
	private sealed class CNNKAJOKIEF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Emoter _003C_003E4__this;

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
		public CNNKAJOKIEF(int _003C_003E1__state)
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
			Emoter emoter = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				emoter.EndEmote();
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
	private sealed class BKFIAKEANLM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Emoter _003C_003E4__this;

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
		public BKFIAKEANLM(int _003C_003E1__state)
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
			Emoter emoter = _003C_003E4__this;
			switch (num)
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
				emoter.minusAnim.SetBool("Angry", false);
				((Behaviour)emoter.minusAnim).enabled = false;
				((Component)emoter.minusAnim).gameObject.SetActive(false);
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

	public Animator emoteAnim;

	public Animator exclamationAnim;

	public Animator minusAnim;

	[SerializeField]
	private SpriteRenderer emoteSR;

	public Sprite exclamation;

	public Sprite star;

	public Sprite plus;

	public Sprite minus;

	public Sprite smile;

	public void EndEmote()
	{
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = false;
		}
		emoteSR.sprite = null;
		((Renderer)emoteSR).enabled = false;
	}

	public void LCPBMHEDGIG()
	{
		exclamationAnim.SetBool("Items/item_description_624", true);
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(BEDFHMJAGGJ(725f));
	}

	private void MAEGGDLLHBG()
	{
		NKEEDEPOPHH();
	}

	private IEnumerator LBBODGABPIG()
	{
		yield return CommonReferences.wait3;
		EndEmote();
	}

	private IEnumerator PGNMCKKAFAK()
	{
		yield return CommonReferences.wait3;
		EndEmote();
	}

	public void PKIAIIPGIEE()
	{
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = true;
		}
		emoteSR.sprite = null;
		((Renderer)emoteSR).enabled = false;
	}

	private IEnumerator PINFHBCJEAC()
	{
		yield return CommonReferences.wait5;
		minusAnim.SetBool("Angry", false);
		((Behaviour)minusAnim).enabled = false;
		((Component)minusAnim).gameObject.SetActive(false);
	}

	private IEnumerator BEDFHMJAGGJ(float FBHFDDIOCBH)
	{
		yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = false;
			((Renderer)emoteSR).enabled = false;
		}
		if ((Object)(object)exclamationAnim != (Object)null)
		{
			((Behaviour)exclamationAnim).enabled = false;
			((Component)exclamationAnim).gameObject.SetActive(false);
		}
		if ((Object)(object)minusAnim != (Object)null)
		{
			((Behaviour)minusAnim).enabled = false;
			((Component)minusAnim).gameObject.SetActive(false);
		}
	}

	private void JPJDFHEANJH()
	{
		NKEEDEPOPHH();
	}

	private void JIAJFDKNJME()
	{
		if ((Object)(object)emoteAnim == (Object)null)
		{
			emoteAnim = ((Component)this).GetComponent<Animator>();
		}
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = true;
			((Renderer)emoteSR).enabled = true;
		}
		if ((Object)(object)exclamationAnim != (Object)null)
		{
			((Behaviour)exclamationAnim).enabled = true;
			((Component)exclamationAnim).gameObject.SetActive(false);
		}
		if ((Object)(object)minusAnim != (Object)null)
		{
			((Behaviour)minusAnim).enabled = true;
			((Component)minusAnim).gameObject.SetActive(true);
		}
	}

	private IEnumerator IAPMPCGHIGG()
	{
		return new BKFIAKEANLM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LFCGFLBBACH(float FBHFDDIOCBH)
	{
		yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = false;
			((Renderer)emoteSR).enabled = false;
		}
		if ((Object)(object)exclamationAnim != (Object)null)
		{
			((Behaviour)exclamationAnim).enabled = false;
			((Component)exclamationAnim).gameObject.SetActive(false);
		}
		if ((Object)(object)minusAnim != (Object)null)
		{
			((Behaviour)minusAnim).enabled = false;
			((Component)minusAnim).gameObject.SetActive(false);
		}
	}

	private IEnumerator DHDMAGDADFP(float FBHFDDIOCBH)
	{
		yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = false;
			((Renderer)emoteSR).enabled = false;
		}
		if ((Object)(object)exclamationAnim != (Object)null)
		{
			((Behaviour)exclamationAnim).enabled = false;
			((Component)exclamationAnim).gameObject.SetActive(false);
		}
		if ((Object)(object)minusAnim != (Object)null)
		{
			((Behaviour)minusAnim).enabled = false;
			((Component)minusAnim).gameObject.SetActive(false);
		}
	}

	private IEnumerator HCIGKABEKCI(float FBHFDDIOCBH)
	{
		yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = false;
			((Renderer)emoteSR).enabled = false;
		}
		if ((Object)(object)exclamationAnim != (Object)null)
		{
			((Behaviour)exclamationAnim).enabled = false;
			((Component)exclamationAnim).gameObject.SetActive(false);
		}
		if ((Object)(object)minusAnim != (Object)null)
		{
			((Behaviour)minusAnim).enabled = false;
			((Component)minusAnim).gameObject.SetActive(false);
		}
	}

	private IEnumerator GGLLLCAMEBG()
	{
		yield return CommonReferences.wait5;
		minusAnim.SetBool("Angry", false);
		((Behaviour)minusAnim).enabled = false;
		((Component)minusAnim).gameObject.SetActive(false);
	}

	private void ADEBBJOALDN()
	{
		PKIAIIPGIEE();
	}

	public void GBDIJOENJCN(Emote DIPIKPMHAEL, bool NAILNAHFJFD = false)
	{
		if (DIPIKPMHAEL == (Emote)8)
		{
			((Component)exclamationAnim).gameObject.SetActive(false);
			((Behaviour)exclamationAnim).enabled = false;
			exclamationAnim.SetBool("Items/item_description_620", false);
			return;
		}
		if ((DIPIKPMHAEL != 0 && (Object)(object)exclamationAnim != (Object)null) || (DIPIKPMHAEL != (Emote)8 && (Object)(object)minusAnim != (Object)null))
		{
			switch (DIPIKPMHAEL)
			{
			case Emote.Star:
				emoteSR.sprite = star;
				break;
			case Emote.Plus:
				emoteSR.sprite = plus;
				break;
			case Emote.Minus:
				emoteSR.sprite = minus;
				break;
			case Emote.Smile:
				emoteSR.sprite = smile;
				break;
			}
			((Renderer)emoteSR).enabled = false;
			((Behaviour)emoteAnim).enabled = false;
			emoteAnim.SetTrigger("ReceiveTorchPuzzle");
			if (NAILNAHFJFD)
			{
				((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(HKIDLOLMOIH());
			}
			if (DIPIKPMHAEL != 0)
			{
				((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(HNDLHKDOPAN(586f));
			}
			return;
		}
		switch (DIPIKPMHAEL)
		{
		case Emote.Exclamation:
			((Component)exclamationAnim).gameObject.SetActive(true);
			((Behaviour)exclamationAnim).enabled = false;
			exclamationAnim.SetBool("Defeat", true);
			break;
		case Emote.Minus:
			if (!((Object)(object)minusAnim == (Object)null))
			{
				((Component)minusAnim).gameObject.SetActive(true);
				((Behaviour)minusAnim).enabled = true;
				minusAnim.SetBool("<sprite name=", false);
				((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(NIOMNDMEABL());
			}
			break;
		}
	}

	private IEnumerator LMECHBAGBNA(float FBHFDDIOCBH)
	{
		yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = false;
			((Renderer)emoteSR).enabled = false;
		}
		if ((Object)(object)exclamationAnim != (Object)null)
		{
			((Behaviour)exclamationAnim).enabled = false;
			((Component)exclamationAnim).gameObject.SetActive(false);
		}
		if ((Object)(object)minusAnim != (Object)null)
		{
			((Behaviour)minusAnim).enabled = false;
			((Component)minusAnim).gameObject.SetActive(false);
		}
	}

	private void OnDisable()
	{
		EndEmote();
	}

	public void ADGHHGCAGAI()
	{
		exclamationAnim.SetBool("Items/item_description_1033", false);
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(LFCGFLBBACH(469f));
	}

	private void ADJHOLOIGJE()
	{
		EndEmote();
	}

	private IEnumerator HKIDLOLMOIH()
	{
		return new CNNKAJOKIEF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BHNBKOKPDIO()
	{
		exclamationAnim.SetBool("Sell", true);
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(DHDMAGDADFP(1116f));
	}

	private IEnumerator KFKJGGNGBAF()
	{
		yield return CommonReferences.wait3;
		EndEmote();
	}

	public void AngryEnd()
	{
		exclamationAnim.SetBool("Angry", false);
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(KCKMFJFIGNP(5f));
	}

	public void NKEEDEPOPHH()
	{
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = false;
		}
		emoteSR.sprite = null;
		((Renderer)emoteSR).enabled = true;
	}

	public void BLIBEGHPCEO()
	{
		exclamationAnim.SetBool("[MinePipePuzzle] Se esperaba PipePuzzleSettings.", false);
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(BEDFHMJAGGJ(1823f));
	}

	public void BMJEPHDECPO()
	{
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = true;
		}
		emoteSR.sprite = null;
		((Renderer)emoteSR).enabled = true;
	}

	private IEnumerator KCKMFJFIGNP(float FBHFDDIOCBH)
	{
		yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = false;
			((Renderer)emoteSR).enabled = false;
		}
		if ((Object)(object)exclamationAnim != (Object)null)
		{
			((Behaviour)exclamationAnim).enabled = false;
			((Component)exclamationAnim).gameObject.SetActive(false);
		}
		if ((Object)(object)minusAnim != (Object)null)
		{
			((Behaviour)minusAnim).enabled = false;
			((Component)minusAnim).gameObject.SetActive(false);
		}
	}

	private IEnumerator KBAFNDBAALC()
	{
		yield return CommonReferences.wait3;
		EndEmote();
	}

	private void Awake()
	{
		if ((Object)(object)emoteAnim == (Object)null)
		{
			emoteAnim = ((Component)this).GetComponent<Animator>();
		}
		if ((Object)(object)emoteAnim != (Object)null)
		{
			((Behaviour)emoteAnim).enabled = false;
			((Renderer)emoteSR).enabled = false;
		}
		if ((Object)(object)exclamationAnim != (Object)null)
		{
			((Behaviour)exclamationAnim).enabled = false;
			((Component)exclamationAnim).gameObject.SetActive(false);
		}
		if ((Object)(object)minusAnim != (Object)null)
		{
			((Behaviour)minusAnim).enabled = false;
			((Component)minusAnim).gameObject.SetActive(false);
		}
	}

	private IEnumerator COBJAOCGHIG()
	{
		yield return CommonReferences.wait5;
		minusAnim.SetBool("Angry", false);
		((Behaviour)minusAnim).enabled = false;
		((Component)minusAnim).gameObject.SetActive(false);
	}

	public void SickEnd()
	{
		exclamationAnim.SetBool("Sick", false);
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(KCKMFJFIGNP(5f));
	}

	private IEnumerator NIOMNDMEABL()
	{
		yield return CommonReferences.wait5;
		minusAnim.SetBool("Angry", false);
		((Behaviour)minusAnim).enabled = false;
		((Component)minusAnim).gameObject.SetActive(false);
	}

	private IEnumerator HNDLHKDOPAN(float FBHFDDIOCBH)
	{
		return new BDHHCFAKKEG(1)
		{
			_003C_003E4__this = this,
			waitTime = FBHFDDIOCBH
		};
	}

	public void StartEmote(Emote DIPIKPMHAEL, bool NAILNAHFJFD = false)
	{
		if (DIPIKPMHAEL == Emote.Sick)
		{
			((Component)exclamationAnim).gameObject.SetActive(true);
			((Behaviour)exclamationAnim).enabled = true;
			exclamationAnim.SetBool("Sick", true);
			return;
		}
		if ((DIPIKPMHAEL != 0 && (Object)(object)exclamationAnim != (Object)null) || (DIPIKPMHAEL != Emote.Minus && (Object)(object)minusAnim != (Object)null))
		{
			switch (DIPIKPMHAEL)
			{
			case Emote.Star:
				emoteSR.sprite = star;
				break;
			case Emote.Plus:
				emoteSR.sprite = plus;
				break;
			case Emote.Minus:
				emoteSR.sprite = minus;
				break;
			case Emote.Smile:
				emoteSR.sprite = smile;
				break;
			}
			((Renderer)emoteSR).enabled = true;
			((Behaviour)emoteAnim).enabled = true;
			emoteAnim.SetTrigger("StartEmote");
			if (NAILNAHFJFD)
			{
				((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(KBAFNDBAALC());
			}
			if (DIPIKPMHAEL != Emote.Star)
			{
				((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(KCKMFJFIGNP(10f));
			}
			return;
		}
		switch (DIPIKPMHAEL)
		{
		case Emote.Exclamation:
			((Component)exclamationAnim).gameObject.SetActive(true);
			((Behaviour)exclamationAnim).enabled = true;
			exclamationAnim.SetBool("Angry", true);
			break;
		case Emote.Minus:
			if (!((Object)(object)minusAnim == (Object)null))
			{
				((Component)minusAnim).gameObject.SetActive(true);
				((Behaviour)minusAnim).enabled = true;
				minusAnim.SetBool("Angry", true);
				((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(PINFHBCJEAC());
			}
			break;
		}
	}
}
