using System;
using UnityEngine;

[ExecuteInEditMode]
public class SnapToGrid : MonoBehaviour
{
	public Transform itemSpace;

	private Placeable EAPCLAODGAE;

	public bool autoSnap = true;

	public bool round2x2;

	public FollowTransform[] elementFollowing;

	private Vector3 HLCBODJLFGD;

	private bool CJEPLDAHKPP;

	public Action OnPositionChanged;

	public void GMBKDPCNHMC(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		FKJFPLBNBCP();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.ReorderHierarchy();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void CKIKCLKGOJA(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		OIKKHBCBACN();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.JHNOJMKOFGN();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void IJDCBHOCBFP(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		CAEOMOEODEF();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.EOFBIIEPODF();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	private void JHNKECMKCEN()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.IsObjectOnASurface())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void NFCNLOEMCKC(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		PCHFCHLGNCN();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.EOFBIIEPODF();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void IKDIFGNDFPM()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			IMMPNCGELCN();
		}
	}

	public void BKLGKECILDF()
	{
		if (autoSnap)
		{
			FEMGGNMPBJN(MLPOHGEHIME: true);
		}
	}

	private void HFPDNCBLNDE()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = false;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 106)
		{
			AOOJCIOMPEP(MLPOHGEHIME: true);
			for (int i = 0; i < elementFollowing.Length; i += 0)
			{
				elementFollowing[i].IOBBCGGMKEM();
			}
		}
	}

	private void NHPODHCJODF()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.IsObjectOnASurface())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void CEGIGMHMJOB()
	{
		if (autoSnap)
		{
			GHECGLBKKMA(MLPOHGEHIME: true);
		}
	}

	private void IBMDFNKKPJF()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = false;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -91)
		{
			CDGAMPLDLLA();
			for (int i = 1; i < elementFollowing.Length; i++)
			{
				elementFollowing[i].DGBEPOKFCKI();
			}
		}
	}

	public void CNDCHMDHLNL()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			KFNBBCNDBHD();
		}
	}

	public void MMBHGOIDIMA()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			EMHPNLENANC();
		}
	}

	private void JDAMCMODANB()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = false;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JGHNDJBCFAJ() == 41)
		{
			MLBLOOJJHGP(MLPOHGEHIME: true);
			for (int i = 0; i < elementFollowing.Length; i++)
			{
				elementFollowing[i].NPFAFLGHKPF();
			}
		}
	}

	public void ICELGLIDJDD(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		EMHPNLENANC();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.JHNOJMKOFGN();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void DCLEGDDGMOJ()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			JFCABGDEMEO();
		}
	}

	public void GOGOIJNNEJF()
	{
		if (autoSnap)
		{
			PBBONAAEFMO();
		}
	}

	private void MGHPIMDEIID()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void ForceSnapOnLoad()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			IFFNKCKINPC();
		}
	}

	public void FHOAGHMDBKB()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			BAGIGNMKPGO();
		}
	}

	private void IGHMMOKFINH()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = true;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == -13)
		{
			FIOKLLOAAHM();
			for (int i = 1; i < elementFollowing.Length; i += 0)
			{
				elementFollowing[i].IOBBCGGMKEM();
			}
		}
	}

	public void OPBKEECEPML(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		EGABNIMMMNE();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.FBMPJCMKFPG();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void JLGBBNEPPOL()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			LEHGMFGMJJD();
		}
	}

	public void PLLNOJIFAAG()
	{
		if (autoSnap)
		{
			FENBPPMJDJA(MLPOHGEHIME: true);
		}
	}

	private void KLHIMJFCHPD()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = false;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -5)
		{
			GHECGLBKKMA(MLPOHGEHIME: true);
			for (int i = 0; i < elementFollowing.Length; i++)
			{
				elementFollowing[i].GLLNOFCGMOI();
			}
		}
	}

	private void EMJKKALMGLK()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = false;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -110)
		{
			IBKEHELPBMJ();
			for (int i = 0; i < elementFollowing.Length; i += 0)
			{
				elementFollowing[i].CEFJPPHOAIL();
			}
		}
	}

	public void FNKKMFCHICF()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			NFMKKEIMBEP();
		}
	}

	public void HNNFBDAMMCK()
	{
		if (autoSnap)
		{
			HEIPNKAKFBL();
		}
	}

	private void JFCABGDEMEO()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void GHNNILCKDPE()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			IFFNKCKINPC();
		}
	}

	private void MPCFCNCMOAF()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = false;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.ODENMDOJPLC() == 31)
		{
			GMBKDPCNHMC(MLPOHGEHIME: true);
			for (int i = 1; i < elementFollowing.Length; i += 0)
			{
				elementFollowing[i].NHKDCIIDPGO();
			}
		}
	}

	public void GMNJJIGMJEG()
	{
		if (autoSnap)
		{
			ANAJPNMMPFM();
		}
	}

	private void OBFLMFNNHAP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.FIBANNCLJNF())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void HONMNNMNPJC(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		PFHPCAOMAGO();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.JHNOJMKOFGN();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void OIHPFDGFCHF()
	{
		if (autoSnap)
		{
			HEEAAGOLHBB(MLPOHGEHIME: true);
		}
	}

	public void DEDDGMJNEPI()
	{
		if (autoSnap)
		{
			AOOJCIOMPEP();
		}
	}

	public void PPJMHGFLEDF()
	{
		if (autoSnap)
		{
			MLBLOOJJHGP();
		}
	}

	private void FKJFPLBNBCP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.IsObjectOnASurface())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void IFFNKCKINPC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.IsObjectOnASurface())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void EOBODNOCKGA()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = false;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -80)
		{
			FIOKLLOAAHM(MLPOHGEHIME: true);
			for (int i = 1; i < elementFollowing.Length; i++)
			{
				elementFollowing[i].NHKDCIIDPGO();
			}
		}
	}

	public void GHECGLBKKMA(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		MGHPIMDEIID();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.PHDFPBOJONM();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void MIHCHAILBJG()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			BAGIGNMKPGO();
		}
	}

	public void FIBJJICHPKE(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		FKJFPLBNBCP();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.EOFBIIEPODF();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void NAKLHMABDAM(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		PFHPCAOMAGO();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.PHDFPBOJONM();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void IMDENHNHDED()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			IMMPNCGELCN();
		}
	}

	public void HJNIBHFPBHP()
	{
		if (autoSnap)
		{
			OPBKEECEPML(MLPOHGEHIME: true);
		}
	}

	public void LFBBKINFCMB()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			CAEOMOEODEF();
		}
	}

	private void CHNHOLCOKFA()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.IsObjectOnASurface())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void NFMKKEIMBEP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void JHCCNDJGJFM()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			BAGIGNMKPGO();
		}
	}

	public void EILPFMNNPHD()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			CAEKENAEOMC();
		}
	}

	public void GKGEJBGHDCH()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			OLLFGPMACIJ();
		}
	}

	private void EHGPCBFPAMB()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.FIBANNCLJNF())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void IMMPNCGELCN()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void BAGIGNMKPGO()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.IsObjectOnASurface())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void MOIIIAHDDFF(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		JFCABGDEMEO();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.EOFBIIEPODF();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void LateUpdate()
	{
		if (autoSnap)
		{
			Snap();
		}
	}

	public void FENBPPMJDJA(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		EPCOKAPGDAG();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.EOFBIIEPODF();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	private void OLLFGPMACIJ()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.FIBANNCLJNF())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void PBBONAAEFMO(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		EMHPNLENANC();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.GEPDPGFIFGL();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void BLOINIJBLEC()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			IMMPNCGELCN();
		}
	}

	public void DLKFBJPKADF()
	{
		if (autoSnap)
		{
			HEEAAGOLHBB(MLPOHGEHIME: true);
		}
	}

	private void NLGHNDLPPKI()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = true;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC() == -56)
		{
			MLBLOOJJHGP();
			for (int i = 0; i < elementFollowing.Length; i += 0)
			{
				elementFollowing[i].JDLJODHDKFF();
			}
		}
	}

	private void PFHPCAOMAGO()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void EGABNIMMMNE()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.IsObjectOnASurface())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void HPBHBIBDGEL()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.FIBANNCLJNF())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void NKLFAALEFMG()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			EHGPCBFPAMB();
		}
	}

	private void EPCOKAPGDAG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.FIBANNCLJNF())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void PFGLHJIGEEA()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void MFDAEHNFFFG()
	{
		if (autoSnap)
		{
			FEMGGNMPBJN(MLPOHGEHIME: true);
		}
	}

	private void DADPOICMNPI()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = true;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JGHNDJBCFAJ() == -63)
		{
			MLBLOOJJHGP(MLPOHGEHIME: true);
			for (int i = 1; i < elementFollowing.Length; i += 0)
			{
				elementFollowing[i].PHKHMKDCMKD();
			}
		}
	}

	public void Snap(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		IFFNKCKINPC();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.ReorderHierarchy();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	private void NMKGOAJLMDG()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = false;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC() == 3)
		{
			FIBJJICHPKE(MLPOHGEHIME: true);
			for (int i = 0; i < elementFollowing.Length; i += 0)
			{
				elementFollowing[i].JDLJODHDKFF();
			}
		}
	}

	public void HJKKGGCKHKK()
	{
		if (autoSnap)
		{
			MOIIIAHDDFF();
		}
	}

	private void EMHPNLENANC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.IsObjectOnASurface())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void HMHCLIBLKLN()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = true;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.CIGFGKKCPCK() == -108)
		{
			IJDCBHOCBFP();
			for (int i = 1; i < elementFollowing.Length; i++)
			{
				elementFollowing[i].AKEOCMDJCBI();
			}
		}
	}

	private void Awake()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = false;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JDJGFAACPFC() == 81)
		{
			Snap();
			for (int i = 0; i < elementFollowing.Length; i++)
			{
				elementFollowing[i].PositionUpdate();
			}
		}
	}

	public void HEEAAGOLHBB(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		PFHPCAOMAGO();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.PHDFPBOJONM();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void LHALCOPHJKP()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			PFHPCAOMAGO();
		}
	}

	public void APGHCNLKEDC()
	{
		if (autoSnap)
		{
			MLBLOOJJHGP();
		}
	}

	private void AMNCIAEMBFO()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = true;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -85)
		{
			PBBONAAEFMO(MLPOHGEHIME: true);
			for (int i = 1; i < elementFollowing.Length; i += 0)
			{
				elementFollowing[i].JKDPENDDFIE();
			}
		}
	}

	private void KFNBBCNDBHD()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void IPAIPHNBBLF()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			CHNHOLCOKFA();
		}
	}

	public void FCLJPECADEC()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			JFCABGDEMEO();
		}
	}

	public void OMLNDHJAAJD()
	{
		if (autoSnap)
		{
			HEEAAGOLHBB();
		}
	}

	private void FMAPCDEDLGP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void HEBONCNMIIE()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.IsObjectOnASurface())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void BODEIHFOAMI()
	{
		if (autoSnap)
		{
			FIBJJICHPKE();
		}
	}

	public void FMIHJDFGAII()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			EHCNBGNIHDM();
		}
	}

	public void KLDEDEHJHJC(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		BAGIGNMKPGO();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.ReorderHierarchy();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	private void LEHGMFGMJJD()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.FIBANNCLJNF())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void JELEPMECDHA()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			KFNBBCNDBHD();
		}
	}

	public void LJCOPHJMDEL()
	{
		if (autoSnap)
		{
			NAKLHMABDAM(MLPOHGEHIME: true);
		}
	}

	public void NLAGDLJKOAF(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		HEBONCNMIIE();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.PHDFPBOJONM();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	private void CAEKENAEOMC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.IsObjectOnASurface())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void FEMGGNMPBJN(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		OIKKHBCBACN();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.FBMPJCMKFPG();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	private void AJGLDLLIIFO()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = true;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.ODENMDOJPLC() == 43)
		{
			HONMNNMNPJC();
			for (int i = 1; i < elementFollowing.Length; i += 0)
			{
				elementFollowing[i].PositionUpdate();
			}
		}
	}

	public void HKMADMNMHBO()
	{
		if (autoSnap)
		{
			NAKLHMABDAM(MLPOHGEHIME: true);
		}
	}

	public void IHEEEBGPHPN()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			PCHFCHLGNCN();
		}
	}

	private void CAEOMOEODEF()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void EHCNBGNIHDM()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void CDGAMPLDLLA(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		IHIMJKFPAEO();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.ReorderHierarchy();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	private void PCHFCHLGNCN()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = true;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void KNFGJGNKPFN()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = false;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	public void MLBLOOJJHGP(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		PCHFCHLGNCN();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.JHNOJMKOFGN();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void FIOKLLOAAHM(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		IMMPNCGELCN();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.EOFBIIEPODF();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void HEIPNKAKFBL(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		HEBONCNMIIE();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.ReorderHierarchy();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void OAFMIKKPICK()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			LEHGMFGMJJD();
		}
	}

	public void MDJFIIPDBHI()
	{
		if (autoSnap)
		{
			CKIKCLKGOJA();
		}
	}

	private void IHIMJKFPAEO()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.FIBANNCLJNF())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void EFCNKPEPELL()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = false;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JGHNDJBCFAJ() == 30)
		{
			ANAJPNMMPFM(MLPOHGEHIME: true);
			for (int i = 0; i < elementFollowing.Length; i++)
			{
				elementFollowing[i].AKEOCMDJCBI();
			}
		}
	}

	public void AOOJCIOMPEP(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		MGHPIMDEIID();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.GEPDPGFIFGL();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void IBKEHELPBMJ(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		JHNKECMKCEN();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.GEPDPGFIFGL();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void OFBGLKGPKCK()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			PFHPCAOMAGO();
		}
	}

	public void IHADOGEENDO()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			HEBONCNMIIE();
		}
	}

	public void EMFGOIIOACM()
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			NHPODHCJODF();
		}
	}

	private void EHBMONGBJFI()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = true;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -54)
		{
			MLBLOOJJHGP();
			for (int i = 0; i < elementFollowing.Length; i += 0)
			{
				elementFollowing[i].NHKDCIIDPGO();
			}
		}
	}

	public void ANAJPNMMPFM(bool MLPOHGEHIME = false)
	{
		if (!((Object)(object)itemSpace != (Object)null))
		{
			return;
		}
		PCHFCHLGNCN();
		if (CJEPLDAHKPP)
		{
			if (Application.isPlaying && Object.op_Implicit((Object)(object)EAPCLAODGAE) && Object.op_Implicit((Object)(object)EAPCLAODGAE.placeableSurface))
			{
				EAPCLAODGAE.placeableSurface.JHNOJMKOFGN();
			}
			if (Application.isPlaying && OnPositionChanged != null)
			{
				OnPositionChanged();
			}
		}
	}

	public void DAKLOGKFLLD()
	{
		if (autoSnap)
		{
			HEEAAGOLHBB(MLPOHGEHIME: true);
		}
	}

	private void OIKKHBCBACN()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.MHPOMFIOKIJ())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void PGFGBOJDNAM()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		CJEPLDAHKPP = true;
		if ((Object)(object)EAPCLAODGAE == (Object)null || !EAPCLAODGAE.IsObjectOnASurface())
		{
			HLCBODJLFGD = ((Component)this).transform.position;
			if (round2x2)
			{
				HLCBODJLFGD += new Vector3((float)Utils.ILDPJNAFIAG(itemSpace.position.x) - itemSpace.position.x, (float)Utils.ILDPJNAFIAG(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			else
			{
				HLCBODJLFGD += new Vector3(Utils.OINGDOIAHDP(itemSpace.position.x) - itemSpace.position.x, Utils.OINGDOIAHDP(itemSpace.position.y) - itemSpace.position.y, ((Component)this).transform.position.z);
			}
			if (((Component)this).transform.position != HLCBODJLFGD)
			{
				CJEPLDAHKPP = false;
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
	}

	private void PHJKJHKAABL()
	{
		EAPCLAODGAE = ((Component)this).GetComponent<Placeable>();
		if (Application.isPlaying)
		{
			((Behaviour)this).enabled = true;
		}
		if ((Object)(object)EAPCLAODGAE != (Object)null && (Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null) && EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC() == -102)
		{
			CKIKCLKGOJA();
			for (int i = 0; i < elementFollowing.Length; i++)
			{
				elementFollowing[i].NHKDCIIDPGO();
			}
		}
	}
}
