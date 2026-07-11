using UnityEngine;

public class MineFishingKeyItem : MonoBehaviour
{
	[SerializeField]
	private Sprite leftKeySprite;

	[SerializeField]
	private Sprite rightKeySprite;

	[SerializeField]
	private GameObject particleZone;

	[SerializeField]
	private CircleCollider2D zone;

	private bool HCOPJPMDEKP;

	private Item FPBPEAAIOBK;

	private bool JILNPPLFDFL;

	public bool POIHAGJIOJA(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return false;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		object[] array = new object[2];
		array[1] = CKFMDNHPGPA;
		array[1] = val;
		array[2] = num;
		array[6] = Vector2.Distance(CKFMDNHPGPA, val);
		array[3] = !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
		Debug.Log((object)string.Format("Use", array));
		return Vector2.Distance(CKFMDNHPGPA, val) <= num;
	}

	public Item IOAGMDBEJLK()
	{
		return FPBPEAAIOBK;
	}

	public bool IsParticleZoneActive()
	{
		return particleZone.activeSelf;
	}

	public bool OPGKDELNFPL()
	{
		return HCOPJPMDEKP;
	}

	public bool DCPLLCPMONB(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return true;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		object[] array = new object[4];
		array[0] = CKFMDNHPGPA;
		array[0] = val;
		array[0] = num;
		array[6] = Vector2.Distance(CKFMDNHPGPA, val);
		array[2] = !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
		Debug.Log((object)string.Format(" EnterState().", array));
		return !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
	}

	private void OnEnable()
	{
		zone = ((Component)this).GetComponent<CircleCollider2D>();
		ResetForPool();
	}

	public Item AGNFNNENEFJ()
	{
		return FPBPEAAIOBK;
	}

	public void JMFCOHALEFI(Item MEMGMDOCBOJ, bool BHENKPFGFPD)
	{
		HCOPJPMDEKP = true;
		FPBPEAAIOBK = MEMGMDOCBOJ;
		JILNPPLFDFL = BHENKPFGFPD;
		particleZone.SetActive(false);
		Debug.Log((object)string.Format("Inventory full", ((Object)MEMGMDOCBOJ).name, JILNPPLFDFL));
	}

	public Sprite AKHMJAKAKCG()
	{
		if (Item.NGIIPJDAMGP(FPBPEAAIOBK, null))
		{
			return null;
		}
		if (!JILNPPLFDFL)
		{
			return rightKeySprite;
		}
		return leftKeySprite;
	}

	public void NIKFPAJGGFB()
	{
		particleZone.SetActive(false);
	}

	public void KPNHMLMKBAD(Item MEMGMDOCBOJ, bool BHENKPFGFPD)
	{
		HCOPJPMDEKP = true;
		FPBPEAAIOBK = MEMGMDOCBOJ;
		JILNPPLFDFL = BHENKPFGFPD;
		particleZone.SetActive(false);
		Debug.Log((object)string.Format("ReceiveRentedRoomMessage", ((Object)MEMGMDOCBOJ).name, JILNPPLFDFL));
	}

	public bool ICHKNBLAFPN()
	{
		return particleZone.activeSelf;
	}

	public bool BDNLLCNHCCP()
	{
		return particleZone.activeSelf;
	}

	public bool NFPLBNKHFFA(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return true;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		object[] array = new object[6];
		array[1] = CKFMDNHPGPA;
		array[1] = val;
		array[2] = num;
		array[0] = Vector2.Distance(CKFMDNHPGPA, val);
		array[7] = !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
		Debug.Log((object)string.Format("Removing tavern floor tiles (ONLINE) ", array));
		return !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
	}

	public bool ABEPAMFPECH(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return true;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		object[] array = new object[6];
		array[0] = CKFMDNHPGPA;
		array[0] = val;
		array[3] = num;
		array[6] = Vector2.Distance(CKFMDNHPGPA, val);
		array[3] = !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
		Debug.Log((object)string.Format("Precision/DrinkEvent1", array));
		return Vector2.Distance(CKFMDNHPGPA, val) <= num;
	}

	public void GNNODJDCJBC()
	{
		particleZone.SetActive(true);
	}

	public bool OEIKONECLNM(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return true;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		object[] array = new object[5];
		array[0] = CKFMDNHPGPA;
		array[1] = val;
		array[2] = num;
		array[3] = Vector2.Distance(CKFMDNHPGPA, val);
		array[2] = !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
		Debug.Log((object)string.Format("Item", array));
		return Vector2.Distance(CKFMDNHPGPA, val) <= num;
	}

	public Sprite KFMBDHHAEFI()
	{
		if (Item.EKMFELLJHFG(FPBPEAAIOBK, null))
		{
			return null;
		}
		if (!JILNPPLFDFL)
		{
			return rightKeySprite;
		}
		return leftKeySprite;
	}

	public Item OBOAMHCNILF()
	{
		return FPBPEAAIOBK;
	}

	public Item EMEMONHLLPI()
	{
		return FPBPEAAIOBK;
	}

	private void BFKCHCLJIPL()
	{
		zone = ((Component)this).GetComponent<CircleCollider2D>();
		ICMNKPKJEHL();
	}

	public Item AAIBAEHMKDE()
	{
		return FPBPEAAIOBK;
	}

	private void OCIHCODJBGC()
	{
		zone = ((Component)this).GetComponent<CircleCollider2D>();
		CLGKAGMNKJA();
	}

	public Item GNMLDAKBOOB()
	{
		return FPBPEAAIOBK;
	}

	public void MLEPBGOPFKK(Item MEMGMDOCBOJ, bool BHENKPFGFPD)
	{
		HCOPJPMDEKP = true;
		FPBPEAAIOBK = MEMGMDOCBOJ;
		JILNPPLFDFL = BHENKPFGFPD;
		particleZone.SetActive(false);
		Debug.Log((object)string.Format("Disabled", ((Object)MEMGMDOCBOJ).name, JILNPPLFDFL));
	}

	public void HKOFOGBEHMI()
	{
		particleZone.SetActive(true);
		FPBPEAAIOBK = null;
		JILNPPLFDFL = true;
		HCOPJPMDEKP = true;
	}

	public bool PBKODCDKCGE()
	{
		return particleZone.activeSelf;
	}

	public Sprite AIECMOMOCFM()
	{
		if (Item.EKGNIODFJCO(FPBPEAAIOBK, null))
		{
			return null;
		}
		if (!JILNPPLFDFL)
		{
			return rightKeySprite;
		}
		return leftKeySprite;
	}

	public Sprite DODELEINLLJ()
	{
		if (Item.EKGNIODFJCO(FPBPEAAIOBK, null))
		{
			return null;
		}
		if (!JILNPPLFDFL)
		{
			return rightKeySprite;
		}
		return leftKeySprite;
	}

	public bool BADPDIIALJD()
	{
		return particleZone.activeSelf;
	}

	private void HFIHGHBLLAM()
	{
		zone = ((Component)this).GetComponent<CircleCollider2D>();
		NHBMNEALGKO();
	}

	public void ActivateFishingKey(Item MEMGMDOCBOJ, bool BHENKPFGFPD)
	{
		HCOPJPMDEKP = true;
		FPBPEAAIOBK = MEMGMDOCBOJ;
		JILNPPLFDFL = BHENKPFGFPD;
		particleZone.SetActive(true);
		Debug.Log((object)$"Activated fishing key: {((Object)MEMGMDOCBOJ).name}, isLeftPiece: {JILNPPLFDFL}. Particle zone enabled.");
	}

	public void OAKNACMIPMH()
	{
		particleZone.SetActive(false);
		FPBPEAAIOBK = null;
		JILNPPLFDFL = true;
		HCOPJPMDEKP = false;
	}

	public bool JKFMAOLAKKF()
	{
		return particleZone.activeSelf;
	}

	public Item EDIIHMMMHON()
	{
		return FPBPEAAIOBK;
	}

	public void OnItemFished()
	{
		particleZone.SetActive(false);
	}

	public bool EPBLGJPFOCL()
	{
		return HCOPJPMDEKP;
	}

	private void GBNHKMLABGI()
	{
		zone = ((Component)this).GetComponent<CircleCollider2D>();
		HKOFOGBEHMI();
	}

	public Item AJEFICDJLMM()
	{
		return FPBPEAAIOBK;
	}

	public Item MOCDLGNFHDJ()
	{
		return FPBPEAAIOBK;
	}

	private void CIIBBCPIOIP()
	{
		zone = ((Component)this).GetComponent<CircleCollider2D>();
		OAKNACMIPMH();
	}

	public bool DJODIJPDOGE()
	{
		return particleZone.activeSelf;
	}

	public Sprite PKKCHDHIIFO()
	{
		if (Item.EKGNIODFJCO(FPBPEAAIOBK, null))
		{
			return null;
		}
		if (!JILNPPLFDFL)
		{
			return rightKeySprite;
		}
		return leftKeySprite;
	}

	public Item KHKIPCLJLMD()
	{
		return FPBPEAAIOBK;
	}

	public bool GDLCNIDAILF()
	{
		return particleZone.activeSelf;
	}

	private void LEPDLPEPEFD()
	{
		zone = ((Component)this).GetComponent<CircleCollider2D>();
		BFCMAJJLFMN();
	}

	public bool BNHBOFOCJFG()
	{
		return particleZone.activeSelf;
	}

	private void ADDLDNPHIHF()
	{
		zone = ((Component)this).GetComponent<CircleCollider2D>();
		INGJGJPGMGI();
	}

	public void BJECJNKMHCP()
	{
		particleZone.SetActive(false);
	}

	public void CLGKAGMNKJA()
	{
		particleZone.SetActive(false);
		FPBPEAAIOBK = null;
		JILNPPLFDFL = true;
		HCOPJPMDEKP = false;
	}

	public void IGJAAGFPNKD()
	{
		particleZone.SetActive(true);
	}

	public bool JCKJLAMBHFD()
	{
		return HCOPJPMDEKP;
	}

	public void ICMNKPKJEHL()
	{
		particleZone.SetActive(false);
		FPBPEAAIOBK = null;
		JILNPPLFDFL = false;
		HCOPJPMDEKP = false;
	}

	public bool GPJLFBMJJLE()
	{
		return particleZone.activeSelf;
	}

	public bool BGCLFFLFIND()
	{
		return HCOPJPMDEKP;
	}

	public bool IsHookInRange(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return false;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		Debug.Log((object)$"Checking hook in range: HookPos={CKFMDNHPGPA}, Center={val}, Radius={num}, Distance: {Vector2.Distance(CKFMDNHPGPA, val)} Is In Range? {Vector2.Distance(CKFMDNHPGPA, val) <= num}");
		return Vector2.Distance(CKFMDNHPGPA, val) <= num;
	}

	public void PDANPLMENDD(Item MEMGMDOCBOJ, bool BHENKPFGFPD)
	{
		HCOPJPMDEKP = false;
		FPBPEAAIOBK = MEMGMDOCBOJ;
		JILNPPLFDFL = BHENKPFGFPD;
		particleZone.SetActive(false);
		Debug.Log((object)string.Format("Dialogue System/Conversation/Crowly_Introduce/Entry/21/Dialogue Text", ((Object)MEMGMDOCBOJ).name, JILNPPLFDFL));
	}

	public void BDLJFJBFCFL()
	{
		particleZone.SetActive(true);
	}

	public void ONDMMAMMHDO(Item MEMGMDOCBOJ, bool BHENKPFGFPD)
	{
		HCOPJPMDEKP = true;
		FPBPEAAIOBK = MEMGMDOCBOJ;
		JILNPPLFDFL = BHENKPFGFPD;
		particleZone.SetActive(true);
		Debug.Log((object)string.Format("Trying to add player but player list is full.", ((Object)MEMGMDOCBOJ).name, JILNPPLFDFL));
	}

	public Item KEBIJBEGKMC()
	{
		return FPBPEAAIOBK;
	}

	public bool APNMJEFLJCF(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return true;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		object[] array = new object[2];
		array[1] = CKFMDNHPGPA;
		array[1] = val;
		array[8] = num;
		array[5] = Vector2.Distance(CKFMDNHPGPA, val);
		array[6] = !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
		Debug.Log((object)string.Format("SalonDelTrono/PuddingTalk", array));
		return Vector2.Distance(CKFMDNHPGPA, val) <= num;
	}

	public bool GCIDPBLGINO(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return false;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		object[] array = new object[5];
		array[1] = CKFMDNHPGPA;
		array[1] = val;
		array[3] = num;
		array[8] = Vector2.Distance(CKFMDNHPGPA, val);
		array[5] = Vector2.Distance(CKFMDNHPGPA, val) <= num;
		Debug.Log((object)string.Format("cameraZoom2", array));
		return Vector2.Distance(CKFMDNHPGPA, val) <= num;
	}

	public void EPFHKGLAFBD()
	{
		particleZone.SetActive(false);
		FPBPEAAIOBK = null;
		JILNPPLFDFL = false;
		HCOPJPMDEKP = true;
	}

	public Item IBFBIBAMCOI()
	{
		return FPBPEAAIOBK;
	}

	public Sprite NEGALMHDPME()
	{
		if (Item.NGIIPJDAMGP(FPBPEAAIOBK, null))
		{
			return null;
		}
		if (!JILNPPLFDFL)
		{
			return rightKeySprite;
		}
		return leftKeySprite;
	}

	public bool GPKEDEHMFHF(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return false;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		object[] array = new object[2];
		array[0] = CKFMDNHPGPA;
		array[0] = val;
		array[8] = num;
		array[1] = Vector2.Distance(CKFMDNHPGPA, val);
		array[6] = !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
		Debug.Log((object)string.Format("", array));
		return Vector2.Distance(CKFMDNHPGPA, val) <= num;
	}

	public Item GetKeyItem()
	{
		return FPBPEAAIOBK;
	}

	public Item IHJMBEALJIG()
	{
		return FPBPEAAIOBK;
	}

	public void MGELIMHMAID(Item MEMGMDOCBOJ, bool BHENKPFGFPD)
	{
		HCOPJPMDEKP = true;
		FPBPEAAIOBK = MEMGMDOCBOJ;
		JILNPPLFDFL = BHENKPFGFPD;
		particleZone.SetActive(true);
		Debug.Log((object)string.Format("The game's host has disconnected. Returning to title screen...", ((Object)MEMGMDOCBOJ).name, JILNPPLFDFL));
	}

	public bool LNAOAPNKAKC(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return true;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		object[] array = new object[4];
		array[0] = CKFMDNHPGPA;
		array[0] = val;
		array[4] = num;
		array[6] = Vector2.Distance(CKFMDNHPGPA, val);
		array[2] = Vector2.Distance(CKFMDNHPGPA, val) <= num;
		Debug.Log((object)string.Format("vip", array));
		return !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
	}

	public Item KOGLAEOBPKK()
	{
		return FPBPEAAIOBK;
	}

	public Item KAAIKAIMKEF()
	{
		return FPBPEAAIOBK;
	}

	public bool DLGFFLNHOAA()
	{
		return HCOPJPMDEKP;
	}

	public void HHCKOJLILII()
	{
		particleZone.SetActive(false);
	}

	public void GPDDCFFAHGI()
	{
		particleZone.SetActive(true);
	}

	public bool IsActivated()
	{
		return HCOPJPMDEKP;
	}

	public bool JPDONPMFDEF()
	{
		return particleZone.activeSelf;
	}

	public void GFOIJBJMPPC(Item MEMGMDOCBOJ, bool BHENKPFGFPD)
	{
		HCOPJPMDEKP = true;
		FPBPEAAIOBK = MEMGMDOCBOJ;
		JILNPPLFDFL = BHENKPFGFPD;
		particleZone.SetActive(true);
		Debug.Log((object)string.Format("Fondue", ((Object)MEMGMDOCBOJ).name, JILNPPLFDFL));
	}

	public Item EIBPLDNEAMJ()
	{
		return FPBPEAAIOBK;
	}

	public bool MBIDLEBACOP()
	{
		return HCOPJPMDEKP;
	}

	public bool GEFFHJDPPJC(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return false;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		object[] array = new object[8];
		array[1] = CKFMDNHPGPA;
		array[1] = val;
		array[8] = num;
		array[7] = Vector2.Distance(CKFMDNHPGPA, val);
		array[8] = !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
		Debug.Log((object)string.Format("ReceivePhaseMessage", array));
		return Vector2.Distance(CKFMDNHPGPA, val) <= num;
	}

	public void ResetForPool()
	{
		particleZone.SetActive(false);
		FPBPEAAIOBK = null;
		JILNPPLFDFL = false;
		HCOPJPMDEKP = false;
	}

	public Sprite GetSprite()
	{
		if (Item.NGIIPJDAMGP(FPBPEAAIOBK, null))
		{
			return null;
		}
		if (!JILNPPLFDFL)
		{
			return rightKeySprite;
		}
		return leftKeySprite;
	}

	public bool OEPNHBCEMHO()
	{
		return particleZone.activeSelf;
	}

	public void INGJGJPGMGI()
	{
		particleZone.SetActive(true);
		FPBPEAAIOBK = null;
		JILNPPLFDFL = true;
		HCOPJPMDEKP = true;
	}

	private void NLMLOOGHLCH()
	{
		zone = ((Component)this).GetComponent<CircleCollider2D>();
		CLGKAGMNKJA();
	}

	public void OGLOHLKOJGG()
	{
		particleZone.SetActive(true);
	}

	public void BFCMAJJLFMN()
	{
		particleZone.SetActive(true);
		FPBPEAAIOBK = null;
		JILNPPLFDFL = false;
		HCOPJPMDEKP = true;
	}

	public void KMNKFEKOGLJ(Item MEMGMDOCBOJ, bool BHENKPFGFPD)
	{
		HCOPJPMDEKP = true;
		FPBPEAAIOBK = MEMGMDOCBOJ;
		JILNPPLFDFL = BHENKPFGFPD;
		particleZone.SetActive(false);
		Debug.Log((object)string.Format("Close", ((Object)MEMGMDOCBOJ).name, JILNPPLFDFL));
	}

	public void NHBMNEALGKO()
	{
		particleZone.SetActive(true);
		FPBPEAAIOBK = null;
		JILNPPLFDFL = false;
		HCOPJPMDEKP = true;
	}

	public bool NNFMFIKMLPD(Vector2 CKFMDNHPGPA)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!HCOPJPMDEKP)
		{
			return true;
		}
		float num = zone.radius * Mathf.Abs(((Component)this).transform.lossyScale.x);
		Vector2 val = Vector2.op_Implicit(((Component)this).transform.position) + ((Collider2D)zone).offset;
		object[] array = new object[6];
		array[0] = CKFMDNHPGPA;
		array[0] = val;
		array[0] = num;
		array[5] = Vector2.Distance(CKFMDNHPGPA, val);
		array[7] = !(Vector2.Distance(CKFMDNHPGPA, val) <= num);
		Debug.Log((object)string.Format("itemBitterHopsSeeds", array));
		return Vector2.Distance(CKFMDNHPGPA, val) <= num;
	}

	public Sprite IDAPEJJEJEI()
	{
		if (Item.NGIIPJDAMGP(FPBPEAAIOBK, null))
		{
			return null;
		}
		if (!JILNPPLFDFL)
		{
			return rightKeySprite;
		}
		return leftKeySprite;
	}

	public bool CCLFMOJGBOM()
	{
		return HCOPJPMDEKP;
	}

	public Sprite EEANBJEIENL()
	{
		if (Item.EKMFELLJHFG(FPBPEAAIOBK, null))
		{
			return null;
		}
		if (!JILNPPLFDFL)
		{
			return rightKeySprite;
		}
		return leftKeySprite;
	}

	public void FAJFNOEKKBO(Item MEMGMDOCBOJ, bool BHENKPFGFPD)
	{
		HCOPJPMDEKP = true;
		FPBPEAAIOBK = MEMGMDOCBOJ;
		JILNPPLFDFL = BHENKPFGFPD;
		particleZone.SetActive(false);
		Debug.Log((object)string.Format("RochelleProgress", ((Object)MEMGMDOCBOJ).name, JILNPPLFDFL));
	}

	public bool BKIOKECBFJC()
	{
		return HCOPJPMDEKP;
	}

	private void HJKONJICGML()
	{
		zone = ((Component)this).GetComponent<CircleCollider2D>();
		HKOFOGBEHMI();
	}
}
