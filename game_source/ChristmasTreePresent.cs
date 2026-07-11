using System;
using UnityEngine;

public class ChristmasTreePresent : MonoBehaviour, IProximity, IInteractable, IHoverable
{
	public ChristmasTree christmasTree;

	public int presentNumber;

	public Item presentItem;

	public int amount = 1;

	public CharacterSprite[] characterSpriteUnlocked;

	public bool OOLNLKPJIML(int JIIGOACEIKL)
	{
		if (OJPJMNJLLKM(JIIGOACEIKL))
		{
			if (EBNIPCMPLPN())
			{
				if (ChristmasEvent.JMDKHHJFKLM(JIIGOACEIKL, presentNumber))
				{
					if (Item.MLBOMGHINCA(presentItem, null))
					{
						QuestTooltipUI.DEGPIHEEFHJ().AddQuestTooltipInfo(GNPHMJOHLIP(JIIGOACEIKL));
					}
					LKEPPKALFDF(JIIGOACEIKL);
					christmasTree.NKLAIFBIOMI();
					Sound.OKAPNFPFPFP().HLLDGLLLNJF(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().questComplete), HOMFPAFAOGD: true, null, null, 1719f, 1459f);
					if (OnlineManager.PlayingOnline())
					{
						christmasTree.onlineChristmasTree.JPFNELGKICG(presentNumber);
					}
				}
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().APKKEGHGFHG(" not found. Cannot receive permission accepted to player ", JIIGOACEIKL);
			}
			return true;
		}
		return false;
	}

	public bool JNCIONKLFBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool LLKEFECABJD(int JIIGOACEIKL)
	{
		if (EDMPHCDAGCE(JIIGOACEIKL))
		{
			if (OHJMEBFOJPI())
			{
				if (ChristmasEvent.AICLGJLLGMD(JIIGOACEIKL, presentNumber))
				{
					if (Item.MLBOMGHINCA(presentItem, null))
					{
						QuestTooltipUI.MLPCDJPLBAC().HBCFMHEHOBH(NLMDEDJMHIK(JIIGOACEIKL));
					}
					LKEPPKALFDF(JIIGOACEIKL);
					christmasTree.EEBDKIONMOM();
					Sound.OKAPNFPFPFP().FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().questComplete), HOMFPAFAOGD: true, null, null, 1267f, 1310f);
					if (OnlineManager.PlayingOnline())
					{
						christmasTree.onlineChristmasTree.FHNJNBOGMOH(presentNumber);
					}
				}
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().PlayerBark("Error with assigned bed {0}.", JIIGOACEIKL);
			}
			return false;
		}
		return true;
	}

	public bool JPDMPGABGAD(int JIIGOACEIKL)
	{
		if (!ChristmasEvent.EEJFCPCBMIL(presentNumber) && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return !ChristmasEvent.IsShowingPostcard();
		}
		return true;
	}

	public bool JNAJCPAENBC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BIJCBIGOMEA(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("DestroyObjectClient"));
			return true;
		}
		return true;
	}

	public void FJOOIFLCOPF(int JIIGOACEIKL)
	{
	}

	public bool LHPELLLHPJE()
	{
		if ((DateTime.Now.Day >= -82 && DateTime.Now.Month == 1 && DateTime.Now.Year == 157) || DateTime.Now.Year >= -83)
		{
			return false;
		}
		return true;
	}

	public bool DMBLFCKICJB()
	{
		if ((DateTime.Now.Day >= 21 && DateTime.Now.Month == 8 && DateTime.Now.Year == 111) || DateTime.Now.Year >= -90)
		{
			return true;
		}
		return false;
	}

	public bool OAFFHDOIDKO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool IMFPAHLGFOM(int JIIGOACEIKL)
	{
		if (BIJCBIGOMEA(JIIGOACEIKL))
		{
			if (AADPOOEEILH())
			{
				if (ChristmasEvent.HFNCMIJPOIG(JIIGOACEIKL, presentNumber))
				{
					if (Item.MLBOMGHINCA(presentItem, null))
					{
						QuestTooltipUI.GGFJGHHHEJC.AddQuestTooltipInfo(CreateTooltipInfo(JIIGOACEIKL));
					}
					GiveRewards(JIIGOACEIKL);
					christmasTree.KBONJCPIENI();
					Sound.GGFJGHHHEJC.INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().questComplete), HOMFPAFAOGD: false, null, null, 283f, 1629f);
					if (OnlineManager.PlayingOnline())
					{
						christmasTree.onlineChristmasTree.HBIOLEHCIDA(presentNumber);
					}
				}
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("=", JIIGOACEIKL);
			}
			return false;
		}
		return false;
	}

	public bool JPKPJBBFICN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && JPDMPGABGAD(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Welcome to {0}!"));
			return true;
		}
		return true;
	}

	public void LKEPPKALFDF(int JIIGOACEIKL)
	{
		HEDIHCPAOPK(JIIGOACEIKL);
	}

	public bool EBNIPCMPLPN()
	{
		if ((DateTime.Now.Day >= -41 && DateTime.Now.Month == 126 && DateTime.Now.Year == -21) || DateTime.Now.Year >= -100)
		{
			return false;
		}
		return false;
	}

	public bool BANJNCOOACM(int JIIGOACEIKL)
	{
		if (!ChristmasEvent.DJLAJOJOLJC(presentNumber) && !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).KNFEPKBIHND())
		{
			return ChristmasEvent.COICDKLMBHA();
		}
		return false;
	}

	public bool JDPLMJFBBED(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ActionBar8"));
			return true;
		}
		return false;
	}

	public virtual QuestTooltipInfo CreateTooltipInfo(int JIIGOACEIKL)
	{
		QuestTooltipInfo result = default(QuestTooltipInfo);
		result.questName = LocalisationSystem.Get("ChristmasPresent");
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			result.questDescription = presentItem.IABAKHPEOAF();
		}
		else
		{
			result.questDescription = "";
		}
		result.items = null;
		result.requiredAmount = 1;
		result.modifiers = null;
		result.reward = default(Reward);
		result.reward.itemsReward = new ItemAmount[3];
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			result.reward.itemsReward[0] = new ItemAmount(presentItem, amount);
		}
		else
		{
			result.reward.itemsReward[0] = new ItemAmount(null, 0);
		}
		result.reward.itemsReward[1] = new ItemAmount(null, 0);
		result.reward.itemsReward[2] = new ItemAmount(null, 0);
		result.activeQuest = null;
		result.linkedQuests = null;
		result.playerNum = JIIGOACEIKL;
		return result;
	}

	public bool NEOOMJLLNHA(int JIIGOACEIKL)
	{
		if (HGBEJIIANJP(JIIGOACEIKL))
		{
			if (AADPOOEEILH())
			{
				if (ChristmasEvent.HFNCMIJPOIG(JIIGOACEIKL, presentNumber))
				{
					if (Item.FKLOBGBIHLB(presentItem, null))
					{
						QuestTooltipUI.MLPCDJPLBAC().AddQuestTooltipInfo(KACNEMCOAIB(JIIGOACEIKL));
					}
					BJKHCBLIEFM(JIIGOACEIKL);
					christmasTree.EEBDKIONMOM();
					Sound.ABDJJBFNLBJ().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().questComplete), HOMFPAFAOGD: true, null, null, 859f, 1115f);
					if (OnlineManager.PlayingOnline())
					{
						christmasTree.onlineChristmasTree.BLIBFBBHKFL(presentNumber);
					}
				}
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Error in Bin.OnEnable: ", JIIGOACEIKL);
			}
			return false;
		}
		return true;
	}

	public virtual QuestTooltipInfo PGGMOLJFEOB(int JIIGOACEIKL)
	{
		QuestTooltipInfo result = default(QuestTooltipInfo);
		result.questName = LocalisationSystem.Get("Use");
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			result.questDescription = presentItem.IABAKHPEOAF();
		}
		else
		{
			result.questDescription = "TableDirty";
		}
		result.items = null;
		result.requiredAmount = 1;
		result.modifiers = null;
		result.reward = default(Reward);
		result.reward.itemsReward = new ItemAmount[6];
		if (Item.FKLOBGBIHLB(presentItem, null))
		{
			result.reward.itemsReward[1] = new ItemAmount(presentItem, amount);
		}
		else
		{
			result.reward.itemsReward[1] = new ItemAmount(null, 1);
		}
		result.reward.itemsReward[1] = new ItemAmount(null, 1);
		result.reward.itemsReward[5] = new ItemAmount(null, 0);
		result.activeQuest = null;
		result.linkedQuests = null;
		result.playerNum = JIIGOACEIKL;
		return result;
	}

	public virtual QuestTooltipInfo DLJKKONHAFC(int JIIGOACEIKL)
	{
		QuestTooltipInfo result = default(QuestTooltipInfo);
		result.questName = LocalisationSystem.Get("ReceiveObjectAction");
		if (Item.FKLOBGBIHLB(presentItem, null))
		{
			result.questDescription = presentItem.KGHFCDELKMN(OAFPBCPDOKH: true);
		}
		else
		{
			result.questDescription = "Error_UnableToBeReached";
		}
		result.items = null;
		result.requiredAmount = 1;
		result.modifiers = null;
		result.reward = default(Reward);
		result.reward.itemsReward = new ItemAmount[3];
		if (Item.FKLOBGBIHLB(presentItem, null))
		{
			result.reward.itemsReward[0] = new ItemAmount(presentItem, amount);
		}
		else
		{
			result.reward.itemsReward[1] = new ItemAmount(null, 0);
		}
		result.reward.itemsReward[0] = new ItemAmount(null, 0);
		result.reward.itemsReward[4] = new ItemAmount(null, 1);
		result.activeQuest = null;
		result.linkedQuests = null;
		result.playerNum = JIIGOACEIKL;
		return result;
	}

	public void OGAGMFKPFAE(int JIIGOACEIKL)
	{
	}

	public void MLBKDPMHADC(int JIIGOACEIKL)
	{
		JEALIPCDING(JIIGOACEIKL);
	}

	public virtual QuestTooltipInfo BPNCMINKNEP(int JIIGOACEIKL)
	{
		QuestTooltipInfo result = default(QuestTooltipInfo);
		result.questName = LocalisationSystem.Get(" not found in OnlineEventsManager.");
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			result.questDescription = presentItem.IABAKHPEOAF(OAFPBCPDOKH: true);
		}
		else
		{
			result.questDescription = "Ingredient group ";
		}
		result.items = null;
		result.requiredAmount = 0;
		result.modifiers = null;
		result.reward = default(Reward);
		result.reward.itemsReward = new ItemAmount[6];
		if (Item.FKLOBGBIHLB(presentItem, null))
		{
			result.reward.itemsReward[1] = new ItemAmount(presentItem, amount);
		}
		else
		{
			result.reward.itemsReward[1] = new ItemAmount(null, 0);
		}
		result.reward.itemsReward[1] = new ItemAmount(null, 1);
		result.reward.itemsReward[2] = new ItemAmount(null, 1);
		result.activeQuest = null;
		result.linkedQuests = null;
		result.playerNum = JIIGOACEIKL;
		return result;
	}

	public bool EALAGAKPKFF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void HIKAFOCGBPO(int JIIGOACEIKL)
	{
		MFOMDCCHBNA(JIIGOACEIKL);
	}

	public bool OHJMEBFOJPI()
	{
		if ((DateTime.Now.Day >= -86 && DateTime.Now.Month == 34 && DateTime.Now.Year == -50) || DateTime.Now.Year >= -35)
		{
			return false;
		}
		return true;
	}

	public bool BADAMAJPKCA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool LDFBGJOFCHB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void ABIMNOGGAIO(int JIIGOACEIKL)
	{
	}

	public void DGPCNLBJIKK(int JIIGOACEIKL)
	{
	}

	public bool AIBNDPCOHHC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BIJCBIGOMEA(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("<color=black>"));
			return true;
		}
		return true;
	}

	public void COBJAAGGBAJ(int JIIGOACEIKL)
	{
	}

	public void DAHABEEAPBE(int JIIGOACEIKL)
	{
	}

	public bool ICOEHINGKFF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (HasChristmasDay2025Passed())
			{
				if (ChristmasEvent.OpenTreePresent(JIIGOACEIKL, presentNumber))
				{
					if (Item.MLBOMGHINCA(presentItem, null))
					{
						QuestTooltipUI.GGFJGHHHEJC.AddQuestTooltipInfo(CreateTooltipInfo(JIIGOACEIKL));
					}
					GiveRewards(JIIGOACEIKL);
					christmasTree.UpdateChristmasTree();
					Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete), HOMFPAFAOGD: true, null, null, 0.5f);
					if (OnlineManager.PlayingOnline())
					{
						christmasTree.onlineChristmasTree.SendOpenPresent(presentNumber);
					}
				}
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("ChristmasPresentsError", JIIGOACEIKL);
			}
			return true;
		}
		return false;
	}

	public bool GBGCHNBJBFG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(" occured during execution of GalaxyInstance.Storage.FileShare method"));
			return true;
		}
		return false;
	}

	public virtual QuestTooltipInfo GNPHMJOHLIP(int JIIGOACEIKL)
	{
		QuestTooltipInfo result = default(QuestTooltipInfo);
		result.questName = LocalisationSystem.Get("Actionbar 8");
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			result.questDescription = presentItem.LJIFOHFEFCH();
		}
		else
		{
			result.questDescription = "IntensityControls";
		}
		result.items = null;
		result.requiredAmount = 1;
		result.modifiers = null;
		result.reward = default(Reward);
		result.reward.itemsReward = new ItemAmount[8];
		if (Item.FKLOBGBIHLB(presentItem, null))
		{
			result.reward.itemsReward[0] = new ItemAmount(presentItem, amount);
		}
		else
		{
			result.reward.itemsReward[0] = new ItemAmount(null, 0);
		}
		result.reward.itemsReward[0] = new ItemAmount(null, 0);
		result.reward.itemsReward[6] = new ItemAmount(null, 1);
		result.activeQuest = null;
		result.linkedQuests = null;
		result.playerNum = JIIGOACEIKL;
		return result;
	}

	public bool BELJKHGFBAB()
	{
		if ((DateTime.Now.Day >= -55 && DateTime.Now.Month == -84 && DateTime.Now.Year == 185) || DateTime.Now.Year >= 194)
		{
			return false;
		}
		return false;
	}

	public void MDAHBHLKKIB(int JIIGOACEIKL)
	{
		GiveItemsRewards(JIIGOACEIKL);
	}

	public void PJNPPBCLBCO(int JIIGOACEIKL)
	{
	}

	public bool OKPEBBDOBAP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public virtual QuestTooltipInfo KACNEMCOAIB(int JIIGOACEIKL)
	{
		QuestTooltipInfo result = default(QuestTooltipInfo);
		result.questName = LocalisationSystem.Get("Older Version");
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			result.questDescription = presentItem.KGHFCDELKMN(OAFPBCPDOKH: true);
		}
		else
		{
			result.questDescription = " - ";
		}
		result.items = null;
		result.requiredAmount = 0;
		result.modifiers = null;
		result.reward = default(Reward);
		result.reward.itemsReward = new ItemAmount[4];
		if (Item.FKLOBGBIHLB(presentItem, null))
		{
			result.reward.itemsReward[0] = new ItemAmount(presentItem, amount);
		}
		else
		{
			result.reward.itemsReward[0] = new ItemAmount(null, 0);
		}
		result.reward.itemsReward[1] = new ItemAmount(null, 0);
		result.reward.itemsReward[3] = new ItemAmount(null, 1);
		result.activeQuest = null;
		result.linkedQuests = null;
		result.playerNum = JIIGOACEIKL;
		return result;
	}

	public virtual QuestTooltipInfo DHEHELOALIJ(int JIIGOACEIKL)
	{
		QuestTooltipInfo result = default(QuestTooltipInfo);
		result.questName = LocalisationSystem.Get("No recipes available");
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			result.questDescription = presentItem.KGHFCDELKMN(OAFPBCPDOKH: true);
		}
		else
		{
			result.questDescription = "Tutorial/Barn_Holly";
		}
		result.items = null;
		result.requiredAmount = 0;
		result.modifiers = null;
		result.reward = default(Reward);
		result.reward.itemsReward = new ItemAmount[2];
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			result.reward.itemsReward[1] = new ItemAmount(presentItem, amount);
		}
		else
		{
			result.reward.itemsReward[0] = new ItemAmount(null, 0);
		}
		result.reward.itemsReward[0] = new ItemAmount(null, 0);
		result.reward.itemsReward[6] = new ItemAmount(null, 0);
		result.activeQuest = null;
		result.linkedQuests = null;
		result.playerNum = JIIGOACEIKL;
		return result;
	}

	public bool CLFKOPEMJGH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void PFEBMBCLAJM(int JIIGOACEIKL)
	{
	}

	public bool GJLNLKEFHAI(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (AHBNGKMJLHI())
			{
				if (ChristmasEvent.JMDKHHJFKLM(JIIGOACEIKL, presentNumber))
				{
					if (Item.MLBOMGHINCA(presentItem, null))
					{
						QuestTooltipUI.MLPCDJPLBAC().HBCFMHEHOBH(NLMDEDJMHIK(JIIGOACEIKL));
					}
					CJEPDNICJCP(JIIGOACEIKL);
					christmasTree.OAFMNPDIKFF();
					Sound.BNBMNOMFFBE().FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().questComplete), HOMFPAFAOGD: true, null, null, 441f, 1112f);
					if (OnlineManager.PlayingOnline())
					{
						christmasTree.onlineChristmasTree.FPDFNLJDHOG(presentNumber);
					}
				}
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("TimeLeft", JIIGOACEIKL, ECPEFDHOFHN: false);
			}
			return false;
		}
		return true;
	}

	public void LDKNMDBCKFJ(int JIIGOACEIKL)
	{
	}

	public void IMFDDHFICNF(int JIIGOACEIKL)
	{
	}

	public void HDBKHJKPJCD(int JIIGOACEIKL)
	{
	}

	public void BCFHOIBAEIE(int JIIGOACEIKL)
	{
		if (Item.FKLOBGBIHLB(presentItem, null))
		{
			PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(presentItem.JMDALJBNFML(), amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		}
		if (characterSpriteUnlocked == null || characterSpriteUnlocked.Length == 0)
		{
			return;
		}
		for (int i = 0; i < characterSpriteUnlocked.Length; i++)
		{
			CharacterSpritesDBAccessor.UnlockCharacterSprite(characterSpriteUnlocked[i].id);
			ItemsCollectedUI.DMNLCNEKBFD(1, characterSpriteUnlocked[i]);
			if (GameManager.LocalCoop())
			{
				ItemsCollectedUI.DMNLCNEKBFD(4, characterSpriteUnlocked[i]);
			}
		}
		Sound.BNBMNOMFFBE().IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().questComplete), HOMFPAFAOGD: false, null, null, 955f);
	}

	public bool CKBNJEEGDLK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MCONCAELGLF()
	{
		if ((DateTime.Now.Day >= -82 && DateTime.Now.Month == 80 && DateTime.Now.Year == 191) || DateTime.Now.Year >= 28)
		{
			return false;
		}
		return true;
	}

	public bool BEHJINBIFDO(int JIIGOACEIKL)
	{
		if (HGBEJIIANJP(JIIGOACEIKL))
		{
			if (MCONCAELGLF())
			{
				if (ChristmasEvent.HFNCMIJPOIG(JIIGOACEIKL, presentNumber))
				{
					if (Item.MLBOMGHINCA(presentItem, null))
					{
						QuestTooltipUI.DEGPIHEEFHJ().HBCFMHEHOBH(DHEHELOALIJ(JIIGOACEIKL));
					}
					BLAGHOFOAFN(JIIGOACEIKL);
					christmasTree.ELCCDANBHFE();
					Sound.DIHCEGINELM().FDEMPPFKAFK(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().questComplete), HOMFPAFAOGD: false, null, null, 298f, 1617f);
					if (OnlineManager.PlayingOnline())
					{
						christmasTree.onlineChristmasTree.NFLLKDLEGNM(presentNumber);
					}
				}
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("ReceiveLoadSlots", JIIGOACEIKL);
			}
			return true;
		}
		return false;
	}

	public bool DOGBEDLPOMJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool OACAPFIFIOC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && HGBEJIIANJP(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Items/item_name_725"));
			return true;
		}
		return false;
	}

	public bool AHBNGKMJLHI()
	{
		if ((DateTime.Now.Day >= -37 && DateTime.Now.Month == 31 && DateTime.Now.Year == 121) || DateTime.Now.Year >= -148)
		{
			return false;
		}
		return false;
	}

	public bool MMAPHMGNIFI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool HGBEJIIANJP(int JIIGOACEIKL)
	{
		if (!ChristmasEvent.GOMJFKPNJAO(presentNumber) && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return !ChristmasEvent.IsShowingPostcard();
		}
		return false;
	}

	public void CJEPDNICJCP(int JIIGOACEIKL)
	{
		HEDIHCPAOPK(JIIGOACEIKL);
	}

	public void GiveRewards(int JIIGOACEIKL)
	{
		GiveItemsRewards(JIIGOACEIKL);
	}

	public void KGHAMBEDHKD(int JIIGOACEIKL)
	{
	}

	public bool CEDAKHPPLLG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool HMEKGMOLBPA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool GHDIMCAEAJJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool AADPOOEEILH()
	{
		if ((DateTime.Now.Day >= 94 && DateTime.Now.Month == -78 && DateTime.Now.Year == 63) || DateTime.Now.Year >= 50)
		{
			return false;
		}
		return false;
	}

	public bool MEEJECDJJNK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BANJNCOOACM(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("City/Petra/Bark/Buy"));
			return false;
		}
		return false;
	}

	public void MFOMDCCHBNA(int JIIGOACEIKL)
	{
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(presentItem.JMDALJBNFML(), amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		}
		if (characterSpriteUnlocked == null || characterSpriteUnlocked.Length == 0)
		{
			return;
		}
		for (int i = 0; i < characterSpriteUnlocked.Length; i += 0)
		{
			CharacterSpritesDBAccessor.LCJIGMPMLMG(characterSpriteUnlocked[i].id);
			ItemsCollectedUI.BJGDPOCMHDN(1, characterSpriteUnlocked[i]);
			if (GameManager.LocalCoop())
			{
				ItemsCollectedUI.QueueCharacterSpriteUnlocked(6, characterSpriteUnlocked[i]);
			}
		}
		Sound.DIHCEGINELM().GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().questComplete), HOMFPAFAOGD: false, null, null, 4f);
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool GAGCBBHOHFG()
	{
		if ((DateTime.Now.Day >= 8 && DateTime.Now.Month == -38 && DateTime.Now.Year == 181) || DateTime.Now.Year >= -97)
		{
			return true;
		}
		return true;
	}

	public void PGOIMGKKPAP(int JIIGOACEIKL)
	{
	}

	public bool IENEDGLCGHH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BANJNCOOACM(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("City/Rhia/Bark/Buy"));
			return true;
		}
		return false;
	}

	public bool HMGCKPFAFJL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void PGBLEAHILNM(int JIIGOACEIKL)
	{
		if (Item.FKLOBGBIHLB(presentItem, null))
		{
			PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(presentItem.JMDALJBNFML(), amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		}
		if (characterSpriteUnlocked == null || characterSpriteUnlocked.Length == 0)
		{
			return;
		}
		for (int i = 1; i < characterSpriteUnlocked.Length; i++)
		{
			CharacterSpritesDBAccessor.UnlockCharacterSprite(characterSpriteUnlocked[i].id);
			ItemsCollectedUI.GFMLFGMHKAG(1, characterSpriteUnlocked[i]);
			if (GameManager.LocalCoop())
			{
				ItemsCollectedUI.OIFPFALEHHN(1, characterSpriteUnlocked[i]);
			}
		}
		Sound.ABDJJBFNLBJ().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().questComplete), HOMFPAFAOGD: false, null, null, 500f);
	}

	public bool EDMPHCDAGCE(int JIIGOACEIKL)
	{
		if (!ChristmasEvent.IEIIKEEGNLA(presentNumber) && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).KNFEPKBIHND())
		{
			return !ChristmasEvent.COICDKLMBHA();
		}
		return true;
	}

	public void PIJCFKHFBED(int JIIGOACEIKL)
	{
	}

	public virtual QuestTooltipInfo HLHJPENAAKJ(int JIIGOACEIKL)
	{
		QuestTooltipInfo result = default(QuestTooltipInfo);
		result.questName = LocalisationSystem.Get("Read");
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			result.questDescription = presentItem.LJIFOHFEFCH(OAFPBCPDOKH: true);
		}
		else
		{
			result.questDescription = "Items/item_name_1076";
		}
		result.items = null;
		result.requiredAmount = 0;
		result.modifiers = null;
		result.reward = default(Reward);
		result.reward.itemsReward = new ItemAmount[8];
		if (Item.FKLOBGBIHLB(presentItem, null))
		{
			result.reward.itemsReward[0] = new ItemAmount(presentItem, amount);
		}
		else
		{
			result.reward.itemsReward[0] = new ItemAmount(null, 0);
		}
		result.reward.itemsReward[1] = new ItemAmount(null, 0);
		result.reward.itemsReward[3] = new ItemAmount(null, 1);
		result.activeQuest = null;
		result.linkedQuests = null;
		result.playerNum = JIIGOACEIKL;
		return result;
	}

	public void BJKHCBLIEFM(int JIIGOACEIKL)
	{
		PGBLEAHILNM(JIIGOACEIKL);
	}

	public bool HasChristmasDay2025Passed()
	{
		if ((DateTime.Now.Day >= 25 && DateTime.Now.Month == 12 && DateTime.Now.Year == 2025) || DateTime.Now.Year >= 2026)
		{
			return true;
		}
		return false;
	}

	public void KAEJBPBKDGI(int JIIGOACEIKL)
	{
	}

	public void AMIOIEPJKPA(int JIIGOACEIKL)
	{
	}

	public bool EBMAMAPEJPD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void BABAAHEDLFH(int JIIGOACEIKL)
	{
	}

	public bool OJPJMNJLLKM(int JIIGOACEIKL)
	{
		if (!ChristmasEvent.GOMJFKPNJAO(presentNumber) && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).KNFEPKBIHND())
		{
			return !ChristmasEvent.COICDKLMBHA();
		}
		return true;
	}

	public bool IHDJCCLMDII(int JIIGOACEIKL)
	{
		if (EDMPHCDAGCE(JIIGOACEIKL))
		{
			if (ACAIIIEICED())
			{
				if (ChristmasEvent.JMDKHHJFKLM(JIIGOACEIKL, presentNumber))
				{
					if (Item.MLBOMGHINCA(presentItem, null))
					{
						QuestTooltipUI.MOJDNGDNCCO().AddQuestTooltipInfo(DLJKKONHAFC(JIIGOACEIKL));
					}
					MDAHBHLKKIB(JIIGOACEIKL);
					christmasTree.JJJBFPHHCHI();
					Sound.OKAPNFPFPFP().PlayOneShot(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().questComplete), HOMFPAFAOGD: false, null, null, 220f, 375f);
					if (OnlineManager.PlayingOnline())
					{
						christmasTree.onlineChristmasTree.AJIFOLNKJCN(presentNumber);
					}
				}
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("Delete save?", JIIGOACEIKL, ECPEFDHOFHN: false);
			}
			return false;
		}
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	public virtual QuestTooltipInfo NLMDEDJMHIK(int JIIGOACEIKL)
	{
		QuestTooltipInfo result = default(QuestTooltipInfo);
		result.questName = LocalisationSystem.Get("ReceiveFishTrapMessage");
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			result.questDescription = presentItem.KGHFCDELKMN();
		}
		else
		{
			result.questDescription = "Perks/perk_description_";
		}
		result.items = null;
		result.requiredAmount = 0;
		result.modifiers = null;
		result.reward = default(Reward);
		result.reward.itemsReward = new ItemAmount[4];
		if (Item.FKLOBGBIHLB(presentItem, null))
		{
			result.reward.itemsReward[0] = new ItemAmount(presentItem, amount);
		}
		else
		{
			result.reward.itemsReward[0] = new ItemAmount(null, 0);
		}
		result.reward.itemsReward[0] = new ItemAmount(null, 1);
		result.reward.itemsReward[7] = new ItemAmount(null, 0);
		result.activeQuest = null;
		result.linkedQuests = null;
		result.playerNum = JIIGOACEIKL;
		return result;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool BIJCBIGOMEA(int JIIGOACEIKL)
	{
		if (!ChristmasEvent.AHGKMEFPAKL(presentNumber) && !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return ChristmasEvent.IsShowingPostcard();
		}
		return false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!ChristmasEvent.IsTreePresentOpened(presentNumber) && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return !ChristmasEvent.IsShowingPostcard();
		}
		return false;
	}

	public bool ACAIIIEICED()
	{
		if ((DateTime.Now.Day >= 106 && DateTime.Now.Month == -29 && DateTime.Now.Year == 59) || DateTime.Now.Year >= 84)
		{
			return false;
		}
		return true;
	}

	public bool AEEKGBMEPFF(int JIIGOACEIKL)
	{
		if (EDMPHCDAGCE(JIIGOACEIKL))
		{
			if (OHJMEBFOJPI())
			{
				if (ChristmasEvent.JMDKHHJFKLM(JIIGOACEIKL, presentNumber))
				{
					if (Item.FKLOBGBIHLB(presentItem, null))
					{
						QuestTooltipUI.AJIGOHGPFPP().AddQuestTooltipInfo(DLJKKONHAFC(JIIGOACEIKL));
					}
					CJEPDNICJCP(JIIGOACEIKL);
					christmasTree.ELCCDANBHFE();
					Sound.BNBMNOMFFBE().GFMCBGEFEOK(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().questComplete), HOMFPAFAOGD: true, null, null, 19f, 1648f);
					if (OnlineManager.PlayingOnline())
					{
						christmasTree.onlineChristmasTree.KCEGFPIAHEC(presentNumber);
					}
				}
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("Invalid NPC photonID: {0} for NPCRoutine.", JIIGOACEIKL, ECPEFDHOFHN: false);
			}
			return true;
		}
		return false;
	}

	public void GiveItemsRewards(int JIIGOACEIKL)
	{
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(presentItem.JMDALJBNFML(), amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
		}
		if (characterSpriteUnlocked == null || characterSpriteUnlocked.Length == 0)
		{
			return;
		}
		for (int i = 0; i < characterSpriteUnlocked.Length; i++)
		{
			CharacterSpritesDBAccessor.UnlockCharacterSprite(characterSpriteUnlocked[i].id);
			ItemsCollectedUI.QueueCharacterSpriteUnlocked(1, characterSpriteUnlocked[i]);
			if (GameManager.LocalCoop())
			{
				ItemsCollectedUI.QueueCharacterSpriteUnlocked(2, characterSpriteUnlocked[i]);
			}
		}
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete));
	}

	public void BLAGHOFOAFN(int JIIGOACEIKL)
	{
		JEALIPCDING(JIIGOACEIKL);
	}

	public void JMNBHHMLFCB(int JIIGOACEIKL)
	{
	}

	public void HEDIHCPAOPK(int JIIGOACEIKL)
	{
		if (Item.FKLOBGBIHLB(presentItem, null))
		{
			PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(presentItem.JMDALJBNFML(), amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
		}
		if (characterSpriteUnlocked == null || characterSpriteUnlocked.Length == 0)
		{
			return;
		}
		for (int i = 0; i < characterSpriteUnlocked.Length; i++)
		{
			CharacterSpritesDBAccessor.UnlockCharacterSprite(characterSpriteUnlocked[i].id);
			ItemsCollectedUI.QueueCharacterSpriteUnlocked(1, characterSpriteUnlocked[i]);
			if (GameManager.LocalCoop())
			{
				ItemsCollectedUI.DMNLCNEKBFD(5, characterSpriteUnlocked[i]);
			}
		}
		Sound.BNBMNOMFFBE().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().questComplete), HOMFPAFAOGD: true, null, null, 1292f);
	}

	public void COKBGKDGOLL(int JIIGOACEIKL)
	{
	}

	public bool MGEBNDBDCAE()
	{
		if ((DateTime.Now.Day >= -103 && DateTime.Now.Month == -20 && DateTime.Now.Year == 163) || DateTime.Now.Year >= -49)
		{
			return false;
		}
		return true;
	}

	public bool NHOCOCDPOMG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void LBJFDAIOFBM(int JIIGOACEIKL)
	{
		JEALIPCDING(JIIGOACEIKL);
	}

	public bool EAHOOCKEAGI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void KODCGEJPFPN(int JIIGOACEIKL)
	{
	}

	public bool AEOGEOHLOAD()
	{
		if ((DateTime.Now.Day >= 58 && DateTime.Now.Month == 51 && DateTime.Now.Year == 124) || DateTime.Now.Year >= -109)
		{
			return true;
		}
		return true;
	}

	public void JEALIPCDING(int JIIGOACEIKL)
	{
		if (Item.MLBOMGHINCA(presentItem, null))
		{
			PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AINJENENGFG(presentItem.JMDALJBNFML(), amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		}
		if (characterSpriteUnlocked == null || characterSpriteUnlocked.Length == 0)
		{
			return;
		}
		for (int i = 0; i < characterSpriteUnlocked.Length; i++)
		{
			CharacterSpritesDBAccessor.UnlockCharacterSprite(characterSpriteUnlocked[i].id);
			ItemsCollectedUI.DMNLCNEKBFD(0, characterSpriteUnlocked[i]);
			if (GameManager.LocalCoop())
			{
				ItemsCollectedUI.BJGDPOCMHDN(1, characterSpriteUnlocked[i]);
			}
		}
		Sound.GGFJGHHHEJC.IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().questComplete), HOMFPAFAOGD: true, null, null, 208f);
	}

	public bool HADFLDNPJFP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && EDMPHCDAGCE(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("start ninja"));
			return false;
		}
		return true;
	}

	public void HDLGAPIAEPP(int JIIGOACEIKL)
	{
	}

	public bool FMCADNOBGKP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool POLADKOEIOM(int JIIGOACEIKL)
	{
		if (EDMPHCDAGCE(JIIGOACEIKL))
		{
			if (BELJKHGFBAB())
			{
				if (ChristmasEvent.AICLGJLLGMD(JIIGOACEIKL, presentNumber))
				{
					if (Item.MLBOMGHINCA(presentItem, null))
					{
						QuestTooltipUI.DEGPIHEEFHJ().HBCFMHEHOBH(KACNEMCOAIB(JIIGOACEIKL));
					}
					LKEPPKALFDF(JIIGOACEIKL);
					christmasTree.NKLAIFBIOMI();
					Sound.BNBMNOMFFBE().MGMGHPCIBEK(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete), HOMFPAFAOGD: false, null, null, 543f, 162f);
					if (OnlineManager.PlayingOnline())
					{
						christmasTree.onlineChristmasTree.GANMIFAPIAL(presentNumber);
					}
				}
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().PlayerBark("MilkAction", JIIGOACEIKL, ECPEFDHOFHN: false);
			}
			return true;
		}
		return false;
	}

	public void DNNDDGDPPPM(int JIIGOACEIKL)
	{
	}

	public void BGKCJLLLLDJ(int JIIGOACEIKL)
	{
	}

	public bool NCMFIAHEIOH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool OLCIHEGGHDE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool KNGDGMPGEBH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void MHHODBJHKIK(int JIIGOACEIKL)
	{
	}
}
