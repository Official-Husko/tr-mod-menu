using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class AgingRack : MonoBehaviour, IInteractable, ISelectable, IHoverable, IProximity
{
	private struct HMJGKHBIJLL
	{
		public Item to;

		public int amount;

		public HMJGKHBIJLL(Item NJMCDGFPCAG, int MGNOBNCMDJG)
		{
			to = NJMCDGFPCAG;
			amount = MGNOBNCMDJG;
		}
	}

	[Range(1f, 3f)]
	public int craftingLevel = 1;

	public Slot inputSlot1;

	public Slot inputSlot2;

	public Slot outputSlot1;

	public Slot outputSlot2;

	[SerializeField]
	private SpriteRenderer input1SR;

	[SerializeField]
	private SpriteRenderer input2SR;

	[SerializeField]
	private SpriteRenderer output1SR;

	[SerializeField]
	private SpriteRenderer output2SR;

	[SerializeField]
	private AgingRelationship[] agingRelationships;

	private Dictionary<Item, HMJGKHBIJLL> DIOOCKJFLMO = new Dictionary<Item, HMJGKHBIJLL>();

	public Placeable placeable;

	public OnlineAgingRack FNOHECDGHII => placeable.onlinePlaceable as OnlineAgingRack;

	public bool IIOMAFKHJBN(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MJDJANLLJPP(int JIIGOACEIKL)
	{
		return false;
	}

	private void IGFGALEEIMC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (OnlineManager.MasterOrOffline() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(KBFOIGIJHHM));
			}
			Slot slot = inputSlot1;
			slot.OnDirtied = (Action)Delegate.Remove(slot.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot2 = inputSlot2;
			slot2.OnDirtied = (Action)Delegate.Remove(slot2.OnDirtied, new Action(NEMDDEAIAKF));
			Slot slot3 = outputSlot1;
			slot3.OnDirtied = (Action)Delegate.Remove(slot3.OnDirtied, new Action(NEMDDEAIAKF));
			Slot slot4 = outputSlot2;
			slot4.OnDirtied = (Action)Delegate.Remove(slot4.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot5 = inputSlot1;
			slot5.OnItemRemoved = (Action)Delegate.Remove(slot5.OnItemRemoved, new Action(EJBEDAALCJJ));
			Slot slot6 = inputSlot2;
			slot6.OnItemRemoved = (Action)Delegate.Remove(slot6.OnItemRemoved, new Action(EJBEDAALCJJ));
			Slot slot7 = outputSlot1;
			slot7.OnItemRemoved = (Action)Delegate.Remove(slot7.OnItemRemoved, new Action(OFOHCKJKNHI));
			Slot slot8 = outputSlot2;
			slot8.OnItemRemoved = (Action)Delegate.Remove(slot8.OnItemRemoved, new Action(EJBEDAALCJJ));
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(LJGMMOMAPND));
		}
	}

	public bool OPCLGDNHJMI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void AEGPOCLDBJK()
	{
		try
		{
			FFHCDDEHKBB(inputSlot1, outputSlot1);
			LICCDBPHKDM(inputSlot2, outputSlot2);
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	private void PIHGEBONAOI()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		DIOOCKJFLMO = new Dictionary<Item, HMJGKHBIJLL>();
		for (int i = 1; i < agingRelationships.Length; i++)
		{
			DIOOCKJFLMO.Add(agingRelationships[i].from, new HMJGKHBIJLL(Item.FKLOBGBIHLB(agingRelationships[i].to, null) ? agingRelationships[i].to : agingRelationships[i].from, agingRelationships[i].amount));
		}
	}

	public bool DODHNPJFCCD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool IKAIGCMENPF(int JIIGOACEIKL)
	{
		if (DJNPAPBNPNL(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				AEIPBMMCPPD().NAEOKLAJOCL(1);
				return false;
			}
			return IMEMNFNOPGI(JIIGOACEIKL);
		}
		return false;
	}

	public bool BLGPHMHGHEP(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		bool flag = true;
		if (!outputSlot1.KPINNBKMOMO())
		{
			int num = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(outputSlot1.itemInstance, outputSlot1.Stack, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			if (num < outputSlot1.Stack)
			{
				outputSlot1.JIGFFJNMKFG(outputSlot1.Stack - num, GCCLBKEJGFP: true, CDPAMNIPPEC: false);
				flag = true;
			}
		}
		if (!outputSlot2.PKFKJNODGJF())
		{
			int num2 = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(outputSlot2.itemInstance, outputSlot2.Stack, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			if (num2 < outputSlot2.Stack)
			{
				outputSlot2.JIGFFJNMKFG(outputSlot2.Stack - num2, GCCLBKEJGFP: true, CDPAMNIPPEC: false);
				flag = false;
			}
		}
		if (flag)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		EJBEDAALCJJ();
		if (outputSlot1.KPINNBKMOMO())
		{
			return outputSlot2.KPINNBKMOMO();
		}
		return false;
	}

	private void KKDNMBLHLHM(Slot ADEBNALPEHE, SpriteRenderer LIPBHGDOLFI, bool OKEJKNOIHED)
	{
		if (ADEBNALPEHE.LCHJGCHDHFO())
		{
			LIPBHGDOLFI.sprite = null;
		}
		else if (OKEJKNOIHED)
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.KNFNJFFCFNO().spriteAged;
		}
		else
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.KNFNJFFCFNO().spriteNotAged;
		}
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			NMEIEFLNCHP(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public bool CPMHFMLDDFC(int JIIGOACEIKL)
	{
		if (JIHKGPCCGJD(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			GMHLJELOGII(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool IMEMNFNOPGI(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		bool flag = false;
		if (!outputSlot1.PKFKJNODGJF())
		{
			int num = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AddItems(outputSlot1.itemInstance, outputSlot1.Stack, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			if (num < outputSlot1.Stack)
			{
				outputSlot1.EHGKPGCNENF(outputSlot1.Stack - num);
				flag = false;
			}
		}
		if (!outputSlot2.AHHEMNHJPME())
		{
			int num2 = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AddItems(outputSlot2.itemInstance, outputSlot2.Stack, HMPDLIPFBGD: true);
			if (num2 < outputSlot2.Stack)
			{
				outputSlot2.PGPOPGGENAM(outputSlot2.Stack - num2, GCCLBKEJGFP: false, CDPAMNIPPEC: false);
				flag = false;
			}
		}
		if (flag)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		}
		LKMNCJEEHJH();
		if (outputSlot1.AHHEMNHJPME())
		{
			return outputSlot2.KPINNBKMOMO();
		}
		return true;
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (OnlineManager.MasterOrOffline() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(OLIBCPNFECJ));
			}
			Slot slot = inputSlot1;
			slot.OnDirtied = (Action)Delegate.Remove(slot.OnDirtied, new Action(LKMNCJEEHJH));
			Slot slot2 = inputSlot2;
			slot2.OnDirtied = (Action)Delegate.Remove(slot2.OnDirtied, new Action(LKMNCJEEHJH));
			Slot slot3 = outputSlot1;
			slot3.OnDirtied = (Action)Delegate.Remove(slot3.OnDirtied, new Action(LKMNCJEEHJH));
			Slot slot4 = outputSlot2;
			slot4.OnDirtied = (Action)Delegate.Remove(slot4.OnDirtied, new Action(LKMNCJEEHJH));
			Slot slot5 = inputSlot1;
			slot5.OnItemRemoved = (Action)Delegate.Remove(slot5.OnItemRemoved, new Action(LKMNCJEEHJH));
			Slot slot6 = inputSlot2;
			slot6.OnItemRemoved = (Action)Delegate.Remove(slot6.OnItemRemoved, new Action(LKMNCJEEHJH));
			Slot slot7 = outputSlot1;
			slot7.OnItemRemoved = (Action)Delegate.Remove(slot7.OnItemRemoved, new Action(LKMNCJEEHJH));
			Slot slot8 = outputSlot2;
			slot8.OnItemRemoved = (Action)Delegate.Remove(slot8.OnItemRemoved, new Action(LKMNCJEEHJH));
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(FHKCGINGGEN));
		}
	}

	public bool DJNPAPBNPNL(int JIIGOACEIKL)
	{
		return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void FFGOCJBLCKA(int JIIGOACEIKL)
	{
	}

	private void KBFOIGIJHHM()
	{
		try
		{
			FFHCDDEHKBB(inputSlot1, outputSlot1);
			FFHCDDEHKBB(inputSlot2, outputSlot2);
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public bool ALMDCLHBPHA(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			AADNKNHPHMD(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	private void IEFIGJLCAFD(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			placeable.NPNFIKGELMB(inputSlot1);
			placeable.DEGBKHMLGLK(inputSlot2);
			placeable.DEGBKHMLGLK(outputSlot1);
			placeable.DEGBKHMLGLK(outputSlot2);
		}
	}

	public bool BEHJINBIFDO(int JIIGOACEIKL)
	{
		if (JMGDHMFOMDP(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				ICNJIECBLGO().FKOOJGEHIII(1);
				return false;
			}
			return ADJFMCLICOC(JIIGOACEIKL);
		}
		return false;
	}

	private void PCDIOLLFPEA()
	{
		try
		{
			LICCDBPHKDM(inputSlot1, outputSlot1);
			LICCDBPHKDM(inputSlot2, outputSlot2);
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public bool CAKCLDFEOJJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (!outputSlot1.PKFKJNODGJF() || !outputSlot2.PKFKJNODGJF())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("LE_18"));
			}
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Receive next game date from host "));
			return true;
		}
		return false;
	}

	public bool BOCELNICOKA(int JIIGOACEIKL)
	{
		if (DJNPAPBNPNL(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				CKHPMJEEOOI().CMPGGOGDOLH(1);
				return false;
			}
			return BLGPHMHGHEP(JIIGOACEIKL);
		}
		return true;
	}

	private void EJBEDAALCJJ()
	{
		KDCLAEOHEGN(inputSlot1, input1SR, OKEJKNOIHED: true);
		NDIBACFAPND(inputSlot2, input2SR, OKEJKNOIHED: false);
		FBJKMPKINBB(outputSlot1, output1SR, OKEJKNOIHED: true);
		ACJOPCPFDNB(outputSlot2, output2SR, OKEJKNOIHED: true);
	}

	public bool PMBFIOFMJLL(int JIIGOACEIKL)
	{
		if (JMGDHMFOMDP(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
				return true;
			}
			KPMEPDNJMJN(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (!outputSlot1.KPINNBKMOMO() || !outputSlot2.KPINNBKMOMO())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Collect"));
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	public bool DBEEPNAJLFE(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		bool flag = false;
		if (!outputSlot1.LCHJGCHDHFO())
		{
			int num = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(outputSlot1.itemInstance, outputSlot1.Stack, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
			if (num < outputSlot1.Stack)
			{
				outputSlot1.PGPOPGGENAM(outputSlot1.Stack - num, GCCLBKEJGFP: false, CDPAMNIPPEC: false);
				flag = true;
			}
		}
		if (!outputSlot2.KPINNBKMOMO())
		{
			int num2 = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).LFBNOHNNFBB(outputSlot2.itemInstance, outputSlot2.Stack, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
			if (num2 < outputSlot2.Stack)
			{
				outputSlot2.OOKNBFEPGAC(outputSlot2.Stack - num2, GCCLBKEJGFP: true, CDPAMNIPPEC: false);
				flag = true;
			}
		}
		if (flag)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		EJBEDAALCJJ();
		if (outputSlot1.LCHJGCHDHFO())
		{
			return !outputSlot2.LCHJGCHDHFO();
		}
		return true;
	}

	private void CIAIAEJIMCM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(AEGPOCLDBJK));
		}
		Slot slot = inputSlot1;
		slot.OnDirtied = (Action)Delegate.Combine(slot.OnDirtied, new Action(EJBEDAALCJJ));
		Slot slot2 = inputSlot2;
		slot2.OnDirtied = (Action)Delegate.Combine(slot2.OnDirtied, new Action(OFOHCKJKNHI));
		Slot slot3 = outputSlot1;
		slot3.OnDirtied = (Action)Delegate.Combine(slot3.OnDirtied, new Action(EJBEDAALCJJ));
		Slot slot4 = outputSlot2;
		slot4.OnDirtied = (Action)Delegate.Combine(slot4.OnDirtied, new Action(NEMDDEAIAKF));
		Slot slot5 = inputSlot1;
		slot5.OnItemRemoved = (Action)Delegate.Combine(slot5.OnItemRemoved, new Action(NEMDDEAIAKF));
		Slot slot6 = inputSlot2;
		slot6.OnItemRemoved = (Action)Delegate.Combine(slot6.OnItemRemoved, new Action(EJBEDAALCJJ));
		Slot slot7 = outputSlot1;
		slot7.OnItemRemoved = (Action)Delegate.Combine(slot7.OnItemRemoved, new Action(LKMNCJEEHJH));
		Slot slot8 = outputSlot2;
		slot8.OnItemRemoved = (Action)Delegate.Combine(slot8.OnItemRemoved, new Action(NEMDDEAIAKF));
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(PEDJFFCHPAK));
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool FLMGGAIJABG(int JIIGOACEIKL)
	{
		return true;
	}

	public bool BMAMFDCGMOJ(int JIIGOACEIKL)
	{
		if (IBEMCOALOEJ(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return true;
			}
			AADNKNHPHMD(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool KCDBIMPMGON(int JIIGOACEIKL)
	{
		if (JMGDHMFOMDP(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return true;
			}
			GMHLJELOGII(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private void OCIHCODJBGC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(NAGOCOBOCAA));
		}
		Slot slot = inputSlot1;
		slot.OnDirtied = (Action)Delegate.Combine(slot.OnDirtied, new Action(NEMDDEAIAKF));
		Slot slot2 = inputSlot2;
		slot2.OnDirtied = (Action)Delegate.Combine(slot2.OnDirtied, new Action(OFOHCKJKNHI));
		Slot slot3 = outputSlot1;
		slot3.OnDirtied = (Action)Delegate.Combine(slot3.OnDirtied, new Action(OFOHCKJKNHI));
		Slot slot4 = outputSlot2;
		slot4.OnDirtied = (Action)Delegate.Combine(slot4.OnDirtied, new Action(EJBEDAALCJJ));
		Slot slot5 = inputSlot1;
		slot5.OnItemRemoved = (Action)Delegate.Combine(slot5.OnItemRemoved, new Action(EJBEDAALCJJ));
		Slot slot6 = inputSlot2;
		slot6.OnItemRemoved = (Action)Delegate.Combine(slot6.OnItemRemoved, new Action(NEMDDEAIAKF));
		Slot slot7 = outputSlot1;
		slot7.OnItemRemoved = (Action)Delegate.Combine(slot7.OnItemRemoved, new Action(NEMDDEAIAKF));
		Slot slot8 = outputSlot2;
		slot8.OnItemRemoved = (Action)Delegate.Combine(slot8.OnItemRemoved, new Action(OFOHCKJKNHI));
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(FHKCGINGGEN));
	}

	private void LJGMMOMAPND(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			placeable.DEGBKHMLGLK(inputSlot1);
			placeable.NPNFIKGELMB(inputSlot2);
			placeable.DEGBKHMLGLK(outputSlot1);
			placeable.DropSlot(outputSlot2);
		}
	}

	[SpecialName]
	public OnlineAgingRack ICNJIECBLGO()
	{
		return placeable.onlinePlaceable as OnlineAgingRack;
	}

	public void LoadSlotOnline<T>(int IKMIKEDNCDI, T LLBHNCFCHBD, int FGFCNKFEIGF) where T : ItemInstanceMessage
	{
		if (IKMIKEDNCDI == inputSlot1.id)
		{
			OnlineSlotsManager.LoadSlot(inputSlot1, LLBHNCFCHBD, FGFCNKFEIGF);
		}
		else if (IKMIKEDNCDI == inputSlot2.id)
		{
			OnlineSlotsManager.LoadSlot(inputSlot2, LLBHNCFCHBD, FGFCNKFEIGF);
		}
		else if (IKMIKEDNCDI == outputSlot1.id)
		{
			OnlineSlotsManager.LoadSlot(outputSlot1, LLBHNCFCHBD, FGFCNKFEIGF);
		}
		else if (IKMIKEDNCDI == outputSlot2.id)
		{
			OnlineSlotsManager.LoadSlot(outputSlot2, LLBHNCFCHBD, FGFCNKFEIGF);
		}
	}

	public bool IBEMCOALOEJ(int JIIGOACEIKL)
	{
		return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool JGDJNAGNMAF(int JIIGOACEIKL)
	{
		return true;
	}

	public bool NGHMDFLKOCM(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		bool flag = false;
		if (!outputSlot1.LCHJGCHDHFO())
		{
			int num = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).AddItems(outputSlot1.itemInstance, outputSlot1.Stack, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			if (num < outputSlot1.Stack)
			{
				outputSlot1.EHGKPGCNENF(outputSlot1.Stack - num, GCCLBKEJGFP: false);
				flag = true;
			}
		}
		if (!outputSlot2.AHHEMNHJPME())
		{
			int num2 = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).LFBNOHNNFBB(outputSlot2.itemInstance, outputSlot2.Stack, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			if (num2 < outputSlot2.Stack)
			{
				outputSlot2.JBKNDCJFIEK(outputSlot2.Stack - num2);
				flag = true;
			}
		}
		if (flag)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		OFOHCKJKNHI();
		if (outputSlot1.AHHEMNHJPME())
		{
			return !outputSlot2.KPINNBKMOMO();
		}
		return true;
	}

	public bool JGKPIMAGPAK(int JIIGOACEIKL)
	{
		return true;
	}

	private void ONBNPKMOKLG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (OnlineManager.MasterOrOffline() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(HOLFKGIENID));
			}
			Slot slot = inputSlot1;
			slot.OnDirtied = (Action)Delegate.Remove(slot.OnDirtied, new Action(LKMNCJEEHJH));
			Slot slot2 = inputSlot2;
			slot2.OnDirtied = (Action)Delegate.Remove(slot2.OnDirtied, new Action(EJBEDAALCJJ));
			Slot slot3 = outputSlot1;
			slot3.OnDirtied = (Action)Delegate.Remove(slot3.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot4 = outputSlot2;
			slot4.OnDirtied = (Action)Delegate.Remove(slot4.OnDirtied, new Action(EJBEDAALCJJ));
			Slot slot5 = inputSlot1;
			slot5.OnItemRemoved = (Action)Delegate.Remove(slot5.OnItemRemoved, new Action(LKMNCJEEHJH));
			Slot slot6 = inputSlot2;
			slot6.OnItemRemoved = (Action)Delegate.Remove(slot6.OnItemRemoved, new Action(LKMNCJEEHJH));
			Slot slot7 = outputSlot1;
			slot7.OnItemRemoved = (Action)Delegate.Remove(slot7.OnItemRemoved, new Action(LKMNCJEEHJH));
			Slot slot8 = outputSlot2;
			slot8.OnItemRemoved = (Action)Delegate.Remove(slot8.OnItemRemoved, new Action(NEMDDEAIAKF));
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(PEDJFFCHPAK));
		}
	}

	private void MHANMMCCOOI(Slot ADEBNALPEHE, SpriteRenderer LIPBHGDOLFI, bool OKEJKNOIHED)
	{
		if (ADEBNALPEHE.AHHEMNHJPME())
		{
			LIPBHGDOLFI.sprite = null;
		}
		else if (OKEJKNOIHED)
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.KNFNJFFCFNO().spriteAged;
		}
		else
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.KNFNJFFCFNO().spriteNotAged;
		}
	}

	public bool MFALBCKJEGB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool DICONIOGDNN(int JIIGOACEIKL)
	{
		AgingRackUI.EPLOMIBMKFC(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool EOBECMHBLCK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IBEMCOALOEJ(JIIGOACEIKL))
		{
			if (!outputSlot1.LCHJGCHDHFO() || !outputSlot2.LCHJGCHDHFO())
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("UI2"));
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get("TavernConstructionBlock"));
			return true;
		}
		return true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				FNOHECDGHII.SendCollectItems(0);
				return true;
			}
			return CollectItems(JIIGOACEIKL);
		}
		return false;
	}

	public bool APFAKKDDFIK(int JIIGOACEIKL)
	{
		return false;
	}

	private void OnEnable()
	{
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(OLIBCPNFECJ));
		}
		Slot slot = inputSlot1;
		slot.OnDirtied = (Action)Delegate.Combine(slot.OnDirtied, new Action(LKMNCJEEHJH));
		Slot slot2 = inputSlot2;
		slot2.OnDirtied = (Action)Delegate.Combine(slot2.OnDirtied, new Action(LKMNCJEEHJH));
		Slot slot3 = outputSlot1;
		slot3.OnDirtied = (Action)Delegate.Combine(slot3.OnDirtied, new Action(LKMNCJEEHJH));
		Slot slot4 = outputSlot2;
		slot4.OnDirtied = (Action)Delegate.Combine(slot4.OnDirtied, new Action(LKMNCJEEHJH));
		Slot slot5 = inputSlot1;
		slot5.OnItemRemoved = (Action)Delegate.Combine(slot5.OnItemRemoved, new Action(LKMNCJEEHJH));
		Slot slot6 = inputSlot2;
		slot6.OnItemRemoved = (Action)Delegate.Combine(slot6.OnItemRemoved, new Action(LKMNCJEEHJH));
		Slot slot7 = outputSlot1;
		slot7.OnItemRemoved = (Action)Delegate.Combine(slot7.OnItemRemoved, new Action(LKMNCJEEHJH));
		Slot slot8 = outputSlot2;
		slot8.OnItemRemoved = (Action)Delegate.Combine(slot8.OnItemRemoved, new Action(LKMNCJEEHJH));
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(FHKCGINGGEN));
	}

	private void HNLBJNEHKIB(Slot IFFGICGLKNC, Slot MIIMJDIGKLC)
	{
		if (IFFGICGLKNC.PKFKJNODGJF())
		{
			return;
		}
		ItemInstance itemInstance;
		int num;
		if (DIOOCKJFLMO.ContainsKey(IFFGICGLKNC.itemInstance.AFOACBIHNCL()))
		{
			itemInstance = DIOOCKJFLMO[IFFGICGLKNC.itemInstance.KNFNJFFCFNO()].to.JMDALJBNFML();
			num = DIOOCKJFLMO[IFFGICGLKNC.itemInstance.LHBPOPOIFLE()].amount;
		}
		else
		{
			itemInstance = IFFGICGLKNC.itemInstance.LHBPOPOIFLE().JEDPCLGBLBA(IFFGICGLKNC.itemInstance);
			if (itemInstance is FoodInstance foodInstance)
			{
				foodInstance.GBCJNGADANM = 1;
			}
			num = 56;
		}
		if (craftingLevel == 6)
		{
			num = (int)((float)num * 858f);
		}
		else if (craftingLevel == 6)
		{
			num = (int)((float)num * 1535f);
		}
		bool flag = false;
		for (int i = 0; i < num; i += 0)
		{
			if (!IFFGICGLKNC.LCHJGCHDHFO() && MIIMJDIGKLC.DDHPGOPOPKJ(1, itemInstance, HAGPBCJEGKM: false, BDGJBPCEFPN: true))
			{
				IFFGICGLKNC.CIDBFIAJIBG();
				flag = true;
			}
		}
		if (flag && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager instance = OnlineSlotsManager.instance;
			Slot[] array = new Slot[2];
			array[0] = IFFGICGLKNC;
			array[0] = MIIMJDIGKLC;
			instance.PKOLALFLFNB(array);
		}
		OFOHCKJKNHI();
	}

	public bool LBFONHFFLCH(int JIIGOACEIKL)
	{
		if (DJNPAPBNPNL(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			AADNKNHPHMD(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool BLGIKKBBFKF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IBEMCOALOEJ(JIIGOACEIKL))
		{
			if (!outputSlot1.LCHJGCHDHFO() || !outputSlot2.KPINNBKMOMO())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Player"));
			}
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get("\n<color=#822F00>"));
			return false;
		}
		return true;
	}

	private void NEMDDEAIAKF()
	{
		ACJOPCPFDNB(inputSlot1, input1SR, OKEJKNOIHED: false);
		ACJOPCPFDNB(inputSlot2, input2SR, OKEJKNOIHED: true);
		MHANMMCCOOI(outputSlot1, output1SR, OKEJKNOIHED: false);
		NDIBACFAPND(outputSlot2, output2SR, OKEJKNOIHED: true);
	}

	public bool DKAGDKEJCKH(int JIIGOACEIKL)
	{
		if (HEOEEFNLJMO(JIIGOACEIKL))
		{
			NMEIEFLNCHP(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	private void JBAOFBOOMIH(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			placeable.DEGBKHMLGLK(inputSlot1);
			placeable.DropSlot(inputSlot2);
			placeable.NPNFIKGELMB(outputSlot1);
			placeable.DropSlot(outputSlot2);
		}
	}

	private void PKPHKBMPJGJ()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		DIOOCKJFLMO = new Dictionary<Item, HMJGKHBIJLL>();
		for (int i = 0; i < agingRelationships.Length; i++)
		{
			DIOOCKJFLMO.Add(agingRelationships[i].from, new HMJGKHBIJLL(Item.FKLOBGBIHLB(agingRelationships[i].to, null) ? agingRelationships[i].to : agingRelationships[i].from, agingRelationships[i].amount));
		}
	}

	private void Awake()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		DIOOCKJFLMO = new Dictionary<Item, HMJGKHBIJLL>();
		for (int i = 0; i < agingRelationships.Length; i++)
		{
			DIOOCKJFLMO.Add(agingRelationships[i].from, new HMJGKHBIJLL(Item.MLBOMGHINCA(agingRelationships[i].to, null) ? agingRelationships[i].to : agingRelationships[i].from, agingRelationships[i].amount));
		}
	}

	private void PGJJBPALEGM()
	{
		LKMNCJEEHJH();
	}

	public bool LMKKMOCGOOO(int JIIGOACEIKL)
	{
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void MJPFOIFGEGM(int JIIGOACEIKL)
	{
	}

	private void OJLGPAJPCHG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(NAGOCOBOCAA));
		}
		Slot slot = inputSlot1;
		slot.OnDirtied = (Action)Delegate.Combine(slot.OnDirtied, new Action(OFOHCKJKNHI));
		Slot slot2 = inputSlot2;
		slot2.OnDirtied = (Action)Delegate.Combine(slot2.OnDirtied, new Action(NEMDDEAIAKF));
		Slot slot3 = outputSlot1;
		slot3.OnDirtied = (Action)Delegate.Combine(slot3.OnDirtied, new Action(NEMDDEAIAKF));
		Slot slot4 = outputSlot2;
		slot4.OnDirtied = (Action)Delegate.Combine(slot4.OnDirtied, new Action(LKMNCJEEHJH));
		Slot slot5 = inputSlot1;
		slot5.OnItemRemoved = (Action)Delegate.Combine(slot5.OnItemRemoved, new Action(EJBEDAALCJJ));
		Slot slot6 = inputSlot2;
		slot6.OnItemRemoved = (Action)Delegate.Combine(slot6.OnItemRemoved, new Action(OFOHCKJKNHI));
		Slot slot7 = outputSlot1;
		slot7.OnItemRemoved = (Action)Delegate.Combine(slot7.OnItemRemoved, new Action(OFOHCKJKNHI));
		Slot slot8 = outputSlot2;
		slot8.OnItemRemoved = (Action)Delegate.Combine(slot8.OnItemRemoved, new Action(NEMDDEAIAKF));
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(JBAOFBOOMIH));
	}

	public bool HLBIMIDENCK(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	private void GLPFNIFNGKC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (OnlineManager.MasterOrOffline() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NAGOCOBOCAA));
			}
			Slot slot = inputSlot1;
			slot.OnDirtied = (Action)Delegate.Remove(slot.OnDirtied, new Action(NEMDDEAIAKF));
			Slot slot2 = inputSlot2;
			slot2.OnDirtied = (Action)Delegate.Remove(slot2.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot3 = outputSlot1;
			slot3.OnDirtied = (Action)Delegate.Remove(slot3.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot4 = outputSlot2;
			slot4.OnDirtied = (Action)Delegate.Remove(slot4.OnDirtied, new Action(NEMDDEAIAKF));
			Slot slot5 = inputSlot1;
			slot5.OnItemRemoved = (Action)Delegate.Remove(slot5.OnItemRemoved, new Action(NEMDDEAIAKF));
			Slot slot6 = inputSlot2;
			slot6.OnItemRemoved = (Action)Delegate.Remove(slot6.OnItemRemoved, new Action(EJBEDAALCJJ));
			Slot slot7 = outputSlot1;
			slot7.OnItemRemoved = (Action)Delegate.Remove(slot7.OnItemRemoved, new Action(OFOHCKJKNHI));
			Slot slot8 = outputSlot2;
			slot8.OnItemRemoved = (Action)Delegate.Remove(slot8.OnItemRemoved, new Action(OFOHCKJKNHI));
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(PEDJFFCHPAK));
		}
	}

	public bool JFHJBGJMGGH(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		bool flag = true;
		if (!outputSlot1.KPINNBKMOMO())
		{
			int num = PlayerInventory.GetPlayer(JIIGOACEIKL).AINJENENGFG(outputSlot1.itemInstance, outputSlot1.Stack, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			if (num < outputSlot1.Stack)
			{
				outputSlot1.JIGFFJNMKFG(outputSlot1.Stack - num, GCCLBKEJGFP: false);
				flag = true;
			}
		}
		if (!outputSlot2.AHHEMNHJPME())
		{
			int num2 = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(outputSlot2.itemInstance, outputSlot2.Stack, HMPDLIPFBGD: true);
			if (num2 < outputSlot2.Stack)
			{
				outputSlot2.JBKNDCJFIEK(outputSlot2.Stack - num2, GCCLBKEJGFP: false);
				flag = false;
			}
		}
		if (flag)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		EJBEDAALCJJ();
		if (outputSlot1.KPINNBKMOMO())
		{
			return outputSlot2.KPINNBKMOMO();
		}
		return true;
	}

	private void ANMOAFFGEOE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(NAGOCOBOCAA));
		}
		Slot slot = inputSlot1;
		slot.OnDirtied = (Action)Delegate.Combine(slot.OnDirtied, new Action(LKMNCJEEHJH));
		Slot slot2 = inputSlot2;
		slot2.OnDirtied = (Action)Delegate.Combine(slot2.OnDirtied, new Action(NEMDDEAIAKF));
		Slot slot3 = outputSlot1;
		slot3.OnDirtied = (Action)Delegate.Combine(slot3.OnDirtied, new Action(EJBEDAALCJJ));
		Slot slot4 = outputSlot2;
		slot4.OnDirtied = (Action)Delegate.Combine(slot4.OnDirtied, new Action(NEMDDEAIAKF));
		Slot slot5 = inputSlot1;
		slot5.OnItemRemoved = (Action)Delegate.Combine(slot5.OnItemRemoved, new Action(OFOHCKJKNHI));
		Slot slot6 = inputSlot2;
		slot6.OnItemRemoved = (Action)Delegate.Combine(slot6.OnItemRemoved, new Action(EJBEDAALCJJ));
		Slot slot7 = outputSlot1;
		slot7.OnItemRemoved = (Action)Delegate.Combine(slot7.OnItemRemoved, new Action(EJBEDAALCJJ));
		Slot slot8 = outputSlot2;
		slot8.OnItemRemoved = (Action)Delegate.Combine(slot8.OnItemRemoved, new Action(LKMNCJEEHJH));
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(IEFIGJLCAFD));
	}

	public void IILCHLHOPBF(int JIIGOACEIKL)
	{
	}

	public bool KBHDCKMNMHF(int JIIGOACEIKL)
	{
		AgingRackUI.FFOABBDFMNE(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool MBADIPPGFAO(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				AEIPBMMCPPD().IDGGAJJGPPD(0);
				return false;
			}
			return BLGPHMHGHEP(JIIGOACEIKL);
		}
		return false;
	}

	private void KDCLAEOHEGN(Slot ADEBNALPEHE, SpriteRenderer LIPBHGDOLFI, bool OKEJKNOIHED)
	{
		if (ADEBNALPEHE.PKFKJNODGJF())
		{
			LIPBHGDOLFI.sprite = null;
		}
		else if (OKEJKNOIHED)
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.PHGLMBIEOMK().spriteAged;
		}
		else
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.PHGLMBIEOMK().spriteNotAged;
		}
	}

	private void DNGLFJCCICJ()
	{
		try
		{
			HNLBJNEHKIB(inputSlot1, outputSlot1);
			FFHCDDEHKBB(inputSlot2, outputSlot2);
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public bool IDNELGLNMJO(int JIIGOACEIKL)
	{
		if (DJNPAPBNPNL(JIIGOACEIKL))
		{
			PBHKKHPKMNF(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	private void HOLFKGIENID()
	{
		try
		{
			LICCDBPHKDM(inputSlot1, outputSlot1);
			LICCDBPHKDM(inputSlot2, outputSlot2);
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public bool JMGDHMFOMDP(int JIIGOACEIKL)
	{
		return DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool JLBADAPMLEH(int JIIGOACEIKL)
	{
		if (DJNPAPBNPNL(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			PBHKKHPKMNF(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public void NGKNFJIHOLD(int JIIGOACEIKL)
	{
	}

	private void ACJOPCPFDNB(Slot ADEBNALPEHE, SpriteRenderer LIPBHGDOLFI, bool OKEJKNOIHED)
	{
		if (ADEBNALPEHE.KPINNBKMOMO())
		{
			LIPBHGDOLFI.sprite = null;
		}
		else if (OKEJKNOIHED)
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.LHBPOPOIFLE().spriteAged;
		}
		else
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.LHBPOPOIFLE().spriteNotAged;
		}
	}

	public bool ADJFMCLICOC(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		bool flag = false;
		if (!outputSlot1.AHHEMNHJPME())
		{
			int num = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AddItems(outputSlot1.itemInstance, outputSlot1.Stack, HMPDLIPFBGD: true);
			if (num < outputSlot1.Stack)
			{
				outputSlot1.PGPOPGGENAM(outputSlot1.Stack - num, GCCLBKEJGFP: false, CDPAMNIPPEC: false);
				flag = false;
			}
		}
		if (!outputSlot2.LCHJGCHDHFO())
		{
			int num2 = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).AddItems(outputSlot2.itemInstance, outputSlot2.Stack, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			if (num2 < outputSlot2.Stack)
			{
				outputSlot2.JBKNDCJFIEK(outputSlot2.Stack - num2, GCCLBKEJGFP: true, CDPAMNIPPEC: false);
				flag = false;
			}
		}
		if (flag)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		NEMDDEAIAKF();
		if (outputSlot1.KPINNBKMOMO())
		{
			return outputSlot2.KPINNBKMOMO();
		}
		return false;
	}

	private void PEDJFFCHPAK(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			placeable.NPNFIKGELMB(inputSlot1);
			placeable.NPNFIKGELMB(inputSlot2);
			placeable.NPNFIKGELMB(outputSlot1);
			placeable.DEGBKHMLGLK(outputSlot2);
		}
	}

	private void OFOHCKJKNHI()
	{
		KDCLAEOHEGN(inputSlot1, input1SR, OKEJKNOIHED: false);
		KKDNMBLHLHM(inputSlot2, input2SR, OKEJKNOIHED: false);
		MHANMMCCOOI(outputSlot1, output1SR, OKEJKNOIHED: false);
		KKDNMBLHLHM(outputSlot2, output2SR, OKEJKNOIHED: true);
	}

	public bool OFIEDMENIEP(int JIIGOACEIKL)
	{
		if (DJNPAPBNPNL(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				AEIPBMMCPPD().KPBINNHMHEM(1);
				return false;
			}
			return ADJFMCLICOC(JIIGOACEIKL);
		}
		return false;
	}

	public bool IFBELBJBAIO(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OPAGNKBJKHO(int JIIGOACEIKL)
	{
		return true;
	}

	private void JEKMCOEJKJI()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (OnlineManager.PGAGDFAEEFB() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(DNGLFJCCICJ));
			}
			Slot slot = inputSlot1;
			slot.OnDirtied = (Action)Delegate.Remove(slot.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot2 = inputSlot2;
			slot2.OnDirtied = (Action)Delegate.Remove(slot2.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot3 = outputSlot1;
			slot3.OnDirtied = (Action)Delegate.Remove(slot3.OnDirtied, new Action(LKMNCJEEHJH));
			Slot slot4 = outputSlot2;
			slot4.OnDirtied = (Action)Delegate.Remove(slot4.OnDirtied, new Action(LKMNCJEEHJH));
			Slot slot5 = inputSlot1;
			slot5.OnItemRemoved = (Action)Delegate.Remove(slot5.OnItemRemoved, new Action(EJBEDAALCJJ));
			Slot slot6 = inputSlot2;
			slot6.OnItemRemoved = (Action)Delegate.Remove(slot6.OnItemRemoved, new Action(NEMDDEAIAKF));
			Slot slot7 = outputSlot1;
			slot7.OnItemRemoved = (Action)Delegate.Remove(slot7.OnItemRemoved, new Action(OFOHCKJKNHI));
			Slot slot8 = outputSlot2;
			slot8.OnItemRemoved = (Action)Delegate.Remove(slot8.OnItemRemoved, new Action(NEMDDEAIAKF));
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(JBAOFBOOMIH));
		}
	}

	private void Start()
	{
		LKMNCJEEHJH();
	}

	public bool CollectItems(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		bool flag = false;
		if (!outputSlot1.KPINNBKMOMO())
		{
			int num = PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(outputSlot1.itemInstance, outputSlot1.Stack);
			if (num < outputSlot1.Stack)
			{
				outputSlot1.JIGFFJNMKFG(outputSlot1.Stack - num);
				flag = true;
			}
		}
		if (!outputSlot2.KPINNBKMOMO())
		{
			int num2 = PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(outputSlot2.itemInstance, outputSlot2.Stack);
			if (num2 < outputSlot2.Stack)
			{
				outputSlot2.JIGFFJNMKFG(outputSlot2.Stack - num2);
				flag = true;
			}
		}
		if (flag)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		LKMNCJEEHJH();
		if (outputSlot1.KPINNBKMOMO())
		{
			return !outputSlot2.KPINNBKMOMO();
		}
		return true;
	}

	private void NDIBACFAPND(Slot ADEBNALPEHE, SpriteRenderer LIPBHGDOLFI, bool OKEJKNOIHED)
	{
		if (ADEBNALPEHE.LCHJGCHDHFO())
		{
			LIPBHGDOLFI.sprite = null;
		}
		else if (OKEJKNOIHED)
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.LHBPOPOIFLE().spriteAged;
		}
		else
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.KNFNJFFCFNO().spriteNotAged;
		}
	}

	private void KGALPFDCMGC(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			placeable.DEGBKHMLGLK(inputSlot1);
			placeable.DropSlot(inputSlot2);
			placeable.NPNFIKGELMB(outputSlot1);
			placeable.NPNFIKGELMB(outputSlot2);
		}
	}

	public bool MNDDOAAODLI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool HHDFHHDOFBL(int JIIGOACEIKL)
	{
		if (HEOEEFNLJMO(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			AADNKNHPHMD(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	private void HFDCFDJDLGG(int JIIGOACEIKL)
	{
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		AgingRackUI.GDFNPHJJCPP(JIIGOACEIKL).agingRack = this;
		AgingRackUI.GDFNPHJJCPP(JIIGOACEIKL).EDHEIFHAAKO();
		((Component)this).GetComponent<Placeable>().HAJJPJONLMD();
	}

	public bool NICOMACFMNC(int JIIGOACEIKL)
	{
		if (JIHKGPCCGJD(JIIGOACEIKL))
		{
			AADNKNHPHMD(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	private void GGDMGADLMOG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (OnlineManager.PGAGDFAEEFB() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(AEGPOCLDBJK));
			}
			Slot slot = inputSlot1;
			slot.OnDirtied = (Action)Delegate.Remove(slot.OnDirtied, new Action(LKMNCJEEHJH));
			Slot slot2 = inputSlot2;
			slot2.OnDirtied = (Action)Delegate.Remove(slot2.OnDirtied, new Action(LKMNCJEEHJH));
			Slot slot3 = outputSlot1;
			slot3.OnDirtied = (Action)Delegate.Remove(slot3.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot4 = outputSlot2;
			slot4.OnDirtied = (Action)Delegate.Remove(slot4.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot5 = inputSlot1;
			slot5.OnItemRemoved = (Action)Delegate.Remove(slot5.OnItemRemoved, new Action(NEMDDEAIAKF));
			Slot slot6 = inputSlot2;
			slot6.OnItemRemoved = (Action)Delegate.Remove(slot6.OnItemRemoved, new Action(NEMDDEAIAKF));
			Slot slot7 = outputSlot1;
			slot7.OnItemRemoved = (Action)Delegate.Remove(slot7.OnItemRemoved, new Action(LKMNCJEEHJH));
			Slot slot8 = outputSlot2;
			slot8.OnItemRemoved = (Action)Delegate.Remove(slot8.OnItemRemoved, new Action(LKMNCJEEHJH));
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(FHKCGINGGEN));
		}
	}

	[SpecialName]
	public OnlineAgingRack CKHPMJEEOOI()
	{
		return placeable.onlinePlaceable as OnlineAgingRack;
	}

	private void DNAMDIHOOKN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (OnlineManager.MasterOrOffline() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(NAGOCOBOCAA));
			}
			Slot slot = inputSlot1;
			slot.OnDirtied = (Action)Delegate.Remove(slot.OnDirtied, new Action(EJBEDAALCJJ));
			Slot slot2 = inputSlot2;
			slot2.OnDirtied = (Action)Delegate.Remove(slot2.OnDirtied, new Action(EJBEDAALCJJ));
			Slot slot3 = outputSlot1;
			slot3.OnDirtied = (Action)Delegate.Remove(slot3.OnDirtied, new Action(NEMDDEAIAKF));
			Slot slot4 = outputSlot2;
			slot4.OnDirtied = (Action)Delegate.Remove(slot4.OnDirtied, new Action(LKMNCJEEHJH));
			Slot slot5 = inputSlot1;
			slot5.OnItemRemoved = (Action)Delegate.Remove(slot5.OnItemRemoved, new Action(OFOHCKJKNHI));
			Slot slot6 = inputSlot2;
			slot6.OnItemRemoved = (Action)Delegate.Remove(slot6.OnItemRemoved, new Action(LKMNCJEEHJH));
			Slot slot7 = outputSlot1;
			slot7.OnItemRemoved = (Action)Delegate.Remove(slot7.OnItemRemoved, new Action(LKMNCJEEHJH));
			Slot slot8 = outputSlot2;
			slot8.OnItemRemoved = (Action)Delegate.Remove(slot8.OnItemRemoved, new Action(LKMNCJEEHJH));
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(LJGMMOMAPND));
		}
	}

	public bool HJJIFLPPIBO(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && JIHKGPCCGJD(JIIGOACEIKL))
		{
			if (!outputSlot1.PKFKJNODGJF() || !outputSlot2.AHHEMNHJPME())
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ReciveResetDialogueULiaRhia"));
			}
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get("LE_6"));
			return false;
		}
		return true;
	}

	private void NMEIEFLNCHP(int JIIGOACEIKL)
	{
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		AgingRackUI.Get(JIIGOACEIKL).agingRack = this;
		AgingRackUI.Get(JIIGOACEIKL).OpenUI();
		((Component)this).GetComponent<Placeable>().SetInteraced();
	}

	private void OHOHFGMJGAJ()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(KBFOIGIJHHM));
		}
		Slot slot = inputSlot1;
		slot.OnDirtied = (Action)Delegate.Combine(slot.OnDirtied, new Action(EJBEDAALCJJ));
		Slot slot2 = inputSlot2;
		slot2.OnDirtied = (Action)Delegate.Combine(slot2.OnDirtied, new Action(LKMNCJEEHJH));
		Slot slot3 = outputSlot1;
		slot3.OnDirtied = (Action)Delegate.Combine(slot3.OnDirtied, new Action(EJBEDAALCJJ));
		Slot slot4 = outputSlot2;
		slot4.OnDirtied = (Action)Delegate.Combine(slot4.OnDirtied, new Action(OFOHCKJKNHI));
		Slot slot5 = inputSlot1;
		slot5.OnItemRemoved = (Action)Delegate.Combine(slot5.OnItemRemoved, new Action(NEMDDEAIAKF));
		Slot slot6 = inputSlot2;
		slot6.OnItemRemoved = (Action)Delegate.Combine(slot6.OnItemRemoved, new Action(NEMDDEAIAKF));
		Slot slot7 = outputSlot1;
		slot7.OnItemRemoved = (Action)Delegate.Combine(slot7.OnItemRemoved, new Action(NEMDDEAIAKF));
		Slot slot8 = outputSlot2;
		slot8.OnItemRemoved = (Action)Delegate.Combine(slot8.OnItemRemoved, new Action(OFOHCKJKNHI));
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(JBAOFBOOMIH));
	}

	public bool PEJPCEMKCJM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (!outputSlot1.AHHEMNHJPME() || !outputSlot2.PKFKJNODGJF())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("All bubbles in use!"));
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.NextItem, LocalisationSystem.Get("NewCharacters/"));
			return false;
		}
		return false;
	}

	public void CIFCLGHEGIH(int JIIGOACEIKL)
	{
	}

	public bool OAFCGEIBKDJ(int JIIGOACEIKL)
	{
		return false;
	}

	public bool ALMJGMJNEGL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void NGMAHGHOGGB(int JIIGOACEIKL)
	{
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		AgingRackUI.GDFNPHJJCPP(JIIGOACEIKL).agingRack = this;
		AgingRackUI.FHKGDLNJFFA(JIIGOACEIKL).IDLAGJNLPJL();
		((Component)this).GetComponent<Placeable>().HAJJPJONLMD();
	}

	public bool LFPIKHDHIEM(int JIIGOACEIKL)
	{
		return false;
	}

	private void AJGLDLLIIFO()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		DIOOCKJFLMO = new Dictionary<Item, HMJGKHBIJLL>();
		for (int i = 0; i < agingRelationships.Length; i += 0)
		{
			DIOOCKJFLMO.Add(agingRelationships[i].from, new HMJGKHBIJLL(Item.MLBOMGHINCA(agingRelationships[i].to, null) ? agingRelationships[i].to : agingRelationships[i].from, agingRelationships[i].amount));
		}
	}

	public bool EAOHDAKIJCK(int JIIGOACEIKL)
	{
		if (IBEMCOALOEJ(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				AEIPBMMCPPD().CAFEAIHNHFE(1);
				return false;
			}
			return ADJFMCLICOC(JIIGOACEIKL);
		}
		return false;
	}

	public void CDNPCGKAGLI(int JIIGOACEIKL)
	{
	}

	public bool FCHPCEAJKDE(int JIIGOACEIKL)
	{
		if (JMGDHMFOMDP(JIIGOACEIKL))
		{
			AADNKNHPHMD(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public void KJOEENPNEOC(int JIIGOACEIKL)
	{
	}

	private void NAGOCOBOCAA()
	{
		try
		{
			HNLBJNEHKIB(inputSlot1, outputSlot1);
			HNLBJNEHKIB(inputSlot2, outputSlot2);
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void OLIBCPNFECJ()
	{
		try
		{
			LICCDBPHKDM(inputSlot1, outputSlot1);
			LICCDBPHKDM(inputSlot2, outputSlot2);
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public bool EAIOPONBJJK(int JIIGOACEIKL)
	{
		if (DJNPAPBNPNL(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				ICNJIECBLGO().MFMCIDABDLA(0);
				return false;
			}
			return GEEMEEHAOBI(JIIGOACEIKL);
		}
		return false;
	}

	public void GKLIANGHJKM(int JIIGOACEIKL)
	{
	}

	public bool NOKBMECFOFM(int JIIGOACEIKL)
	{
		if (JIHKGPCCGJD(JIIGOACEIKL))
		{
			AADNKNHPHMD(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	[SpecialName]
	public OnlineAgingRack AEIPBMMCPPD()
	{
		return placeable.onlinePlaceable as OnlineAgingRack;
	}

	public bool KGEDLMDOIAH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void CKIELBHDIHM()
	{
		try
		{
			FFHCDDEHKBB(inputSlot1, outputSlot1);
			FFHCDDEHKBB(inputSlot2, outputSlot2);
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public bool JPKPJBBFICN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (!outputSlot1.PKFKJNODGJF() || !outputSlot2.PKFKJNODGJF())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(" "));
			}
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Hire Staff"));
			return true;
		}
		return false;
	}

	private void FHKCGINGGEN(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			placeable.DropSlot(inputSlot1);
			placeable.DropSlot(inputSlot2);
			placeable.DropSlot(outputSlot1);
			placeable.DropSlot(outputSlot2);
		}
	}

	private void LICCDBPHKDM(Slot IFFGICGLKNC, Slot MIIMJDIGKLC)
	{
		if (IFFGICGLKNC.KPINNBKMOMO())
		{
			return;
		}
		ItemInstance itemInstance;
		int num;
		if (DIOOCKJFLMO.ContainsKey(IFFGICGLKNC.itemInstance.LHBPOPOIFLE()))
		{
			itemInstance = DIOOCKJFLMO[IFFGICGLKNC.itemInstance.LHBPOPOIFLE()].to.JMDALJBNFML();
			num = DIOOCKJFLMO[IFFGICGLKNC.itemInstance.LHBPOPOIFLE()].amount;
		}
		else
		{
			itemInstance = IFFGICGLKNC.itemInstance.LHBPOPOIFLE().KDNBBPJCNDJ(IFFGICGLKNC.itemInstance);
			if (itemInstance is FoodInstance foodInstance)
			{
				foodInstance.GBCJNGADANM = 1;
			}
			num = 10;
		}
		if (craftingLevel == 2)
		{
			num = (int)((float)num * 1.5f);
		}
		else if (craftingLevel == 3)
		{
			num = (int)((float)num * 2f);
		}
		bool flag = false;
		for (int i = 0; i < num; i++)
		{
			if (!IFFGICGLKNC.KPINNBKMOMO() && MIIMJDIGKLC.FEEOFAGCONJ(1, itemInstance))
			{
				IFFGICGLKNC.MEODNPFJDMH(CDPAMNIPPEC: false);
				flag = true;
			}
		}
		if (flag && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlots(new Slot[2] { IFFGICGLKNC, MIIMJDIGKLC });
		}
		LKMNCJEEHJH();
	}

	private void KPMEPDNJMJN(int JIIGOACEIKL)
	{
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		AgingRackUI.EPLOMIBMKFC(JIIGOACEIKL).agingRack = this;
		AgingRackUI.OCCEHEMCGJF(JIIGOACEIKL).OpenUI();
		((Component)this).GetComponent<Placeable>().HAJJPJONLMD();
	}

	public bool GILPDLFNIKB(int JIIGOACEIKL)
	{
		if (DJNPAPBNPNL(JIIGOACEIKL))
		{
			NGMAHGHOGGB(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public void JGNENDCKJAC(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private void MAIMGNMIFKG()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(AEGPOCLDBJK));
		}
		Slot slot = inputSlot1;
		slot.OnDirtied = (Action)Delegate.Combine(slot.OnDirtied, new Action(EJBEDAALCJJ));
		Slot slot2 = inputSlot2;
		slot2.OnDirtied = (Action)Delegate.Combine(slot2.OnDirtied, new Action(NEMDDEAIAKF));
		Slot slot3 = outputSlot1;
		slot3.OnDirtied = (Action)Delegate.Combine(slot3.OnDirtied, new Action(OFOHCKJKNHI));
		Slot slot4 = outputSlot2;
		slot4.OnDirtied = (Action)Delegate.Combine(slot4.OnDirtied, new Action(NEMDDEAIAKF));
		Slot slot5 = inputSlot1;
		slot5.OnItemRemoved = (Action)Delegate.Combine(slot5.OnItemRemoved, new Action(EJBEDAALCJJ));
		Slot slot6 = inputSlot2;
		slot6.OnItemRemoved = (Action)Delegate.Combine(slot6.OnItemRemoved, new Action(OFOHCKJKNHI));
		Slot slot7 = outputSlot1;
		slot7.OnItemRemoved = (Action)Delegate.Combine(slot7.OnItemRemoved, new Action(OFOHCKJKNHI));
		Slot slot8 = outputSlot2;
		slot8.OnItemRemoved = (Action)Delegate.Combine(slot8.OnItemRemoved, new Action(OFOHCKJKNHI));
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(JBAOFBOOMIH));
	}

	private void NJKHCOHADCL()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (OnlineManager.MasterOrOffline() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(KBFOIGIJHHM));
			}
			Slot slot = inputSlot1;
			slot.OnDirtied = (Action)Delegate.Remove(slot.OnDirtied, new Action(LKMNCJEEHJH));
			Slot slot2 = inputSlot2;
			slot2.OnDirtied = (Action)Delegate.Remove(slot2.OnDirtied, new Action(NEMDDEAIAKF));
			Slot slot3 = outputSlot1;
			slot3.OnDirtied = (Action)Delegate.Remove(slot3.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot4 = outputSlot2;
			slot4.OnDirtied = (Action)Delegate.Remove(slot4.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot5 = inputSlot1;
			slot5.OnItemRemoved = (Action)Delegate.Remove(slot5.OnItemRemoved, new Action(EJBEDAALCJJ));
			Slot slot6 = inputSlot2;
			slot6.OnItemRemoved = (Action)Delegate.Remove(slot6.OnItemRemoved, new Action(EJBEDAALCJJ));
			Slot slot7 = outputSlot1;
			slot7.OnItemRemoved = (Action)Delegate.Remove(slot7.OnItemRemoved, new Action(OFOHCKJKNHI));
			Slot slot8 = outputSlot2;
			slot8.OnItemRemoved = (Action)Delegate.Remove(slot8.OnItemRemoved, new Action(EJBEDAALCJJ));
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(KGALPFDCMGC));
		}
	}

	public bool HEOEEFNLJMO(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool AJOMNOIEFDP(int JIIGOACEIKL)
	{
		if (JIHKGPCCGJD(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			KPMEPDNJMJN(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void OJIEDIAAOLN(int JIIGOACEIKL)
	{
	}

	private void LBBAIKBNHFE(Slot ADEBNALPEHE, SpriteRenderer LIPBHGDOLFI, bool OKEJKNOIHED)
	{
		if (ADEBNALPEHE.KPINNBKMOMO())
		{
			LIPBHGDOLFI.sprite = null;
		}
		else if (OKEJKNOIHED)
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.PHGLMBIEOMK().spriteAged;
		}
		else
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.PHGLMBIEOMK().spriteNotAged;
		}
	}

	[SpecialName]
	public OnlineAgingRack BBDHLENJJMM()
	{
		return placeable.onlinePlaceable as OnlineAgingRack;
	}

	public void KOANHOFAJMA(int JIIGOACEIKL)
	{
	}

	public bool FNHLBEGJEMJ(int JIIGOACEIKL)
	{
		if (JMGDHMFOMDP(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				AEIPBMMCPPD().PODDPPKCCMB(1);
				return true;
			}
			return BLGPHMHGHEP(JIIGOACEIKL);
		}
		return true;
	}

	public bool GHDIMCAEAJJ(int JIIGOACEIKL)
	{
		return true;
	}

	public bool LJCFJIOBDLD(int JIIGOACEIKL)
	{
		return true;
	}

	public bool INDHAHEONDM(int JIIGOACEIKL)
	{
		AgingRackUI.FHKGDLNJFFA(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		AgingRackUI.Get(JIIGOACEIKL).CloseUI();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public void PFGDKCBPNEP(int JIIGOACEIKL)
	{
	}

	public bool EIOJAIOOMEI(int JIIGOACEIKL)
	{
		return true;
	}

	private void FBJKMPKINBB(Slot ADEBNALPEHE, SpriteRenderer LIPBHGDOLFI, bool OKEJKNOIHED)
	{
		if (ADEBNALPEHE.AHHEMNHJPME())
		{
			LIPBHGDOLFI.sprite = null;
		}
		else if (OKEJKNOIHED)
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.PHGLMBIEOMK().spriteAged;
		}
		else
		{
			LIPBHGDOLFI.sprite = ADEBNALPEHE.itemInstance.PHGLMBIEOMK().spriteNotAged;
		}
	}

	public bool Select(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			NMEIEFLNCHP(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool DAFBICEGOFO(int JIIGOACEIKL)
	{
		AgingRackUI.FHKGDLNJFFA(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public bool JIHKGPCCGJD(int JIIGOACEIKL)
	{
		return !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).GABNNLJOMHI();
	}

	private void FFHCDDEHKBB(Slot IFFGICGLKNC, Slot MIIMJDIGKLC)
	{
		if (IFFGICGLKNC.AHHEMNHJPME())
		{
			return;
		}
		ItemInstance itemInstance;
		int num;
		if (DIOOCKJFLMO.ContainsKey(IFFGICGLKNC.itemInstance.KNFNJFFCFNO()))
		{
			itemInstance = DIOOCKJFLMO[IFFGICGLKNC.itemInstance.AFOACBIHNCL()].to.JMDALJBNFML();
			num = DIOOCKJFLMO[IFFGICGLKNC.itemInstance.LHBPOPOIFLE()].amount;
		}
		else
		{
			itemInstance = IFFGICGLKNC.itemInstance.KNFNJFFCFNO().KDNBBPJCNDJ(IFFGICGLKNC.itemInstance);
			if (itemInstance is FoodInstance foodInstance)
			{
				foodInstance.JBIMNJGMFOC(1);
			}
			num = -117;
		}
		if (craftingLevel == 0)
		{
			num = (int)((float)num * 623f);
		}
		else if (craftingLevel == 6)
		{
			num = (int)((float)num * 1457f);
		}
		bool flag = false;
		for (int i = 1; i < num; i++)
		{
			if (!IFFGICGLKNC.LCHJGCHDHFO() && MIIMJDIGKLC.DDHPGOPOPKJ(0, itemInstance, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true))
			{
				IFFGICGLKNC.POHFJCEAKML();
				flag = false;
			}
		}
		if (flag && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager instance = OnlineSlotsManager.instance;
			Slot[] array = new Slot[0];
			array[1] = IFFGICGLKNC;
			array[1] = MIIMJDIGKLC;
			instance.LKCOAKJICDB(array);
		}
		LKMNCJEEHJH();
	}

	private void PBHKKHPKMNF(int JIIGOACEIKL)
	{
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		AgingRackUI.LKJNAHIPOLN(JIIGOACEIKL).agingRack = this;
		AgingRackUI.EPLOMIBMKFC(JIIGOACEIKL).OpenUI();
		((Component)this).GetComponent<Placeable>().NCMLCJDPCMM();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void AADNKNHPHMD(int JIIGOACEIKL)
	{
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		AgingRackUI.EPLOMIBMKFC(JIIGOACEIKL).agingRack = this;
		AgingRackUI.EPLOMIBMKFC(JIIGOACEIKL).IDLAGJNLPJL();
		((Component)this).GetComponent<Placeable>().NCMLCJDPCMM();
	}

	public void PIJCFKHFBED(int JIIGOACEIKL)
	{
	}

	private void HANCJHIDCNJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (OnlineManager.PGAGDFAEEFB() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(HOLFKGIENID));
			}
			Slot slot = inputSlot1;
			slot.OnDirtied = (Action)Delegate.Remove(slot.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot2 = inputSlot2;
			slot2.OnDirtied = (Action)Delegate.Remove(slot2.OnDirtied, new Action(EJBEDAALCJJ));
			Slot slot3 = outputSlot1;
			slot3.OnDirtied = (Action)Delegate.Remove(slot3.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot4 = outputSlot2;
			slot4.OnDirtied = (Action)Delegate.Remove(slot4.OnDirtied, new Action(OFOHCKJKNHI));
			Slot slot5 = inputSlot1;
			slot5.OnItemRemoved = (Action)Delegate.Remove(slot5.OnItemRemoved, new Action(LKMNCJEEHJH));
			Slot slot6 = inputSlot2;
			slot6.OnItemRemoved = (Action)Delegate.Remove(slot6.OnItemRemoved, new Action(OFOHCKJKNHI));
			Slot slot7 = outputSlot1;
			slot7.OnItemRemoved = (Action)Delegate.Remove(slot7.OnItemRemoved, new Action(NEMDDEAIAKF));
			Slot slot8 = outputSlot2;
			slot8.OnItemRemoved = (Action)Delegate.Remove(slot8.OnItemRemoved, new Action(LKMNCJEEHJH));
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(PEDJFFCHPAK));
		}
	}

	public bool FGFCJEMPHMG(int JIIGOACEIKL)
	{
		if (DJNPAPBNPNL(JIIGOACEIKL))
		{
			GMHLJELOGII(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public bool GEEMEEHAOBI(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		bool flag = false;
		if (!outputSlot1.LCHJGCHDHFO())
		{
			int num = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).LFBNOHNNFBB(outputSlot1.itemInstance, outputSlot1.Stack, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			if (num < outputSlot1.Stack)
			{
				outputSlot1.EHGKPGCNENF(outputSlot1.Stack - num);
				flag = true;
			}
		}
		if (!outputSlot2.PKFKJNODGJF())
		{
			int num2 = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AddItems(outputSlot2.itemInstance, outputSlot2.Stack, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			if (num2 < outputSlot2.Stack)
			{
				outputSlot2.PGPOPGGENAM(outputSlot2.Stack - num2, GCCLBKEJGFP: true, CDPAMNIPPEC: false);
				flag = true;
			}
		}
		if (flag)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		EJBEDAALCJJ();
		if (outputSlot1.LCHJGCHDHFO())
		{
			return !outputSlot2.AHHEMNHJPME();
		}
		return true;
	}

	private void LKMNCJEEHJH()
	{
		ACJOPCPFDNB(inputSlot1, input1SR, OKEJKNOIHED: false);
		ACJOPCPFDNB(inputSlot2, input2SR, OKEJKNOIHED: false);
		ACJOPCPFDNB(outputSlot1, output1SR, OKEJKNOIHED: true);
		ACJOPCPFDNB(outputSlot2, output2SR, OKEJKNOIHED: true);
	}

	public bool NPJLDBMBILF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void GMHLJELOGII(int JIIGOACEIKL)
	{
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		AgingRackUI.IPDFCJLOHLC(JIIGOACEIKL).agingRack = this;
		AgingRackUI.NDJAMDLOIJL(JIIGOACEIKL).EDHEIFHAAKO();
		((Component)this).GetComponent<Placeable>().SetInteraced();
	}
}
