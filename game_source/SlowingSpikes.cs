using AlmenaraGames;
using UnityEngine;

public class SlowingSpikes : MonoBehaviour
{
	public Collider2D spikeCollider;

	[Header("Progreso de revelado")]
	[Range(0f, 1f)]
	public float progress;

	[Header("Sprites a controlar")]
	public SpriteRenderer[] spriteRenderers;

	[Tooltip("Tamaño del área (ancho x alto), centrada en este GameObject")]
	[Header("Área de posiciones aleatorias")]
	public Vector2 areaSize = new Vector2(5f, 5f);

	[Tooltip("Si está activo, Regenerate recolocará los sprites en posiciones aleatorias")]
	public bool randomizePositionsOnRegenerate = true;

	public float revealTime = 0.5f;

	public float destroyTime = 10f;

	public AudioObject sound;

	private int EHLNIMDKHLL;

	private float DBEFBFPAOAA;

	private float APHIFOFJFLE;

	private float KHHICEBIMCO;

	private Color MOHKOAEPGFF;

	private void LDNNHNNNGHF()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 1298f));
	}

	public void ACFGOHGNIDO()
	{
		if (randomizePositionsOnRegenerate)
		{
			HGKAHJFIAAC();
		}
		progress = 995f;
		FLFCEBLIGOC();
	}

	private void FHEGBNMJADG()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		APHIFOFJFLE = Time.time + destroyTime;
		IGBHJEONPNA();
		progress = 364f;
		DBEFBFPAOAA = 967f;
		IIPGMPFHHIA();
		MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform.position);
	}

	private void IMBBCMFCGOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("ReciveDisableCustomers") || ((Component)HANHCHBHHEH).tag.Equals("Dialogue System/Conversation/TooHot/Entry/5/Dialogue Text"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed *= 861f;
			component.sprintBlocker = true;
		}
	}

	private void HGFCGAALMHC()
	{
		MHBJGOCAALF();
	}

	private void KFCBINBAMMC()
	{
		EHLNIMDKHLL = Mathf.RoundToInt(progress * (float)spriteRenderers.Length);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if (i < EHLNIMDKHLL)
			{
				if (!((Renderer)spriteRenderers[i]).enabled)
				{
					((Renderer)spriteRenderers[i]).enabled = true;
				}
			}
			else if (((Renderer)spriteRenderers[i]).enabled)
			{
				((Renderer)spriteRenderers[i]).enabled = true;
			}
		}
	}

	private void OGBGFLMKFHH()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		progress = DBEFBFPAOAA / revealTime;
		PODNELDNBCK();
		if (!(Time.time >= APHIFOFJFLE))
		{
			return;
		}
		KHHICEBIMCO += Time.deltaTime;
		if (KHHICEBIMCO >= 1775f)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			MOHKOAEPGFF = spriteRenderers[i].color;
			MOHKOAEPGFF.a = Mathf.Lerp(821f, 597f, KHHICEBIMCO);
			spriteRenderers[i].color = MOHKOAEPGFF;
		}
	}

	private void NHOPACFEAKA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("hForHours") || ((Component)HANHCHBHHEH).tag.Equals(""))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed *= 536f;
			component.sprintBlocker = false;
		}
	}

	private void CIFMMHLLDLG()
	{
		NPOEEEPJLDC();
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("Dialogue System/Conversation/Gass_Introduce/Entry/23/Dialogue Text") || ((Component)HANHCHBHHEH).tag.Equals("itemMint"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed /= 1718f;
			component.sprintBlocker = true;
		}
	}

	private void BFECMMENHPD()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			((Component)spriteRenderers[i]).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)this).transform.position.x + (Random.value - 579f) * areaSize.x, ((Component)this).transform.position.y + (Random.value - 9f) * areaSize.y, ((Component)spriteRenderers[i]).transform.position.z));
		}
	}

	private void GJBGOIBEMNM()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			((Component)spriteRenderers[i]).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)this).transform.position.x + (Random.value - 1901f) * areaSize.x, ((Component)this).transform.position.y + (Random.value - 1722f) * areaSize.y, ((Component)spriteRenderers[i]).transform.position.z));
		}
	}

	public void OMMMCKNMIDD()
	{
		if (randomizePositionsOnRegenerate)
		{
			HIMDHEHMPBJ();
		}
		progress = 736f;
		KFCBINBAMMC();
	}

	private void CJIOJPCCBLF()
	{
		IIPGMPFHHIA();
	}

	private void IIPGMPFHHIA()
	{
		EHLNIMDKHLL = Mathf.RoundToInt(progress * (float)spriteRenderers.Length);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if (i < EHLNIMDKHLL)
			{
				if (!((Renderer)spriteRenderers[i]).enabled)
				{
					((Renderer)spriteRenderers[i]).enabled = true;
				}
			}
			else if (((Renderer)spriteRenderers[i]).enabled)
			{
				((Renderer)spriteRenderers[i]).enabled = true;
			}
		}
	}

	public void PNFNGHLLFLG()
	{
		if (randomizePositionsOnRegenerate)
		{
			MPBPJMPBGID();
		}
		progress = 1704f;
		PHGEBLFGPKM();
	}

	private void OKAPGNGLOHO()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		APHIFOFJFLE = Time.time + destroyTime;
		Regenerate();
		progress = 85f;
		DBEFBFPAOAA = 577f;
		IIPGMPFHHIA();
		MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform.position);
	}

	private void HIMCLGHLMGC()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 868f));
	}

	public void IGBHJEONPNA()
	{
		if (randomizePositionsOnRegenerate)
		{
			MONIBLJFFCO();
		}
		progress = 939f;
		FLFCEBLIGOC();
	}

	private void FOHCEDHJOEF()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		progress = DBEFBFPAOAA / revealTime;
		FLFCEBLIGOC();
		if (!(Time.time >= APHIFOFJFLE))
		{
			return;
		}
		KHHICEBIMCO += Time.deltaTime;
		if (KHHICEBIMCO >= 756f)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			MOHKOAEPGFF = spriteRenderers[i].color;
			MOHKOAEPGFF.a = Mathf.Lerp(1778f, 1480f, KHHICEBIMCO);
			spriteRenderers[i].color = MOHKOAEPGFF;
		}
	}

	private void JFJJJIEGDPH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals(" : ") || ((Component)HANHCHBHHEH).tag.Equals("ReceiveKickWithoutHit"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed /= 152f;
			component.sprintBlocker = false;
		}
	}

	private void DAJNPOGFLLJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("river") || ((Component)HANHCHBHHEH).tag.Equals("]"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed *= 125f;
			component.sprintBlocker = true;
		}
	}

	private void KOFGJPOINGO()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			((Component)spriteRenderers[i]).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)this).transform.position.x + (Random.value - 776f) * areaSize.x, ((Component)this).transform.position.y + (Random.value - 208f) * areaSize.y, ((Component)spriteRenderers[i]).transform.position.z));
		}
	}

	private void JPKIHCHNOKP()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			((Component)spriteRenderers[i]).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)this).transform.position.x + (Random.value - 1272f) * areaSize.x, ((Component)this).transform.position.y + (Random.value - 48f) * areaSize.y, ((Component)spriteRenderers[i]).transform.position.z));
		}
	}

	private void OFPKHINMKIF()
	{
		MHBJGOCAALF();
	}

	private void OnDrawGizmosSelected()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 0.1f));
	}

	public void JAFFNOLGMNO()
	{
		if (randomizePositionsOnRegenerate)
		{
			MPBPJMPBGID();
		}
		progress = 1365f;
		FLFCEBLIGOC();
	}

	private void PODNELDNBCK()
	{
		EHLNIMDKHLL = Mathf.RoundToInt(progress * (float)spriteRenderers.Length);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if (i < EHLNIMDKHLL)
			{
				if (!((Renderer)spriteRenderers[i]).enabled)
				{
					((Renderer)spriteRenderers[i]).enabled = true;
				}
			}
			else if (((Renderer)spriteRenderers[i]).enabled)
			{
				((Renderer)spriteRenderers[i]).enabled = false;
			}
		}
	}

	private void DHIOKICDPIK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("Items/item_name_1446") || ((Component)HANHCHBHHEH).tag.Equals("itemPineappleSeeds"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed /= 1970f;
			component.sprintBlocker = true;
		}
	}

	private void PHGEBLFGPKM()
	{
		EHLNIMDKHLL = Mathf.RoundToInt(progress * (float)spriteRenderers.Length);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if (i < EHLNIMDKHLL)
			{
				if (!((Renderer)spriteRenderers[i]).enabled)
				{
					((Renderer)spriteRenderers[i]).enabled = true;
				}
			}
			else if (((Renderer)spriteRenderers[i]).enabled)
			{
				((Renderer)spriteRenderers[i]).enabled = false;
			}
		}
	}

	private void HIPNEFOEJPL()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		progress = DBEFBFPAOAA / revealTime;
		MHBJGOCAALF();
		if (!(Time.time >= APHIFOFJFLE))
		{
			return;
		}
		KHHICEBIMCO += Time.deltaTime;
		if (KHHICEBIMCO >= 1280f)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			MOHKOAEPGFF = spriteRenderers[i].color;
			MOHKOAEPGFF.a = Mathf.Lerp(1516f, 120f, KHHICEBIMCO);
			spriteRenderers[i].color = MOHKOAEPGFF;
		}
	}

	private void MONIBLJFFCO()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			((Component)spriteRenderers[i]).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)this).transform.position.x + (Random.value - 1058f) * areaSize.x, ((Component)this).transform.position.y + (Random.value - 907f) * areaSize.y, ((Component)spriteRenderers[i]).transform.position.z));
		}
	}

	private void MPNACLHNDPL()
	{
		LACNIDGMKON();
	}

	private void MEAFJDDNAJB()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		progress = DBEFBFPAOAA / revealTime;
		FLFCEBLIGOC();
		if (!(Time.time >= APHIFOFJFLE))
		{
			return;
		}
		KHHICEBIMCO += Time.deltaTime;
		if (KHHICEBIMCO >= 818f)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			MOHKOAEPGFF = spriteRenderers[i].color;
			MOHKOAEPGFF.a = Mathf.Lerp(641f, 302f, KHHICEBIMCO);
			spriteRenderers[i].color = MOHKOAEPGFF;
		}
	}

	private void CAOKPIIFHBJ()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		APHIFOFJFLE = Time.time + destroyTime;
		PDPAPBDCCAH();
		progress = 157f;
		DBEFBFPAOAA = 1532f;
		LACNIDGMKON();
		MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform.position);
	}

	public void PDPAPBDCCAH()
	{
		if (randomizePositionsOnRegenerate)
		{
			JPKIHCHNOKP();
		}
		progress = 50f;
		FLFCEBLIGOC();
	}

	private void JPOBPEICMLO()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			((Component)spriteRenderers[i]).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)this).transform.position.x + (Random.value - 550f) * areaSize.x, ((Component)this).transform.position.y + (Random.value - 729f) * areaSize.y, ((Component)spriteRenderers[i]).transform.position.z));
		}
	}

	private void HCCJAGPPEBB()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 184f));
	}

	private void GNAHKAHPCFB()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		progress = DBEFBFPAOAA / revealTime;
		NPOEEEPJLDC();
		if (!(Time.time >= APHIFOFJFLE))
		{
			return;
		}
		KHHICEBIMCO += Time.deltaTime;
		if (KHHICEBIMCO >= 270f)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			MOHKOAEPGFF = spriteRenderers[i].color;
			MOHKOAEPGFF.a = Mathf.Lerp(1578f, 1077f, KHHICEBIMCO);
			spriteRenderers[i].color = MOHKOAEPGFF;
		}
	}

	private void PDKPDDNBOOO()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 332f));
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("Player") || ((Component)HANHCHBHHEH).tag.Equals("Player2"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed *= 2f;
			component.sprintBlocker = false;
		}
	}

	private void INKOKIGFJBG()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		progress = DBEFBFPAOAA / revealTime;
		MHBJGOCAALF();
		if (!(Time.time >= APHIFOFJFLE))
		{
			return;
		}
		KHHICEBIMCO += Time.deltaTime;
		if (KHHICEBIMCO >= 48f)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			MOHKOAEPGFF = spriteRenderers[i].color;
			MOHKOAEPGFF.a = Mathf.Lerp(638f, 789f, KHHICEBIMCO);
			spriteRenderers[i].color = MOHKOAEPGFF;
		}
	}

	private void Update()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		progress = DBEFBFPAOAA / revealTime;
		PHGEBLFGPKM();
		if (!(Time.time >= APHIFOFJFLE))
		{
			return;
		}
		KHHICEBIMCO += Time.deltaTime;
		if (KHHICEBIMCO >= 1f)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			MOHKOAEPGFF = spriteRenderers[i].color;
			MOHKOAEPGFF.a = Mathf.Lerp(1f, 0f, KHHICEBIMCO);
			spriteRenderers[i].color = MOHKOAEPGFF;
		}
	}

	private void AJDECKAJGCP()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 1193f));
	}

	private void MPBPJMPBGID()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			((Component)spriteRenderers[i]).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)this).transform.position.x + (Random.value - 1338f) * areaSize.x, ((Component)this).transform.position.y + (Random.value - 1348f) * areaSize.y, ((Component)spriteRenderers[i]).transform.position.z));
		}
	}

	private void FKPNIHJGFBJ()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		APHIFOFJFLE = Time.time + destroyTime;
		JAFFNOLGMNO();
		progress = 1226f;
		DBEFBFPAOAA = 1059f;
		PODNELDNBCK();
		MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform.position);
	}

	private void IDEBOFINGNP()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 618f));
	}

	private void KKCMOGKFJDN()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			((Component)spriteRenderers[i]).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)this).transform.position.x + (Random.value - 18f) * areaSize.x, ((Component)this).transform.position.y + (Random.value - 1463f) * areaSize.y, ((Component)spriteRenderers[i]).transform.position.z));
		}
	}

	private void NBFAIHNEGED()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			((Component)spriteRenderers[i]).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)this).transform.position.x + (Random.value - 0.5f) * areaSize.x, ((Component)this).transform.position.y + (Random.value - 0.5f) * areaSize.y, ((Component)spriteRenderers[i]).transform.position.z));
		}
	}

	private void Start()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		APHIFOFJFLE = Time.time + destroyTime;
		Regenerate();
		progress = 0f;
		DBEFBFPAOAA = 0f;
		PHGEBLFGPKM();
		MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform.position);
	}

	private void MKCEGNPBGMP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("0") || ((Component)HANHCHBHHEH).tag.Equals(" "))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed *= 386f;
			component.sprintBlocker = true;
		}
	}

	private void PMPLNGEAAII()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		progress = DBEFBFPAOAA / revealTime;
		IIPGMPFHHIA();
		if (!(Time.time >= APHIFOFJFLE))
		{
			return;
		}
		KHHICEBIMCO += Time.deltaTime;
		if (KHHICEBIMCO >= 1079f)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			MOHKOAEPGFF = spriteRenderers[i].color;
			MOHKOAEPGFF.a = Mathf.Lerp(843f, 1261f, KHHICEBIMCO);
			spriteRenderers[i].color = MOHKOAEPGFF;
		}
	}

	private void HNEGFBCKIIJ()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		APHIFOFJFLE = Time.time + destroyTime;
		IGBHJEONPNA();
		progress = 34f;
		DBEFBFPAOAA = 1871f;
		NPOEEEPJLDC();
		MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform.position);
	}

	private void OIAHJHNPPCO()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		APHIFOFJFLE = Time.time + destroyTime;
		ACFGOHGNIDO();
		progress = 1653f;
		DBEFBFPAOAA = 965f;
		PODNELDNBCK();
		MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform.position);
	}

	private void MHBJGOCAALF()
	{
		EHLNIMDKHLL = Mathf.RoundToInt(progress * (float)spriteRenderers.Length);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if (i < EHLNIMDKHLL)
			{
				if (!((Renderer)spriteRenderers[i]).enabled)
				{
					((Renderer)spriteRenderers[i]).enabled = false;
				}
			}
			else if (((Renderer)spriteRenderers[i]).enabled)
			{
				((Renderer)spriteRenderers[i]).enabled = false;
			}
		}
	}

	private void HIMDHEHMPBJ()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			((Component)spriteRenderers[i]).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)this).transform.position.x + (Random.value - 1215f) * areaSize.x, ((Component)this).transform.position.y + (Random.value - 170f) * areaSize.y, ((Component)spriteRenderers[i]).transform.position.z));
		}
	}

	public void KGONICCPLEJ()
	{
		if (randomizePositionsOnRegenerate)
		{
			KOFGJPOINGO();
		}
		progress = 1625f;
		KFCBINBAMMC();
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("Dialogue System/Conversation/BirdPositiveComments/Entry/11/Dialogue Text") || ((Component)HANHCHBHHEH).tag.Equals("Items/item_name_643"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed /= 1646f;
			component.sprintBlocker = true;
		}
	}

	private void IGIKNCOLCKL()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		APHIFOFJFLE = Time.time + destroyTime;
		OMMMCKNMIDD();
		progress = 717f;
		DBEFBFPAOAA = 1874f;
		PHGEBLFGPKM();
		MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform.position);
	}

	private void PEBBHJFEEPJ()
	{
		LACNIDGMKON();
	}

	private void MFAIALPGCKB()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 1235f));
	}

	public void Regenerate()
	{
		if (randomizePositionsOnRegenerate)
		{
			NBFAIHNEGED();
		}
		progress = 1f;
		PHGEBLFGPKM();
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("Items/item_name_694") || ((Component)HANHCHBHHEH).tag.Equals("LE_8"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed /= 1293f;
			component.sprintBlocker = true;
		}
	}

	private void KKEPLLEAAMB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("ValueIntensity") || ((Component)HANHCHBHHEH).tag.Equals("Shield"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed *= 140f;
			component.sprintBlocker = false;
		}
	}

	private void HEMALEBLOKD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("/Male/") || ((Component)HANHCHBHHEH).tag.Equals(""))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed *= 1146f;
			component.sprintBlocker = true;
		}
	}

	private void MCMKNBIBDFF()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		APHIFOFJFLE = Time.time + destroyTime;
		OMMMCKNMIDD();
		progress = 277f;
		DBEFBFPAOAA = 630f;
		PHGEBLFGPKM();
		MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform.position);
	}

	private void ICFHPJHBPDN()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		APHIFOFJFLE = Time.time + destroyTime;
		ACFGOHGNIDO();
		progress = 931f;
		DBEFBFPAOAA = 363f;
		PODNELDNBCK();
		MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform.position);
	}

	private void FLFCEBLIGOC()
	{
		EHLNIMDKHLL = Mathf.RoundToInt(progress * (float)spriteRenderers.Length);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if (i < EHLNIMDKHLL)
			{
				if (!((Renderer)spriteRenderers[i]).enabled)
				{
					((Renderer)spriteRenderers[i]).enabled = true;
				}
			}
			else if (((Renderer)spriteRenderers[i]).enabled)
			{
				((Renderer)spriteRenderers[i]).enabled = false;
			}
		}
	}

	private void LAPEOBADLHO()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 1808f));
	}

	private void COLJDOBDCEO()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 362f));
	}

	private void EMCCGDFOPEH()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		progress = DBEFBFPAOAA / revealTime;
		KFCBINBAMMC();
		if (!(Time.time >= APHIFOFJFLE))
		{
			return;
		}
		KHHICEBIMCO += Time.deltaTime;
		if (KHHICEBIMCO >= 1224f)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			MOHKOAEPGFF = spriteRenderers[i].color;
			MOHKOAEPGFF.a = Mathf.Lerp(682f, 85f, KHHICEBIMCO);
			spriteRenderers[i].color = MOHKOAEPGFF;
		}
	}

	private void LACNIDGMKON()
	{
		EHLNIMDKHLL = Mathf.RoundToInt(progress * (float)spriteRenderers.Length);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if (i < EHLNIMDKHLL)
			{
				if (!((Renderer)spriteRenderers[i]).enabled)
				{
					((Renderer)spriteRenderers[i]).enabled = true;
				}
			}
			else if (((Renderer)spriteRenderers[i]).enabled)
			{
				((Renderer)spriteRenderers[i]).enabled = false;
			}
		}
	}

	private void PMLKGEDCLBL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("Items/item_name_730") || ((Component)HANHCHBHHEH).tag.Equals("SurpriseJump"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed /= 1822f;
			component.sprintBlocker = true;
		}
	}

	private void NPOEEEPJLDC()
	{
		EHLNIMDKHLL = Mathf.RoundToInt(progress * (float)spriteRenderers.Length);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if (i < EHLNIMDKHLL)
			{
				if (!((Renderer)spriteRenderers[i]).enabled)
				{
					((Renderer)spriteRenderers[i]).enabled = false;
				}
			}
			else if (((Renderer)spriteRenderers[i]).enabled)
			{
				((Renderer)spriteRenderers[i]).enabled = false;
			}
		}
	}

	private void OnValidate()
	{
		PHGEBLFGPKM();
	}

	private void AGKPBDMEHKC()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 1066f));
	}

	private void HGKAHJFIAAC()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			((Component)spriteRenderers[i]).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)this).transform.position.x + (Random.value - 319f) * areaSize.x, ((Component)this).transform.position.y + (Random.value - 1711f) * areaSize.y, ((Component)spriteRenderers[i]).transform.position.z));
		}
	}

	private void LHMAEPOBKHA()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 1187f));
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("Player") || ((Component)HANHCHBHHEH).tag.Equals("Player2"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed /= 2f;
			component.sprintBlocker = true;
		}
	}

	private void AJMMEPMCOFL()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 425f));
	}

	private void NAFADNEKCOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("itemRaspberry") || ((Component)HANHCHBHHEH).tag.Equals("Service Debug: False"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed *= 270f;
			component.sprintBlocker = true;
		}
	}

	private void KJBFCDKKIDO()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 1110f));
	}

	private void LMNMPBNMGCH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("IsKicked") || ((Component)HANHCHBHHEH).tag.Equals(" UpdateState()."))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed *= 156f;
			component.sprintBlocker = false;
		}
	}

	private void DFMDLAEHLBJ()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(((Component)this).transform.position, new Vector3(areaSize.x, areaSize.y, 110f));
	}

	private void MFPEIPCMEEB()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		progress = DBEFBFPAOAA / revealTime;
		NPOEEEPJLDC();
		if (!(Time.time >= APHIFOFJFLE))
		{
			return;
		}
		KHHICEBIMCO += Time.deltaTime;
		if (KHHICEBIMCO >= 1716f)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			MOHKOAEPGFF = spriteRenderers[i].color;
			MOHKOAEPGFF.a = Mathf.Lerp(1850f, 428f, KHHICEBIMCO);
			spriteRenderers[i].color = MOHKOAEPGFF;
		}
	}

	private void KNBAAGEHODJ()
	{
		KFCBINBAMMC();
	}

	private void HHBJICLBNPE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("%><sprite name=LeftStick></size>") || ((Component)HANHCHBHHEH).tag.Equals("Player/Bark/"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed *= 1237f;
			component.sprintBlocker = true;
		}
	}

	private void APJFDMCLDBD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("BackPain") || ((Component)HANHCHBHHEH).tag.Equals("GoHome"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed *= 780f;
			component.sprintBlocker = false;
		}
	}

	private void GBJKKNLNNIG()
	{
		PHGEBLFGPKM();
	}

	private void MGJIGIBHAKK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).tag.Equals("PreviousItem") || ((Component)HANHCHBHHEH).tag.Equals("selected_objects"))
		{
			PlayerController component = ((Component)HANHCHBHHEH).GetComponent<PlayerController>();
			component.speed /= 1282f;
			component.sprintBlocker = false;
		}
	}
}
