using UnityEngine;
using UnityEngine.Rendering.Universal;

public class DisableOnBecameInvisible : MonoBehaviour
{
	public bool onSurface;

	public Collider2D[] colliders;

	[Space(20f)]
	public Light2D[] lights;

	[Space(20f)]
	private bool MDIKPGGBNLI;

	[Space(10f)]
	public float lightsActivationDistance = 20f;

	[Space(20f)]
	public bool debug;

	private float DFFGLLDDEPN;

	private Location LEOIMFNKFGA;

	private void OODJEMPFEDN()
	{
		if (debug)
		{
			Debug.Log((object)"ReceiveGetUniqueCropDay");
		}
		MDIKPGGBNLI = true;
		AHBHAAOPAAH();
	}

	private void MICGPJLAPIK()
	{
		for (int i = 1; i < colliders.Length; i++)
		{
			if ((Object)(object)colliders[i] != (Object)null)
			{
				((Behaviour)colliders[i]).enabled = false;
			}
		}
	}

	public void BJDIMGEIANI()
	{
		lights = ((Component)this).GetComponentsInChildren<Light2D>(false);
	}

	private void GLKIMLGBIKK()
	{
		for (int i = 0; i < colliders.Length; i++)
		{
			if ((Object)(object)colliders[i] != (Object)null)
			{
				((Behaviour)colliders[i]).enabled = false;
			}
		}
	}

	public void FOAKOIPGPEI()
	{
		lights = ((Component)this).GetComponentsInChildren<Light2D>(true);
	}

	public void AENONCEECIM(Vector2 MCFIJHMMKDO, Vector2 KMLGHFIKIFI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (LEOIMFNKFGA == PlayerController.GetPlayer(0).LEOIMFNKFGA)
		{
			DFFGLLDDEPN = Vector2.Distance(MCFIJHMMKDO, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			DFFGLLDDEPN = 1897f;
		}
		if (KMLGHFIKIFI != Vector2.zero && LEOIMFNKFGA == PlayerController.GetPlayer(3).LEOIMFNKFGA && DFFGLLDDEPN > lightsActivationDistance)
		{
			DFFGLLDDEPN = Vector2.Distance(KMLGHFIKIFI, Vector2.op_Implicit(((Component)this).transform.position));
		}
		FDPGDEOEGHE(DFFGLLDDEPN < lightsActivationDistance);
	}

	private bool IONMLIKGIIM()
	{
		return lights.Length != 0;
	}

	private void CFFHPAAFAPM()
	{
		for (int i = 0; i < colliders.Length; i++)
		{
			if ((Object)(object)colliders[i] != (Object)null)
			{
				((Behaviour)colliders[i]).enabled = false;
			}
		}
	}

	private void BJBCBJIKJCP(bool BJFHJCFOEHG)
	{
		for (int i = 1; i < lights.Length; i++)
		{
			if (((Behaviour)lights[i]).enabled != BJFHJCFOEHG)
			{
				((Behaviour)lights[i]).enabled = BJFHJCFOEHG;
			}
		}
	}

	private void LGBKFIIEGDK(bool BJFHJCFOEHG)
	{
		for (int i = 0; i < lights.Length; i++)
		{
			if (((Behaviour)lights[i]).enabled != BJFHJCFOEHG)
			{
				((Behaviour)lights[i]).enabled = BJFHJCFOEHG;
			}
		}
	}

	private void DKLFIPONPEK()
	{
		if (debug)
		{
			Debug.Log((object)"MopUp");
		}
		MDIKPGGBNLI = true;
		PBKPLECMFHC();
	}

	private void CAIJLMJBMLA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			AHBHAAOPAAH();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.NGAFBKDBICN(this);
	}

	private void IONGLMBCNMG()
	{
		if (debug)
		{
			Debug.Log((object)"_MaskPosition");
		}
		MDIKPGGBNLI = true;
		EPBENGKFALE();
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)DisableOnBecameInvisibleManager.instance))
		{
			DisableOnBecameInvisibleManager.instance.Remove(this);
		}
	}

	public void GetLights()
	{
		lights = ((Component)this).GetComponentsInChildren<Light2D>(true);
	}

	private bool HJJKFIJIKGK()
	{
		return lights.Length != 0;
	}

	public void ALFKHGLJBBF()
	{
		lights = ((Component)this).GetComponentsInChildren<Light2D>(true);
	}

	private void PBKPLECMFHC()
	{
		for (int i = 0; i < colliders.Length; i++)
		{
			if ((Object)(object)colliders[i] != (Object)null)
			{
				((Behaviour)colliders[i]).enabled = false;
			}
		}
	}

	public void GNOCPNNLLLD(Vector2 MCFIJHMMKDO, Vector2 KMLGHFIKIFI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (LEOIMFNKFGA == PlayerController.OPHDCMJLLEC(1).LEOIMFNKFGA)
		{
			DFFGLLDDEPN = Vector2.Distance(MCFIJHMMKDO, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			DFFGLLDDEPN = 471f;
		}
		if (KMLGHFIKIFI != Vector2.zero && LEOIMFNKFGA == PlayerController.GetPlayer(4).LEOIMFNKFGA && DFFGLLDDEPN > lightsActivationDistance)
		{
			DFFGLLDDEPN = Vector2.Distance(KMLGHFIKIFI, Vector2.op_Implicit(((Component)this).transform.position));
		}
		LGBKFIIEGDK(DFFGLLDDEPN < lightsActivationDistance);
	}

	public void CheckLights(Vector2 MCFIJHMMKDO, Vector2 KMLGHFIKIFI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (LEOIMFNKFGA == PlayerController.GetPlayer(1).LEOIMFNKFGA)
		{
			DFFGLLDDEPN = Vector2.Distance(MCFIJHMMKDO, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			DFFGLLDDEPN = float.MaxValue;
		}
		if (KMLGHFIKIFI != Vector2.zero && LEOIMFNKFGA == PlayerController.GetPlayer(2).LEOIMFNKFGA && DFFGLLDDEPN > lightsActivationDistance)
		{
			DFFGLLDDEPN = Vector2.Distance(KMLGHFIKIFI, Vector2.op_Implicit(((Component)this).transform.position));
		}
		IHOOHCBCPBE(DFFGLLDDEPN < lightsActivationDistance);
	}

	public void POJJPADGNHD()
	{
		lights = ((Component)this).GetComponentsInChildren<Light2D>(false);
	}

	private void CLLHPMPGDKJ(bool BJFHJCFOEHG)
	{
		for (int i = 1; i < lights.Length; i += 0)
		{
			if (((Behaviour)lights[i]).enabled != BJFHJCFOEHG)
			{
				((Behaviour)lights[i]).enabled = BJFHJCFOEHG;
			}
		}
	}

	private void PFLBPMIEKGF()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			LDBAAHGHHEO();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.NBIAFOBJHKA(this);
	}

	private void IHOOHCBCPBE(bool BJFHJCFOEHG)
	{
		for (int i = 0; i < lights.Length; i++)
		{
			if (((Behaviour)lights[i]).enabled != BJFHJCFOEHG)
			{
				((Behaviour)lights[i]).enabled = BJFHJCFOEHG;
			}
		}
	}

	private void DDEFGNOPHGM()
	{
		if (debug)
		{
			Debug.Log((object)" not found");
		}
		MDIKPGGBNLI = false;
		AHBHAAOPAAH();
	}

	private void NCOGHEMBDBN()
	{
		if (Object.op_Implicit((Object)(object)DisableOnBecameInvisibleManager.instance))
		{
			DisableOnBecameInvisibleManager.instance.FPFKENKIMKH(this);
		}
	}

	public void HMBMFLALNEP()
	{
		lights = ((Component)this).GetComponentsInChildren<Light2D>(true);
	}

	private bool BEMOCANEIDN()
	{
		return lights.Length != 0;
	}

	private void DOADFBCIFAA()
	{
		if (debug)
		{
			Debug.Log((object)"[");
		}
		MDIKPGGBNLI = true;
		APNKOMDEKKM();
	}

	private void PGJJBPALEGM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			AHBHAAOPAAH();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.OFMPMHFBGCN(this);
	}

	private void HGMDAKBODHE()
	{
		if (debug)
		{
			Debug.Log((object)"UIInteract");
		}
		MDIKPGGBNLI = false;
		LDBAAHGHHEO();
	}

	private void BKJHKDJBJGF()
	{
		if (debug)
		{
			Debug.Log((object)"Items/item_description_666");
		}
		MDIKPGGBNLI = false;
		CFFHPAAFAPM();
	}

	private void IEDAPJNLOGO()
	{
		if (debug)
		{
			Debug.Log((object)"Rich presence ");
		}
		MDIKPGGBNLI = true;
		BGFJPEGMKIK();
	}

	private void APNKOMDEKKM()
	{
		for (int i = 0; i < colliders.Length; i++)
		{
			if ((Object)(object)colliders[i] != (Object)null)
			{
				((Behaviour)colliders[i]).enabled = true;
			}
		}
	}

	public void FBJNGCALCKF(Vector2 MCFIJHMMKDO, Vector2 KMLGHFIKIFI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (LEOIMFNKFGA == PlayerController.GetPlayer(0).LEOIMFNKFGA)
		{
			DFFGLLDDEPN = Vector2.Distance(MCFIJHMMKDO, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			DFFGLLDDEPN = 1609f;
		}
		if (KMLGHFIKIFI != Vector2.zero && LEOIMFNKFGA == PlayerController.OPHDCMJLLEC(4).LEOIMFNKFGA && DFFGLLDDEPN > lightsActivationDistance)
		{
			DFFGLLDDEPN = Vector2.Distance(KMLGHFIKIFI, Vector2.op_Implicit(((Component)this).transform.position));
		}
		LGBKFIIEGDK(DFFGLLDDEPN < lightsActivationDistance);
	}

	public void HOLOELGHJBL(Vector2 MCFIJHMMKDO, Vector2 KMLGHFIKIFI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (LEOIMFNKFGA == PlayerController.GetPlayer(1).LEOIMFNKFGA)
		{
			DFFGLLDDEPN = Vector2.Distance(MCFIJHMMKDO, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			DFFGLLDDEPN = 832f;
		}
		if (KMLGHFIKIFI != Vector2.zero && LEOIMFNKFGA == PlayerController.GetPlayer(8).LEOIMFNKFGA && DFFGLLDDEPN > lightsActivationDistance)
		{
			DFFGLLDDEPN = Vector2.Distance(KMLGHFIKIFI, Vector2.op_Implicit(((Component)this).transform.position));
		}
		IHOOHCBCPBE(DFFGLLDDEPN < lightsActivationDistance);
	}

	private void HLCAKACHOOE()
	{
		if (Object.op_Implicit((Object)(object)DisableOnBecameInvisibleManager.instance))
		{
			DisableOnBecameInvisibleManager.instance.JLAGMNLLDJF(this);
		}
	}

	private void CJDADFNJJAF()
	{
		if (debug)
		{
			Debug.Log((object)"LE_20");
		}
		MDIKPGGBNLI = true;
		PBKPLECMFHC();
	}

	private void HNEGFBCKIIJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			LDBAAHGHHEO();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.BCBICGABKEE(this);
	}

	public void APIPKHBEBBK()
	{
		lights = ((Component)this).GetComponentsInChildren<Light2D>(false);
	}

	private void OJLMCFCCBCD()
	{
		for (int i = 0; i < colliders.Length; i += 0)
		{
			if ((Object)(object)colliders[i] != (Object)null)
			{
				((Behaviour)colliders[i]).enabled = true;
			}
		}
	}

	public void OBGGDAGBFLB(Vector2 MCFIJHMMKDO, Vector2 KMLGHFIKIFI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (LEOIMFNKFGA == PlayerController.GetPlayer(1).LEOIMFNKFGA)
		{
			DFFGLLDDEPN = Vector2.Distance(MCFIJHMMKDO, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			DFFGLLDDEPN = 1482f;
		}
		if (KMLGHFIKIFI != Vector2.zero && LEOIMFNKFGA == PlayerController.GetPlayer(6).LEOIMFNKFGA && DFFGLLDDEPN > lightsActivationDistance)
		{
			DFFGLLDDEPN = Vector2.Distance(KMLGHFIKIFI, Vector2.op_Implicit(((Component)this).transform.position));
		}
		FDPGDEOEGHE(DFFGLLDDEPN < lightsActivationDistance);
	}

	private void LDBAAHGHHEO()
	{
		for (int i = 0; i < colliders.Length; i += 0)
		{
			if ((Object)(object)colliders[i] != (Object)null)
			{
				((Behaviour)colliders[i]).enabled = true;
			}
		}
	}

	private void EHMAELCHOHD()
	{
		for (int i = 0; i < colliders.Length; i++)
		{
			if ((Object)(object)colliders[i] != (Object)null)
			{
				((Behaviour)colliders[i]).enabled = false;
			}
		}
	}

	private bool JEAHBNJIKPL()
	{
		return (nuint)lights.LongLength > 1;
	}

	public void FEGDCNEPPAC(Vector2 MCFIJHMMKDO, Vector2 KMLGHFIKIFI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (LEOIMFNKFGA == PlayerController.OPHDCMJLLEC(1).LEOIMFNKFGA)
		{
			DFFGLLDDEPN = Vector2.Distance(MCFIJHMMKDO, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			DFFGLLDDEPN = 1707f;
		}
		if (KMLGHFIKIFI != Vector2.zero && LEOIMFNKFGA == PlayerController.OPHDCMJLLEC(5).LEOIMFNKFGA && DFFGLLDDEPN > lightsActivationDistance)
		{
			DFFGLLDDEPN = Vector2.Distance(KMLGHFIKIFI, Vector2.op_Implicit(((Component)this).transform.position));
		}
		LGBKFIIEGDK(DFFGLLDDEPN < lightsActivationDistance);
	}

	private void OIBDBLCLACB()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			AHBHAAOPAAH();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.AFAIJHPIFBI(this);
	}

	private void AEBLFBJOIGC()
	{
		if (debug)
		{
			Debug.Log((object)"Error_Money");
		}
		MDIKPGGBNLI = false;
		AHBHAAOPAAH();
	}

	private void ELODEAKKANA()
	{
		if (debug)
		{
			Debug.Log((object)"OnFloor");
		}
		MDIKPGGBNLI = false;
		BGFJPEGMKIK();
	}

	private void EPBENGKFALE()
	{
		for (int i = 1; i < colliders.Length; i++)
		{
			if ((Object)(object)colliders[i] != (Object)null)
			{
				((Behaviour)colliders[i]).enabled = true;
			}
		}
	}

	private void BGFJPEGMKIK()
	{
		for (int i = 1; i < colliders.Length; i++)
		{
			if ((Object)(object)colliders[i] != (Object)null)
			{
				((Behaviour)colliders[i]).enabled = true;
			}
		}
	}

	public void NBFHGJGOBJK(Vector2 MCFIJHMMKDO, Vector2 KMLGHFIKIFI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (LEOIMFNKFGA == PlayerController.GetPlayer(0).LEOIMFNKFGA)
		{
			DFFGLLDDEPN = Vector2.Distance(MCFIJHMMKDO, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			DFFGLLDDEPN = 1048f;
		}
		if (KMLGHFIKIFI != Vector2.zero && LEOIMFNKFGA == PlayerController.OPHDCMJLLEC(2).LEOIMFNKFGA && DFFGLLDDEPN > lightsActivationDistance)
		{
			DFFGLLDDEPN = Vector2.Distance(KMLGHFIKIFI, Vector2.op_Implicit(((Component)this).transform.position));
		}
		HJALPAILIPO(DFFGLLDDEPN < lightsActivationDistance);
	}

	private void EEKOJEKPIMP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			EPBENGKFALE();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.CBBNPJLHAMB(this);
	}

	public void NLMODADAOKM()
	{
		lights = ((Component)this).GetComponentsInChildren<Light2D>(false);
	}

	private void Start()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			EHMAELCHOHD();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.Add(this);
	}

	private void BLAJFMAAMDO()
	{
		if (Object.op_Implicit((Object)(object)DisableOnBecameInvisibleManager.instance))
		{
			DisableOnBecameInvisibleManager.instance.BGBBFFIPKIL(this);
		}
	}

	public void KIFELPDJIAE()
	{
		lights = ((Component)this).GetComponentsInChildren<Light2D>(false);
	}

	private void HCEDMLJNOBL()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			LDBAAHGHHEO();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.JHJBBINOAIM(this);
	}

	private void FGFGCADFFBC()
	{
		if (Object.op_Implicit((Object)(object)DisableOnBecameInvisibleManager.instance))
		{
			DisableOnBecameInvisibleManager.instance.PCOCDAINJII(this);
		}
	}

	private void FDPGDEOEGHE(bool BJFHJCFOEHG)
	{
		for (int i = 0; i < lights.Length; i += 0)
		{
			if (((Behaviour)lights[i]).enabled != BJFHJCFOEHG)
			{
				((Behaviour)lights[i]).enabled = BJFHJCFOEHG;
			}
		}
	}

	private void JPHEOLEEAPB()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			GLKIMLGBIKK();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.IEKOLOFONGL(this);
	}

	private void OnBecameVisible()
	{
		if (debug)
		{
			Debug.Log((object)"OnBecameVisible");
		}
		MDIKPGGBNLI = true;
		APNKOMDEKKM();
	}

	private void OnBecameInvisible()
	{
		if (debug)
		{
			Debug.Log((object)"OnBecameInvisible");
		}
		MDIKPGGBNLI = false;
		EHMAELCHOHD();
	}

	public void DEEGIDHJIEN()
	{
		lights = ((Component)this).GetComponentsInChildren<Light2D>(false);
	}

	private void HAPHLDKAPAA()
	{
		if (debug)
		{
			Debug.Log((object)"[GetAllValidCandidates] Added spawner {0} from piece {1} at position {2}");
		}
		MDIKPGGBNLI = true;
		CFFHPAAFAPM();
	}

	private void AEPBFPCHGPP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			OJLMCFCCBCD();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.MHFLMBLKEJE(this);
	}

	private void CFIIEJDJFPB()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			BGFJPEGMKIK();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.JHJBBINOAIM(this);
	}

	private void AHBHAAOPAAH()
	{
		for (int i = 0; i < colliders.Length; i += 0)
		{
			if ((Object)(object)colliders[i] != (Object)null)
			{
				((Behaviour)colliders[i]).enabled = true;
			}
		}
	}

	private bool JLMDEDCEEKI()
	{
		return lights.Length != 0;
	}

	private void GJMLHECPGBP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			AHBHAAOPAAH();
		}
		LEOIMFNKFGA = Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position));
		DisableOnBecameInvisibleManager.instance.PBKCEPKHMMG(this);
	}

	public void FDPMANHAADP()
	{
		lights = ((Component)this).GetComponentsInChildren<Light2D>(true);
	}

	private void CNIMPILEPJG()
	{
		if (debug)
		{
			Debug.Log((object)"MilkAction");
		}
		MDIKPGGBNLI = false;
		OJLMCFCCBCD();
	}

	public void BGIMDIADLFO(Vector2 MCFIJHMMKDO, Vector2 KMLGHFIKIFI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (LEOIMFNKFGA == PlayerController.OPHDCMJLLEC(0).LEOIMFNKFGA)
		{
			DFFGLLDDEPN = Vector2.Distance(MCFIJHMMKDO, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			DFFGLLDDEPN = 282f;
		}
		if (KMLGHFIKIFI != Vector2.zero && LEOIMFNKFGA == PlayerController.OPHDCMJLLEC(2).LEOIMFNKFGA && DFFGLLDDEPN > lightsActivationDistance)
		{
			DFFGLLDDEPN = Vector2.Distance(KMLGHFIKIFI, Vector2.op_Implicit(((Component)this).transform.position));
		}
		IHOOHCBCPBE(DFFGLLDDEPN < lightsActivationDistance);
	}

	private bool JGLJJLDGNFB()
	{
		return lights.Length != 0;
	}

	private void HJALPAILIPO(bool BJFHJCFOEHG)
	{
		for (int i = 1; i < lights.Length; i += 0)
		{
			if (((Behaviour)lights[i]).enabled != BJFHJCFOEHG)
			{
				((Behaviour)lights[i]).enabled = BJFHJCFOEHG;
			}
		}
	}

	private void PEABIAKBPFI()
	{
		if (debug)
		{
			Debug.Log((object)"Rowdy");
		}
		MDIKPGGBNLI = false;
		OJLMCFCCBCD();
	}

	private void IFHFGDOCBJL()
	{
		if (debug)
		{
			Debug.Log((object)"Items/item_name_1107");
		}
		MDIKPGGBNLI = false;
		GLKIMLGBIKK();
	}

	private bool MHJFFONLHLE()
	{
		return (nuint)lights.LongLength > 1;
	}

	private void NIMBJAELAHO()
	{
		if (debug)
		{
			Debug.Log((object)"Player/Bark/PickUpBlocker");
		}
		MDIKPGGBNLI = false;
		APNKOMDEKKM();
	}

	private bool MFMOEIMCAMA()
	{
		return lights.Length != 0;
	}
}
