using Newtonsoft.Json;
using UnityEngine;

public class OnlineMagicBroom : OnlinePlaceable
{
	[JsonProperty("1")]
	public RobotVacNPC robotVacNPC;

	private float GCPMDBAMKIK = float.MaxValue;

	public void IOCNLKIMHMG(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		LKJCLCLHGLI(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void PNBDILOCGIE(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		MMOLBLAGMEG(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void MDKBFKGMDJO(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		GHFDMLHBKEB(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void HJCHDIGPGKN(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		BLNFGDFAPHE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void UpdateBroomPosition()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void NKAKGPHDNIE(string GEGDHHIDEEF)
	{
		KFMKDHDFOEE(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void EGBKNLBAGHA(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void FGKBNJLJJLH(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void OBOEHJGNBHE(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void KEJBGPOLHOA(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		robotVacNPC.animator.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void MGMPIDCAGNF(int GJKKNOKIKBJ)
	{
		robotVacNPC.animator.SetTrigger(GJKKNOKIKBJ);
	}

	public void FANDGCDPMBG()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void OAPEIELFIEM(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		FAMNCCECGMK(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void JMGFBMEEOLA(int GJKKNOKIKBJ)
	{
		robotVacNPC.animator.SetTrigger(GJKKNOKIKBJ);
	}

	public void NOMJMMIPOAE()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void EAIHIMLAIGE(string GEGDHHIDEEF)
	{
		ANPAJIMCIPE(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void BLIDEAAIBIF(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void LANOMBCPFLN()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void DODNEJNJOFO(string GEGDHHIDEEF)
	{
		BLINEGACJLF(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void NJBOBMMLGBN(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		MMOLBLAGMEG(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void OMOGMANABDM(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		robotVacNPC.animator.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void MKKLOMNEMKP(string GEGDHHIDEEF)
	{
		NOBBLCEPAOA(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void FNKDKGFFGPE(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		FAMNCCECGMK(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void EBHCNGMAOCC(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		OMOGMANABDM(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		Debug.Log((object)("Get Components " + ((Object)((Component)this).gameObject).name));
		robotVacNPC = ((Component)this).gameObject.GetComponentInChildren<RobotVacNPC>();
		robotVacNPC.onlineMagicBroom = this;
	}

	public void ILEEGGJDIJE(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		GHFDMLHBKEB(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void EKODBEDBJBE(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		KAKIEDMEFGE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void AKAGMDNEGGN(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void KEGFDOJJFEF(Vector2 CDHGIJJHPJB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)robotVacNPC).transform.position);
		}
		GCPMDBAMKIK = 170f;
	}

	public void IGGFCNGPGHA()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void BLNFGDFAPHE(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void HGMDIJMPOOA(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void MIKHGDGBMAN(string GEGDHHIDEEF)
	{
		KFMKDHDFOEE(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void MNPKAIJAGAN(Vector2 CDHGIJJHPJB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)robotVacNPC).transform.position);
		}
		GCPMDBAMKIK = 345f;
	}

	public void PCJDNLKDKKE(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		KAKIEDMEFGE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void CGEJIDHOCIE(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void ReceiveSetTrigger(string GEGDHHIDEEF)
	{
		ReceiveSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void JNKIIIFAJKI(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		MECKGICJMPP(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void PIPPNNGLJJA(bool IHLGDCAIPLN)
	{
		OnlineObjectsManager.instance.GHHKOOABOKA(uniqueId, IHLGDCAIPLN);
	}

	public void BNPOFFGGIKB(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		ADEOIABFFNG(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void AFGNJKDFEBC(string GEGDHHIDEEF)
	{
		JMIIPHHBNJI(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void KEDMECKILON(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		OMOGMANABDM(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void LJEPJCDMDDG(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		robotVacNPC.animator.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void ONJBBIFOLCH(string GEGDHHIDEEF)
	{
		ANPAJIMCIPE(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void BLINEGACJLF(int GJKKNOKIKBJ)
	{
		robotVacNPC.animator.SetTrigger(GJKKNOKIKBJ);
	}

	public void FCAEHCOEIEB()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void FEMDMCJNNHN(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		LJEPJCDMDDG(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void FCILGDAGLKB(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void NOBBLCEPAOA(int GJKKNOKIKBJ)
	{
		robotVacNPC.animator.SetTrigger(GJKKNOKIKBJ);
	}

	public void AEEIFEIFJEL(string GEGDHHIDEEF)
	{
		ReceiveSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void IHJLLKIMJHC(string GEGDHHIDEEF)
	{
		EGBKNLBAGHA(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void DEICHFILNJN(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		CGEJIDHOCIE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void PNDCFPFJIOE(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void HBFNPOIBCHG(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void FHJCKFDKNIO(string GEGDHHIDEEF)
	{
		GEPLGAFHBGE(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void CKCCJPDCCAN(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		LJEPJCDMDDG(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void MJJNJLGHCDE(string GEGDHHIDEEF)
	{
		ELPNKDIJJCM(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void GHFDMLHBKEB(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		robotVacNPC.animator.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void DLDKHBAIAOI(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		MMOLBLAGMEG(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void IOEHPFIMLFP(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void OPGLNCADEKK(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void MDBCCKCKHAH(string GEGDHHIDEEF)
	{
		SendSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void HCGGOKCINIF(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		CGEJIDHOCIE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void CBCPEJOBIKM(string GEGDHHIDEEF)
	{
		HBFNPOIBCHG(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void NEDLADAHOCN(Vector2 CDHGIJJHPJB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)robotVacNPC).transform.position);
		}
		GCPMDBAMKIK = 167f;
	}

	public void IPFNGBHGBMA(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void SendSetBool(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void PICAHIAEEFD()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void KKPKJKHHIPN(string GEGDHHIDEEF)
	{
		NOBBLCEPAOA(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void KAKIEDMEFGE(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		robotVacNPC.animator.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void HOGAODHKMIO(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		LKJCLCLHGLI(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void NPOFHMGPGCM(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void KOPHAGOLKEP(string GEGDHHIDEEF)
	{
		OPGLNCADEKK(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void IKKBJCNHLMM(string GEGDHHIDEEF)
	{
		JMGFBMEEOLA(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void MoveBroomToNextPosition(Vector2 CDHGIJJHPJB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)robotVacNPC).transform.position);
		}
		GCPMDBAMKIK = 0f;
	}

	public void NNLCDBINADN(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		GHFDMLHBKEB(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void MNNBHLLPALH(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		FGKBNJLJJLH(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void ANNHIPOCGPB(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void LBBCANANBGI(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		ADEOIABFFNG(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void JKDFBNBAFDD()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void NJACLLDHJBO(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void IJEJLIDBNEK(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void GLJKBIPDJGJ(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void JMIIPHHBNJI(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void HGMBJPGJBKE()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void ReceiveSetBool(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		robotVacNPC.animator.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void GJHMBJIDFBO(bool IHLGDCAIPLN)
	{
		OnlineObjectsManager.instance.GHHKOOABOKA(uniqueId, IHLGDCAIPLN);
	}

	public void DBLLDCGCFPD(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		LJEPJCDMDDG(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void NEFCFLEOEGD(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void FAMNCCECGMK(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		robotVacNPC.animator.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void FEPMOJCBOLP(string GEGDHHIDEEF)
	{
		NJACLLDHJBO(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void CLKCILAAFEO()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void ADEOIABFFNG(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void LKJCLCLHGLI(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		robotVacNPC.animator.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void GEPLGAFHBGE(int GJKKNOKIKBJ)
	{
		robotVacNPC.animator.SetTrigger(GJKKNOKIKBJ);
	}

	public void MGBDMEFOFFP(string GEGDHHIDEEF)
	{
		BLINEGACJLF(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void OEFMBGFPCFE(string GEGDHHIDEEF)
	{
		JMGFBMEEOLA(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void ANPAJIMCIPE(int GJKKNOKIKBJ)
	{
		robotVacNPC.animator.SetTrigger(GJKKNOKIKBJ);
	}

	public void SendSetPickupable(bool IHLGDCAIPLN)
	{
		OnlineObjectsManager.instance.SendSetPickupable(uniqueId, IHLGDCAIPLN);
	}

	public void MGHAPPKGFCE(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		KEJBGPOLHOA(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void SendSetBool(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void HODFFHKCJPN(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void OJONOIOEPME()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void CDMKNLPIHBN(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void GJJFAGOMMBM(bool IHLGDCAIPLN)
	{
		OnlineObjectsManager.instance.SendSetPickupable(uniqueId, IHLGDCAIPLN);
	}

	public void PCMKEEMBHBJ(Vector2 CDHGIJJHPJB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)robotVacNPC).transform.position);
		}
		GCPMDBAMKIK = 1613f;
	}

	public void BLOEANHKHEG(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void ReceiveSetBool(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		ReceiveSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void JFGPJBPFLFO(string GEGDHHIDEEF)
	{
		ELPNKDIJJCM(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void CDMMJPMBPAD()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void JEAMGOCHILB(string GEGDHHIDEEF)
	{
		APGKMHDMIKF(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void FLGEBNHPJFF(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		PNDCFPFJIOE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void PKLCCABKIOD(string GEGDHHIDEEF)
	{
		ANPAJIMCIPE(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void NHGHDIKPFDD()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void KFMKDHDFOEE(int GJKKNOKIKBJ)
	{
		robotVacNPC.animator.SetTrigger(GJKKNOKIKBJ);
	}

	public void MFEBPDBBDDJ(Vector2 CDHGIJJHPJB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)robotVacNPC).transform.position);
		}
		GCPMDBAMKIK = 1514f;
	}

	public void ICMOLLPEIDD(string GEGDHHIDEEF)
	{
		OPGLNCADEKK(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void OMKEKOJIFJM()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void AENDEDGKAKC(Vector2 CDHGIJJHPJB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)robotVacNPC).transform.position);
		}
		GCPMDBAMKIK = 927f;
	}

	public void DAPBHHBBLBK(string GEGDHHIDEEF)
	{
		JMGFBMEEOLA(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void JGMCPIMEFGG()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void FKCGENDKHGK(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void SetPickupable(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void MECKGICJMPP(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void SendSetTrigger(string GEGDHHIDEEF)
	{
		SendSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void EHLFPPLJKCL(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		MMOLBLAGMEG(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	protected override void Update()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		if (!OnlineManager.MasterOrOffline() && GCPMDBAMKIK < AFMFHCAHEFO)
		{
			GCPMDBAMKIK += Time.deltaTime;
			DCGBADKLANM = GCPMDBAMKIK / AFMFHCAHEFO;
			((Component)robotVacNPC).transform.position = Utils.EKCCGNEDPNO(Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM)), 1);
		}
	}

	public void SendSetTrigger(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void EGFGIPGNKEP(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		OMOGMANABDM(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void CFOJKNMLAJH(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void KKCMOGKALDH()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void CDJGKENFKPN(bool IHLGDCAIPLN)
	{
		OnlineObjectsManager.instance.GHHKOOABOKA(uniqueId, IHLGDCAIPLN);
	}

	public void ELPNKDIJJCM(int GJKKNOKIKBJ)
	{
		robotVacNPC.animator.SetTrigger(GJKKNOKIKBJ);
	}

	public void DFMNKGFGMNN(bool IHLGDCAIPLN)
	{
		OnlineObjectsManager.instance.GHHKOOABOKA(uniqueId, IHLGDCAIPLN);
	}

	public void APGKMHDMIKF(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void HLPGMOAHOIH(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void CBIEFMKEKBK(string GEGDHHIDEEF)
	{
		NOBBLCEPAOA(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void MMOLBLAGMEG(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void OAMDOOJLHKG()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void IIJKNHJMJPH(bool IHLGDCAIPLN)
	{
		OnlineObjectsManager.instance.SendSetPickupable(uniqueId, IHLGDCAIPLN);
	}

	public void FAPAPOIEIGL(Vector2 CDHGIJJHPJB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)robotVacNPC).transform.position);
		}
		GCPMDBAMKIK = 1874f;
	}

	public void KILHGNNMKBI(bool IHLGDCAIPLN)
	{
		OnlineObjectsManager.instance.GHHKOOABOKA(uniqueId, IHLGDCAIPLN);
	}

	public void GJGCODOAFEB(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		BLNFGDFAPHE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void ENGENAGEBEA(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		KAKIEDMEFGE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void HIIFIDDOAIL()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void LAKMPOHJELN()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.AddMagicBroomMovement(uniqueId, Vector2.op_Implicit(((Component)robotVacNPC).transform.position));
	}

	public void BPNKMBOJCNN(Vector2 CDHGIJJHPJB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)robotVacNPC).transform.position);
		}
		GCPMDBAMKIK = 1060f;
	}

	public void HDBDHLEFPFG(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void KJGGDKELOLA(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		LKJCLCLHGLI(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void NDHMCPOHGON(bool IHLGDCAIPLN)
	{
		placeable.pickUpable = IHLGDCAIPLN;
	}

	public void ONBOGKENMMD(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		FAMNCCECGMK(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void JEFFPCKNLDG(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		BLNFGDFAPHE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void JBOKJJEGGHO(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		FGKBNJLJJLH(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void NMLJLOEAJPN(bool IHLGDCAIPLN)
	{
		OnlineObjectsManager.instance.GHHKOOABOKA(uniqueId, IHLGDCAIPLN);
	}

	public void ReceiveSetTrigger(int GJKKNOKIKBJ)
	{
		robotVacNPC.animator.SetTrigger(GJKKNOKIKBJ);
	}
}
