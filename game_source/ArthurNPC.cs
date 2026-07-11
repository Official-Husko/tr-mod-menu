using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class ArthurNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class HKLPIFBJEEC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string bark;

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
		public HKLPIFBJEEC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				string text = bark;
				if (text == "Farm/Event/PiedrasVioletyArthur")
				{
					goto IL_006f;
				}
				if (text == "Farm/Event/SwordVioletArthur")
				{
					goto IL_00d0;
				}
				goto IL_012e;
			}
			case 1:
				_003C_003E1__state = -1;
				goto IL_006f;
			case 2:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.Bark(bark, CDPAMNIPPEC: false);
				break;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00d0;
			case 4:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.Bark(bark, CDPAMNIPPEC: false);
				break;
			case 5:
				_003C_003E1__state = -1;
				goto IL_012e;
			case 6:
				{
					_003C_003E1__state = -1;
					GGFJGHHHEJC.Bark(bark, CDPAMNIPPEC: false);
					break;
				}
				IL_00d0:
				if (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 4;
				return true;
				IL_012e:
				if (GGFJGHHHEJC.inBark)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 6;
				return true;
				IL_006f:
				if (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 2;
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

	[CompilerGenerated]
	private sealed class NKBOOAMDLIA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ArthurNPC _003C_003E4__this;

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
		public NKBOOAMDLIA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ArthurNPC arthurNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				arthurNPC.StopConversation();
				if (OnlineManager.PlayingOnline())
				{
					arthurNPC.onlineDialogue.SendStopConversation();
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				arthurNPC.EHHOHCPHAAO = playerNum;
				CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(playerNum);
				arthurNPC.NJJCCIBDAPM();
				arthurNPC.SelectDialogueUI(playerNum);
				arthurNPC.CheckPossibleStates(playerNum);
				AnimatorStateInfo currentAnimatorStateInfo = arthurNPC.arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
				if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
				{
					Debug.Log((object)"Look");
					arthurNPC.LookAtPlayer();
				}
				arthurNPC.mouseUpTrigger = true;
				arthurNPC.dialogue.OnUse();
				arthurNPC.BEGCPKOAJCP = null;
				return false;
			}
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

	private static ArthurNPC IADEMLIIDPC;

	private Coroutine BEGCPKOAJCP;

	public NPCAnimation arthurAnimation;

	private float FDBCHJMHBKF;

	private float IEIHJNPHGAJ;

	private float IFGFABPMGGK = 2f;

	private float PMCKBLAPLKK = 1f;

	private bool HCCBOAMEEIJ;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_8";

	public static ArthurNPC GGFJGHHHEJC => IADEMLIIDPC;

	private IEnumerator FCPEKHFEMEJ(string GAGJHPKONIC)
	{
		if (!(GAGJHPKONIC == "Farm/Event/PiedrasVioletyArthur"))
		{
			if (GAGJHPKONIC == "Farm/Event/SwordVioletArthur")
			{
				while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
			else
			{
				while (GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
		}
		else
		{
			while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
		}
	}

	public void DBPBPKCKBCB(string emotion)
	{
		LANAINBEMCM().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void OFOAOOAAIML()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(4)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(0) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("Reject"))
				{
					Debug.Log((object)"Light Fire");
					arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().IsInDialogue(0) && PlayerController.OPHDCMJLLEC(7).characterAnimation.animator.GetBool("Decline"))
			{
				Debug.Log((object)"Open");
				arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(5)).gameObject);
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = true;
		}
	}

	public void DBPHFKPLMBG()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
		}
	}

	private void KNICILHPKND()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(8) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(6)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(1) && PlayerController.OPHDCMJLLEC(1).characterAnimation.animator.GetBool("\n  doorSprite:         "))
				{
					Debug.Log((object)"HalloweenUseOnly");
					arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject, MAPFDGCKBLD: false);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IsInDialogue(7) && PlayerController.OPHDCMJLLEC(5).characterAnimation.animator.GetBool(""))
			{
				Debug.Log((object)"ActionExecutedRPC");
				arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	public void MFBCPPLCNEE()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(5)).gameObject, MAPFDGCKBLD: false);
		}
	}

	public void PCFKNNGHLLJ(string bark)
	{
		((MonoBehaviour)ABDJJBFNLBJ()).StartCoroutine(JJIOFIPPHLO(bark));
	}

	[SpecialName]
	public static ArthurNPC ABDJJBFNLBJ()
	{
		return IADEMLIIDPC;
	}

	public void FixedUpdate()
	{
		KCNFAHCOPJI();
	}

	private IEnumerator NCCMBJFJLEG(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void DCEDHIBBJJK(string bark)
	{
		((MonoBehaviour)AAFOFNEHPLC()).StartCoroutine(EPLNGFNODEG(bark));
	}

	public void LGMDDMFKIAD(string emotion)
	{
		CFLBNDLLABP().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static ArthurNPC CFHEJAGKIII()
	{
		return IADEMLIIDPC;
	}

	public void EOCNGCHINNJ(string bark)
	{
		((MonoBehaviour)EJHDHCNILDH()).StartCoroutine(HONDOBLPIJO(bark));
	}

	public void IOKILGMHFNE(string emotion)
	{
		EJHDHCNILDH().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void IGNLHLAAMMN()
	{
		OIPGANPOHBP();
	}

	[SpecialName]
	public static ArthurNPC HNNJEBNIPOI()
	{
		return IADEMLIIDPC;
	}

	public void GIACODBNDIP()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
		}
	}

	public void CLFGMALANIE()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(3)).gameObject);
		}
	}

	private void GNJKKIGMBON()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(5)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(0) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("ReceivePlayerLeftBed"))
				{
					Debug.Log((object)"'.");
					arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(7) && PlayerController.OPHDCMJLLEC(5).characterAnimation.animator.GetBool("Shoes"))
			{
				Debug.Log((object)"Meditation");
				arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(8)).gameObject, MAPFDGCKBLD: false);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	private IEnumerator JNOAOIEFEDE(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	public void FKJLMJHGIDK(string bark)
	{
		((MonoBehaviour)CFLBNDLLABP()).StartCoroutine(APALKMBOJMD(bark));
	}

	public void JJNMAGKMFEJ()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(3)).gameObject, MAPFDGCKBLD: false);
		}
	}

	private IEnumerator FCBLIFMAHMC(string GAGJHPKONIC)
	{
		if (!(GAGJHPKONIC == "Farm/Event/PiedrasVioletyArthur"))
		{
			if (GAGJHPKONIC == "Farm/Event/SwordVioletArthur")
			{
				while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
			else
			{
				while (GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
		}
		else
		{
			while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
		}
	}

	public void NLOEGNNLKKE()
	{
		MDDFCALHOPN();
	}

	public void FAIMNFBBGJN(string bark)
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(JDHLCHDKFLL(bark));
	}

	private IEnumerator HBPJFPIAOPI(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private void AMDLLAMIKHP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(5)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(0) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool("halloweenActivated"))
				{
					Debug.Log((object)"vibration");
					arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
					busy = false;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(5) && PlayerController.OPHDCMJLLEC(4).characterAnimation.animator.GetBool("Player/Bark/Tutorial/SleepBlock"))
			{
				Debug.Log((object)"Year");
				arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject);
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = true;
		}
	}

	public void NKNCBMDGCJJ()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
		}
	}

	private IEnumerator NIGJCGIOBBF(int JIIGOACEIKL)
	{
		return new NKBOOAMDLIA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void FGJNOKGJDCG(string bark)
	{
		((MonoBehaviour)KCFGPDHELKP()).StartCoroutine(JDHLCHDKFLL(bark));
	}

	[SpecialName]
	public static ArthurNPC LANAINBEMCM()
	{
		return IADEMLIIDPC;
	}

	private void MDDFCALHOPN()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(8) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().IsInDialogue(0) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool("Precision/DrinkEvent1"))
				{
					Debug.Log((object)"  ");
					arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(6) && PlayerController.OPHDCMJLLEC(3).characterAnimation.animator.GetBool("add item "))
			{
				Debug.Log((object)"Dialogue System/Conversation/Gass_Quest/Entry/24/Dialogue Text");
				arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject, MAPFDGCKBLD: false);
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = true;
		}
	}

	[SpecialName]
	public static ArthurNPC NGPHACGDNJN()
	{
		return IADEMLIIDPC;
	}

	private void OMAOEDGDJLC()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(8) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(2)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(0) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool(""))
				{
					Debug.Log((object)"Dog");
					arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(5) && PlayerController.GetPlayer(4).characterAnimation.animator.GetBool("Fortitude/MainEvent 3"))
			{
				Debug.Log((object)"Run");
				arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = false;
		}
	}

	public void HFMJABAPFHF()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(6)).gameObject, MAPFDGCKBLD: false);
		}
	}

	public void DAJMCFKBFDD(string bark)
	{
		((MonoBehaviour)HLMGBEGEAPC()).StartCoroutine(HGPJGJBHIDN(bark));
	}

	private IEnumerator KFAOHCKAGIK(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private IEnumerator EPLNGFNODEG(string GAGJHPKONIC)
	{
		if (!(GAGJHPKONIC == "Farm/Event/PiedrasVioletyArthur"))
		{
			if (GAGJHPKONIC == "Farm/Event/SwordVioletArthur")
			{
				while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
			else
			{
				while (GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
		}
		else
		{
			while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator NFNDNOKOOAC(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private void LANONBCAFIO()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(5) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(0) && PlayerController.OPHDCMJLLEC(1).characterAnimation.animator.GetBool("TooCold"))
				{
					Debug.Log((object)"Content");
					arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().IsInDialogue(7) && PlayerController.GetPlayer(8).characterAnimation.animator.GetBool("Ingredients list count == 0!"))
			{
				Debug.Log((object)"Light Fire");
				arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(7)).gameObject, MAPFDGCKBLD: false);
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	[SpecialName]
	public static ArthurNPC DEGPIHEEFHJ()
	{
		return IADEMLIIDPC;
	}

	public void IAFBFHALBJH(string emotion)
	{
		IDIGFHEHIDM().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void OJECLFGAAPN(string emotion)
	{
		HLMGBEGEAPC().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void JNLBEGGHJFN()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(3)).gameObject, MAPFDGCKBLD: false);
		}
	}

	[SpecialName]
	public static ArthurNPC KCFGPDHELKP()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator DBBGNBKMDFF(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private void DOIIJCMMGGA()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(8) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(0) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects"))
				{
					Debug.Log((object)" destroyed.");
					arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IsInDialogue(3) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool("itemCaramelAle"))
			{
				Debug.Log((object)"HandUp");
				arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	private IEnumerator CNHICIEMBDB(string GAGJHPKONIC)
	{
		if (!(GAGJHPKONIC == "Farm/Event/PiedrasVioletyArthur"))
		{
			if (GAGJHPKONIC == "Farm/Event/SwordVioletArthur")
			{
				while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
			else
			{
				while (GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
		}
		else
		{
			while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
		}
	}

	[SpecialName]
	public static ArthurNPC EBAIHKJHCCA()
	{
		return IADEMLIIDPC;
	}

	private void OIPGANPOHBP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(4)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(0) && PlayerController.OPHDCMJLLEC(1).characterAnimation.animator.GetBool("Unsaved progress will be lost."))
				{
					Debug.Log((object)"FerroProgress");
					arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(3) && PlayerController.OPHDCMJLLEC(2).characterAnimation.animator.GetBool("LearnPrecision"))
			{
				Debug.Log((object)"Grain");
				arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(5)).gameObject);
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = true;
		}
	}

	[SpecialName]
	public static ArthurNPC NBKKEINELDN()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static ArthurNPC HFHPMKJGMPA()
	{
		return IADEMLIIDPC;
	}

	public void BNIHJFMGFPL()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(2)).gameObject);
		}
	}

	private IEnumerator OHMBCGJBELG(int JIIGOACEIKL)
	{
		return new NKBOOAMDLIA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	private IEnumerator JDHLCHDKFLL(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	public void HAHFKJCIPKH()
	{
		CJAKMEIOJCN();
	}

	[SpecialName]
	public static ArthurNPC LHKFIDJFPDB()
	{
		return IADEMLIIDPC;
	}

	public void BDOLAEMDIIH(string bark)
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(CNHICIEMBDB(bark));
	}

	public void FKIEEDDAGKG()
	{
		OIPGANPOHBP();
	}

	[SpecialName]
	public static ArthurNPC NGIMIHFFNMH()
	{
		return IADEMLIIDPC;
	}

	public void OFNABDJCCEJ()
	{
		OIPGANPOHBP();
	}

	private IEnumerator FEOPOFINODN(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private void MMEDMKABALJ()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && PlayerController.OPHDCMJLLEC(1).characterAnimation.animator.GetBool("{0} is not active."))
				{
					Debug.Log((object)"Setup");
					arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
					busy = false;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(8) && PlayerController.OPHDCMJLLEC(6).characterAnimation.animator.GetBool("cameraZoom2"))
			{
				Debug.Log((object)"Send next game date as a host ");
				arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(6)).gameObject);
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	public void IAONIGGLBLO()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(3)).gameObject);
		}
	}

	public void NJFPIDNHBMN()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(5) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(2)).gameObject);
		}
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inUse && canTalk)
		{
			if (IsAvailableByProximity(JIIGOACEIKL))
			{
				if (inSpecialEvent)
				{
					base.EHHOHCPHAAO = JIIGOACEIKL;
					DialogueLua.SetVariable("BarkActor", (object)actorName);
					dialogue.conversation = "Farm/Event/RegañinaViolet";
					SelectDialogueUI();
					dialogue.OnUse();
					return true;
				}
				if (BEGCPKOAJCP == null)
				{
					BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(KACNGNMNFNK(JIIGOACEIKL));
				}
				return true;
			}
		}
		else if (!canTalk && !inUse)
		{
			StartObserverDialogue(JIIGOACEIKL);
		}
		return false;
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		int hKKKNMIKPCM = HKKKNMIKPCM;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (hKKKNMIKPCM != ((Result)(ref variable)).asInt && OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			string hDFMHCKKJJG = HDFMHCKKJJG;
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
		}
	}

	public void KDMFOALOBFC(string bark)
	{
		((MonoBehaviour)IDIGFHEHIDM()).StartCoroutine(EPLNGFNODEG(bark));
	}

	private void KCNFAHCOPJI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(2)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("Moving"))
				{
					Debug.Log((object)"DontWalk");
					arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IsInDialogue(2) && PlayerController.GetPlayer(2).characterAnimation.animator.GetBool("Moving"))
			{
				Debug.Log((object)"DontWalk2");
				arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = true;
		}
	}

	private void CJAKMEIOJCN()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(0) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool("<br/>Graphics Memory Size: "))
				{
					Debug.Log((object)"Player2");
					arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(8) && PlayerController.GetPlayer(3).characterAnimation.animator.GetBool("HotBath/Main 3"))
			{
				Debug.Log((object)"Must have a unique ID assigned.");
				arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject);
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = true;
		}
	}

	private IEnumerator BEGMJLGDBAD(string GAGJHPKONIC)
	{
		if (!(GAGJHPKONIC == "Farm/Event/PiedrasVioletyArthur"))
		{
			if (GAGJHPKONIC == "Farm/Event/SwordVioletArthur")
			{
				while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
			else
			{
				while (GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
		}
		else
		{
			while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator AIEPGLJMEPG(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void LAANEEHHDLL(string emotion)
	{
		OMFKNGDCJFN().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private IEnumerator EGICNNFFLBD(int JIIGOACEIKL)
	{
		return new NKBOOAMDLIA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void BOKOLOCCLEN()
	{
		OMAOEDGDJLC();
	}

	private IEnumerator ODCBPOLKBAN(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private void ANBEJEJJPJN()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(7)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(0) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("Trying to assign mine ID to an object without OnlineObject component."))
				{
					Debug.Log((object)"<color=#822F00>");
					arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().IsInDialogue(0) && PlayerController.GetPlayer(4).characterAnimation.animator.GetBool(""))
			{
				Debug.Log((object)"Exit build mode");
				arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(5)).gameObject, MAPFDGCKBLD: false);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = true;
		}
	}

	protected override void NJJCCIBDAPM()
	{
		dialogue.conversation = "Farm/Arthur/Main";
	}

	private void DLPDLLFABMA()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(1) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool("BanquetEvent instance is null. Make sure it is initialized before calling DeactivateBanquetEvent."))
				{
					Debug.Log((object)"\n<color=#d99100>");
					arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(6) && PlayerController.OPHDCMJLLEC(6).characterAnimation.animator.GetBool("[ControllerType:"))
			{
				Debug.Log((object)"TimeLeft");
				arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(3)).gameObject);
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = false;
		}
	}

	public void DKDLMNFCIHG(string bark)
	{
		((MonoBehaviour)KCFGPDHELKP()).StartCoroutine(CNHICIEMBDB(bark));
	}

	public void OPBNEPHLOBH(string bark)
	{
		((MonoBehaviour)DEGPIHEEFHJ()).StartCoroutine(APALKMBOJMD(bark));
	}

	public void HHECLDCGGBE(string emotion)
	{
		KFGKCKCDMLG().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator AFACOHNBGFK(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static ArthurNPC FJAMHCAAEAM()
	{
		return IADEMLIIDPC;
	}

	public void MCPDJHICBLA(string emotion)
	{
		GGFJGHHHEJC.emotionsController.DCCNJLBLFGI(emotion);
	}

	public override void InitDialogueStart()
	{
		if (mouseUpTrigger)
		{
			main = true;
			DisableDialogue();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.OnDialogueStart();
			}
			mouseUpTrigger = false;
		}
	}

	private IEnumerator EFJEMGEPPMJ(string GAGJHPKONIC)
	{
		if (!(GAGJHPKONIC == "Farm/Event/PiedrasVioletyArthur"))
		{
			if (GAGJHPKONIC == "Farm/Event/SwordVioletArthur")
			{
				while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
			else
			{
				while (GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
		}
		else
		{
			while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
		}
	}

	public void BarkSequence(string bark)
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(BEGMJLGDBAD(bark));
	}

	private void OLFNDAIKHDD()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(7)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(1) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("[ActivatePuzzle] Type: "))
				{
					Debug.Log((object)"Exit build mode");
					arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(7) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("ReceiveTrayState"))
			{
				Debug.Log((object)"HollyAnimalShop");
				arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(2)).gameObject);
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = true;
		}
	}

	private IEnumerator JJIOFIPPHLO(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private void GPPGCMPHLEF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(0) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("HorizontalMove"))
				{
					Debug.Log((object)"Received RPC SetAnimatorObjectStateRPC on {0}, but the target animatorObject was not found.");
					arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = false;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(0) && PlayerController.OPHDCMJLLEC(8).characterAnimation.animator.GetBool("V-Sync"))
			{
				Debug.Log((object)"CloseBoxSound ");
				arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(5) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = true;
		}
	}

	public void HDDABJNLLLG(string bark)
	{
		((MonoBehaviour)ABDJJBFNLBJ()).StartCoroutine(APALKMBOJMD(bark));
	}

	public void KBCFNPHJMJO()
	{
		DOIIJCMMGGA();
	}

	[SpecialName]
	public static ArthurNPC KFGKCKCDMLG()
	{
		return IADEMLIIDPC;
	}

	public void FNANIIAOOEO(string bark)
	{
		((MonoBehaviour)EBAIHKJHCCA()).StartCoroutine(EFJEMGEPPMJ(bark));
	}

	private IEnumerator LIKKAPKJCLJ(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void OAMIDEIHNDM()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void CMJJFJFDNED()
	{
		JANJFGBMLDE();
	}

	public void HNLFNIOKFJE()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
		}
	}

	private IEnumerator BFOANMDADNO(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void NNIPLEIEGJA()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
		}
	}

	private IEnumerator APEJOHGFHFE(int JIIGOACEIKL)
	{
		return new NKBOOAMDLIA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void GEFMFLAGCKF(string bark)
	{
		((MonoBehaviour)HLMGBEGEAPC()).StartCoroutine(HGPJGJBHIDN(bark));
	}

	[SpecialName]
	public static ArthurNPC HLMGBEGEAPC()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator OJEHIJGNNPB(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void FAOKIMMAJJI()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(6)).gameObject);
		}
	}

	private IEnumerator JLMIOIBKAKO(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator KACNGNMNFNK(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator OJOEHLJDOEE(int JIIGOACEIKL)
	{
		return new NKBOOAMDLIA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator ANANILBDEJE(int JIIGOACEIKL)
	{
		return new NKBOOAMDLIA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void OOBDKJHKPEP()
	{
		GNJKKIGMBON();
	}

	public void NDJGLEMAAJF(string bark)
	{
		((MonoBehaviour)FJAMHCAAEAM()).StartCoroutine(FCPEKHFEMEJ(bark));
	}

	private IEnumerator IOKBJAPAJPB(int JIIGOACEIKL)
	{
		return new NKBOOAMDLIA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void HCFMEHNAMAM()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(4)).gameObject);
		}
	}

	[SpecialName]
	public static ArthurNPC CFLBNDLLABP()
	{
		return IADEMLIIDPC;
	}

	public void KDCHBIFCIBO(string emotion)
	{
		CFHEJAGKIII().emotionsController.PIOCPGKDAOF(emotion);
	}

	private IEnumerator KNGGLPDOMEN(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator MNLPNNLFHPF(int JIIGOACEIKL)
	{
		return new NKBOOAMDLIA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator HONDOBLPIJO(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private void JANJFGBMLDE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(1) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("[HierarchyPrinter] Activa al menos una opción de salida."))
				{
					Debug.Log((object)"[PipeConnectionPuzzleUI] Falta _previewDatabase.");
					arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(1) && PlayerController.GetPlayer(5).characterAnimation.animator.GetBool("\n"))
			{
				Debug.Log((object)"BarnTutorialDone");
				arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(8)).gameObject);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	public void CNLOJJIMKNG(string bark)
	{
		((MonoBehaviour)NGPHACGDNJN()).StartCoroutine(FCBLIFMAHMC(bark));
	}

	public void MGNHIHICCCB()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(5)).gameObject);
		}
	}

	private IEnumerator HGPJGJBHIDN(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private IEnumerator GEMHJPLFEGO(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = arthurAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void DGGMELLBHMK()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(5)).gameObject);
		}
	}

	public void LookAtPlayer()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
		}
	}

	private void DNCCDPKOJPB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().IsInDialogue(1) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("Festín del Juramento/ComensalesBarks"))
				{
					Debug.Log((object)"Style");
					arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
					busy = false;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(6) && PlayerController.GetPlayer(4).characterAnimation.animator.GetBool("Interact"))
			{
				Debug.Log((object)"Orders");
				arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(8)).gameObject);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = true;
		}
	}

	private void PGIJKILANFP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(5)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(0) && PlayerController.OPHDCMJLLEC(1).characterAnimation.animator.GetBool("Waiting for players to finish their transitions..."))
				{
					Debug.Log((object)" has null in variant objects list.");
					arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
					busy = false;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(8) && PlayerController.GetPlayer(6).characterAnimation.animator.GetBool("Player2"))
			{
				Debug.Log((object)" ");
				arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(3)).gameObject);
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	private void IDNHNKJEODI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		}
		if (arthurAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(0) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("Hint key is not set for this puzzle hint."))
				{
					Debug.Log((object)"ReceiveItemContainerMessage");
					arthurAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().IsInDialogue(1) && PlayerController.OPHDCMJLLEC(3).characterAnimation.animator.GetBool("Key1"))
			{
				Debug.Log((object)"Waiting for other players");
				arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(8)).gameObject);
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	public void BEHNPNHMILC(string bark)
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(EPLNGFNODEG(bark));
	}

	public void FLDOELEICDL()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(3)).gameObject);
		}
	}

	[SpecialName]
	public static ArthurNPC KMKILBCGJOI()
	{
		return IADEMLIIDPC;
	}

	public void GBIDNAGBLBF()
	{
		LANONBCAFIO();
	}

	[SpecialName]
	public static ArthurNPC OMFKNGDCJFN()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static ArthurNPC AAFOFNEHPLC()
	{
		return IADEMLIIDPC;
	}

	public void DGIFHBIJDDE()
	{
		OMAOEDGDJLC();
	}

	public void KGABNOLDJDN()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			arthurAnimation.LookAtObject(((Component)PlayerController.GetPlayer(8)).gameObject, MAPFDGCKBLD: false);
		}
	}

	private IEnumerator APALKMBOJMD(string GAGJHPKONIC)
	{
		if (!(GAGJHPKONIC == "Farm/Event/PiedrasVioletyArthur"))
		{
			if (GAGJHPKONIC == "Farm/Event/SwordVioletArthur")
			{
				while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
			else
			{
				while (GGFJGHHHEJC.inBark)
				{
					yield return null;
				}
				yield return CommonReferences.wait01;
				GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			}
		}
		else
		{
			while (VioletNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		NJJCCIBDAPM();
	}

	[SpecialName]
	public static ArthurNPC EJHDHCNILDH()
	{
		return IADEMLIIDPC;
	}

	public void FDNPAOECMKE(string bark)
	{
		((MonoBehaviour)NGPHACGDNJN()).StartCoroutine(CNHICIEMBDB(bark));
	}

	[SpecialName]
	public static ArthurNPC IDIGFHEHIDM()
	{
		return IADEMLIIDPC;
	}

	public void AHFAJIBFKGK(string emotion)
	{
		LHKFIDJFPDB().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void GIHCKNBINMG()
	{
		MDDFCALHOPN();
	}
}
