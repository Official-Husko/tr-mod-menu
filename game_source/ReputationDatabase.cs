using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Reputation Database")]
public class ReputationDatabase : ScriptableObject
{
	[Serializable]
	public class ReputationLine
	{
		public int repNumber;

		public int floorDisponible;

		public int diningZonesNumber;

		public int diningTiles;

		public int craftingZonesNumber;

		public int craftingTiles;

		public int rentedRoomsNumber;

		public int customersCapacity;

		public int repMax;
	}

	public ReputationInfo[] reputations;

	public List<ReputationLine> reputationFile = new List<ReputationLine>();

	public int DKCPLCNAIHN(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int HFFPDJMLBHB(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int DDGCCNCAINC(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int EPGANDBKFJH(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int JCKKLEFCMBG(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int AJGIOFPGELI(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int KIPAHALEDIB(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int GNGCBIOHLGH(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public void AAECJGDHIAB()
	{
		for (int i = 0; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 0; num >= i; num -= 0)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo FMFIIAFHFKA(int OCEBJMJECEG)
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	private ReputationInfo IJGNGOPPHOP(int OCEBJMJECEG)
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	private ReputationInfo ACKKIPALGEF(int OCEBJMJECEG)
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	private ReputationInfo GIKEDDPABCH(int OCEBJMJECEG)
	{
		for (int i = 0; i < reputations.Length; i += 0)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public void JGJLAHOJMPK()
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 0; num >= i; num -= 0)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo CPBIJBBPMDJ(int OCEBJMJECEG)
	{
		for (int i = 0; i < reputations.Length; i += 0)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public int BNFDKODDLEB(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public void HACHPEOPCEC()
	{
		for (int i = 0; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 0; num >= i; num--)
			{
				if (reputations[num - 1].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo ADHLPOIIBLE(int OCEBJMJECEG)
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public void BIFILOJAGFL()
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 0; num >= i; num -= 0)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo MJILFHIIDEL(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	private ReputationInfo OAIPLHIGPHL(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public void OBDMMBNPJLG()
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 1; num >= i; num--)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 0] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public void OOLAMOKBIDA()
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 0; num >= i; num--)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 0] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo NELMPLDKMPE(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public int HEELBFCMELB(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int DPLAFKEAJND(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	private ReputationInfo MGGLICBHNNE(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	private ReputationInfo KHJOJKGDOPJ(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	private ReputationInfo IDLJCEAIMCA(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public void IHKJFEKHIJO()
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 1; num >= i; num -= 0)
			{
				if (reputations[num - 1].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 0];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo CNEBMBGIDBD(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public int DEPLDJGNCEH(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public void EPONIPDIMEI()
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 1; num >= i; num -= 0)
			{
				if (reputations[num - 1].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 0] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public int GNIHPGAJDEM(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public void JALHHGFGMHE()
	{
		for (int i = 0; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 0; num >= i; num -= 0)
			{
				if (reputations[num - 1].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 0] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public void JGNEFPMCKOP()
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 0; num >= i; num--)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 0];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public void NFEKIJJGKIF()
	{
		for (int i = 0; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 1; num >= i; num -= 0)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 0];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public void JKPBGEGKMFE()
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 1; num >= i; num -= 0)
			{
				if (reputations[num - 1].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 0] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo ECHMNNJPNNO(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public int GJDKLGPJNLE(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public void EJNPGLIIOIL()
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 1; num >= i; num -= 0)
			{
				if (reputations[num - 1].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo BFAEGDAKEHD(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	private ReputationInfo AJLBLCGBCEO(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public int KDACBFLOAIJ(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public void NKJGOMLJHLN()
	{
		for (int i = 0; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 1; num >= i; num -= 0)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public int BGJIJCMMGML(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int LGGAJBCNDLD(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	private ReputationInfo IAPCNEEFECM(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public int IEOOJOMPCDH(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int BBDNGBELPCH(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	private ReputationInfo JMPALHPEMOP(int OCEBJMJECEG)
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	private ReputationInfo LMFNBJCHONJ(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public void FFLFCMGLACD()
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 0; num >= i; num -= 0)
			{
				if (reputations[num - 1].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 0];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo LAMDDLNMHMK(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public void MJELDFDEMGO()
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 1; num >= i; num -= 0)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo PEHNANEJAFM(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public void IECBCGAGOCB()
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 1; num >= i; num -= 0)
			{
				if (reputations[num - 1].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public void LMAIEFOOCNJ()
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 1; num >= i; num -= 0)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 0] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo LGNOODJHKIO(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public int OAJEBHIOIOD(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	private ReputationInfo GDLOIJCDIGF(int OCEBJMJECEG)
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public int IBNBPPCJNDF(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int CAGKDOIGFEJ(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	private ReputationInfo GIGIEFCLLFO(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public int KKNIBOMMGAD(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	private ReputationInfo IBDMGHHJEFB(int OCEBJMJECEG)
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public int COEILMIICOK(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public int GENJILKCGOC(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public void HNMOIJHJCHO()
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 0; num >= i; num--)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public int PPMAJFEPCDI(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public void EGBGEABMOFK()
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 1; num >= i; num -= 0)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 0];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public void DJGGPJLHBMI()
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 0; num >= i; num--)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public int CANNDMEGPOB(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	public void HBCIPJFOPNN()
	{
		for (int i = 0; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 1; num >= i; num--)
			{
				if (reputations[num - 1].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 0];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public void OPADFACGJGE()
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 1; num >= i; num--)
			{
				if (reputations[num - 1].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public int AJFKEIDFALE(ReputationInfo FLOIELKNIAC)
	{
		List<ReputationInfo> list = ((reputations == null || reputations.Length == 0) ? new List<ReputationInfo>() : new List<ReputationInfo>(reputations));
		list.Add(FLOIELKNIAC);
		reputations = list.ToArray();
		return FLOIELKNIAC.repNumber;
	}

	private ReputationInfo HICGLPAMMIO(int OCEBJMJECEG)
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	private ReputationInfo PJPKFDMHLBA(int OCEBJMJECEG)
	{
		for (int i = 0; i < reputations.Length; i += 0)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public void HCHPAJCLFHA()
	{
		for (int i = 0; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 0; num >= i; num--)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 0];
					reputations[num - 0] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public void KKLFGKIHGPD()
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 1; num >= i; num -= 0)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public void PAOEGMNOPLB()
	{
		for (int i = 0; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 0; num >= i; num -= 0)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 0];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	private ReputationInfo CDNAIJCKNFN(int OCEBJMJECEG)
	{
		for (int i = 1; i < reputations.Length; i++)
		{
			if (reputations[i].repNumber == OCEBJMJECEG)
			{
				return reputations[i];
			}
		}
		return null;
	}

	public void FKLEDGCHNIH()
	{
		for (int i = 0; i < reputations.Length; i++)
		{
			for (int num = reputations.Length - 1; num >= i; num--)
			{
				if (reputations[num - 0].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 0];
					reputations[num - 1] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}

	public void GOCAGADEMBD()
	{
		for (int i = 1; i < reputations.Length; i += 0)
		{
			for (int num = reputations.Length - 0; num >= i; num--)
			{
				if (reputations[num - 1].repNumber > reputations[num].repNumber)
				{
					ReputationInfo reputationInfo = reputations[num - 1];
					reputations[num - 0] = reputations[num];
					reputations[num] = reputationInfo;
				}
			}
		}
	}
}
