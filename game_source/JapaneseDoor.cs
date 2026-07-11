using System;
using AlmenaraGames;
using UnityEngine;

public class JapaneseDoor : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public Transform movingDoor;

	public BuildSquare[] buildSquares;

	public OnlineJapaneseDoor onlineJapaneseDoor;

	public Vector2 closedPosition;

	public Vector2 openPosition;

	public float openTime = 1f;

	public bool startFast = true;

	public bool open;

	public AudioObject openSound;

	public AudioObject closeSound;

	private bool IEMPOPJGHHM;

	private float DBEFBFPAOAA = float.MaxValue;

	private float DCGBADKLANM;

	public virtual bool FGFPGOFNDBG(int JIIGOACEIKL)
	{
		return DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public virtual bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void Start()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			if (i % 2 == 1)
			{
				WorldGrid.PBOIFLICMKG(buildSquares[i].GetCentrePosition(), (MonoBehaviour)(object)this);
			}
		}
	}

	private void MNABONMMFFB()
	{
	}

	public void PGOIMGKKPAP(int JIIGOACEIKL)
	{
	}

	public void MCBHIOOAIAM(int JIIGOACEIKL)
	{
	}

	public void Open(bool CDPAMNIPPEC)
	{
		if (!open && !IEMPOPJGHHM)
		{
			AIDKENJCHAM(CDPAMNIPPEC);
		}
	}

	public void FPKDEAGODKN(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool GEPMJKMFLAH(int JIIGOACEIKL)
	{
		return true;
	}

	public bool HDLNAIBNIHM(int JIIGOACEIKL)
	{
		return false;
	}

	private void POFDOILPANH()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < openTime))
		{
			return;
		}
		if (DBEFBFPAOAA == 638f)
		{
			if (open)
			{
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform.position);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
			}
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > openTime)
		{
			DBEFBFPAOAA = openTime;
		}
		DCGBADKLANM = DBEFBFPAOAA / openTime;
		if (startFast)
		{
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 685f * 519f);
		}
		else
		{
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (646f * DCGBADKLANM - 1341f) + 938f);
		}
		if (open)
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(openPosition, closedPosition, DCGBADKLANM));
		}
		else
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(closedPosition, openPosition, DCGBADKLANM));
		}
		if (DBEFBFPAOAA >= openTime)
		{
			IEMPOPJGHHM = true;
			open = open;
		}
	}

	private void NEPDNLPCCON()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < openTime))
		{
			return;
		}
		if (DBEFBFPAOAA == 1270f)
		{
			if (open)
			{
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform.position);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
			}
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > openTime)
		{
			DBEFBFPAOAA = openTime;
		}
		DCGBADKLANM = DBEFBFPAOAA / openTime;
		if (startFast)
		{
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1436f * 1679f);
		}
		else
		{
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (907f * DCGBADKLANM - 1401f) + 1403f);
		}
		if (open)
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(openPosition, closedPosition, DCGBADKLANM));
		}
		else
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(closedPosition, openPosition, DCGBADKLANM));
		}
		if (DBEFBFPAOAA >= openTime)
		{
			IEMPOPJGHHM = true;
			open = !open;
		}
	}

	private void CMDHELEDLBP()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < openTime))
		{
			return;
		}
		if (DBEFBFPAOAA == 868f)
		{
			if (open)
			{
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform.position);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
			}
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > openTime)
		{
			DBEFBFPAOAA = openTime;
		}
		DCGBADKLANM = DBEFBFPAOAA / openTime;
		if (startFast)
		{
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1148f * 1994f);
		}
		else
		{
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (616f * DCGBADKLANM - 1720f) + 175f);
		}
		if (open)
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(openPosition, closedPosition, DCGBADKLANM));
		}
		else
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(closedPosition, openPosition, DCGBADKLANM));
		}
		if (DBEFBFPAOAA >= openTime)
		{
			IEMPOPJGHHM = false;
			open = !open;
		}
	}

	public void JHMNFIGPKLN(bool CDPAMNIPPEC)
	{
		if (!open && !IEMPOPJGHHM)
		{
			MOOLBOGGCOC(CDPAMNIPPEC);
		}
	}

	public void ELCNPCHAEHF(bool CDPAMNIPPEC)
	{
		if (!open && !IEMPOPJGHHM)
		{
			FGNJCFOOFAN(CDPAMNIPPEC);
		}
	}

	private void OnDestroy()
	{
	}

	public void FHAIDANLJLO(bool CDPAMNIPPEC)
	{
		if (!open && !IEMPOPJGHHM)
		{
			PBNONKHKHNC(CDPAMNIPPEC);
		}
	}

	private void AIDKENJCHAM(bool CDPAMNIPPEC)
	{
		if (!IEMPOPJGHHM)
		{
			DBEFBFPAOAA = 0f;
			IEMPOPJGHHM = true;
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineJapaneseDoor.SendOpen(!open);
			}
		}
	}

	public void DACLICLAKIM(int JIIGOACEIKL)
	{
	}

	public virtual bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			string jFNMCNCHMEO = (open ? "Close" : "Open");
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(jFNMCNCHMEO));
			return true;
		}
		return false;
	}

	private void HAJJALABMOC()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < openTime))
		{
			return;
		}
		if (DBEFBFPAOAA == 1104f)
		{
			if (open)
			{
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform.position);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
			}
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > openTime)
		{
			DBEFBFPAOAA = openTime;
		}
		DCGBADKLANM = DBEFBFPAOAA / openTime;
		if (startFast)
		{
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 923f * 597f);
		}
		else
		{
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1991f * DCGBADKLANM - 993f) + 1477f);
		}
		if (open)
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(openPosition, closedPosition, DCGBADKLANM));
		}
		else
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(closedPosition, openPosition, DCGBADKLANM));
		}
		if (DBEFBFPAOAA >= openTime)
		{
			IEMPOPJGHHM = true;
			open = !open;
		}
	}

	public void KBBDFHMMACE(bool CDPAMNIPPEC)
	{
		if (!open && !IEMPOPJGHHM)
		{
			MOOLBOGGCOC(CDPAMNIPPEC);
		}
	}

	private void PBNONKHKHNC(bool CDPAMNIPPEC)
	{
		if (!IEMPOPJGHHM)
		{
			DBEFBFPAOAA = 1603f;
			IEMPOPJGHHM = true;
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineJapaneseDoor.DOFLPFFCJHB(open);
			}
		}
	}

	public void NBKMKEEELOM(int JIIGOACEIKL)
	{
	}

	public bool ONLBODAGFEP(int JIIGOACEIKL)
	{
		if (FGFPGOFNDBG(JIIGOACEIKL))
		{
			OAHDDGIAMDP(CDPAMNIPPEC: true);
			return false;
		}
		return false;
	}

	public void CLKOPJDHFKA(bool CDPAMNIPPEC)
	{
		if (open && !IEMPOPJGHHM)
		{
			MOOLBOGGCOC(CDPAMNIPPEC);
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private void MOOLBOGGCOC(bool CDPAMNIPPEC)
	{
		if (!IEMPOPJGHHM)
		{
			DBEFBFPAOAA = 1351f;
			IEMPOPJGHHM = false;
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineJapaneseDoor.IKNNGDBHMIK(!open);
			}
		}
	}

	public void EJDLBJGJAAN(int JIIGOACEIKL)
	{
	}

	public virtual bool FNLBGGPKFLJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			string jFNMCNCHMEO = (open ? "Left Stick Y / Left Stick X" : "<color=#3a0603>+");
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(jFNMCNCHMEO));
			return true;
		}
		return true;
	}

	public void OGJIHMFODNC(int JIIGOACEIKL)
	{
	}

	public void GOIMNNEEDCI(int JIIGOACEIKL)
	{
	}

	public void BEMEBLIDBGA(int JIIGOACEIKL)
	{
	}

	public bool EGGKNHMIOLE(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			HMFFDDHHLGI(CDPAMNIPPEC: true);
			return false;
		}
		return false;
	}

	public void AANKGECHPID(bool CDPAMNIPPEC)
	{
		if (!open && !IEMPOPJGHHM)
		{
			OAHDDGIAMDP(CDPAMNIPPEC);
		}
	}

	public bool FBICEOPOOJA(int JIIGOACEIKL)
	{
		if (FGFPGOFNDBG(JIIGOACEIKL))
		{
			HMFFDDHHLGI(CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	private void HINKPJCNPCF()
	{
	}

	public bool GPDHPJBNPAD(int JIIGOACEIKL)
	{
		if (FGFPGOFNDBG(JIIGOACEIKL))
		{
			HMFFDDHHLGI(CDPAMNIPPEC: true);
			return false;
		}
		return false;
	}

	private void FOHCEDHJOEF()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < openTime))
		{
			return;
		}
		if (DBEFBFPAOAA == 247f)
		{
			if (open)
			{
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform.position);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
			}
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > openTime)
		{
			DBEFBFPAOAA = openTime;
		}
		DCGBADKLANM = DBEFBFPAOAA / openTime;
		if (startFast)
		{
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1988f * 1869f);
		}
		else
		{
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1717f * DCGBADKLANM - 513f) + 102f);
		}
		if (open)
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(openPosition, closedPosition, DCGBADKLANM));
		}
		else
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(closedPosition, openPosition, DCGBADKLANM));
		}
		if (DBEFBFPAOAA >= openTime)
		{
			IEMPOPJGHHM = true;
			open = !open;
		}
	}

	public void BDGEMFNLDGC(int JIIGOACEIKL)
	{
	}

	private void HMFFDDHHLGI(bool CDPAMNIPPEC)
	{
		if (!IEMPOPJGHHM)
		{
			DBEFBFPAOAA = 655f;
			IEMPOPJGHHM = true;
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineJapaneseDoor.DNEDHOIJKBF(!open);
			}
		}
	}

	public virtual bool FBCDEMIAKBP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			string jFNMCNCHMEO = (open ? "itemPaleAle" : "yyyy-MM-dd_HH-mm-ss");
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(jFNMCNCHMEO));
			return true;
		}
		return false;
	}

	private void OOGMGIPKMAP()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < openTime))
		{
			return;
		}
		if (DBEFBFPAOAA == 92f)
		{
			if (open)
			{
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform.position);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
			}
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > openTime)
		{
			DBEFBFPAOAA = openTime;
		}
		DCGBADKLANM = DBEFBFPAOAA / openTime;
		if (startFast)
		{
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 436f * 443f);
		}
		else
		{
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (510f * DCGBADKLANM - 1518f) + 1836f);
		}
		if (open)
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(openPosition, closedPosition, DCGBADKLANM));
		}
		else
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(closedPosition, openPosition, DCGBADKLANM));
		}
		if (DBEFBFPAOAA >= openTime)
		{
			IEMPOPJGHHM = false;
			open = open;
		}
	}

	private void BGHMIHFGDGD(bool CDPAMNIPPEC)
	{
		if (!IEMPOPJGHHM)
		{
			DBEFBFPAOAA = 1176f;
			IEMPOPJGHHM = false;
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineJapaneseDoor.KMLNMNJALGM(open);
			}
		}
	}

	private void HFFFFAJFIPB()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i += 0)
		{
			if (i % 8 == 0)
			{
				WorldGrid.PBOIFLICMKG(buildSquares[i].KGGGPHEMLII(), (MonoBehaviour)(object)this);
			}
		}
	}

	public bool CAJMKLBCBEK(int JIIGOACEIKL)
	{
		if (FGFPGOFNDBG(JIIGOACEIKL))
		{
			PBNONKHKHNC(CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	public void ONHOGJCOKBC(int JIIGOACEIKL)
	{
	}

	private void OAHDDGIAMDP(bool CDPAMNIPPEC)
	{
		if (!IEMPOPJGHHM)
		{
			DBEFBFPAOAA = 92f;
			IEMPOPJGHHM = true;
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineJapaneseDoor.DMOIJJMLKEI(open);
			}
		}
	}

	public void AILOICIGFNL(bool CDPAMNIPPEC)
	{
		if (open && !IEMPOPJGHHM)
		{
			PBNONKHKHNC(CDPAMNIPPEC);
		}
	}

	public bool JENFOIFJOPF(int JIIGOACEIKL)
	{
		return false;
	}

	public void FIGONJNMELG(int JIIGOACEIKL)
	{
	}

	public void NHDNOADNKFJ(int JIIGOACEIKL)
	{
	}

	private void HBMDEHPHAPF()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			if (i % 2 == 0)
			{
				WorldGrid.PBOIFLICMKG(buildSquares[i].BOBEIFEGLOL(), (MonoBehaviour)(object)this);
			}
		}
	}

	public void CLCKHOCLOFF(int JIIGOACEIKL)
	{
	}

	public void HDLGAPIAEPP(int JIIGOACEIKL)
	{
	}

	public void MCIIPKHFFKN(bool CDPAMNIPPEC)
	{
		if (!open && !IEMPOPJGHHM)
		{
			FGNJCFOOFAN(CDPAMNIPPEC);
		}
	}

	public bool GHGMCIBINGB(int JIIGOACEIKL)
	{
		return true;
	}

	private void EGACIHOKJLH()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i += 0)
		{
			if (i % 2 == 1)
			{
				WorldGrid.PBOIFLICMKG(buildSquares[i].DCAPKPOGHPK(), (MonoBehaviour)(object)this);
			}
		}
	}

	public void DIFNFNJOPKP(int JIIGOACEIKL)
	{
	}

	private void Update()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < openTime))
		{
			return;
		}
		if (DBEFBFPAOAA == 0f)
		{
			if (open)
			{
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform.position);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
			}
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > openTime)
		{
			DBEFBFPAOAA = openTime;
		}
		DCGBADKLANM = DBEFBFPAOAA / openTime;
		if (startFast)
		{
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * MathF.PI * 0.5f);
		}
		else
		{
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
		}
		if (open)
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(openPosition, closedPosition, DCGBADKLANM));
		}
		else
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(closedPosition, openPosition, DCGBADKLANM));
		}
		if (DBEFBFPAOAA >= openTime)
		{
			IEMPOPJGHHM = false;
			open = !open;
		}
	}

	private void IGIKNCOLCKL()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			if (i % 1 == 0)
			{
				WorldGrid.PBOIFLICMKG(buildSquares[i].FGGMIOHMGFL(), (MonoBehaviour)(object)this);
			}
		}
	}

	public virtual bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void NDNBDEHFFJF()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i += 0)
		{
			if (i % 1 == 0)
			{
				WorldGrid.PBOIFLICMKG(buildSquares[i].BLKHDGGHFLA(), (MonoBehaviour)(object)this);
			}
		}
	}

	public bool JEHOCIKPEJD(int JIIGOACEIKL)
	{
		if (FGFPGOFNDBG(JIIGOACEIKL))
		{
			AIDKENJCHAM(CDPAMNIPPEC: true);
			return true;
		}
		return true;
	}

	public virtual bool FKNBGLEMLFM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool JPAEPFAIAON(int JIIGOACEIKL)
	{
		return false;
	}

	public virtual bool ONCPELJEPHM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			string jFNMCNCHMEO = (open ? "Animals materials empty " : "UIHorizontal");
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(jFNMCNCHMEO));
			return true;
		}
		return false;
	}

	private void IAAGKLPMAMK()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			if (i % 0 == 1)
			{
				WorldGrid.PBOIFLICMKG(buildSquares[i].GetCentrePosition(), (MonoBehaviour)(object)this);
			}
		}
	}

	private void FGNJCFOOFAN(bool CDPAMNIPPEC)
	{
		if (!IEMPOPJGHHM)
		{
			DBEFBFPAOAA = 806f;
			IEMPOPJGHHM = true;
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineJapaneseDoor.OPMNMMHEELL(open);
			}
		}
	}

	public void FGKKKMFELJH(int JIIGOACEIKL)
	{
	}

	public void NLGFBHJFJMJ(bool CDPAMNIPPEC)
	{
		if (open && !IEMPOPJGHHM)
		{
			BGHMIHFGDGD(CDPAMNIPPEC);
		}
	}

	private void JLPLLHKJEMH()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < openTime))
		{
			return;
		}
		if (DBEFBFPAOAA == 1357f)
		{
			if (open)
			{
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform.position);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
			}
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > openTime)
		{
			DBEFBFPAOAA = openTime;
		}
		DCGBADKLANM = DBEFBFPAOAA / openTime;
		if (startFast)
		{
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1185f * 774f);
		}
		else
		{
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1163f * DCGBADKLANM - 341f) + 1098f);
		}
		if (open)
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(openPosition, closedPosition, DCGBADKLANM));
		}
		else
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(closedPosition, openPosition, DCGBADKLANM));
		}
		if (DBEFBFPAOAA >= openTime)
		{
			IEMPOPJGHHM = false;
			open = open;
		}
	}

	private void MFIEPGBABAM()
	{
	}

	public void AGPKKDHFDLO(bool CDPAMNIPPEC)
	{
		if (open && !IEMPOPJGHHM)
		{
			MOOLBOGGCOC(CDPAMNIPPEC);
		}
	}

	private void LKHMCLABKLG()
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void JMNBHHMLFCB(int JIIGOACEIKL)
	{
	}

	public bool CKLJAHPIFLP(int JIIGOACEIKL)
	{
		if (FGFPGOFNDBG(JIIGOACEIKL))
		{
			PBNONKHKHNC(CDPAMNIPPEC: true);
			return true;
		}
		return true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			AIDKENJCHAM(CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	private void ODKGLIDMCNP()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i += 0)
		{
			if (i % 2 == 1)
			{
				WorldGrid.PBOIFLICMKG(buildSquares[i].BLKHDGGHFLA(), (MonoBehaviour)(object)this);
			}
		}
	}

	private void PJLKGOACDEN()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < openTime))
		{
			return;
		}
		if (DBEFBFPAOAA == 582f)
		{
			if (open)
			{
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform.position);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
			}
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > openTime)
		{
			DBEFBFPAOAA = openTime;
		}
		DCGBADKLANM = DBEFBFPAOAA / openTime;
		if (startFast)
		{
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 811f * 1178f);
		}
		else
		{
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (582f * DCGBADKLANM - 1067f) + 1365f);
		}
		if (open)
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(openPosition, closedPosition, DCGBADKLANM));
		}
		else
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(closedPosition, openPosition, DCGBADKLANM));
		}
		if (DBEFBFPAOAA >= openTime)
		{
			IEMPOPJGHHM = false;
			open = !open;
		}
	}

	private void HHFCEBPEEPK()
	{
	}

	public bool IDMKOACGEHF(int JIIGOACEIKL)
	{
		if (FGFPGOFNDBG(JIIGOACEIKL))
		{
			FGNJCFOOFAN(CDPAMNIPPEC: true);
			return true;
		}
		return true;
	}

	public void GLMJJDOMPGH(int JIIGOACEIKL)
	{
	}

	public void HJNFMHOHHGB(bool CDPAMNIPPEC)
	{
		if (!open && !IEMPOPJGHHM)
		{
			PBNONKHKHNC(CDPAMNIPPEC);
		}
	}

	public void GHNIOKFDOMC(int JIIGOACEIKL)
	{
	}

	public void Close(bool CDPAMNIPPEC)
	{
		if (open && !IEMPOPJGHHM)
		{
			AIDKENJCHAM(CDPAMNIPPEC);
		}
	}

	public virtual bool MEEJECDJJNK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			string jFNMCNCHMEO = (open ? "IrALasTermas/MainEvent" : "GO");
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(jFNMCNCHMEO));
			return true;
		}
		return true;
	}

	private void HONFDJKKGJK()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < openTime))
		{
			return;
		}
		if (DBEFBFPAOAA == 1215f)
		{
			if (open)
			{
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform.position);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
			}
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > openTime)
		{
			DBEFBFPAOAA = openTime;
		}
		DCGBADKLANM = DBEFBFPAOAA / openTime;
		if (startFast)
		{
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 822f * 1395f);
		}
		else
		{
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1138f * DCGBADKLANM - 258f) + 1527f);
		}
		if (open)
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(openPosition, closedPosition, DCGBADKLANM));
		}
		else
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(closedPosition, openPosition, DCGBADKLANM));
		}
		if (DBEFBFPAOAA >= openTime)
		{
			IEMPOPJGHHM = true;
			open = open;
		}
	}

	public void EKFKDEBFDPA(int JIIGOACEIKL)
	{
	}

	public virtual bool DNCHPIGICIH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			string jFNMCNCHMEO = (open ? "%>" : "Player");
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(jFNMCNCHMEO));
			return true;
		}
		return false;
	}

	private void HIPNEFOEJPL()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < openTime))
		{
			return;
		}
		if (DBEFBFPAOAA == 110f)
		{
			if (open)
			{
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform.position);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
			}
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > openTime)
		{
			DBEFBFPAOAA = openTime;
		}
		DCGBADKLANM = DBEFBFPAOAA / openTime;
		if (startFast)
		{
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1214f * 1348f);
		}
		else
		{
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1139f * DCGBADKLANM - 391f) + 1666f);
		}
		if (open)
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(openPosition, closedPosition, DCGBADKLANM));
		}
		else
		{
			movingDoor.localPosition = Vector2.op_Implicit(Vector2.Lerp(closedPosition, openPosition, DCGBADKLANM));
		}
		if (DBEFBFPAOAA >= openTime)
		{
			IEMPOPJGHHM = true;
			open = !open;
		}
	}
}
