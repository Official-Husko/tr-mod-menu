using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NPCBed : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class HHECIFGGJPH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NPCBed _003C_003E4__this;

		public CharacterAnimation characterAnimation;

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
		public HHECIFGGJPH(int _003C_003E1__state)
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
			NPCBed nPCBed = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				if (Time.time > nPCBed.MKIGBIIBGPD)
				{
					nPCBed.doWork.Stop();
					nPCBed.LHEFGDNMEHN(characterAnimation);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (nPCBed.doWork.JCMBHAEKLKK)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			nPCBed.OIPDMJCGJIB = null;
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

	private const int EHLLICIEINK = 1200;

	public Action OnBedMade = delegate
	{
	};

	public Action OnBedUnmade = delegate
	{
	};

	[SerializeField]
	private Sprite bedUnmadeSprite;

	[SerializeField]
	private Sprite bedMadeSprite;

	[SerializeField]
	private Sprite bedUnmadeSpriteTutorial;

	[SerializeField]
	private Sprite bedMadeSpriteTutorial;

	[SerializeField]
	private SpriteRenderer bedFrontSR;

	[SerializeField]
	private SpriteRenderer bedFrontSRTutorial;

	private bool BLGFCMHJBOF = true;

	[SerializeField]
	private DoWork doWork;

	private float MKIGBIIBGPD;

	private string BMAODKKCGDH = "Bed is unmade";

	public OnlineBed onlineBed;

	private Coroutine OIPDMJCGJIB;

	public bool IDHLOLDLLOE
	{
		get
		{
			return BLGFCMHJBOF;
		}
		set
		{
			BLGFCMHJBOF = value;
			UpdateSprites();
			if (BLGFCMHJBOF)
			{
				((Component)this).GetComponent<Placeable>().selectBlockers.Remove(BMAODKKCGDH);
				OnBedMade();
			}
			else
			{
				((Component)this).GetComponent<Placeable>().selectBlockers.Add(BMAODKKCGDH);
				OnBedUnmade();
			}
		}
	}

	private void LKHMCLABKLG()
	{
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BAIHOECGIND(EIMGLPAMFDN);
		}
	}

	public void PNFKIHGMBLG(int JIIGOACEIKL)
	{
	}

	[SpecialName]
	public void EDCINOGOEDC(bool AODONKKHPBP)
	{
		BLGFCMHJBOF = AODONKKHPBP;
		NJGCDCKKOAK();
		if (BLGFCMHJBOF)
		{
			((Component)this).GetComponent<Placeable>().selectBlockers.Remove(BMAODKKCGDH);
			OnBedMade();
		}
		else
		{
			((Component)this).GetComponent<Placeable>().selectBlockers.Add(BMAODKKCGDH);
			OnBedUnmade();
		}
	}

	private void EIMGLPAMFDN(int JIIGOACEIKL)
	{
		SetBedMade(NBBELPFDLJG: true, CDPAMNIPPEC: true);
	}

	private void LALJNGFGKPA()
	{
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.OKKPFFIIDEC(CMOAJOLHKAN);
		}
	}

	private IEnumerator POPADKKNEAL(CharacterAnimation FJHKGBNBNKL)
	{
		return new HHECIFGGJPH(1)
		{
			_003C_003E4__this = this,
			characterAnimation = FJHKGBNBNKL
		};
	}

	[SpecialName]
	public bool LILIGKKMAOJ()
	{
		return BLGFCMHJBOF;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return MakeBed(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation);
	}

	public void NJGCDCKKOAK()
	{
		bedFrontSR.sprite = (BLGFCMHJBOF ? bedMadeSprite : bedUnmadeSprite);
		if ((Object)(object)bedFrontSRTutorial != (Object)null)
		{
			bedFrontSRTutorial.sprite = (BLGFCMHJBOF ? bedMadeSpriteTutorial : bedUnmadeSpriteTutorial);
		}
	}

	public bool JNCIONKLFBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return MakeBed(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation, 1823f);
	}

	public void JGHHNJGLNHB(bool NBBELPFDLJG, bool CDPAMNIPPEC)
	{
		IDHLOLDLLOE = NBBELPFDLJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineBed.EGBMKCPMEHE(NBBELPFDLJG);
		}
	}

	public bool LGDMGLJCBJM(int JIIGOACEIKL)
	{
		APKMPNOAEIC(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation);
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void GONDLJKGLGO()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BECJEKINIFB(CMOAJOLHKAN);
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void JBNGENAHPGM()
	{
		bedFrontSR.sprite = (BLGFCMHJBOF ? bedMadeSprite : bedUnmadeSprite);
		if ((Object)(object)bedFrontSRTutorial != (Object)null)
		{
			bedFrontSRTutorial.sprite = (BLGFCMHJBOF ? bedMadeSpriteTutorial : bedUnmadeSpriteTutorial);
		}
	}

	private void CHNDAAPNFAE(int JIIGOACEIKL)
	{
		SetBedMade(NBBELPFDLJG: false, CDPAMNIPPEC: false);
	}

	private void FLFNACCJOFB(CharacterAnimation FJHKGBNBNKL)
	{
		FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
	}

	public bool MakeBed(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 600f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.GetPlayer(JIIGOACEIKL).CFICAAJGBOF != "UI"))
		{
			if (doWork.JCMBHAEKLKK)
			{
				if (doWork.AddWorkDone(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
				{
					LHEFGDNMEHN(FJHKGBNBNKL);
					return true;
				}
				MKIGBIIBGPD = Time.time + 0.1f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
				return false;
			}
			if (!IDHLOLDLLOE)
			{
				doWork.StartWork(1200f);
				MKIGBIIBGPD = Time.time + 0.1f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
				if (JIIGOACEIKL != 0 && OIPDMJCGJIB == null)
				{
					OIPDMJCGJIB = ((MonoBehaviour)this).StartCoroutine(CKOGCKCGDPA(FJHKGBNBNKL));
				}
				return false;
			}
			if (doWork.OJLICLKJJOF >= 1200f)
			{
				LHEFGDNMEHN(FJHKGBNBNKL);
				return false;
			}
			return false;
		}
		LHEFGDNMEHN(FJHKGBNBNKL);
		return false;
	}

	private void CMOAJOLHKAN(int JIIGOACEIKL)
	{
		SetBedMade(NBBELPFDLJG: false, CDPAMNIPPEC: true);
	}

	private IEnumerator DLINNBHKFIN(CharacterAnimation FJHKGBNBNKL)
	{
		return new HHECIFGGJPH(1)
		{
			_003C_003E4__this = this,
			characterAnimation = FJHKGBNBNKL
		};
	}

	public void ChangeBedSprites(Sprite NBBELPFDLJG, Sprite LLHHDIMGIIC)
	{
		bedMadeSprite = NBBELPFDLJG;
		bedUnmadeSprite = LLHHDIMGIIC;
		UpdateSprites();
	}

	[SpecialName]
	public bool EJPBEEPOJKB()
	{
		return BLGFCMHJBOF;
	}

	private void APKMPNOAEIC(CharacterAnimation FJHKGBNBNKL)
	{
		FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: false);
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Make bed"));
			return true;
		}
		return false;
	}

	public bool LOCIBONDBGF(int JIIGOACEIKL)
	{
		LHEFGDNMEHN(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation);
		return true;
	}

	public bool MEPAIBJILMH(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 600f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.GetPlayer(JIIGOACEIKL).AAGNDCEODFO() != "PirateMinigame/Minigame2"))
		{
			if (doWork.OENMBFGINAL())
			{
				if (doWork.PFLPFNICHJA(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
				{
					LHEFGDNMEHN(FJHKGBNBNKL);
					return true;
				}
				MKIGBIIBGPD = Time.time + 1559f;
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: true);
				return false;
			}
			if (!IDHLOLDLLOE)
			{
				doWork.GEJFAPKOLJH(680f);
				MKIGBIIBGPD = Time.time + 937f;
				FJHKGBNBNKL.BNGPBEOAGCH(KOIDJKBBINH: false);
				if (JIIGOACEIKL != 0 && OIPDMJCGJIB == null)
				{
					OIPDMJCGJIB = ((MonoBehaviour)this).StartCoroutine(CKOGCKCGDPA(FJHKGBNBNKL));
				}
				return true;
			}
			if (doWork.OJLICLKJJOF >= 1836f)
			{
				APKMPNOAEIC(FJHKGBNBNKL);
				return true;
			}
			return true;
		}
		FLFNACCJOFB(FJHKGBNBNKL);
		return true;
	}

	public bool CAJMKLBCBEK(int JIIGOACEIKL)
	{
		LHEFGDNMEHN(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation);
		return false;
	}

	public bool BBAFEKJIALK(int JIIGOACEIKL)
	{
		return false;
	}

	public void EKMBJHDPHPM(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool MEEJECDJJNK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && JPDMPGABGAD(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("LE_10"));
			return true;
		}
		return false;
	}

	public void SetBedMade(bool NBBELPFDLJG, bool CDPAMNIPPEC)
	{
		IDHLOLDLLOE = NBBELPFDLJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineBed.SendBedMade(NBBELPFDLJG);
		}
	}

	public void NLLENLLOBLH(int JIIGOACEIKL)
	{
	}

	private IEnumerator CKOGCKCGDPA(CharacterAnimation FJHKGBNBNKL)
	{
		while (doWork.JCMBHAEKLKK)
		{
			yield return null;
			if (Time.time > MKIGBIIBGPD)
			{
				doWork.Stop();
				LHEFGDNMEHN(FJHKGBNBNKL);
			}
			yield return null;
		}
		OIPDMJCGJIB = null;
	}

	public void KMPILLCNJPC(int JIIGOACEIKL)
	{
	}

	private void LHEFGDNMEHN(CharacterAnimation FJHKGBNBNKL)
	{
		FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		LHEFGDNMEHN(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation);
		return false;
	}

	public void GIIDCCEDHOF(int JIIGOACEIKL)
	{
	}

	public void COMGONICNIN(int JIIGOACEIKL)
	{
	}

	public bool BKPEBOBAIJI(int JIIGOACEIKL)
	{
		if (doWork.JCMBHAEKLKK || !LILIGKKMAOJ())
		{
			return DecorationMode.OCJGHINCLJM(JIIGOACEIKL).GABNNLJOMHI();
		}
		return false;
	}

	public bool EBIDPMLPLIA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return MakeBed(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation, 1601f);
	}

	public bool JPDMPGABGAD(int JIIGOACEIKL)
	{
		if (doWork.KGOEFMFHCOG() || !LILIGKKMAOJ())
		{
			return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return true;
	}

	private void OnDestroy()
	{
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BGIJPOMIIMB -= EIMGLPAMFDN;
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (doWork.JCMBHAEKLKK || !IDHLOLDLLOE)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public void UpdateSprites()
	{
		bedFrontSR.sprite = (BLGFCMHJBOF ? bedMadeSprite : bedUnmadeSprite);
		if ((Object)(object)bedFrontSRTutorial != (Object)null)
		{
			bedFrontSRTutorial.sprite = (BLGFCMHJBOF ? bedMadeSpriteTutorial : bedUnmadeSpriteTutorial);
		}
	}

	private void KHONOODGLBI()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BGIJPOMIIMB += EIMGLPAMFDN;
		}
	}

	public void FOGLDLKAEBK(int JIIGOACEIKL)
	{
	}

	private void Awake()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BGIJPOMIIMB += EIMGLPAMFDN;
		}
	}

	public void NDMIJJJOOAA()
	{
		bedFrontSR.sprite = (BLGFCMHJBOF ? bedMadeSprite : bedUnmadeSprite);
		if ((Object)(object)bedFrontSRTutorial != (Object)null)
		{
			bedFrontSRTutorial.sprite = (BLGFCMHJBOF ? bedMadeSpriteTutorial : bedUnmadeSpriteTutorial);
		}
	}

	private void FGFGCADFFBC()
	{
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BAIHOECGIND(CMOAJOLHKAN);
		}
	}

	public void HFFHJBLMGAB(int JIIGOACEIKL)
	{
	}

	public void LIAIAOFMOAP(bool NBBELPFDLJG, bool CDPAMNIPPEC)
	{
		EDCINOGOEDC(NBBELPFDLJG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineBed.EGBMKCPMEHE(NBBELPFDLJG);
		}
	}

	private void HINKPJCNPCF()
	{
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BAIHOECGIND(CMOAJOLHKAN);
		}
	}

	public void GCBLINFFFKC(int JIIGOACEIKL)
	{
	}

	[SpecialName]
	public bool JAFKAMIDNPJ()
	{
		return BLGFCMHJBOF;
	}

	public bool HGBEJIIANJP(int JIIGOACEIKL)
	{
		if (doWork.OENMBFGINAL() || !IDHLOLDLLOE)
		{
			return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).GABNNLJOMHI();
		}
		return false;
	}

	private void FPNCANODJKE()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BGIJPOMIIMB += EIMGLPAMFDN;
		}
	}
}
