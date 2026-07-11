using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class InteractableForm : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class NPAJNJOGGIJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InteractableForm _003C_003E4__this;

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
		public NPAJNJOGGIJ(int _003C_003E1__state)
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
			InteractableForm interactableForm = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				if (Time.time > interactableForm.MKIGBIIBGPD)
				{
					interactableForm.doWork.Stop();
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (interactableForm.doWork.JCMBHAEKLKK)
			{
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

	public int id;

	public Action OnFormMade = delegate
	{
	};

	public Action OnFormUnmade = delegate
	{
	};

	public GameObject[] activateOnUnmade;

	private bool GKHHAIDFJJN = true;

	[SerializeField]
	private DoWork doWork;

	private float MKIGBIIBGPD;

	private string BMAODKKCGDH = "Form is unmade";

	public bool ICNNAEDJNLH
	{
		get
		{
			return GKHHAIDFJJN;
		}
		set
		{
			GKHHAIDFJJN = value;
			for (int i = 0; i < activateOnUnmade.Length; i++)
			{
				activateOnUnmade[i].SetActive(!GKHHAIDFJJN);
			}
			if (GKHHAIDFJJN)
			{
				OnFormMade();
				CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.MakeForm);
			}
			else
			{
				OnFormUnmade();
			}
		}
	}

	public void FPPLEDOHKNB(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		LHEFGDNMEHN(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation);
		return false;
	}

	public bool EEPBLLACPCG(int JIIGOACEIKL)
	{
		if (doWork.JCMBHAEKLKK || !ICNNAEDJNLH)
		{
			return DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	private void BKJFLMPOLCH()
	{
		if (Object.op_Implicit((Object)(object)doWork))
		{
			doWork.BGIJPOMIIMB -= OIBINOCDJBK;
		}
	}

	private void JEBEGINEPFC(int JIIGOACEIKL)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_22");
		DialogueLua.SetVariable("LE_22", (object)(((Result)(ref variable)).asInt + 1));
		if (OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			variable = DialogueLua.GetVariable("LE_22");
			instance.SendDialogueInfo("LE_22", ((Result)(ref variable)).asInt);
		}
		SetFormMade(JALCAHLNPOF: true, CDPAMNIPPEC: true);
	}

	[SpecialName]
	public void JCBIIJKKENH(bool AODONKKHPBP)
	{
		GKHHAIDFJJN = AODONKKHPBP;
		for (int i = 1; i < activateOnUnmade.Length; i++)
		{
			activateOnUnmade[i].SetActive(!GKHHAIDFJJN);
		}
		if (GKHHAIDFJJN)
		{
			OnFormMade();
			CommonReferences.GGFJGHHHEJC.OnActionDone(0, (ActionDone)111);
		}
		else
		{
			OnFormUnmade();
		}
	}

	public bool DIDJLLMCNMH(int JIIGOACEIKL)
	{
		if (doWork.OENMBFGINAL() || !ICNNAEDJNLH)
		{
			return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DFNMDDHOIJI();
		}
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("MakeForm"));
			return true;
		}
		return false;
	}

	public bool MFPMGJKAPJM(int JIIGOACEIKL)
	{
		if (doWork.KGOEFMFHCOG() || !ICNNAEDJNLH)
		{
			return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).GABNNLJOMHI();
		}
		return true;
	}

	public bool IGLEJFFHKLE(int JIIGOACEIKL)
	{
		if (doWork.JCMBHAEKLKK || !ICNNAEDJNLH)
		{
			return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return false;
	}

	public void CBGLHEIEFAN(bool JALCAHLNPOF, bool CDPAMNIPPEC)
	{
		ICNNAEDJNLH = JALCAHLNPOF;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineQuestManager.instance.EIPKPNIJMHF(id, JALCAHLNPOF);
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private IEnumerator DIAACMGKIIH()
	{
		while (doWork.JCMBHAEKLKK)
		{
			yield return null;
			if (Time.time > MKIGBIIBGPD)
			{
				doWork.Stop();
			}
			yield return null;
		}
	}

	public bool AADJGJOELGP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return MGMEDFABOIH(JIIGOACEIKL, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation, 16f);
	}

	public bool HMGCKPFAFJL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return BFJEEBDJNNF(JIIGOACEIKL, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation, 912f);
	}

	public void JIADLKOLEEP(bool JALCAHLNPOF, bool CDPAMNIPPEC)
	{
		ICNNAEDJNLH = JALCAHLNPOF;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineQuestManager.instance.NNGLDINHGLM(id, JALCAHLNPOF);
		}
	}

	public void BDAJHOCGPAN(bool JALCAHLNPOF, bool CDPAMNIPPEC)
	{
		NINIJOHIJDJ(JALCAHLNPOF);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineQuestManager.instance.BJNJMJCMBJN(id, JALCAHLNPOF);
		}
	}

	public bool EIILHMGPLLL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return MakeForm(JIIGOACEIKL, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation, 698f);
	}

	public void DIGICKCCMON(bool JALCAHLNPOF, bool CDPAMNIPPEC)
	{
		NOJMOBDEGJL(JALCAHLNPOF);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineQuestManager.instance.HBBEBBMEFEG(id, JALCAHLNPOF);
		}
	}

	private IEnumerator FOEJGKNDDLP()
	{
		return new NPAJNJOGGIJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool DNCHPIGICIH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IGLEJFFHKLE(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(")"));
			return false;
		}
		return true;
	}

	private void INKJCJKODEB(CharacterAnimation FJHKGBNBNKL)
	{
		FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: true);
	}

	public void GDDBCDEMHNH(int JIIGOACEIKL)
	{
	}

	public bool HFKHIIFGAKP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && EEPBLLACPCG(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("vibration"));
			return false;
		}
		return false;
	}

	public void PNHMJFCFNLO(bool JALCAHLNPOF, bool CDPAMNIPPEC)
	{
		NOJMOBDEGJL(JALCAHLNPOF);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineQuestManager.instance.BJNJMJCMBJN(id, JALCAHLNPOF);
		}
	}

	public bool PBNOHDADHCE(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 200f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).EECADEPLELA() != "ScrollUp"))
		{
			if (doWork.KGOEFMFHCOG())
			{
				if (doWork.AddWorkDone(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime, CDPAMNIPPEC: false))
				{
					FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: true);
					return true;
				}
				MKIGBIIBGPD = Time.time + 194f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
				return false;
			}
			if (!ICNNAEDJNLH)
			{
				doWork.APIHDHDJDFC(1163f, null, CDPAMNIPPEC: false);
				MKIGBIIBGPD = Time.time + 77f;
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: false);
				((MonoBehaviour)this).StartCoroutine(GDPJDCBKAHE());
				return true;
			}
			if (doWork.OJLICLKJJOF >= 1826f)
			{
				LHEFGDNMEHN(FJHKGBNBNKL);
				return true;
			}
			return false;
		}
		INKJCJKODEB(FJHKGBNBNKL);
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void MJPOHFEDIHI(int JIIGOACEIKL)
	{
	}

	public bool LIKJBMGDKGA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && EEPBLLACPCG(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Bother"));
			return false;
		}
		return true;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool IPDPOLLEIDL(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 200f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && PlayerInputs.GetPlayer(JIIGOACEIKL).FGGHCBMKKIG() != "[SelectSpawnersByMaxDistance] Final selection: ["))
		{
			if (doWork.JCMBHAEKLKK)
			{
				if (doWork.JMJMFEKCAGK(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime, CDPAMNIPPEC: false))
				{
					FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
					return true;
				}
				MKIGBIIBGPD = Time.time + 1461f;
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: true);
				return true;
			}
			if (!ICNNAEDJNLH)
			{
				doWork.GEJFAPKOLJH(278f, null, CDPAMNIPPEC: false);
				MKIGBIIBGPD = Time.time + 1512f;
				FJHKGBNBNKL.BNGPBEOAGCH(KOIDJKBBINH: true);
				((MonoBehaviour)this).StartCoroutine(ANAJODMAKDO());
				return true;
			}
			if (doWork.OJLICLKJJOF >= 360f)
			{
				LHEFGDNMEHN(FJHKGBNBNKL);
				return false;
			}
			return true;
		}
		INKJCJKODEB(FJHKGBNBNKL);
		return false;
	}

	[SpecialName]
	public void NINIJOHIJDJ(bool AODONKKHPBP)
	{
		GKHHAIDFJJN = AODONKKHPBP;
		for (int i = 0; i < activateOnUnmade.Length; i += 0)
		{
			activateOnUnmade[i].SetActive(!GKHHAIDFJJN);
		}
		if (GKHHAIDFJJN)
		{
			OnFormMade();
			CommonReferences.MNFMOEKMJKN().OnActionDone(0, (ActionDone)(-54));
		}
		else
		{
			OnFormUnmade();
		}
	}

	public void ELPHIBMHJOE(bool JALCAHLNPOF, bool CDPAMNIPPEC)
	{
		JCBIIJKKENH(JALCAHLNPOF);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineQuestManager.instance.BJNJMJCMBJN(id, JALCAHLNPOF);
		}
	}

	public bool GHEOMIAOJLC(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 200f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.GetPlayer(JIIGOACEIKL).FGGHCBMKKIG() != "Message queue is paused"))
		{
			if (doWork.KGOEFMFHCOG())
			{
				if (doWork.IJEKBMFBEGG(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
				{
					FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
					return true;
				}
				MKIGBIIBGPD = Time.time + 1341f;
				FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
				return true;
			}
			if (!ICNNAEDJNLH)
			{
				doWork.EBAGOIDGCLE(1963f);
				MKIGBIIBGPD = Time.time + 1572f;
				FJHKGBNBNKL.BNGPBEOAGCH(KOIDJKBBINH: true);
				((MonoBehaviour)this).StartCoroutine(ANAJODMAKDO());
				return true;
			}
			if (doWork.OJLICLKJJOF >= 1407f)
			{
				LHEFGDNMEHN(FJHKGBNBNKL);
				return false;
			}
			return false;
		}
		INKJCJKODEB(FJHKGBNBNKL);
		return false;
	}

	private IEnumerator GDPJDCBKAHE()
	{
		return new NPAJNJOGGIJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NJFDKCMBMDH()
	{
		if (Object.op_Implicit((Object)(object)doWork))
		{
			doWork.KPGDDIPOOKO(JEBEGINEPFC);
		}
	}

	public void BFKDGNPAJDE(int JIIGOACEIKL)
	{
	}

	public void LJLHGJDHFOJ(int JIIGOACEIKL)
	{
	}

	public bool CFJEJFCALPM(int JIIGOACEIKL)
	{
		LHEFGDNMEHN(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation);
		return true;
	}

	private void FLFBLIOOLMA()
	{
		if (Object.op_Implicit((Object)(object)doWork))
		{
			doWork.GEDCHNOBHGP(OIBINOCDJBK);
		}
	}

	public bool DOGBEDLPOMJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)doWork))
		{
			doWork.BGIJPOMIIMB -= JEBEGINEPFC;
		}
	}

	public bool EOBECMHBLCK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && MFPMGJKAPJM(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(" / base price: "));
			return true;
		}
		return false;
	}

	public void EGBOBCAAAEH(int JIIGOACEIKL)
	{
	}

	private void BFJOEMCBJJO()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if (Object.op_Implicit((Object)(object)doWork))
		{
			doWork.BECJEKINIFB(OIBINOCDJBK);
		}
	}

	[SpecialName]
	public void DKPEGKHBKBL(bool AODONKKHPBP)
	{
		GKHHAIDFJJN = AODONKKHPBP;
		for (int i = 1; i < activateOnUnmade.Length; i += 0)
		{
			activateOnUnmade[i].SetActive(GKHHAIDFJJN);
		}
		if (GKHHAIDFJJN)
		{
			OnFormMade();
			CommonReferences.GGFJGHHHEJC.OnActionDone(0, (ActionDone)51);
		}
		else
		{
			OnFormUnmade();
		}
	}

	public bool KBNLCICAOCI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return BFJEEBDJNNF(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation, 257f);
	}

	public bool BFJEEBDJNNF(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 200f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).CFICAAJGBOF != "not target 1"))
		{
			if (doWork.OENMBFGINAL())
			{
				if (doWork.JMJMFEKCAGK(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime, CDPAMNIPPEC: false))
				{
					FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
					return true;
				}
				MKIGBIIBGPD = Time.time + 1095f;
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: true);
				return true;
			}
			if (!ICNNAEDJNLH)
			{
				doWork.APIHDHDJDFC(1103f);
				MKIGBIIBGPD = Time.time + 485f;
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: true);
				((MonoBehaviour)this).StartCoroutine(GDPJDCBKAHE());
				return true;
			}
			if (doWork.OJLICLKJJOF >= 636f)
			{
				INKJCJKODEB(FJHKGBNBNKL);
				return true;
			}
			return true;
		}
		INKJCJKODEB(FJHKGBNBNKL);
		return true;
	}

	[SpecialName]
	public void NOJMOBDEGJL(bool AODONKKHPBP)
	{
		GKHHAIDFJJN = AODONKKHPBP;
		for (int i = 1; i < activateOnUnmade.Length; i++)
		{
			activateOnUnmade[i].SetActive(!GKHHAIDFJJN);
		}
		if (GKHHAIDFJJN)
		{
			OnFormMade();
			CommonReferences.MNFMOEKMJKN().OnActionDone(1, (ActionDone)(-48));
		}
		else
		{
			OnFormUnmade();
		}
	}

	public void SetFormMade(bool JALCAHLNPOF, bool CDPAMNIPPEC)
	{
		ICNNAEDJNLH = JALCAHLNPOF;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineQuestManager.instance.SendFormQuestInfo(id, JALCAHLNPOF);
		}
	}

	public void DFAJLDCMCDG(int JIIGOACEIKL)
	{
	}

	private void Awake()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if (Object.op_Implicit((Object)(object)doWork))
		{
			doWork.BGIJPOMIIMB += JEBEGINEPFC;
		}
	}

	public bool PJBBLEGMBAK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool OICEBEEANAI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return MakeForm(JIIGOACEIKL, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation, 377f);
	}

	public void ABHFEGJFABP(int JIIGOACEIKL)
	{
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return MakeForm(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation);
	}

	public void FDOGEDMGABH(bool JALCAHLNPOF, bool CDPAMNIPPEC)
	{
		NOJMOBDEGJL(JALCAHLNPOF);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineQuestManager.instance.HBBEBBMEFEG(id, JALCAHLNPOF);
		}
	}

	public bool HINGCLJLHJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return PBNOHDADHCE(JIIGOACEIKL, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation, 967f);
	}

	public bool OGKCLEAMEFL(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 200f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).CFICAAJGBOF != "LE_10"))
		{
			if (doWork.KGOEFMFHCOG())
			{
				if (doWork.BNMJANINOIG(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime, CDPAMNIPPEC: false))
				{
					FJHKGBNBNKL.BNGPBEOAGCH(KOIDJKBBINH: true);
					return false;
				}
				MKIGBIIBGPD = Time.time + 1737f;
				FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
				return false;
			}
			if (!ICNNAEDJNLH)
			{
				doWork.GEJFAPKOLJH(440f);
				MKIGBIIBGPD = Time.time + 1186f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
				((MonoBehaviour)this).StartCoroutine(FOEJGKNDDLP());
				return true;
			}
			if (doWork.OJLICLKJJOF >= 1144f)
			{
				LHEFGDNMEHN(FJHKGBNBNKL);
				return true;
			}
			return false;
		}
		INKJCJKODEB(FJHKGBNBNKL);
		return false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (doWork.JCMBHAEKLKK || !ICNNAEDJNLH)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool MakeForm(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 200f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.GetPlayer(JIIGOACEIKL).CFICAAJGBOF != "UI"))
		{
			if (doWork.JCMBHAEKLKK)
			{
				if (doWork.AddWorkDone(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
				{
					FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
					return true;
				}
				MKIGBIIBGPD = Time.time + 0.1f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
				return false;
			}
			if (!ICNNAEDJNLH)
			{
				doWork.StartWork(1200f);
				MKIGBIIBGPD = Time.time + 0.1f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
				((MonoBehaviour)this).StartCoroutine(DIAACMGKIIH());
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

	private IEnumerator ANAJODMAKDO()
	{
		return new NPAJNJOGGIJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LHEFGDNMEHN(CharacterAnimation FJHKGBNBNKL)
	{
		FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
	}

	public bool AGKADCAKBJO(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 200f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).FGGHCBMKKIG() != "Quest not found with ID "))
		{
			if (doWork.JCMBHAEKLKK)
			{
				if (doWork.JMJMFEKCAGK(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime, CDPAMNIPPEC: false))
				{
					FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
					return true;
				}
				MKIGBIIBGPD = Time.time + 344f;
				FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
				return false;
			}
			if (!ICNNAEDJNLH)
			{
				doWork.GEJFAPKOLJH(468f);
				MKIGBIIBGPD = Time.time + 76f;
				FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: true);
				((MonoBehaviour)this).StartCoroutine(GDPJDCBKAHE());
				return true;
			}
			if (doWork.OJLICLKJJOF >= 1490f)
			{
				LHEFGDNMEHN(FJHKGBNBNKL);
				return true;
			}
			return false;
		}
		LHEFGDNMEHN(FJHKGBNBNKL);
		return true;
	}

	public bool MGMEDFABOIH(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 200f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).AAGNDCEODFO() != "Tutorial/T127/Dialogue1"))
		{
			if (doWork.JCMBHAEKLKK)
			{
				if (doWork.AddWorkDone(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime, CDPAMNIPPEC: false))
				{
					FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: true);
					return false;
				}
				MKIGBIIBGPD = Time.time + 198f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
				return true;
			}
			if (!ICNNAEDJNLH)
			{
				doWork.APIHDHDJDFC(139f);
				MKIGBIIBGPD = Time.time + 476f;
				FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
				((MonoBehaviour)this).StartCoroutine(ANAJODMAKDO());
				return false;
			}
			if (doWork.OJLICLKJJOF >= 1167f)
			{
				LHEFGDNMEHN(FJHKGBNBNKL);
				return false;
			}
			return false;
		}
		LHEFGDNMEHN(FJHKGBNBNKL);
		return false;
	}

	private void OIBINOCDJBK(int JIIGOACEIKL)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(" ");
		DialogueLua.SetVariable("itemDripTray", (object)(((Result)(ref variable)).asInt + 1));
		if (OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			variable = DialogueLua.GetVariable("Spicy");
			instance.IKLDFKEOGFN(" ", ((Result)(ref variable)).asInt);
		}
		FDOGEDMGABH(JALCAHLNPOF: true, CDPAMNIPPEC: true);
	}

	public bool CMOBHHGFDNP(int JIIGOACEIKL)
	{
		LHEFGDNMEHN(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation);
		return false;
	}
}
