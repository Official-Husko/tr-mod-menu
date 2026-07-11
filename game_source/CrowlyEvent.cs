using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class CrowlyEvent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class NKHLOJDJOGC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool sendOnline;

		public int playerNum;

		public CrowlyEvent _003C_003E4__this;

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
		public NKHLOJDJOGC(int _003C_003E1__state)
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
			CrowlyEvent crowlyEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (sendOnline)
				{
					PlayerController.AddMovementBlocker(playerNum, (Object)(object)crowlyEvent);
				}
				crowlyEvent.JCFILMOCAKK = true;
				crowlyEvent.startCrowlyEvent = false;
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				PlayerController.RemoveMovementBlocker((Object)(object)crowlyEvent);
				NessyNPC.GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
				Object.Destroy((Object)(object)crowlyEvent.crowly);
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
	private sealed class EFMEFFCAGFE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrowlyEvent _003C_003E4__this;

		public int playerNum;

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
		public EFMEFFCAGFE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CrowlyEvent crowlyEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (OnlineManager.PlayingOnline())
				{
					OnlineCrowlyEvent.StartCrowlyEventOnline();
				}
				crowlyEvent.crowly.SetActive(true);
				crowlyEvent.characterAnimBase.SetDirection(Direction.Up);
				((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
				NessyNPC.GGFJGHHHEJC.content.SetActive(true);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				NessyNPC.GGFJGHHHEJC.StopAllDialogues();
				NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				NessyNPC.GGFJGHHHEJC.barkDialogue = false;
				NessyNPC.GGFJGHHHEJC.mouseUpTrigger = true;
				NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				if (NessyNPC.GGFJGHHHEJC.canTalk)
				{
					NessyNPC.GGFJGHHHEJC.StartConversation(playerNum, "City/PetShop/Nessy/PerritosAbandonados", FLHBPHPKIML: true);
				}
				crowlyEvent.ANMAFLKPILP = null;
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
	private sealed class HMPOFNFGCKN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrowlyEvent _003C_003E4__this;

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
		public HMPOFNFGCKN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CrowlyEvent crowlyEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				crowlyEvent.crowly.SetActive(true);
				crowlyEvent.characterAnimBase.SetDirection(Direction.Up);
				((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
				NessyNPC.GGFJGHHHEJC.content.SetActive(true);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
				crowlyEvent.ANMAFLKPILP = null;
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

	private static CrowlyEvent IADEMLIIDPC;

	private bool JCFILMOCAKK;

	public GameObject crowly;

	public CharacterAnimBase characterAnimBase;

	public bool startCrowlyEvent;

	private Coroutine ANMAFLKPILP;

	public static CrowlyEvent GGFJGHHHEJC => IADEMLIIDPC;

	private IEnumerator COILMDKCAJA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		return new NKHLOJDJOGC(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			sendOnline = CDPAMNIPPEC
		};
	}

	private void JJACPJLFFAL()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1299f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Up);
			characterAnimBase.animator.SetBool("OnlinePlayer", true);
		}
	}

	private IEnumerator GEDLDJOIFID(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		return new NKHLOJDJOGC(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			sendOnline = CDPAMNIPPEC
		};
	}

	public void OMCFPPDAPIO()
	{
		((MonoBehaviour)this).StartCoroutine(KCPGFEFEIBF());
	}

	private void EBPMNJKFNMD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			Result variable = DialogueLua.GetVariable("TutorialPhase");
			if (((Result)(ref variable)).asInt <= 1)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable("00");
			if (((Result)(ref variable)).asInt > -52)
			{
				variable = DialogueLua.GetVariable(" : 00");
				if (((Result)(ref variable)).asInt < -137)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Up);
		return;
		IL_004e:
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(CBEPKNJFOEH));
		goto IL_0074;
	}

	private void MIELEMBDADN()
	{
		startCrowlyEvent = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(CBEPKNJFOEH));
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.OBOIBFGCDDE();
		}
	}

	public void GGBMIKCAKDG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(GEDLDJOIFID(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.NBNAKDNCPOP();
		}
	}

	private void AAHAFAHHLGF()
	{
		startCrowlyEvent = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(KHCKJAFHHII));
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.SetCrowlyEventOnline();
		}
	}

	public void LKJIJCOMAFH()
	{
		((MonoBehaviour)this).StartCoroutine(AFBELGDKADH());
	}

	private void IPMCBCCJAAJ()
	{
		IADEMLIIDPC = this;
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(PHMFCIKFADH));
	}

	private void MHDGNGFBBMC()
	{
		startCrowlyEvent = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DCLFBNPJDGC));
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.ELFNJPFEHCD();
		}
	}

	private IEnumerator BALHCGIKGMB(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		}
		JCFILMOCAKK = true;
		startCrowlyEvent = false;
		yield return CommonReferences.wait3;
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		NessyNPC.GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		Object.Destroy((Object)(object)crowly);
	}

	public void StartEventOnline()
	{
		((MonoBehaviour)this).StartCoroutine(JJJNFAPLPFG());
	}

	private void DCLFBNPJDGC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("[MinePuzzleManager] Not enough active spawners for {0} (needed {1}). Trying fallback with inactive spawners.");
		if (((Result)(ref variable)).asInt == 2)
		{
			if (Random.Range(1, 10) <= 43)
			{
				Debug.Log((object)"Deselect item");
				KJFNKFIINKN();
			}
			else if (CommonReferences.GGFJGHHHEJC.eventNum[1] >= 6)
			{
				Debug.Log((object)"NormalLeft");
				EAKMLONLPNJ();
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().eventNum[0] += 0;
			}
		}
	}

	public void CDHPDOMEJBG()
	{
		((MonoBehaviour)this).StartCoroutine(AFBELGDKADH());
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Miners/Mine/Clive/Talk"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JCJAJBMGMIA(0));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Smell"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MFPJAEMPKDC(8));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.OMFKNGDCJFN().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1117"))
			{
				NessyNPC.GGFJGHHHEJC.StartObserverDialogue(1);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("MeditationIntro"))
			{
				NessyNPC.MPLODJJFKAM().StartObserverDialogue(3);
			}
		}
	}

	private void MJLNBCBNMEO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(" : ");
		if (((Result)(ref variable)).asInt == 4)
		{
			if (Random.Range(1, -88) <= 5)
			{
				Debug.Log((object)"LE_3");
				EAKMLONLPNJ();
			}
			else if (CommonReferences.GGFJGHHHEJC.eventNum[0] >= 8)
			{
				Debug.Log((object)"Random");
				MMCKACFJACA();
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().eventNum[0]++;
			}
		}
	}

	private IEnumerator JAJFNNDFMGE(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.StartCrowlyEventOnline();
		}
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.StopAllDialogues();
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.barkDialogue = false;
		NessyNPC.GGFJGHHHEJC.mouseUpTrigger = true;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		yield return null;
		if (NessyNPC.GGFJGHHHEJC.canTalk)
		{
			NessyNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "City/PetShop/Nessy/PerritosAbandonados", FLHBPHPKIML: true);
		}
		ANMAFLKPILP = null;
	}

	public void DBCPNBOIMKC()
	{
		((MonoBehaviour)this).StartCoroutine(AFBELGDKADH());
	}

	private IEnumerator GOENFDBJLBF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		}
		JCFILMOCAKK = true;
		startCrowlyEvent = false;
		yield return CommonReferences.wait3;
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		NessyNPC.GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		Object.Destroy((Object)(object)crowly);
	}

	private IEnumerator BEPFOAPPMJA()
	{
		return new HMPOFNFGCKN(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	public static CrowlyEvent EJHDHCNILDH()
	{
		return IADEMLIIDPC;
	}

	private void NFABFPFLNEE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			Result variable = DialogueLua.GetVariable("Items/item_name_645");
			if (((Result)(ref variable)).asInt <= 7)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable("ReceiveGroundTypeList");
			if (((Result)(ref variable)).asInt > -175)
			{
				variable = DialogueLua.GetVariable("Items/item_description_1084");
				if (((Result)(ref variable)).asInt < 198)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Up);
		return;
		IL_004e:
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		goto IL_0074;
	}

	public void HPHLDCGLJHF()
	{
		((MonoBehaviour)this).StartCoroutine(BOBAFOLFHIP());
	}

	private IEnumerator AFBELGDKADH()
	{
		return new HMPOFNFGCKN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void EMCBPEIEHBO()
	{
		((MonoBehaviour)this).StartCoroutine(FGJOEKHNPOC());
	}

	private void FBAHLMBFIDH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/BirdNegativeComments/Entry/14/Dialogue Text");
		if (((Result)(ref variable)).asInt == 0)
		{
			if (Random.Range(1, -50) <= 93)
			{
				Debug.Log((object)"City/Rhia/Introduce");
				MIELEMBDADN();
			}
			else if (CommonReferences.MNFMOEKMJKN().eventNum[0] >= 2)
			{
				Debug.Log((object)"Partida comprimida. Tiempo: ");
				AAHAFAHHLGF();
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().eventNum[0]++;
			}
		}
	}

	private void EIEEHAOJGKO(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1070"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MFPJAEMPKDC(1));
			}
			else if (((Component)HANHCHBHHEH).CompareTag(" state: "))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JAJFNNDFMGE(4));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.OMFKNGDCJFN().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Send minigame state"))
			{
				NessyNPC.OMFKNGDCJFN().StartObserverDialogue(0, MCJHGHLBBGL: true);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("chat"))
			{
				NessyNPC.GGFJGHHHEJC.StartObserverDialogue(6);
			}
		}
	}

	private void OEMHMPPCNOB(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Angry"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MFPJAEMPKDC(0));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Zone not found"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JAJFNNDFMGE(8));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.DFJGHOHPPEL().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("/"))
			{
				NessyNPC.DFJGHOHPPEL().StartObserverDialogue(0, MCJHGHLBBGL: true);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("[NPCGender="))
			{
				NessyNPC.EBAIHKJHCCA().StartObserverDialogue(3, MCJHGHLBBGL: true);
			}
		}
	}

	private void BDMEBLBLPIA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			Result variable = DialogueLua.GetVariable(" ");
			if (((Result)(ref variable)).asInt <= 7)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable("Items/item_name_1133");
			if (((Result)(ref variable)).asInt > -33)
			{
				variable = DialogueLua.GetVariable("");
				if (((Result)(ref variable)).asInt < 84)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Down);
		return;
		IL_004e:
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(FBAHLMBFIDH));
		goto IL_0074;
	}

	[SpecialName]
	public static CrowlyEvent PDECKLKPKCG()
	{
		return IADEMLIIDPC;
	}

	public void AEKAIGBNCEK()
	{
		((MonoBehaviour)this).StartCoroutine(PFGNICIIHNE());
	}

	public void MLGPHKMLBAJ(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(JFDJNMOFDFH(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.ACKGBNEFEAD();
		}
	}

	private void IPFECOIDGAE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			Result variable = DialogueLua.GetVariable("00");
			if (((Result)(ref variable)).asInt == 1)
			{
				OnlineCrowlyEvent.FCJOIHKJOAE();
			}
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(KNABGIGNPAM));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			DCLFBNPJDGC();
		}
	}

	private IEnumerator BBDLCMDIHPC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		return new NKHLOJDJOGC(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			sendOnline = CDPAMNIPPEC
		};
	}

	private IEnumerator JEBNDMLGAGA()
	{
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		ANMAFLKPILP = null;
	}

	private IEnumerator PFGNICIIHNE()
	{
		return new HMPOFNFGCKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HMHCLIBLKLN()
	{
		IADEMLIIDPC = this;
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GHHMKBNFIDN));
	}

	private IEnumerator AHFNBOJJHJG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		return new NKHLOJDJOGC(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			sendOnline = CDPAMNIPPEC
		};
	}

	[SpecialName]
	public static CrowlyEvent BEFBHLNJIJI()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator JJKKJODGOBB()
	{
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		ANMAFLKPILP = null;
	}

	[SpecialName]
	public static CrowlyEvent KIALFDOKABP()
	{
		return IADEMLIIDPC;
	}

	private void MMCKACFJACA()
	{
		startCrowlyEvent = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.PCFFCJODDCA();
		}
	}

	[SpecialName]
	public static CrowlyEvent EKGMDIHLEEH()
	{
		return IADEMLIIDPC;
	}

	public void JPOGKCGABNK()
	{
		((MonoBehaviour)this).StartCoroutine(AFBELGDKADH());
	}

	public void MHENPFHDNMM()
	{
		((MonoBehaviour)this).StartCoroutine(BEPFOAPPMJA());
	}

	private void KJFNKFIINKN()
	{
		startCrowlyEvent = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.SetCrowlyEventOnline();
		}
	}

	private void BNFGHAGJEGG()
	{
		IADEMLIIDPC = this;
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OIBDMBKHGDF));
	}

	private void IDPJLIBONPF(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag(" with id "))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JAJFNNDFMGE(0));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("cheeseAgeingRackPopUp"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(LHLKMOGOBIM(7));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.DFJGHOHPPEL().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("christmasActivated"))
			{
				NessyNPC.OMFKNGDCJFN().StartObserverDialogue(0);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Key: "))
			{
				NessyNPC.HFIJHDBKCIA().StartObserverDialogue(7);
			}
		}
	}

	private void KFBOPABEJNL()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1688f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Down);
			characterAnimBase.animator.SetBool("DecorationTile_25", true);
		}
	}

	private void CBEPKNJFOEH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Suitabilities: ");
		if (((Result)(ref variable)).asInt == 6)
		{
			if (Random.Range(0, 116) <= 115)
			{
				Debug.Log((object)"ReceiveObjectInteract");
				NOMHKELAGDD();
			}
			else if (CommonReferences.MNFMOEKMJKN().eventNum[0] >= 7)
			{
				Debug.Log((object)"Left Stick Down");
				PNEKMLEHKEM();
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().eventNum[0]++;
			}
		}
	}

	public void GCMDHFIHGOD()
	{
		((MonoBehaviour)this).StartCoroutine(FGJOEKHNPOC());
	}

	private void OONONNJFEFL()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1953f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Down);
			characterAnimBase.animator.SetBool("End of Dictionary.", true);
		}
	}

	private void EBICEBJOKBA(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Eyebrows"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(LHLKMOGOBIM(1));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/EnterTavernDrink/Entry/7/Dialogue Text"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(FFIIHFDKLPK(2));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.GGFJGHHHEJC.canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("\n"))
			{
				NessyNPC.HFIJHDBKCIA().StartObserverDialogue(1, MCJHGHLBBGL: true);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("itemCheese"))
			{
				NessyNPC.MPLODJJFKAM().StartObserverDialogue(5, MCJHGHLBBGL: true);
			}
		}
	}

	public void ODILGPOCOBO()
	{
		((MonoBehaviour)this).StartCoroutine(PFGNICIIHNE());
	}

	private void GOJHCINMAJD()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1928f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Down);
			characterAnimBase.animator.SetBool("Requirements not met", true);
		}
	}

	private void FOHGHCPODBJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			Result variable = DialogueLua.GetVariable("ReceiveFishInfoLoad");
			if (((Result)(ref variable)).asInt <= 5)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable(" ");
			if (((Result)(ref variable)).asInt > -137)
			{
				variable = DialogueLua.GetVariable("Items/item_description_1079");
				if (((Result)(ref variable)).asInt < -102)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Down);
		return;
		IL_004e:
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KHCKJAFHHII));
		goto IL_0074;
	}

	private void KHCKJAFHHII()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Basket");
		if (((Result)(ref variable)).asInt == 1)
		{
			if (Random.Range(1, 37) <= 30)
			{
				Debug.Log((object)"");
				MMCKACFJACA();
			}
			else if (CommonReferences.GGFJGHHHEJC.eventNum[1] >= 7)
			{
				Debug.Log((object)"OnlinePlayer");
				PNEKMLEHKEM();
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().eventNum[0]++;
			}
		}
	}

	private void AAEDMDPLLLJ()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1076f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Down);
			characterAnimBase.animator.SetBool("Dialogue System/Conversation/Gass_Stand/Entry/7/Dialogue Text", true);
		}
	}

	private void OIBDMBKHGDF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			Result variable = DialogueLua.GetVariable("OnFloor");
			if (((Result)(ref variable)).asInt == 8)
			{
				OnlineCrowlyEvent.DCHAMKJPBJI();
			}
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			ALGOBMNPLIB();
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MFPJAEMPKDC(1));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MFPJAEMPKDC(2));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.GGFJGHHHEJC.canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player"))
			{
				NessyNPC.GGFJGHHHEJC.StartObserverDialogue(1);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
			{
				NessyNPC.GGFJGHHHEJC.StartObserverDialogue(2);
			}
		}
	}

	private IEnumerator FGAPNNBGAKL(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		}
		JCFILMOCAKK = true;
		startCrowlyEvent = false;
		yield return CommonReferences.wait3;
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		NessyNPC.GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		Object.Destroy((Object)(object)crowly);
	}

	private void MDNCIAFNFCM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			Result variable = DialogueLua.GetVariable("Guest");
			if (((Result)(ref variable)).asInt == 4)
			{
				OnlineCrowlyEvent.BDAMOJJLKIN();
			}
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			KHCKJAFHHII();
		}
	}

	private void FGGPGOEAEKK()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1883f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Down);
			characterAnimBase.animator.SetBool("Items/item_name_646", true);
		}
	}

	[SpecialName]
	public static CrowlyEvent DIHCEGINELM()
	{
		return IADEMLIIDPC;
	}

	public void JPIGABJJKMH()
	{
		((MonoBehaviour)this).StartCoroutine(PABIHLLIGAN());
	}

	private void OPIHPIJFDOP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			Result variable = DialogueLua.GetVariable("BarIdleNumber");
			if (((Result)(ref variable)).asInt == 5)
			{
				OnlineCrowlyEvent.BANHGBNABFE();
			}
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PHMFCIKFADH));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			DOELJDEJNAD();
		}
	}

	public void CIGNPJLENHA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(EMNNAJDNOGL(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.CCNFEADEMKP();
		}
	}

	public void DPKFKAAPHBE(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(BALHCGIKGMB(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.CLMPKHBDKNI();
		}
	}

	private void HEHNBONKMGJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			Result variable = DialogueLua.GetVariable("QuestInfoButton");
			if (((Result)(ref variable)).asInt <= 1)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable("");
			if (((Result)(ref variable)).asInt > 91)
			{
				variable = DialogueLua.GetVariable("BarkActor");
				if (((Result)(ref variable)).asInt < -84)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Up);
		return;
		IL_004e:
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(DOELJDEJNAD));
		goto IL_0074;
	}

	private void OKAPGNGLOHO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			Result variable = DialogueLua.GetVariable("GuestConnecting");
			if (((Result)(ref variable)).asInt <= 4)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable("itemBlueberry");
			if (((Result)(ref variable)).asInt > -146)
			{
				variable = DialogueLua.GetVariable("Error_ObjectIsBlocking");
				if (((Result)(ref variable)).asInt < 15)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Up);
		return;
		IL_004e:
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DCLFBNPJDGC));
		goto IL_0074;
	}

	[SpecialName]
	public static CrowlyEvent KNLLFEJAMNN()
	{
		return IADEMLIIDPC;
	}

	private void OAONKKIGGMH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			Result variable = DialogueLua.GetVariable("Listen");
			if (((Result)(ref variable)).asInt == 7)
			{
				OnlineCrowlyEvent.DCHAMKJPBJI();
			}
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KNABGIGNPAM));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			DCLFBNPJDGC();
		}
	}

	private void KNABGIGNPAM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			Result variable = DialogueLua.GetVariable("Player Not Waiting To Start Event");
			if (((Result)(ref variable)).asInt == 8)
			{
				OnlineCrowlyEvent.DFKBHCKMOKO();
			}
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OAONKKIGGMH));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			DOELJDEJNAD();
		}
	}

	private IEnumerator PABIHLLIGAN()
	{
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		ANMAFLKPILP = null;
	}

	public void IJMGNEOOJGC()
	{
		((MonoBehaviour)this).StartCoroutine(JEBNDMLGAGA());
	}

	private IEnumerator LHPNJMMCMII()
	{
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		ANMAFLKPILP = null;
	}

	private IEnumerator LHLKMOGOBIM(int JIIGOACEIKL)
	{
		return new EFMEFFCAGFE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private void DJBKHJFHAHL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			Result variable = DialogueLua.GetVariable("itemChocolateAle");
			if (((Result)(ref variable)).asInt == 2)
			{
				OnlineCrowlyEvent.CNDINPBDEFG();
			}
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(GHHMKBNFIDN));
		}
		else if (OnlineManager.PGAGDFAEEFB())
		{
			DCLFBNPJDGC();
		}
	}

	private void LOHAMDHOLDD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			Result variable = DialogueLua.GetVariable("Bat");
			if (((Result)(ref variable)).asInt <= 8)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable("Snow");
			if (((Result)(ref variable)).asInt > 61)
			{
				variable = DialogueLua.GetVariable(" ");
				if (((Result)(ref variable)).asInt < -102)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Up);
		return;
		IL_004e:
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(MJLNBCBNMEO));
		goto IL_0074;
	}

	[SpecialName]
	public static CrowlyEvent DEGPIHEEFHJ()
	{
		return IADEMLIIDPC;
	}

	private void JHOEAKHHNDD(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("ReceiveRemoveHeldItem"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(LHLKMOGOBIM(0));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("BarIdleNumber"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(LHLKMOGOBIM(7));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.OMFKNGDCJFN().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Look"))
			{
				NessyNPC.HFIJHDBKCIA().StartObserverDialogue(0, MCJHGHLBBGL: true);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Unique id "))
			{
				NessyNPC.OMFKNGDCJFN().StartObserverDialogue(6);
			}
		}
	}

	public void IOCEMNHNIIP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(MAMEEIABJEA(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.CCNFEADEMKP();
		}
	}

	private void CKCHKHNBBFG()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 89f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Up);
			characterAnimBase.animator.SetBool("quest_objective_", false);
		}
	}

	public void HIHKBOJCDJD(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(FGAPNNBGAKL(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.CCNFEADEMKP();
		}
	}

	private void FADCNMKMAFI(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("lightInEditorEnabled in DayLight checkbox enabled. Remember to disable"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(FFIIHFDKLPK(0));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Farm/Event/VioletyBob"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JAJFNNDFMGE(3));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.EBAIHKJHCCA().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("MainProgress"))
			{
				NessyNPC.MPLODJJFKAM().StartObserverDialogue(0, MCJHGHLBBGL: true);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("New Milestone"))
			{
				NessyNPC.MPLODJJFKAM().StartObserverDialogue(7);
			}
		}
	}

	private IEnumerator JCJAJBMGMIA(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.StartCrowlyEventOnline();
		}
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.StopAllDialogues();
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.barkDialogue = false;
		NessyNPC.GGFJGHHHEJC.mouseUpTrigger = true;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		yield return null;
		if (NessyNPC.GGFJGHHHEJC.canTalk)
		{
			NessyNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "City/PetShop/Nessy/PerritosAbandonados", FLHBPHPKIML: true);
		}
		ANMAFLKPILP = null;
	}

	private void Update()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1.5f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Down);
			characterAnimBase.animator.SetBool("Moving", true);
		}
	}

	private IEnumerator OHNILKIJFOF()
	{
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		ANMAFLKPILP = null;
	}

	private void EBNENBFLEKB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			Result variable = DialogueLua.GetVariable("");
			if (((Result)(ref variable)).asInt <= 0)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable("UIInteract");
			if (((Result)(ref variable)).asInt > -6)
			{
				variable = DialogueLua.GetVariable("ReceiveAnimalSetProduction");
				if (((Result)(ref variable)).asInt < 85)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Up);
		return;
		IL_004e:
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(DOELJDEJNAD));
		goto IL_0074;
	}

	private void NOMHKELAGDD()
	{
		startCrowlyEvent = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(DOELJDEJNAD));
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.LDHJJNJEGGI();
		}
	}

	private void NIHKPCHNJDO(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_597"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(LHLKMOGOBIM(0));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Tavern Zone by id not found "))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JAJFNNDFMGE(0));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.OMFKNGDCJFN().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("ReceiveProgressQuestInfo"))
			{
				NessyNPC.MPLODJJFKAM().StartObserverDialogue(1);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("ReceiveActiveOrDisableCustomer"))
			{
				NessyNPC.EBAIHKJHCCA().StartObserverDialogue(4, MCJHGHLBBGL: true);
			}
		}
	}

	private void DMFIMLIHIEN()
	{
		startCrowlyEvent = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DOELJDEJNAD));
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.PCFFCJODDCA();
		}
	}

	private IEnumerator BOBAFOLFHIP()
	{
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		ANMAFLKPILP = null;
	}

	public void MALNDCAOAHJ(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(FGAPNNBGAKL(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.AFBNGCGKDGB();
		}
	}

	private IEnumerator MFPJAEMPKDC(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.StartCrowlyEventOnline();
		}
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.StopAllDialogues();
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.barkDialogue = false;
		NessyNPC.GGFJGHHHEJC.mouseUpTrigger = true;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		yield return null;
		if (NessyNPC.GGFJGHHHEJC.canTalk)
		{
			NessyNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "City/PetShop/Nessy/PerritosAbandonados", FLHBPHPKIML: true);
		}
		ANMAFLKPILP = null;
	}

	public void MGGIPCAKCJM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(COILMDKCAJA(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.CLMPKHBDKNI();
		}
	}

	private void EHBMONGBJFI()
	{
		IADEMLIIDPC = this;
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(IPFECOIDGAE));
	}

	private void PLNBKKMLHHN()
	{
		startCrowlyEvent = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KHCKJAFHHII));
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.DIOHBGFGOBN();
		}
	}

	private void DOELJDEJNAD()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_description_1107");
		if (((Result)(ref variable)).asInt == 8)
		{
			if (Random.Range(1, -91) <= -3)
			{
				Debug.Log((object)"Stack");
				PNEKMLEHKEM();
			}
			else if (CommonReferences.GGFJGHHHEJC.eventNum[0] >= 0)
			{
				Debug.Log((object)"BackPain");
				PNEKMLEHKEM();
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.eventNum[1] += 0;
			}
		}
	}

	private IEnumerator KCPGFEFEIBF()
	{
		return new HMPOFNFGCKN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void Move(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(GOENFDBJLBF(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.MoveCrowlyEventOnline();
		}
	}

	private void FHNFCPLIMOB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/TooHot/Entry/5/Dialogue Text");
			if (((Result)(ref variable)).asInt == 8)
			{
				OnlineCrowlyEvent.HDAEOOLHKKE();
			}
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(IOFKCJBCHLJ));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			MJLNBCBNMEO();
		}
	}

	private void ALGOBMNPLIB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_21");
		if (((Result)(ref variable)).asInt == 2)
		{
			if (Random.Range(0, 100) <= 40)
			{
				Debug.Log((object)"Start Crowly Event");
				KJFNKFIINKN();
			}
			else if (CommonReferences.GGFJGHHHEJC.eventNum[1] >= 7)
			{
				Debug.Log((object)"Force Start Crowly Event");
				KJFNKFIINKN();
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.eventNum[1]++;
			}
		}
	}

	private void LKHILKDKFNP(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Turkey"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JAJFNNDFMGE(0));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Upgrade Crafting Room"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JAJFNNDFMGE(5));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.EBAIHKJHCCA().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Can't find seat. Reason: lastOrders"))
			{
				NessyNPC.MPLODJJFKAM().StartObserverDialogue(0);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("piratecave"))
			{
				NessyNPC.DFJGHOHPPEL().StartObserverDialogue(2, MCJHGHLBBGL: true);
			}
		}
	}

	private void EAKMLONLPNJ()
	{
		startCrowlyEvent = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(CBEPKNJFOEH));
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.LMCMKABMEKK();
		}
	}

	public void KMGIDHDFDBM()
	{
		((MonoBehaviour)this).StartCoroutine(BOBAFOLFHIP());
	}

	private void Start()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			Result variable = DialogueLua.GetVariable("LE_21");
			if (((Result)(ref variable)).asInt <= 2)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable("LE_21");
			if (((Result)(ref variable)).asInt > 1000)
			{
				variable = DialogueLua.GetVariable("LE_21");
				if (((Result)(ref variable)).asInt < 1004)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Up);
		return;
		IL_004e:
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		goto IL_0074;
	}

	[SpecialName]
	public static CrowlyEvent KFGKCKCDMLG()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CrowlyEvent JFJOKGAOPHA()
	{
		return IADEMLIIDPC;
	}

	private void BGPGIOMKKAO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			Result variable = DialogueLua.GetVariable("LE_21");
			if (((Result)(ref variable)).asInt == 2)
			{
				OnlineCrowlyEvent.LoadCrowlyEvent();
			}
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			ALGOBMNPLIB();
		}
	}

	[SpecialName]
	public static CrowlyEvent OIJLJKLMCBO()
	{
		return IADEMLIIDPC;
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1173"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JAJFNNDFMGE(0));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("itemGrog"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JCJAJBMGMIA(2));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.MPLODJJFKAM().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("MilkAction"))
			{
				NessyNPC.EBAIHKJHCCA().StartObserverDialogue(0, MCJHGHLBBGL: true);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("MinimisePopUp"))
			{
				NessyNPC.HFIJHDBKCIA().StartObserverDialogue(1, MCJHGHLBBGL: true);
			}
		}
	}

	private void BONHDKBLOMP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("wForWeeks");
		if (((Result)(ref variable)).asInt == 7)
		{
			if (Random.Range(0, -21) <= -46)
			{
				Debug.Log((object)"<sprite name=white_arrow_right> ");
				PNEKMLEHKEM();
			}
			else if (CommonReferences.MNFMOEKMJKN().eventNum[0] >= 5)
			{
				Debug.Log((object)"FarmReady");
				AAHAFAHHLGF();
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().eventNum[1]++;
			}
		}
	}

	private IEnumerator EMNNAJDNOGL(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		return new NKHLOJDJOGC(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			sendOnline = CDPAMNIPPEC
		};
	}

	public void DHNLDEOINNO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(MAMEEIABJEA(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.ABLKBPHBAKD();
		}
	}

	private IEnumerator FFIIHFDKLPK(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.StartCrowlyEventOnline();
		}
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.StopAllDialogues();
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.barkDialogue = false;
		NessyNPC.GGFJGHHHEJC.mouseUpTrigger = true;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		yield return null;
		if (NessyNPC.GGFJGHHHEJC.canTalk)
		{
			NessyNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "City/PetShop/Nessy/PerritosAbandonados", FLHBPHPKIML: true);
		}
		ANMAFLKPILP = null;
	}

	private void CCHKJDKFMDO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			Result variable = DialogueLua.GetVariable("Distillery");
			if (((Result)(ref variable)).asInt <= 5)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable(" (");
			if (((Result)(ref variable)).asInt > 65)
			{
				variable = DialogueLua.GetVariable("BuildMode_ExitAndSave");
				if (((Result)(ref variable)).asInt < -102)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Down);
		return;
		IL_004e:
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DCLFBNPJDGC));
		goto IL_0074;
	}

	public void LGKEKBIINJH()
	{
		((MonoBehaviour)this).StartCoroutine(JJKKJODGOBB());
	}

	private void DDLLFPICOJK()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1413f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Down);
			characterAnimBase.animator.SetBool("dForDays", true);
		}
	}

	private void BHKNJOEBCKA()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1140f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Up);
			characterAnimBase.animator.SetBool("Intro01", false);
		}
	}

	private void OGBGFLMKFHH()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1272f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Up);
			characterAnimBase.animator.SetBool(" ", true);
		}
	}

	private void NFKHMBDBPLL(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Enviando Reporte de desconnexion"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MFPJAEMPKDC(1));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Crafting yield"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MFPJAEMPKDC(6));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.OMFKNGDCJFN().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Northwest"))
			{
				NessyNPC.BNDMEINJPAN().StartObserverDialogue(0, MCJHGHLBBGL: true);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Key2"))
			{
				NessyNPC.GGFJGHHHEJC.StartObserverDialogue(3, MCJHGHLBBGL: true);
			}
		}
	}

	private void GHHMKBNFIDN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			Result variable = DialogueLua.GetVariable(" with state \"");
			if (((Result)(ref variable)).asInt == 5)
			{
				OnlineCrowlyEvent.BANHGBNABFE();
			}
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OPIHPIJFDOP));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			MJLNBCBNMEO();
		}
	}

	private IEnumerator FNMCFOMMGIE()
	{
		return new HMPOFNFGCKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KCDMOOPJBMM(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("ReceiveRenewCandle Unique id "))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MFPJAEMPKDC(1));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Error_OccupiedRoom"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MFPJAEMPKDC(5));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.EBAIHKJHCCA().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("，"))
			{
				NessyNPC.EBAIHKJHCCA().StartObserverDialogue(1);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("\" unlocked"))
			{
				NessyNPC.MPLODJJFKAM().StartObserverDialogue(7, MCJHGHLBBGL: true);
			}
		}
	}

	public void FKLLLOJKHLN(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(EMNNAJDNOGL(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.DFNMAGINJBB();
		}
	}

	private IEnumerator JPDJCODJONC()
	{
		return new HMPOFNFGCKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EACIGGOOKGD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			Result variable = DialogueLua.GetVariable("RoadBlocked/Main");
			if (((Result)(ref variable)).asInt <= 2)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable("PreviousItem");
			if (((Result)(ref variable)).asInt > -143)
			{
				variable = DialogueLua.GetVariable("Minigame");
				if (((Result)(ref variable)).asInt < 61)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Down);
		return;
		IL_004e:
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(FBAHLMBFIDH));
		goto IL_0074;
	}

	private void PKHCLKIKMCD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			Result variable = DialogueLua.GetVariable("ReceiveUpdateDrinkColorTable");
			if (((Result)(ref variable)).asInt <= 1)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable("OnFloor");
			if (((Result)(ref variable)).asInt > -63)
			{
				variable = DialogueLua.GetVariable("]");
				if (((Result)(ref variable)).asInt < -117)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Up);
		return;
		IL_004e:
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(BONHDKBLOMP));
		goto IL_0074;
	}

	private IEnumerator MBEPAIHLGLG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		return new NKHLOJDJOGC(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			sendOnline = CDPAMNIPPEC
		};
	}

	private void IOFKCJBCHLJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			Result variable = DialogueLua.GetVariable("Button index hasn't been set up properly.");
			if (((Result)(ref variable)).asInt == 6)
			{
				OnlineCrowlyEvent.NDLFKBPAMMD();
			}
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(GHHMKBNFIDN));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			BONHDKBLOMP();
		}
	}

	private void MGMLDHPOLGK()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1879f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Down);
			characterAnimBase.animator.SetBool("Items/item_name_673", true);
		}
	}

	[SpecialName]
	public static CrowlyEvent IELEBCAELNI()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CrowlyEvent DOIKFJDLKJP()
	{
		return IADEMLIIDPC;
	}

	private void PNJJEDEFAGO()
	{
		IADEMLIIDPC = this;
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OIBDMBKHGDF));
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private IEnumerator JFDJNMOFDFH(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		}
		JCFILMOCAKK = true;
		startCrowlyEvent = false;
		yield return CommonReferences.wait3;
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		NessyNPC.GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		Object.Destroy((Object)(object)crowly);
	}

	private IEnumerator BIBOMADKLKG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		}
		JCFILMOCAKK = true;
		startCrowlyEvent = false;
		yield return CommonReferences.wait3;
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		NessyNPC.GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		Object.Destroy((Object)(object)crowly);
	}

	private void APDADNAOMPP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			Result variable = DialogueLua.GetVariable("KentaProgress");
			if (((Result)(ref variable)).asInt == 4)
			{
				OnlineCrowlyEvent.CNDINPBDEFG();
			}
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(IPFECOIDGAE));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			FBAHLMBFIDH();
		}
	}

	private void KEOFDFJMDAM()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 374f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Up);
			characterAnimBase.animator.SetBool("TimeLeft", false);
		}
	}

	private void NCIBKMLIIAJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			Result variable = DialogueLua.GetVariable("dog");
			if (((Result)(ref variable)).asInt <= 8)
			{
				goto IL_004e;
			}
			variable = DialogueLua.GetVariable("[ProceduralMine] Trying to force ALTAR piece at block {0} (target is {1}). Path block pos: {2}");
			if (((Result)(ref variable)).asInt > -183)
			{
				variable = DialogueLua.GetVariable("ReceiveAnimalSlotFromContainer");
				if (((Result)(ref variable)).asInt < -6)
				{
					goto IL_004e;
				}
			}
		}
		goto IL_0074;
		IL_0074:
		characterAnimBase.SetDirection(Direction.Down);
		return;
		IL_004e:
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		goto IL_0074;
	}

	private void APJNDKLBHCF()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1406f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Up);
			characterAnimBase.animator.SetBool("quest_description_28", false);
		}
	}

	private void MFJIHCKEIIF()
	{
		IADEMLIIDPC = this;
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IPFECOIDGAE));
	}

	public void JNKPNOFKPDB()
	{
		((MonoBehaviour)this).StartCoroutine(KCPGFEFEIBF());
	}

	private void PNEKMLEHKEM()
	{
		startCrowlyEvent = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DOELJDEJNAD));
		if (OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.LMCMKABMEKK();
		}
	}

	private IEnumerator MAMEEIABJEA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		return new NKHLOJDJOGC(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			sendOnline = CDPAMNIPPEC
		};
	}

	private void PHMFCIKFADH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			Result variable = DialogueLua.GetVariable("not target 2");
			if (((Result)(ref variable)).asInt == 2)
			{
				OnlineCrowlyEvent.OFAEGHNJOJC();
			}
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PHMFCIKFADH));
		}
		else if (OnlineManager.MasterOrOffline())
		{
			DCLFBNPJDGC();
		}
	}

	[SpecialName]
	public static CrowlyEvent ILMPOAEALPP()
	{
		return IADEMLIIDPC;
	}

	private void GOKBDDFNDFH()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 617f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Up);
			characterAnimBase.animator.SetBool("Object dropped on Bar position: ", true);
		}
	}

	private void LEEOKPCIOGA(Collider2D HANHCHBHHEH)
	{
		if (startCrowlyEvent && !crowly.activeInHierarchy && ANMAFLKPILP == null)
		{
			if (((Component)HANHCHBHHEH).CompareTag("MaxPrice"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(LHLKMOGOBIM(0));
			}
			else if (((Component)HANHCHBHHEH).CompareTag("christmasActivated"))
			{
				ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MFPJAEMPKDC(6));
			}
		}
		else if (startCrowlyEvent && crowly.activeInHierarchy && !NessyNPC.OMFKNGDCJFN().canTalk)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Could not assign file "))
			{
				NessyNPC.BNDMEINJPAN().StartObserverDialogue(0, MCJHGHLBBGL: true);
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Player"))
			{
				NessyNPC.DFJGHOHPPEL().StartObserverDialogue(5, MCJHGHLBBGL: true);
			}
		}
	}

	public void LEJKGGGGEBF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(BBDLCMDIHPC(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.HAFPKFFBHLH();
		}
	}

	public void MADKCAENBHM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(BALHCGIKGMB(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineCrowlyEvent.DKMIJOBHBFI();
		}
	}

	private void EFJFJJDGGGI()
	{
		IADEMLIIDPC = this;
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MDNCIAFNFCM));
	}

	private IEnumerator FGJOEKHNPOC()
	{
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		ANMAFLKPILP = null;
	}

	private void MMPMJNAFKHC()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK && (Object)(object)crowly != (Object)null)
		{
			crowly.transform.Translate(Vector2.op_Implicit(Vector2.down * 1586f * Time.deltaTime));
			characterAnimBase.SetDirection(Direction.Down);
			characterAnimBase.animator.SetBool("LE_13", true);
		}
	}

	private IEnumerator JJJNFAPLPFG()
	{
		crowly.SetActive(true);
		characterAnimBase.SetDirection(Direction.Up);
		((Component)NessyNPC.GGFJGHHHEJC).transform.position = new Vector3(-881.3125f, 32.45833f, 0f);
		NessyNPC.GGFJGHHHEJC.content.SetActive(true);
		yield return null;
		NessyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return null;
		NessyNPC.GGFJGHHHEJC.inSpecialEvent = true;
		ANMAFLKPILP = null;
	}
}
