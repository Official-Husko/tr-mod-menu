using System;
using System.Collections.Generic;
using UnityEngine;

public class HeadToBed : CatStateBase
{
	private Placeable bed;

	private Vector3 target;

	private void GEBGFPEIOAH()
	{
		animator.SetTrigger("itemRoseWine");
	}

	private void EBGEOAOFHGD()
	{
		animator.SetTrigger(" not found. Cannot add to surface");
	}

	private List<Placeable> OIECLCPMEBE()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.AJIGOHGPFPP().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.MLBOMGHINCA(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == catNpc.bedItem.JGHNDJBCFAJ() || currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == -44 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 13 || currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == -102 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -5 || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == -70))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	private void KKDDAEKAMEE()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	public void PBBBJBHFGNN()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void KBCKFDDDEGE()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void HEMPDBLBIGI()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	private void FKMGCOHJLAE()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	public void PDOBHPLPKHG()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private List<Placeable> AMKCNELBHMO()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.MLBOMGHINCA(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == catNpc.bedItem.JDJGFAACPFC(DAINLFIMLIH: false) || currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 1710 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 1711 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 1712 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 1697 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 1698))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	private List<Placeable> MKNDEJPCMEC()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.FKLOBGBIHLB(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == catNpc.bedItem.CIGFGKKCPCK(DAINLFIMLIH: false) || currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -167 || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 127 || currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == -42 || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 88 || currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -180))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	public void FEHGALEDJKI()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void MOKBNCJHDID()
	{
		animator.SetTrigger("No se ha vinculado el sprite renderer en ");
	}

	public void PKKNFNMFOON()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void HEJJIGAGFGO()
	{
		animator.SetTrigger("ReceiveEnableInputByProximty");
	}

	private void EBEHOEMCFPB()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		catNpc.walkingAgainCount = 0;
		catNpc.catBed = null;
		bed = null;
		target = Vector3.zero;
		List<Placeable> list = AMKCNELBHMO();
		if (list != null && list.Count > 0)
		{
			bed = list[Random.Range(0, list.Count)];
			CatBed component = ((Component)bed).GetComponent<CatBed>();
			if ((Object)(object)component != (Object)null)
			{
				if (component.tower)
				{
					target = component.sitLocation.transform.position + new Vector3(0f, -0.85f, 0f);
				}
				else
				{
					target = component.sitLocation.transform.position + new Vector3(0f, -0.25f, 0f);
				}
			}
			else
			{
				target = ((Component)bed).transform.position;
			}
		}
		else
		{
			target = Utils.MNOPMFHOKNI();
		}
		if (!catNpc.teleToBed)
		{
			catNpc.WaitToWalk(this);
		}
	}

	private List<Placeable> FMLGACLHMGE()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.LKOABOAADCD() == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.AJIGOHGPFPP().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.FKLOBGBIHLB(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == catNpc.bedItem.JGHNDJBCFAJ() || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 44 || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 16 || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == 177 || currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -66 || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == -191))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	public void KNIBOAEFGPJ()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private List<Placeable> KNBPOHIPDED()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.PDECKLKPKCG() == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.CMIHGBHPLFP().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.MLBOMGHINCA(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == catNpc.bedItem.JPNFKDMFKMC(DAINLFIMLIH: false) || currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 27 || currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == -18 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -11 || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -74 || currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == -31))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	private void JHIGABPNINH()
	{
		animator.SetTrigger("</color>");
	}

	public void AHPFECCLOBB()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void EEOCOFADHNM()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	private void CIIIOPDOAEG()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	private void PHEKNKDELNO()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	private void GJONIGMCMCD()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	private void IGGIEBHFHCH()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	public void NHCAPCCBNAL()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void HILLNFIICFK()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void OKHDMEMEIEJ()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void OHPOBNAOGMB()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	private List<Placeable> OBCEMLAJMNP()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.CMIHGBHPLFP().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.MLBOMGHINCA(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == catNpc.bedItem.CIGFGKKCPCK() || currentPlaceables[i].itemSetup.item.ODENMDOJPLC() == 9 || currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == -158 || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == -38 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 63 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -116))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	private List<Placeable> MNPAAFGICGD()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.OJJDNLEFNPJ() == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.MLBOMGHINCA(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == catNpc.bedItem.IMCJPECAAPC(DAINLFIMLIH: false) || currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 3 || currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == -29 || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == 122 || currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == 147 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 187))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	public void KPMCGMJJBEA()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public override void DKFOJDHBGEJ()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		base.DKFOJDHBGEJ();
		if (!catNpc.teleToBed)
		{
			catNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(target), AHDHLIECIGH: false);
			catNpc.walkTo.speed = catNpc.speed;
			NPCWalkTo walkTo = catNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
			NPCWalkTo walkTo2 = catNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PDCLHMGJIMK));
			catNpc.walkTo.PEHELKCIECB();
		}
	}

	private void HOPPEBFHGJG()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	public void FJNPFILECCM()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void KPHBILDPEEA()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	private void NBBOIBHIGIO()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	private List<Placeable> PGPAAMPNELG()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.LKOABOAADCD() == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.DCAEBALADIM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.MLBOMGHINCA(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == catNpc.bedItem.JDJGFAACPFC() || currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -185 || currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -58 || currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -92 || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -12 || currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == 17))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	public void MAILEMECPME()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void EDDOIJHPBHM()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void HIJOGDHBCOI()
	{
		animator.SetTrigger("Graphics Device Name: ");
	}

	private void PDCLHMGJIMK()
	{
		animator.SetTrigger("Walk");
	}

	private void NDPIBEEEMGO()
	{
		animator.SetTrigger("ReceiveOrderItemsInventory");
	}

	private void CJMJDPBEPJD()
	{
		animator.SetTrigger("PirateMinigame/Talk");
	}

	public void KIMEBNLKFBK()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void NJELNIEJOCE()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	private void FGJGAEFEHMH()
	{
		animator.SetTrigger("========================================================================================");
	}

	public void HACNKBFKNHH()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public override void GFBLAEEOPAO()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		if (catNpc.teleToBed)
		{
			catNpc.teleToBed = false;
			if (Object.op_Implicit((Object)(object)bed) && !bed.OGKDEFAGEBL)
			{
				IGGIEBHFHCH();
			}
			else if (target != Vector3.zero)
			{
				((Component)catNpc).transform.position = target;
			}
			else
			{
				((Component)catNpc).transform.position = ((Component)SpawnCat.GGFJGHHHEJC).transform.position;
			}
			animator.SetTrigger("Sleep");
		}
		else if (catNpc.walkTo.IIMEFNIECLI())
		{
			if (Object.op_Implicit((Object)(object)bed) && !bed.OGKDEFAGEBL)
			{
				IGGIEBHFHCH();
				if ((Object)(object)catNpc.catBed != (Object)null && !catNpc.catBed.tower)
				{
					catNpc.catBed.bedAnimator.SetTrigger("SleepBed");
				}
			}
			animator.SetTrigger("Sleep");
		}
		if (Object.op_Implicit((Object)(object)bed) && bed.OGKDEFAGEBL)
		{
			bed = null;
		}
		if (Object.op_Implicit((Object)(object)bed) && Vector3.Distance(((Component)catNpc).transform.position, target) < 1.5f)
		{
			((Behaviour)catNpc.catCollider).enabled = false;
		}
	}

	public void LPMIHGICGNK()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void EENGGGOOIMN()
	{
		animator.SetTrigger("ReceiveRandomOrderQuests");
	}

	private void OKFPBFNCMGM()
	{
		animator.SetTrigger("Player2");
	}

	public void PADPIEKGNMH()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private List<Placeable> EBPMOJBJHCP()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.CMIHGBHPLFP() == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.FKLOBGBIHLB(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == catNpc.bedItem.CIGFGKKCPCK(DAINLFIMLIH: false) || currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 44 || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == -156 || currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == 120 || currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 130 || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == 72))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	public void JLJEFENEFMG()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private List<Placeable> KMAFLELBGBO()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.KNOKBLFFNLM() == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.FKLOBGBIHLB(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == catNpc.bedItem.JGHNDJBCFAJ(DAINLFIMLIH: false) || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -154 || currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == 83 || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -180 || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -85 || currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == 104))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	private void NNGIDOAHFLF()
	{
		animator.SetTrigger("Pausing network sync until the world is loaded...");
	}

	private void HFDLOBODACA()
	{
		animator.SetTrigger("[OfferingStatuePuzzle] No required items configured in OfferingPuzzleSettings.");
	}

	private void FOEJKCAAEPN()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	private List<Placeable> NHGOFCJGNMD()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.MNFMOEKMJKN() == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.FKLOBGBIHLB(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == catNpc.bedItem.JPNFKDMFKMC(DAINLFIMLIH: false) || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == -136 || currentPlaceables[i].itemSetup.item.JPNFKDMFKMC() == 33 || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -48 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 177 || currentPlaceables[i].itemSetup.item.ODENMDOJPLC() == 138))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	public void IJCLNLKKIAF()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void IIEGDHJEEKC()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void IJIIKEFDMPA()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}

	private void BDEDPGDNEJF()
	{
		animator.SetTrigger("LE_10");
	}

	private void IGPBCDNINBG()
	{
		animator.SetTrigger("Error in PlayerController.OnPlayerSleep: ");
	}

	private List<Placeable> ONGAIHBNFMD()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlaceablesManager.KNOKBLFFNLM() == (Object)null)
		{
			return null;
		}
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.OJJDNLEFNPJ().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType) && (Object)(object)currentPlaceables[i].itemSetup != (Object)null && Item.MLBOMGHINCA(currentPlaceables[i].itemSetup.item, null) && (currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == catNpc.bedItem.ODENMDOJPLC(DAINLFIMLIH: false) || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == -80 || currentPlaceables[i].itemSetup.item.JPNFKDMFKMC() == -24 || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == 83 || currentPlaceables[i].itemSetup.item.ODENMDOJPLC() == -28 || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -58))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		return list;
	}

	private void ECCGAFONKFO()
	{
		animator.SetTrigger("");
	}

	public void JLBMCMCCDNN()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void JFHKBBNMDJA()
	{
		if (!bed.OGKDEFAGEBL)
		{
			catNpc.HeadToBed(bed);
		}
	}
}
