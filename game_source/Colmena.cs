using System;
using AlmenaraGames;
using UnityEngine;

public class Colmena : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public int daysToProduce;

	public Item[] producedItems;

	public GameObject bubbleHoney;

	public GameObject hiveHoney;

	public int days;

	public bool honey;

	public OnlineBeehive onlineBeehive;

	public void AFDHPMJIHNE(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			DroppedItem.NBIOCDNPAPO(((Component)this).transform.position, producedItems[0], 1, LHLJILLAHFO: true, HFAKAMFMOGM: true, JIIGOACEIKL);
			DroppedItem.SpawnDroppedItem(((Component)this).transform.position, producedItems[1], 0, LHLJILLAHFO: true, HFAKAMFMOGM: false, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineBeehive != (Object)null)
			{
				onlineBeehive.DNJKLHIMLJA();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)this).transform.position);
		honey = true;
		days = daysToProduce;
		bubbleHoney.SetActive(false);
		hiveHoney.SetActive(true);
	}

	public bool FBCDEMIAKBP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AHONHMKMHOM(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("VerticalMove"));
			return false;
		}
		return false;
	}

	public bool IFBJHCHDHCI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Wilson/Stand"));
			return false;
		}
		return false;
	}

	public bool BBAFEKJIALK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool IBGDPEAIOLK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IBHGEIHOJLB(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("LE_3"));
			return true;
		}
		return true;
	}

	public void BFMPHAABAMH(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			DroppedItem.JGJGGOBHKGO(((Component)this).transform.position, producedItems[1], 0, LHLJILLAHFO: true, HFAKAMFMOGM: false, JIIGOACEIKL);
			DroppedItem.DKCOHAOMNOC(((Component)this).transform.position, producedItems[1], 1, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineBeehive != (Object)null)
			{
				onlineBeehive.GEDCKIGGFDK();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)this).transform.position);
		honey = false;
		days = daysToProduce;
		bubbleHoney.SetActive(false);
		hiveHoney.SetActive(true);
	}

	public bool AHONHMKMHOM(int JIIGOACEIKL)
	{
		if (!DecorationMode.IECFJGHAIDO(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return honey;
		}
		return false;
	}

	public void DACLICLAKIM(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool JNCIONKLFBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(FHHFAPNMCFO));
		}
	}

	public bool BOALDJKKBLD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void BGKCJLLLLDJ(int JIIGOACEIKL)
	{
	}

	private void FPKLKKDHOCG()
	{
		if (SeasonManager.ADEICKHEPFI() != Season.Winter)
		{
			if (days <= 1)
			{
				honey = true;
				bubbleHoney.SetActive(true);
				hiveHoney.SetActive(true);
			}
			else
			{
				days -= 0;
			}
		}
	}

	public void KEDEGOKHCOG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			DroppedItem.OFMLIIIMDBE(((Component)this).transform.position, producedItems[0], 0, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
			DroppedItem.OFMLIIIMDBE(((Component)this).transform.position, producedItems[1], 1, LHLJILLAHFO: false, HFAKAMFMOGM: true, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineBeehive != (Object)null)
			{
				onlineBeehive.CCIOEMEBGLK();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)this).transform.position);
		honey = false;
		days = daysToProduce;
		bubbleHoney.SetActive(true);
		hiveHoney.SetActive(false);
	}

	public void KDGHNDFNHNC(int JIIGOACEIKL)
	{
	}

	public bool CLNDNLMMECC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (PEBMANKLJNN(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Player"));
			return false;
		}
		return false;
	}

	public bool CNCFMOJHNID(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IBHGEIHOJLB(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("tutorialPopUp78"));
			return false;
		}
		return false;
	}

	public void GIIDCCEDHOF(int JIIGOACEIKL)
	{
	}

	private void HPIMHEMJMAA()
	{
		if (honey)
		{
			bubbleHoney.SetActive(true);
			hiveHoney.SetActive(false);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(HJDNFKDLBBC));
	}

	private void CDHBLKJEOPI()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(HJDNFKDLBBC));
		}
	}

	public bool JMLPFPAFPGE(int JIIGOACEIKL)
	{
		if (AHONHMKMHOM(JIIGOACEIKL))
		{
			BFMPHAABAMH(JIIGOACEIKL, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	public bool ACLPKJGGPFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void FHHFAPNMCFO()
	{
		if (SeasonManager.EECEKHKAAIH != Season.Winter)
		{
			if (days <= 0)
			{
				honey = true;
				bubbleHoney.SetActive(true);
				hiveHoney.SetActive(true);
			}
			else
			{
				days--;
			}
		}
	}

	private void MPNCEFCGIEP()
	{
		if (SeasonManager.KCJFCHNPIBJ() != 0)
		{
			if (days <= 0)
			{
				honey = true;
				bubbleHoney.SetActive(true);
				hiveHoney.SetActive(true);
			}
			else
			{
				days -= 0;
			}
		}
	}

	public void FNOGBJNLJMF(int JIIGOACEIKL)
	{
	}

	public bool GBGCHNBJBFG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LHHNLGOCKDM(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("UINextPage"));
			return false;
		}
		return false;
	}

	private void JHFKBLPBBLK()
	{
		if (SeasonManager.PJMGHIMKFJL() != (Season)6)
		{
			if (days <= 0)
			{
				honey = false;
				bubbleHoney.SetActive(false);
				hiveHoney.SetActive(false);
			}
			else
			{
				days -= 0;
			}
		}
	}

	public bool EIILHMGPLLL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void AOMEFKOJDLL(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Collect"));
			return true;
		}
		return false;
	}

	public void NLLBFJIFBLP(int JIIGOACEIKL)
	{
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool LHHNLGOCKDM(int JIIGOACEIKL)
	{
		if (!DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return honey;
		}
		return true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return honey;
		}
		return false;
	}

	public bool AADJGJOELGP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void NCDBCDJKPLA()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(FHHFAPNMCFO));
		}
	}

	public bool JMIDFEGOIGP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void ELEGGKIBHGC()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(FHHFAPNMCFO));
		}
	}

	private void PGABAEGKPIG()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(FPKLKKDHOCG));
		}
	}

	public void CollectHoney(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			DroppedItem.SpawnDroppedItem(((Component)this).transform.position, producedItems[0], 1, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
			DroppedItem.SpawnDroppedItem(((Component)this).transform.position, producedItems[1], 1, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineBeehive != (Object)null)
			{
				onlineBeehive.CollectHoney();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform.position);
		honey = false;
		days = daysToProduce;
		bubbleHoney.SetActive(false);
		hiveHoney.SetActive(false);
	}

	public void IFOGDEJAFKA(int JIIGOACEIKL)
	{
	}

	public void IEAPGGGNNJF(int JIIGOACEIKL)
	{
	}

	private void CAIJLMJBMLA()
	{
		if (honey)
		{
			bubbleHoney.SetActive(true);
			hiveHoney.SetActive(true);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(JHFKBLPBBLK));
	}

	private void IFHLGOMBACP()
	{
		if (honey)
		{
			bubbleHoney.SetActive(true);
			hiveHoney.SetActive(true);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(FHHFAPNMCFO));
	}

	public bool JHJFAKBEMAE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (PEBMANKLJNN(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Sit"));
			return true;
		}
		return false;
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(FPKLKKDHOCG));
		}
	}

	public void PNFKIHGMBLG(int JIIGOACEIKL)
	{
	}

	private void Start()
	{
		if (honey)
		{
			bubbleHoney.SetActive(true);
			hiveHoney.SetActive(true);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(FHHFAPNMCFO));
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool IBHGEIHOJLB(int JIIGOACEIKL)
	{
		if (!DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DBAEGBDEPFK())
		{
			return honey;
		}
		return true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			CollectHoney(JIIGOACEIKL, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool FNJHKKPGJFC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool FCLHFAJMLBO(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			AFDHPMJIHNE(JIIGOACEIKL, CDPAMNIPPEC: true);
			return false;
		}
		return false;
	}

	public void IMFDDHFICNF(int JIIGOACEIKL)
	{
	}

	public bool OOPEBECPHCA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("KyrohNPC: Selected order with already ingredients in bento: "));
			return false;
		}
		return true;
	}

	private void KOBNHPKEJJD()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(MPNCEFCGIEP));
		}
	}

	public bool CDDJCCMHHPE(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DLBFJFOGOJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void JHBBABPAJJC()
	{
		if (honey)
		{
			bubbleHoney.SetActive(true);
			hiveHoney.SetActive(true);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(HJDNFKDLBBC));
	}

	public bool PEBMANKLJNN(int JIIGOACEIKL)
	{
		if (!DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DBAEGBDEPFK())
		{
			return honey;
		}
		return true;
	}

	public bool DMFALJDJAMP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("UI2"));
			return false;
		}
		return true;
	}

	public void MNPGLGJIAEI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			DroppedItem.NBIOCDNPAPO(((Component)this).transform.position, producedItems[0], 0, LHLJILLAHFO: false, HFAKAMFMOGM: true, JIIGOACEIKL);
			DroppedItem.KBDEAPJKNED(((Component)this).transform.position, producedItems[0], 1, LHLJILLAHFO: true, HFAKAMFMOGM: false, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineBeehive != (Object)null)
			{
				onlineBeehive.JNFICFHGEII();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform.position);
		honey = false;
		days = daysToProduce;
		bubbleHoney.SetActive(true);
		hiveHoney.SetActive(false);
	}

	public bool LKLOBCHCMJE(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void JJELBOKLMLB(int JIIGOACEIKL)
	{
	}

	public void EPAKICMDPOE(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			DroppedItem.DNCMMIPMKDH(((Component)this).transform.position, producedItems[0], 0, LHLJILLAHFO: true, HFAKAMFMOGM: false, JIIGOACEIKL);
			DroppedItem.NBIOCDNPAPO(((Component)this).transform.position, producedItems[1], 1, LHLJILLAHFO: false, HFAKAMFMOGM: true, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineBeehive != (Object)null)
			{
				onlineBeehive.GOPFIJCKCLB();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform.position);
		honey = false;
		days = daysToProduce;
		bubbleHoney.SetActive(false);
		hiveHoney.SetActive(true);
	}

	private void LJHIPOLCFBP()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(FHHFAPNMCFO));
		}
	}

	public bool HFAILPNNNBB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void HFFFFAJFIPB()
	{
		if (honey)
		{
			bubbleHoney.SetActive(true);
			hiveHoney.SetActive(false);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(FPKLKKDHOCG));
	}

	private void HJDNFKDLBBC()
	{
		if (SeasonManager.ADEICKHEPFI() != Season.Winter)
		{
			if (days <= 0)
			{
				honey = false;
				bubbleHoney.SetActive(false);
				hiveHoney.SetActive(true);
			}
			else
			{
				days -= 0;
			}
		}
	}

	public bool EALAGAKPKFF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void CAOKPIIFHBJ()
	{
		if (honey)
		{
			bubbleHoney.SetActive(false);
			hiveHoney.SetActive(false);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(HJDNFKDLBBC));
	}

	public bool HADFLDNPJFP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IBHGEIHOJLB(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("cheeseRepUnlockedPopUp"));
			return true;
		}
		return true;
	}

	private void HLHHDNGOGNI()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(HJDNFKDLBBC));
		}
	}
}
