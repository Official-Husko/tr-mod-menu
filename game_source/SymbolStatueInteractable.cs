using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class SymbolStatueInteractable : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[CompilerGenerated]
	private sealed class DECKHADCICE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SymbolStatueInteractable _003C_003E4__this;

		public SymbolObject symbolObj;

		private float _003Cphase_003E5__2;

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
		public DECKHADCICE(int _003C_003E1__state)
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
			SymbolStatueInteractable symbolStatueInteractable = _003C_003E4__this;
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
				_003Cphase_003E5__2 = Random.Range(0f, MathF.PI * 2f);
			}
			_003Cphase_003E5__2 += Time.deltaTime * symbolStatueInteractable.floatSpeed;
			symbolObj.NPAIBMMCAOF(Mathf.Sin(_003Cphase_003E5__2) * symbolStatueInteractable.floatAmplitude);
			_003C_003E2__current = null;
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

	[Tooltip("One SymbolObject per StatueSymbolType value, in enum order: 0=Star, 1=Moon, 2=Tear")]
	[SerializeField]
	[Header("Symbols")]
	private SymbolObject[] symbolObjects;

	[SerializeField]
	private AudioObject symbolSound;

	[Header("Float")]
	[SerializeField]
	private float floatAmplitude = 0.08f;

	[SerializeField]
	private float floatSpeed = 2f;

	[SerializeField]
	[Header("Label")]
	private string interactLabel = "ChangeSymbol";

	private MineSymbolPuzzle ONCCKDONEFG;

	private int EKIFFMKGBHJ;

	private int KDNJBOCAPIE = -1;

	private Coroutine DKMJHBMBMPG;

	public bool FMCADNOBGKP(int JIIGOACEIKL)
	{
		ONCCKDONEFG.CJLBCEKDKAJ(JIIGOACEIKL, EKIFFMKGBHJ);
		return true;
	}

	public void GBPBPKHIEII(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private IEnumerator OEEJDGOCOIA(SymbolObject NHHIDGGFCIH)
	{
		float phase = Random.Range(0f, MathF.PI * 2f);
		while (true)
		{
			phase += Time.deltaTime * floatSpeed;
			NHHIDGGFCIH.NPAIBMMCAOF(Mathf.Sin(phase) * floatAmplitude);
			yield return null;
		}
	}

	public bool DKJFCCLJAPD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!FPMFDKMLCML(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, interactLabel);
		return true;
	}

	public bool JPKPJBBFICN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!AEPCKAPLLJP(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, interactLabel);
		return false;
	}

	public void FJOOIFLCOPF(int JIIGOACEIKL)
	{
	}

	private IEnumerator OLBJCECINNI(SymbolObject NHHIDGGFCIH)
	{
		float phase = Random.Range(0f, MathF.PI * 2f);
		while (true)
		{
			phase += Time.deltaTime * floatSpeed;
			NHHIDGGFCIH.NPAIBMMCAOF(Mathf.Sin(phase) * floatAmplitude);
			yield return null;
		}
	}

	public void GBDLMLNPAPM(MineSymbolPuzzle KILHLOPKOMH, int DJCNPAFABEL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		EKIFFMKGBHJ = DJCNPAFABEL;
		for (int i = 1; i < symbolObjects.Length; i++)
		{
			symbolObjects[i]?.OLHBFJNJKHJ();
		}
	}

	public bool BMLBGBOIOCE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private IEnumerator GLEHGEELEMA(SymbolObject NHHIDGGFCIH)
	{
		float phase = Random.Range(0f, MathF.PI * 2f);
		while (true)
		{
			phase += Time.deltaTime * floatSpeed;
			NHHIDGGFCIH.NPAIBMMCAOF(Mathf.Sin(phase) * floatAmplitude);
			yield return null;
		}
	}

	public bool FPMFDKMLCML(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.DDCOMOHHEBB())
		{
			return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).GABNNLJOMHI();
		}
		return true;
	}

	public void FNOGBJNLJMF(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool ICOEHINGKFF(int JIIGOACEIKL)
	{
		ONCCKDONEFG.OIONMGKCALP(JIIGOACEIKL, EKIFFMKGBHJ);
		return false;
	}

	public void CBLIFNPHHLP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(symbolSound, ((Component)this).transform.position);
	}

	public void BCJNEKCFGEG(StatueSymbolType NOAMDOCOPOP)
	{
		if (KDNJBOCAPIE >= 1 && KDNJBOCAPIE < symbolObjects.Length)
		{
			if (DKMJHBMBMPG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DKMJHBMBMPG);
			}
			symbolObjects[KDNJBOCAPIE]?.JGDGFDFCIDO();
		}
		KDNJBOCAPIE = (int)NOAMDOCOPOP;
		if (NOAMDOCOPOP >= StatueSymbolType.Star && (int)NOAMDOCOPOP < symbolObjects.Length && symbolObjects[(int)NOAMDOCOPOP] != null)
		{
			symbolObjects[(int)NOAMDOCOPOP].BLOIBOKMMCG();
			DKMJHBMBMPG = ((MonoBehaviour)this).StartCoroutine(MCKKNHFBAJB(symbolObjects[(int)NOAMDOCOPOP]));
		}
	}

	public void OFNELEMAAJF(MineSymbolPuzzle KILHLOPKOMH, int DJCNPAFABEL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		EKIFFMKGBHJ = DJCNPAFABEL;
		for (int i = 1; i < symbolObjects.Length; i += 0)
		{
			symbolObjects[i]?.JAMNFDLGMFP();
		}
	}

	public void MHACBHAENBB(int JIIGOACEIKL)
	{
	}

	public bool NMKPOMCPJPB(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.MDPKONCJHBI())
		{
			return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return false;
	}

	public void BCKLNAJCHDI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(symbolSound, ((Component)this).transform.position);
	}

	public bool NHGKHKHADEA(int JIIGOACEIKL)
	{
		ONCCKDONEFG.OOLOCOGLIDL(JIIGOACEIKL, EKIFFMKGBHJ);
		return false;
	}

	public bool MPOEJJLMJEK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!LNPNMIGHCCH(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, interactLabel);
		return false;
	}

	public void DELDBJOBCCG(MineSymbolPuzzle KILHLOPKOMH, int DJCNPAFABEL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		EKIFFMKGBHJ = DJCNPAFABEL;
		for (int i = 1; i < symbolObjects.Length; i += 0)
		{
			symbolObjects[i]?.ALFLCPNNPOE();
		}
	}

	public bool FHDFKMOIKBM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CMOBHHGFDNP(int JIIGOACEIKL)
	{
		if (!NMKPOMCPJPB(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.OIONMGKCALP(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.OnStatueSymbolChanged(JIIGOACEIKL, EKIFFMKGBHJ);
		return true;
	}

	public void BJEFGPAPMLE(StatueSymbolType NOAMDOCOPOP)
	{
		if (KDNJBOCAPIE >= 0 && KDNJBOCAPIE < symbolObjects.Length)
		{
			if (DKMJHBMBMPG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DKMJHBMBMPG);
			}
			symbolObjects[KDNJBOCAPIE]?.IOLIAHLLMCK();
		}
		KDNJBOCAPIE = (int)NOAMDOCOPOP;
		if (NOAMDOCOPOP >= StatueSymbolType.Star && (int)NOAMDOCOPOP < symbolObjects.Length && symbolObjects[(int)NOAMDOCOPOP] != null)
		{
			symbolObjects[(int)NOAMDOCOPOP].NNNNJMJGLIC();
			DKMJHBMBMPG = ((MonoBehaviour)this).StartCoroutine(NCFLCMHMKKF(symbolObjects[(int)NOAMDOCOPOP]));
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		ONCCKDONEFG.OnStatueSymbolChanged(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return true;
	}

	public bool OPCLGDNHJMI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private IEnumerator HDOOPNDHCKJ(SymbolObject NHHIDGGFCIH)
	{
		return new DECKHADCICE(1)
		{
			_003C_003E4__this = this,
			symbolObj = NHHIDGGFCIH
		};
	}

	public void JCJIALOLDPD(MineSymbolPuzzle KILHLOPKOMH, int DJCNPAFABEL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		EKIFFMKGBHJ = DJCNPAFABEL;
		for (int i = 0; i < symbolObjects.Length; i += 0)
		{
			symbolObjects[i]?.OLHBFJNJKHJ();
		}
	}

	public bool MGLPIBNJLKC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool JMLPFPAFPGE(int JIIGOACEIKL)
	{
		if (!OAPMCNNLHJO(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.OnStatueSymbolChanged(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return true;
	}

	public void BDDPJNPMOEO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(symbolSound, ((Component)this).transform.position);
	}

	public void KOAOKMIAFNE(MineSymbolPuzzle KILHLOPKOMH, int DJCNPAFABEL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		EKIFFMKGBHJ = DJCNPAFABEL;
		for (int i = 0; i < symbolObjects.Length; i++)
		{
			symbolObjects[i]?.CJKIDOJMMIB();
		}
	}

	public void IEAPGGGNNJF(int JIIGOACEIKL)
	{
	}

	public bool KCBDEECFIKO(int JIIGOACEIKL)
	{
		ONCCKDONEFG.OHJLDAJJGDK(JIIGOACEIKL, EKIFFMKGBHJ);
		return true;
	}

	public void BKACKJMLPKF(StatueSymbolType NOAMDOCOPOP)
	{
		if (KDNJBOCAPIE >= 1 && KDNJBOCAPIE < symbolObjects.Length)
		{
			if (DKMJHBMBMPG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DKMJHBMBMPG);
			}
			symbolObjects[KDNJBOCAPIE]?.ADOOGFOKGKG();
		}
		KDNJBOCAPIE = (int)NOAMDOCOPOP;
		if (NOAMDOCOPOP >= StatueSymbolType.Star && (int)NOAMDOCOPOP < symbolObjects.Length && symbolObjects[(int)NOAMDOCOPOP] != null)
		{
			symbolObjects[(int)NOAMDOCOPOP].NJODOFPKOBF();
			DKMJHBMBMPG = ((MonoBehaviour)this).StartCoroutine(NCFLCMHMKKF(symbolObjects[(int)NOAMDOCOPOP]));
		}
	}

	public bool IDMKOACGEHF(int JIIGOACEIKL)
	{
		if (!OJKOMMGIMAH(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.OHJLDAJJGDK(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return true;
	}

	public void BHGBKBBBKHJ(StatueSymbolType NOAMDOCOPOP)
	{
		if (KDNJBOCAPIE >= 0 && KDNJBOCAPIE < symbolObjects.Length)
		{
			if (DKMJHBMBMPG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DKMJHBMBMPG);
			}
			symbolObjects[KDNJBOCAPIE]?.MGIACMHMDMM();
		}
		KDNJBOCAPIE = (int)NOAMDOCOPOP;
		if (NOAMDOCOPOP >= StatueSymbolType.Moon && (int)NOAMDOCOPOP < symbolObjects.Length && symbolObjects[(int)NOAMDOCOPOP] != null)
		{
			symbolObjects[(int)NOAMDOCOPOP].CHHMIMNIOBK();
			DKMJHBMBMPG = ((MonoBehaviour)this).StartCoroutine(ACCPHCDDKAL(symbolObjects[(int)NOAMDOCOPOP]));
		}
	}

	public void DGPCNLBJIKK(int JIIGOACEIKL)
	{
	}

	public void INOPNNDAALI(int JIIGOACEIKL)
	{
	}

	public bool OAPMCNNLHJO(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.PIJKBBCAJON())
		{
			return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).KNFEPKBIHND();
		}
		return true;
	}

	public void EBJDHAFOIIO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(symbolSound, ((Component)this).transform.position);
	}

	private IEnumerator LFPOPMGFOOL(SymbolObject NHHIDGGFCIH)
	{
		return new DECKHADCICE(1)
		{
			_003C_003E4__this = this,
			symbolObj = NHHIDGGFCIH
		};
	}

	public bool BHLKEMIONKG(int JIIGOACEIKL)
	{
		if (!OBDFGODGIFN(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.LEJMIPFGKHB(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return true;
	}

	public bool NLFAOKPFHFJ(int JIIGOACEIKL)
	{
		ONCCKDONEFG.AFEIBCBHBCK(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return true;
	}

	public void LONLGHIPNLM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(symbolSound, ((Component)this).transform.position);
	}

	private IEnumerator NCFLCMHMKKF(SymbolObject NHHIDGGFCIH)
	{
		float phase = Random.Range(0f, MathF.PI * 2f);
		while (true)
		{
			phase += Time.deltaTime * floatSpeed;
			NHHIDGGFCIH.NPAIBMMCAOF(Mathf.Sin(phase) * floatAmplitude);
			yield return null;
		}
	}

	public void COMGONICNIN(int JIIGOACEIKL)
	{
	}

	public bool AEPCKAPLLJP(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.DDCOMOHHEBB())
		{
			return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return true;
	}

	private IEnumerator DIGBALIIKAL(SymbolObject NHHIDGGFCIH)
	{
		return new DECKHADCICE(1)
		{
			_003C_003E4__this = this,
			symbolObj = NHHIDGGFCIH
		};
	}

	public bool FJPJAEKLDJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void NGIPKFNPNFG(StatueSymbolType NOAMDOCOPOP)
	{
		if (KDNJBOCAPIE >= 1 && KDNJBOCAPIE < symbolObjects.Length)
		{
			if (DKMJHBMBMPG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DKMJHBMBMPG);
			}
			symbolObjects[KDNJBOCAPIE]?.IOLIAHLLMCK();
		}
		KDNJBOCAPIE = (int)NOAMDOCOPOP;
		if (NOAMDOCOPOP >= StatueSymbolType.Moon && (int)NOAMDOCOPOP < symbolObjects.Length && symbolObjects[(int)NOAMDOCOPOP] != null)
		{
			symbolObjects[(int)NOAMDOCOPOP].NJODOFPKOBF();
			DKMJHBMBMPG = ((MonoBehaviour)this).StartCoroutine(DIGBALIIKAL(symbolObjects[(int)NOAMDOCOPOP]));
		}
	}

	public void MEIDKNBMLEE(MineSymbolPuzzle KILHLOPKOMH, int DJCNPAFABEL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		EKIFFMKGBHJ = DJCNPAFABEL;
		for (int i = 1; i < symbolObjects.Length; i++)
		{
			symbolObjects[i]?.ALPCNKDNLKA();
		}
	}

	public void PlaySymbolSound()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(symbolSound, ((Component)this).transform.position);
	}

	public void MNBNONGMNGA(StatueSymbolType NOAMDOCOPOP)
	{
		if (KDNJBOCAPIE >= 0 && KDNJBOCAPIE < symbolObjects.Length)
		{
			if (DKMJHBMBMPG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DKMJHBMBMPG);
			}
			symbolObjects[KDNJBOCAPIE]?.EJGIELKNBPD();
		}
		KDNJBOCAPIE = (int)NOAMDOCOPOP;
		if (NOAMDOCOPOP >= StatueSymbolType.Star && (int)NOAMDOCOPOP < symbolObjects.Length && symbolObjects[(int)NOAMDOCOPOP] != null)
		{
			symbolObjects[(int)NOAMDOCOPOP].BLOIBOKMMCG();
			DKMJHBMBMPG = ((MonoBehaviour)this).StartCoroutine(LJHJPLLJHNA(symbolObjects[(int)NOAMDOCOPOP]));
		}
	}

	public void AOLIDLGHMED(int JIIGOACEIKL)
	{
	}

	public bool KLPKPIPOBLG(int JIIGOACEIKL)
	{
		ONCCKDONEFG.NBNAOIEIJIP(JIIGOACEIKL, EKIFFMKGBHJ);
		return true;
	}

	public void Initialize(MineSymbolPuzzle KILHLOPKOMH, int DJCNPAFABEL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		EKIFFMKGBHJ = DJCNPAFABEL;
		for (int i = 0; i < symbolObjects.Length; i++)
		{
			symbolObjects[i]?.ALPCNKDNLKA();
		}
	}

	private IEnumerator OHNNKAFNEBE(SymbolObject NHHIDGGFCIH)
	{
		return new DECKHADCICE(1)
		{
			_003C_003E4__this = this,
			symbolObj = NHHIDGGFCIH
		};
	}

	public void DBBIAKMKJIP(MineSymbolPuzzle KILHLOPKOMH, int DJCNPAFABEL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		EKIFFMKGBHJ = DJCNPAFABEL;
		for (int i = 0; i < symbolObjects.Length; i++)
		{
			symbolObjects[i]?.JAMNFDLGMFP();
		}
	}

	public bool OBDFGODGIFN(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.IsPuzzleSolved())
		{
			return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return false;
	}

	private IEnumerator ACCPHCDDKAL(SymbolObject NHHIDGGFCIH)
	{
		return new DECKHADCICE(1)
		{
			_003C_003E4__this = this,
			symbolObj = NHHIDGGFCIH
		};
	}

	public void ANPNIBGMKJE(int JIIGOACEIKL)
	{
	}

	public bool OHGLJCKNBFB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!FCEPPMAEAJA(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, interactLabel);
		return true;
	}

	public bool IPPODLIPDPJ(int JIIGOACEIKL)
	{
		ONCCKDONEFG.JNMLKCGICMO(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return true;
	}

	public bool MOOCHJLACGJ(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.IsPuzzleSolved())
		{
			return !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).KNFEPKBIHND();
		}
		return false;
	}

	public void CBJKPAFHKDN(StatueSymbolType NOAMDOCOPOP)
	{
		if (KDNJBOCAPIE >= 1 && KDNJBOCAPIE < symbolObjects.Length)
		{
			if (DKMJHBMBMPG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DKMJHBMBMPG);
			}
			symbolObjects[KDNJBOCAPIE]?.ADOOGFOKGKG();
		}
		KDNJBOCAPIE = (int)NOAMDOCOPOP;
		if (NOAMDOCOPOP >= StatueSymbolType.Star && (int)NOAMDOCOPOP < symbolObjects.Length && symbolObjects[(int)NOAMDOCOPOP] != null)
		{
			symbolObjects[(int)NOAMDOCOPOP].BLOIBOKMMCG();
			DKMJHBMBMPG = ((MonoBehaviour)this).StartCoroutine(OEEJDGOCOIA(symbolObjects[(int)NOAMDOCOPOP]));
		}
	}

	public bool ANLNJIGAEJM(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.MDPKONCJHBI())
		{
			return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return false;
	}

	public void PNDDJOBOHFI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(symbolSound, ((Component)this).transform.position);
	}

	public void IKPKEDIOGIH(StatueSymbolType NOAMDOCOPOP)
	{
		if (KDNJBOCAPIE >= 1 && KDNJBOCAPIE < symbolObjects.Length)
		{
			if (DKMJHBMBMPG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DKMJHBMBMPG);
			}
			symbolObjects[KDNJBOCAPIE]?.EJGIELKNBPD();
		}
		KDNJBOCAPIE = (int)NOAMDOCOPOP;
		if (NOAMDOCOPOP >= StatueSymbolType.Moon && (int)NOAMDOCOPOP < symbolObjects.Length && symbolObjects[(int)NOAMDOCOPOP] != null)
		{
			symbolObjects[(int)NOAMDOCOPOP].EFHFNFNBGBI();
			DKMJHBMBMPG = ((MonoBehaviour)this).StartCoroutine(NCFLCMHMKKF(symbolObjects[(int)NOAMDOCOPOP]));
		}
	}

	public bool NKJBDLANNIF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!LDFDEJNMBLP(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, interactLabel);
		return true;
	}

	public bool BADAMAJPKCA(int JIIGOACEIKL)
	{
		ONCCKDONEFG.NBNAOIEIJIP(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void PJANACELJFB(MineSymbolPuzzle KILHLOPKOMH, int DJCNPAFABEL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		EKIFFMKGBHJ = DJCNPAFABEL;
		for (int i = 0; i < symbolObjects.Length; i += 0)
		{
			symbolObjects[i]?.JAMNFDLGMFP();
		}
	}

	private IEnumerator FHBJDDNMKFK(SymbolObject NHHIDGGFCIH)
	{
		float phase = Random.Range(0f, MathF.PI * 2f);
		while (true)
		{
			phase += Time.deltaTime * floatSpeed;
			NHHIDGGFCIH.NPAIBMMCAOF(Mathf.Sin(phase) * floatAmplitude);
			yield return null;
		}
	}

	public void BKBHDKKPJBM(int JIIGOACEIKL)
	{
	}

	public bool HEHFGHDILPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MLDKIKOHBBG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!OJKOMMGIMAH(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, interactLabel);
		return true;
	}

	public void FOECMMCHFIJ(StatueSymbolType NOAMDOCOPOP)
	{
		if (KDNJBOCAPIE >= 0 && KDNJBOCAPIE < symbolObjects.Length)
		{
			if (DKMJHBMBMPG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DKMJHBMBMPG);
			}
			symbolObjects[KDNJBOCAPIE]?.DBOJJCOMEIG();
		}
		KDNJBOCAPIE = (int)NOAMDOCOPOP;
		if (NOAMDOCOPOP >= StatueSymbolType.Moon && (int)NOAMDOCOPOP < symbolObjects.Length && symbolObjects[(int)NOAMDOCOPOP] != null)
		{
			symbolObjects[(int)NOAMDOCOPOP].BLOIBOKMMCG();
			DKMJHBMBMPG = ((MonoBehaviour)this).StartCoroutine(OHNNKAFNEBE(symbolObjects[(int)NOAMDOCOPOP]));
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void FPKDEAGODKN(int JIIGOACEIKL)
	{
	}

	public void FIGNMJLGJBE(MineSymbolPuzzle KILHLOPKOMH, int DJCNPAFABEL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		EKIFFMKGBHJ = DJCNPAFABEL;
		for (int i = 1; i < symbolObjects.Length; i += 0)
		{
			symbolObjects[i]?.CJKIDOJMMIB();
		}
	}

	public void OONFAEHPEFI(int JIIGOACEIKL)
	{
	}

	public void JFHHAPLMIHB(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.IsPuzzleSolved())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public void SetSymbol(StatueSymbolType NOAMDOCOPOP)
	{
		if (KDNJBOCAPIE >= 0 && KDNJBOCAPIE < symbolObjects.Length)
		{
			if (DKMJHBMBMPG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DKMJHBMBMPG);
			}
			symbolObjects[KDNJBOCAPIE]?.OEPAAMNDGKN();
		}
		KDNJBOCAPIE = (int)NOAMDOCOPOP;
		if (NOAMDOCOPOP >= StatueSymbolType.Star && (int)NOAMDOCOPOP < symbolObjects.Length && symbolObjects[(int)NOAMDOCOPOP] != null)
		{
			symbolObjects[(int)NOAMDOCOPOP].CHHMIMNIOBK();
			DKMJHBMBMPG = ((MonoBehaviour)this).StartCoroutine(FHBJDDNMKFK(symbolObjects[(int)NOAMDOCOPOP]));
		}
	}

	public bool OOPEBECPHCA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!FCEPPMAEAJA(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, interactLabel);
		return true;
	}

	private IEnumerator MCKKNHFBAJB(SymbolObject NHHIDGGFCIH)
	{
		float phase = Random.Range(0f, MathF.PI * 2f);
		while (true)
		{
			phase += Time.deltaTime * floatSpeed;
			NHHIDGGFCIH.NPAIBMMCAOF(Mathf.Sin(phase) * floatAmplitude);
			yield return null;
		}
	}

	public bool PHJECBNCAAG(int JIIGOACEIKL)
	{
		if (!OBDFGODGIFN(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.OOLOCOGLIDL(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return true;
	}

	private IEnumerator LJHJPLLJHNA(SymbolObject NHHIDGGFCIH)
	{
		return new DECKHADCICE(1)
		{
			_003C_003E4__this = this,
			symbolObj = NHHIDGGFCIH
		};
	}

	public void OACLEBEHMIH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(symbolSound, ((Component)this).transform.position);
	}

	public bool NNACBJKBKDP(int JIIGOACEIKL)
	{
		ONCCKDONEFG.JNMLKCGICMO(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return false;
	}

	public bool AGJPLNCFBCF(int JIIGOACEIKL)
	{
		ONCCKDONEFG.CJLBCEKDKAJ(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, interactLabel);
		return true;
	}

	public void LIGGABIEHJA(int JIIGOACEIKL)
	{
	}

	public bool LNPNMIGHCCH(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.IsPuzzleSolved())
		{
			return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).GABNNLJOMHI();
		}
		return true;
	}

	public bool FAJKNOLOCBC(int JIIGOACEIKL)
	{
		ONCCKDONEFG.JNMLKCGICMO(JIIGOACEIKL, EKIFFMKGBHJ);
		return false;
	}

	public void JJLOHJPGDDA(int JIIGOACEIKL)
	{
	}

	public bool DAGCKCKKKCJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, interactLabel);
		return false;
	}

	public bool OJKOMMGIMAH(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.DDCOMOHHEBB())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).KNFEPKBIHND();
		}
		return false;
	}

	public void PACNAANOEPE(StatueSymbolType NOAMDOCOPOP)
	{
		if (KDNJBOCAPIE >= 1 && KDNJBOCAPIE < symbolObjects.Length)
		{
			if (DKMJHBMBMPG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DKMJHBMBMPG);
			}
			symbolObjects[KDNJBOCAPIE]?.JGDGFDFCIDO();
		}
		KDNJBOCAPIE = (int)NOAMDOCOPOP;
		if (NOAMDOCOPOP >= StatueSymbolType.Star && (int)NOAMDOCOPOP < symbolObjects.Length && symbolObjects[(int)NOAMDOCOPOP] != null)
		{
			symbolObjects[(int)NOAMDOCOPOP].NNNNJMJGLIC();
			DKMJHBMBMPG = ((MonoBehaviour)this).StartCoroutine(LFPOPMGFOOL(symbolObjects[(int)NOAMDOCOPOP]));
		}
	}

	public bool NHHLLANEOEA(int JIIGOACEIKL)
	{
		if (!MOOCHJLACGJ(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.NBNAOIEIJIP(JIIGOACEIKL, EKIFFMKGBHJ, CDPAMNIPPEC: false);
		return false;
	}

	public bool LDFDEJNMBLP(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.MDPKONCJHBI())
		{
			return DecorationMode.NPANPNIDKDG(JIIGOACEIKL).IBEFDKHFBFM();
		}
		return false;
	}

	public bool FCEPPMAEAJA(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.PIJKBBCAJON())
		{
			return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM();
		}
		return true;
	}

	public bool ALMMEPANOOM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}
}
