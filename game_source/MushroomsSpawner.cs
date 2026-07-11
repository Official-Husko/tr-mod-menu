using System;
using System.Collections.Generic;
using UnityEngine;

public class MushroomsSpawner : MonoBehaviour
{
	public Transform[] spawners;

	[SerializeField]
	private List<Transform> listSpawners = new List<Transform>();

	public GameObject[] mushrooms;

	public int minMush;

	public int maxMush;

	private int LLPGKHHKCLC;

	private int IFFMEJBECPK;

	private void PNLAJCHBHPH()
	{
		if (Utils.FFLNGLMHLBO())
		{
			JOIDFGFEFAM();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(AGLKDJBDNGF));
		}
	}

	public void FEDFIOJOAMD()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 1; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void LALJNGFGKPA()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(LJMDNAJDMDO));
		}
	}

	public void MGOAKBALJEI()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 1; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	public void BJBKHIACCCM()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 1; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void NNMFLMJDKNH()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(AJPKNCKEFEJ));
		}
	}

	public void FBNGDFKNKAO()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 1; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	public void MFPGLBFENOP()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 1; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void HLCAKACHOOE()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(MFPGLBFENOP));
		}
	}

	private void LHABENPEMPB()
	{
		if (Utils.FFLNGLMHLBO())
		{
			HABNGHAGOCE();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(JJCHJIBBEKG));
		}
	}

	private void HKECEBGKACL()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(AHIDHBCPGJK));
		}
	}

	public void ILHDPKIEIBN()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 1; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	public void AHIDHBCPGJK()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 0; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void FDNAEJDHODK()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(GPILFKEPHJD));
		}
	}

	private void KLHIMJFCHPD()
	{
		if (Utils.FFLNGLMHLBO())
		{
			AHIDHBCPGJK();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(EOPHJNFMCFF));
		}
	}

	private void CDHBLKJEOPI()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(DJGDMFPMAAK));
		}
	}

	public void EOPHJNFMCFF()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 1; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void EMJKKALMGLK()
	{
		if (Utils.FFLNGLMHLBO())
		{
			FGFNAKDGFEL();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MKMPPLOENHJ));
		}
	}

	private void AIEKBPENOKC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(MKMPPLOENHJ));
		}
	}

	private void GOJKOBEEMNA()
	{
		if (Utils.FFLNGLMHLBO())
		{
			EOPHJNFMCFF();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MKMPPLOENHJ));
		}
	}

	private void LKHMCLABKLG()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(EOPHJNFMCFF));
		}
	}

	private void CLNBMOPMNOF()
	{
		if (Utils.FFLNGLMHLBO())
		{
			JGLOEGEHIEN();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(JGLOEGEHIEN));
		}
	}

	private void KJHKBGDJNDC()
	{
		if (Utils.FFLNGLMHLBO())
		{
			MFPGLBFENOP();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(BJBKHIACCCM));
		}
	}

	private void LADLGPKMPBP()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(CNOMFAEFGMH));
		}
	}

	private void DADPOICMNPI()
	{
		if (Utils.FFLNGLMHLBO())
		{
			MKMPPLOENHJ();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(LJMDNAJDMDO));
		}
	}

	private void OCPLOMJAFPC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(BJBKHIACCCM));
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(LJMDNAJDMDO));
		}
	}

	public void JGLOEGEHIEN()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 1; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void JDHHJKBOJML()
	{
		if (Utils.FFLNGLMHLBO())
		{
			AGLKDJBDNGF();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(LJMDNAJDMDO));
		}
	}

	public void PADHIKJPHBC()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 1; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	public void AKKJDKJAAIF()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 0; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void CLLAKJADGIH()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(FGFNAKDGFEL));
		}
	}

	private void OBHFJIDKBJN()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(BODAAHHGALH));
		}
	}

	private void PEOPFPEDFAK()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(EOPHJNFMCFF));
		}
	}

	private void LNPDALMANFB()
	{
		if (Utils.FFLNGLMHLBO())
		{
			GPILFKEPHJD();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(ILHDPKIEIBN));
		}
	}

	private void DNBGIIGAKMJ()
	{
		if (Utils.FFLNGLMHLBO())
		{
			JGLOEGEHIEN();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(GPILFKEPHJD));
		}
	}

	private void MIKNFPCDLML()
	{
		if (Utils.FFLNGLMHLBO())
		{
			AJPKNCKEFEJ();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(ENMHDBLBOML));
		}
	}

	public void SpawnMushrooms()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 0; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void OGEJKOIOKAN()
	{
		if (Utils.FFLNGLMHLBO())
		{
			BJBKHIACCCM();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MGOAKBALJEI));
		}
	}

	private void FBHHPNJGNJG()
	{
		if (Utils.FFLNGLMHLBO())
		{
			EOPHJNFMCFF();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DJGDMFPMAAK));
		}
	}

	public void MKMPPLOENHJ()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 1; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void EGHOIJHBDBP()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(HABNGHAGOCE));
		}
	}

	public void ENMHDBLBOML()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 1; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void KOBNHPKEJJD()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(GPILFKEPHJD));
		}
	}

	private void JNJCCIFIKOC()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(HABNGHAGOCE));
		}
	}

	private void GHDBHNMOBMN()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(ENMHDBLBOML));
		}
	}

	private void FGFGCADFFBC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(FGFNAKDGFEL));
		}
	}

	private void GECHJIGBPEN()
	{
		if (Utils.FFLNGLMHLBO())
		{
			CNOMFAEFGMH();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(SpawnMushrooms));
		}
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(MKMPPLOENHJ));
		}
	}

	private void FLOFJHNAIKP()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(FBNGDFKNKAO));
		}
	}

	public void DJGDMFPMAAK()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 1; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	public void GPILFKEPHJD()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 1; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void EIDJLHFAMIB()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(BODAAHHGALH));
		}
	}

	private void JBBHDOMALDB()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(JOIDFGFEFAM));
		}
	}

	public void JJCHJIBBEKG()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 0; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void ALCJOABPBMA()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(HEMOPOHKMMJ));
		}
	}

	private void NJAFKFAPDIE()
	{
		if (Utils.FFLNGLMHLBO())
		{
			JOIDFGFEFAM();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(BIMOIGFOMDD));
		}
	}

	public void MJDFKEJKOIM()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 0; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void ACFABFCGIGH()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(MFPGLBFENOP));
		}
	}

	private void BLAJFMAAMDO()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(AHIDHBCPGJK));
		}
	}

	public void LJMDNAJDMDO()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 0; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	public void CNOMFAEFGMH()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 0; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void KHONOODGLBI()
	{
		if (Utils.FFLNGLMHLBO())
		{
			ILHDPKIEIBN();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MKMPPLOENHJ));
		}
	}

	private void KMBEOPAHKGB()
	{
		if (Utils.FFLNGLMHLBO())
		{
			FBNGDFKNKAO();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(BJBKHIACCCM));
		}
	}

	public void JOIDFGFEFAM()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 1; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void PCEFNHADDIG()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(CNOMFAEFGMH));
		}
	}

	private void Awake()
	{
		if (Utils.FFLNGLMHLBO())
		{
			SpawnMushrooms();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(SpawnMushrooms));
		}
	}

	private void IBMDFNKKPJF()
	{
		if (Utils.FFLNGLMHLBO())
		{
			MFPGLBFENOP();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(FBNGDFKNKAO));
		}
	}

	private void OCJOAHDNDIJ()
	{
		if (Utils.FFLNGLMHLBO())
		{
			DJGDMFPMAAK();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(BODAAHHGALH));
		}
	}

	private void AGELAMLCINB()
	{
		if (Utils.FFLNGLMHLBO())
		{
			EOPHJNFMCFF();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DJGDMFPMAAK));
		}
	}

	public void BIMOIGFOMDD()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 1; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	public void AJPKNCKEFEJ()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 1; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(SpawnMushrooms));
		}
	}

	private void JIAJFDKNJME()
	{
		if (Utils.FFLNGLMHLBO())
		{
			JOIDFGFEFAM();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(BODAAHHGALH));
		}
	}

	private void HHMBCKCNPPN()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(MKMPPLOENHJ));
		}
	}

	private void GADEGOPBNGC()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(FEDFIOJOAMD));
		}
	}

	private void CACJMKJBJDP()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(MGOAKBALJEI));
		}
	}

	public void PKNOMNMGELI()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 1; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	public void HEMOPOHKMMJ()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 1; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	public void BODAAHHGALH()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 0; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	public void HABNGHAGOCE()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 0; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void HNNBAAJAHEN()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(JGLOEGEHIEN));
		}
	}

	public void AGLKDJBDNGF()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 1);
		for (int j = 1; j < LLPGKHHKCLC; j += 0)
		{
			IFFMEJBECPK = Random.Range(0, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(0, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void DEKGNHEHKFB()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(FEDFIOJOAMD));
		}
	}

	private void PHNJGHKBIIL()
	{
		if (Utils.FFLNGLMHLBO())
		{
			FEDFIOJOAMD();
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(AHIDHBCPGJK));
		}
	}

	private void DONGKOKMGMM()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(BODAAHHGALH));
		}
	}

	public void FGFNAKDGFEL()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		LLPGKHHKCLC = Random.Range(minMush, maxMush + 0);
		for (int j = 0; j < LLPGKHHKCLC; j++)
		{
			IFFMEJBECPK = Random.Range(1, listSpawners.Count);
			Object.Instantiate<GameObject>(mushrooms[Random.Range(1, mushrooms.Length)], listSpawners[IFFMEJBECPK].position, listSpawners[IFFMEJBECPK].rotation, listSpawners[IFFMEJBECPK]);
			listSpawners.Remove(listSpawners[IFFMEJBECPK]);
		}
	}

	private void KPILPDFCHBG()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(CNOMFAEFGMH));
		}
	}
}
