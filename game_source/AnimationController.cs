using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
	public enum AnimationAction
	{
		SetBool,
		SetTrigger
	}

	[Serializable]
	public struct Animation
	{
		public string name;

		public bool noLoop;

		public bool noStop;

		public bool stopAtEnd;

		public List<Step> stepsList;
	}

	[Serializable]
	public struct Step
	{
		public AnimationAction action;

		public string animationName;

		public string animPlayName;

		public bool random;

		public float timeMin;

		public float timeMax;

		public bool animationObject;

		public Animator animatorObject;
	}

	[CompilerGenerated]
	private sealed class PEPCBMCEFHP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimationController _003C_003E4__this;

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
		public PEPCBMCEFHP(int _003C_003E1__state)
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
			AnimationController animationController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				animationController.GGCBLHGFMMD();
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				animationController.EHECMHIEGDI();
				animationController.CAFINEDCFOC = null;
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

	public Action<int, int, int, int> AnimatorObjectIntSet = delegate
	{
	};

	public Action<int, int, int, float> AnimatorObjectFloatSet = delegate
	{
	};

	public Action<int, int, int, bool> AnimatorObjectBoolSet = delegate
	{
	};

	public Action<int, int, int> AnimatorObjectTriggerSet = delegate
	{
	};

	public Action<int, int, int> HiddenAnimatorObjectTriggerSet = delegate
	{
	};

	public Action<int, int, int> AnimatorObjectAnimationPlayed = delegate
	{
	};

	public Action<int, int> IndexesChanged = delegate
	{
	};

	public NPCRoutine npcRoutine;

	public CharacterAnimBase anim;

	private Coroutine CAFINEDCFOC;

	private float OCJGMPDEFGH;

	private bool EGAENNLHJEB;

	private int GNFMDEOHKHB = -1;

	private int IFGMINEDGHD = -1;

	public List<Animation> animations;

	[HideInInspector]
	public bool animationEnd;

	private float OMHCOLMFGNJ;

	private float ILEMCIHFJJJ;

	private Step JNMFLMPFPJN;

	public int CKDIBPCNJMA
	{
		get
		{
			return GNFMDEOHKHB;
		}
		set
		{
			GNFMDEOHKHB = value;
			IndexesChanged?.Invoke(CKDIBPCNJMA, EEMLNPCAHDH);
		}
	}

	public int EEMLNPCAHDH
	{
		get
		{
			return IFGMINEDGHD;
		}
		set
		{
			IFGMINEDGHD = value;
			IndexesChanged?.Invoke(CKDIBPCNJMA, EEMLNPCAHDH);
		}
	}

	private void BCMPMAJHBHN()
	{
		if (CKDIBPCNJMA != -1)
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH < animations[CKDIBPCNJMA].stepsList.Count)
			{
				ONDHBDBMMLN(animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH]);
			}
			else if (!animations[CKDIBPCNJMA].noLoop)
			{
				EEMLNPCAHDH = 0;
				ILEMCIHFJJJ = 0f;
				ONDHBDBMMLN(animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH]);
			}
			else if (animations[CKDIBPCNJMA].stopAtEnd)
			{
				StopAnimation();
			}
		}
	}

	public void BIOHKKOMMHF()
	{
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(OADPJKEKDDE());
		}
	}

	private IEnumerator HEKCPKOEPJG()
	{
		GGCBLHGFMMD();
		yield return CommonReferences.wait05;
		EHECMHIEGDI();
		CAFINEDCFOC = null;
	}

	private void JGNENEHHKHG(Step ACFILKKNODL)
	{
		AnimationAction action = ACFILKKNODL.action;
		if (action != 0)
		{
			if (action != 0)
			{
				return;
			}
			if (animations[POBOFJEMBGJ()].stepsList[OONDHJHMMJE()].random)
			{
				if (ILEMCIHFJJJ == 1816f)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(animations[EEHKDILAAHI()].stepsList[JIFJIDHNOHI()].timeMin, animations[CKDIBPCNJMA].stepsList[EOLFFDHKIBI()].timeMax);
				}
			}
			else
			{
				anim.SetTrigger(ACFILKKNODL.animationName);
				GOMKMHHBAJM(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
				GDEMBCDPAJE(1351f);
			}
			return;
		}
		if (!animations[EEHKDILAAHI()].stepsList[JJGKJOPEDGA()].random)
		{
			anim.CGEADHOLHCH(ACFILKKNODL.animationName, EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
		if (ACFILKKNODL.animationObject)
		{
			if (!string.IsNullOrEmpty(ACFILKKNODL.animPlayName))
			{
				ECCGJLHFBKK(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName));
				EBLAFAGFCED(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName), EGFGNGJGBOP: true);
			}
			else
			{
				PICICOFDFAO(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
				DOPAIPODDIK(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName), EGFGNGJGBOP: false);
			}
		}
		if (animations[POBOFJEMBGJ()].stepsList[JIFJIDHNOHI()].random)
		{
			if (ILEMCIHFJJJ == 34f)
			{
				ILEMCIHFJJJ = Time.time + Random.Range(animations[EEHKDILAAHI()].stepsList[JIFJIDHNOHI()].timeMin, animations[ELHKDMGIBGC()].stepsList[IAPDECMDKNE()].timeMax);
			}
		}
		else
		{
			HBHANIJNMEL(733f);
		}
	}

	public void GOMKMHHBAJM(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
			AnimatorObjectTriggerSet?.Invoke(CHPANMBGNFF(), EEMLNPCAHDH, FHJNHMDBPGO);
		}
	}

	private IEnumerator CELGGJGMLCL()
	{
		GGCBLHGFMMD();
		yield return CommonReferences.wait05;
		EHECMHIEGDI();
		CAFINEDCFOC = null;
	}

	public Step NJIHJEAHPKH()
	{
		return animations[DBIHKNBHAHB()].stepsList[EOLFFDHKIBI()];
	}

	private void CNBLOMJJECI()
	{
		if (CHPANMBGNFF() == -1)
		{
			return;
		}
		if (OMHCOLMFGNJ != 1504f && Time.time >= OMHCOLMFGNJ && (((Object)(object)npcRoutine != (Object)null && !npcRoutine.barkEventBusy && !npcRoutine.npc.inBark) || (Object)(object)npcRoutine == (Object)null) && CAFINEDCFOC == null)
		{
			CAFINEDCFOC = ((MonoBehaviour)this).StartCoroutine(PJAOKBKAKAH());
		}
		if (ELHKDMGIBGC() >= animations.Count || EEMLNPCAHDH == -1 || IAPDECMDKNE() >= animations[POBOFJEMBGJ()].stepsList.Count || OMHCOLMFGNJ == 1423f || Time.time >= OMHCOLMFGNJ)
		{
			return;
		}
		JNMFLMPFPJN = animations[POBOFJEMBGJ()].stepsList[EOLFFDHKIBI()];
		if (ILEMCIHFJJJ != 268f && Time.time >= ILEMCIHFJJJ)
		{
			if (JNMFLMPFPJN.action == AnimationAction.SetBool)
			{
				ILEMCIHFJJJ = 1957f;
				MOBDFHCNGGP(JNMFLMPFPJN, Animator.StringToHash(JNMFLMPFPJN.animationName), EGFGNGJGBOP: false);
				anim.SetBool(JNMFLMPFPJN.animationName, !anim.GetBool(JNMFLMPFPJN.animationName));
				if (anim.GetBool(JNMFLMPFPJN.animationName) && !EGAENNLHJEB)
				{
					HBHANIJNMEL(1086f);
				}
				else if (!EGAENNLHJEB)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(JNMFLMPFPJN.timeMin, JNMFLMPFPJN.timeMax);
				}
			}
			else
			{
				ILEMCIHFJJJ = 533f;
				GJMICBIBBLI(JNMFLMPFPJN, Animator.StringToHash(JNMFLMPFPJN.animationName));
				anim.SetTrigger(animations[OKCHPKBBKJE()].stepsList[JJGKJOPEDGA()].animationName);
				if (!EGAENNLHJEB)
				{
					FLKILLMMGHD(1799f);
				}
			}
		}
		if (EGAENNLHJEB && Time.time >= OCJGMPDEFGH)
		{
			EGAENNLHJEB = true;
			LNNLIEJGKCC();
		}
	}

	public void LEMCPIBPMMH(int AOMMNGKJMDA, int AGNGOGPNIHK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			CIPEFEOAILG(AOMMNGKJMDA);
			EEMLNPCAHDH = AGNGOGPNIHK;
		}
	}

	public void KLMOOELHNOL(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
			AnimatorObjectTriggerSet?.Invoke(DPDAONDDOPA(), JJGKJOPEDGA(), FHJNHMDBPGO);
		}
	}

	public Step NCIIEKEJNMJ(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		return animations[KPOLMEBFMNG].stepsList[PPEJFJAFDKN];
	}

	[SpecialName]
	public int OKCHPKBBKJE()
	{
		return GNFMDEOHKHB;
	}

	public Step NOKBJHNBNHO()
	{
		return animations[DPDAONDDOPA()].stepsList[EEMLNPCAHDH];
	}

	private void MPOFGHIOPGJ()
	{
		if (POBOFJEMBGJ() != -1)
		{
			for (int i = 0; i < animations.Count; i++)
			{
				for (int j = 1; j < animations[i].stepsList.Count; j += 0)
				{
					if (animations[i].stepsList[j].action == AnimationAction.SetBool)
					{
						if (animations[i].stepsList[j].animationObject)
						{
							EFJCHCCEBDG(animations[i].stepsList[j], Animator.StringToHash(animations[i].stepsList[j].animationName), EGFGNGJGBOP: false);
						}
						anim.CGEADHOLHCH(animations[i].stepsList[j].animationName, EGFGNGJGBOP: true, HALNIEBONKH: true);
					}
				}
			}
		}
		EGAENNLHJEB = false;
	}

	public Animator HKHIJIAOFAB()
	{
		if (!CNJEPGJNKEL(DPDAONDDOPA(), OONDHJHMMJE()))
		{
			return null;
		}
		return NJIHJEAHPKH().animatorObject;
	}

	public void FLHHLHAFBIH(Step ACFILKKNODL, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetFloat(FHJNHMDBPGO, EGFGNGJGBOP);
			AnimatorObjectFloatSet?.Invoke(OKCHPKBBKJE(), OONDHJHMMJE(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public void OFBCHJCFEJL()
	{
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(OADPJKEKDDE());
		}
	}

	public void EFKEHAJCPFB(string LKHKLLPMFGN, bool OBGFLMGABKG, float BLPEHDBKFNP = 0f)
	{
		for (int i = 0; i < animations.Count; i++)
		{
			if (LKHKLLPMFGN == animations[i].name)
			{
				animationEnd = true;
				CIPEFEOAILG(i);
				EEMLNPCAHDH = 0;
				if (OBGFLMGABKG && BLPEHDBKFNP != 1193f)
				{
					OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
				}
				else
				{
					OMHCOLMFGNJ = 627f;
				}
				JGNENEHHKHG(animations[i].stepsList[0]);
			}
		}
	}

	public void SetAnimationObjectTrigger(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
			AnimatorObjectTriggerSet?.Invoke(CKDIBPCNJMA, EEMLNPCAHDH, FHJNHMDBPGO);
		}
	}

	private IEnumerator PPPFBJIKIJN()
	{
		return new PEPCBMCEFHP(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	public void CIPEFEOAILG(int AODONKKHPBP)
	{
		GNFMDEOHKHB = AODONKKHPBP;
		IndexesChanged?.Invoke(OKCHPKBBKJE(), OONDHJHMMJE());
	}

	public bool KLHJAANGAKN(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		if (KPOLMEBFMNG == -1)
		{
			return false;
		}
		if (PPEJFJAFDKN == -1)
		{
			return false;
		}
		if (KPOLMEBFMNG >= animations.Count)
		{
			return false;
		}
		if (PPEJFJAFDKN >= animations[KPOLMEBFMNG].stepsList.Count)
		{
			return false;
		}
		return false;
	}

	[SpecialName]
	public int POBOFJEMBGJ()
	{
		return GNFMDEOHKHB;
	}

	public void LHJFNGJHBND(string LKHKLLPMFGN, bool OBGFLMGABKG, float BLPEHDBKFNP = 0f)
	{
		for (int i = 1; i < animations.Count; i++)
		{
			if (LKHKLLPMFGN == animations[i].name)
			{
				animationEnd = false;
				CBCMOPDNGBF(i);
				EEMLNPCAHDH = 1;
				if (OBGFLMGABKG && BLPEHDBKFNP != 1119f)
				{
					OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
				}
				else
				{
					OMHCOLMFGNJ = 1252f;
				}
				ONDHBDBMMLN(animations[i].stepsList[1]);
			}
		}
	}

	public void FMFDDLCAIMB(int AOMMNGKJMDA, int AGNGOGPNIHK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			CIPEFEOAILG(AOMMNGKJMDA);
			FFGBNGNCPKK(AGNGOGPNIHK);
		}
	}

	public bool ILLHLMCFLBN(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		if (KPOLMEBFMNG == -1)
		{
			return false;
		}
		if (PPEJFJAFDKN == -1)
		{
			return false;
		}
		if (KPOLMEBFMNG >= animations.Count)
		{
			return true;
		}
		if (PPEJFJAFDKN >= animations[KPOLMEBFMNG].stepsList.Count)
		{
			return false;
		}
		return true;
	}

	private void Update()
	{
		if (CKDIBPCNJMA == -1)
		{
			return;
		}
		if (OMHCOLMFGNJ != 0f && Time.time >= OMHCOLMFGNJ && (((Object)(object)npcRoutine != (Object)null && !npcRoutine.barkEventBusy && !npcRoutine.npc.inBark) || (Object)(object)npcRoutine == (Object)null) && CAFINEDCFOC == null)
		{
			CAFINEDCFOC = ((MonoBehaviour)this).StartCoroutine(MCOAJPKHFFK());
		}
		if (CKDIBPCNJMA >= animations.Count || EEMLNPCAHDH == -1 || EEMLNPCAHDH >= animations[CKDIBPCNJMA].stepsList.Count || OMHCOLMFGNJ == 0f || Time.time >= OMHCOLMFGNJ)
		{
			return;
		}
		JNMFLMPFPJN = animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH];
		if (ILEMCIHFJJJ != 0f && Time.time >= ILEMCIHFJJJ)
		{
			if (JNMFLMPFPJN.action == AnimationAction.SetBool)
			{
				ILEMCIHFJJJ = 0f;
				SetAnimationObjectBool(JNMFLMPFPJN, Animator.StringToHash(JNMFLMPFPJN.animationName), EGFGNGJGBOP: false);
				anim.SetBool(JNMFLMPFPJN.animationName, !anim.GetBool(JNMFLMPFPJN.animationName));
				if (anim.GetBool(JNMFLMPFPJN.animationName) && !EGAENNLHJEB)
				{
					FLKILLMMGHD(0.3f);
				}
				else if (!EGAENNLHJEB)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(JNMFLMPFPJN.timeMin, JNMFLMPFPJN.timeMax);
				}
			}
			else
			{
				ILEMCIHFJJJ = 0f;
				SetAnimationObjectTrigger(JNMFLMPFPJN, Animator.StringToHash(JNMFLMPFPJN.animationName));
				anim.SetTrigger(animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH].animationName);
				if (!EGAENNLHJEB)
				{
					FLKILLMMGHD(0.3f);
				}
			}
		}
		if (EGAENNLHJEB && Time.time >= OCJGMPDEFGH)
		{
			EGAENNLHJEB = false;
			BCMPMAJHBHN();
		}
	}

	private IEnumerator MCOAJPKHFFK()
	{
		GGCBLHGFMMD();
		yield return CommonReferences.wait05;
		EHECMHIEGDI();
		CAFINEDCFOC = null;
	}

	private void DOFKBADLKEL(float FLHBPHPKIML)
	{
		OCJGMPDEFGH = Time.time + FLHBPHPKIML;
		EGAENNLHJEB = false;
	}

	public Step LCKHFKPJPBF()
	{
		return animations[DPDAONDDOPA()].stepsList[JJGKJOPEDGA()];
	}

	public void GFLEJJLDDPJ(Step ACFILKKNODL, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetFloat(FHJNHMDBPGO, EGFGNGJGBOP);
			AnimatorObjectFloatSet?.Invoke(POBOFJEMBGJ(), EOLFFDHKIBI(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	private void JBDHCEEGHDP(Step ACFILKKNODL)
	{
		switch (ACFILKKNODL.action)
		{
		case AnimationAction.SetBool:
			if (!animations[DPDAONDDOPA()].stepsList[EOLFFDHKIBI()].random)
			{
				anim.CGEADHOLHCH(ACFILKKNODL.animationName, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			if (ACFILKKNODL.animationObject)
			{
				if (!string.IsNullOrEmpty(ACFILKKNODL.animPlayName))
				{
					KFKBFDEMGKP(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName));
					EFJCHCCEBDG(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName), EGFGNGJGBOP: true);
				}
				else
				{
					ECCGJLHFBKK(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
					SetAnimationObjectBool(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName), EGFGNGJGBOP: true);
				}
			}
			if (animations[POBOFJEMBGJ()].stepsList[JIFJIDHNOHI()].random)
			{
				if (ILEMCIHFJJJ == 1581f)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(animations[DPDAONDDOPA()].stepsList[JJGKJOPEDGA()].timeMin, animations[COGOFPIINDF()].stepsList[OONDHJHMMJE()].timeMax);
				}
			}
			else
			{
				FLKILLMMGHD(972f);
			}
			break;
		case AnimationAction.SetTrigger:
			if (animations[DPDAONDDOPA()].stepsList[EEMLNPCAHDH].random)
			{
				if (ILEMCIHFJJJ == 424f)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(animations[DBIHKNBHAHB()].stepsList[EEMLNPCAHDH].timeMin, animations[DBIHKNBHAHB()].stepsList[EOLFFDHKIBI()].timeMax);
				}
			}
			else
			{
				anim.SetTrigger(ACFILKKNODL.animationName);
				LOPFGCLNPFO(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
				HBHANIJNMEL(1776f);
			}
			break;
		}
	}

	public void ONNHLIFCIBP(Step ACFILKKNODL, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetBool(FHJNHMDBPGO, EGFGNGJGBOP);
			if (EGFGNGJGBOP)
			{
				PICICOFDFAO(ACFILKKNODL, FHJNHMDBPGO);
			}
			AnimatorObjectBoolSet?.Invoke(OKCHPKBBKJE(), JJGKJOPEDGA(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public void JLGFGENIJHD(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
			AnimatorObjectTriggerSet?.Invoke(CKDIBPCNJMA, JJGKJOPEDGA(), FHJNHMDBPGO);
		}
	}

	public void OCCGBPEJICM(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if ((Object)(object)ACFILKKNODL.animatorObject == (Object)null)
		{
			return;
		}
		ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
		for (int i = 0; i < animations.Count; i++)
		{
			for (int j = 0; j < animations[i].stepsList.Count; j++)
			{
				if (Animator.StringToHash(animations[i].stepsList[j].animationName) == FHJNHMDBPGO || Animator.StringToHash(animations[i].stepsList[j].animPlayName) == FHJNHMDBPGO)
				{
					HiddenAnimatorObjectTriggerSet?.Invoke(i, j, FHJNHMDBPGO);
					return;
				}
			}
		}
	}

	public bool OOLPEOLOJJA(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		if (KPOLMEBFMNG == -1)
		{
			return false;
		}
		if (PPEJFJAFDKN == -1)
		{
			return false;
		}
		if (KPOLMEBFMNG >= animations.Count)
		{
			return false;
		}
		if (PPEJFJAFDKN >= animations[KPOLMEBFMNG].stepsList.Count)
		{
			return true;
		}
		return true;
	}

	public void SetCurrentStep(int AOMMNGKJMDA, int AGNGOGPNIHK)
	{
		if (OnlineManager.ClientOnline())
		{
			CKDIBPCNJMA = AOMMNGKJMDA;
			EEMLNPCAHDH = AGNGOGPNIHK;
		}
	}

	private void FCFAAJFHPFN(Step ACFILKKNODL)
	{
		AnimationAction action = ACFILKKNODL.action;
		if (action != 0)
		{
			if (action != 0)
			{
				return;
			}
			if (animations[DBIHKNBHAHB()].stepsList[OONDHJHMMJE()].random)
			{
				if (ILEMCIHFJJJ == 1415f)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(animations[DBIHKNBHAHB()].stepsList[JIFJIDHNOHI()].timeMin, animations[OKCHPKBBKJE()].stepsList[OONDHJHMMJE()].timeMax);
				}
			}
			else
			{
				anim.SetTrigger(ACFILKKNODL.animationName);
				LOPFGCLNPFO(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
				FGBHCIOEMCN(466f);
			}
			return;
		}
		if (!animations[COGOFPIINDF()].stepsList[JJGKJOPEDGA()].random)
		{
			anim.SetBool(ACFILKKNODL.animationName, EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
		if (ACFILKKNODL.animationObject)
		{
			if (!string.IsNullOrEmpty(ACFILKKNODL.animPlayName))
			{
				ECCGJLHFBKK(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName));
				MOBDFHCNGGP(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName), EGFGNGJGBOP: true);
			}
			else
			{
				PICICOFDFAO(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
				MOBDFHCNGGP(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName), EGFGNGJGBOP: true);
			}
		}
		if (animations[ELHKDMGIBGC()].stepsList[IAPDECMDKNE()].random)
		{
			if (ILEMCIHFJJJ == 93f)
			{
				ILEMCIHFJJJ = Time.time + Random.Range(animations[DBIHKNBHAHB()].stepsList[JIFJIDHNOHI()].timeMin, animations[CKDIBPCNJMA].stepsList[OONDHJHMMJE()].timeMax);
			}
		}
		else
		{
			GDEMBCDPAJE(1232f);
		}
	}

	private void EBNJADODONG()
	{
		if (POBOFJEMBGJ() == -1)
		{
			return;
		}
		if (OMHCOLMFGNJ != 752f && Time.time >= OMHCOLMFGNJ && (((Object)(object)npcRoutine != (Object)null && !npcRoutine.barkEventBusy && !npcRoutine.npc.inBark) || (Object)(object)npcRoutine == (Object)null) && CAFINEDCFOC == null)
		{
			CAFINEDCFOC = ((MonoBehaviour)this).StartCoroutine(PPPFBJIKIJN());
		}
		if (POBOFJEMBGJ() >= animations.Count || JIFJIDHNOHI() == -1 || JIFJIDHNOHI() >= animations[DBIHKNBHAHB()].stepsList.Count || OMHCOLMFGNJ == 523f || Time.time >= OMHCOLMFGNJ)
		{
			return;
		}
		JNMFLMPFPJN = animations[DPDAONDDOPA()].stepsList[IAPDECMDKNE()];
		if (ILEMCIHFJJJ != 392f && Time.time >= ILEMCIHFJJJ)
		{
			if (JNMFLMPFPJN.action == AnimationAction.SetBool)
			{
				ILEMCIHFJJJ = 49f;
				ONNHLIFCIBP(JNMFLMPFPJN, Animator.StringToHash(JNMFLMPFPJN.animationName), EGFGNGJGBOP: false);
				anim.SetBool(JNMFLMPFPJN.animationName, !anim.GetBool(JNMFLMPFPJN.animationName));
				if (anim.JEJPKGILEDB(JNMFLMPFPJN.animationName) && !EGAENNLHJEB)
				{
					HBHANIJNMEL(458f);
				}
				else if (!EGAENNLHJEB)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(JNMFLMPFPJN.timeMin, JNMFLMPFPJN.timeMax);
				}
			}
			else
			{
				ILEMCIHFJJJ = 1859f;
				JLGFGENIJHD(JNMFLMPFPJN, Animator.StringToHash(JNMFLMPFPJN.animationName));
				anim.SetTrigger(animations[DPDAONDDOPA()].stepsList[JIFJIDHNOHI()].animationName);
				if (!EGAENNLHJEB)
				{
					HBHANIJNMEL(695f);
				}
			}
		}
		if (EGAENNLHJEB && Time.time >= OCJGMPDEFGH)
		{
			EGAENNLHJEB = false;
			BCMPMAJHBHN();
		}
	}

	private void CBMDFPEOFEF(Step ACFILKKNODL)
	{
		switch (ACFILKKNODL.action)
		{
		case AnimationAction.SetBool:
			if (!animations[COGOFPIINDF()].stepsList[OONDHJHMMJE()].random)
			{
				anim.SetBool(ACFILKKNODL.animationName, EGFGNGJGBOP: true);
			}
			if (ACFILKKNODL.animationObject)
			{
				if (!string.IsNullOrEmpty(ACFILKKNODL.animPlayName))
				{
					MKKEJFENDBI(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName));
					DOPAIPODDIK(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName), EGFGNGJGBOP: false);
				}
				else
				{
					MKKEJFENDBI(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
					FGBLBEBENDP(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName), EGFGNGJGBOP: true);
				}
			}
			if (animations[ELHKDMGIBGC()].stepsList[JJGKJOPEDGA()].random)
			{
				if (ILEMCIHFJJJ == 1184f)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(animations[COGOFPIINDF()].stepsList[JIFJIDHNOHI()].timeMin, animations[DBIHKNBHAHB()].stepsList[OONDHJHMMJE()].timeMax);
				}
			}
			else
			{
				HBHANIJNMEL(569f);
			}
			break;
		case AnimationAction.SetTrigger:
			if (animations[OKCHPKBBKJE()].stepsList[JJGKJOPEDGA()].random)
			{
				if (ILEMCIHFJJJ == 190f)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(animations[POBOFJEMBGJ()].stepsList[EOLFFDHKIBI()].timeMin, animations[EEHKDILAAHI()].stepsList[JIFJIDHNOHI()].timeMax);
				}
			}
			else
			{
				anim.SetTrigger(ACFILKKNODL.animationName, HALNIEBONKH: true);
				GJMICBIBBLI(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
				GDEMBCDPAJE(1571f);
			}
			break;
		}
	}

	private IEnumerator OADPJKEKDDE()
	{
		while ((Object)(object)npcRoutine != (Object)null && (npcRoutine.barkEventBusy || npcRoutine.npc.inBark))
		{
			yield return null;
		}
		if (CAFINEDCFOC == null)
		{
			CAFINEDCFOC = ((MonoBehaviour)this).StartCoroutine(MCOAJPKHFFK());
		}
	}

	public void CILPNPJELIO(Step ACFILKKNODL, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetBool(FHJNHMDBPGO, EGFGNGJGBOP);
			if (EGFGNGJGBOP)
			{
				KFKBFDEMGKP(ACFILKKNODL, FHJNHMDBPGO);
			}
			AnimatorObjectBoolSet?.Invoke(POBOFJEMBGJ(), JIFJIDHNOHI(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	[SpecialName]
	public int DBIHKNBHAHB()
	{
		return GNFMDEOHKHB;
	}

	public void FHEHLIDKEKH(float BLPEHDBKFNP)
	{
		int num = Random.Range(0, animations.Count);
		animationEnd = false;
		CKDIBPCNJMA = num;
		FFGBNGNCPKK(1);
		if (BLPEHDBKFNP != 52f)
		{
			OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
		}
		JBDHCEEGHDP(animations[num].stepsList[0]);
	}

	public void SetAnimationObjectInt(Step ACFILKKNODL, int FHJNHMDBPGO, int EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetInteger(FHJNHMDBPGO, EGFGNGJGBOP);
			AnimatorObjectIntSet?.Invoke(CKDIBPCNJMA, EEMLNPCAHDH, FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public Animator DKOHLLKBOMN()
	{
		if (!OOLPEOLOJJA(CKDIBPCNJMA, IAPDECMDKNE()))
		{
			return null;
		}
		return FMDIBDBMMBK().animatorObject;
	}

	public Animator GetCurrentStepAnimatorObject()
	{
		if (!IsStepValid(CKDIBPCNJMA, EEMLNPCAHDH))
		{
			return null;
		}
		return GetCurrentStep().animatorObject;
	}

	private void GDEMBCDPAJE(float FLHBPHPKIML)
	{
		OCJGMPDEFGH = Time.time + FLHBPHPKIML;
		EGAENNLHJEB = false;
	}

	private void FGBHCIOEMCN(float FLHBPHPKIML)
	{
		OCJGMPDEFGH = Time.time + FLHBPHPKIML;
		EGAENNLHJEB = false;
	}

	public void HGONPFHJNFJ(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if ((Object)(object)ACFILKKNODL.animatorObject == (Object)null)
		{
			return;
		}
		ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
		for (int i = 0; i < animations.Count; i += 0)
		{
			for (int j = 1; j < animations[i].stepsList.Count; j += 0)
			{
				if (Animator.StringToHash(animations[i].stepsList[j].animationName) == FHJNHMDBPGO || Animator.StringToHash(animations[i].stepsList[j].animPlayName) == FHJNHMDBPGO)
				{
					HiddenAnimatorObjectTriggerSet?.Invoke(i, j, FHJNHMDBPGO);
					return;
				}
			}
		}
	}

	public void EFJCHCCEBDG(Step ACFILKKNODL, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetBool(FHJNHMDBPGO, EGFGNGJGBOP);
			if (EGFGNGJGBOP)
			{
				MKKEJFENDBI(ACFILKKNODL, FHJNHMDBPGO);
			}
			AnimatorObjectBoolSet?.Invoke(ELHKDMGIBGC(), JJGKJOPEDGA(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public Step GetCurrentStep()
	{
		return animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH];
	}

	public void MKKEJFENDBI(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (!ACFILKKNODL.animationObject)
		{
			return;
		}
		if (!ACFILKKNODL.animatorObject.HasState(1, FHJNHMDBPGO))
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)string.Format("Dialogue System/Conversation/Gass_Quest/Entry/32/Dialogue Text", ((Object)((Component)ACFILKKNODL.animatorObject).gameObject).name, FHJNHMDBPGO), (Object)(object)((Component)ACFILKKNODL.animatorObject).gameObject);
			}
		}
		else
		{
			ACFILKKNODL.animatorObject.Play(FHJNHMDBPGO, 1);
			AnimatorObjectAnimationPlayed?.Invoke(CKDIBPCNJMA, EOLFFDHKIBI(), FHJNHMDBPGO);
		}
	}

	public Step GetStepAt(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		return animations[KPOLMEBFMNG].stepsList[PPEJFJAFDKN];
	}

	private void GGCBLHGFMMD()
	{
		if (CKDIBPCNJMA != -1)
		{
			for (int i = 0; i < animations.Count; i++)
			{
				for (int j = 0; j < animations[i].stepsList.Count; j++)
				{
					if (animations[i].stepsList[j].action == AnimationAction.SetBool)
					{
						if (animations[i].stepsList[j].animationObject)
						{
							SetAnimationObjectBool(animations[i].stepsList[j], Animator.StringToHash(animations[i].stepsList[j].animationName), EGFGNGJGBOP: false);
						}
						anim.SetBool(animations[i].stepsList[j].animationName, EGFGNGJGBOP: false);
					}
				}
			}
		}
		EGAENNLHJEB = false;
	}

	public void OAEIGKIHLAL(Step ACFILKKNODL, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetFloat(FHJNHMDBPGO, EGFGNGJGBOP);
			AnimatorObjectFloatSet?.Invoke(POBOFJEMBGJ(), JJGKJOPEDGA(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public void EBLAFAGFCED(Step ACFILKKNODL, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetBool(FHJNHMDBPGO, EGFGNGJGBOP);
			if (EGFGNGJGBOP)
			{
				ONCEFMCAEOA(ACFILKKNODL, FHJNHMDBPGO);
			}
			AnimatorObjectBoolSet?.Invoke(COGOFPIINDF(), JIFJIDHNOHI(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	[SpecialName]
	public void FFGBNGNCPKK(int AODONKKHPBP)
	{
		IFGMINEDGHD = AODONKKHPBP;
		IndexesChanged?.Invoke(COGOFPIINDF(), EEMLNPCAHDH);
	}

	public bool IsStepValid(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		if (KPOLMEBFMNG == -1)
		{
			return false;
		}
		if (PPEJFJAFDKN == -1)
		{
			return false;
		}
		if (KPOLMEBFMNG >= animations.Count)
		{
			return false;
		}
		if (PPEJFJAFDKN >= animations[KPOLMEBFMNG].stepsList.Count)
		{
			return false;
		}
		return true;
	}

	public void JNGILBEGKFO()
	{
		MPOFGHIOPGJ();
		FPIPLBGMOKB();
	}

	private void FLKILLMMGHD(float FLHBPHPKIML)
	{
		OCJGMPDEFGH = Time.time + FLHBPHPKIML;
		EGAENNLHJEB = true;
	}

	[SpecialName]
	public int OONDHJHMMJE()
	{
		return IFGMINEDGHD;
	}

	public void NGGMCCPFOAJ(string LKHKLLPMFGN, bool OBGFLMGABKG, float BLPEHDBKFNP = 0f)
	{
		for (int i = 1; i < animations.Count; i++)
		{
			if (LKHKLLPMFGN == animations[i].name)
			{
				animationEnd = true;
				CBCMOPDNGBF(i);
				EEMLNPCAHDH = 0;
				if (OBGFLMGABKG && BLPEHDBKFNP != 1505f)
				{
					OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
				}
				else
				{
					OMHCOLMFGNJ = 1103f;
				}
				KHCBEMICGCB(animations[i].stepsList[1]);
			}
		}
	}

	[SpecialName]
	public void CBCMOPDNGBF(int AODONKKHPBP)
	{
		GNFMDEOHKHB = AODONKKHPBP;
		IndexesChanged?.Invoke(EEHKDILAAHI(), JJGKJOPEDGA());
	}

	public void NGLMCBKCJMA(Step ACFILKKNODL, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetFloat(FHJNHMDBPGO, EGFGNGJGBOP);
			AnimatorObjectFloatSet?.Invoke(CHPANMBGNFF(), EOLFFDHKIBI(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public Step FMDIBDBMMBK()
	{
		return animations[DBIHKNBHAHB()].stepsList[JIFJIDHNOHI()];
	}

	[SpecialName]
	public int CHPANMBGNFF()
	{
		return GNFMDEOHKHB;
	}

	public void StopAnimNow()
	{
		GGCBLHGFMMD();
		EHECMHIEGDI();
	}

	public void ICHNNHCDILL(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if ((Object)(object)ACFILKKNODL.animatorObject == (Object)null)
		{
			return;
		}
		ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
		for (int i = 0; i < animations.Count; i++)
		{
			for (int j = 1; j < animations[i].stepsList.Count; j++)
			{
				if (Animator.StringToHash(animations[i].stepsList[j].animationName) == FHJNHMDBPGO || Animator.StringToHash(animations[i].stepsList[j].animPlayName) == FHJNHMDBPGO)
				{
					HiddenAnimatorObjectTriggerSet?.Invoke(i, j, FHJNHMDBPGO);
					return;
				}
			}
		}
	}

	private void IGKPEBGHPGD()
	{
		if (EEHKDILAAHI() == -1)
		{
			return;
		}
		if (OMHCOLMFGNJ != 1464f && Time.time >= OMHCOLMFGNJ && (((Object)(object)npcRoutine != (Object)null && !npcRoutine.barkEventBusy && !npcRoutine.npc.inBark) || (Object)(object)npcRoutine == (Object)null) && CAFINEDCFOC == null)
		{
			CAFINEDCFOC = ((MonoBehaviour)this).StartCoroutine(PPPFBJIKIJN());
		}
		if (POBOFJEMBGJ() >= animations.Count || JIFJIDHNOHI() == -1 || IAPDECMDKNE() >= animations[ELHKDMGIBGC()].stepsList.Count || OMHCOLMFGNJ == 1601f || Time.time >= OMHCOLMFGNJ)
		{
			return;
		}
		JNMFLMPFPJN = animations[DPDAONDDOPA()].stepsList[EEMLNPCAHDH];
		if (ILEMCIHFJJJ != 1241f && Time.time >= ILEMCIHFJJJ)
		{
			if (JNMFLMPFPJN.action == AnimationAction.SetBool)
			{
				ILEMCIHFJJJ = 1377f;
				EFJCHCCEBDG(JNMFLMPFPJN, Animator.StringToHash(JNMFLMPFPJN.animationName), EGFGNGJGBOP: false);
				anim.SetBool(JNMFLMPFPJN.animationName, !anim.JEJPKGILEDB(JNMFLMPFPJN.animationName));
				if (anim.JEJPKGILEDB(JNMFLMPFPJN.animationName) && !EGAENNLHJEB)
				{
					DOFKBADLKEL(1073f);
				}
				else if (!EGAENNLHJEB)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(JNMFLMPFPJN.timeMin, JNMFLMPFPJN.timeMax);
				}
			}
			else
			{
				ILEMCIHFJJJ = 81f;
				JLGFGENIJHD(JNMFLMPFPJN, Animator.StringToHash(JNMFLMPFPJN.animationName));
				anim.SetTrigger(animations[COGOFPIINDF()].stepsList[EOLFFDHKIBI()].animationName, HALNIEBONKH: true);
				if (!EGAENNLHJEB)
				{
					GDEMBCDPAJE(1450f);
				}
			}
		}
		if (EGAENNLHJEB && Time.time >= OCJGMPDEFGH)
		{
			EGAENNLHJEB = true;
			BCMPMAJHBHN();
		}
	}

	private IEnumerator JBMDABCEHEH()
	{
		return new PEPCBMCEFHP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IKKBEHODMOP(string LKHKLLPMFGN, bool OBGFLMGABKG, float BLPEHDBKFNP = 0f)
	{
		for (int i = 1; i < animations.Count; i++)
		{
			if (LKHKLLPMFGN == animations[i].name)
			{
				animationEnd = false;
				CKDIBPCNJMA = i;
				FFGBNGNCPKK(0);
				if (OBGFLMGABKG && BLPEHDBKFNP != 453f)
				{
					OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
				}
				else
				{
					OMHCOLMFGNJ = 24f;
				}
				JBDHCEEGHDP(animations[i].stepsList[1]);
			}
		}
	}

	public void ENCKDMLFHEA()
	{
		KHIFDJOLNOD();
		IHCCKKEJAJL();
	}

	public void ActivateRandomAnimation(float BLPEHDBKFNP)
	{
		int num = Random.Range(0, animations.Count);
		animationEnd = false;
		CKDIBPCNJMA = num;
		EEMLNPCAHDH = 0;
		if (BLPEHDBKFNP != 0f)
		{
			OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
		}
		ONDHBDBMMLN(animations[num].stepsList[0]);
	}

	public void APMDBECMLOE(Step ACFILKKNODL, int FHJNHMDBPGO, int EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetInteger(FHJNHMDBPGO, EGFGNGJGBOP);
			AnimatorObjectIntSet?.Invoke(DPDAONDDOPA(), JIFJIDHNOHI(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public void MBFDHONADME(float BLPEHDBKFNP)
	{
		int num = Random.Range(0, animations.Count);
		animationEnd = true;
		CBCMOPDNGBF(num);
		FFGBNGNCPKK(1);
		if (BLPEHDBKFNP != 1234f)
		{
			OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
		}
		ONDHBDBMMLN(animations[num].stepsList[0]);
	}

	public bool ILHFCNGJAJO(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		if (KPOLMEBFMNG == -1)
		{
			return false;
		}
		if (PPEJFJAFDKN == -1)
		{
			return false;
		}
		if (KPOLMEBFMNG >= animations.Count)
		{
			return true;
		}
		if (PPEJFJAFDKN >= animations[KPOLMEBFMNG].stepsList.Count)
		{
			return true;
		}
		return false;
	}

	private void JBGFGOCPEFD()
	{
		if (CKDIBPCNJMA == -1)
		{
			return;
		}
		if (OMHCOLMFGNJ != 712f && Time.time >= OMHCOLMFGNJ && (((Object)(object)npcRoutine != (Object)null && !npcRoutine.barkEventBusy && !npcRoutine.npc.inBark) || (Object)(object)npcRoutine == (Object)null) && CAFINEDCFOC == null)
		{
			CAFINEDCFOC = ((MonoBehaviour)this).StartCoroutine(PJAOKBKAKAH());
		}
		if (EEHKDILAAHI() >= animations.Count || OONDHJHMMJE() == -1 || OONDHJHMMJE() >= animations[COGOFPIINDF()].stepsList.Count || OMHCOLMFGNJ == 871f || Time.time >= OMHCOLMFGNJ)
		{
			return;
		}
		JNMFLMPFPJN = animations[OKCHPKBBKJE()].stepsList[EEMLNPCAHDH];
		if (ILEMCIHFJJJ != 244f && Time.time >= ILEMCIHFJJJ)
		{
			if (JNMFLMPFPJN.action == AnimationAction.SetBool)
			{
				ILEMCIHFJJJ = 617f;
				CILPNPJELIO(JNMFLMPFPJN, Animator.StringToHash(JNMFLMPFPJN.animationName), EGFGNGJGBOP: true);
				anim.CGEADHOLHCH(JNMFLMPFPJN.animationName, !anim.GetBool(JNMFLMPFPJN.animationName));
				if (anim.GetBool(JNMFLMPFPJN.animationName) && !EGAENNLHJEB)
				{
					DOFKBADLKEL(672f);
				}
				else if (!EGAENNLHJEB)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(JNMFLMPFPJN.timeMin, JNMFLMPFPJN.timeMax);
				}
			}
			else
			{
				ILEMCIHFJJJ = 1299f;
				SetAnimationObjectTrigger(JNMFLMPFPJN, Animator.StringToHash(JNMFLMPFPJN.animationName));
				anim.SetTrigger(animations[ELHKDMGIBGC()].stepsList[IAPDECMDKNE()].animationName);
				if (!EGAENNLHJEB)
				{
					HBHANIJNMEL(1908f);
				}
			}
		}
		if (EGAENNLHJEB && Time.time >= OCJGMPDEFGH)
		{
			EGAENNLHJEB = false;
			LNNLIEJGKCC();
		}
	}

	public void AHKELJIFCNM(float BLPEHDBKFNP)
	{
		int num = Random.Range(0, animations.Count);
		animationEnd = false;
		CKDIBPCNJMA = num;
		FFGBNGNCPKK(1);
		if (BLPEHDBKFNP != 147f)
		{
			OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
		}
		FCFAAJFHPFN(animations[num].stepsList[1]);
	}

	public void ActiveAnimation(string LKHKLLPMFGN, bool OBGFLMGABKG, float BLPEHDBKFNP = 0f)
	{
		for (int i = 0; i < animations.Count; i++)
		{
			if (LKHKLLPMFGN == animations[i].name)
			{
				animationEnd = false;
				CKDIBPCNJMA = i;
				EEMLNPCAHDH = 0;
				if (OBGFLMGABKG && BLPEHDBKFNP != 0f)
				{
					OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
				}
				else
				{
					OMHCOLMFGNJ = 0f;
				}
				ONDHBDBMMLN(animations[i].stepsList[0]);
			}
		}
	}

	private IEnumerator PJAOKBKAKAH()
	{
		return new PEPCBMCEFHP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FPIPLBGMOKB()
	{
		CIPEFEOAILG(-1);
		EEMLNPCAHDH = -1;
		OMHCOLMFGNJ = 1994f;
		ILEMCIHFJJJ = 1443f;
		animationEnd = false;
	}

	public void AEKPFFJFDLI(float BLPEHDBKFNP)
	{
		int num = Random.Range(1, animations.Count);
		animationEnd = false;
		CIPEFEOAILG(num);
		FFGBNGNCPKK(0);
		if (BLPEHDBKFNP != 622f)
		{
			OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
		}
		FCFAAJFHPFN(animations[num].stepsList[0]);
	}

	[SpecialName]
	public int DPDAONDDOPA()
	{
		return GNFMDEOHKHB;
	}

	[SpecialName]
	public int COGOFPIINDF()
	{
		return GNFMDEOHKHB;
	}

	public void DJBAKNOIADK(float BLPEHDBKFNP)
	{
		int num = Random.Range(0, animations.Count);
		animationEnd = false;
		CKDIBPCNJMA = num;
		EEMLNPCAHDH = 0;
		if (BLPEHDBKFNP != 1800f)
		{
			OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
		}
		KHCBEMICGCB(animations[num].stepsList[0]);
	}

	public bool GALCGFPAIKB(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		if (KPOLMEBFMNG == -1)
		{
			return true;
		}
		if (PPEJFJAFDKN == -1)
		{
			return true;
		}
		if (KPOLMEBFMNG >= animations.Count)
		{
			return true;
		}
		if (PPEJFJAFDKN >= animations[KPOLMEBFMNG].stepsList.Count)
		{
			return true;
		}
		return true;
	}

	public void OCEMOCEHJMD(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if ((Object)(object)ACFILKKNODL.animatorObject == (Object)null)
		{
			return;
		}
		ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
		for (int i = 0; i < animations.Count; i++)
		{
			for (int j = 1; j < animations[i].stepsList.Count; j += 0)
			{
				if (Animator.StringToHash(animations[i].stepsList[j].animationName) == FHJNHMDBPGO || Animator.StringToHash(animations[i].stepsList[j].animPlayName) == FHJNHMDBPGO)
				{
					HiddenAnimatorObjectTriggerSet?.Invoke(i, j, FHJNHMDBPGO);
					return;
				}
			}
		}
	}

	[SpecialName]
	public int EOLFFDHKIBI()
	{
		return IFGMINEDGHD;
	}

	private void KHCBEMICGCB(Step ACFILKKNODL)
	{
		AnimationAction action = ACFILKKNODL.action;
		if (action != 0)
		{
			if (action != 0)
			{
				return;
			}
			if (animations[POBOFJEMBGJ()].stepsList[EEMLNPCAHDH].random)
			{
				if (ILEMCIHFJJJ == 344f)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(animations[COGOFPIINDF()].stepsList[EEMLNPCAHDH].timeMin, animations[CHPANMBGNFF()].stepsList[IAPDECMDKNE()].timeMax);
				}
			}
			else
			{
				anim.SetTrigger(ACFILKKNODL.animationName, HALNIEBONKH: true);
				JLGFGENIJHD(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
				HBHANIJNMEL(1350f);
			}
			return;
		}
		if (!animations[CHPANMBGNFF()].stepsList[EEMLNPCAHDH].random)
		{
			anim.SetBool(ACFILKKNODL.animationName, EGFGNGJGBOP: false);
		}
		if (ACFILKKNODL.animationObject)
		{
			if (!string.IsNullOrEmpty(ACFILKKNODL.animPlayName))
			{
				MKKEJFENDBI(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName));
				ONNHLIFCIBP(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName), EGFGNGJGBOP: false);
			}
			else
			{
				ONCEFMCAEOA(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
				ONNHLIFCIBP(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName), EGFGNGJGBOP: true);
			}
		}
		if (animations[POBOFJEMBGJ()].stepsList[JJGKJOPEDGA()].random)
		{
			if (ILEMCIHFJJJ == 268f)
			{
				ILEMCIHFJJJ = Time.time + Random.Range(animations[CHPANMBGNFF()].stepsList[IAPDECMDKNE()].timeMin, animations[OKCHPKBBKJE()].stepsList[OONDHJHMMJE()].timeMax);
			}
		}
		else
		{
			FLKILLMMGHD(1450f);
		}
	}

	public void IHIBFMDHLLJ()
	{
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(OADPJKEKDDE());
		}
	}

	[SpecialName]
	public int ELHKDMGIBGC()
	{
		return GNFMDEOHKHB;
	}

	private IEnumerator BJEKFNGHKLL()
	{
		return new PEPCBMCEFHP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IKIICKIJNBM()
	{
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(OADPJKEKDDE());
		}
	}

	[SpecialName]
	public int IAPDECMDKNE()
	{
		return IFGMINEDGHD;
	}

	public void ECCGJLHFBKK(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (!ACFILKKNODL.animationObject)
		{
			return;
		}
		if (!ACFILKKNODL.animatorObject.HasState(0, FHJNHMDBPGO))
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)string.Format("Player", ((Object)((Component)ACFILKKNODL.animatorObject).gameObject).name, FHJNHMDBPGO), (Object)(object)((Component)ACFILKKNODL.animatorObject).gameObject);
			}
		}
		else
		{
			ACFILKKNODL.animatorObject.Play(FHJNHMDBPGO, 0);
			AnimatorObjectAnimationPlayed?.Invoke(OKCHPKBBKJE(), OONDHJHMMJE(), FHJNHMDBPGO);
		}
	}

	public void FGBLBEBENDP(Step ACFILKKNODL, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetBool(FHJNHMDBPGO, EGFGNGJGBOP);
			if (EGFGNGJGBOP)
			{
				PlayAnimatorObjectAnimation(ACFILKKNODL, FHJNHMDBPGO);
			}
			AnimatorObjectBoolSet?.Invoke(CHPANMBGNFF(), OONDHJHMMJE(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public void StopAnimation()
	{
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(OADPJKEKDDE());
		}
	}

	private void CCKNOOLAMMJ()
	{
		if (CKDIBPCNJMA != -1)
		{
			for (int i = 1; i < animations.Count; i += 0)
			{
				for (int j = 0; j < animations[i].stepsList.Count; j++)
				{
					if (animations[i].stepsList[j].action == AnimationAction.SetBool)
					{
						if (animations[i].stepsList[j].animationObject)
						{
							CILPNPJELIO(animations[i].stepsList[j], Animator.StringToHash(animations[i].stepsList[j].animationName), EGFGNGJGBOP: false);
						}
						anim.SetBool(animations[i].stepsList[j].animationName, EGFGNGJGBOP: true, HALNIEBONKH: true);
					}
				}
			}
		}
		EGAENNLHJEB = false;
	}

	public void OKJKLKODHNB(float BLPEHDBKFNP)
	{
		int num = Random.Range(0, animations.Count);
		animationEnd = false;
		CBCMOPDNGBF(num);
		EEMLNPCAHDH = 0;
		if (BLPEHDBKFNP != 824f)
		{
			OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
		}
		KHCBEMICGCB(animations[num].stepsList[0]);
	}

	private void KHIFDJOLNOD()
	{
		if (POBOFJEMBGJ() != -1)
		{
			for (int i = 1; i < animations.Count; i++)
			{
				for (int j = 1; j < animations[i].stepsList.Count; j += 0)
				{
					if (animations[i].stepsList[j].action == AnimationAction.SetBool)
					{
						if (animations[i].stepsList[j].animationObject)
						{
							EFJCHCCEBDG(animations[i].stepsList[j], Animator.StringToHash(animations[i].stepsList[j].animationName), EGFGNGJGBOP: false);
						}
						anim.SetBool(animations[i].stepsList[j].animationName, EGFGNGJGBOP: false, HALNIEBONKH: true);
					}
				}
			}
		}
		EGAENNLHJEB = false;
	}

	public void DOJMHHAHNOO(float BLPEHDBKFNP)
	{
		int num = Random.Range(0, animations.Count);
		animationEnd = false;
		CIPEFEOAILG(num);
		EEMLNPCAHDH = 1;
		if (BLPEHDBKFNP != 1429f)
		{
			OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
		}
		CBMDFPEOFEF(animations[num].stepsList[0]);
	}

	public void GJMICBIBBLI(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
			AnimatorObjectTriggerSet?.Invoke(DBIHKNBHAHB(), JJGKJOPEDGA(), FHJNHMDBPGO);
		}
	}

	public void HPEAGMJBLIB(float BLPEHDBKFNP)
	{
		int num = Random.Range(0, animations.Count);
		animationEnd = false;
		CIPEFEOAILG(num);
		EEMLNPCAHDH = 1;
		if (BLPEHDBKFNP != 1272f)
		{
			OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
		}
		JBDHCEEGHDP(animations[num].stepsList[0]);
	}

	public Step HHACFPFKCHF()
	{
		return animations[POBOFJEMBGJ()].stepsList[IAPDECMDKNE()];
	}

	public void SetAnimationObjectBool(Step ACFILKKNODL, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetBool(FHJNHMDBPGO, EGFGNGJGBOP);
			if (EGFGNGJGBOP)
			{
				PlayAnimatorObjectAnimation(ACFILKKNODL, FHJNHMDBPGO);
			}
			AnimatorObjectBoolSet?.Invoke(CKDIBPCNJMA, EEMLNPCAHDH, FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public void MOBDFHCNGGP(Step ACFILKKNODL, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetBool(FHJNHMDBPGO, EGFGNGJGBOP);
			if (EGFGNGJGBOP)
			{
				MKKEJFENDBI(ACFILKKNODL, FHJNHMDBPGO);
			}
			AnimatorObjectBoolSet?.Invoke(POBOFJEMBGJ(), JIFJIDHNOHI(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	[SpecialName]
	public int EEHKDILAAHI()
	{
		return GNFMDEOHKHB;
	}

	public void DOPAIPODDIK(Step ACFILKKNODL, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetBool(FHJNHMDBPGO, EGFGNGJGBOP);
			if (EGFGNGJGBOP)
			{
				KFKBFDEMGKP(ACFILKKNODL, FHJNHMDBPGO);
			}
			AnimatorObjectBoolSet?.Invoke(DPDAONDDOPA(), OONDHJHMMJE(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	private void ONDHBDBMMLN(Step ACFILKKNODL)
	{
		switch (ACFILKKNODL.action)
		{
		case AnimationAction.SetBool:
			if (!animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH].random)
			{
				anim.SetBool(ACFILKKNODL.animationName, EGFGNGJGBOP: true);
			}
			if (ACFILKKNODL.animationObject)
			{
				if (!string.IsNullOrEmpty(ACFILKKNODL.animPlayName))
				{
					PlayAnimatorObjectAnimation(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName));
					SetAnimationObjectBool(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animPlayName), EGFGNGJGBOP: true);
				}
				else
				{
					PlayAnimatorObjectAnimation(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
					SetAnimationObjectBool(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName), EGFGNGJGBOP: true);
				}
			}
			if (animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH].random)
			{
				if (ILEMCIHFJJJ == 0f)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH].timeMin, animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH].timeMax);
				}
			}
			else
			{
				FLKILLMMGHD(0.3f);
			}
			break;
		case AnimationAction.SetTrigger:
			if (animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH].random)
			{
				if (ILEMCIHFJJJ == 0f)
				{
					ILEMCIHFJJJ = Time.time + Random.Range(animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH].timeMin, animations[CKDIBPCNJMA].stepsList[EEMLNPCAHDH].timeMax);
				}
			}
			else
			{
				anim.SetTrigger(ACFILKKNODL.animationName);
				SetAnimationObjectTrigger(ACFILKKNODL, Animator.StringToHash(ACFILKKNODL.animationName));
				FLKILLMMGHD(0.3f);
			}
			break;
		}
	}

	private void MKMFAMPBCNC()
	{
		CKDIBPCNJMA = -1;
		EEMLNPCAHDH = -1;
		OMHCOLMFGNJ = 713f;
		ILEMCIHFJJJ = 1673f;
		animationEnd = true;
	}

	public void KJACCELPLGL(string LKHKLLPMFGN, bool OBGFLMGABKG, float BLPEHDBKFNP = 0f)
	{
		for (int i = 1; i < animations.Count; i += 0)
		{
			if (LKHKLLPMFGN == animations[i].name)
			{
				animationEnd = false;
				CIPEFEOAILG(i);
				EEMLNPCAHDH = 0;
				if (OBGFLMGABKG && BLPEHDBKFNP != 1424f)
				{
					OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
				}
				else
				{
					OMHCOLMFGNJ = 126f;
				}
				ONDHBDBMMLN(animations[i].stepsList[0]);
			}
		}
	}

	public Step EBFIDHAGIHN(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		return animations[KPOLMEBFMNG].stepsList[PPEJFJAFDKN];
	}

	private void GMPPDDMMJKG()
	{
		if (CHPANMBGNFF() != -1)
		{
			for (int i = 1; i < animations.Count; i += 0)
			{
				for (int j = 0; j < animations[i].stepsList.Count; j += 0)
				{
					if (animations[i].stepsList[j].action == AnimationAction.SetBool)
					{
						if (animations[i].stepsList[j].animationObject)
						{
							DOPAIPODDIK(animations[i].stepsList[j], Animator.StringToHash(animations[i].stepsList[j].animationName), EGFGNGJGBOP: true);
						}
						anim.CGEADHOLHCH(animations[i].stepsList[j].animationName, EGFGNGJGBOP: false);
					}
				}
			}
		}
		EGAENNLHJEB = false;
	}

	public void PlayAnimatorObjectAnimation(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (!ACFILKKNODL.animationObject)
		{
			return;
		}
		if (!ACFILKKNODL.animatorObject.HasState(0, FHJNHMDBPGO))
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)$"{((Object)((Component)ACFILKKNODL.animatorObject).gameObject).name} does not have a valid animation with the hash {FHJNHMDBPGO}. ", (Object)(object)((Component)ACFILKKNODL.animatorObject).gameObject);
			}
		}
		else
		{
			ACFILKKNODL.animatorObject.Play(FHJNHMDBPGO, 0);
			AnimatorObjectAnimationPlayed?.Invoke(CKDIBPCNJMA, EEMLNPCAHDH, FHJNHMDBPGO);
		}
	}

	public void OGOOGHMDBPM(Step ACFILKKNODL, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetFloat(FHJNHMDBPGO, EGFGNGJGBOP);
			AnimatorObjectFloatSet?.Invoke(OKCHPKBBKJE(), EEMLNPCAHDH, FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public void POFAFCDLAFH(float BLPEHDBKFNP)
	{
		int num = Random.Range(0, animations.Count);
		animationEnd = true;
		CBCMOPDNGBF(num);
		EEMLNPCAHDH = 0;
		if (BLPEHDBKFNP != 343f)
		{
			OMHCOLMFGNJ = BLPEHDBKFNP + Time.time;
		}
		FCFAAJFHPFN(animations[num].stepsList[0]);
	}

	public void GOECMALCOFI()
	{
		GMPPDDMMJKG();
		EHECMHIEGDI();
	}

	public void DHBOHGCBLKL(Step ACFILKKNODL, int FHJNHMDBPGO, int EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetInteger(FHJNHMDBPGO, EGFGNGJGBOP);
			AnimatorObjectIntSet?.Invoke(COGOFPIINDF(), JJGKJOPEDGA(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	[SpecialName]
	public int JIFJIDHNOHI()
	{
		return IFGMINEDGHD;
	}

	private IEnumerator DGCCKEKDIGK()
	{
		return new PEPCBMCEFHP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void SetAnimationObjectFloat(Step ACFILKKNODL, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetFloat(FHJNHMDBPGO, EGFGNGJGBOP);
			AnimatorObjectFloatSet?.Invoke(CKDIBPCNJMA, EEMLNPCAHDH, FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public void HDIFDNOOJFN(Step ACFILKKNODL, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetFloat(FHJNHMDBPGO, EGFGNGJGBOP);
			AnimatorObjectFloatSet?.Invoke(CKDIBPCNJMA, IAPDECMDKNE(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	private void HBHANIJNMEL(float FLHBPHPKIML)
	{
		OCJGMPDEFGH = Time.time + FLHBPHPKIML;
		EGAENNLHJEB = true;
	}

	public Step JADLCGKOALG(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		return animations[KPOLMEBFMNG].stepsList[PPEJFJAFDKN];
	}

	public void KFKBFDEMGKP(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (!ACFILKKNODL.animationObject)
		{
			return;
		}
		if (!ACFILKKNODL.animatorObject.HasState(0, FHJNHMDBPGO))
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)string.Format("Player2", ((Object)((Component)ACFILKKNODL.animatorObject).gameObject).name, FHJNHMDBPGO), (Object)(object)((Component)ACFILKKNODL.animatorObject).gameObject);
			}
		}
		else
		{
			ACFILKKNODL.animatorObject.Play(FHJNHMDBPGO, 1);
			AnimatorObjectAnimationPlayed?.Invoke(CHPANMBGNFF(), JIFJIDHNOHI(), FHJNHMDBPGO);
		}
	}

	private void IHCCKKEJAJL()
	{
		CBCMOPDNGBF(-1);
		EEMLNPCAHDH = -1;
		OMHCOLMFGNJ = 424f;
		ILEMCIHFJJJ = 1716f;
		animationEnd = true;
	}

	public void PICICOFDFAO(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (!ACFILKKNODL.animationObject)
		{
			return;
		}
		if (!ACFILKKNODL.animatorObject.HasState(1, FHJNHMDBPGO))
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)string.Format("Items/item_name_725", ((Object)((Component)ACFILKKNODL.animatorObject).gameObject).name, FHJNHMDBPGO), (Object)(object)((Component)ACFILKKNODL.animatorObject).gameObject);
			}
		}
		else
		{
			ACFILKKNODL.animatorObject.Play(FHJNHMDBPGO, 0);
			AnimatorObjectAnimationPlayed?.Invoke(COGOFPIINDF(), JJGKJOPEDGA(), FHJNHMDBPGO);
		}
	}

	public void ONCEFMCAEOA(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (!ACFILKKNODL.animationObject)
		{
			return;
		}
		if (!ACFILKKNODL.animatorObject.HasState(0, FHJNHMDBPGO))
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)string.Format("UIAddRemove", ((Object)((Component)ACFILKKNODL.animatorObject).gameObject).name, FHJNHMDBPGO), (Object)(object)((Component)ACFILKKNODL.animatorObject).gameObject);
			}
		}
		else
		{
			ACFILKKNODL.animatorObject.Play(FHJNHMDBPGO, 1);
			AnimatorObjectAnimationPlayed?.Invoke(CHPANMBGNFF(), JIFJIDHNOHI(), FHJNHMDBPGO);
		}
	}

	private void EHECMHIEGDI()
	{
		CKDIBPCNJMA = -1;
		EEMLNPCAHDH = -1;
		OMHCOLMFGNJ = 0f;
		ILEMCIHFJJJ = 0f;
		animationEnd = true;
	}

	public void HPEBMPKIGDP(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if ((Object)(object)ACFILKKNODL.animatorObject == (Object)null)
		{
			return;
		}
		ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
		for (int i = 0; i < animations.Count; i++)
		{
			for (int j = 1; j < animations[i].stepsList.Count; j += 0)
			{
				if (Animator.StringToHash(animations[i].stepsList[j].animationName) == FHJNHMDBPGO || Animator.StringToHash(animations[i].stepsList[j].animPlayName) == FHJNHMDBPGO)
				{
					HiddenAnimatorObjectTriggerSet?.Invoke(i, j, FHJNHMDBPGO);
					return;
				}
			}
		}
	}

	public void LOPFGCLNPFO(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
			AnimatorObjectTriggerSet?.Invoke(ELHKDMGIBGC(), EEMLNPCAHDH, FHJNHMDBPGO);
		}
	}

	[SpecialName]
	public int JJGKJOPEDGA()
	{
		return IFGMINEDGHD;
	}

	public void GINMGBDFDLM()
	{
		KHIFDJOLNOD();
		IHCCKKEJAJL();
	}

	public bool CNJEPGJNKEL(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		if (KPOLMEBFMNG == -1)
		{
			return false;
		}
		if (PPEJFJAFDKN == -1)
		{
			return true;
		}
		if (KPOLMEBFMNG >= animations.Count)
		{
			return false;
		}
		if (PPEJFJAFDKN >= animations[KPOLMEBFMNG].stepsList.Count)
		{
			return false;
		}
		return true;
	}

	public void SetHiddenAnimationObjectTrigger(Step ACFILKKNODL, int FHJNHMDBPGO)
	{
		if ((Object)(object)ACFILKKNODL.animatorObject == (Object)null)
		{
			return;
		}
		ACFILKKNODL.animatorObject.SetTrigger(FHJNHMDBPGO);
		for (int i = 0; i < animations.Count; i++)
		{
			for (int j = 0; j < animations[i].stepsList.Count; j++)
			{
				if (Animator.StringToHash(animations[i].stepsList[j].animationName) == FHJNHMDBPGO || Animator.StringToHash(animations[i].stepsList[j].animPlayName) == FHJNHMDBPGO)
				{
					HiddenAnimatorObjectTriggerSet?.Invoke(i, j, FHJNHMDBPGO);
					return;
				}
			}
		}
	}

	public void ICKLCIJDOIG(Step ACFILKKNODL, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (ACFILKKNODL.animationObject)
		{
			ACFILKKNODL.animatorObject.SetFloat(FHJNHMDBPGO, EGFGNGJGBOP);
			AnimatorObjectFloatSet?.Invoke(COGOFPIINDF(), IAPDECMDKNE(), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	public Step GPFEFEKGFNO(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		return animations[KPOLMEBFMNG].stepsList[PPEJFJAFDKN];
	}

	private void LNNLIEJGKCC()
	{
		if (OKCHPKBBKJE() != -1)
		{
			int num = JIFJIDHNOHI();
			FFGBNGNCPKK(num + 0);
			if (EEMLNPCAHDH < animations[EEHKDILAAHI()].stepsList.Count)
			{
				FCFAAJFHPFN(animations[OKCHPKBBKJE()].stepsList[OONDHJHMMJE()]);
			}
			else if (!animations[DPDAONDDOPA()].noLoop)
			{
				FFGBNGNCPKK(1);
				ILEMCIHFJJJ = 1359f;
				JBDHCEEGHDP(animations[COGOFPIINDF()].stepsList[OONDHJHMMJE()]);
			}
			else if (animations[COGOFPIINDF()].stopAtEnd)
			{
				IHIBFMDHLLJ();
			}
		}
	}
}
