using System;
using UnityEngine;

public class LucenWalkTo : LucenStateBase
{
	private void OKOKOMPNFDF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.PKIBNCNNDJJ(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void GBLGELBAPOJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.PKIBNCNNDJJ(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void GMFONHHLBIO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.EJAMGJMEAEM(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void KNIBOAEFGPJ()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)8)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Up;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.CAONJPIPLBJ(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void GJMOKBGIBEP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.EJAMGJMEAEM(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void MMPGIKGMFMA()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)7)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)7;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.CAONJPIPLBJ(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void KNNALICIDEN()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)6)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Up;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.LPGGLIGOLKD(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void GONBDDJHANF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.BLDPKJOMJOK(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	public void BKNBKDKIDNJ()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Diagonal)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Right;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.CAONJPIPLBJ(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void JLBMCMCCDNN()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Down)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Diagonal;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.CAONJPIPLBJ(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void EIOKFNLDEEB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.DMIHGCBJBKG(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void IJKIFECCGEP()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)7)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)8;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.ChangeState(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void EIAMODMOLIL()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)7)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)7;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.LNBALFOONDE(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void DJNOFCBINHM()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Down)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)8;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.CAONJPIPLBJ(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void PDLDELGPHMG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.IFJKPCMEBLI(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void FOBPMBDMGBL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.DMIHGCBJBKG(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void JOGNFMGIJMD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.PKIBNCNNDJJ(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void MDILLGFCCMI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.BLDPKJOMJOK(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void CAHIIFMAAEA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.IFJKPCMEBLI(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void AGLDNOHPHFD()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != 0)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Up;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.NDBNGDOAGAM(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void EJPFGEHOKPK()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)5)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Up;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.NDBNGDOAGAM(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void IIEGDHJEEKC()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)7)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)7;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.KDEKLDPKEFE(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void BEEDFJOOPAH()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Down)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Diagonal;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.CNHIBHEIAMJ(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void ALDAHNKKOGE()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)5)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Down;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.PHLANJBCIKC(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void BOOBKGLCDFK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.IFJKPCMEBLI(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		base.FixedUpdateState(GDHCBGCIIKG);
		if (lucenNPC.targetWalkTo != Vector2.zero)
		{
			lucenNPC.walkTo.IIMEFNIECLI();
		}
	}

	public void AAPBBHOHMIJ()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)8)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)6;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.NDBNGDOAGAM(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void PBMBOPDALGD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.EJAMGJMEAEM(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void LPMIHGICGNK()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)7)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)7;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.ChangeState(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void JAHKKNGPCJO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.Walk(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void BBHODALHMAD()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)7)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Diagonal;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.OFHJIANLOEO(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		base.EnterState(GDHCBGCIIKG);
		lucenNPC.walkTo.FNNPPBDFBCI(lucenNPC.targetWalkTo);
		lucenNPC.walkTo.speed = lucenNPC.speed;
		NPCWalkTo walkTo = lucenNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo walkTo2 = lucenNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		lucenNPC.walkTo.PEHELKCIECB();
	}

	public void HMLFDDDGGBO()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Diagonal)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)8;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.ChangeState(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void OFEMFGCBLBH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.MMAAOFHFPNP(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void AHNEAEKDBED()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.Walk(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void CMELEOKAEHO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.MMAAOFHFPNP(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void GANFLECJKBE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.PKIBNCNNDJJ(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void ACOJHBFFFIF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.Walk(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void AEOBJMKNACK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.MMAAOFHFPNP(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	public void EDDFAALFNGB()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Down)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)5;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.ChangeState(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void CAELADBMLFL()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != 0)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Left;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.CAONJPIPLBJ(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void MGCPPABFAGA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.Walk(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void KLDIIKJAKIB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.Walk(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void NHFGBBBCJNM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.PKIBNCNNDJJ(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	public void IKOIKCHBBNG()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)5)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Up;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.PHLANJBCIKC(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void IEJGDOPLBLB()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Down)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)7;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.NDBNGDOAGAM(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void KBCKFDDDEGE()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Left)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)5;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.LNBALFOONDE(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void OnActionComplete()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Diagonal)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Diagonal;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.ChangeState(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void OHDFLHEHING()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.BLDPKJOMJOK(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void FOMDNPODHLG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.DMIHGCBJBKG(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void KJMDNKCJFEF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.PKIBNCNNDJJ(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void GKAALFJNHFA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.EJAMGJMEAEM(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void IGOGKMLCLPI()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)8)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Up;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.EKBJHJLFODI(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void AHPFECCLOBB()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != 0)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)7;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.LNBALFOONDE(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void KNDLFHILBMA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.IFJKPCMEBLI(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void MDLHDGDLANK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.PKIBNCNNDJJ(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	public override int GetStateEnumID()
	{
		return 1;
	}

	public void CKGFIHKADBM()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)8)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)8;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.ChangeState(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void KPMCGMJJBEA()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Down)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Up;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.KDEKLDPKEFE(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void JMBOINMJEGI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.DMIHGCBJBKG(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void ENOEOGABPIC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.DMIHGCBJBKG(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void IPKFEPKJIJE()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != 0)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Up;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.EKBJHJLFODI(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void OKHDMEMEIEJ()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)8)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Right;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.NDBNGDOAGAM(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void HNFMJFJPDNN()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != 0)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)7;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.ChangeState(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void IJCLNLKKIAF()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Right)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Down;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.CAONJPIPLBJ(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void AHECKLFEFAB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.IFJKPCMEBLI(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void HILLNFIICFK()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Down)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Left;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.CNHIBHEIAMJ(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void GMCINBCEPJO()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)7)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)6;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.PHLANJBCIKC(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void HEEOHKBPMAI()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)8)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Down;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.KDEKLDPKEFE(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void IEPLNADMDJL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.EJAMGJMEAEM(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void HMCGBJCGGEF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.PKIBNCNNDJJ(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void FJNPFILECCM()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Right)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)6;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.LNBALFOONDE(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void GOPIJNFDCME()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Down)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Down;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.OFHJIANLOEO(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void EBBAPFKABDB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.BLDPKJOMJOK(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void KNJJKEAIDND()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.Walk(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void DHFOEHFPLNB()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)7)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)6;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.ChangeState(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void HKGKJCOKLLD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.IFJKPCMEBLI(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	public void MKJDIMFOGIA()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != (Direction)7)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)7;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.PHLANJBCIKC(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void GOEFOAKFDDD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.MMAAOFHFPNP(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void PPAINOJKAGI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.EJAMGJMEAEM(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void ABMMONFHFGF()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Diagonal)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Up;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.LNBALFOONDE(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void FIFEIDAMIIG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.IFJKPCMEBLI(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void ALBMMJPBAGA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.PKIBNCNNDJJ(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void NEEDNONKBAC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.PKIBNCNNDJJ(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}

	private void FLFPPMPBPCK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.IFJKPCMEBLI(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void AGLOLKAIAMG()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != Direction.Left)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Down;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.LPGGLIGOLKD(LucenState.Inactive);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void MIFEFJBGDEP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.DMIHGCBJBKG(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void HFLCAILNOHC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.BLDPKJOMJOK(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void FKBOPOMCLBF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.PKIBNCNNDJJ(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	public void KNGKEAPDNLP()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != 0)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = Direction.Up;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.LPGGLIGOLKD(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = true;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	public void EBLEAJFOEJL()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (lucenNPC.endDirection != 0)
		{
			lucenNPC.animationBase.SetDirection(lucenNPC.endDirection);
			lucenNPC.endDirection = (Direction)5;
		}
		if (lucenNPC.disableOnCompleteWalkTo)
		{
			lucenNPC.NDBNGDOAGAM(LucenState.WalkTo);
			lucenNPC.disableOnCompleteWalkTo = false;
		}
		lucenNPC.targetWalkTo = Vector2.zero;
		lucenNPC.WalkToCompleted();
	}

	private void NNFPNFNFCJJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.IFJKPCMEBLI(lucenNPC.targetWalkTo, lucenNPC.endDirection);
	}

	private void NAKLGHHDBAN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		lucenNPC.IFJKPCMEBLI(lucenNPC.targetWalkTo, lucenNPC.endDirection, KEEGDBAAEOG: true);
	}
}
