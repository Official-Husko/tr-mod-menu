using System.Collections.Generic;
using UnityEngine;

public class DisableOnBecameInvisibleManager : MonoBehaviour
{
	public static DisableOnBecameInvisibleManager instance;

	private List<DisableOnBecameInvisible> LEIKDNNIKKA = new List<DisableOnBecameInvisible>();

	private Vector2 MCFIJHMMKDO;

	private Vector2 KMLGHFIKIFI;

	private void NEPDNLPCCON()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].AENONCEECIM(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void HOACGDMMMFB(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	public void JLAGMNLLDJF(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void EMCCGDFOPEH()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(8)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].NBFHGJGOBJK(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void MJDEALIMMJG(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void DBKCPJIKFFC()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(3)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].NBFHGJGOBJK(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void NMIJACDOGMF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(7)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].FEGDCNEPPAC(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void HIPNEFOEJPL()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(7)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].CheckLights(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void HAJJALABMOC()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(8)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].BGIMDIADLFO(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void EGABOGIFGLJ(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void OGEJKOIOKAN()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void IIOHJIEHJKE(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void EFCNKPEPELL()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void EBNJADODONG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].AENONCEECIM(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void BFJOEMCBJJO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void LALAFOIGMKN()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(7)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].NBFHGJGOBJK(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void GPJGNCIIHJO(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void JIIBFOMMNBN()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void HHMNOKALDFE(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void BEHHEEABIPB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(5)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].GNOCPNNLLLD(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void PCOCDAINJII(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	public void HDBNINPDHJH(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void GONDLJKGLGO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void IIOHMDNGFDH()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(5)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].NBFHGJGOBJK(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void JBPHMAAOLJH(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void PHJKJHKAABL()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void PBDNKBPBCHM()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void ABAMOJIIAFJ()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].HOLOELGHJBL(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void MFIBFFDBNGI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].FBJNGCALCKF(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void CIICEKEJANM()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void DKNNLPFIBIK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void NLHGCGOMLHJ(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void ILDPIPHIGFO(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void EHBMONGBJFI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void BGBFJPJLPMF()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void NEKMHCDEDLH(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void BGBBFFIPKIL(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void NJAFKFAPDIE()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void PDPFKFGPKDM(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void IAICCKPOBMJ()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(4)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].CheckLights(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void IMMHEOJPIDH(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	public void OMKHFALCLJD(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	public void DKMJACGDKKO(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void CEOEHODJAJK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void KGABFMLLBDC(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void OIOLGAOPECC()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void BGBFLOCPMII()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void BEGLOAKAICN()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(3)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].CheckLights(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void ANOODJNILHD(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void FFHIGDJEFJE()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void CBBNPJLHAMB(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void BGBODBHLFOG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void OFMPMHFBGCN(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void JHJBBINOAIM(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void IEKOLOFONGL(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void DADPOICMNPI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void LKFIGIPCCNF(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void DKNMGFDFLKL()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(6)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].OBGGDAGBFLB(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void KJPECNGCOKK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void ICCEPNKBKKE(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void KLEAPLOKEDK()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(2)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].CheckLights(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void HFKGEPJNADL()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].GNOCPNNLLLD(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void PIHGEBONAOI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void KGIKOECKEHI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void FGGPGOEAEKK()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(3)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].FEGDCNEPPAC(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void LHABENPEMPB()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void LGNDLGMIPGF(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void MMPMJNAFKHC()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(5)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].CheckLights(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void FBIEFPIHIOB(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void ANHEDDLIEEG(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void OCJOAHDNDIJ()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void ANPLFHHCEGP(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void MIKNFPCDLML()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void LHFOFAMDKEO()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(7)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].CheckLights(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void BDBCBPPECOI(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void BCBICGABKEE(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void DIMAPDNCBAN()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void EJMAJFGPGEC()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(7)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].HOLOELGHJBL(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void FBHHPNJGNJG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void DEEIEACLPEF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(6)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].HOLOELGHJBL(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void CKCHKHNBBFG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].CheckLights(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void FDHMOEDMPNG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(3)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].FEGDCNEPPAC(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void Update()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].CheckLights(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void AJGKMFOJLBJ()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void JEIBLMKNDAL(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	public void PBKCEPKHMMG(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void Awake()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void KJBBALMEPPB(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	public void EIOKGDEAMNA(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void EOBODNOCKGA()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void NBIAFOBJHKA(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void LNPDALMANFB()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void OMBHDODDHNO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void DGJKLAEINHJ()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(6)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].AENONCEECIM(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void BHLHCOALABE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(4)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].BGIMDIADLFO(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void DEGHMJBCFMK(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void PKEPBKHEDOD()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].GNOCPNNLLLD(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void AGLMGDNBHBF()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void EFJFJJDGGGI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void GOJHCINMAJD()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(8)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].NBFHGJGOBJK(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void AGGJDFHNPPI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].GNOCPNNLLLD(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void MCCKJKMGKLE(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void INGGDMNFMCO()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(2)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].HOLOELGHJBL(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void EDDPHMHPBEA(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void NHLHACBEMIJ(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	public void FPFKENKIMKH(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void AADEJPNOBHP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(7)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].FBJNGCALCKF(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void PNJJEDEFAGO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void NCPNBBCNBIM()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void LMCCKEPMNNI(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void IMIGOGJFGLL(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void ONOAGANPECB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(5)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].OBGGDAGBFLB(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void HHHJPBBACLG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].OBGGDAGBFLB(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void LFGKEHNKAKI(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void MGMLDHPOLGK()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(6)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].FEGDCNEPPAC(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void MINOKDPICGM(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void KJBHMAGDLCK(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	public void MBFBGBLHPDO(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	public void BCIPDJBIAMI(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void CBBJJGFJFOJ(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void PJIMENLPNOE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].FEGDCNEPPAC(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void BEOGHCHPPAH()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(3)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].GNOCPNNLLLD(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void PHLLBPLOLFO()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(7)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].FBJNGCALCKF(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void IGHMMOKFINH()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void JKLGKDMOCLE(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void KHNGJFBMMCP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(4)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].BGIMDIADLFO(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void CDOECEFPFOO(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void BIILFPDIADC()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(4)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].AENONCEECIM(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void CMJPIAAGIFF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].GNOCPNNLLLD(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void PDIECJCKCOD()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void NGAFBKDBICN(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void BBCPDBEOOKL()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 0; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].OBGGDAGBFLB(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void AFAIJHPIFBI(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void IOHIEBBDOJN()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].OBGGDAGBFLB(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void DNNMLKIBOAP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(5)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].BGIMDIADLFO(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void JDAMCMODANB()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void OOGMGIPKMAP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(6)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].OBGGDAGBFLB(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void KLMNLEDKEOE()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void KCMIKDBAFNA()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].CheckLights(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void KGIGOJGONIB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].BGIMDIADLFO(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	private void OGBGFLMKFHH()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].NBFHGJGOBJK(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void LEEDCDNEELC(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	public void DKCCBBGAGKI(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void KMEJBPOOBJK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void INOIAMKEIFO(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void MHFLMBLKEJE(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	public void MKMBHBPLDEM(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void EDKFNAPDMCN()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void PDPJJCCDPCL(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}

	private void AAEDMDPLLLJ()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(5)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i++)
			{
				LEIKDNNIKKA[i].AENONCEECIM(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void PJOKJHPJHBO(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	private void NDLCBLKOBLF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			MCFIJHMMKDO = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position);
			if (GameManager.LocalCoop())
			{
				KMLGHFIKIFI = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position);
			}
			else
			{
				KMLGHFIKIFI = Vector2.zero;
			}
			for (int i = 1; i < LEIKDNNIKKA.Count; i += 0)
			{
				LEIKDNNIKKA[i].CheckLights(MCFIJHMMKDO, KMLGHFIKIFI);
			}
		}
	}

	public void Remove(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (LEIKDNNIKKA.Contains(GIDABDJCONK))
		{
			LEIKDNNIKKA.Remove(GIDABDJCONK);
		}
	}

	public void Add(DisableOnBecameInvisible GIDABDJCONK)
	{
		if (GIDABDJCONK.lights.Length != 0)
		{
			LEIKDNNIKKA.Add(GIDABDJCONK);
		}
	}
}
