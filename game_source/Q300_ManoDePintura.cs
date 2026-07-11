using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Q300_ManoDePintura", menuName = "Missions/Q300_ManoDePintura")]
public class Q300_ManoDePintura : MissionBase
{
	private void OFCAMKIDIIJ(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.EPICLNDDLKH(0))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.smelterRepaired && !activeMission.OCIGJLPAMAC(0))
		{
			activeMission.PFNPELJFJKA(0);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.KILNMBGOPAI(2))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.KILNMBGOPAI(7))
		{
			activeMission.OGHHAGHNOCG(3);
		}
		if (Crafter.stumpRepaired && !activeMission.EPICLNDDLKH(0))
		{
			activeMission.KNOIJBMDJDK(2);
		}
		if (activeMission.PJGLJKFPCHN())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(KDMADDODCIM));
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.AICNIPFBFFN();
			}
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				Debug.Log((object)"Player/Bark/TavernBlock");
				MaiNPC.GGFJGHHHEJC.GDCCJACLGJE(99f);
			}
		}
	}

	private void HJPKDMEJCOB(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.AHMMKLJMPAF(0))
		{
			activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false);
		}
		if (Crafter.smelterRepaired && !activeMission.DIEJALHGMEM(1))
		{
			activeMission.OGHHAGHNOCG(1);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.KILNMBGOPAI(7))
		{
			activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.OCBPOLPLPEK(5))
		{
			activeMission.KNOIJBMDJDK(8);
		}
		if (Crafter.stumpRepaired && !activeMission.FEAIADMHKGM(5))
		{
			activeMission.KNOIJBMDJDK(2);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(PAOPACJOICD));
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.ENHFKOBMGEO();
			}
			if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
			{
				Debug.Log((object)"Dialogue System/Conversation/Gass_Introduce/Entry/7/Dialogue Text");
				MaiNPC.GGFJGHHHEJC.ActiveMaiInBar(746f);
			}
		}
	}

	private void ALMKILIHLAI(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.EPICLNDDLKH(1))
		{
			activeMission.OGHHAGHNOCG(0);
		}
		if (Crafter.smelterRepaired && !activeMission.JEGIEDHFANI(1))
		{
			activeMission.BNGFAGIGJNE(0);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.DIEJALHGMEM(1))
		{
			activeMission.PFNPELJFJKA(3, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.OCBPOLPLPEK(2))
		{
			activeMission.MJJIHGHCDCC(6);
		}
		if (Crafter.stumpRepaired && !activeMission.KILNMBGOPAI(0))
		{
			activeMission.OGHHAGHNOCG(4, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.HIFAEOKEHGF())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(HJPKDMEJCOB));
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DDCIALHPFPC();
			}
			if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
			{
				Debug.Log((object)"distillingRepUnlock");
				MaiNPC.GGFJGHHHEJC.AECJLMGNMAH(499f);
			}
		}
	}

	public override void DDGEPPLPJHI()
	{
		base.DDGEPPLPJHI();
		BDGNKECCHJC(1);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCrafterRepaired = (Action<int>)Delegate.Combine(instance.OnCrafterRepaired, new Action<int>(BDGNKECCHJC));
		MinersDisputeEvent.instance.ActivateMinersDisputeFromMission();
	}

	private void BDGNKECCHJC(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.OCBPOLPLPEK(0))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.smelterRepaired && !activeMission.OCBPOLPLPEK(1))
		{
			activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.OCBPOLPLPEK(2))
		{
			activeMission.BNGFAGIGJNE(2, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.OCBPOLPLPEK(3))
		{
			activeMission.BNGFAGIGJNE(3, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.stumpRepaired && !activeMission.OCBPOLPLPEK(4))
		{
			activeMission.BNGFAGIGJNE(4, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.PJGLJKFPCHN())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(BDGNKECCHJC));
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.LHKIJABBBPM();
			}
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				Debug.Log((object)"ActiveMaiInBar");
				MaiNPC.GGFJGHHHEJC.ActiveMaiInBar();
			}
		}
	}

	private void LKINPFEHOEC(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.JEGIEDHFANI(0))
		{
			activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: false);
		}
		if (Crafter.smelterRepaired && !activeMission.AHMMKLJMPAF(0))
		{
			activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.AHMMKLJMPAF(8))
		{
			activeMission.MJJIHGHCDCC(4);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.OCBPOLPLPEK(1))
		{
			activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.stumpRepaired && !activeMission.FEAIADMHKGM(2))
		{
			activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.EFGJJFGCJNO())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(LDLGFCDFACO));
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DDCIALHPFPC();
			}
			if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
			{
				Debug.Log((object)"Exit build mode");
				MaiNPC.GGFJGHHHEJC.ActiveMaiInBar(448f);
			}
		}
	}

	private void HNOCKKBLNEB(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.KILNMBGOPAI(1))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.smelterRepaired && !activeMission.FEAIADMHKGM(0))
		{
			activeMission.OGHHAGHNOCG(1);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.JEGIEDHFANI(4))
		{
			activeMission.BNGFAGIGJNE(3, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.EPICLNDDLKH(1))
		{
			activeMission.PFNPELJFJKA(4);
		}
		if (Crafter.stumpRepaired && !activeMission.FEAIADMHKGM(4))
		{
			activeMission.KNOIJBMDJDK(6, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.EAJBBEHPPKM())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(BDGNKECCHJC));
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.DOAGOANJANC();
			}
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				Debug.Log((object)"Invalid playerNum");
				MaiNPC.GGFJGHHHEJC.AECJLMGNMAH(1515f);
			}
		}
	}

	private void KDMADDODCIM(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.OCIGJLPAMAC(1))
		{
			activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.smelterRepaired && !activeMission.EPICLNDDLKH(1))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.FEAIADMHKGM(8))
		{
			activeMission.MJJIHGHCDCC(3, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.FEAIADMHKGM(7))
		{
			activeMission.PFNPELJFJKA(4);
		}
		if (Crafter.stumpRepaired && !activeMission.AHMMKLJMPAF(3))
		{
			activeMission.MJJIHGHCDCC(3, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(JDHHMDAMOOD));
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.DDCIALHPFPC();
			}
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				Debug.Log((object)"Disconnecting...");
				MaiNPC.GGFJGHHHEJC.AECJLMGNMAH(619f);
			}
		}
	}

	private void OMBHPPCFBGB(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.OCBPOLPLPEK(0))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.smelterRepaired && !activeMission.KILNMBGOPAI(0))
		{
			activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.KILNMBGOPAI(6))
		{
			activeMission.BNGFAGIGJNE(4);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.FEAIADMHKGM(4))
		{
			activeMission.BNGFAGIGJNE(4, BLJPGJKOLNF: false);
		}
		if (Crafter.stumpRepaired && !activeMission.AHMMKLJMPAF(3))
		{
			activeMission.KNOIJBMDJDK(7, BLJPGJKOLNF: false);
		}
		if (activeMission.OGJCNHAHFAL())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(GHGMFIMLNAP));
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.LHKIJABBBPM();
			}
			if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
			{
				Debug.Log((object)"");
				MaiNPC.GGFJGHHHEJC.GDCCJACLGJE(222f);
			}
		}
	}

	private void LDLGFCDFACO(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.OCIGJLPAMAC(1))
		{
			activeMission.MJJIHGHCDCC(0);
		}
		if (Crafter.smelterRepaired && !activeMission.KILNMBGOPAI(0))
		{
			activeMission.BNGFAGIGJNE(0);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.FEAIADMHKGM(2))
		{
			activeMission.MJJIHGHCDCC(5);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.AHMMKLJMPAF(8))
		{
			activeMission.BNGFAGIGJNE(0);
		}
		if (Crafter.stumpRepaired && !activeMission.FEAIADMHKGM(4))
		{
			activeMission.OGHHAGHNOCG(3);
		}
		if (activeMission.OGJCNHAHFAL())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(ALMKILIHLAI));
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.LHKIJABBBPM();
			}
			if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
			{
				Debug.Log((object)"UI2");
				MaiNPC.GGFJGHHHEJC.AECJLMGNMAH(1725f);
			}
		}
	}

	private void GHGMFIMLNAP(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.OCIGJLPAMAC(0))
		{
			activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.smelterRepaired && !activeMission.FEAIADMHKGM(1))
		{
			activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.KILNMBGOPAI(3))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.OCIGJLPAMAC(5))
		{
			activeMission.KNOIJBMDJDK(6, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.stumpRepaired && !activeMission.FEAIADMHKGM(6))
		{
			activeMission.MJJIHGHCDCC(5, BLJPGJKOLNF: false);
		}
		if (activeMission.AEEHNCDJBKA())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(HNOCKKBLNEB));
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.LHKIJABBBPM();
			}
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				Debug.Log((object)"Items/item_description_1137");
				MaiNPC.GGFJGHHHEJC.AECJLMGNMAH(1608f);
			}
		}
	}

	private void PAOPACJOICD(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.JEGIEDHFANI(0))
		{
			activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false);
		}
		if (Crafter.smelterRepaired && !activeMission.JEGIEDHFANI(0))
		{
			activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.KILNMBGOPAI(2))
		{
			activeMission.OGHHAGHNOCG(4, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.OCBPOLPLPEK(6))
		{
			activeMission.BNGFAGIGJNE(8, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.stumpRepaired && !activeMission.JEGIEDHFANI(8))
		{
			activeMission.MJJIHGHCDCC(3, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(ALMKILIHLAI));
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DDCIALHPFPC();
			}
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				Debug.Log((object)"ReceiveRentedRoomMessage");
				MaiNPC.GGFJGHHHEJC.ActiveMaiInBar(1991f);
			}
		}
	}

	private void IIIHIBKBDGB(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.KILNMBGOPAI(1))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.smelterRepaired && !activeMission.OCIGJLPAMAC(0))
		{
			activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.KILNMBGOPAI(8))
		{
			activeMission.PFNPELJFJKA(4, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.EPICLNDDLKH(7))
		{
			activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: false);
		}
		if (Crafter.stumpRepaired && !activeMission.EPICLNDDLKH(6))
		{
			activeMission.OGHHAGHNOCG(2);
		}
		if (activeMission.PJGLJKFPCHN())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(BDGNKECCHJC));
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.AICNIPFBFFN();
			}
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				Debug.Log((object)"Cannot load old character saved");
				MaiNPC.GGFJGHHHEJC.ActiveMaiInBar(1985f);
			}
		}
	}

	private void JDHHMDAMOOD(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (Crafter.sawmillRepaired && !activeMission.KILNMBGOPAI(0))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (Crafter.smelterRepaired && !activeMission.EPICLNDDLKH(0))
		{
			activeMission.KNOIJBMDJDK(1);
		}
		if (Crafter.blacksmithsTableRepaired && !activeMission.OCBPOLPLPEK(4))
		{
			activeMission.KNOIJBMDJDK(6, BLJPGJKOLNF: false);
		}
		if (Crafter.stoneWorkstationRepaired && !activeMission.OCIGJLPAMAC(1))
		{
			activeMission.MJJIHGHCDCC(8, BLJPGJKOLNF: false);
		}
		if (Crafter.stumpRepaired && !activeMission.JEGIEDHFANI(4))
		{
			activeMission.PFNPELJFJKA(4, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.PJGLJKFPCHN())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(HJPKDMEJCOB));
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.AABDCFOJBNH();
			}
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				Debug.Log((object)" ");
				MaiNPC.GGFJGHHHEJC.ActiveMaiInBar(349f);
			}
		}
	}
}
