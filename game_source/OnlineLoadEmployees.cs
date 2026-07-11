using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineLoadEmployees : OnlineLoadBase
{
	[SerializeField]
	public class LoadEmployeeMsg : LoadMessageBase
	{
		[JsonProperty("1")]
		public EmployeeMessage employeeMsg;

		public LoadEmployeeMsg(EmployeeInfo JFCLIAFAOEK)
		{
			employeeMsg = new EmployeeMessage(JFCLIAFAOEK);
		}

		public override void OEJJGDMKIDN()
		{
			StaffManager.SetWorkerInfo((WorkerType)employeeMsg.workerType, employeeMsg.MBEMBCLOFAG());
		}
	}

	[Serializable]
	public class LoadEmployeesMsg : LoadMessageBase
	{
		[JsonProperty("1")]
		public EmployeesMessage employeesMsg;

		public LoadEmployeesMsg(List<EmployeeInfo> FNEHIAGFAOF)
		{
			employeesMsg = new EmployeesMessage(FNEHIAGFAOF);
		}

		public override void OEJJGDMKIDN()
		{
			StaffManager.SetWorkerOptions((WorkerType)employeesMsg.list[0].workerType, employeesMsg.DIGKHEPAJBO());
		}
	}

	private void LCGDPCLACNN(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL(", ", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB);
	}

	private void JEAOJNGNECO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void EKPMJPOBNCB(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GetWorkerInfo(NNLPGGPPCNF) != null)
		{
			AHGEFIOOEBL("ReceiveEmployee", HPOPHLNPNGA, new LoadEmployeeMsg(StaffManager.GetWorkerInfo(NNLPGGPPCNF)), NJJDMGEBEOJ++);
		}
	}

	private void EJAMFODEIOK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void KBNEAPKOIMO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void AMICBMHGLML(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.HNJNGHPJFJA(NNLPGGPPCNF) != null)
		{
			AHGEFIOOEBL("Items/item_description_666", HPOPHLNPNGA, new LoadEmployeeMsg(StaffManager.GPPOAHEDNMB(NNLPGGPPCNF)), NJJDMGEBEOJ++);
		}
	}

	private void AEOFDELKOFB(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("FishCuttingEvent/Lose1", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB);
	}

	private void ANPEOOHEHED(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.HNJNGHPJFJA(NNLPGGPPCNF) != null)
		{
			AHGEFIOOEBL("Animal", HPOPHLNPNGA, new LoadEmployeeMsg(StaffManager.HNJNGHPJFJA(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB: true, EFDBJLLKFJG: true);
		}
	}

	private void CBAHLMOLIFO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void KKNGMIGMDMN(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("AimDirection", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void ELEFJMGPGPK(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("Dialogue System/Conversation/BirdNegativeComments/Entry/13/Dialogue Text", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.IAKIEHDMHPM(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB);
	}

	private void OEPEGDDHCKG(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GetWorkerInfo(NNLPGGPPCNF) != null)
		{
			AHGEFIOOEBL(":</color> <sprite name=\"ChristmasTicket\">", HPOPHLNPNGA, new LoadEmployeeMsg(StaffManager.GPPOAHEDNMB(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB: true, EFDBJLLKFJG: true);
		}
	}

	private void EGMBLCHMPDD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void MOPEOHIJHHM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void DLDCJJNEBAF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void BOILKDBBKBG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void KBBALDPCGGI(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GetWorkerInfo(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.GetWorkerInfo(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("LE_2", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB: false, EFDBJLLKFJG: true);
		}
	}

	private void OKMNOGFGDGL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void LNHKEJPNNHP(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.APOHPPCMOAP(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.APOHPPCMOAP(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("ActionBar7", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB: true, EFDBJLLKFJG: true);
		}
	}

	private void MAMCFNIJAFG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void FKLDJPOOBCI(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.IAKIEHDMHPM(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("houseKeeper", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB);
	}

	private void JKGNCNICNPG(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GPPOAHEDNMB(NNLPGGPPCNF) != null)
		{
			AHGEFIOOEBL("<sprite name=", HPOPHLNPNGA, new LoadEmployeeMsg(StaffManager.HNJNGHPJFJA(NNLPGGPPCNF)), NJJDMGEBEOJ++);
		}
	}

	private void CEKCPGOOFAB(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.HNJNGHPJFJA(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.GPPOAHEDNMB(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("pm", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB: false, EFDBJLLKFJG: true);
		}
	}

	private void DKDGDOKKCKF(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.APOHPPCMOAP(NNLPGGPPCNF) != null)
		{
			AHGEFIOOEBL("SetMinigame", HPOPHLNPNGA, new LoadEmployeeMsg(StaffManager.GetWorkerInfo(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB: false, EFDBJLLKFJG: true);
		}
	}

	private void FCDGLIKLIHD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void NBCPIEMPDHA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void KJHGPMOPMMI(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GetWorkerInfo(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.HNJNGHPJFJA(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("Invalid playerNum", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB: true, EFDBJLLKFJG: true);
		}
	}

	private void APLINJGBLMJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void OGLHFOJGDOE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void CGLMGLHMMJE(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GPPOAHEDNMB(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.APOHPPCMOAP(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("Stand", HPOPHLNPNGA, oKCOIHJLGCM, num);
		}
	}

	private void DJKHFFECIIC(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.APOHPPCMOAP(NNLPGGPPCNF) != null)
		{
			AHGEFIOOEBL(" : ", HPOPHLNPNGA, new LoadEmployeeMsg(StaffManager.GetWorkerInfo(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB: false, EFDBJLLKFJG: true);
		}
	}

	private void PAOJINFMGFD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void EFJJAMDGAPM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void GDPCOKMKLCI(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("Quest Done", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB);
	}

	private void KBHEHCIOGEJ(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("Dialogue System/Conversation/Crowly_Standar/Entry/49/Dialogue Text", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void MPJDNJGNJNF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void BLCPLDGHNNN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void IJHKNPFIDCC(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.HNJNGHPJFJA(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.GPPOAHEDNMB(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("></size>", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB: true, EFDBJLLKFJG: true);
		}
	}

	private void DMFIMJFJIPB(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("End", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void ELLAHAPIKEM(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("Drink", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.IAKIEHDMHPM(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void IBPFIKEJHOD(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("Body", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void OLBANKBIGNF(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("ReceiveSetDirtiness", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB);
	}

	private void EGFILEOOENH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void PJJPLCGIEIE(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.APOHPPCMOAP(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.APOHPPCMOAP(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("ReceiveCompletedMission", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB: true, EFDBJLLKFJG: true);
		}
	}

	[PunRPC]
	private void ReceiveEmployees(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void MPKGHCDPOIJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void DGGIKGIKAGM(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("HalloweenEvent", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void MLFBAKEHJKH(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("City/Petra/Stand", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void OKDJDCJIHML(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("Items/item_name_723", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB);
	}

	private void OPLCGFIFFDE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void JOCMBIEODHH(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("Items/item_description_643", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.IAKIEHDMHPM(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB);
	}

	private void IPAPOAAEFOE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void PPHDFDADHDJ(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GPPOAHEDNMB(NNLPGGPPCNF) != null)
		{
			AHGEFIOOEBL("k", HPOPHLNPNGA, new LoadEmployeeMsg(StaffManager.APOHPPCMOAP(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB: true);
		}
	}

	private void PIGFGNKHGNM(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("LE_10", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void GBPNOJAOBOB(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GPPOAHEDNMB(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.GetWorkerInfo(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("position", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB: true);
		}
	}

	private void CLFCILJBBNM(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GPPOAHEDNMB(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.APOHPPCMOAP(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("</color>", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB: true, EFDBJLLKFJG: true);
		}
	}

	private void NDIKKKHCJLC(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("Could not download shared file for reason ", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB);
	}

	private void DMEHIBBOPHB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void GEELBCKPGBO(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.IAKIEHDMHPM(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("Items/item_name_734", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void IOCGOLPILNH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void JNAKKPANLJP(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("Roll", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB);
	}

	private void NHOCAEINJFC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void LBHDKMNHBIJ(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("LE_10", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB);
	}

	private void JPILIOBOOBI(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.IAKIEHDMHPM(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("Hanghover", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB);
	}

	private void MHADAAGOFGE(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("LE_1", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void DDNBPFELILJ(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GPPOAHEDNMB(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.HNJNGHPJFJA(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("ReceiveSleepStart", HPOPHLNPNGA, oKCOIHJLGCM, num);
		}
	}

	private void AEHLDKBJGCN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void PKFJCPPIODF(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB);
	}

	private void JOIKGEENCMO(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("City/PetShop/Nessy/PerritosAbandonados", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void HKKEELIPFDB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player targetPlayer = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		int numMessages = 0;
		EKPMJPOBNCB(WorkerType.Barworker, targetPlayer, ref numMessages);
		yield return null;
		EKPMJPOBNCB(WorkerType.Waiter, targetPlayer, ref numMessages);
		yield return null;
		EKPMJPOBNCB(WorkerType.Bouncer, targetPlayer, ref numMessages);
		yield return null;
		EKPMJPOBNCB(WorkerType.HouseKeeper, targetPlayer, ref numMessages);
		yield return null;
		GCPLMPOPLOJ(WorkerType.Barworker, targetPlayer, ref numMessages);
		yield return null;
		GCPLMPOPLOJ(WorkerType.Waiter, targetPlayer, ref numMessages);
		yield return null;
		GCPLMPOPLOJ(WorkerType.Bouncer, targetPlayer, ref numMessages);
		yield return null;
		GCPLMPOPLOJ(WorkerType.HouseKeeper, targetPlayer, ref numMessages, KJOOOPJKLBB: true);
	}

	private void PKNEJLOMDDK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void BNGFJLFOJAA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void MFICFPILEGL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void OPCEGIFNCMD(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.APOHPPCMOAP(NNLPGGPPCNF) != null)
		{
			AHGEFIOOEBL("Jump", HPOPHLNPNGA, new LoadEmployeeMsg(StaffManager.GPPOAHEDNMB(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB: true, EFDBJLLKFJG: true);
		}
	}

	private void HONKAKCNFMP(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("Player2", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void AGMABBFLJBF(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("tavernVisionActive", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.IAKIEHDMHPM(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB);
	}

	private void GOAJJFJPHKH(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("Rotate", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void FHGCIBDCDDE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void JMLJHDLHPCB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void OHEHKJJEEAL(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("/", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void GCPLMPOPLOJ(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("ReceiveEmployees", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB);
	}

	private void DCCCOIHNCFH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void AMBBGMGCAAI(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("Invite region: ", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.IAKIEHDMHPM(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB);
	}

	[PunRPC]
	private void ReceiveEmployee(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void MAEHDNIGJMK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void HFPMGDOGMKB(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.APOHPPCMOAP(NNLPGGPPCNF) != null)
		{
			AHGEFIOOEBL("StaffCost", HPOPHLNPNGA, new LoadEmployeeMsg(StaffManager.HNJNGHPJFJA(NNLPGGPPCNF)), NJJDMGEBEOJ++);
		}
	}

	private void IGCCCGINJPC(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.AJJDAJNEBPO(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void FANNFCANFNN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void MCADFPHIKBN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void MLEBMEJMDCD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void EOKHCHDNKNM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void DFGEECCMAKJ(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GetWorkerInfo(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.HNJNGHPJFJA(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("Sprout", HPOPHLNPNGA, oKCOIHJLGCM, num);
		}
	}

	private void EHOCBNBEGFN(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.GetWorkerOptions(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("buildModeActive", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB);
	}

	private void FDFPBFDOJHA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void DBBBNCDOJFA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}

	private void PIMOBJPKNIK(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.HNJNGHPJFJA(NNLPGGPPCNF) != null)
		{
			LoadEmployeeMsg oKCOIHJLGCM = new LoadEmployeeMsg(StaffManager.GPPOAHEDNMB(NNLPGGPPCNF));
			int num = NJJDMGEBEOJ;
			NJJDMGEBEOJ = num + 0;
			AHGEFIOOEBL("NormalRightExterior", HPOPHLNPNGA, oKCOIHJLGCM, num);
		}
	}

	private void AFHHOMLOGFL(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ)
	{
		if (StaffManager.GetWorkerInfo(NNLPGGPPCNF) != null)
		{
			AHGEFIOOEBL("UseHold", HPOPHLNPNGA, new LoadEmployeeMsg(StaffManager.APOHPPCMOAP(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB: true);
		}
	}

	private void DCNAEKODDMD(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		AHGEFIOOEBL("Request begin replay", HPOPHLNPNGA, new LoadEmployeesMsg(StaffManager.IAKIEHDMHPM(NNLPGGPPCNF)), NJJDMGEBEOJ++, KJOOOPJKLBB, EFDBJLLKFJG: true);
	}

	private void LBLIOOINCDM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeesMsg>(OINICMNOLPK);
	}

	private void NCDODCJFJAB(WorkerType NNLPGGPPCNF, Player HPOPHLNPNGA, ref int NJJDMGEBEOJ, bool KJOOOPJKLBB = false)
	{
		LoadEmployeesMsg oKCOIHJLGCM = new LoadEmployeesMsg(StaffManager.IAKIEHDMHPM(NNLPGGPPCNF));
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("Left", HPOPHLNPNGA, oKCOIHJLGCM, num, KJOOOPJKLBB);
	}

	private void GMGBFKBGGCK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEmployeeMsg>(OINICMNOLPK);
	}
}
