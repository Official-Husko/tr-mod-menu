using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class TweekNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class KGDKIPFENPN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TweekNPC _003C_003E4__this;

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
		public KGDKIPFENPN(int _003C_003E1__state)
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
			TweekNPC tweekNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.waitRealtime05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((Renderer)tweekNPC.KIIEOIGDPFF.npcSprite).sortingOrder = 1;
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

	private static TweekNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "";

	public NPCAnimation KIIEOIGDPFF => animationBase as NPCAnimation;

	public static TweekNPC GGFJGHHHEJC => IADEMLIIDPC;

	[SpecialName]
	public static TweekNPC JLNBMNKJCHE()
	{
		return IADEMLIIDPC;
	}

	public void APLNODFEIGF(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.HELOLJBENMK(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IDBCMIMFHJC));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(IJGENAIOCHB));
			walkTo.EHDKLBLKBEO();
		}
	}

	private void FHEGBNMJADG()
	{
		SelectDialogueUI(1);
	}

	private IEnumerator GCFFFBHGCHJ()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	private void MFDJLGHGEJH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	private void MDLHDGDLANK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GAINAOFIGGH(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public NPCAnimation HCJACLPIOGO()
	{
		return animationBase as NPCAnimation;
	}

	private IEnumerator EAILJNCMOGD()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	private void IJGENAIOCHB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		HNMMHJOFBGB(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void NKAMNKDKLHI()
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(KNOKBLFFNLM().dialogueEvent))
		{
			HEKFJEKFMNO().barkDialogue = true;
			KNOKBLFFNLM().mouseUpTrigger = false;
			BDAGIEIJOOG().StartConversation(0, JLNBMNKJCHE().dialogueEvent, FLHBPHPKIML: true);
			EFPJLFMBPLL().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)5;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		if (animationBase.JEJPKGILEDB("UpgradeToLevel"))
		{
			animationBase.SetBool("No banquet barrel found with drink: ", EGFGNGJGBOP: false, HALNIEBONKH: true);
			((MonoBehaviour)this).StartCoroutine(GEOCAEGNMPM());
		}
		targetWalkTo = Vector2.zero;
	}

	public void KCINDOCIKAI()
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(ABDJJBFNLBJ().dialogueEvent))
		{
			EJHDHCNILDH().barkDialogue = true;
			EFPJLFMBPLL().mouseUpTrigger = true;
			GGFJGHHHEJC.StartConversation(1, HEKFJEKFMNO().dialogueEvent);
			EJHDHCNILDH().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		if (animationBase.JEJPKGILEDB("El componente ItemSetup del prefab '{0}' no referencia correctamente al item '{1}' (ID: {2})."))
		{
			animationBase.SetBool("/", EGFGNGJGBOP: false, HALNIEBONKH: true);
			((MonoBehaviour)this).StartCoroutine(ADFPFDPLHLK());
		}
		targetWalkTo = Vector2.zero;
	}

	private IEnumerator DCHOCLPHEIC()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	private void LFNENELHOGJ()
	{
		SelectDialogueUI(1);
	}

	private void IMPOBDAAPHB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	private void NLFHFPHDNCF()
	{
		SelectDialogueUI(1);
	}

	private IEnumerator KOEEBIAJIBJ()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	private void JLCFNPBBKEK()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static TweekNPC BDAGIEIJOOG()
	{
		return IADEMLIIDPC;
	}

	public void CFFPOBJPNCI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(". Time since startup: ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void BLIHMNIAENP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void GHDIABALHLP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
		}
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void EGACIHOKJLH()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static TweekNPC EJHDHCNILDH()
	{
		return IADEMLIIDPC;
	}

	private void IABEJCPMJOF()
	{
		SelectDialogueUI();
	}

	public void GOKMCECOBCK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Can't find Seat");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void Start()
	{
		SelectDialogueUI();
	}

	private IEnumerator EOJBLBDJEBA()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	public void HNMMHJOFBGB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.EJPGFOEDPBG(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PCFNCMPNBDI));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OHDFLHEHING));
			walkTo.PEHELKCIECB();
		}
	}

	private void HJHHKHAFHJE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	private void CHIJGHPHCNA()
	{
		SelectDialogueUI(1);
	}

	public void COACMHKHDBL()
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OOKBNHMMFON().dialogueEvent))
		{
			GAGMPCEPONF().barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = false;
			EFPJLFMBPLL().StartConversation(0, EFPJLFMBPLL().dialogueEvent);
			OOKBNHMMFON().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		if (animationBase.GetBool("Object "))
		{
			animationBase.CGEADHOLHCH("Winner", EGFGNGJGBOP: false, HALNIEBONKH: true);
			((MonoBehaviour)this).StartCoroutine(PCPEHFOCPMK());
		}
		targetWalkTo = Vector2.zero;
	}

	private IEnumerator BBNOACKLHON()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	private IEnumerator JOEBCFLJKCN()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void OHJIFGGCDAN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			BLIHMNIAENP();
		}
	}

	private void IPMEFFKMPCI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	private void HPIMHEMJMAA()
	{
		SelectDialogueUI(1);
	}

	public void FPKLJCGJBPL(string emotion)
	{
		EJHDHCNILDH().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void MCFCNKLOCKL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GDGGABHLNOH(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PCFNCMPNBDI));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
			walkTo.PEHELKCIECB();
		}
	}

	private void CHMHMGACCNH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void DPOHEFNJFKK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			PIPFMDKNHBE();
		}
	}

	private void HELHNJDFPPF()
	{
		SelectDialogueUI(1);
	}

	private IEnumerator PCPEHFOCPMK()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	private void PDMHOEICGAD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			MMEPKPBACMO();
		}
	}

	private IEnumerator JHLANAAJNBA()
	{
		return new KGDKIPFENPN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PIHOPOOOHHN()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	private IEnumerator AMMGDJCBLPP()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	[SpecialName]
	public NPCAnimation MJIBMCCBJPI()
	{
		return animationBase as NPCAnimation;
	}

	private void DCBPBCKENPC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	private void EGDIINMEMGE()
	{
		SelectDialogueUI();
	}

	private void GNGADDPBJDC()
	{
		SelectDialogueUI();
	}

	public void IDBCMIMFHJC()
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EFPJLFMBPLL().dialogueEvent))
		{
			KNOKBLFFNLM().barkDialogue = false;
			GAGMPCEPONF().mouseUpTrigger = false;
			GGFJGHHHEJC.StartConversation(1, GGFJGHHHEJC.dialogueEvent);
			OOKBNHMMFON().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		if (animationBase.JEJPKGILEDB("Sabrina"))
		{
			animationBase.CGEADHOLHCH("chaty", EGFGNGJGBOP: false);
			((MonoBehaviour)this).StartCoroutine(EAILJNCMOGD());
		}
		targetWalkTo = Vector2.zero;
	}

	public void EACGIFJCIKJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Tutorial/T101/Dialogue1");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static TweekNPC KNOKBLFFNLM()
	{
		return IADEMLIIDPC;
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
	public NPCAnimation PHEOCCJKKDI()
	{
		return animationBase as NPCAnimation;
	}

	public void FFHKDCECPHI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_description_1085");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void GGOCPPNOGCD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.JDHMPOJKOLF(targetWalkTo);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PCFNCMPNBDI));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
			walkTo.NOFKEMGPFEO();
		}
	}

	[SpecialName]
	public static TweekNPC EFPJLFMBPLL()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator LLELBIPFAFC()
	{
		return new KGDKIPFENPN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OJOJGBLAPBB()
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GAGMPCEPONF().dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = false;
			EJHDHCNILDH().mouseUpTrigger = false;
			GAGMPCEPONF().StartConversation(1, HEKFJEKFMNO().dialogueEvent, FLHBPHPKIML: true);
			HEKFJEKFMNO().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		if (animationBase.JEJPKGILEDB("bath travelling"))
		{
			animationBase.SetBool("Swiss Cheese", EGFGNGJGBOP: false);
			((MonoBehaviour)this).StartCoroutine(GCFFFBHGCHJ());
		}
		targetWalkTo = Vector2.zero;
	}

	public void EEBOKKANBEM(string emotion)
	{
		ABDJJBFNLBJ().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static TweekNPC GAGMPCEPONF()
	{
		return IADEMLIIDPC;
	}

	private void MMEPKPBACMO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL();
		}
	}

	[SpecialName]
	public static TweekNPC OOKBNHMMFON()
	{
		return IADEMLIIDPC;
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private IEnumerator NKMAMJOLLAD()
	{
		return new KGDKIPFENPN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PODKNIMOACM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			MFDJLGHGEJH();
		}
	}

	private void DGIFHBIJDDE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			CHMHMGACCNH();
		}
	}

	public void EEPJLOBNIMM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Chat selected");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void KDBJHCAEGCM()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public NPCAnimation HBAEIGCMBGJ()
	{
		return animationBase as NPCAnimation;
	}

	public void OnActionComplete()
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
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
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		if (animationBase.GetBool("Roll"))
		{
			animationBase.SetBool("Roll", EGFGNGJGBOP: false);
			((MonoBehaviour)this).StartCoroutine(GCFFFBHGCHJ());
		}
		targetWalkTo = Vector2.zero;
	}

	[SpecialName]
	public NPCAnimation HINDOCPMBHH()
	{
		return animationBase as NPCAnimation;
	}

	private void AFKGJCIANOF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			PIPFMDKNHBE();
		}
	}

	private void HOKAPOOCJCC()
	{
		SelectDialogueUI();
	}

	private void OGFKFGAMGCE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	[SpecialName]
	public NPCAnimation ACGGAGEGIHA()
	{
		return animationBase as NPCAnimation;
	}

	[SpecialName]
	public NPCAnimation OPBNIAFMIDN()
	{
		return animationBase as NPCAnimation;
	}

	private void OHDFLHEHING()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void LFBMFAHPBIM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KPOIBPDHLPE(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void NODKOAHMPFM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GDGGABHLNOH(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(COACMHKHDBL));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OHDFLHEHING));
			walkTo.PEHELKCIECB();
		}
	}

	[SpecialName]
	public NPCAnimation COHNBHMHKGK()
	{
		return animationBase as NPCAnimation;
	}

	public override bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!playerCanInteract)
		{
			return false;
		}
		return base.IsAvailableByProximity(JIIGOACEIKL);
	}

	public void GAINAOFIGGH(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.OGLJDLEGJAA(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OJOJGBLAPBB));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(HEADJCFMKIP));
			walkTo.PEHELKCIECB();
		}
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	private void HEADJCFMKIP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private IEnumerator ADFPFDPLHLK()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	public new void CheckExclamation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	private void FixedUpdate()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	[SpecialName]
	public NPCAnimation OMKHKPIACKO()
	{
		return animationBase as NPCAnimation;
	}

	public void JBKHJEJAMHM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Waiting for guards to finish walking...");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	public void BAPCIPCAEKL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.BDIKOLNFKGD(targetWalkTo);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(LFBMFAHPBIM));
			walkTo.PEHELKCIECB();
		}
	}

	public void KPOIBPDHLPE(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.BDIKOLNFKGD(targetWalkTo);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(NKAMNKDKLHI));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(IJGENAIOCHB));
			walkTo.NOFKEMGPFEO();
		}
	}

	private void GBFPCABGAII()
	{
		SelectDialogueUI(1);
	}

	public void FAHDMOFILDI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Actionbar 7");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void CDGNCDKDCIG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
		}
	}

	public void LMBJEGLHKBO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("- ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	private void EBNENBFLEKB()
	{
		SelectDialogueUI(1);
	}

	private void GNMMELIJKML()
	{
		SelectDialogueUI();
	}

	private void EHBFECEJGCE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			MFDJLGHGEJH();
		}
	}

	[SpecialName]
	public NPCAnimation MIEGFIPBCBM()
	{
		return animationBase as NPCAnimation;
	}

	public void OFABJMDGBDM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.OGLJDLEGJAA(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(BKNBKDKIDNJ));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(HEADJCFMKIP));
			walkTo.NOFKEMGPFEO();
		}
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
	public static TweekNPC HEKFJEKFMNO()
	{
		return IADEMLIIDPC;
	}

	public void AFDECDJICPD(string emotion)
	{
		BDAGIEIJOOG().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public NPCAnimation HKCEGLJEALB()
	{
		return animationBase as NPCAnimation;
	}

	private IEnumerator OKABOCJBJLK()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	public void EKFJKEMGCKB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Tutorial/T130/Dialogue1");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void CJEECBDICOK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("}");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public NPCAnimation DGOEHJBKCGJ()
	{
		return animationBase as NPCAnimation;
	}

	public void KBFLBLENCKJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("qualityWater2");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator GEOCAEGNMPM()
	{
		return new KGDKIPFENPN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NEEDNONKBAC()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KPOIBPDHLPE(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void OPEIHOAKOKP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private IEnumerator FFMLHJNPHEN()
	{
		yield return CommonReferences.waitRealtime05;
		((Renderer)KIIEOIGDPFF.npcSprite).sortingOrder = 1;
	}

	private void EOFEAJHOMDN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			MMEPKPBACMO();
		}
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	[SpecialName]
	public NPCAnimation IIONKKLNCKH()
	{
		return animationBase as NPCAnimation;
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsActive(EventsManager.EventType.ThroneRoom))
		{
			dialogue.conversation = "SalonDelTrono/TweekTalk";
		}
	}

	public void HJBBGFPGGDO(string emotion)
	{
		HEKFJEKFMNO().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void PCFNCMPNBDI()
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GAGMPCEPONF().dialogueEvent))
		{
			BDAGIEIJOOG().barkDialogue = true;
			JLNBMNKJCHE().mouseUpTrigger = false;
			EFPJLFMBPLL().StartConversation(1, BDAGIEIJOOG().dialogueEvent, FLHBPHPKIML: true);
			GAGMPCEPONF().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)6;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		if (animationBase.GetBool("CultivableDuringOneMonth"))
		{
			animationBase.CGEADHOLHCH("HarvestableAllYearRound", EGFGNGJGBOP: true, HALNIEBONKH: true);
			((MonoBehaviour)this).StartCoroutine(GCFFFBHGCHJ());
		}
		targetWalkTo = Vector2.zero;
	}

	[SpecialName]
	public static TweekNPC ABDJJBFNLBJ()
	{
		return IADEMLIIDPC;
	}

	public void BKNBKDKIDNJ()
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GGFJGHHHEJC.dialogueEvent))
		{
			EJHDHCNILDH().barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = true;
			EFPJLFMBPLL().StartConversation(1, ABDJJBFNLBJ().dialogueEvent, FLHBPHPKIML: true);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		if (animationBase.GetBool("Items/item_description_651"))
		{
			animationBase.CGEADHOLHCH("", EGFGNGJGBOP: false);
			((MonoBehaviour)this).StartCoroutine(PCPEHFOCPMK());
		}
		targetWalkTo = Vector2.zero;
	}

	private void DMFMNEMDFNP()
	{
		SelectDialogueUI(1);
	}

	public void Walk(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.FNNPPBDFBCI(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
			walkTo.PEHELKCIECB();
		}
	}

	private void NPJMFAGHKCO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	private void PIPFMDKNHBE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}
}
