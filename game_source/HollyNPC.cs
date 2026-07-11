using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HollyNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class JHMNAAJBGKC : IEnumerator<object>, IEnumerator, IDisposable
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
		public JHMNAAJBGKC(int _003C_003E1__state)
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
				_003C_003E1__state = -1;
				if (bark == "Farm/Event/Love")
				{
					goto IL_0055;
				}
				goto IL_00b3;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0055;
			case 2:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.Bark(bark, CDPAMNIPPEC: false);
				break;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00b3;
			case 4:
				{
					_003C_003E1__state = -1;
					GGFJGHHHEJC.Bark(bark, CDPAMNIPPEC: false);
					break;
				}
				IL_00b3:
				if (GGFJGHHHEJC.inBark)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 4;
				return true;
				IL_0055:
				if (BuzzNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
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
	private sealed class JIFKEELNMCL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public JIFKEELNMCL(int _003C_003E1__state)
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
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
				if (OnlineManager.ClientOnline())
				{
					GGFJGHHHEJC.onlineDialogue.SendHollyDirectionForTutorial(0);
				}
				PlayerController.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).characterAnimation.FCGBJEIIMBC = Direction.Up;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeIn();
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.StartConversation(GGFJGHHHEJC.EHHOHCPHAAO, "Tutorial/Barn_Holly");
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
	private sealed class GCDCIBMPECC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public GCDCIBMPECC(int _003C_003E1__state)
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
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
				if (OnlineManager.ClientOnline())
				{
					GGFJGHHHEJC.onlineDialogue.SendHollyDirectionForTutorial(0);
				}
				PlayerController.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).characterAnimation.FCGBJEIIMBC = Direction.Up;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeInWithDelay();
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.StartConversation(GGFJGHHHEJC.EHHOHCPHAAO, "Tutorial/Chicken_Holly");
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
	private sealed class DMIIKKCFGGL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public DMIIKKCFGGL(int _003C_003E1__state)
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
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeInWithDelay();
				PlayerInputs.EnableKeyboardInputs(GGFJGHHHEJC.EHHOHCPHAAO, (MonoBehaviour)(object)GGFJGHHHEJC);
				PlayerController.RemoveMovementBlocker(GGFJGHHHEJC.EHHOHCPHAAO, (Object)(object)GGFJGHHHEJC);
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
	private sealed class ABPADLFIKOA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HollyNPC _003C_003E4__this;

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
		public ABPADLFIKOA(int _003C_003E1__state)
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
			HollyNPC hollyNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				hollyNPC.StopConversation();
				if (OnlineManager.PlayingOnline())
				{
					hollyNPC.onlineDialogue.SendStopConversation();
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				hollyNPC.EHHOHCPHAAO = playerNum;
				CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(playerNum);
				hollyNPC.NJJCCIBDAPM();
				hollyNPC.SelectDialogueUI(playerNum);
				hollyNPC.CheckPossibleStates(playerNum);
				AnimatorStateInfo currentAnimatorStateInfo = hollyNPC.hollyAnimation.animator.GetCurrentAnimatorStateInfo(0);
				if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
				{
					hollyNPC.LookAtPlayer();
				}
				hollyNPC.mouseUpTrigger = true;
				hollyNPC.dialogue.OnUse();
				hollyNPC.BEGCPKOAJCP = null;
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

	private static HollyNPC IADEMLIIDPC;

	private Coroutine BEGCPKOAJCP;

	public NPCAnimation hollyAnimation;

	private float FDBCHJMHBKF;

	private float IEIHJNPHGAJ;

	private float IFGFABPMGGK = 2f;

	private float PMCKBLAPLKK = 1f;

	private bool HCCBOAMEEIJ;

	private Vector3 FBECPDLNIKC;

	public GameObject barnTravelZone;

	public GameObject barnBarkCollider;

	public Transform[] barnTpPos;

	public Transform[] barnTpPos2;

	public Transform[] barnTpPos3;

	[HideInInspector]
	public AnimalNPC barnTutorialAnimal;

	public GameObject[] arrows;

	public Material defaultMaterial;

	public Material outlineMaterial;

	public SpriteRenderer[] foodFeeder;

	public SpriteRenderer[] waterFeeder;

	public NPCRoutine hollyRoutine;

	public bool inBarnTutorial;

	private float GPEJKMJNEEK;

	private HenHouse EJOJOPGGHLI;

	private bool GGKOGAMMNJP;

	private int HKKKNMIKPCM;

	private bool APFBGJJCLCM;

	private bool GGNFOPEKCOF;

	private string HDFMHCKKJJG = "LE_6";

	public GameObject[] inputObj;

	public static HollyNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void BELPBBLFAPN()
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
		if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(4)).transform.position, ((Component)this).transform.position);
		}
		if (hollyAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(1) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("UIInteract"))
				{
					Debug.Log((object)"Information");
					hollyAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject, MAPFDGCKBLD: false);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(7) && PlayerController.OPHDCMJLLEC(3).characterAnimation.animator.GetBool("Farm/Event/Love"))
			{
				Debug.Log((object)"ReceiveAskHostForRoomToJoin");
				hollyAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(6)).gameObject);
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null)
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

	public void LookAtPlayer()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			hollyAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			hollyAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
		}
	}

	public void BDLPFKMJKMH()
	{
		for (int i = 1; i < HenHouseTutorialUI.AGGAGCBAGLL().henHouseMask.Length; i += 0)
		{
			HenHouseTutorialUI.EFPJLFMBPLL().henHouseMask[i].SetActive(true);
		}
		for (int j = 1; j < HenHouseTutorialUI.BDAGIEIJOOG().henHouseMask2.Length; j += 0)
		{
			HenHouseTutorialUI.AJIGOHGPFPP().henHouseMask2[j].SetActive(false);
		}
		for (int k = 1; k < HenHouseTutorialUI.LFPEPJBNCBF().henHouseMask3.Length; k++)
		{
			HenHouseTutorialUI.LADDMEMMJFP().henHouseMask3[k].SetActive(true);
		}
	}

	public void LAJKICDOFLF()
	{
		CommonReferences.MNFMOEKMJKN().barnAnimalsTutorial = true;
		EKGMDIHLEEH().barnTutorialAnimal.Sick(CDPAMNIPPEC: true);
		PlayerInventory.NEKDDPIAOBE(OOKBNHMMFON().EHHOHCPHAAO, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.CPMMBEPEJLO(81, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
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
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		}
		if (hollyAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(0) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool("Error in TavernEventManager.EndOfDayEventCheck: "))
				{
					Debug.Log((object)"Player2");
					hollyAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(3) && PlayerController.GetPlayer(4).characterAnimation.animator.GetBool("Online Placeable Null"))
			{
				Debug.Log((object)"<color=#A95A00>+");
				hollyAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(3)).gameObject);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null)
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

	public void BarnTp()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GGFJGHHHEJC.inputObj.Length; i++)
		{
			GGFJGHHHEJC.inputObj[i].SetActive(false);
		}
		GGFJGHHHEJC.inTutorial = false;
		GGFJGHHHEJC.inBarnTutorial = true;
		GGFJGHHHEJC.barnBarkCollider.SetActive(true);
		CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = true;
		GGFJGHHHEJC.barnTravelZone.SetActive(false);
		GGFJGHHHEJC.FBECPDLNIKC = ((Component)GGFJGHHHEJC).transform.position;
		if (OnlineManager.ClientOnline())
		{
			GGFJGHHHEJC.onlineDialogue.SendHollyPositionForTutorial(((Component)GGFJGHHHEJC).transform.position);
		}
		FadeCamera player = FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GGFJGHHHEJC.DELJMIKKGIB));
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeOut();
	}

	public void SickAnimal()
	{
		CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = true;
		GGFJGHHHEJC.barnTutorialAnimal.Sick(CDPAMNIPPEC: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(1235).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void HIHJIOMOAOJ(bool active)
	{
		if (active)
		{
			for (int i = 1; i < EHJOPCBIGAB().waterFeeder.Length; i++)
			{
				((Renderer)JFJOKGAOPHA().waterFeeder[i]).material = JFJOKGAOPHA().outlineMaterial;
			}
		}
		else
		{
			for (int j = 0; j < JFJOKGAOPHA().waterFeeder.Length; j += 0)
			{
				((Renderer)EHJOPCBIGAB().waterFeeder[j]).material = GGFJGHHHEJC.defaultMaterial;
			}
		}
	}

	public void OEKAKLPMNNE()
	{
		if (GameManager.LocalCoop())
		{
			if (EKGMDIHLEEH().EHHOHCPHAAO == 1)
			{
				HenHouseTutorialUI.BAKPBHPNKPB().henHouseTutorial[0].SetActive(true);
			}
			else
			{
				HenHouseTutorialUI.HNNJEBNIPOI().henHouseTutorial[6].SetActive(false);
			}
		}
		else
		{
			HenHouseTutorialUI.BAKPBHPNKPB().henHouseTutorial[1].SetActive(true);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void FMBEGDCIHHH(string emotion)
	{
		JFJOKGAOPHA().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void GGEJIFNBOIL()
	{
		for (int i = 1; i < BarnTutorialUI.HEKFJEKFMNO().barnTutorial.Length; i += 0)
		{
			BarnTutorialUI.BGMJCCFNNDL().barnTutorial[i].SetActive(true);
		}
	}

	public void ENHPMGIOBLL()
	{
		BPPBLHOOEDE();
	}

	public void NBNCMOAPDOG()
	{
		BELPBBLFAPN();
	}

	public void OIPHFBKLHLF(bool active)
	{
		if (active)
		{
			for (int i = 0; i < GGFJGHHHEJC.foodFeeder.Length; i++)
			{
				((Renderer)JFJOKGAOPHA().foodFeeder[i]).material = JFJOKGAOPHA().outlineMaterial;
			}
		}
		else
		{
			for (int j = 1; j < JFJOKGAOPHA().foodFeeder.Length; j += 0)
			{
				((Renderer)OOKBNHMMFON().foodFeeder[j]).material = EKGMDIHLEEH().defaultMaterial;
			}
		}
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	private IEnumerator BEGMJLGDBAD(string GAGJHPKONIC)
	{
		if (GAGJHPKONIC == "Farm/Event/Love")
		{
			while (BuzzNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
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

	public void HFDMGAHIJKC()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(JFJOKGAOPHA().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(EKGMDIHLEEH().BIEPOPICILE));
		FadeCamera.IGMCBPOPNCA(OOKBNHMMFON().EHHOHCPHAAO).FadeOut(56f);
		EHJOPCBIGAB().inTutorial = true;
		GGFJGHHHEJC.FBECPDLNIKC = ((Component)EKGMDIHLEEH()).transform.position;
	}

	private void NNJKFFPBOKH(int ABAIKKGKDGD)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(OOKBNHMMFON().BIEPOPICILE));
		EKGMDIHLEEH().EJOJOPGGHLI = FarmConstructionManager.GetHenHouse();
		if (GameManager.EAOOLEFMIKE() || (GameManager.LocalCoop() && PlayerController.GetPlayer(1).LEOIMFNKFGA != PlayerController.OPHDCMJLLEC(5).LEOIMFNKFGA))
		{
			SceneManager.UnloadSceneAsync(PlayerController.OPHDCMJLLEC(GGFJGHHHEJC.EHHOHCPHAAO).LEOIMFNKFGA.ToString());
		}
		PlayerController.TeleportPlayer(EKGMDIHLEEH().EHHOHCPHAAO, GGFJGHHHEJC.EJOJOPGGHLI.tpPositions[0].position, Location.Road | Location.River);
		((Component)GGFJGHHHEJC).transform.position = EKGMDIHLEEH().EJOJOPGGHLI.tpPositions[0].position;
		if (OnlineManager.ClientOnline())
		{
			JFJOKGAOPHA().onlineDialogue.SendHollyPositionForTutorial(OOKBNHMMFON().EJOJOPGGHLI.tpPositions[1].position);
		}
		((MonoBehaviour)JFJOKGAOPHA()).StartCoroutine(BIGFACIEPKB());
	}

	public void LOOILKKBGHN()
	{
		for (int i = 0; i < BarnTutorialUI.AJIGOHGPFPP().barnMask.Length; i++)
		{
			BarnTutorialUI.GGFJGHHHEJC.barnMask[i].SetActive(false);
		}
		for (int j = 1; j < BarnTutorialUI.KGPJPILAHDE().barnMask2.Length; j++)
		{
			BarnTutorialUI.BGMJCCFNNDL().barnMask2[j].SetActive(false);
		}
		for (int k = 0; k < BarnTutorialUI.BGMJCCFNNDL().barnMask3.Length; k++)
		{
			BarnTutorialUI.MLPCDJPLBAC().barnMask3[k].SetActive(true);
		}
	}

	public void FEGGOJBHIKH()
	{
		for (int i = 1; i < BarnTutorialUI.MLPCDJPLBAC().barnTutorial.Length; i += 0)
		{
			BarnTutorialUI.MLPCDJPLBAC().barnTutorial[i].SetActive(true);
		}
	}

	private IEnumerator MFHJEEDGDHI()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		if (OnlineManager.ClientOnline())
		{
			GGFJGHHHEJC.onlineDialogue.SendHollyDirectionForTutorial(0);
		}
		PlayerController.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).characterAnimation.FCGBJEIIMBC = Direction.Up;
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeIn();
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.StartConversation(GGFJGHHHEJC.EHHOHCPHAAO, "Tutorial/Barn_Holly");
	}

	public void ActiveArrows(bool active)
	{
		for (int i = 0; i < GGFJGHHHEJC.arrows.Length; i++)
		{
			GGFJGHHHEJC.arrows[i].SetActive(active);
		}
	}

	private void JGAEMCPPOKB(int ABAIKKGKDGD)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GGFJGHHHEJC.JGAEMCPPOKB));
		((Component)GGFJGHHHEJC).transform.position = GGFJGHHHEJC.FBECPDLNIKC;
		if (OnlineManager.ClientOnline())
		{
			GGFJGHHHEJC.onlineDialogue.SendHollyPositionForTutorial(GGFJGHHHEJC.FBECPDLNIKC);
			GGFJGHHHEJC.onlineDialogue.SendHollyDirectionForTutorial(1);
		}
		GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Down;
		GGFJGHHHEJC.barnTravelZone.SetActive(true);
		GGFJGHHHEJC.hollyRoutine.inTutorial = false;
		((Behaviour)GGFJGHHHEJC.hollyRoutine).enabled = true;
		if (GGFJGHHHEJC.GGKOGAMMNJP)
		{
			if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, GGFJGHHHEJC.barnTpPos[0].position, Location.BarnInterior);
			}
			else if (Barn.instance.EONJGMONIOM == 1)
			{
				PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, GGFJGHHHEJC.barnTpPos2[0].position, Location.BarnInterior);
			}
			else if (Barn.instance.EONJGMONIOM == 2)
			{
				PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, GGFJGHHHEJC.barnTpPos3[0].position, Location.BarnInterior);
			}
		}
		for (int i = 0; i < GGFJGHHHEJC.inputObj.Length; i++)
		{
			GGFJGHHHEJC.inputObj[i].SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(GOMOLOOLDIP());
	}

	public void HICCBGANODN(int num)
	{
		if (GameManager.LocalCoop())
		{
			if (GGFJGHHHEJC.EHHOHCPHAAO == 0)
			{
				for (int i = 0; i < HenHouseTutorialUI.BAKPBHPNKPB().henHouseMask2.Length; i += 0)
				{
					HenHouseTutorialUI.GJFMMOPOKGJ().henHouseMask2[i].SetActive(false);
				}
				HenHouseTutorialUI.ICNFHJLLHGP().henHouseMask2[0].SetActive(true);
				HenHouseTutorialUI.PDECKLKPKCG().henHouseMask2[num].SetActive(false);
			}
			else
			{
				for (int j = 0; j < HenHouseTutorialUI.EAGMIHGJKNB().henHouseMask3.Length; j++)
				{
					HenHouseTutorialUI.LFPEPJBNCBF().henHouseMask3[j].SetActive(false);
				}
				HenHouseTutorialUI.NJNFHEPLEHL().henHouseMask3[1].SetActive(false);
				HenHouseTutorialUI.DEGPIHEEFHJ().henHouseMask3[num].SetActive(true);
			}
		}
		else
		{
			for (int k = 0; k < HenHouseTutorialUI.AFFGPMFKEFH().henHouseMask.Length; k++)
			{
				HenHouseTutorialUI.LPFNKEOJJKE().henHouseMask[k].SetActive(false);
			}
			HenHouseTutorialUI.LFPEPJBNCBF().henHouseMask[0].SetActive(false);
			HenHouseTutorialUI.LADDMEMMJFP().henHouseMask[num].SetActive(true);
		}
	}

	private void ADHPCOKBLIE(int ABAIKKGKDGD)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(GGFJGHHHEJC.EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(OOKBNHMMFON().EMNPAMOIGPJ));
		((Component)OOKBNHMMFON()).transform.position = GGFJGHHHEJC.FBECPDLNIKC;
		if (OnlineManager.HHDBMDMFEMP())
		{
			JFJOKGAOPHA().onlineDialogue.SendHollyPositionForTutorial(OOKBNHMMFON().FBECPDLNIKC);
			EHJOPCBIGAB().onlineDialogue.GCDNIGNNIGP(0);
		}
		JFJOKGAOPHA().animationBase.NCAJNNHBHJM(Direction.Up);
		GGFJGHHHEJC.barnTravelZone.SetActive(true);
		GGFJGHHHEJC.hollyRoutine.inTutorial = false;
		((Behaviour)EKGMDIHLEEH().hollyRoutine).enabled = true;
		if (OOKBNHMMFON().GGKOGAMMNJP)
		{
			if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, EHJOPCBIGAB().barnTpPos[1].position, Location.Road | Location.Quarry);
			}
			else if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, OOKBNHMMFON().barnTpPos2[1].position, ~(Location.Road | Location.River | Location.Quarry | Location.BarnInterior));
			}
			else if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(EKGMDIHLEEH().EHHOHCPHAAO, EHJOPCBIGAB().barnTpPos3[1].position, Location.Tavern | Location.River | Location.Camp | Location.BarnInterior);
			}
		}
		for (int i = 0; i < GGFJGHHHEJC.inputObj.Length; i++)
		{
			EKGMDIHLEEH().inputObj[i].SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(GOMOLOOLDIP());
	}

	public void LLAAAJIHBKA()
	{
		for (int i = 1; i < HenHouseTutorialUI.BNDNMBGJEKP().henHouseMask.Length; i += 0)
		{
			HenHouseTutorialUI.BGMJCCFNNDL().henHouseMask[i].SetActive(false);
		}
		for (int j = 0; j < HenHouseTutorialUI.OOKBNHMMFON().henHouseMask2.Length; j++)
		{
			HenHouseTutorialUI.GJFMMOPOKGJ().henHouseMask2[j].SetActive(false);
		}
		for (int k = 1; k < HenHouseTutorialUI.BAKPBHPNKPB().henHouseMask3.Length; k++)
		{
			HenHouseTutorialUI.OKAPNFPFPFP().henHouseMask3[k].SetActive(true);
		}
	}

	public void KLHAAFJOOMC()
	{
		OIPGANPOHBP();
	}

	private IEnumerator DICCPLGAGPC()
	{
		return new JIFKEELNMCL(1);
	}

	public void FKFGPMLIBOL()
	{
		CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = false;
		EKGMDIHLEEH().barnTutorialAnimal.Sick(CDPAMNIPPEC: false);
		PlayerInventory.EIFPKCAFDIB(EHJOPCBIGAB().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.KMBGJEKCJFJ(94, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
	}

	private IEnumerator DEHODPIBPCL()
	{
		return new GCDCIBMPECC(1);
	}

	private void DKDMIMMNHGM(int ABAIKKGKDGD)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(JFJOKGAOPHA().EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(OOKBNHMMFON().IPIOHMBCHNO));
		((Component)GGFJGHHHEJC).transform.position = JFJOKGAOPHA().FBECPDLNIKC;
		if (OnlineManager.ClientOnline())
		{
			EKGMDIHLEEH().onlineDialogue.SendHollyPositionForTutorial(EKGMDIHLEEH().FBECPDLNIKC);
			EKGMDIHLEEH().onlineDialogue.GCDNIGNNIGP(0);
		}
		GGFJGHHHEJC.animationBase.NCAJNNHBHJM(Direction.Up);
		EHJOPCBIGAB().barnTravelZone.SetActive(false);
		OOKBNHMMFON().hollyRoutine.inTutorial = false;
		((Behaviour)OOKBNHMMFON().hollyRoutine).enabled = false;
		if (OOKBNHMMFON().GGKOGAMMNJP)
		{
			if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(OOKBNHMMFON().EHHOHCPHAAO, GGFJGHHHEJC.barnTpPos[0].position, Location.Tavern | Location.Camp | Location.Farm);
			}
			else if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(JFJOKGAOPHA().EHHOHCPHAAO, OOKBNHMMFON().barnTpPos2[0].position, Location.Tavern | Location.Road | Location.River | Location.Farm | Location.BarnInterior);
			}
			else if (Barn.instance.EONJGMONIOM == 4)
			{
				PlayerController.TeleportPlayer(JFJOKGAOPHA().EHHOHCPHAAO, EHJOPCBIGAB().barnTpPos3[0].position, ~(Location.Tavern | Location.Road | Location.River | Location.Farm));
			}
		}
		for (int i = 0; i < GGFJGHHHEJC.inputObj.Length; i += 0)
		{
			GGFJGHHHEJC.inputObj[i].SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(GOMOLOOLDIP());
	}

	public void CloseUI()
	{
		for (int i = 0; i < HenHouseTutorialUI.GGFJGHHHEJC.henHouseTutorial.Length; i++)
		{
			HenHouseTutorialUI.GGFJGHHHEJC.henHouseTutorial[i].SetActive(false);
		}
	}

	public void PCPNEJOIKAN()
	{
		BJABHDJBBGE();
	}

	private void GOIPEOBLNKI(int ABAIKKGKDGD)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(JFJOKGAOPHA().EMNPAMOIGPJ));
		((Component)JFJOKGAOPHA()).transform.position = OOKBNHMMFON().FBECPDLNIKC;
		if (OnlineManager.ClientOnline())
		{
			EHJOPCBIGAB().onlineDialogue.SendHollyPositionForTutorial(GGFJGHHHEJC.FBECPDLNIKC);
			EHJOPCBIGAB().onlineDialogue.CCBENPEMMLF(1);
		}
		EKGMDIHLEEH().animationBase.NCAJNNHBHJM(Direction.Up);
		GGFJGHHHEJC.barnTravelZone.SetActive(true);
		OOKBNHMMFON().hollyRoutine.inTutorial = true;
		((Behaviour)OOKBNHMMFON().hollyRoutine).enabled = false;
		if (EKGMDIHLEEH().GGKOGAMMNJP)
		{
			if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(EHJOPCBIGAB().EHHOHCPHAAO, EKGMDIHLEEH().barnTpPos[1].position, ~(Location.River | Location.Camp | Location.Farm));
			}
			else if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(EKGMDIHLEEH().EHHOHCPHAAO, JFJOKGAOPHA().barnTpPos2[0].position, ~(Location.Tavern | Location.River | Location.Quarry));
			}
			else if (Barn.instance.EONJGMONIOM == 8)
			{
				PlayerController.TeleportPlayer(OOKBNHMMFON().EHHOHCPHAAO, JFJOKGAOPHA().barnTpPos3[0].position, ~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior));
			}
		}
		for (int i = 0; i < OOKBNHMMFON().inputObj.Length; i++)
		{
			EKGMDIHLEEH().inputObj[i].SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(EFGCGJCJOKA());
	}

	public void OINBNGCKOCN()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GGFJGHHHEJC.inputObj.Length; i += 0)
		{
			EKGMDIHLEEH().inputObj[i].SetActive(false);
		}
		GGFJGHHHEJC.inTutorial = true;
		JFJOKGAOPHA().inBarnTutorial = true;
		JFJOKGAOPHA().barnBarkCollider.SetActive(true);
		CommonReferences.MNFMOEKMJKN().barnAnimalsTutorial = false;
		EKGMDIHLEEH().barnTravelZone.SetActive(true);
		EHJOPCBIGAB().FBECPDLNIKC = ((Component)GGFJGHHHEJC).transform.position;
		if (OnlineManager.ClientOnline())
		{
			EHJOPCBIGAB().onlineDialogue.SendHollyPositionForTutorial(((Component)OOKBNHMMFON()).transform.position);
		}
		FadeCamera player = FadeCamera.GetPlayer(EHJOPCBIGAB().EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GGFJGHHHEJC.DELJMIKKGIB));
		FadeCamera.EIFPKCAFDIB(EKGMDIHLEEH().EHHOHCPHAAO).IONMINJHMKL(1913f);
	}

	public void MMMNBGGELEL()
	{
		for (int i = 0; i < BarnTutorialUI.BDAGIEIJOOG().barnTutorial.Length; i += 0)
		{
			BarnTutorialUI.HEKFJEKFMNO().barnTutorial[i].SetActive(true);
		}
	}

	public void IIOHODCBPJK()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			hollyAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			hollyAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(5)).gameObject);
		}
	}

	private IEnumerator EFGCGJCJOKA()
	{
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeInWithDelay();
		PlayerInputs.EnableKeyboardInputs(GGFJGHHHEJC.EHHOHCPHAAO, (MonoBehaviour)(object)GGFJGHHHEJC);
		PlayerController.RemoveMovementBlocker(GGFJGHHHEJC.EHHOHCPHAAO, (Object)(object)GGFJGHHHEJC);
	}

	public void FAKMHPBPLKA()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(GGFJGHHHEJC.EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(GGFJGHHHEJC.BIEPOPICILE));
		FadeCamera.EIFPKCAFDIB(JFJOKGAOPHA().EHHOHCPHAAO).FadeOut(440f);
		EKGMDIHLEEH().inTutorial = false;
		EHJOPCBIGAB().FBECPDLNIKC = ((Component)GGFJGHHHEJC).transform.position;
	}

	public void EKNGKMMOGLF()
	{
		AnimalShopUI.ANPKEGFMLED(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
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
		AnimatorStateInfo currentAnimatorStateInfo = hollyAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void OLPCANEECJN()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			hollyAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			hollyAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(3)).gameObject, MAPFDGCKBLD: false);
		}
	}

	public void DBKIFOIJGIK()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			hollyAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			hollyAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(2)).gameObject);
		}
	}

	public void LLKAFMDCNPF()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(JFJOKGAOPHA().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(JFJOKGAOPHA().AKCMEMJPINO));
		FadeCamera.EIFPKCAFDIB(JFJOKGAOPHA().EHHOHCPHAAO).FadeOut(669f);
		GGFJGHHHEJC.inTutorial = false;
		JFJOKGAOPHA().FBECPDLNIKC = ((Component)OOKBNHMMFON()).transform.position;
	}

	public void GJBHKFLCLBE()
	{
		for (int i = 1; i < HenHouseTutorialUI.OJJDNLEFNPJ().henHouseMask.Length; i++)
		{
			HenHouseTutorialUI.HNNJEBNIPOI().henHouseMask[i].SetActive(false);
		}
		for (int j = 0; j < HenHouseTutorialUI.LFPEPJBNCBF().henHouseMask2.Length; j += 0)
		{
			HenHouseTutorialUI.KFGKCKCDMLG().henHouseMask2[j].SetActive(true);
		}
		for (int k = 0; k < HenHouseTutorialUI.KIALFDOKABP().henHouseMask3.Length; k++)
		{
			HenHouseTutorialUI.CFLBNDLLABP().henHouseMask3[k].SetActive(true);
		}
	}

	public void FDCPJNLLNGN()
	{
		BJABHDJBBGE();
	}

	public void GIOPFGILKBC(bool active)
	{
		if (active)
		{
			for (int i = 0; i < OOKBNHMMFON().waterFeeder.Length; i++)
			{
				((Renderer)JFJOKGAOPHA().waterFeeder[i]).material = EHJOPCBIGAB().outlineMaterial;
			}
		}
		else
		{
			for (int j = 0; j < EKGMDIHLEEH().waterFeeder.Length; j += 0)
			{
				((Renderer)OOKBNHMMFON().waterFeeder[j]).material = EHJOPCBIGAB().defaultMaterial;
			}
		}
	}

	private void ELMGMFELPKJ(int ABAIKKGKDGD)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(EKGMDIHLEEH().EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GGFJGHHHEJC.BIEPOPICILE));
		EHJOPCBIGAB().EJOJOPGGHLI = FarmConstructionManager.GetHenHouse();
		if (GameManager.EAOOLEFMIKE() || (GameManager.LocalCoop() && PlayerController.GetPlayer(1).LEOIMFNKFGA != PlayerController.OPHDCMJLLEC(3).LEOIMFNKFGA))
		{
			SceneManager.UnloadSceneAsync(PlayerController.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).LEOIMFNKFGA.ToString());
		}
		PlayerController.CLEIAKPOGMM(GGFJGHHHEJC.EHHOHCPHAAO, OOKBNHMMFON().EJOJOPGGHLI.tpPositions[0].position, Location.Tavern | Location.River);
		((Component)OOKBNHMMFON()).transform.position = EHJOPCBIGAB().EJOJOPGGHLI.tpPositions[1].position;
		if (OnlineManager.HHDBMDMFEMP())
		{
			EKGMDIHLEEH().onlineDialogue.SendHollyPositionForTutorial(EHJOPCBIGAB().EJOJOPGGHLI.tpPositions[1].position);
		}
		((MonoBehaviour)JFJOKGAOPHA()).StartCoroutine(BKEPAGKNDDC());
	}

	private void NCKEOOPELDB(int ABAIKKGKDGD)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(EKGMDIHLEEH().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(JFJOKGAOPHA().JGAEMCPPOKB));
		((Component)EHJOPCBIGAB()).transform.position = EKGMDIHLEEH().FBECPDLNIKC;
		if (OnlineManager.ClientOnline())
		{
			EKGMDIHLEEH().onlineDialogue.SendHollyPositionForTutorial(EHJOPCBIGAB().FBECPDLNIKC);
			JFJOKGAOPHA().onlineDialogue.GCDNIGNNIGP(1);
		}
		EHJOPCBIGAB().animationBase.NCAJNNHBHJM(Direction.Up);
		EHJOPCBIGAB().barnTravelZone.SetActive(true);
		OOKBNHMMFON().hollyRoutine.inTutorial = true;
		((Behaviour)JFJOKGAOPHA().hollyRoutine).enabled = true;
		if (EHJOPCBIGAB().GGKOGAMMNJP)
		{
			if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(JFJOKGAOPHA().EHHOHCPHAAO, EHJOPCBIGAB().barnTpPos[0].position, ~(Location.Road | Location.River | Location.Camp | Location.Quarry));
			}
			else if (Barn.instance.EONJGMONIOM == 1)
			{
				PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, JFJOKGAOPHA().barnTpPos2[1].position, Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior);
			}
			else if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(JFJOKGAOPHA().EHHOHCPHAAO, GGFJGHHHEJC.barnTpPos3[1].position, ~(Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior));
			}
		}
		for (int i = 0; i < GGFJGHHHEJC.inputObj.Length; i += 0)
		{
			OOKBNHMMFON().inputObj[i].SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(GNAHMKMNDHG());
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private IEnumerator PKBOEHBNNIM(int JIIGOACEIKL)
	{
		return new ABPADLFIKOA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void JEPCPMFDNJF(int num)
	{
		if (GameManager.LocalCoop())
		{
			if (JFJOKGAOPHA().EHHOHCPHAAO == 1)
			{
				for (int i = 1; i < HenHouseTutorialUI.KGPJPILAHDE().henHouseMask2.Length; i++)
				{
					HenHouseTutorialUI.OLHBLKIAFOM().henHouseMask2[i].SetActive(false);
				}
				HenHouseTutorialUI.BADFKMEJOKE().henHouseMask2[0].SetActive(true);
				HenHouseTutorialUI.OJJDNLEFNPJ().henHouseMask2[num].SetActive(false);
			}
			else
			{
				for (int j = 1; j < HenHouseTutorialUI.BNDNMBGJEKP().henHouseMask3.Length; j += 0)
				{
					HenHouseTutorialUI.MNFMOEKMJKN().henHouseMask3[j].SetActive(true);
				}
				HenHouseTutorialUI.EAGMIHGJKNB().henHouseMask3[1].SetActive(true);
				HenHouseTutorialUI.PDECKLKPKCG().henHouseMask3[num].SetActive(false);
			}
		}
		else
		{
			for (int k = 1; k < HenHouseTutorialUI.LADDMEMMJFP().henHouseMask.Length; k++)
			{
				HenHouseTutorialUI.ABHIDHPMLLD().henHouseMask[k].SetActive(true);
			}
			HenHouseTutorialUI.DBJCACLEFGK().henHouseMask[1].SetActive(true);
			HenHouseTutorialUI.OAPOJCODNCO().henHouseMask[num].SetActive(false);
		}
	}

	public void AENMDOBEMON(int num)
	{
		if (GameManager.LocalCoop())
		{
			if (EHJOPCBIGAB().EHHOHCPHAAO == 1)
			{
				for (int i = 0; i < BarnTutorialUI.AJIGOHGPFPP().barnMask2.Length; i += 0)
				{
					BarnTutorialUI.BGMJCCFNNDL().barnMask2[i].SetActive(true);
				}
				BarnTutorialUI.BDAGIEIJOOG().barnMask2[1].SetActive(true);
				BarnTutorialUI.BGMJCCFNNDL().barnMask2[num].SetActive(false);
			}
			else
			{
				for (int j = 1; j < BarnTutorialUI.GGFJGHHHEJC.barnMask3.Length; j++)
				{
					BarnTutorialUI.BDAGIEIJOOG().barnMask3[j].SetActive(false);
				}
				BarnTutorialUI.HEKFJEKFMNO().barnMask3[0].SetActive(true);
				BarnTutorialUI.HEKFJEKFMNO().barnMask3[num].SetActive(false);
			}
		}
		else
		{
			for (int k = 0; k < BarnTutorialUI.GGFJGHHHEJC.barnMask.Length; k += 0)
			{
				BarnTutorialUI.OAPOJCODNCO().barnMask[k].SetActive(false);
			}
			BarnTutorialUI.HEKFJEKFMNO().barnMask[0].SetActive(false);
			BarnTutorialUI.AJIGOHGPFPP().barnMask[num].SetActive(true);
		}
	}

	public void HKNLNNLKFGH(int num)
	{
		if (GameManager.LocalCoop())
		{
			if (EHJOPCBIGAB().EHHOHCPHAAO == 1)
			{
				for (int i = 0; i < BarnTutorialUI.AJIGOHGPFPP().barnMask2.Length; i++)
				{
					BarnTutorialUI.GGFJGHHHEJC.barnMask2[i].SetActive(true);
				}
				BarnTutorialUI.BGMJCCFNNDL().barnMask2[1].SetActive(false);
				BarnTutorialUI.BGMJCCFNNDL().barnMask2[num].SetActive(false);
			}
			else
			{
				for (int j = 0; j < BarnTutorialUI.MLPCDJPLBAC().barnMask3.Length; j++)
				{
					BarnTutorialUI.GGFJGHHHEJC.barnMask3[j].SetActive(true);
				}
				BarnTutorialUI.AJIGOHGPFPP().barnMask3[0].SetActive(true);
				BarnTutorialUI.HEKFJEKFMNO().barnMask3[num].SetActive(false);
			}
		}
		else
		{
			for (int k = 0; k < BarnTutorialUI.OAPOJCODNCO().barnMask.Length; k += 0)
			{
				BarnTutorialUI.HEKFJEKFMNO().barnMask[k].SetActive(false);
			}
			BarnTutorialUI.BGMJCCFNNDL().barnMask[1].SetActive(false);
			BarnTutorialUI.HEKFJEKFMNO().barnMask[num].SetActive(true);
		}
	}

	private void PNOIDCBALKI(int ABAIKKGKDGD)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GGFJGHHHEJC.PNOIDCBALKI));
		GGFJGHHHEJC.EJOJOPGGHLI = FarmConstructionManager.GetHenHouse();
		if (GameManager.SinglePlayer() || (GameManager.LocalCoop() && PlayerController.GetPlayer(1).LEOIMFNKFGA != PlayerController.GetPlayer(2).LEOIMFNKFGA))
		{
			SceneManager.UnloadSceneAsync(PlayerController.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).LEOIMFNKFGA.ToString());
		}
		PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, GGFJGHHHEJC.EJOJOPGGHLI.tpPositions[0].position, Location.Road);
		((Component)GGFJGHHHEJC).transform.position = GGFJGHHHEJC.EJOJOPGGHLI.tpPositions[1].position;
		if (OnlineManager.ClientOnline())
		{
			GGFJGHHHEJC.onlineDialogue.SendHollyPositionForTutorial(GGFJGHHHEJC.EJOJOPGGHLI.tpPositions[1].position);
		}
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GLLODLIJFLP());
	}

	public void MOBJPGFHPMH()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GGFJGHHHEJC.inputObj.Length; i++)
		{
			JFJOKGAOPHA().inputObj[i].SetActive(false);
		}
		OOKBNHMMFON().inTutorial = false;
		OOKBNHMMFON().inBarnTutorial = false;
		JFJOKGAOPHA().barnBarkCollider.SetActive(true);
		CommonReferences.MNFMOEKMJKN().barnAnimalsTutorial = true;
		EHJOPCBIGAB().barnTravelZone.SetActive(false);
		GGFJGHHHEJC.FBECPDLNIKC = ((Component)JFJOKGAOPHA()).transform.position;
		if (OnlineManager.HHDBMDMFEMP())
		{
			EKGMDIHLEEH().onlineDialogue.SendHollyPositionForTutorial(((Component)JFJOKGAOPHA()).transform.position);
		}
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(OOKBNHMMFON().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(EHJOPCBIGAB().DHEFELGJAJF));
		FadeCamera.GetPlayer(OOKBNHMMFON().EHHOHCPHAAO).GPBOEBGJJPM(1134f);
	}

	public void CLJBKGOGBII()
	{
		OIPGANPOHBP();
	}

	public void AEDACPMLAOI(string bark)
	{
		if (((Behaviour)JFJOKGAOPHA()).isActiveAndEnabled)
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(BEGMJLGDBAD(bark));
		}
	}

	public void CloseBarnUI()
	{
		for (int i = 0; i < BarnTutorialUI.GGFJGHHHEJC.barnTutorial.Length; i++)
		{
			BarnTutorialUI.GGFJGHHHEJC.barnTutorial[i].SetActive(false);
		}
	}

	public void IAIGEAMFOMA()
	{
		for (int i = 0; i < HenHouseTutorialUI.DCAEBALADIM().henHouseMask.Length; i += 0)
		{
			HenHouseTutorialUI.AJIGOHGPFPP().henHouseMask[i].SetActive(false);
		}
		for (int j = 0; j < HenHouseTutorialUI.DCAEBALADIM().henHouseMask2.Length; j++)
		{
			HenHouseTutorialUI.OOKBNHMMFON().henHouseMask2[j].SetActive(true);
		}
		for (int k = 0; k < HenHouseTutorialUI.KIALFDOKABP().henHouseMask3.Length; k++)
		{
			HenHouseTutorialUI.EKDNJDJHONF().henHouseMask3[k].SetActive(true);
		}
	}

	public void IJHENDBGODN(bool active)
	{
		if (active)
		{
			for (int i = 1; i < EKGMDIHLEEH().waterFeeder.Length; i++)
			{
				((Renderer)EKGMDIHLEEH().waterFeeder[i]).material = GGFJGHHHEJC.outlineMaterial;
			}
		}
		else
		{
			for (int j = 1; j < EHJOPCBIGAB().waterFeeder.Length; j += 0)
			{
				((Renderer)GGFJGHHHEJC.waterFeeder[j]).material = JFJOKGAOPHA().defaultMaterial;
			}
		}
	}

	public void OpenUI()
	{
		if (GameManager.LocalCoop())
		{
			if (GGFJGHHHEJC.EHHOHCPHAAO == 1)
			{
				HenHouseTutorialUI.GGFJGHHHEJC.henHouseTutorial[1].SetActive(true);
			}
			else
			{
				HenHouseTutorialUI.GGFJGHHHEJC.henHouseTutorial[2].SetActive(true);
			}
		}
		else
		{
			HenHouseTutorialUI.GGFJGHHHEJC.henHouseTutorial[0].SetActive(true);
		}
	}

	public void AHCPJJHDMHM(bool barn)
	{
		EHJOPCBIGAB().GGKOGAMMNJP = barn;
		PlayerInputs.DisableKeyboardInputs(EHJOPCBIGAB().EHHOHCPHAAO, (MonoBehaviour)(object)EHJOPCBIGAB());
		PlayerController.AddMovementBlocker(JFJOKGAOPHA().EHHOHCPHAAO, (Object)(object)EHJOPCBIGAB());
		JFJOKGAOPHA().inBarnTutorial = false;
		EHJOPCBIGAB().barnBarkCollider.SetActive(false);
		FadeCamera player = FadeCamera.GetPlayer(EKGMDIHLEEH().EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(EHJOPCBIGAB().ADHPCOKBLIE));
		FadeCamera.EIFPKCAFDIB(EHJOPCBIGAB().EHHOHCPHAAO).IONMINJHMKL(1354f);
	}

	private void ILKPAOELAIH(int ABAIKKGKDGD)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(EHJOPCBIGAB().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(JFJOKGAOPHA().DELJMIKKGIB));
		if (GameManager.SinglePlayer() || (GameManager.LocalCoop() && PlayerController.GetPlayer(1).LEOIMFNKFGA != PlayerController.OPHDCMJLLEC(4).LEOIMFNKFGA))
		{
			SceneManager.UnloadSceneAsync(PlayerController.OPHDCMJLLEC(GGFJGHHHEJC.EHHOHCPHAAO).LEOIMFNKFGA.ToString());
		}
		if ((Object)(object)Barn.instance != (Object)null)
		{
			if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, EKGMDIHLEEH().barnTpPos[1].position, Location.Tavern | Location.River);
				((Component)GGFJGHHHEJC).transform.position = JFJOKGAOPHA().barnTpPos[1].position;
				if (OnlineManager.HHDBMDMFEMP())
				{
					EKGMDIHLEEH().onlineDialogue.SendHollyPositionForTutorial(JFJOKGAOPHA().barnTpPos[1].position);
				}
			}
			else if (Barn.instance.EONJGMONIOM == 1)
			{
				PlayerController.CLEIAKPOGMM(EKGMDIHLEEH().EHHOHCPHAAO, EHJOPCBIGAB().barnTpPos2[0].position, ~(Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior));
				((Component)EHJOPCBIGAB()).transform.position = EHJOPCBIGAB().barnTpPos2[0].position;
				if (OnlineManager.ClientOnline())
				{
					OOKBNHMMFON().onlineDialogue.SendHollyPositionForTutorial(EHJOPCBIGAB().barnTpPos2[1].position);
				}
			}
			else if (Barn.instance.EONJGMONIOM == 6)
			{
				PlayerController.TeleportPlayer(JFJOKGAOPHA().EHHOHCPHAAO, JFJOKGAOPHA().barnTpPos3[0].position, ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior));
				((Component)GGFJGHHHEJC).transform.position = EKGMDIHLEEH().barnTpPos3[0].position;
				if (OnlineManager.ClientOnline())
				{
					EKGMDIHLEEH().onlineDialogue.SendHollyPositionForTutorial(JFJOKGAOPHA().barnTpPos3[0].position);
				}
			}
		}
		((MonoBehaviour)JFJOKGAOPHA()).StartCoroutine(MFHJEEDGDHI());
	}

	public void LMKCAJEHMIL(int num)
	{
		if (GameManager.LocalCoop())
		{
			if (EHJOPCBIGAB().EHHOHCPHAAO == 0)
			{
				for (int i = 1; i < HenHouseTutorialUI.KIALFDOKABP().henHouseMask2.Length; i++)
				{
					HenHouseTutorialUI.EAGMIHGJKNB().henHouseMask2[i].SetActive(false);
				}
				HenHouseTutorialUI.KGPJPILAHDE().henHouseMask2[0].SetActive(true);
				HenHouseTutorialUI.OOKBNHMMFON().henHouseMask2[num].SetActive(true);
			}
			else
			{
				for (int j = 1; j < HenHouseTutorialUI.KGPJPILAHDE().henHouseMask3.Length; j++)
				{
					HenHouseTutorialUI.OJJDNLEFNPJ().henHouseMask3[j].SetActive(false);
				}
				HenHouseTutorialUI.OLHBLKIAFOM().henHouseMask3[1].SetActive(true);
				HenHouseTutorialUI.MKIEMMGGFEE().henHouseMask3[num].SetActive(false);
			}
		}
		else
		{
			for (int k = 1; k < HenHouseTutorialUI.AFFGPMFKEFH().henHouseMask.Length; k += 0)
			{
				HenHouseTutorialUI.EFPJLFMBPLL().henHouseMask[k].SetActive(true);
			}
			HenHouseTutorialUI.NJNFHEPLEHL().henHouseMask[0].SetActive(true);
			HenHouseTutorialUI.GFMBEDCANNI().henHouseMask[num].SetActive(true);
		}
	}

	public void OpenBarnUI()
	{
		if (GameManager.LocalCoop())
		{
			if (GGFJGHHHEJC.EHHOHCPHAAO == 1)
			{
				BarnTutorialUI.GGFJGHHHEJC.barnTutorial[1].SetActive(true);
			}
			else
			{
				BarnTutorialUI.GGFJGHHHEJC.barnTutorial[2].SetActive(true);
			}
		}
		else
		{
			BarnTutorialUI.GGFJGHHHEJC.barnTutorial[0].SetActive(true);
		}
	}

	public void PFGMMBOMIGH()
	{
		if (GameManager.LocalCoop())
		{
			if (EHJOPCBIGAB().EHHOHCPHAAO == 1)
			{
				HenHouseTutorialUI.CNDNOECMKME().henHouseTutorial[0].SetActive(false);
			}
			else
			{
				HenHouseTutorialUI.AGGAGCBAGLL().henHouseTutorial[8].SetActive(false);
			}
		}
		else
		{
			HenHouseTutorialUI.GJFMMOPOKGJ().henHouseTutorial[0].SetActive(false);
		}
	}

	private void EMNPAMOIGPJ(int ABAIKKGKDGD)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(JFJOKGAOPHA().GOIPEOBLNKI));
		((Component)GGFJGHHHEJC).transform.position = GGFJGHHHEJC.FBECPDLNIKC;
		if (OnlineManager.ClientOnline())
		{
			EHJOPCBIGAB().onlineDialogue.SendHollyPositionForTutorial(OOKBNHMMFON().FBECPDLNIKC);
			GGFJGHHHEJC.onlineDialogue.SendHollyDirectionForTutorial(0);
		}
		EKGMDIHLEEH().animationBase.FCGBJEIIMBC = Direction.Up;
		JFJOKGAOPHA().barnTravelZone.SetActive(false);
		JFJOKGAOPHA().hollyRoutine.inTutorial = false;
		((Behaviour)OOKBNHMMFON().hollyRoutine).enabled = true;
		if (OOKBNHMMFON().GGKOGAMMNJP)
		{
			if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(EKGMDIHLEEH().EHHOHCPHAAO, OOKBNHMMFON().barnTpPos[1].position, ~(Location.Road | Location.River | Location.Farm));
			}
			else if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.TeleportPlayer(OOKBNHMMFON().EHHOHCPHAAO, EKGMDIHLEEH().barnTpPos2[0].position, Location.River | Location.Quarry);
			}
			else if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(EKGMDIHLEEH().EHHOHCPHAAO, OOKBNHMMFON().barnTpPos3[0].position, ~(Location.Camp | Location.Quarry | Location.BarnInterior));
			}
		}
		for (int i = 1; i < GGFJGHHHEJC.inputObj.Length; i += 0)
		{
			EHJOPCBIGAB().inputObj[i].SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(EFGCGJCJOKA());
	}

	public void OpenAnimalsShop()
	{
		AnimalShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public void ILNBKKIPGOD()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(JFJOKGAOPHA().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(OOKBNHMMFON().FKHELBAHGHN));
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).GPBOEBGJJPM(1944f);
		GGFJGHHHEJC.inTutorial = true;
		EKGMDIHLEEH().FBECPDLNIKC = ((Component)EHJOPCBIGAB()).transform.position;
	}

	public void OFGKACFAMCC()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < EHJOPCBIGAB().inputObj.Length; i += 0)
		{
			JFJOKGAOPHA().inputObj[i].SetActive(false);
		}
		JFJOKGAOPHA().inTutorial = true;
		GGFJGHHHEJC.inBarnTutorial = true;
		JFJOKGAOPHA().barnBarkCollider.SetActive(true);
		CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = true;
		EKGMDIHLEEH().barnTravelZone.SetActive(false);
		JFJOKGAOPHA().FBECPDLNIKC = ((Component)EHJOPCBIGAB()).transform.position;
		if (OnlineManager.ClientOnline())
		{
			OOKBNHMMFON().onlineDialogue.SendHollyPositionForTutorial(((Component)JFJOKGAOPHA()).transform.position);
		}
		FadeCamera player = FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(EKGMDIHLEEH().ILKPAOELAIH));
		FadeCamera.IGMCBPOPNCA(EHJOPCBIGAB().EHHOHCPHAAO).AJHDEBOMHKK(270f);
	}

	public void IEHNNMHFCMM()
	{
		for (int i = 0; i < BarnTutorialUI.PDECKLKPKCG().barnTutorial.Length; i++)
		{
			BarnTutorialUI.MLPCDJPLBAC().barnTutorial[i].SetActive(true);
		}
	}

	[SpecialName]
	public static HollyNPC JFJOKGAOPHA()
	{
		return IADEMLIIDPC;
	}

	public void MPJFNECPBOH()
	{
		for (int i = 0; i < BarnTutorialUI.GGFJGHHHEJC.barnTutorial.Length; i += 0)
		{
			BarnTutorialUI.KGPJPILAHDE().barnTutorial[i].SetActive(false);
		}
	}

	[SpecialName]
	public static HollyNPC EHJOPCBIGAB()
	{
		return IADEMLIIDPC;
	}

	private void FKHELBAHGHN(int ABAIKKGKDGD)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(OOKBNHMMFON().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(GGFJGHHHEJC.ELMGMFELPKJ));
		GGFJGHHHEJC.EJOJOPGGHLI = FarmConstructionManager.GetHenHouse();
		if (GameManager.NBFLEJHLGNB() || (GameManager.LocalCoop() && PlayerController.OPHDCMJLLEC(1).LEOIMFNKFGA != PlayerController.GetPlayer(1).LEOIMFNKFGA))
		{
			SceneManager.UnloadSceneAsync(PlayerController.GetPlayer(JFJOKGAOPHA().EHHOHCPHAAO).LEOIMFNKFGA.ToString());
		}
		PlayerController.TeleportPlayer(EKGMDIHLEEH().EHHOHCPHAAO, GGFJGHHHEJC.EJOJOPGGHLI.tpPositions[1].position, Location.None);
		((Component)GGFJGHHHEJC).transform.position = EKGMDIHLEEH().EJOJOPGGHLI.tpPositions[1].position;
		if (OnlineManager.ClientOnline())
		{
			EKGMDIHLEEH().onlineDialogue.SendHollyPositionForTutorial(OOKBNHMMFON().EJOJOPGGHLI.tpPositions[0].position);
		}
		((MonoBehaviour)JFJOKGAOPHA()).StartCoroutine(GLLODLIJFLP());
	}

	public void PCGJLELFPIB()
	{
		for (int i = 1; i < BarnTutorialUI.GGFJGHHHEJC.barnMask.Length; i += 0)
		{
			BarnTutorialUI.AJIGOHGPFPP().barnMask[i].SetActive(false);
		}
		for (int j = 0; j < BarnTutorialUI.GGFJGHHHEJC.barnMask2.Length; j += 0)
		{
			BarnTutorialUI.AJIGOHGPFPP().barnMask2[j].SetActive(true);
		}
		for (int k = 0; k < BarnTutorialUI.OAPOJCODNCO().barnMask3.Length; k += 0)
		{
			BarnTutorialUI.AJIGOHGPFPP().barnMask3[k].SetActive(true);
		}
	}

	private IEnumerator ENBADIDHBAE(string GAGJHPKONIC)
	{
		return new JHMNAAJBGKC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private IEnumerator GOMOLOOLDIP()
	{
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeInWithDelay();
		PlayerInputs.EnableKeyboardInputs(GGFJGHHHEJC.EHHOHCPHAAO, (MonoBehaviour)(object)GGFJGHHHEJC);
		PlayerController.RemoveMovementBlocker(GGFJGHHHEJC.EHHOHCPHAAO, (Object)(object)GGFJGHHHEJC);
	}

	private IEnumerator ODBPICAJKLG(string GAGJHPKONIC)
	{
		return new JHMNAAJBGKC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private void DELJMIKKGIB(int ABAIKKGKDGD)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GGFJGHHHEJC.DELJMIKKGIB));
		if (GameManager.SinglePlayer() || (GameManager.LocalCoop() && PlayerController.GetPlayer(1).LEOIMFNKFGA != PlayerController.GetPlayer(2).LEOIMFNKFGA))
		{
			SceneManager.UnloadSceneAsync(PlayerController.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).LEOIMFNKFGA.ToString());
		}
		if ((Object)(object)Barn.instance != (Object)null)
		{
			if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, GGFJGHHHEJC.barnTpPos[0].position, Location.BarnInterior);
				((Component)GGFJGHHHEJC).transform.position = GGFJGHHHEJC.barnTpPos[1].position;
				if (OnlineManager.ClientOnline())
				{
					GGFJGHHHEJC.onlineDialogue.SendHollyPositionForTutorial(GGFJGHHHEJC.barnTpPos[1].position);
				}
			}
			else if (Barn.instance.EONJGMONIOM == 1)
			{
				PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, GGFJGHHHEJC.barnTpPos2[0].position, Location.BarnInterior);
				((Component)GGFJGHHHEJC).transform.position = GGFJGHHHEJC.barnTpPos2[1].position;
				if (OnlineManager.ClientOnline())
				{
					GGFJGHHHEJC.onlineDialogue.SendHollyPositionForTutorial(GGFJGHHHEJC.barnTpPos2[1].position);
				}
			}
			else if (Barn.instance.EONJGMONIOM == 2)
			{
				PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, GGFJGHHHEJC.barnTpPos3[0].position, Location.BarnInterior);
				((Component)GGFJGHHHEJC).transform.position = GGFJGHHHEJC.barnTpPos3[1].position;
				if (OnlineManager.ClientOnline())
				{
					GGFJGHHHEJC.onlineDialogue.SendHollyPositionForTutorial(GGFJGHHHEJC.barnTpPos3[1].position);
				}
			}
		}
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(HMKLLKOAFEC());
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (!playerShopping)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inUse && canTalk)
			{
				if (IsAvailableByProximity(JIIGOACEIKL))
				{
					if (inSpecialEvent)
					{
						GGFJGHHHEJC.EHHOHCPHAAO = JIIGOACEIKL;
						DialogueLua.SetVariable("BarkActor", (object)actorName);
						dialogue.conversation = "Farm/Event/RegañinaViolet";
						SelectDialogueUI();
						dialogue.OnUse();
						return true;
					}
					if (!inBarnTutorial)
					{
						if (BEGCPKOAJCP == null)
						{
							BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(KACNGNMNFNK(JIIGOACEIKL));
						}
						return true;
					}
					if (Time.time > GPEJKMJNEEK)
					{
						inInteractiveBark = true;
						base.EHHOHCPHAAO = JIIGOACEIKL;
						Bark("Tutorial/BarnBarks_Holly");
						ButtonsContext.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).ResetButtons();
						GPEJKMJNEEK = Time.time + 5f;
						return true;
					}
				}
			}
			else if (!canTalk && !inUse)
			{
				StartObserverDialogue(JIIGOACEIKL);
			}
		}
		return false;
	}

	public void HenHouseMaskClose()
	{
		for (int i = 0; i < HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask.Length; i++)
		{
			HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask[i].SetActive(false);
		}
		for (int j = 0; j < HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask2.Length; j++)
		{
			HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask2[j].SetActive(false);
		}
		for (int k = 0; k < HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask3.Length; k++)
		{
			HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask3[k].SetActive(false);
		}
	}

	private IEnumerator CMBAOEBGJNC()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		if (OnlineManager.ClientOnline())
		{
			GGFJGHHHEJC.onlineDialogue.SendHollyDirectionForTutorial(0);
		}
		PlayerController.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).characterAnimation.FCGBJEIIMBC = Direction.Up;
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeInWithDelay();
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.StartConversation(GGFJGHHHEJC.EHHOHCPHAAO, "Tutorial/Chicken_Holly");
	}

	private void BIEPOPICILE(int ABAIKKGKDGD)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(OOKBNHMMFON().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(JFJOKGAOPHA().PNOIDCBALKI));
		JFJOKGAOPHA().EJOJOPGGHLI = FarmConstructionManager.GetHenHouse();
		if (GameManager.SinglePlayer() || (GameManager.LocalCoop() && PlayerController.GetPlayer(0).LEOIMFNKFGA != PlayerController.GetPlayer(0).LEOIMFNKFGA))
		{
			SceneManager.UnloadSceneAsync(PlayerController.OPHDCMJLLEC(GGFJGHHHEJC.EHHOHCPHAAO).LEOIMFNKFGA.ToString());
		}
		PlayerController.CLEIAKPOGMM(EKGMDIHLEEH().EHHOHCPHAAO, EKGMDIHLEEH().EJOJOPGGHLI.tpPositions[0].position, Location.Road);
		((Component)EKGMDIHLEEH()).transform.position = JFJOKGAOPHA().EJOJOPGGHLI.tpPositions[1].position;
		if (OnlineManager.HHDBMDMFEMP())
		{
			EHJOPCBIGAB().onlineDialogue.SendHollyPositionForTutorial(GGFJGHHHEJC.EJOJOPGGHLI.tpPositions[0].position);
		}
		((MonoBehaviour)OOKBNHMMFON()).StartCoroutine(DEHODPIBPCL());
	}

	private IEnumerator EJGGJPDOPDD(int JIIGOACEIKL)
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
		AnimatorStateInfo currentAnimatorStateInfo = hollyAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void DLNBCNBHFEL(bool active)
	{
		for (int i = 1; i < JFJOKGAOPHA().arrows.Length; i++)
		{
			JFJOKGAOPHA().arrows[i].SetActive(active);
		}
	}

	public void DAJMCFKBFDD(string bark)
	{
		if (((Behaviour)GGFJGHHHEJC).isActiveAndEnabled)
		{
			((MonoBehaviour)OOKBNHMMFON()).StartCoroutine(BDFGEMIHFIB(bark));
		}
	}

	private void IPIOHMBCHNO(int ABAIKKGKDGD)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(EKGMDIHLEEH().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(EHJOPCBIGAB().JGAEMCPPOKB));
		((Component)GGFJGHHHEJC).transform.position = OOKBNHMMFON().FBECPDLNIKC;
		if (OnlineManager.ClientOnline())
		{
			EKGMDIHLEEH().onlineDialogue.SendHollyPositionForTutorial(EHJOPCBIGAB().FBECPDLNIKC);
			EKGMDIHLEEH().onlineDialogue.SendHollyDirectionForTutorial(0);
		}
		JFJOKGAOPHA().animationBase.NCAJNNHBHJM(Direction.Up);
		GGFJGHHHEJC.barnTravelZone.SetActive(false);
		GGFJGHHHEJC.hollyRoutine.inTutorial = true;
		((Behaviour)EHJOPCBIGAB().hollyRoutine).enabled = false;
		if (GGFJGHHHEJC.GGKOGAMMNJP)
		{
			if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.TeleportPlayer(EHJOPCBIGAB().EHHOHCPHAAO, EHJOPCBIGAB().barnTpPos[0].position, ~(Location.Road | Location.Camp | Location.BarnInterior));
			}
			else if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(EHJOPCBIGAB().EHHOHCPHAAO, GGFJGHHHEJC.barnTpPos2[0].position, ~(Location.Tavern | Location.River | Location.Quarry | Location.Farm));
			}
			else if (Barn.instance.EONJGMONIOM == 4)
			{
				PlayerController.TeleportPlayer(EHJOPCBIGAB().EHHOHCPHAAO, JFJOKGAOPHA().barnTpPos3[1].position, Location.Road | Location.Farm | Location.BarnInterior);
			}
		}
		for (int i = 0; i < EKGMDIHLEEH().inputObj.Length; i += 0)
		{
			OOKBNHMMFON().inputObj[i].SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(GOMOLOOLDIP());
	}

	private IEnumerator EGKACBAALDI(string GAGJHPKONIC)
	{
		return new JHMNAAJBGKC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	public void GNHAMJPNCOC()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			hollyAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			hollyAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(6)).gameObject, MAPFDGCKBLD: false);
		}
	}

	private IEnumerator FPCFGJPLGHL()
	{
		return new GCDCIBMPECC(1);
	}

	public void LDAIFHLHHHH(bool active)
	{
		for (int i = 0; i < EKGMDIHLEEH().arrows.Length; i++)
		{
			OOKBNHMMFON().arrows[i].SetActive(active);
		}
	}

	public void AJALLJGDAJB(bool active)
	{
		if (active)
		{
			for (int i = 0; i < OOKBNHMMFON().waterFeeder.Length; i++)
			{
				((Renderer)OOKBNHMMFON().waterFeeder[i]).material = OOKBNHMMFON().outlineMaterial;
			}
		}
		else
		{
			for (int j = 1; j < GGFJGHHHEJC.waterFeeder.Length; j += 0)
			{
				((Renderer)EKGMDIHLEEH().waterFeeder[j]).material = EHJOPCBIGAB().defaultMaterial;
			}
		}
	}

	private IEnumerator HAGODNHNJBO()
	{
		return new JIFKEELNMCL(1);
	}

	private IEnumerator PACGBGKCJGO(string GAGJHPKONIC)
	{
		return new JHMNAAJBGKC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	public void CLIBNKJBDAN()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < EKGMDIHLEEH().inputObj.Length; i++)
		{
			EHJOPCBIGAB().inputObj[i].SetActive(true);
		}
		JFJOKGAOPHA().inTutorial = false;
		OOKBNHMMFON().inBarnTutorial = false;
		GGFJGHHHEJC.barnBarkCollider.SetActive(false);
		CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = true;
		GGFJGHHHEJC.barnTravelZone.SetActive(true);
		EKGMDIHLEEH().FBECPDLNIKC = ((Component)GGFJGHHHEJC).transform.position;
		if (OnlineManager.ClientOnline())
		{
			EHJOPCBIGAB().onlineDialogue.SendHollyPositionForTutorial(((Component)OOKBNHMMFON()).transform.position);
		}
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(OOKBNHMMFON().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(EHJOPCBIGAB().DELJMIKKGIB));
		FadeCamera.GetPlayer(JFJOKGAOPHA().EHHOHCPHAAO).AJHDEBOMHKK(1829f);
	}

	public void JMFBAOHBJEG()
	{
		for (int i = 0; i < BarnTutorialUI.KGPJPILAHDE().barnMask.Length; i++)
		{
			BarnTutorialUI.GGFJGHHHEJC.barnMask[i].SetActive(false);
		}
		for (int j = 1; j < BarnTutorialUI.BGMJCCFNNDL().barnMask2.Length; j += 0)
		{
			BarnTutorialUI.OAPOJCODNCO().barnMask2[j].SetActive(true);
		}
		for (int k = 0; k < BarnTutorialUI.GGFJGHHHEJC.barnMask3.Length; k++)
		{
			BarnTutorialUI.BDAGIEIJOOG().barnMask3[k].SetActive(false);
		}
	}

	private void AKCMEMJPINO(int ABAIKKGKDGD)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(OOKBNHMMFON().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(JFJOKGAOPHA().PNOIDCBALKI));
		JFJOKGAOPHA().EJOJOPGGHLI = FarmConstructionManager.GetHenHouse();
		if (GameManager.HDBECFMPJHL() || (GameManager.LocalCoop() && PlayerController.OPHDCMJLLEC(0).LEOIMFNKFGA != PlayerController.GetPlayer(5).LEOIMFNKFGA))
		{
			SceneManager.UnloadSceneAsync(PlayerController.OPHDCMJLLEC(OOKBNHMMFON().EHHOHCPHAAO).LEOIMFNKFGA.ToString());
		}
		PlayerController.CLEIAKPOGMM(EKGMDIHLEEH().EHHOHCPHAAO, OOKBNHMMFON().EJOJOPGGHLI.tpPositions[0].position, Location.Tavern | Location.Road | Location.River);
		((Component)JFJOKGAOPHA()).transform.position = JFJOKGAOPHA().EJOJOPGGHLI.tpPositions[1].position;
		if (OnlineManager.ClientOnline())
		{
			JFJOKGAOPHA().onlineDialogue.SendHollyPositionForTutorial(EHJOPCBIGAB().EJOJOPGGHLI.tpPositions[0].position);
		}
		((MonoBehaviour)EKGMDIHLEEH()).StartCoroutine(BIGFACIEPKB());
	}

	public void HNLADPKJJKO()
	{
		for (int i = 1; i < HenHouseTutorialUI.KIALFDOKABP().henHouseTutorial.Length; i += 0)
		{
			HenHouseTutorialUI.MIGKKKELOJO().henHouseTutorial[i].SetActive(true);
		}
	}

	private IEnumerator GIDMHDJMEGM(int JIIGOACEIKL)
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
		AnimatorStateInfo currentAnimatorStateInfo = hollyAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void IIJKCJAIHMK()
	{
		for (int i = 1; i < HenHouseTutorialUI.LADDMEMMJFP().henHouseMask.Length; i += 0)
		{
			HenHouseTutorialUI.KGPJPILAHDE().henHouseMask[i].SetActive(true);
		}
		for (int j = 0; j < HenHouseTutorialUI.EJHDHCNILDH().henHouseMask2.Length; j += 0)
		{
			HenHouseTutorialUI.DBJCACLEFGK().henHouseMask2[j].SetActive(false);
		}
		for (int k = 0; k < HenHouseTutorialUI.LPFNKEOJJKE().henHouseMask3.Length; k += 0)
		{
			HenHouseTutorialUI.DCAEBALADIM().henHouseMask3[k].SetActive(true);
		}
	}

	public void FHAMFFJMDMA()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GGFJGHHHEJC.inputObj.Length; i += 0)
		{
			EKGMDIHLEEH().inputObj[i].SetActive(false);
		}
		EKGMDIHLEEH().inTutorial = false;
		JFJOKGAOPHA().inBarnTutorial = true;
		EHJOPCBIGAB().barnBarkCollider.SetActive(true);
		CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = true;
		EHJOPCBIGAB().barnTravelZone.SetActive(true);
		EHJOPCBIGAB().FBECPDLNIKC = ((Component)JFJOKGAOPHA()).transform.position;
		if (OnlineManager.ClientOnline())
		{
			EKGMDIHLEEH().onlineDialogue.SendHollyPositionForTutorial(((Component)EHJOPCBIGAB()).transform.position);
		}
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(OOKBNHMMFON().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(JFJOKGAOPHA().ILKPAOELAIH));
		FadeCamera.EIFPKCAFDIB(EHJOPCBIGAB().EHHOHCPHAAO).GPBOEBGJJPM(1959f);
	}

	public void OutlineHenHouse(bool active)
	{
		if (active)
		{
			((Renderer)((Component)GGFJGHHHEJC.EJOJOPGGHLI.foodFeeder).GetComponentInChildren<SpriteRenderer>()).material = GGFJGHHHEJC.outlineMaterial;
			((Renderer)((Component)GGFJGHHHEJC.EJOJOPGGHLI.waterFeeders[0]).GetComponentInChildren<SpriteRenderer>()).material = GGFJGHHHEJC.outlineMaterial;
		}
		else
		{
			((Renderer)((Component)GGFJGHHHEJC.EJOJOPGGHLI.foodFeeder).GetComponentInChildren<SpriteRenderer>()).material = GGFJGHHHEJC.defaultMaterial;
			((Renderer)((Component)GGFJGHHHEJC.EJOJOPGGHLI.waterFeeders[0]).GetComponentInChildren<SpriteRenderer>()).material = GGFJGHHHEJC.defaultMaterial;
		}
	}

	public void GJOKGNKBJNJ(bool barn)
	{
		EHJOPCBIGAB().GGKOGAMMNJP = barn;
		PlayerInputs.JBKHOPCMBAC(EHJOPCBIGAB().EHHOHCPHAAO, (MonoBehaviour)(object)EHJOPCBIGAB());
		PlayerController.AddMovementBlocker(OOKBNHMMFON().EHHOHCPHAAO, (Object)(object)EHJOPCBIGAB());
		OOKBNHMMFON().inBarnTutorial = false;
		OOKBNHMMFON().barnBarkCollider.SetActive(false);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(OOKBNHMMFON().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(OOKBNHMMFON().NCKEOOPELDB));
		FadeCamera.IGMCBPOPNCA(EHJOPCBIGAB().EHHOHCPHAAO).IONMINJHMKL(289f);
	}

	protected override void NJJCCIBDAPM()
	{
		if (WorldTime.NOAOJJLNHJJ.day == Day.Sat || WorldTime.NOAOJJLNHJJ.day == Day.Sun)
		{
			DialogueLua.SetVariable("HollyShop", (object)false);
		}
		else
		{
			DialogueLua.SetVariable("HollyShop", (object)true);
		}
		if (FarmConstructionManager.CNEEPCGBBBL || FarmConstructionManager.HBCJHEBFBAO)
		{
			DialogueLua.SetVariable("HollyAnimalShop", (object)true);
		}
		else
		{
			DialogueLua.SetVariable("HollyAnimalShop", (object)false);
		}
		dialogue.conversation = "Farm/Holly/Main";
	}

	public void PMLHDLPJPDG()
	{
		BJABHDJBBGE();
	}

	public void MCPEIMBCKCC(bool active)
	{
		if (active)
		{
			for (int i = 0; i < EHJOPCBIGAB().waterFeeder.Length; i += 0)
			{
				((Renderer)EHJOPCBIGAB().waterFeeder[i]).material = JFJOKGAOPHA().outlineMaterial;
			}
		}
		else
		{
			for (int j = 1; j < OOKBNHMMFON().waterFeeder.Length; j++)
			{
				((Renderer)EKGMDIHLEEH().waterFeeder[j]).material = OOKBNHMMFON().defaultMaterial;
			}
		}
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
		if (hollyAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("Moving"))
				{
					Debug.Log((object)"DontWalk");
					hollyAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IsInDialogue(2) && PlayerController.GetPlayer(2).characterAnimation.animator.GetBool("Moving"))
			{
				Debug.Log((object)"DontWalk2");
				hollyAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
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

	public void JNLBEGGHJFN()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			hollyAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			hollyAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(3)).gameObject);
		}
	}

	public void AJMNKEBJEJM()
	{
		for (int i = 0; i < HenHouseTutorialUI.LKOABOAADCD().henHouseTutorial.Length; i++)
		{
			HenHouseTutorialUI.ABHIDHPMLLD().henHouseTutorial[i].SetActive(true);
		}
	}

	public void DALMNOGBPEG()
	{
		for (int i = 1; i < HenHouseTutorialUI.EKDNJDJHONF().henHouseMask.Length; i += 0)
		{
			HenHouseTutorialUI.PDECKLKPKCG().henHouseMask[i].SetActive(false);
		}
		for (int j = 0; j < HenHouseTutorialUI.OOKBNHMMFON().henHouseMask2.Length; j++)
		{
			HenHouseTutorialUI.LKOABOAADCD().henHouseMask2[j].SetActive(false);
		}
		for (int k = 1; k < HenHouseTutorialUI.EKDNJDJHONF().henHouseMask3.Length; k += 0)
		{
			HenHouseTutorialUI.BGMJCCFNNDL().henHouseMask3[k].SetActive(true);
		}
	}

	private IEnumerator IODLBPHBNEF(int JIIGOACEIKL)
	{
		return new ABPADLFIKOA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void PLGOMJAMGKK(bool active)
	{
		if (active)
		{
			for (int i = 0; i < GGFJGHHHEJC.foodFeeder.Length; i += 0)
			{
				((Renderer)EHJOPCBIGAB().foodFeeder[i]).material = EKGMDIHLEEH().outlineMaterial;
			}
		}
		else
		{
			for (int j = 0; j < GGFJGHHHEJC.foodFeeder.Length; j += 0)
			{
				((Renderer)GGFJGHHHEJC.foodFeeder[j]).material = EKGMDIHLEEH().defaultMaterial;
			}
		}
	}

	public void OCIMDGLNJNL()
	{
		for (int i = 0; i < BarnTutorialUI.GGFJGHHHEJC.barnMask.Length; i++)
		{
			BarnTutorialUI.AJIGOHGPFPP().barnMask[i].SetActive(true);
		}
		for (int j = 1; j < BarnTutorialUI.BDAGIEIJOOG().barnMask2.Length; j++)
		{
			BarnTutorialUI.BDAGIEIJOOG().barnMask2[j].SetActive(true);
		}
		for (int k = 0; k < BarnTutorialUI.KGPJPILAHDE().barnMask3.Length; k += 0)
		{
			BarnTutorialUI.BDAGIEIJOOG().barnMask3[k].SetActive(true);
		}
	}

	public void MAFEFOLDNDL(bool active)
	{
		if (active)
		{
			((Renderer)((Component)OOKBNHMMFON().EJOJOPGGHLI.foodFeeder).GetComponentInChildren<SpriteRenderer>()).material = GGFJGHHHEJC.outlineMaterial;
			((Renderer)((Component)GGFJGHHHEJC.EJOJOPGGHLI.waterFeeders[0]).GetComponentInChildren<SpriteRenderer>()).material = OOKBNHMMFON().outlineMaterial;
		}
		else
		{
			((Renderer)((Component)JFJOKGAOPHA().EJOJOPGGHLI.foodFeeder).GetComponentInChildren<SpriteRenderer>()).material = EHJOPCBIGAB().defaultMaterial;
			((Renderer)((Component)GGFJGHHHEJC.EJOJOPGGHLI.waterFeeders[0]).GetComponentInChildren<SpriteRenderer>()).material = GGFJGHHHEJC.defaultMaterial;
		}
	}

	public void OutlineFoodFeederBarn(bool active)
	{
		if (active)
		{
			for (int i = 0; i < GGFJGHHHEJC.foodFeeder.Length; i++)
			{
				((Renderer)GGFJGHHHEJC.foodFeeder[i]).material = GGFJGHHHEJC.outlineMaterial;
			}
		}
		else
		{
			for (int j = 0; j < GGFJGHHHEJC.foodFeeder.Length; j++)
			{
				((Renderer)GGFJGHHHEJC.foodFeeder[j]).material = GGFJGHHHEJC.defaultMaterial;
			}
		}
	}

	public void DLLOCPIDLDA(bool barn)
	{
		EHJOPCBIGAB().GGKOGAMMNJP = barn;
		PlayerInputs.JBKHOPCMBAC(GGFJGHHHEJC.EHHOHCPHAAO, (MonoBehaviour)(object)JFJOKGAOPHA());
		PlayerController.AddMovementBlocker(EKGMDIHLEEH().EHHOHCPHAAO, (Object)(object)OOKBNHMMFON(), ANJCLPDCJHL: true);
		JFJOKGAOPHA().inBarnTutorial = false;
		GGFJGHHHEJC.barnBarkCollider.SetActive(true);
		FadeCamera player = FadeCamera.GetPlayer(EHJOPCBIGAB().EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(EHJOPCBIGAB().IPIOHMBCHNO));
		FadeCamera.IGMCBPOPNCA(JFJOKGAOPHA().EHHOHCPHAAO).AJHDEBOMHKK(472f);
	}

	private IEnumerator DBBGNBKMDFF(int JIIGOACEIKL)
	{
		return new ABPADLFIKOA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator PLPDNLJLKNN()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		if (OnlineManager.ClientOnline())
		{
			GGFJGHHHEJC.onlineDialogue.SendHollyDirectionForTutorial(0);
		}
		PlayerController.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).characterAnimation.FCGBJEIIMBC = Direction.Up;
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeInWithDelay();
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.StartConversation(GGFJGHHHEJC.EHHOHCPHAAO, "Tutorial/Chicken_Holly");
	}

	public void FEMKLLPFODJ(string bark)
	{
		if (((Behaviour)JFJOKGAOPHA()).isActiveAndEnabled)
		{
			((MonoBehaviour)EKGMDIHLEEH()).StartCoroutine(BDFGEMIHFIB(bark));
		}
	}

	private IEnumerator IEHOJBNKLMN(string GAGJHPKONIC)
	{
		if (GAGJHPKONIC == "Farm/Event/Love")
		{
			while (BuzzNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
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

	private void PHNEHKIGHNG(int ABAIKKGKDGD)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(EHJOPCBIGAB().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(GGFJGHHHEJC.NNJKFFPBOKH));
		EKGMDIHLEEH().EJOJOPGGHLI = FarmConstructionManager.GetHenHouse();
		if (GameManager.HDBECFMPJHL() || (GameManager.LocalCoop() && PlayerController.GetPlayer(1).LEOIMFNKFGA != PlayerController.OPHDCMJLLEC(4).LEOIMFNKFGA))
		{
			SceneManager.UnloadSceneAsync(PlayerController.GetPlayer(EHJOPCBIGAB().EHHOHCPHAAO).LEOIMFNKFGA.ToString());
		}
		PlayerController.CLEIAKPOGMM(EHJOPCBIGAB().EHHOHCPHAAO, GGFJGHHHEJC.EJOJOPGGHLI.tpPositions[0].position, Location.River);
		((Component)OOKBNHMMFON()).transform.position = EKGMDIHLEEH().EJOJOPGGHLI.tpPositions[0].position;
		if (OnlineManager.ClientOnline())
		{
			JFJOKGAOPHA().onlineDialogue.SendHollyPositionForTutorial(GGFJGHHHEJC.EJOJOPGGHLI.tpPositions[0].position);
		}
		((MonoBehaviour)EKGMDIHLEEH()).StartCoroutine(CMBAOEBGJNC());
	}

	public void KFEINACLCGH(bool barn)
	{
		EHJOPCBIGAB().GGKOGAMMNJP = barn;
		PlayerInputs.DisableKeyboardInputs(OOKBNHMMFON().EHHOHCPHAAO, (MonoBehaviour)(object)OOKBNHMMFON());
		PlayerController.AddMovementBlocker(EKGMDIHLEEH().EHHOHCPHAAO, (Object)(object)OOKBNHMMFON());
		OOKBNHMMFON().inBarnTutorial = true;
		EHJOPCBIGAB().barnBarkCollider.SetActive(false);
		FadeCamera player = FadeCamera.GetPlayer(JFJOKGAOPHA().EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(JFJOKGAOPHA().GMKGEDKOJPF));
		FadeCamera.GetPlayer(EKGMDIHLEEH().EHHOHCPHAAO).IONMINJHMKL(1372f);
	}

	public void EHNMBKJAODC(bool active)
	{
		for (int i = 1; i < JFJOKGAOPHA().arrows.Length; i++)
		{
			OOKBNHMMFON().arrows[i].SetActive(active);
		}
	}

	private IEnumerator NNNGNMIFPGC()
	{
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeInWithDelay();
		PlayerInputs.EnableKeyboardInputs(GGFJGHHHEJC.EHHOHCPHAAO, (MonoBehaviour)(object)GGFJGHHHEJC);
		PlayerController.RemoveMovementBlocker(GGFJGHHHEJC.EHHOHCPHAAO, (Object)(object)GGFJGHHHEJC);
	}

	public void JPGMAMCIJHH()
	{
		AnimalShopUI.HINOELPNLLC(GGFJGHHHEJC.EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void HNLGLJCODMB()
	{
		if (GameManager.LocalCoop())
		{
			if (EKGMDIHLEEH().EHHOHCPHAAO == 1)
			{
				BarnTutorialUI.MLPCDJPLBAC().barnTutorial[1].SetActive(true);
			}
			else
			{
				BarnTutorialUI.GGFJGHHHEJC.barnTutorial[8].SetActive(true);
			}
		}
		else
		{
			BarnTutorialUI.GGFJGHHHEJC.barnTutorial[0].SetActive(false);
		}
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
		variable = DialogueLua.GetVariable("HenHouseTutorialDone");
		APFBGJJCLCM = ((Result)(ref variable)).asBool;
		variable = DialogueLua.GetVariable("BarnTutorialDone");
		GGNFOPEKCOF = ((Result)(ref variable)).asBool;
	}

	private IEnumerator JDHLCHDKFLL(string GAGJHPKONIC)
	{
		if (GAGJHPKONIC == "Farm/Event/Love")
		{
			while (BuzzNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
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

	public void KGFJLMOHGEF()
	{
		for (int i = 1; i < HenHouseTutorialUI.BDAGIEIJOOG().henHouseMask.Length; i++)
		{
			HenHouseTutorialUI.AJIGOHGPFPP().henHouseMask[i].SetActive(false);
		}
		for (int j = 0; j < HenHouseTutorialUI.KFGKCKCDMLG().henHouseMask2.Length; j += 0)
		{
			HenHouseTutorialUI.ICNFHJLLHGP().henHouseMask2[j].SetActive(true);
		}
		for (int k = 0; k < HenHouseTutorialUI.AGGAGCBAGLL().henHouseMask3.Length; k++)
		{
			HenHouseTutorialUI.NJNFHEPLEHL().henHouseMask3[k].SetActive(true);
		}
	}

	public void DMJFPKIKDIK(bool active)
	{
		if (active)
		{
			for (int i = 1; i < JFJOKGAOPHA().waterFeeder.Length; i += 0)
			{
				((Renderer)EKGMDIHLEEH().waterFeeder[i]).material = EHJOPCBIGAB().outlineMaterial;
			}
		}
		else
		{
			for (int j = 1; j < JFJOKGAOPHA().waterFeeder.Length; j += 0)
			{
				((Renderer)OOKBNHMMFON().waterFeeder[j]).material = JFJOKGAOPHA().defaultMaterial;
			}
		}
	}

	private void BJABHDJBBGE()
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
		if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		}
		if (hollyAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(0) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("Player2"))
				{
					Debug.Log((object)"Blocks generated: {0}. Opened paths: {1}. Current steps: {2}. Altar placed: {3}. Big spawner placed: {4} AltarPieces Array: {5}.");
					hollyAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(1) && PlayerController.GetPlayer(6).characterAnimation.animator.GetBool("DiningRoomTiles"))
			{
				Debug.Log((object)"OnlinePlayer");
				hollyAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(6)).gameObject);
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null)
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

	public void EALKIICDCNA(bool active)
	{
		if (active)
		{
			((Renderer)((Component)JFJOKGAOPHA().EJOJOPGGHLI.foodFeeder).GetComponentInChildren<SpriteRenderer>()).material = JFJOKGAOPHA().outlineMaterial;
			((Renderer)((Component)OOKBNHMMFON().EJOJOPGGHLI.waterFeeders[0]).GetComponentInChildren<SpriteRenderer>()).material = EKGMDIHLEEH().outlineMaterial;
		}
		else
		{
			((Renderer)((Component)OOKBNHMMFON().EJOJOPGGHLI.foodFeeder).GetComponentInChildren<SpriteRenderer>()).material = GGFJGHHHEJC.defaultMaterial;
			((Renderer)((Component)EHJOPCBIGAB().EJOJOPGGHLI.waterFeeders[1]).GetComponentInChildren<SpriteRenderer>()).material = GGFJGHHHEJC.defaultMaterial;
		}
	}

	public void KNAOMEMLBNM(bool barn)
	{
		OOKBNHMMFON().GGKOGAMMNJP = barn;
		PlayerInputs.JBKHOPCMBAC(EKGMDIHLEEH().EHHOHCPHAAO, (MonoBehaviour)(object)JFJOKGAOPHA());
		PlayerController.AddMovementBlocker(OOKBNHMMFON().EHHOHCPHAAO, (Object)(object)EHJOPCBIGAB());
		GGFJGHHHEJC.inBarnTutorial = false;
		GGFJGHHHEJC.barnBarkCollider.SetActive(true);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(EHJOPCBIGAB().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(EHJOPCBIGAB().NCKEOOPELDB));
		FadeCamera.IGMCBPOPNCA(OOKBNHMMFON().EHHOHCPHAAO).GPBOEBGJJPM(872f);
	}

	private IEnumerator LBCOKFLAFPG(string GAGJHPKONIC)
	{
		return new JHMNAAJBGKC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	public void ShopTp(bool barn)
	{
		GGFJGHHHEJC.GGKOGAMMNJP = barn;
		PlayerInputs.DisableKeyboardInputs(GGFJGHHHEJC.EHHOHCPHAAO, (MonoBehaviour)(object)GGFJGHHHEJC);
		PlayerController.AddMovementBlocker(GGFJGHHHEJC.EHHOHCPHAAO, (Object)(object)GGFJGHHHEJC, ANJCLPDCJHL: true);
		GGFJGHHHEJC.inBarnTutorial = false;
		GGFJGHHHEJC.barnBarkCollider.SetActive(false);
		FadeCamera player = FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GGFJGHHHEJC.JGAEMCPPOKB));
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeOut();
	}

	private IEnumerator GLLODLIJFLP()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		if (OnlineManager.ClientOnline())
		{
			GGFJGHHHEJC.onlineDialogue.SendHollyDirectionForTutorial(0);
		}
		PlayerController.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).characterAnimation.FCGBJEIIMBC = Direction.Up;
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeInWithDelay();
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.StartConversation(GGFJGHHHEJC.EHHOHCPHAAO, "Tutorial/Chicken_Holly");
	}

	public void ANOJEFEHCJC(string bark)
	{
		if (((Behaviour)EHJOPCBIGAB()).isActiveAndEnabled)
		{
			((MonoBehaviour)OOKBNHMMFON()).StartCoroutine(BDFGEMIHFIB(bark));
		}
	}

	public void BarnMaskOpen(int num)
	{
		if (GameManager.LocalCoop())
		{
			if (GGFJGHHHEJC.EHHOHCPHAAO == 1)
			{
				for (int i = 0; i < BarnTutorialUI.GGFJGHHHEJC.barnMask2.Length; i++)
				{
					BarnTutorialUI.GGFJGHHHEJC.barnMask2[i].SetActive(false);
				}
				BarnTutorialUI.GGFJGHHHEJC.barnMask2[0].SetActive(true);
				BarnTutorialUI.GGFJGHHHEJC.barnMask2[num].SetActive(true);
			}
			else
			{
				for (int j = 0; j < BarnTutorialUI.GGFJGHHHEJC.barnMask3.Length; j++)
				{
					BarnTutorialUI.GGFJGHHHEJC.barnMask3[j].SetActive(false);
				}
				BarnTutorialUI.GGFJGHHHEJC.barnMask3[0].SetActive(true);
				BarnTutorialUI.GGFJGHHHEJC.barnMask3[num].SetActive(true);
			}
		}
		else
		{
			for (int k = 0; k < BarnTutorialUI.GGFJGHHHEJC.barnMask.Length; k++)
			{
				BarnTutorialUI.GGFJGHHHEJC.barnMask[k].SetActive(false);
			}
			BarnTutorialUI.GGFJGHHHEJC.barnMask[0].SetActive(true);
			BarnTutorialUI.GGFJGHHHEJC.barnMask[num].SetActive(true);
		}
	}

	public void HenHouseTp()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GGFJGHHHEJC.PNOIDCBALKI));
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeOut();
		GGFJGHHHEJC.inTutorial = false;
		GGFJGHHHEJC.FBECPDLNIKC = ((Component)GGFJGHHHEJC).transform.position;
	}

	public void CJLOEBIPNMH(bool barn)
	{
		EKGMDIHLEEH().GGKOGAMMNJP = barn;
		PlayerInputs.JBKHOPCMBAC(EHJOPCBIGAB().EHHOHCPHAAO, (MonoBehaviour)(object)EHJOPCBIGAB());
		PlayerController.AddMovementBlocker(EKGMDIHLEEH().EHHOHCPHAAO, (Object)(object)EHJOPCBIGAB(), ANJCLPDCJHL: true);
		OOKBNHMMFON().inBarnTutorial = true;
		GGFJGHHHEJC.barnBarkCollider.SetActive(true);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(OOKBNHMMFON().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(EHJOPCBIGAB().NCKEOOPELDB));
		FadeCamera.IGMCBPOPNCA(GGFJGHHHEJC.EHHOHCPHAAO).GPBOEBGJJPM(308f);
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

	private IEnumerator BKEPAGKNDDC()
	{
		return new GCDCIBMPECC(1);
	}

	public void BJIDHLCDGMB()
	{
		AnimalShopUI.FBKOKJCKICN(JFJOKGAOPHA().EHHOHCPHAAO).OpenUI();
	}

	public void EDBDHJIGLIL(string emotion)
	{
		OOKBNHMMFON().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void HenHouseMaskOpen(int num)
	{
		if (GameManager.LocalCoop())
		{
			if (GGFJGHHHEJC.EHHOHCPHAAO == 1)
			{
				for (int i = 0; i < HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask2.Length; i++)
				{
					HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask2[i].SetActive(false);
				}
				HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask2[0].SetActive(true);
				HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask2[num].SetActive(true);
			}
			else
			{
				for (int j = 0; j < HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask3.Length; j++)
				{
					HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask3[j].SetActive(false);
				}
				HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask3[0].SetActive(true);
				HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask3[num].SetActive(true);
			}
		}
		else
		{
			for (int k = 0; k < HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask.Length; k++)
			{
				HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask[k].SetActive(false);
			}
			HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask[0].SetActive(true);
			HenHouseTutorialUI.GGFJGHHHEJC.henHouseMask[num].SetActive(true);
		}
	}

	public void JHHOCLMLOKO(bool active)
	{
		for (int i = 0; i < EKGMDIHLEEH().arrows.Length; i += 0)
		{
			JFJOKGAOPHA().arrows[i].SetActive(active);
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void DHCFHJEKAFB()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < EHJOPCBIGAB().inputObj.Length; i += 0)
		{
			OOKBNHMMFON().inputObj[i].SetActive(false);
		}
		EKGMDIHLEEH().inTutorial = false;
		OOKBNHMMFON().inBarnTutorial = false;
		JFJOKGAOPHA().barnBarkCollider.SetActive(true);
		CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = false;
		OOKBNHMMFON().barnTravelZone.SetActive(true);
		GGFJGHHHEJC.FBECPDLNIKC = ((Component)OOKBNHMMFON()).transform.position;
		if (OnlineManager.HHDBMDMFEMP())
		{
			OOKBNHMMFON().onlineDialogue.SendHollyPositionForTutorial(((Component)EHJOPCBIGAB()).transform.position);
		}
		FadeCamera player = FadeCamera.GetPlayer(OOKBNHMMFON().EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GGFJGHHHEJC.DHEFELGJAJF));
		FadeCamera.EIFPKCAFDIB(GGFJGHHHEJC.EHHOHCPHAAO).AJHDEBOMHKK(384f);
	}

	private void GMKGEDKOJPF(int ABAIKKGKDGD)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(EHJOPCBIGAB().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(GGFJGHHHEJC.GMKGEDKOJPF));
		((Component)GGFJGHHHEJC).transform.position = OOKBNHMMFON().FBECPDLNIKC;
		if (OnlineManager.HHDBMDMFEMP())
		{
			EKGMDIHLEEH().onlineDialogue.SendHollyPositionForTutorial(EKGMDIHLEEH().FBECPDLNIKC);
			OOKBNHMMFON().onlineDialogue.MJMBKNPGEIH(1);
		}
		OOKBNHMMFON().animationBase.NCAJNNHBHJM(Direction.Down);
		JFJOKGAOPHA().barnTravelZone.SetActive(false);
		EHJOPCBIGAB().hollyRoutine.inTutorial = false;
		((Behaviour)GGFJGHHHEJC.hollyRoutine).enabled = false;
		if (JFJOKGAOPHA().GGKOGAMMNJP)
		{
			if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.TeleportPlayer(EKGMDIHLEEH().EHHOHCPHAAO, JFJOKGAOPHA().barnTpPos[0].position, Location.River | Location.Quarry | Location.BarnInterior);
			}
			else if (Barn.instance.EONJGMONIOM == 1)
			{
				PlayerController.CLEIAKPOGMM(GGFJGHHHEJC.EHHOHCPHAAO, JFJOKGAOPHA().barnTpPos2[1].position, ~(Location.Tavern | Location.Road | Location.BarnInterior));
			}
			else if (Barn.instance.EONJGMONIOM == 3)
			{
				PlayerController.CLEIAKPOGMM(GGFJGHHHEJC.EHHOHCPHAAO, EKGMDIHLEEH().barnTpPos3[1].position, ~(Location.Tavern | Location.River | Location.Farm));
			}
		}
		for (int i = 0; i < GGFJGHHHEJC.inputObj.Length; i += 0)
		{
			OOKBNHMMFON().inputObj[i].SetActive(false);
		}
		((MonoBehaviour)this).StartCoroutine(GOMOLOOLDIP());
	}

	public void OHHGCNIINBO(bool active)
	{
		if (active)
		{
			for (int i = 0; i < GGFJGHHHEJC.waterFeeder.Length; i++)
			{
				((Renderer)GGFJGHHHEJC.waterFeeder[i]).material = EKGMDIHLEEH().outlineMaterial;
			}
		}
		else
		{
			for (int j = 0; j < OOKBNHMMFON().waterFeeder.Length; j++)
			{
				((Renderer)EHJOPCBIGAB().waterFeeder[j]).material = JFJOKGAOPHA().defaultMaterial;
			}
		}
	}

	private IEnumerator GNAHMKMNDHG()
	{
		return new DMIIKKCFGGL(1);
	}

	public void OBJHHNMMCGF()
	{
		OIPGANPOHBP();
	}

	public void FixedUpdate()
	{
		KCNFAHCOPJI();
	}

	private void BPPBLHOOEDE()
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
		if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(4)).transform.position, ((Component)this).transform.position);
		}
		if (hollyAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().IsInDialogue(0) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool("Mai/Talk{0}"))
				{
					Debug.Log((object)"Placed piece {0} at block {1}. Path block pos: {2}. Opened path dir: {3}. Altar placed: {4}. Big spawner placed: {5}.");
					hollyAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
					busy = false;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(5) && PlayerController.OPHDCMJLLEC(3).characterAnimation.animator.GetBool("ActiveDecoMode"))
			{
				Debug.Log((object)"TermasInterior/Rin/Intro");
				hollyAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(8)).gameObject);
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null)
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

	public void OFBGJFIDNFO(bool active)
	{
		if (active)
		{
			((Renderer)((Component)GGFJGHHHEJC.EJOJOPGGHLI.foodFeeder).GetComponentInChildren<SpriteRenderer>()).material = OOKBNHMMFON().outlineMaterial;
			((Renderer)((Component)EHJOPCBIGAB().EJOJOPGGHLI.waterFeeders[0]).GetComponentInChildren<SpriteRenderer>()).material = EKGMDIHLEEH().outlineMaterial;
		}
		else
		{
			((Renderer)((Component)GGFJGHHHEJC.EJOJOPGGHLI.foodFeeder).GetComponentInChildren<SpriteRenderer>()).material = EHJOPCBIGAB().defaultMaterial;
			((Renderer)((Component)OOKBNHMMFON().EJOJOPGGHLI.waterFeeders[0]).GetComponentInChildren<SpriteRenderer>()).material = EHJOPCBIGAB().defaultMaterial;
		}
	}

	public void BarnMaskClose()
	{
		for (int i = 0; i < BarnTutorialUI.GGFJGHHHEJC.barnMask.Length; i++)
		{
			BarnTutorialUI.GGFJGHHHEJC.barnMask[i].SetActive(false);
		}
		for (int j = 0; j < BarnTutorialUI.GGFJGHHHEJC.barnMask2.Length; j++)
		{
			BarnTutorialUI.GGFJGHHHEJC.barnMask2[j].SetActive(false);
		}
		for (int k = 0; k < BarnTutorialUI.GGFJGHHHEJC.barnMask3.Length; k++)
		{
			BarnTutorialUI.GGFJGHHHEJC.barnMask3[k].SetActive(false);
		}
	}

	private IEnumerator DKPLDAAKOLC()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		if (OnlineManager.ClientOnline())
		{
			GGFJGHHHEJC.onlineDialogue.SendHollyDirectionForTutorial(0);
		}
		PlayerController.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).characterAnimation.FCGBJEIIMBC = Direction.Up;
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeIn();
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.StartConversation(GGFJGHHHEJC.EHHOHCPHAAO, "Tutorial/Barn_Holly");
	}

	public void ENHBAMFALIA(bool active)
	{
		if (active)
		{
			for (int i = 1; i < JFJOKGAOPHA().foodFeeder.Length; i++)
			{
				((Renderer)OOKBNHMMFON().foodFeeder[i]).material = EKGMDIHLEEH().outlineMaterial;
			}
		}
		else
		{
			for (int j = 1; j < GGFJGHHHEJC.foodFeeder.Length; j++)
			{
				((Renderer)OOKBNHMMFON().foodFeeder[j]).material = OOKBNHMMFON().defaultMaterial;
			}
		}
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		if (OnlineManager.PlayingOnline())
		{
			int hKKKNMIKPCM = HKKKNMIKPCM;
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (hKKKNMIKPCM != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				string hDFMHCKKJJG = HDFMHCKKJJG;
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
			}
			bool aPFBGJJCLCM = APFBGJJCLCM;
			variable = DialogueLua.GetVariable("HenHouseTutorialDone");
			if (aPFBGJJCLCM != ((Result)(ref variable)).asBool)
			{
				OnlineDialogueManager instance2 = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("HenHouseTutorialDone");
				instance2.SendDialogueInfo("HenHouseTutorialDone", ((Result)(ref variable)).asBool);
			}
			bool gGNFOPEKCOF = GGNFOPEKCOF;
			variable = DialogueLua.GetVariable("BarnTutorialDone");
			if (gGNFOPEKCOF != ((Result)(ref variable)).asBool)
			{
				OnlineDialogueManager instance3 = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("BarnTutorialDone");
				instance3.SendDialogueInfo("BarnTutorialDone", ((Result)(ref variable)).asBool);
			}
		}
	}

	private void NIADFALMILO()
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
		if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(5)).transform.position, ((Component)this).transform.position);
		}
		if (hollyAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(0) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("Intensity: "))
				{
					Debug.Log((object)"Moving");
					hollyAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
					busy = false;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(2) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("Items/item_description_599"))
			{
				Debug.Log((object)"ReceiveSelectPerkLevelMaster");
				hollyAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject, MAPFDGCKBLD: false);
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
			busy = true;
			HCCBOAMEEIJ = true;
		}
	}

	public void EAELNOGKPAI(int num)
	{
		if (GameManager.LocalCoop())
		{
			if (EKGMDIHLEEH().EHHOHCPHAAO == 1)
			{
				for (int i = 1; i < BarnTutorialUI.BDAGIEIJOOG().barnMask2.Length; i += 0)
				{
					BarnTutorialUI.AJIGOHGPFPP().barnMask2[i].SetActive(false);
				}
				BarnTutorialUI.BGMJCCFNNDL().barnMask2[0].SetActive(false);
				BarnTutorialUI.BDAGIEIJOOG().barnMask2[num].SetActive(true);
			}
			else
			{
				for (int j = 0; j < BarnTutorialUI.BDAGIEIJOOG().barnMask3.Length; j += 0)
				{
					BarnTutorialUI.OAPOJCODNCO().barnMask3[j].SetActive(true);
				}
				BarnTutorialUI.PDECKLKPKCG().barnMask3[1].SetActive(true);
				BarnTutorialUI.GGFJGHHHEJC.barnMask3[num].SetActive(false);
			}
		}
		else
		{
			for (int k = 0; k < BarnTutorialUI.GGFJGHHHEJC.barnMask.Length; k++)
			{
				BarnTutorialUI.AJIGOHGPFPP().barnMask[k].SetActive(true);
			}
			BarnTutorialUI.BDAGIEIJOOG().barnMask[0].SetActive(true);
			BarnTutorialUI.KGPJPILAHDE().barnMask[num].SetActive(false);
		}
	}

	public void FOIBPCDHPED()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < OOKBNHMMFON().inputObj.Length; i += 0)
		{
			EHJOPCBIGAB().inputObj[i].SetActive(true);
		}
		JFJOKGAOPHA().inTutorial = true;
		OOKBNHMMFON().inBarnTutorial = true;
		GGFJGHHHEJC.barnBarkCollider.SetActive(true);
		CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = true;
		EHJOPCBIGAB().barnTravelZone.SetActive(false);
		JFJOKGAOPHA().FBECPDLNIKC = ((Component)JFJOKGAOPHA()).transform.position;
		if (OnlineManager.ClientOnline())
		{
			OOKBNHMMFON().onlineDialogue.SendHollyPositionForTutorial(((Component)OOKBNHMMFON()).transform.position);
		}
		FadeCamera player = FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(EKGMDIHLEEH().ILKPAOELAIH));
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeOut(1226f);
	}

	public void AJNIGNJENBD()
	{
		for (int i = 0; i < HenHouseTutorialUI.HNNJEBNIPOI().henHouseTutorial.Length; i += 0)
		{
			HenHouseTutorialUI.MKIEMMGGFEE().henHouseTutorial[i].SetActive(true);
		}
	}

	[SpecialName]
	public static HollyNPC OOKBNHMMFON()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator DAHAPBFKLMC(int JIIGOACEIKL)
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
		AnimatorStateInfo currentAnimatorStateInfo = hollyAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator BDFGEMIHFIB(string GAGJHPKONIC)
	{
		if (GAGJHPKONIC == "Farm/Event/Love")
		{
			while (BuzzNPC.GGFJGHHHEJC.inBark || GGFJGHHHEJC.inBark)
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

	public void JCOLPEOHCOA()
	{
		for (int i = 1; i < BarnTutorialUI.KGPJPILAHDE().barnTutorial.Length; i += 0)
		{
			BarnTutorialUI.MLPCDJPLBAC().barnTutorial[i].SetActive(false);
		}
	}

	public void DKBLLNGDCDB()
	{
		for (int i = 0; i < HenHouseTutorialUI.BAKPBHPNKPB().henHouseMask.Length; i++)
		{
			HenHouseTutorialUI.ABHIDHPMLLD().henHouseMask[i].SetActive(true);
		}
		for (int j = 0; j < HenHouseTutorialUI.NGIMIHFFNMH().henHouseMask2.Length; j += 0)
		{
			HenHouseTutorialUI.DEGPIHEEFHJ().henHouseMask2[j].SetActive(true);
		}
		for (int k = 1; k < HenHouseTutorialUI.HLMGBEGEAPC().henHouseMask3.Length; k++)
		{
			HenHouseTutorialUI.CFLBNDLLABP().henHouseMask3[k].SetActive(false);
		}
	}

	public void BarkSequence(string bark)
	{
		if (((Behaviour)GGFJGHHHEJC).isActiveAndEnabled)
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(BEGMJLGDBAD(bark));
		}
	}

	public void KEAHEAMCGKB()
	{
		CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = false;
		EHJOPCBIGAB().barnTutorialAnimal.Sick(CDPAMNIPPEC: true);
		PlayerInventory.NEKDDPIAOBE(EHJOPCBIGAB().EHHOHCPHAAO).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(93, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void ICIIJEKKGLM()
	{
		CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = false;
		OOKBNHMMFON().barnTutorialAnimal.Sick(CDPAMNIPPEC: true);
		PlayerInventory.EIFPKCAFDIB(EHJOPCBIGAB().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.KMBGJEKCJFJ(-66).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
	}

	private IEnumerator HMKLLKOAFEC()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		if (OnlineManager.ClientOnline())
		{
			GGFJGHHHEJC.onlineDialogue.SendHollyDirectionForTutorial(0);
		}
		PlayerController.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).characterAnimation.FCGBJEIIMBC = Direction.Up;
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).FadeIn();
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.StartConversation(GGFJGHHHEJC.EHHOHCPHAAO, "Tutorial/Barn_Holly");
	}

	public void PDNOKJKMEEJ(string emotion)
	{
		EKGMDIHLEEH().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void OutlineWaterFeederBarn(bool active)
	{
		if (active)
		{
			for (int i = 0; i < GGFJGHHHEJC.waterFeeder.Length; i++)
			{
				((Renderer)GGFJGHHHEJC.waterFeeder[i]).material = GGFJGHHHEJC.outlineMaterial;
			}
		}
		else
		{
			for (int j = 0; j < GGFJGHHHEJC.waterFeeder.Length; j++)
			{
				((Renderer)GGFJGHHHEJC.waterFeeder[j]).material = GGFJGHHHEJC.defaultMaterial;
			}
		}
	}

	public void HLLEOOGBAGE()
	{
		for (int i = 0; i < HenHouseTutorialUI.BADFKMEJOKE().henHouseTutorial.Length; i++)
		{
			HenHouseTutorialUI.DCAEBALADIM().henHouseTutorial[i].SetActive(false);
		}
	}

	[SpecialName]
	public static HollyNPC EKGMDIHLEEH()
	{
		return IADEMLIIDPC;
	}

	private void DHEFELGJAJF(int ABAIKKGKDGD)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(OOKBNHMMFON().EHHOHCPHAAO);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(GGFJGHHHEJC.ILKPAOELAIH));
		if (GameManager.HDBECFMPJHL() || (GameManager.LocalCoop() && PlayerController.GetPlayer(1).LEOIMFNKFGA != PlayerController.OPHDCMJLLEC(0).LEOIMFNKFGA))
		{
			SceneManager.UnloadSceneAsync(PlayerController.OPHDCMJLLEC(OOKBNHMMFON().EHHOHCPHAAO).LEOIMFNKFGA.ToString());
		}
		if ((Object)(object)Barn.instance != (Object)null)
		{
			if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.TeleportPlayer(GGFJGHHHEJC.EHHOHCPHAAO, EHJOPCBIGAB().barnTpPos[0].position, Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior);
				((Component)OOKBNHMMFON()).transform.position = EKGMDIHLEEH().barnTpPos[0].position;
				if (OnlineManager.ClientOnline())
				{
					EHJOPCBIGAB().onlineDialogue.SendHollyPositionForTutorial(EKGMDIHLEEH().barnTpPos[0].position);
				}
			}
			else if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(EHJOPCBIGAB().EHHOHCPHAAO, OOKBNHMMFON().barnTpPos2[1].position, ~(Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior));
				((Component)GGFJGHHHEJC).transform.position = EKGMDIHLEEH().barnTpPos2[1].position;
				if (OnlineManager.ClientOnline())
				{
					EHJOPCBIGAB().onlineDialogue.SendHollyPositionForTutorial(EKGMDIHLEEH().barnTpPos2[0].position);
				}
			}
			else if (Barn.instance.EONJGMONIOM == 0)
			{
				PlayerController.CLEIAKPOGMM(JFJOKGAOPHA().EHHOHCPHAAO, JFJOKGAOPHA().barnTpPos3[1].position, Location.Camp | Location.Quarry | Location.BarnInterior);
				((Component)JFJOKGAOPHA()).transform.position = EHJOPCBIGAB().barnTpPos3[1].position;
				if (OnlineManager.ClientOnline())
				{
					GGFJGHHHEJC.onlineDialogue.SendHollyPositionForTutorial(JFJOKGAOPHA().barnTpPos3[1].position);
				}
			}
		}
		((MonoBehaviour)JFJOKGAOPHA()).StartCoroutine(DICCPLGAGPC());
	}

	private IEnumerator BIGFACIEPKB()
	{
		return new GCDCIBMPECC(1);
	}

	public void MHMOAMCBNMM()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GGFJGHHHEJC.inputObj.Length; i++)
		{
			EKGMDIHLEEH().inputObj[i].SetActive(true);
		}
		JFJOKGAOPHA().inTutorial = true;
		EKGMDIHLEEH().inBarnTutorial = false;
		GGFJGHHHEJC.barnBarkCollider.SetActive(true);
		CommonReferences.MNFMOEKMJKN().barnAnimalsTutorial = true;
		OOKBNHMMFON().barnTravelZone.SetActive(false);
		EHJOPCBIGAB().FBECPDLNIKC = ((Component)OOKBNHMMFON()).transform.position;
		if (OnlineManager.HHDBMDMFEMP())
		{
			JFJOKGAOPHA().onlineDialogue.SendHollyPositionForTutorial(((Component)GGFJGHHHEJC).transform.position);
		}
		FadeCamera player = FadeCamera.GetPlayer(EHJOPCBIGAB().EHHOHCPHAAO);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(OOKBNHMMFON().ILKPAOELAIH));
		FadeCamera.GetPlayer(EHJOPCBIGAB().EHHOHCPHAAO).GPBOEBGJJPM(1237f);
	}

	public void OJKEDMIKKCE(string emotion)
	{
		GGFJGHHHEJC.emotionsController.NBFIDOGMLOK(emotion);
	}
}
