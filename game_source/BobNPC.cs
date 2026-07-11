using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BobNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class KLIFMKOGOAE : IEnumerator<object>, IEnumerator, IDisposable
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
		public KLIFMKOGOAE(int _003C_003E1__state)
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
				if (bark == "Farm/Event/VioletyBob")
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

	[HideInInspector]
	public float barkOutroTime;

	public BobAnimation bobAnim;

	[HideInInspector]
	public bool inUseBob;

	public Sprite bobPortrait;

	public Sprite blackPortrait;

	private static BobNPC IADEMLIIDPC;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "BobProgress";

	public static BobNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void GANFLECJKBE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MKIONOKDHPA(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void KIBCBNHKGDL(string bark)
	{
		((MonoBehaviour)DFJGHOHPPEL()).StartCoroutine(BEGMJLGDBAD(bark));
	}

	private void HKEEMIANLIF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	public void OnActionComplete()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GGFJGHHHEJC.dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = true;
			GGFJGHHHEJC.StartConversation(1, GGFJGHHHEJC.dialogueEvent);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
		}
		if (disable)
		{
			Debug.Log((object)"Disable Bob");
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	[SpecialName]
	public static BobNPC OPDKAPNDBJE()
	{
		return IADEMLIIDPC;
	}

	public void EIBOMLNHNLP()
	{
		ShopUI.EPKNOMLADCL(POINNCPMEIG().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(OPDKAPNDBJE().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void INHHGMPOFBF()
	{
		if (EventsManager.ALEMDEBCFDH((EventsManager.EventType)79))
		{
			Debug.Log((object)("TakesXDaysToGrow" + EventsManager.FDIHEFGPKFP((EventsManager.EventType)(-144))));
			((Behaviour)bobAnim).enabled = false;
		}
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(IPFECOIDGAE));
	}

	private void JLMKOKBPLFN()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MCFCNKLOCKL(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void HBHGDJKOJLO()
	{
		ShopUI.Get(DFJGHOHPPEL().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(BNDNMBGJEKP().EHHOHCPHAAO).OpenUI();
	}

	public void HNMMHJOFBGB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.FNNPPBDFBCI(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FNKIODOAHPN));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OFEMFGCBLBH));
		walkTo.PEHELKCIECB();
	}

	[SpecialName]
	public static BobNPC EJHDHCNILDH()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BobNPC OFLELHKKNKC()
	{
		return IADEMLIIDPC;
	}

	public void LFAPOMEEBJI()
	{
		ShopUI.FKFNANNBIAM(LDBJELPPBAI().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(BNDNMBGJEKP().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (!bobAnim.animator.GetBool("Sleep") || EventsManager.IsActive(EventsManager.EventType.RoadBlocked))
		{
			base.MouseUp(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void KHHIGGPNAND()
	{
		ShopUI.NALKHGMLALJ(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(POINNCPMEIG().EHHOHCPHAAO).OpenUI();
	}

	public override bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!playerCanInteract)
		{
			return false;
		}
		return base.IsAvailableByProximity(JIIGOACEIKL);
	}

	private void OIMOJDJDCAK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
		}
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	private void FixedUpdate()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	private void NDPMBDKGMKA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	private void CNHEMKHJPPN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			NDPMBDKGMKA();
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void ALDAHNKKOGE()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(BNDNMBGJEKP().dialogueEvent))
		{
			DFJGHOHPPEL().barkDialogue = false;
			LDBJELPPBAI().mouseUpTrigger = true;
			POINNCPMEIG().StartConversation(0, DFJGHOHPPEL().dialogueEvent);
			DFJGHOHPPEL().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)5;
		}
		if (disable)
		{
			Debug.Log((object)"<size=");
			content.SetActive(true);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void LNCNPIPMJLL()
	{
		ShopUI.IEKODILKIHJ(DFJGHOHPPEL().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(LDBJELPPBAI().EHHOHCPHAAO).OpenUI();
	}

	private void GAAKLENLEOF(Collider2D HANHCHBHHEH)
	{
	}

	public void APGNMAGFPOO(string bark)
	{
		((MonoBehaviour)DFJGHOHPPEL()).StartCoroutine(NILKMGAHLKM(bark));
	}

	private void BGPGIOMKKAO()
	{
		if (EventsManager.IsDone(EventsManager.EventType.RoadBlocked))
		{
			Debug.Log((object)("RoadBlocked" + EventsManager.IsDone(EventsManager.EventType.RoadBlocked)));
			((Behaviour)bobAnim).enabled = true;
		}
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private void DIKPOHPGNLG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	[SpecialName]
	public static BobNPC DFJGHOHPPEL()
	{
		return IADEMLIIDPC;
	}

	public void JHCONAJDBHG(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.KBEENHPEOAB(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(MMHIOJMIJMP));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(AEOBJMKNACK));
		walkTo.EHDKLBLKBEO();
	}

	public void MMHIOJMIJMP()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(POINNCPMEIG().dialogueEvent))
		{
			DFJGHOHPPEL().barkDialogue = false;
			EJHDHCNILDH().mouseUpTrigger = false;
			BNDNMBGJEKP().StartConversation(0, GGFJGHHHEJC.dialogueEvent);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Left;
		}
		if (disable)
		{
			Debug.Log((object)"ReceiveDialogueInfo");
			content.SetActive(true);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void LFDHFFEPFCO(string bark)
	{
		((MonoBehaviour)EJHDHCNILDH()).StartCoroutine(PNLLADACPCK(bark));
	}

	public void ADAPAMDCNEH()
	{
		ShopUI.EAONFFENMCE(LDBJELPPBAI().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private IEnumerator IKOJJCNGOHM(string GAGJHPKONIC)
	{
		return new KLIFMKOGOAE(1)
		{
			bark = GAGJHPKONIC
		};
	}

	public void GOLAJNDPNKP(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.EJPGFOEDPBG(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(JLMKOKBPLFN));
		walkTo.NOFKEMGPFEO();
	}

	public void BMFNJOFDHGO(string bark)
	{
		((MonoBehaviour)DFJGHOHPPEL()).StartCoroutine(BEGMJLGDBAD(bark));
	}

	[SpecialName]
	public static BobNPC POINNCPMEIG()
	{
		return IADEMLIIDPC;
	}

	private void JAPFDIEHKPI()
	{
		if (OnlineManager.MasterOrOffline())
		{
			LNPFFJBJHJM();
		}
	}

	private void CHIJGHPHCNA()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
	}

	public void MKIONOKDHPA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GLHBJNDMIDC(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(ALDAHNKKOGE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OFEMFGCBLBH));
		walkTo.NOFKEMGPFEO();
	}

	public void IKFIADANHCE(string emotion)
	{
		OFLELHKKNKC().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
	}

	public void MCFCNKLOCKL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.DHFPOCOEONG(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FNKIODOAHPN));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(AEOBJMKNACK));
		walkTo.EHDKLBLKBEO();
	}

	private void HKOFLOPDCEJ()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			MBLOIGIMANG();
		}
	}

	private void CJLGLDBNHBE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	protected override void Update()
	{
		base.Update();
		inUseBob = inUse;
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void LFPJOBMFDAC(Collider2D HANHCHBHHEH)
	{
	}

	public void OGEMNLDNDBM(string emotion)
	{
		GGFJGHHHEJC.emotionsController.NMAPMPBAGMM(emotion);
	}

	public void HEACFLIHBBI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.JJDCANFBFMK(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PADPIEKGNMH));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GANFLECJKBE));
		walkTo.PEHELKCIECB();
	}

	public void AMLCKCOBHGO(string emotion)
	{
		BNDNMBGJEKP().emotionsController.EMMBEAHMDHE(emotion);
	}

	private IEnumerator BEPMIHMIFBE(string GAGJHPKONIC)
	{
		return new KLIFMKOGOAE(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private void JDFDLEEELFH()
	{
		if (EventsManager.IsDone((EventsManager.EventType)(-159)))
		{
			Debug.Log((object)("OnlinePlayer" + EventsManager.LOFKKDNOKNF((EventsManager.EventType)155)));
			((Behaviour)bobAnim).enabled = false;
		}
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JDFDLEEELFH));
	}

	private void AEOBJMKNACK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		HEACFLIHBBI(targetWalkTo, endWalkDirection);
	}

	private void GONBDDJHANF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		HEACFLIHBBI(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	[SpecialName]
	public static BobNPC BNDNMBGJEKP()
	{
		return IADEMLIIDPC;
	}

	private void HPGGFPEOPGJ()
	{
		if (EventsManager.AEFHILOAEEE((EventsManager.EventType)78))
		{
			Debug.Log((object)("Dialogue System/Conversation/Gass_Quest/Entry/37/Dialogue Text" + EventsManager.ALEMDEBCFDH((EventsManager.EventType)162)));
			((Behaviour)bobAnim).enabled = true;
		}
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PCBKNPFOFCC));
	}

	private void CGONFNBEOHF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	public void BFBEEAMKPID(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.HELOLJBENMK(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PADPIEKGNMH));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(PDLDELGPHMG));
		walkTo.NOFKEMGPFEO();
	}

	private void IMPOBDAAPHB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	public void DOCHPOEOOAL(string emotion)
	{
		GGFJGHHHEJC.emotionsController.GPLECKGJFKM(emotion);
	}

	private void GPKKMEGKDHE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	public void FNKIODOAHPN()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(BNDNMBGJEKP().dialogueEvent))
		{
			LDBJELPPBAI().barkDialogue = false;
			LDBJELPPBAI().mouseUpTrigger = false;
			OPDKAPNDBJE().StartConversation(0, OFLELHKKNKC().dialogueEvent, FLHBPHPKIML: true);
			OFLELHKKNKC().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
		}
		if (disable)
		{
			Debug.Log((object)"");
			content.SetActive(true);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private IEnumerator MEMJIGHAKNO(string GAGJHPKONIC)
	{
		if (GAGJHPKONIC == "Farm/Event/VioletyBob")
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

	private void PCBKNPFOFCC()
	{
		if (EventsManager.LOFKKDNOKNF((EventsManager.EventType)(-182)))
		{
			Debug.Log((object)("- " + EventsManager.IsDone((EventsManager.EventType)(-6))));
			((Behaviour)bobAnim).enabled = true;
		}
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(INHHGMPOFBF));
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	private void NPCEFHCNJGE(Collider2D HANHCHBHHEH)
	{
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsActive(EventsManager.EventType.RoadBlocked))
		{
			dialogue.conversation = "RoadBlocked/Main";
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt != 0)
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt != 1)
			{
				dialogue.conversation = "Farm/Bob/Stand";
				return;
			}
		}
		dialogue.conversation = "Farm/Bob/Introduce";
	}

	private void NFNBJANDMCC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			DFCKAJCMPFL();
		}
	}

	public void BarkSequence(string bark)
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(BEGMJLGDBAD(bark));
	}

	public void HBEPDNOMENA(string emotion)
	{
		OPDKAPNDBJE().emotionsController.StartEmotion(emotion);
	}

	public void GINJDLKFNMB(string emotion)
	{
		BNDNMBGJEKP().emotionsController.EMMBEAHMDHE(emotion);
	}

	private IEnumerator FCPEKHFEMEJ(string GAGJHPKONIC)
	{
		return new KLIFMKOGOAE(1)
		{
			bark = GAGJHPKONIC
		};
	}

	public void Walk(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.FNNPPBDFBCI(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		walkTo.PEHELKCIECB();
	}

	private IEnumerator PNLLADACPCK(string GAGJHPKONIC)
	{
		return new KLIFMKOGOAE(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private void LBPGLJOGDMK()
	{
		if (EventsManager.FDIHEFGPKFP((EventsManager.EventType)(-71)))
		{
			Debug.Log((object)("itemRedGrapeMust" + EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-23))));
			((Behaviour)bobAnim).enabled = false;
		}
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PCBKNPFOFCC));
	}

	private IEnumerator KFAOHCKAGIK(string GAGJHPKONIC)
	{
		return new KLIFMKOGOAE(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private void JMCJFCPCDKL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			CJLGLDBNHBE();
		}
	}

	private void LNPFFJBJHJM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	private void HEDGGNKENPB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			NDPMBDKGMKA();
		}
	}

	public void PADPIEKGNMH()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OPDKAPNDBJE().dialogueEvent))
		{
			EJHDHCNILDH().barkDialogue = false;
			BNDNMBGJEKP().mouseUpTrigger = true;
			POINNCPMEIG().StartConversation(1, GGFJGHHHEJC.dialogueEvent);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != 0)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Up;
		}
		if (disable)
		{
			Debug.Log((object)"Spade");
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void Start()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public void GEFMFLAGCKF(string bark)
	{
		((MonoBehaviour)DFJGHOHPPEL()).StartCoroutine(FCBLIFMAHMC(bark));
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	private void DBNAJMBFJEG()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			MBLOIGIMANG();
		}
	}

	private void NELBHAMPBPL()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(PCBKNPFOFCC));
	}

	public void PFHDEFOFLOE(string bark)
	{
		((MonoBehaviour)BNDNMBGJEKP()).StartCoroutine(FCPEKHFEMEJ(bark));
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

	[SpecialName]
	public static BobNPC LDBJELPPBAI()
	{
		return IADEMLIIDPC;
	}

	private void IPFECOIDGAE()
	{
		if (EventsManager.DOPLDNPIBPP((EventsManager.EventType)(-62)))
		{
			Debug.Log((object)("Invalid player num" + EventsManager.FDIHEFGPKFP((EventsManager.EventType)73)));
			((Behaviour)bobAnim).enabled = false;
		}
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LBPGLJOGDMK));
	}

	private void OFEMFGCBLBH()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JHCONAJDBHG(targetWalkTo, endWalkDirection);
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!bobAnim.animator.GetBool("Sleep") || EventsManager.IsActive(EventsManager.EventType.RoadBlocked))
		{
			base.OnHover(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private void BGFCHEIOKOG()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(HPGGFPEOPGJ));
	}

	public override void CheckExclamationSendOnline(bool sendOnline)
	{
		if (EventsManager.IsActive(EventsManager.EventType.RoadBlocked))
		{
			GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, sendOnline);
		}
		else
		{
			GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: false, sendOnline);
		}
	}

	private void OLDDEAJMHNI()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LBPGLJOGDMK));
	}

	private void CHMHMGACCNH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	public void NODKOAHMPFM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.DHFPOCOEONG(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GANFLECJKBE));
		walkTo.NOFKEMGPFEO();
	}

	private IEnumerator FCBLIFMAHMC(string GAGJHPKONIC)
	{
		if (GAGJHPKONIC == "Farm/Event/VioletyBob")
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

	private void BNIKICAEIND()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(HPGGFPEOPGJ));
	}

	private IEnumerator NILKMGAHLKM(string GAGJHPKONIC)
	{
		if (GAGJHPKONIC == "Farm/Event/VioletyBob")
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

	private void DHIOKICDPIK(Collider2D HANHCHBHHEH)
	{
	}

	private void KACEOJDPLKB()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(JDFDLEEELFH));
	}

	public void LCILJBGGDDL()
	{
		ShopUI.NALKHGMLALJ(LDBJELPPBAI().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(EJHDHCNILDH().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		NJJCCIBDAPM();
	}

	public void KCKGPHEACFO()
	{
		ShopUI.IEABDMDELFO(LDBJELPPBAI().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(OFLELHKKNKC().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void BLDPKJOMJOK(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.DBHOIIIHIIM(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PADPIEKGNMH));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GANFLECJKBE));
		walkTo.EHDKLBLKBEO();
	}

	public void DPKEDOOJOAA()
	{
		ShopUI.IEKODILKIHJ(LDBJELPPBAI().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void KPPIKBFOIFB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			LNPFFJBJHJM();
		}
	}

	private IEnumerator BEGMJLGDBAD(string GAGJHPKONIC)
	{
		if (GAGJHPKONIC == "Farm/Event/VioletyBob")
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

	private void MBLOIGIMANG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	public void HHDCJGOFOFJ(string bark)
	{
		((MonoBehaviour)BNDNMBGJEKP()).StartCoroutine(FCBLIFMAHMC(bark));
	}

	private void PDLDELGPHMG()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		NODKOAHMPFM(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void OABHKHIEJBJ(string bark)
	{
		((MonoBehaviour)EJHDHCNILDH()).StartCoroutine(MEMJIGHAKNO(bark));
	}

	private void DFCKAJCMPFL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}
}
