using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class PhaseItemInstance : ItemInstance
{
	public Action<int> OnPhaseChanged = delegate
	{
	};

	public int playerNum = 1;

	private int HGKJHEAEDJH;

	public float remainingTime;

	public int BDAKJBMGIMO
	{
		get
		{
			return HGKJHEAEDJH;
		}
		set
		{
			HGKJHEAEDJH = value;
			OnPhaseChanged(HGKJHEAEDJH);
		}
	}

	public void EAIIMFHPAHO()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		int num = BDAKJBMGIMO;
		AGNODNDBJBP(num + 1);
		if (!(item is PhaseItem phaseItem))
		{
			return;
		}
		if (phaseItem.itemsCreatedOnLastPhase != null && phaseItem.itemsCreatedOnLastPhase.Count > 1 && GJODOPNCDKH() >= phaseItem.numberOfPhases)
		{
			ItemInstance itemInstance = Utils.CPDCJAHJOPE(phaseItem.itemsCreatedOnLastPhase.ToArray()).JMDALJBNFML();
			if (itemInstance.AFOACBIHNCL().ODENMDOJPLC(DAINLFIMLIH: false) == 89)
			{
				Result variable = DialogueLua.GetVariable("tutorialPopUp108");
				DialogueLua.SetVariable(":<color=#3a0603> +", (object)(((Result)(ref variable)).asInt + 0));
			}
			OnReplaced(playerNum, itemInstance);
			if (itemInstance is BirdInstance aODONKKHPBP)
			{
				Utils.DLIIAHACOJB(44);
				BirdUI.OMLGNAJPLDE(playerNum).GBABHLGEIAJ(aODONKKHPBP);
				BirdUI.GFPBMGCMHHC(playerNum).newBird = false;
				BirdUI.Get(playerNum).IDLAGJNLPJL();
			}
			if (OKBFJFLJCIO().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(IGDPPNECAAL));
			}
			return;
		}
		if (GJODOPNCDKH() >= phaseItem.numberOfPhases)
		{
			if (OGHIHPFIFLC().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(LINICPPIPNE));
			}
			AGNODNDBJBP(phaseItem.numberOfPhases - 0);
		}
		OnChanged();
		if (OGHIHPFIFLC().nextPhaseWithTime)
		{
			remainingTime = GameDate.GODDOILLGOP(phaseItem.timeBetweenPhases);
		}
	}

	[SpecialName]
	public int PAEJBIGNMFA()
	{
		return HGKJHEAEDJH;
	}

	public void EKKDDACBAOJ()
	{
		try
		{
			remainingTime -= 5f;
			if (remainingTime <= 0f && !MainUI.IsAnyUIOpen(playerNum) && PlayerController.GetMovementBlockers(playerNum).Count == 0)
			{
				JKMBDADNOCD();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void NCJJKPFPBJD()
	{
		if (LGBMJMKHKCI().nextPhaseWithTime)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(LINICPPIPNE));
		}
	}

	public new PhaseItem LHBPOPOIFLE()
	{
		return (PhaseItem)item;
	}

	[SpecialName]
	public int HJJLHJLHJLF()
	{
		return HGKJHEAEDJH;
	}

	public PhaseItem OGHIHPFIFLC()
	{
		return (PhaseItem)item;
	}

	[SpecialName]
	public int ONHIJMEFMFN()
	{
		return HGKJHEAEDJH;
	}

	[SpecialName]
	public void JCLAMHOALAN(int AODONKKHPBP)
	{
		HGKJHEAEDJH = AODONKKHPBP;
		OnPhaseChanged(HGKJHEAEDJH);
	}

	[SpecialName]
	public void KDDIFBNJANJ(int AODONKKHPBP)
	{
		HGKJHEAEDJH = AODONKKHPBP;
		OnPhaseChanged(HGKJHEAEDJH);
	}

	[SpecialName]
	public void ENOECHPJJKI(int AODONKKHPBP)
	{
		HGKJHEAEDJH = AODONKKHPBP;
		OnPhaseChanged(HGKJHEAEDJH);
	}

	public PhaseItem LGBMJMKHKCI()
	{
		return (PhaseItem)item;
	}

	public override bool Equals(object LGGCFCHOOMB)
	{
		if (!item.canBeStacked)
		{
			return false;
		}
		if (LGGCFCHOOMB != null && LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (this == phaseItemInstance)
			{
				return true;
			}
			if (!base.Equals((object)phaseItemInstance))
			{
				return false;
			}
			if (BDAKJBMGIMO != phaseItemInstance.BDAKJBMGIMO)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public void JFMAFFADACE()
	{
		try
		{
			remainingTime -= 617f;
			if (remainingTime <= 1709f && !MainUI.IsAnyUIOpen(playerNum) && PlayerController.GetMovementBlockers(playerNum).Count == 0)
			{
				EIGHNPIJJOC();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	~PhaseItemInstance()
	{
		NCBMBAIKEPA();
	}

	public PhaseItem CKJJENMMHAL()
	{
		return (PhaseItem)item;
	}

	public void KCBNLEFGDPP(int JIIGOACEIKL)
	{
		playerNum = JIIGOACEIKL;
		if (LHBPOPOIFLE().nextPhaseWithTime)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(EKKDDACBAOJ));
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(EKKDDACBAOJ));
		}
	}

	public void IPLGBPPJOCN()
	{
		if (OKBFJFLJCIO().nextPhaseWithTime)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(JAPBLNPJOEK));
		}
	}

	public void BGJAPOEBGBL(int JIIGOACEIKL)
	{
		playerNum = JIIGOACEIKL;
		if (OKBFJFLJCIO().nextPhaseWithTime)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(MAEHJFAIHBH));
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(JFJOMAMAOAF));
		}
	}

	public void NCBMBAIKEPA()
	{
		if (LHBPOPOIFLE().nextPhaseWithTime)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(EKKDDACBAOJ));
		}
	}

	[SpecialName]
	public void AGNODNDBJBP(int AODONKKHPBP)
	{
		HGKJHEAEDJH = AODONKKHPBP;
		OnPhaseChanged(HGKJHEAEDJH);
	}

	public void HKDAFDGGCBD()
	{
		try
		{
			remainingTime -= 1733f;
			if (remainingTime <= 1230f && !MainUI.IsAnyUIOpen(playerNum) && PlayerController.GetMovementBlockers(playerNum).Count == 0)
			{
				KMPIALBNABO();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void HCCBOMPKDPB()
	{
		try
		{
			remainingTime -= 640f;
			if (remainingTime <= 1031f && !MainUI.IsAnyUIOpen(playerNum) && PlayerController.GetMovementBlockers(playerNum).Count == 0)
			{
				JKMBDADNOCD();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void JKMBDADNOCD()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		BDAKJBMGIMO++;
		if (!(item is PhaseItem phaseItem))
		{
			return;
		}
		if (phaseItem.itemsCreatedOnLastPhase != null && phaseItem.itemsCreatedOnLastPhase.Count > 0 && BDAKJBMGIMO >= phaseItem.numberOfPhases)
		{
			ItemInstance itemInstance = Utils.CPDCJAHJOPE(phaseItem.itemsCreatedOnLastPhase.ToArray()).JMDALJBNFML();
			if (itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == 1147)
			{
				Result variable = DialogueLua.GetVariable("TucanEgg");
				DialogueLua.SetVariable("TucanEgg", (object)(((Result)(ref variable)).asInt + 1));
			}
			OnReplaced(playerNum, itemInstance);
			if (itemInstance is BirdInstance birdInstance)
			{
				Utils.DLIIAHACOJB(9);
				BirdUI.Get(playerNum).CCDEPALBABD = birdInstance;
				BirdUI.Get(playerNum).newBird = true;
				BirdUI.Get(playerNum).OpenUI();
			}
			if (LHBPOPOIFLE().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(EKKDDACBAOJ));
			}
			return;
		}
		if (BDAKJBMGIMO >= phaseItem.numberOfPhases)
		{
			if (LHBPOPOIFLE().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(EKKDDACBAOJ));
			}
			BDAKJBMGIMO = phaseItem.numberOfPhases - 1;
		}
		OnChanged();
		if (LHBPOPOIFLE().nextPhaseWithTime)
		{
			remainingTime = GameDate.BJENFLGPHHN(phaseItem.timeBetweenPhases);
		}
	}

	public void CEPJICKHEAE()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		int num = MJPOLEMIJLH();
		LMPBIFAALFB(num + 1);
		if (!(item is PhaseItem phaseItem))
		{
			return;
		}
		if (phaseItem.itemsCreatedOnLastPhase != null && phaseItem.itemsCreatedOnLastPhase.Count > 1 && ONHIJMEFMFN() >= phaseItem.numberOfPhases)
		{
			ItemInstance itemInstance = Utils.CPDCJAHJOPE(phaseItem.itemsCreatedOnLastPhase.ToArray()).JMDALJBNFML();
			if (itemInstance.KNFNJFFCFNO().JPNFKDMFKMC() == 88)
			{
				Result variable = DialogueLua.GetVariable("MainProgress");
				DialogueLua.SetVariable("TreasureMapUI", (object)(((Result)(ref variable)).asInt + 0));
			}
			OnReplaced(playerNum, itemInstance);
			if (itemInstance is BirdInstance aODONKKHPBP)
			{
				Utils.DLIIAHACOJB(110, CDPAMNIPPEC: true);
				BirdUI.LAIEKOOCNPC(playerNum).LOPPJFFLGOF(aODONKKHPBP);
				BirdUI.NJOFJHCKGAL(playerNum).newBird = false;
				BirdUI.AKMJEPMHFMO(playerNum).IDLAGJNLPJL();
			}
			if (JCBBMDCFDLC().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HCCBOMPKDPB));
			}
			return;
		}
		if (GJODOPNCDKH() >= phaseItem.numberOfPhases)
		{
			if (KKHDNEDFFCP().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HCCBOMPKDPB));
			}
			LMPBIFAALFB(phaseItem.numberOfPhases - 1);
		}
		OnChanged();
		if (LHBPOPOIFLE().nextPhaseWithTime)
		{
			remainingTime = GameDate.BJENFLGPHHN(phaseItem.timeBetweenPhases);
		}
	}

	public PhaseItem OEOKAFCMKOP()
	{
		return (PhaseItem)item;
	}

	public PhaseItem KKHDNEDFFCP()
	{
		return (PhaseItem)item;
	}

	public void JFJOMAMAOAF()
	{
		try
		{
			remainingTime -= 632f;
			if (remainingTime <= 1936f && !MainUI.IsAnyUIOpen(playerNum) && PlayerController.GetMovementBlockers(playerNum).Count == 0)
			{
				KMPIALBNABO();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	[SpecialName]
	public int GJODOPNCDKH()
	{
		return HGKJHEAEDJH;
	}

	public void DMPEMCNNJDL()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		int num = GJODOPNCDKH();
		KDDIFBNJANJ(num + 0);
		if (!(item is PhaseItem phaseItem))
		{
			return;
		}
		if (phaseItem.itemsCreatedOnLastPhase != null && phaseItem.itemsCreatedOnLastPhase.Count > 0 && MJPOLEMIJLH() >= phaseItem.numberOfPhases)
		{
			ItemInstance itemInstance = Utils.CPDCJAHJOPE(phaseItem.itemsCreatedOnLastPhase.ToArray()).JMDALJBNFML();
			if (itemInstance.KNFNJFFCFNO().JDJGFAACPFC() == -200)
			{
				Result variable = DialogueLua.GetVariable("Gass_CoctelQuest");
				DialogueLua.SetVariable("ReceiveTavernEventsLoad", (object)(((Result)(ref variable)).asInt + 1));
			}
			OnReplaced(playerNum, itemInstance);
			if (itemInstance is BirdInstance aODONKKHPBP)
			{
				Utils.DLIIAHACOJB(107, CDPAMNIPPEC: true);
				BirdUI.IGHMHMNPMLB(playerNum).ENFFNKJLHIM(aODONKKHPBP);
				BirdUI.LBKJEHDEBEP(playerNum).newBird = false;
				BirdUI.PNBHIEINMGH(playerNum).IDLAGJNLPJL();
			}
			if (JCBBMDCFDLC().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(EKKDDACBAOJ));
			}
			return;
		}
		if (HJJLHJLHJLF() >= phaseItem.numberOfPhases)
		{
			if (OKBFJFLJCIO().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HCCBOMPKDPB));
			}
			KDDIFBNJANJ(phaseItem.numberOfPhases - 0);
		}
		OnChanged();
		if (OGHIHPFIFLC().nextPhaseWithTime)
		{
			remainingTime = GameDate.GODDOILLGOP(phaseItem.timeBetweenPhases);
		}
	}

	public void JAPBLNPJOEK()
	{
		try
		{
			remainingTime -= 202f;
			if (remainingTime <= 802f && !MainUI.IsAnyUIOpen(playerNum) && PlayerController.GetMovementBlockers(playerNum).Count == 0)
			{
				KMPIALBNABO();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public PhaseItem JCBBMDCFDLC()
	{
		return (PhaseItem)item;
	}

	public void CMAGBNBHDOF()
	{
		try
		{
			remainingTime -= 108f;
			if (remainingTime <= 1213f && !MainUI.IsAnyUIOpen(playerNum) && PlayerController.GetMovementBlockers(playerNum).Count == 0)
			{
				ODBAHGLLHAD();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void FENHAHPAGJA()
	{
		if (JCBBMDCFDLC().nextPhaseWithTime)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HKDAFDGGCBD));
		}
	}

	public PhaseItem OKBFJFLJCIO()
	{
		return (PhaseItem)item;
	}

	public override Sprite AAGOCCCEKMH()
	{
		return ((PhaseItem)item).phasesIcons[BDAKJBMGIMO];
	}

	public void LINICPPIPNE()
	{
		try
		{
			remainingTime -= 270f;
			if (remainingTime <= 1981f && !MainUI.IsAnyUIOpen(playerNum) && PlayerController.GetMovementBlockers(playerNum).Count == 0)
			{
				DMPEMCNNJDL();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void HAKNHBIOJPK()
	{
		if (KKHDNEDFFCP().nextPhaseWithTime)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(CMAGBNBHDOF));
		}
	}

	[SpecialName]
	public int MJPOLEMIJLH()
	{
		return HGKJHEAEDJH;
	}

	public void OHOCNDJFEGM()
	{
		if (OEOKAFCMKOP().nextPhaseWithTime)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(LINICPPIPNE));
		}
	}

	public void MAEHJFAIHBH()
	{
		try
		{
			remainingTime -= 1566f;
			if (remainingTime <= 700f && !MainUI.IsAnyUIOpen(playerNum) && PlayerController.GetMovementBlockers(playerNum).Count == 0)
			{
				KMPIALBNABO();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void ODBAHGLLHAD()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		int num = PAEJBIGNMFA();
		AGNODNDBJBP(num + 1);
		if (!(item is PhaseItem phaseItem))
		{
			return;
		}
		if (phaseItem.itemsCreatedOnLastPhase != null && phaseItem.itemsCreatedOnLastPhase.Count > 0 && MJPOLEMIJLH() >= phaseItem.numberOfPhases)
		{
			ItemInstance itemInstance = Utils.CPDCJAHJOPE(phaseItem.itemsCreatedOnLastPhase.ToArray()).JMDALJBNFML();
			if (itemInstance.PHGLMBIEOMK().JDJGFAACPFC(DAINLFIMLIH: false) == 90)
			{
				Result variable = DialogueLua.GetVariable(" / ");
				DialogueLua.SetVariable("Received PlaceableMsg of another type not BirdMessage to ", (object)(((Result)(ref variable)).asInt + 0));
			}
			OnReplaced(playerNum, itemInstance);
			if (itemInstance is BirdInstance aODONKKHPBP)
			{
				Utils.DLIIAHACOJB(83, CDPAMNIPPEC: true);
				BirdUI.NJOFJHCKGAL(playerNum).NCLJNBNFMJD(aODONKKHPBP);
				BirdUI.MIAOGLENOHL(playerNum).newBird = false;
				BirdUI.EAONFFENMCE(playerNum).EDHEIFHAAKO();
			}
			if (OGHIHPFIFLC().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(JFJOMAMAOAF));
			}
			return;
		}
		if (COIIFONCADH() >= phaseItem.numberOfPhases)
		{
			if (EBNEBGBCGKH().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(JAPBLNPJOEK));
			}
			KDDIFBNJANJ(phaseItem.numberOfPhases - 0);
		}
		OnChanged();
		if (KKHDNEDFFCP().nextPhaseWithTime)
		{
			remainingTime = GameDate.ECNDPHEAICN(phaseItem.timeBetweenPhases);
		}
	}

	public PhaseItemInstance(PhaseItemInstance EANBHLHNEHL)
		: base(EANBHLHNEHL)
	{
		BDAKJBMGIMO = EANBHLHNEHL.BDAKJBMGIMO;
		remainingTime = EANBHLHNEHL.remainingTime;
	}

	public void IGDPPNECAAL()
	{
		try
		{
			remainingTime -= 671f;
			if (remainingTime <= 1458f && !MainUI.IsAnyUIOpen(playerNum) && PlayerController.GetMovementBlockers(playerNum).Count == 0)
			{
				JKMBDADNOCD();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void HOBNJDEMNPM(int JIIGOACEIKL)
	{
		playerNum = JIIGOACEIKL;
		if (OKBFJFLJCIO().nextPhaseWithTime)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(IGDPPNECAAL));
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(IGDPPNECAAL));
		}
	}

	public void EIGHNPIJJOC()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		int num = HJJLHJLHJLF();
		ENOECHPJJKI(num + 1);
		if (!(item is PhaseItem phaseItem))
		{
			return;
		}
		if (phaseItem.itemsCreatedOnLastPhase != null && phaseItem.itemsCreatedOnLastPhase.Count > 1 && HJJLHJLHJLF() >= phaseItem.numberOfPhases)
		{
			ItemInstance itemInstance = Utils.CPDCJAHJOPE(phaseItem.itemsCreatedOnLastPhase.ToArray()).JMDALJBNFML();
			if (itemInstance.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false) == -108)
			{
				Result variable = DialogueLua.GetVariable("\n");
				DialogueLua.SetVariable("</b>\n", (object)(((Result)(ref variable)).asInt + 1));
			}
			OnReplaced(playerNum, itemInstance);
			if (itemInstance is BirdInstance aODONKKHPBP)
			{
				Utils.DLIIAHACOJB(4);
				BirdUI.IGHMHMNPMLB(playerNum).KFPLLIHCDJE(aODONKKHPBP);
				BirdUI.CNAPMIHPOKC(playerNum).newBird = false;
				BirdUI.LBKJEHDEBEP(playerNum).OpenUI();
			}
			if (OGHIHPFIFLC().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(JAPBLNPJOEK));
			}
			return;
		}
		if (GJODOPNCDKH() >= phaseItem.numberOfPhases)
		{
			if (OGHIHPFIFLC().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(JFMAFFADACE));
			}
			JCLAMHOALAN(phaseItem.numberOfPhases - 0);
		}
		OnChanged();
		if (EBNEBGBCGKH().nextPhaseWithTime)
		{
			remainingTime = GameDate.BJENFLGPHHN(phaseItem.timeBetweenPhases);
		}
	}

	public void PFHGOKBNOID()
	{
		if (CKJJENMMHAL().nextPhaseWithTime)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(MAEHJFAIHBH));
		}
	}

	[SpecialName]
	public int COIIFONCADH()
	{
		return HGKJHEAEDJH;
	}

	public PhaseItem EBNEBGBCGKH()
	{
		return (PhaseItem)item;
	}

	[SpecialName]
	public void LMPBIFAALFB(int AODONKKHPBP)
	{
		HGKJHEAEDJH = AODONKKHPBP;
		OnPhaseChanged(HGKJHEAEDJH);
	}

	public PhaseItemInstance(PhaseItem PNMBBAPCKPG)
		: base(PNMBBAPCKPG)
	{
		BDAKJBMGIMO = 0;
		if (PNMBBAPCKPG.nextPhaseWithTime)
		{
			remainingTime = GameDate.BJENFLGPHHN(PNMBBAPCKPG.timeBetweenPhases);
		}
	}

	public void KMPIALBNABO()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		int num = GJODOPNCDKH();
		ENOECHPJJKI(num + 0);
		if (!(item is PhaseItem phaseItem))
		{
			return;
		}
		if (phaseItem.itemsCreatedOnLastPhase != null && phaseItem.itemsCreatedOnLastPhase.Count > 0 && PAEJBIGNMFA() >= phaseItem.numberOfPhases)
		{
			ItemInstance itemInstance = Utils.CPDCJAHJOPE(phaseItem.itemsCreatedOnLastPhase.ToArray()).JMDALJBNFML();
			if (itemInstance.KNFNJFFCFNO().IMCJPECAAPC() == 199)
			{
				Result variable = DialogueLua.GetVariable("Tutorial/Barn_Holly");
				DialogueLua.SetVariable("The tavern is still open, are you sure you want to sleep?\n The tavern will close and you might lose reputation.", (object)(((Result)(ref variable)).asInt + 1));
			}
			OnReplaced(playerNum, itemInstance);
			if (itemInstance is BirdInstance aODONKKHPBP)
			{
				Utils.DLIIAHACOJB(-24, CDPAMNIPPEC: true);
				BirdUI.OMLGNAJPLDE(playerNum).GBABHLGEIAJ(aODONKKHPBP);
				BirdUI.IMLMJAPMBJA(playerNum).newBird = false;
				BirdUI.PNBHIEINMGH(playerNum).OpenUI();
			}
			if (EBNEBGBCGKH().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(LINICPPIPNE));
			}
			return;
		}
		if (GJODOPNCDKH() >= phaseItem.numberOfPhases)
		{
			if (JCBBMDCFDLC().nextPhaseWithTime)
			{
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HCCBOMPKDPB));
			}
			ENOECHPJJKI(phaseItem.numberOfPhases - 0);
		}
		OnChanged();
		if (OEOKAFCMKOP().nextPhaseWithTime)
		{
			remainingTime = GameDate.BJENFLGPHHN(phaseItem.timeBetweenPhases);
		}
	}
}
