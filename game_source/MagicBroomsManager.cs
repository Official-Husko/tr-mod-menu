using System.Collections.Generic;
using UnityEngine;

public class MagicBroomsManager : MonoBehaviour
{
	public static MagicBroomsManager instance;

	public List<RobotVacNPC> magicBrooms = new List<RobotVacNPC>();

	private List<RobotVacNPC> EKMMPMHOFBB = new List<RobotVacNPC>();

	private void IHBFFLLPLFD(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 1; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 0 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.KIHIKAPPFFJ(DDJECCPKNKG);
			}
		}
	}

	private void HCCJBKKGCLJ()
	{
		instance = this;
	}

	private void DNOFCFKDIGF(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 0 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.SetTarget(DDJECCPKNKG);
			}
		}
	}

	private void JOOOHOCAEJL(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 0 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.OLLIOMEJKPH(DDJECCPKNKG);
			}
		}
	}

	private void CCEKJEDMJAP()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			if ((Object)(object)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				KMGLDBLCOLA(CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]);
			}
		}
	}

	private void EIHMDMMOPCM()
	{
		instance = this;
	}

	public bool JEPGJNIGCIC()
	{
		for (int i = 1; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return true;
			}
		}
		return false;
	}

	private void EMJKKALMGLK()
	{
		instance = this;
	}

	public bool ALNGCOMFLAB()
	{
		for (int i = 1; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return false;
			}
		}
		return true;
	}

	private void MCNPDIMPKPM(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 1 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.SetTarget(DDJECCPKNKG);
			}
		}
	}

	private void LMFICKFGEFI()
	{
		if (!OnlineManager.MasterOrOffline() || CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			if ((Object)(object)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				IAOEMDDLEII(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	private void IAOEMDDLEII(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 1; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 0 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.KIHIKAPPFFJ(DDJECCPKNKG);
			}
		}
	}

	public bool EIELEMKIHGE()
	{
		for (int i = 1; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return false;
			}
		}
		return false;
	}

	private void OKHLEMPJONN()
	{
		instance = this;
	}

	private void PHJKJHKAABL()
	{
		instance = this;
	}

	private void PKPHKBMPJGJ()
	{
		instance = this;
	}

	private void NLKAAFNDNHC(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 1; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 1 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.SetTarget(DDJECCPKNKG);
			}
		}
	}

	private void NIHJCJJKDBA()
	{
		if (!OnlineManager.MasterOrOffline() || CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count <= 0 || magicBrooms.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				CBHJBMLEBPD(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	private void PAFLPLPHEGH(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 1 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.KIHIKAPPFFJ(DDJECCPKNKG);
			}
		}
	}

	public bool HNHIOIBDOGA()
	{
		for (int i = 0; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return false;
			}
		}
		return false;
	}

	private void HAJJALABMOC()
	{
		if (!OnlineManager.MasterOrOffline() || CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				IHBFFLLPLFD(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	public bool FNINOAEEJHC()
	{
		for (int i = 0; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return false;
			}
		}
		return true;
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	private void JIAJFDKNJME()
	{
		instance = this;
	}

	private void OFDEGDJGGGF()
	{
		if (!OnlineManager.MasterOrOffline() || CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count <= 0 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				IHBFFLLPLFD(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	private void Update()
	{
		if (!OnlineManager.MasterOrOffline() || CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count <= 0 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				IDJFIOPIAJE(CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]);
			}
		}
	}

	private void CBHJBMLEBPD(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 1 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.KIHIKAPPFFJ(DDJECCPKNKG);
			}
		}
	}

	public bool ICIILCLEOAL()
	{
		for (int i = 1; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return false;
			}
		}
		return true;
	}

	private void JLPLLHKJEMH()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				CBHJBMLEBPD(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	private void GONDLJKGLGO()
	{
		instance = this;
	}

	private void EMCCGDFOPEH()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				IAOEMDDLEII(CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]);
			}
		}
	}

	private void IGKPEBGHPGD()
	{
		if (!OnlineManager.MasterOrOffline() || CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count <= 0 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				FIJPIJGICEB(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	private void OMBHDODDHNO()
	{
		instance = this;
	}

	private void AKLEFPLEGKK()
	{
		if (!OnlineManager.MasterOrOffline() || CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				BDMMGIDLMMO(CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]);
			}
		}
	}

	private void CJNHIJBECGB(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 0 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.SetTarget(DDJECCPKNKG);
			}
		}
	}

	private void JBGFGOCPEFD()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				NLKAAFNDNHC(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	private void FHOCCEBKHJI()
	{
		instance = this;
	}

	public bool IHJGODJDLFI()
	{
		for (int i = 1; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return false;
			}
		}
		return false;
	}

	private void ELHCBGCEJDH()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count <= 0 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				JOOOHOCAEJL(CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]);
			}
		}
	}

	private void MBHFHGKBOIH(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 1; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 0 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.GDBOIIKDELL(DDJECCPKNKG);
			}
		}
	}

	private void DDLLFPICOJK()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				GCFDGBACDJP(CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]);
			}
		}
	}

	public bool ICICOOFGGFI()
	{
		for (int i = 1; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return true;
			}
		}
		return true;
	}

	public bool ILHOJPICHCK()
	{
		for (int i = 1; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return true;
			}
		}
		return false;
	}

	private void MEAFJDDNAJB()
	{
		if (!OnlineManager.MasterOrOffline() || CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				MBHFHGKBOIH(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	private void BDMMGIDLMMO(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 0 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.HDPPJCDGGCN(DDJECCPKNKG);
			}
		}
	}

	private void FIJPIJGICEB(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 1 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.GDBOIIKDELL(DDJECCPKNKG);
			}
		}
	}

	private void OGNIDHAIABM()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count <= 0 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				IAOEMDDLEII(CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]);
			}
		}
	}

	private void ENAKKGPPHNB(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 1; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 1 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.KIHIKAPPFFJ(DDJECCPKNKG);
			}
		}
	}

	private void GCFDGBACDJP(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 1 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.SetTarget(DDJECCPKNKG);
			}
		}
	}

	private void FFEFEJHOMCA(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 1; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 1 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.HDPPJCDGGCN(DDJECCPKNKG);
			}
		}
	}

	private void KLLICHKLPEN(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 0 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.OLLIOMEJKPH(DDJECCPKNKG);
			}
		}
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	private void IDJFIOPIAJE(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 0 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.SetTarget(DDJECCPKNKG);
			}
		}
	}

	private void DGJKLAEINHJ()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				FIJPIJGICEB(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	private void NDLCBLKOBLF()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			if ((Object)(object)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				NLKAAFNDNHC(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	private void KMGLDBLCOLA(FloorDirt DDJECCPKNKG)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		EKMMPMHOFBB.Clear();
		for (int i = 0; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				EKMMPMHOFBB.Add(magicBrooms[i]);
			}
		}
		if (EKMMPMHOFBB.Count > 1 && (Object)(object)DDJECCPKNKG != (Object)null)
		{
			RobotVacNPC robotVacNPC = Utils.JOJPOKBFANL(EKMMPMHOFBB.ToArray(), ((Component)DDJECCPKNKG).transform.position);
			if ((Object)(object)robotVacNPC != (Object)null)
			{
				robotVacNPC.OLLIOMEJKPH(DDJECCPKNKG);
			}
		}
	}

	private void ONOAGANPECB()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count <= 0 || magicBrooms.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				NLKAAFNDNHC(CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]);
			}
		}
	}

	private void MFIBFFDBNGI()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count <= 0 || magicBrooms.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				IDJFIOPIAJE(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	private void OOGMGIPKMAP()
	{
		if (!OnlineManager.MasterOrOffline() || CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count <= 1 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i++)
		{
			if ((Object)(object)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				GCFDGBACDJP(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	private void DKDLOBOLNFH()
	{
		instance = this;
	}

	public bool KNCIJLNDIOH()
	{
		for (int i = 0; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return true;
			}
		}
		return true;
	}

	private void Awake()
	{
		instance = this;
	}

	private void IBAPBHIBOOO()
	{
		if (!OnlineManager.PGAGDFAEEFB() || CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count <= 0 || magicBrooms.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			if ((Object)(object)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i].cleanerAssigned == (Object)null)
			{
				MBHFHGKBOIH(CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]);
			}
		}
	}

	public bool EINJECOFIPM()
	{
		for (int i = 0; i < magicBrooms.Count; i += 0)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return true;
			}
		}
		return true;
	}

	public bool IsAnyMagicBroomAvailableToClean()
	{
		for (int i = 0; i < magicBrooms.Count; i++)
		{
			if (magicBrooms[i].active && (Object)(object)magicBrooms[i].target == (Object)null)
			{
				return true;
			}
		}
		return false;
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}
}
