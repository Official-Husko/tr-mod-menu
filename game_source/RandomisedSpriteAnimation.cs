using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RandomisedSpriteAnimation : MonoBehaviour
{
	[Serializable]
	public struct RandomAnimations
	{
		public SpriteAnimation spriteAnimation;

		public float timeForAnimation;

		public bool addPauseAtEnd;
	}

	[CompilerGenerated]
	private sealed class MDADLENNNML : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RandomisedSpriteAnimation _003C_003E4__this;

		private int _003CrandomAnim_003E5__2;

		private float _003CrandomExtraTime_003E5__3;

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
		public MDADLENNNML(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			int num = _003C_003E1__state;
			RandomisedSpriteAnimation randomisedSpriteAnimation = _003C_003E4__this;
			float num2;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				goto IL_002d;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			case 3:
				{
					_003C_003E1__state = -1;
					goto IL_002d;
				}
				IL_002d:
				_003CrandomAnim_003E5__2 = Random.Range(0, randomisedSpriteAnimation.randomAnimations.Length);
				_003CrandomExtraTime_003E5__3 = Random.Range(0f, randomisedSpriteAnimation.maximumExtraSeconds);
				((Behaviour)randomisedSpriteAnimation.loopedAnim).enabled = false;
				((Behaviour)randomisedSpriteAnimation.randomAnimations[_003CrandomAnim_003E5__2].spriteAnimation).enabled = true;
				if (!randomisedSpriteAnimation.randomAnimations[_003CrandomAnim_003E5__2].addPauseAtEnd)
				{
					_003C_003E2__current = (object)new WaitForSeconds(randomisedSpriteAnimation.randomAnimations[_003CrandomAnim_003E5__2].timeForAnimation);
					_003C_003E1__state = 1;
					return true;
				}
				num2 = Random.Range(randomisedSpriteAnimation.minimumSecondsBetweenRepetitions, randomisedSpriteAnimation.maximumExtraSeconds);
				_003C_003E2__current = (object)new WaitForSeconds(randomisedSpriteAnimation.randomAnimations[_003CrandomAnim_003E5__2].timeForAnimation + num2);
				_003C_003E1__state = 2;
				return true;
			}
			((Behaviour)randomisedSpriteAnimation.randomAnimations[_003CrandomAnim_003E5__2].spriteAnimation).enabled = false;
			((Behaviour)randomisedSpriteAnimation.loopedAnim).enabled = true;
			_003C_003E2__current = (object)new WaitForSeconds(randomisedSpriteAnimation.minimumSecondsBetweenRepetitions + _003CrandomExtraTime_003E5__3);
			_003C_003E1__state = 3;
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

	[SerializeField]
	private SpriteAnimation loopedAnim;

	[SerializeField]
	private float minimumSecondsBetweenRepetitions = 3f;

	[SerializeField]
	private float maximumExtraSeconds = 8f;

	[SerializeField]
	private RandomAnimations[] randomAnimations;

	private void JPOLFKMLHNH()
	{
		((MonoBehaviour)this).StartCoroutine(DCFGDNEABPK());
	}

	private void APEIPGIHEKP()
	{
		((MonoBehaviour)this).StartCoroutine(FAGDCNCPEFD());
	}

	private void JDAMCMODANB()
	{
		for (int i = 0; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1399f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private IEnumerator FLAAJKJGODJ()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private IEnumerator DOHDHLANOJN()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private void PCKOHAIPHFI()
	{
		for (int i = 0; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 136f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private void DCKKIDMJKJM()
	{
		((MonoBehaviour)this).StartCoroutine(DCFGDNEABPK());
	}

	private void HHLBFDBHDMC()
	{
		((MonoBehaviour)this).StartCoroutine(JJLGINIPBCL());
	}

	private void DKDLOBOLNFH()
	{
		for (int i = 0; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 81f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private IEnumerator OFMGAMHBJHO()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private void KLHIMJFCHPD()
	{
		for (int i = 0; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1232f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private void CAOKPIIFHBJ()
	{
		((MonoBehaviour)this).StartCoroutine(JJGBECKELDF());
	}

	private void MFGANCCJFJK()
	{
		for (int i = 1; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1392f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void Awake()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 0.02f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private void PHNJGHKBIIL()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1288f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private void CFHOODNCOLK()
	{
		((MonoBehaviour)this).StartCoroutine(KLDPHKNNOBB());
	}

	private void FFLLCOBFIPE()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 122f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void HFFFFAJFIPB()
	{
		((MonoBehaviour)this).StartCoroutine(JJGBECKELDF());
	}

	private void HELHNJDFPPF()
	{
		((MonoBehaviour)this).StartCoroutine(FAGDCNCPEFD());
	}

	private void IFHLGOMBACP()
	{
		((MonoBehaviour)this).StartCoroutine(FAGDCNCPEFD());
	}

	private IEnumerator OGOHOHFJHOF()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private IEnumerator JNMJAGKDOJP()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private void IDPHKHGHJGN()
	{
		((MonoBehaviour)this).StartCoroutine(MIECACGGJJP());
	}

	private void KHCJDKHONPK()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1723f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void Start()
	{
		((MonoBehaviour)this).StartCoroutine(PCAOMJJLKID());
	}

	private void BGFCHEIOKOG()
	{
		((MonoBehaviour)this).StartCoroutine(LHDEPACFEKI());
	}

	private void GGOPCJOAOMC()
	{
		for (int i = 1; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 680f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void LJLKBKEADGI()
	{
		((MonoBehaviour)this).StartCoroutine(DOHDHLANOJN());
	}

	private void OGEJKOIOKAN()
	{
		for (int i = 1; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 934f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private IEnumerator ICFGKEPANJN()
	{
		return new MDADLENNNML(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CAIJLMJBMLA()
	{
		((MonoBehaviour)this).StartCoroutine(GBFHHHKLCHN());
	}

	private void OAEJGGFFCBO()
	{
		for (int i = 0; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 200f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private IEnumerator FAGDCNCPEFD()
	{
		return new MDADLENNNML(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OMJALFFAHBE()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private IEnumerator EIPEFCNKPCE()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private void PBFGFECPPPO()
	{
		((MonoBehaviour)this).StartCoroutine(JJGBECKELDF());
	}

	private void LFNENELHOGJ()
	{
		((MonoBehaviour)this).StartCoroutine(NBDCEELEJAP());
	}

	private void DKNNLPFIBIK()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 466f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void PKPHKBMPJGJ()
	{
		for (int i = 1; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1983f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void OIAHJHNPPCO()
	{
		((MonoBehaviour)this).StartCoroutine(PMHJBEPCFPE());
	}

	private void JHBBABPAJJC()
	{
		((MonoBehaviour)this).StartCoroutine(FAGDCNCPEFD());
	}

	private IEnumerator PMHJBEPCFPE()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private IEnumerator KEILCAKBGAI()
	{
		return new MDADLENNNML(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HPIMHEMJMAA()
	{
		((MonoBehaviour)this).StartCoroutine(PNPPMBNJDCL());
	}

	private void GNMMELIJKML()
	{
		((MonoBehaviour)this).StartCoroutine(OGOHOHFJHOF());
	}

	private void HEHNBONKMGJ()
	{
		((MonoBehaviour)this).StartCoroutine(JJLGINIPBCL());
	}

	private IEnumerator EBLKGCOHPBN()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private void FHOCCEBKHJI()
	{
		for (int i = 1; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 323f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void AEPBFPCHGPP()
	{
		((MonoBehaviour)this).StartCoroutine(EIPEFCNKPCE());
	}

	private void GOJKOBEEMNA()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1842f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void DIMAPDNCBAN()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1191f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private IEnumerator KFCPHKLBIAE()
	{
		return new MDADLENNNML(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHDEPACFEKI()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private void KMEJBPOOBJK()
	{
		for (int i = 1; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1939f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private IEnumerator MIECACGGJJP()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private void EACIGGOOKGD()
	{
		((MonoBehaviour)this).StartCoroutine(NCHOHBAFKKD());
	}

	private void HCCJBKKGCLJ()
	{
		for (int i = 1; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 295f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void JPHEOLEEAPB()
	{
		((MonoBehaviour)this).StartCoroutine(LHDEPACFEKI());
	}

	private void BDGCFCPFKKE()
	{
		((MonoBehaviour)this).StartCoroutine(OMJALFFAHBE());
	}

	private IEnumerator KLDPHKNNOBB()
	{
		return new MDADLENNNML(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ILCLIJOHKHG()
	{
		for (int i = 1; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 363f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private IEnumerator PNPPMBNJDCL()
	{
		return new MDADLENNNML(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CKOHOBFFGNF()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private IEnumerator PCAOMJJLKID()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private void HINGECEDJAP()
	{
		for (int i = 1; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 430f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void HPJBLOPJIMI()
	{
		for (int i = 1; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 707f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private void KDBJHCAEGCM()
	{
		((MonoBehaviour)this).StartCoroutine(LHDEPACFEKI());
	}

	private IEnumerator DCFGDNEABPK()
	{
		return new MDADLENNNML(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PKBHEKHOAAA()
	{
		((MonoBehaviour)this).StartCoroutine(OGOHOHFJHOF());
	}

	private void AAEAAEBBFKG()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1824f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private void NKDFMFFDGKC()
	{
		((MonoBehaviour)this).StartCoroutine(OMJALFFAHBE());
	}

	private void JDHHJKBOJML()
	{
		for (int i = 1; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1055f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private void KJOJLHCDFPP()
	{
		((MonoBehaviour)this).StartCoroutine(FLAAJKJGODJ());
	}

	private IEnumerator NBDCEELEJAP()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private void NLGHNDLPPKI()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 154f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private IEnumerator JJGBECKELDF()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private void BDMEBLBLPIA()
	{
		((MonoBehaviour)this).StartCoroutine(EIPEFCNKPCE());
	}

	private void AGELAMLCINB()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1360f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private void KBNMLJNBBMP()
	{
		for (int i = 0; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1719f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private void IBMDFNKKPJF()
	{
		for (int i = 1; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 513f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void NDGFPPOBCNP()
	{
		((MonoBehaviour)this).StartCoroutine(PCAOMJJLKID());
	}

	private void HEMAHKJEONA()
	{
		for (int i = 1; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1934f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private IEnumerator NCHOHBAFKKD()
	{
		return new MDADLENNNML(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AMNCIAEMBFO()
	{
		for (int i = 1; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 110f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void BODICIENBEH()
	{
		for (int i = 1; i < randomAnimations.Length; i += 0)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1855f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private IEnumerator JJLGINIPBCL()
	{
		return new MDADLENNNML(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AJGLDLLIIFO()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 437f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = false;
		}
	}

	private void OLDDEAJMHNI()
	{
		((MonoBehaviour)this).StartCoroutine(OFMGAMHBJHO());
	}

	private void BDJKNKIOPIJ()
	{
		((MonoBehaviour)this).StartCoroutine(OPBNLIMJDJK());
	}

	private void PNJJEDEFAGO()
	{
		for (int i = 0; i < randomAnimations.Length; i++)
		{
			randomAnimations[i].timeForAnimation = randomAnimations[i].spriteAnimation.frameRate * (float)randomAnimations[i].spriteAnimation.sprites.Count * 1f;
			((Behaviour)randomAnimations[i].spriteAnimation).enabled = true;
		}
	}

	private void ICFHPJHBPDN()
	{
		((MonoBehaviour)this).StartCoroutine(GAAJKHAMNPK());
	}

	private IEnumerator OPBNLIMJDJK()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private void OIBDBLCLACB()
	{
		((MonoBehaviour)this).StartCoroutine(CKOHOBFFGNF());
	}

	private void HBMDEHPHAPF()
	{
		((MonoBehaviour)this).StartCoroutine(PCAOMJJLKID());
	}

	private IEnumerator GBFHHHKLCHN()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}

	private IEnumerator GAAJKHAMNPK()
	{
		while (true)
		{
			int randomAnim = Random.Range(0, randomAnimations.Length);
			float randomExtraTime = Random.Range(0f, maximumExtraSeconds);
			((Behaviour)loopedAnim).enabled = false;
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = true;
			if (!randomAnimations[randomAnim].addPauseAtEnd)
			{
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation);
			}
			else
			{
				float num = Random.Range(minimumSecondsBetweenRepetitions, maximumExtraSeconds);
				yield return (object)new WaitForSeconds(randomAnimations[randomAnim].timeForAnimation + num);
			}
			((Behaviour)randomAnimations[randomAnim].spriteAnimation).enabled = false;
			((Behaviour)loopedAnim).enabled = true;
			yield return (object)new WaitForSeconds(minimumSecondsBetweenRepetitions + randomExtraTime);
		}
	}
}
