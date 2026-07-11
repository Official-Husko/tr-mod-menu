using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TutorialPopUps
{
	public static TutorialPopUp calendarPopUp = new TutorialPopUp(23, LFNJPBDOBOM, PKBDMKLIEEL);

	public static TutorialPopUp specialEventGuestAddedPopUp = new TutorialPopUp(28, MAALBHGADLJ, PEPNDOFHJCG);

	public static TutorialPopUp importantGuestSpawnPopUp = new TutorialPopUp(29, ELGNOLMAAHG, EIIDAIPMNPD);

	public static TutorialPopUp customerAskRoomPopUp = new TutorialPopUp(77, GJNAKNJJHPP, KPFAJNIPLBK);

	public static TutorialPopUp enterRentRoomPopUp = new TutorialPopUp(78, CCOMJNNBLHA, OPNAGMHLEFL);

	public static TutorialPopUp uniqueItemsPopUp = new TutorialPopUp(80, NCCGMAJLOKK, JMBIOAFAHCH);

	public static TutorialPopUp trendsPopUp = new TutorialPopUp(81, JHFJHNNNKEP, MIEFIABNNLB);

	public static TutorialPopUp barWithTrendsPopUp = new TutorialPopUp(82, KMFECKBOLIP, JKFKHFLMOCH);

	public static TutorialPopUp player2ChestPopUp = new TutorialPopUp(95, BJNEJPBHELD, IJOIHCJOENM, null, AIOOLCMJBKE: true);

	public static TutorialPopUp staffMenu2PopUp = new TutorialPopUp(102, LIGBDDLEFAH, HCLIJKJFLFH);

	public static TutorialPopUp employeeHiredPopUp = new TutorialPopUp(103, NOOJAMIGELI, AJBAIGKGLGM, null, AIOOLCMJBKE: true);

	public static TutorialPopUp employeeAvoidingWorkPopUp = new TutorialPopUp(104, ABCLFIEEOIP, FDHPJOGCMOK, null, AIOOLCMJBKE: true);

	public static TutorialPopUp employeeInfoOpenPopUp = new TutorialPopUp(105, OFANLOGAMEB, EIMACIILMEI);

	public static TutorialPopUp employeeInfoOpen2PopUp = new TutorialPopUp(106, EJENLJGAHPP, FILGHGAPNBP, PPFJEADFIPB);

	private static int CGMLGEFBJFB = 0;

	public static TutorialPopUp employeeInfoOpen3PopUp = new TutorialPopUp(107, BNMINFACHFO, LBJNKHBDDNM, GCGIIBAAGKE);

	public static TutorialPopUp firstDayBarworkerPopUp = new TutorialPopUp(108, FHEDGPPAACO, IALHDABAKBJ);

	public static TutorialPopUp firstDayWaiterPopUp = new TutorialPopUp(109, EHLIEHLNEIP, OGILAJJGLGF);

	public static TutorialPopUp firstDayBouncerPopUp = new TutorialPopUp(110, FAMOOHKAFPM, BEKKOIHIJGK);

	public static TutorialPopUp firstDayHouseKeeperPopUp = new TutorialPopUp(111, PIILNGKMNFP, CGDALLJNNKD);

	public static TutorialPopUp rentRoomInfoOpenPopUp = new TutorialPopUp(112, FAEJCHDFPDE, EANLPKMDILG);

	public static TutorialPopUp rentRoomInfoOpen2PopUp = new TutorialPopUp(113, JDCJBGJMPNB, PEPDANOMDAA);

	public static TutorialPopUp firstRentedRoomPopUp = new TutorialPopUp(114, KFHCOMOEAND, FMCEJJLAKNE);

	public static TutorialPopUp firstGuestLeavingPopUp = new TutorialPopUp(115, KBENBKLAHIB, ADLJOCEICFO);

	public static TutorialPopUp firstGuestRequestingRoomPopUp = new TutorialPopUp(116, FJJAGGFMIOE, BGIKCAMPLNN);

	public static TutorialPopUp staffMenuPopUp = new TutorialPopUp(120, PCBPGHFNKPB, IOPIMOOMMAB);

	public static TutorialPopUp fishEncyclopediaPopUp = new TutorialPopUp(124, CINPMHLHGEA, IOCIELLIMJH);

	public static List<TutorialPopUp> autoSetUp = new List<TutorialPopUp>
	{
		calendarPopUp, specialEventGuestAddedPopUp, importantGuestSpawnPopUp, customerAskRoomPopUp, enterRentRoomPopUp, uniqueItemsPopUp, trendsPopUp, barWithTrendsPopUp, player2ChestPopUp, staffMenu2PopUp,
		employeeHiredPopUp, employeeAvoidingWorkPopUp, employeeInfoOpenPopUp, employeeInfoOpen2PopUp, employeeInfoOpen3PopUp, firstDayBarworkerPopUp, firstDayWaiterPopUp, firstDayBouncerPopUp, firstDayHouseKeeperPopUp, rentRoomInfoOpenPopUp,
		rentRoomInfoOpen2PopUp, firstRentedRoomPopUp, firstGuestLeavingPopUp, firstGuestRequestingRoomPopUp, staffMenuPopUp, fishEncyclopediaPopUp
	};

	private static string PCBPGHFNKPB(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp120", JIIGOACEIKL);
	}

	private static bool GHMDAGIALFH(bool GDIGPFGIGPL)
	{
		TutorialManager.GGFJGHHHEJC.right = GDIGPFGIGPL;
		return true;
	}

	private static void CJNCAJJMDPK(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnWaiterGoingToWork = (Action<int>)Delegate.Remove(instance.OnWaiterGoingToWork, new Action<int>(CJNCAJJMDPK));
			CFGJBIIBBDB(firstDayBouncerPopUp, JIIGOACEIKL);
		}
	}

	private static void MHOMAKANLOI(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarOpenWithTrends = (Action<int>)Delegate.Remove(instance.OnBarOpenWithTrends, new Action<int>(MHOMAKANLOI));
			CFGJBIIBBDB(barWithTrendsPopUp, JIIGOACEIKL);
		}
	}

	public static IEnumerator KPGHLIGGJJL(TutorialPopUp FKHFBMFJKDM)
	{
		yield return null;
		TutorialManager.GGFJGHHHEJC.popUpQueue.Enqueue(FKHFBMFJKDM);
	}

	private static string EJENLJGAHPP(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp106", JIIGOACEIKL);
	}

	private static void JDAEECPOCHO(int PHNKKAHPIAO)
	{
		if (PHNKKAHPIAO >= 3 && TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			Trends instance = Trends.GGFJGHHHEJC;
			instance.OnUniqueItemsCalculated = (Action<int>)Delegate.Remove(instance.OnUniqueItemsCalculated, new Action<int>(JDAEECPOCHO));
			CFGJBIIBBDB(uniqueItemsPopUp, 1);
		}
	}

	private static void MAILNLIPMPF(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnHouseKeeperGoingToWork = (Action<int>)Delegate.Remove(instance.OnHouseKeeperGoingToWork, new Action<int>(MAILNLIPMPF));
			CFGJBIIBBDB(firstDayHouseKeeperPopUp, JIIGOACEIKL);
		}
	}

	private static void IJOIHCJOENM()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(NJEIAHCEDNK));
	}

	private static void EIMACIILMEI()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnEmployeeInfoOpen = (Action<int>)Delegate.Combine(instance.OnEmployeeInfoOpen, new Action<int>(ONINPNJLPDO));
	}

	private static string PIILNGKMNFP(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp111", JIIGOACEIKL);
	}

	private static string KFHCOMOEAND(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp114", JIIGOACEIKL);
	}

	public static void HBOMKPFIFJM()
	{
		if (!SaveUI.instance.tutorial || OnlineManager.ClientOnline())
		{
			return;
		}
		HashSet<int> hashSet = new HashSet<int>();
		foreach (TutorialPopUp item in autoSetUp)
		{
			if (hashSet.Contains(item.DCFNIMCMFEM))
			{
				Debug.Log((object)"Duplicate tutorial ID found!");
			}
			else if (!CommonReferences.GGFJGHHHEJC.seenPopUps.Contains(item.DCFNIMCMFEM))
			{
				item.DDGEPPLPJHI();
				hashSet.Add(item.DCFNIMCMFEM);
			}
		}
	}

	private static void EKDPMGEAJAG(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarworkerGoingToWork = (Action<int>)Delegate.Remove(instance.OnBarworkerGoingToWork, new Action<int>(EKDPMGEAJAG));
			CFGJBIIBBDB(firstDayBarworkerPopUp, JIIGOACEIKL);
		}
	}

	private static string NOOJAMIGELI(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp103", JIIGOACEIKL);
	}

	private static string MAALBHGADLJ(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp28", JIIGOACEIKL);
	}

	private static string FAMOOHKAFPM(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp110", JIIGOACEIKL);
	}

	private static void IOCIELLIMJH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnUnlockFishEncyclopedia = (Action<int>)Delegate.Combine(instance.OnUnlockFishEncyclopedia, new Action<int>(KIEEIFNMEBP));
	}

	private static string AKBBOHNCHPL(int JIIGOACEIKL, string JFNMCNCHMEO, params ActionType[] ONINNJACJLA)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.GetStringWithTags(JFNMCNCHMEO)))
		{
			return JFNMCNCHMEO;
		}
		try
		{
			if (ONINNJACJLA.Length != 0)
			{
				string[] array = new string[ONINNJACJLA.Length];
				for (int i = 0; i < ONINNJACJLA.Length; i++)
				{
					array[i] = InputUtils.CMOBIDABHKM(JIIGOACEIKL, ONINNJACJLA[i]);
				}
				return InputUtils.GEJLCOGDMID(InputUtils.LPGJFAOKMNE(JIIGOACEIKL, LocalisationSystem.GetStringWithTags(JFNMCNCHMEO)), array);
			}
			return InputUtils.GEJLCOGDMID(InputUtils.LPGJFAOKMNE(JIIGOACEIKL, LocalisationSystem.GetStringWithTags(JFNMCNCHMEO)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("PopUpGen error: " + ex));
			return JFNMCNCHMEO;
		}
	}

	private static void PEPNDOFHJCG()
	{
		TavernEventManager.OnEventAdded = (Action<TavernEvent>)Delegate.Combine(TavernEventManager.OnEventAdded, new Action<TavernEvent>(BOHCABCMBAI));
	}

	private static void KPJGCGJJHOP(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CFGJBIIBBDB(employeeInfoOpen2PopUp, JIIGOACEIKL);
			OOIADJEJAII(JIIGOACEIKL);
			if (JIIGOACEIKL == 1)
			{
				TutorialManager.GGFJGHHHEJC.right = false;
			}
			else
			{
				TutorialManager.GGFJGHHHEJC.left = false;
			}
			CGMLGEFBJFB = JIIGOACEIKL;
		}
	}

	private static string KBENBKLAHIB(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp115", JIIGOACEIKL);
	}

	private static void JNOBLDFPPIL(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnWaiterGoingToWork = (Action<int>)Delegate.Remove(instance.OnWaiterGoingToWork, new Action<int>(JNOBLDFPPIL));
			CFGJBIIBBDB(firstDayWaiterPopUp, JIIGOACEIKL);
		}
	}

	private static void KIEEIFNMEBP(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnUnlockFishEncyclopedia = (Action<int>)Delegate.Remove(instance.OnUnlockFishEncyclopedia, new Action<int>(KIEEIFNMEBP));
			CFGJBIIBBDB(fishEncyclopediaPopUp, JIIGOACEIKL);
		}
	}

	private static void IALHDABAKBJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarworkerGoingToWork = (Action<int>)Delegate.Combine(instance.OnBarworkerGoingToWork, new Action<int>(EKDPMGEAJAG));
	}

	private static void KJNPHJMDNIC(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnGuestLeaving = (Action<int>)Delegate.Remove(instance.OnGuestLeaving, new Action<int>(KJNPHJMDNIC));
			CFGJBIIBBDB(firstGuestLeavingPopUp, JIIGOACEIKL);
		}
	}

	private static void OGILAJJGLGF()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnWaiterGoingToWork = (Action<int>)Delegate.Combine(instance.OnWaiterGoingToWork, new Action<int>(JNOBLDFPPIL));
	}

	private static void PBLLFPLIMIN(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CFGJBIIBBDB(staffMenu2PopUp, JIIGOACEIKL);
		}
	}

	private static void MFHCAOMNMAE(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && TavernReputation.GetMilestone() >= RepUnlocksManager.GetInstance().repUnlockStaff.repNumber)
		{
			for (int i = 0; i < HireStaffUI.instances.Length; i++)
			{
				HireStaffUI obj = HireStaffUI.instances[i];
				obj.OnUIOpen = (Action<int>)Delegate.Remove(obj.OnUIOpen, new Action<int>(MFHCAOMNMAE));
			}
			CFGJBIIBBDB(staffMenuPopUp, JIIGOACEIKL);
			PBLLFPLIMIN(JIIGOACEIKL);
		}
	}

	private static string JHFJHNNNKEP(int JIIGOACEIKL)
	{
		return InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("tutorialPopUp81", JIIGOACEIKL), Utils.MLNDLODLJJL("Calendar"));
	}

	private static void JKFKHFLMOCH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarOpenWithTrends = (Action<int>)Delegate.Combine(instance.OnBarOpenWithTrends, new Action<int>(MHOMAKANLOI));
	}

	private static string JDCJBGJMPNB(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp113", JIIGOACEIKL);
	}

	private static string LFNJPBDOBOM(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp23", JIIGOACEIKL);
	}

	private static bool MBDALEEBNDI(bool IFHNAJLPFDF)
	{
		TutorialManager.GGFJGHHHEJC.left = IFHNAJLPFDF;
		return true;
	}

	private static void EIIDAIPMNPD()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnGuestSpawn = (Action)Delegate.Combine(instance.OnGuestSpawn, new Action(PMKJHGEPGNG));
	}

	private static void DGMCDIHPKCA(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			for (int i = 0; i < CalendarUI.instances.Length; i++)
			{
				CalendarUI obj = CalendarUI.instances[i];
				obj.OnUIOpen = (Action<int>)Delegate.Remove(obj.OnUIOpen, new Action<int>(DGMCDIHPKCA));
			}
			CFGJBIIBBDB(calendarPopUp, JIIGOACEIKL);
		}
	}

	private static void HHJJMDCBCHD(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CFGJBIIBBDB(rentRoomInfoOpen2PopUp, JIIGOACEIKL);
		}
	}

	private static string CCOMJNNBLHA(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp78", JIIGOACEIKL);
	}

	private static void FILGHGAPNBP()
	{
	}

	private static void FDHPJOGCMOK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyEmployeeAvoidingWork = (Action<int>)Delegate.Combine(instance.OnAnyEmployeeAvoidingWork, new Action<int>(OLMIGEJGCMP));
	}

	private static string EHLIEHLNEIP(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp109", JIIGOACEIKL);
	}

	private static void HCLIJKJFLFH()
	{
	}

	private static string FJJAGGFMIOE(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp116", JIIGOACEIKL);
	}

	private static string FAEJCHDFPDE(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp112", JIIGOACEIKL);
	}

	private static string CINPMHLHGEA(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp124", JIIGOACEIKL);
	}

	private static string GJNAKNJJHPP(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp77", JIIGOACEIKL);
	}

	private static string OFANLOGAMEB(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp105", JIIGOACEIKL);
	}

	private static void CFGJBIIBBDB(TutorialPopUp FKHFBMFJKDM, int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !CommonReferences.GGFJGHHHEJC.seenPopUps.Contains(FKHFBMFJKDM.DCFNIMCMFEM))
		{
			FKHFBMFJKDM.KKNDBMCIEBL = JIIGOACEIKL;
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(KPGHLIGGJJL(FKHFBMFJKDM));
			CommonReferences.GGFJGHHHEJC.seenPopUps.Add(FKHFBMFJKDM.DCFNIMCMFEM);
			if (VersionNumberManager.IsTheSameOrNewerVersion(VersionNumberManager.instance.versionNumber, VersionNumberManager.instance.ABAEJAMHKHB))
			{
				CommonReferences.GGFJGHHHEJC.seenPopUpsInWorkersVersion.Add(FKHFBMFJKDM.DCFNIMCMFEM);
			}
		}
	}

	private static List<GameObject> GCGIIBAAGKE()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		TutorialManager.GGFJGHHHEJC.ActiveMask(CGMLGEFBJFB, 1);
		return new List<GameObject> { FHPJMEMEMJB(new Vector3(10000f, 10000f, 0f)) };
	}

	private static void GKJPNHCBKLE(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRentAnyRoom = (Action<int>)Delegate.Remove(instance.OnRentAnyRoom, new Action<int>(GKJPNHCBKLE));
			CFGJBIIBBDB(firstRentedRoomPopUp, JIIGOACEIKL);
		}
	}

	private static void BGIKCAMPLNN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnGuestRequestingRoom = (Action<int>)Delegate.Combine(instance.OnGuestRequestingRoom, new Action<int>(NFIEKOKIOEG));
	}

	private static void BOJIOFKOBBE()
	{
		if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			PlayerController player = PlayerController.GetPlayer(2);
			player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(LDILNFEPFLI));
		}
	}

	private static string NCCGMAJLOKK(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp80", JIIGOACEIKL);
	}

	private static void IOPIMOOMMAB()
	{
		for (int i = 0; i < HireStaffUI.instances.Length; i++)
		{
			HireStaffUI obj = HireStaffUI.instances[i];
			obj.OnUIOpen = (Action<int>)Delegate.Combine(obj.OnUIOpen, new Action<int>(MFHCAOMNMAE));
		}
	}

	private static void OOIADJEJAII(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CFGJBIIBBDB(employeeInfoOpen3PopUp, JIIGOACEIKL);
		}
	}

	private static void AGNCACHOGPG(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRentRoomInfoOpen = (Action<int>)Delegate.Remove(instance.OnRentRoomInfoOpen, new Action<int>(AGNCACHOGPG));
			CFGJBIIBBDB(rentRoomInfoOpenPopUp, JIIGOACEIKL);
			HHJJMDCBCHD(JIIGOACEIKL);
		}
	}

	private static string BNMINFACHFO(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp107", JIIGOACEIKL);
	}

	private static void ONINPNJLPDO(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEmployeeInfoOpen = (Action<int>)Delegate.Remove(instance.OnEmployeeInfoOpen, new Action<int>(ONINPNJLPDO));
			CFGJBIIBBDB(employeeInfoOpenPopUp, JIIGOACEIKL);
			KPJGCGJJHOP(JIIGOACEIKL);
		}
	}

	private static void MIEFIABNNLB()
	{
		RepUnlocksManager.OnRepUnlock = (Action<ReputationInfo>)Delegate.Combine(RepUnlocksManager.OnRepUnlock, new Action<ReputationInfo>(JINGGMAECIE));
	}

	private static void PKBDMKLIEEL()
	{
		for (int i = 0; i < CalendarUI.instances.Length; i++)
		{
			CalendarUI obj = CalendarUI.instances[i];
			obj.OnUIOpen = (Action<int>)Delegate.Combine(obj.OnUIOpen, new Action<int>(DGMCDIHPKCA));
		}
	}

	private static string ABCLFIEEOIP(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp104", JIIGOACEIKL);
	}

	private static List<GameObject> PPFJEADFIPB()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (CGMLGEFBJFB == 1)
		{
			GHMDAGIALFH(GDIGPFGIGPL: true);
		}
		else
		{
			MBDALEEBNDI(IFHNAJLPFDF: true);
		}
		TutorialManager.GGFJGHHHEJC.ActiveMask(CGMLGEFBJFB, 0);
		return new List<GameObject> { FHPJMEMEMJB(new Vector3(10000f, 10000f, 0f)) };
	}

	private static string BJNEJPBHELD(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp95", JIIGOACEIKL);
	}

	private static void JMBIOAFAHCH()
	{
		Trends instance = Trends.GGFJGHHHEJC;
		instance.OnUniqueItemsCalculated = (Action<int>)Delegate.Combine(instance.OnUniqueItemsCalculated, new Action<int>(JDAEECPOCHO));
	}

	private static string ELGNOLMAAHG(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp29", JIIGOACEIKL);
	}

	private static void EANLPKMDILG()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRentRoomInfoOpen = (Action<int>)Delegate.Combine(instance.OnRentRoomInfoOpen, new Action<int>(AGNCACHOGPG));
	}

	private static void JINGGMAECIE(ReputationInfo JDNIAEJMELH)
	{
		if (!((Object)(object)JDNIAEJMELH != (Object)(object)RepUnlocksManager.GetInstance().repUnlockTrends) && TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			RepUnlocksManager.OnRepUnlock = (Action<ReputationInfo>)Delegate.Remove(RepUnlocksManager.OnRepUnlock, new Action<ReputationInfo>(JINGGMAECIE));
			CFGJBIIBBDB(trendsPopUp, 1);
		}
	}

	private static void BOHCABCMBAI(TavernEvent BDIDEOLPCEI)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && BDIDEOLPCEI.eventType == TREventType.ImportantGuest)
		{
			TavernEventManager.OnEventAdded = (Action<TavernEvent>)Delegate.Remove(TavernEventManager.OnEventAdded, new Action<TavernEvent>(BOHCABCMBAI));
			CFGJBIIBBDB(specialEventGuestAddedPopUp, 1);
		}
	}

	private static void BEKKOIHIJGK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBouncerGoingToWork = (Action<int>)Delegate.Combine(instance.OnBouncerGoingToWork, new Action<int>(CJNCAJJMDPK));
	}

	private static void JFMKADGJDHP(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyEmployeeHired = (Action<int>)Delegate.Remove(instance.OnAnyEmployeeHired, new Action<int>(JFMKADGJDHP));
			CFGJBIIBBDB(employeeHiredPopUp, JIIGOACEIKL);
		}
	}

	private static void KPFAJNIPLBK()
	{
		RentRoomUI rentRoomUI = RentRoomUI.Get(1);
		rentRoomUI.OnUIOpen = (Action<int>)Delegate.Combine(rentRoomUI.OnUIOpen, new Action<int>(LGCJBHHLDAI));
		RentRoomUI rentRoomUI2 = RentRoomUI.Get(2);
		rentRoomUI2.OnUIOpen = (Action<int>)Delegate.Combine(rentRoomUI2.OnUIOpen, new Action<int>(LGCJBHHLDAI));
	}

	private static GameObject FHPJMEMEMJB(Vector3 IMOBLFMHKOD, bool HOMFPAFAOGD = false)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (!HOMFPAFAOGD)
		{
			return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.arrowPointPrefab, IMOBLFMHKOD, Quaternion.identity, ((Component)TutorialManager.GGFJGHHHEJC).gameObject.transform);
		}
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.arrowPointUIPrefab, IMOBLFMHKOD, Quaternion.Euler(0f, 0f, -90f), ((Component)MenuUI.GGFJGHHHEJC).gameObject.transform);
	}

	private static void ADLJOCEICFO()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnGuestLeaving = (Action<int>)Delegate.Combine(instance.OnGuestLeaving, new Action<int>(KJNPHJMDNIC));
	}

	private static string KMFECKBOLIP(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp82", JIIGOACEIKL);
	}

	private static void OPNAGMHLEFL()
	{
		if (!((Object)(object)PlayerController.GetPlayer(1) == (Object)null))
		{
			PlayerController player = PlayerController.GetPlayer(1);
			player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(LDILNFEPFLI));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(BOJIOFKOBBE));
		}
	}

	private static void LDILNFEPFLI(int JIIGOACEIKL, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		if (GIBJPCAFCJB == ZoneType.RentedRoom && TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			PlayerController player = PlayerController.GetPlayer(1);
			player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(player.OnZoneChanged, new Action<int, ZoneType, int>(LDILNFEPFLI));
			GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(BOJIOFKOBBE));
			if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
			{
				PlayerController player2 = PlayerController.GetPlayer(2);
				player2.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(player2.OnZoneChanged, new Action<int, ZoneType, int>(LDILNFEPFLI));
			}
			CFGJBIIBBDB(enterRentRoomPopUp, JIIGOACEIKL);
		}
	}

	private static void NJEIAHCEDNK()
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(NJEIAHCEDNK));
			CFGJBIIBBDB(player2ChestPopUp, 2);
		}
	}

	private static void CGDALLJNNKD()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnHouseKeeperGoingToWork = (Action<int>)Delegate.Combine(instance.OnHouseKeeperGoingToWork, new Action<int>(MAILNLIPMPF));
	}

	private static void AJBAIGKGLGM()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyEmployeeHired = (Action<int>)Delegate.Combine(instance.OnAnyEmployeeHired, new Action<int>(JFMKADGJDHP));
	}

	private static void LGCJBHHLDAI(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			RentRoomUI rentRoomUI = RentRoomUI.Get(1);
			rentRoomUI.OnUIOpen = (Action<int>)Delegate.Remove(rentRoomUI.OnUIOpen, new Action<int>(LGCJBHHLDAI));
			RentRoomUI rentRoomUI2 = RentRoomUI.Get(2);
			rentRoomUI2.OnUIOpen = (Action<int>)Delegate.Remove(rentRoomUI2.OnUIOpen, new Action<int>(LGCJBHHLDAI));
			CFGJBIIBBDB(customerAskRoomPopUp, JIIGOACEIKL);
		}
	}

	private static void FMCEJJLAKNE()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRentAnyRoom = (Action<int>)Delegate.Combine(instance.OnRentAnyRoom, new Action<int>(GKJPNHCBKLE));
	}

	private static void NFIEKOKIOEG(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnGuestRequestingRoom = (Action<int>)Delegate.Remove(instance.OnGuestRequestingRoom, new Action<int>(NFIEKOKIOEG));
			CFGJBIIBBDB(firstGuestRequestingRoomPopUp, JIIGOACEIKL);
		}
	}

	private static void PMKJHGEPGNG()
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnGuestSpawn = (Action)Delegate.Remove(instance.OnGuestSpawn, new Action(PMKJHGEPGNG));
			CFGJBIIBBDB(importantGuestSpawnPopUp, 1);
		}
	}

	private static string FHEDGPPAACO(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp108", JIIGOACEIKL);
	}

	private static void LBJNKHBDDNM()
	{
	}

	private static void PEPDANOMDAA()
	{
	}

	private static void OLMIGEJGCMP(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyEmployeeAvoidingWork = (Action<int>)Delegate.Remove(instance.OnAnyEmployeeAvoidingWork, new Action<int>(OLMIGEJGCMP));
			CFGJBIIBBDB(employeeAvoidingWorkPopUp, JIIGOACEIKL);
		}
	}

	private static string LIGBDDLEFAH(int JIIGOACEIKL)
	{
		return LocalisationSystem.GetStringWithTags("tutorialPopUp102", JIIGOACEIKL);
	}
}
