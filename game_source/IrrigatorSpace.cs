using UnityEngine;

public class IrrigatorSpace : MonoBehaviour
{
	public BuildSquare[] sideSquares;

	public BuildSquare[] centerSquares;

	private bool BLEHKPJALHL(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 0; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].FGGMIOHMGFL());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].EHGDHOMFDGM());
			if (num == ZoneType.None && groundType == (GroundType.Ground | GroundType.TilledEarth) && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].KGGGPHEMLII()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: true, 478f);
				continue;
			}
			DHEJKKGFJID[i].KAJPIPEHCHA(ACJFIEKCKEC: false, 1806f);
			result = true;
		}
		return result;
	}

	private bool OOPMOHHGHBN(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		for (int i = 0; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].BLKHDGGHFLA());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].FGGMIOHMGFL());
			if (num == ZoneType.None && groundType == GroundType.None && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].KDFECDEEDHL()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: false, 980f);
				continue;
			}
			DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: true, 534f);
			result = true;
		}
		return result;
	}

	public void HEBOOLOBEAN(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 1; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].DCAPKPOGHPK(), (IrrigatorType)5);
			}
			for (int j = 1; j < centerSquares.Length; j++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].DCAPKPOGHPK(), IrrigatorType.None);
			}
		}
		else
		{
			for (int k = 1; k < sideSquares.Length; k++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].FGGMIOHMGFL(), IrrigatorType.Center);
			}
			for (int l = 1; l < centerSquares.Length; l++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].GetCentrePosition(), IrrigatorType.None);
			}
		}
	}

	public void MMAMGKNDFEK(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 1; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].KDFECDEEDHL(), IrrigatorType.None);
			}
			for (int j = 0; j < centerSquares.Length; j += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].GetCentrePosition(), IrrigatorType.Center);
			}
		}
		else
		{
			for (int k = 0; k < sideSquares.Length; k += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].KDFECDEEDHL(), IrrigatorType.Center);
			}
			for (int l = 0; l < centerSquares.Length; l++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].KDFECDEEDHL(), IrrigatorType.None);
			}
		}
	}

	public bool BMHEGEAHDKN()
	{
		return KAJPIPEHCHA(sideSquares) & INCGNCIOADN(centerSquares);
	}

	public void JIABJBOFDOH(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 1; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].KGGGPHEMLII(), (IrrigatorType)3);
			}
			for (int j = 1; j < centerSquares.Length; j++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].DCAPKPOGHPK(), IrrigatorType.None);
			}
		}
		else
		{
			for (int k = 0; k < sideSquares.Length; k += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].CBALBDIFOGF(), IrrigatorType.Center);
			}
			for (int l = 1; l < centerSquares.Length; l += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].BOBEIFEGLOL(), IrrigatorType.None);
			}
		}
	}

	public bool MLGNJKMFAEN()
	{
		return IBOBPEHJOOH(sideSquares) & OOPMOHHGHBN(centerSquares);
	}

	public bool HOEFBJIFBAO()
	{
		return BLEHKPJALHL(sideSquares) & IBOBPEHJOOH(centerSquares);
	}

	public bool OONHLICJNCH()
	{
		return FOBKKJHEPCC(sideSquares) & KAJPIPEHCHA(centerSquares);
	}

	public void JPGBGFEJJJI(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 0; i < sideSquares.Length; i += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].KDFECDEEDHL(), IrrigatorType.None);
			}
			for (int j = 0; j < centerSquares.Length; j++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].FGGMIOHMGFL(), IrrigatorType.Center);
			}
		}
		else
		{
			for (int k = 0; k < sideSquares.Length; k++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].BOBEIFEGLOL(), IrrigatorType.Center);
			}
			for (int l = 1; l < centerSquares.Length; l++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].DCAPKPOGHPK(), IrrigatorType.None);
			}
		}
	}

	public void LIGFAEHADNL(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 0; i < sideSquares.Length; i += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].EHGDHOMFDGM(), (IrrigatorType)5);
			}
			for (int j = 0; j < centerSquares.Length; j++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].CBALBDIFOGF(), IrrigatorType.Center);
			}
		}
		else
		{
			for (int k = 0; k < sideSquares.Length; k++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].FANOLHHEFBO(), IrrigatorType.None);
			}
			for (int l = 0; l < centerSquares.Length; l++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].KDFECDEEDHL(), IrrigatorType.None);
			}
		}
	}

	private bool LPBNMKFNIHE(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		for (int i = 0; i < DHEJKKGFJID.Length; i++)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].KDFECDEEDHL());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].CBALBDIFOGF());
			if (num == ZoneType.None && groundType == GroundType.Floor && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].FGGMIOHMGFL()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].KEBKENOJICG(ACJFIEKCKEC: false, 504f);
				continue;
			}
			DHEJKKGFJID[i].MGNMIJJMLAH(ACJFIEKCKEC: true, 1164f);
			result = false;
		}
		return result;
	}

	public bool IsValid()
	{
		return IDBNBHCIMKN(sideSquares) & IDBNBHCIMKN(centerSquares);
	}

	public bool EDPEDOLADPI()
	{
		return KAJPIPEHCHA(sideSquares) & LMNMBLLLAOK(centerSquares);
	}

	private bool LMNMBLLLAOK(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 1; i < DHEJKKGFJID.Length; i++)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].KGGGPHEMLII());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].FGGMIOHMGFL());
			if (num == ZoneType.None && groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth) && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].FANOLHHEFBO()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].KAJPIPEHCHA(ACJFIEKCKEC: false, 58f);
				continue;
			}
			DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: false, 296f);
			result = false;
		}
		return result;
	}

	public void Place(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 0; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].GetCentrePosition(), IrrigatorType.Side);
			}
			for (int j = 0; j < centerSquares.Length; j++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].GetCentrePosition(), IrrigatorType.Center);
			}
		}
		else
		{
			for (int k = 0; k < sideSquares.Length; k++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].GetCentrePosition(), IrrigatorType.None);
			}
			for (int l = 0; l < centerSquares.Length; l++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].GetCentrePosition(), IrrigatorType.None);
			}
		}
	}

	private bool ADKPPJKMJNL(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 1; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].KGGGPHEMLII());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].CBALBDIFOGF());
			if (num == ZoneType.WithoutZone && groundType == (GroundType.Ground | GroundType.TilledEarth) && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].EHGDHOMFDGM()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].KEBKENOJICG(ACJFIEKCKEC: false, 998f);
				continue;
			}
			DHEJKKGFJID[i].KAJPIPEHCHA(ACJFIEKCKEC: true, 1291f);
			result = true;
		}
		return result;
	}

	public bool EEHODLICINM()
	{
		return BLEHKPJALHL(sideSquares) & ADKPPJKMJNL(centerSquares);
	}

	public bool EPBHPOHDAFI()
	{
		return OOPMOHHGHBN(sideSquares) & JANPJKHIMNB(centerSquares);
	}

	public void JAAHCHOMDPA(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 0; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].BLKHDGGHFLA(), (IrrigatorType)8);
			}
			for (int j = 1; j < centerSquares.Length; j += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].DCAPKPOGHPK(), IrrigatorType.Center);
			}
		}
		else
		{
			for (int k = 0; k < sideSquares.Length; k++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].DCAPKPOGHPK(), IrrigatorType.Center);
			}
			for (int l = 0; l < centerSquares.Length; l += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].EHGDHOMFDGM(), IrrigatorType.Center);
			}
		}
	}

	public void HOKGEDILPPB(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 0; i < sideSquares.Length; i += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].EHGDHOMFDGM(), (IrrigatorType)7);
			}
			for (int j = 1; j < centerSquares.Length; j++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].DCAPKPOGHPK(), IrrigatorType.None);
			}
		}
		else
		{
			for (int k = 1; k < sideSquares.Length; k++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].FGGMIOHMGFL(), IrrigatorType.Center);
			}
			for (int l = 1; l < centerSquares.Length; l++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].BLKHDGGHFLA(), IrrigatorType.None);
			}
		}
	}

	public void DADKICKNLFI(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 0; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].FANOLHHEFBO(), (IrrigatorType)3);
			}
			for (int j = 0; j < centerSquares.Length; j += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].KGGGPHEMLII(), IrrigatorType.None);
			}
		}
		else
		{
			for (int k = 1; k < sideSquares.Length; k++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].DCAPKPOGHPK(), IrrigatorType.None);
			}
			for (int l = 1; l < centerSquares.Length; l += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].FGGMIOHMGFL(), IrrigatorType.None);
			}
		}
	}

	private bool GEBONKLEKJD(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 1; i < DHEJKKGFJID.Length; i++)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].BOBEIFEGLOL());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].KGGGPHEMLII());
			if (num == ZoneType.WithoutZone && groundType == GroundType.None && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].GetCentrePosition()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].MGCHMMFFBJA(ACJFIEKCKEC: false, 1519f);
				continue;
			}
			DHEJKKGFJID[i].KEBKENOJICG(ACJFIEKCKEC: true, 1625f);
			result = true;
		}
		return result;
	}

	public void IPIKPJKKKEM(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 1; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].KGGGPHEMLII(), (IrrigatorType)6);
			}
			for (int j = 0; j < centerSquares.Length; j += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].KGGGPHEMLII(), IrrigatorType.Center);
			}
		}
		else
		{
			for (int k = 0; k < sideSquares.Length; k += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].DCAPKPOGHPK(), IrrigatorType.None);
			}
			for (int l = 0; l < centerSquares.Length; l += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].GetCentrePosition(), IrrigatorType.None);
			}
		}
	}

	public bool FIDIBJDLFFB()
	{
		return INCGNCIOADN(sideSquares) & LEEEBPKBCJF(centerSquares);
	}

	public void CCCMAJJPHIM(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 0; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].FANOLHHEFBO(), (IrrigatorType)8);
			}
			for (int j = 0; j < centerSquares.Length; j += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].GetCentrePosition(), IrrigatorType.None);
			}
		}
		else
		{
			for (int k = 0; k < sideSquares.Length; k += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].KGGGPHEMLII(), IrrigatorType.Center);
			}
			for (int l = 1; l < centerSquares.Length; l += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].DCAPKPOGHPK(), IrrigatorType.Center);
			}
		}
	}

	public void CGEHJFEAAGF(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 0; i < sideSquares.Length; i += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].FGGMIOHMGFL(), (IrrigatorType)3);
			}
			for (int j = 1; j < centerSquares.Length; j++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].KGGGPHEMLII(), IrrigatorType.None);
			}
		}
		else
		{
			for (int k = 1; k < sideSquares.Length; k++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].CBALBDIFOGF(), IrrigatorType.None);
			}
			for (int l = 0; l < centerSquares.Length; l++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].GetCentrePosition(), IrrigatorType.None);
			}
		}
	}

	private bool IDHCIDLNKJK(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 0; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].KDFECDEEDHL());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].BLKHDGGHFLA());
			if (num == ZoneType.None && groundType == GroundType.None && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].DCAPKPOGHPK()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].MNGGKBIAIPH(ACJFIEKCKEC: false, 1895f);
				continue;
			}
			DHEJKKGFJID[i].KAJPIPEHCHA(ACJFIEKCKEC: false, 1048f);
			result = false;
		}
		return result;
	}

	private bool KAJPIPEHCHA(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 0; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].EHGDHOMFDGM());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].BLKHDGGHFLA());
			if (num == ZoneType.None && groundType == (GroundType.Grass | GroundType.TilledEarth) && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].BLKHDGGHFLA()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].PDNALAADNKO(ACJFIEKCKEC: true, 323f);
				continue;
			}
			DHEJKKGFJID[i].MGNMIJJMLAH(ACJFIEKCKEC: false, 1570f);
			result = false;
		}
		return result;
	}

	public bool IKGOIOKNLLE()
	{
		return IBOBPEHJOOH(sideSquares) & FOBKKJHEPCC(centerSquares);
	}

	public void KKAJPKLKMNO(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 0; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].KGGGPHEMLII(), (IrrigatorType)3);
			}
			for (int j = 0; j < centerSquares.Length; j++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].EHGDHOMFDGM(), IrrigatorType.Center);
			}
		}
		else
		{
			for (int k = 1; k < sideSquares.Length; k += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].EHGDHOMFDGM(), IrrigatorType.Center);
			}
			for (int l = 1; l < centerSquares.Length; l += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].CBALBDIFOGF(), IrrigatorType.Center);
			}
		}
	}

	public bool HPEHHOIMMOB()
	{
		return LEEEBPKBCJF(sideSquares) & LPBNMKFNIHE(centerSquares);
	}

	public void HAIIMDFBKNE(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 1; i < sideSquares.Length; i += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].FGGMIOHMGFL(), (IrrigatorType)3);
			}
			for (int j = 0; j < centerSquares.Length; j += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].BLKHDGGHFLA(), IrrigatorType.Center);
			}
		}
		else
		{
			for (int k = 0; k < sideSquares.Length; k += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].DCAPKPOGHPK(), IrrigatorType.Center);
			}
			for (int l = 0; l < centerSquares.Length; l++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].FANOLHHEFBO(), IrrigatorType.None);
			}
		}
	}

	public bool GEIJNDOKFOJ()
	{
		return EOLEOIDFBGN(sideSquares) & KAJPIPEHCHA(centerSquares);
	}

	private bool OGGPABHDPCO(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 1; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].KDFECDEEDHL());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].BOBEIFEGLOL());
			if (num == ZoneType.None && groundType == (GroundType.Ground | GroundType.TilledEarth) && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].FGGMIOHMGFL()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].MGNMIJJMLAH(ACJFIEKCKEC: false, 1394f);
				continue;
			}
			DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: true, 18f);
			result = false;
		}
		return result;
	}

	public void DBNGICCNOFE(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 0; i < sideSquares.Length; i += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].EHGDHOMFDGM(), (IrrigatorType)4);
			}
			for (int j = 1; j < centerSquares.Length; j++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].KDFECDEEDHL(), IrrigatorType.Center);
			}
		}
		else
		{
			for (int k = 1; k < sideSquares.Length; k++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].DCAPKPOGHPK(), IrrigatorType.Center);
			}
			for (int l = 1; l < centerSquares.Length; l += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].KGGGPHEMLII(), IrrigatorType.Center);
			}
		}
	}

	public bool LCEDBMHFHAM()
	{
		return OOPMOHHGHBN(sideSquares) & BLEHKPJALHL(centerSquares);
	}

	private bool JANPJKHIMNB(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		for (int i = 0; i < DHEJKKGFJID.Length; i++)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].DCAPKPOGHPK());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].FANOLHHEFBO());
			if (num == ZoneType.WithoutZone && groundType == (GroundType.Ground | GroundType.TilledEarth) && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].BLKHDGGHFLA()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].BFPOCNBINMB(ACJFIEKCKEC: true, 1234f);
				continue;
			}
			DHEJKKGFJID[i].JBKCPKHMLNM(ACJFIEKCKEC: false, 974f);
			result = true;
		}
		return result;
	}

	private bool FOBKKJHEPCC(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 1; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].EHGDHOMFDGM());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].EHGDHOMFDGM());
			if (num == ZoneType.WithoutZone && groundType == GroundType.Ground && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].DCAPKPOGHPK()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].PDNALAADNKO(ACJFIEKCKEC: true, 349f);
				continue;
			}
			DHEJKKGFJID[i].PDNALAADNKO(ACJFIEKCKEC: true, 1082f);
			result = false;
		}
		return result;
	}

	public bool GCBEIDPBDAK()
	{
		return FOBKKJHEPCC(sideSquares) & LEEEBPKBCJF(centerSquares);
	}

	private bool NANFHODDFGL(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		for (int i = 0; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].EHGDHOMFDGM());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].BOBEIFEGLOL());
			if (num == ZoneType.WithoutZone && groundType == GroundType.TilledEarth && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].CBALBDIFOGF()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].MGCHMMFFBJA(ACJFIEKCKEC: true, 695f);
				continue;
			}
			DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: true, 1721f);
			result = false;
		}
		return result;
	}

	public bool IBFAAHDLGHO()
	{
		return CKAGPGBNHBC(sideSquares) & KAJPIPEHCHA(centerSquares);
	}

	public bool GGHGMCEPDKG()
	{
		return KAJPIPEHCHA(sideSquares) & NANFHODDFGL(centerSquares);
	}

	public void FIGECCLOCLE(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 1; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].EHGDHOMFDGM(), IrrigatorType.Center);
			}
			for (int j = 1; j < centerSquares.Length; j++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].EHGDHOMFDGM(), IrrigatorType.None);
			}
		}
		else
		{
			for (int k = 1; k < sideSquares.Length; k++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].BLKHDGGHFLA(), IrrigatorType.None);
			}
			for (int l = 0; l < centerSquares.Length; l++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].GetCentrePosition(), IrrigatorType.Center);
			}
		}
	}

	public void NJFPNEIKCID(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 1; i < sideSquares.Length; i += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].FANOLHHEFBO(), IrrigatorType.None);
			}
			for (int j = 0; j < centerSquares.Length; j++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].CBALBDIFOGF(), IrrigatorType.None);
			}
		}
		else
		{
			for (int k = 1; k < sideSquares.Length; k++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].FGGMIOHMGFL(), IrrigatorType.Center);
			}
			for (int l = 0; l < centerSquares.Length; l++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].GetCentrePosition(), IrrigatorType.None);
			}
		}
	}

	private bool LEEEBPKBCJF(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 1; i < DHEJKKGFJID.Length; i++)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].BLKHDGGHFLA());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].FGGMIOHMGFL());
			if (num == ZoneType.WithoutZone && groundType == GroundType.Ground && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].KDFECDEEDHL()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].MGCHMMFFBJA(ACJFIEKCKEC: true, 660f);
				continue;
			}
			DHEJKKGFJID[i].PHHDMNLPOJL(ACJFIEKCKEC: false, 326f);
			result = true;
		}
		return result;
	}

	private bool CKAGPGBNHBC(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		for (int i = 0; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].FGGMIOHMGFL());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].BLKHDGGHFLA());
			if (num == ZoneType.WithoutZone && groundType == GroundType.Grass && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].KDFECDEEDHL()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].KEBKENOJICG(ACJFIEKCKEC: true, 645f);
				continue;
			}
			DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: false, 950f);
			result = false;
		}
		return result;
	}

	public void KGECNIPGPFG(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 0; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].KDFECDEEDHL(), (IrrigatorType)4);
			}
			for (int j = 0; j < centerSquares.Length; j += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].BOBEIFEGLOL(), IrrigatorType.None);
			}
		}
		else
		{
			for (int k = 1; k < sideSquares.Length; k += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].FANOLHHEFBO(), IrrigatorType.Center);
			}
			for (int l = 1; l < centerSquares.Length; l++)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].KDFECDEEDHL(), IrrigatorType.None);
			}
		}
	}

	public bool GCJLPFFAMJH()
	{
		return IBOBPEHJOOH(sideSquares) & CKAGPGBNHBC(centerSquares);
	}

	public bool MAAACFKBIAB()
	{
		return NANFHODDFGL(sideSquares) & KBALLMPBENG(centerSquares);
	}

	public bool BMKFABIHBOK()
	{
		return LEEEBPKBCJF(sideSquares) & NANFHODDFGL(centerSquares);
	}

	public bool ICPPNLMIIEC()
	{
		return NANFHODDFGL(sideSquares) & OGGPABHDPCO(centerSquares);
	}

	private bool INCGNCIOADN(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 0; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].BLKHDGGHFLA());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].CBALBDIFOGF());
			if (num == ZoneType.WithoutZone && groundType == (GroundType.Grass | GroundType.TilledEarth) && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].KDFECDEEDHL()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].KAJPIPEHCHA(ACJFIEKCKEC: true, 1133f);
				continue;
			}
			DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: false, 13f);
			result = false;
		}
		return result;
	}

	public bool FBCBNIMEEJC()
	{
		return IDBNBHCIMKN(sideSquares) & LMNMBLLLAOK(centerSquares);
	}

	public bool KPPMHHDGBLP()
	{
		return MJKILONNOJN(sideSquares) & CKAGPGBNHBC(centerSquares);
	}

	private bool EOLEOIDFBGN(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 0; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].KDFECDEEDHL());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].EHGDHOMFDGM());
			if (num == ZoneType.WithoutZone && groundType == GroundType.Floor && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].KDFECDEEDHL()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].FOBEHKFOMPB(ACJFIEKCKEC: false, 1145f);
				continue;
			}
			DHEJKKGFJID[i].PHHDMNLPOJL(ACJFIEKCKEC: true, 275f);
			result = true;
		}
		return result;
	}

	private bool MJKILONNOJN(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		for (int i = 1; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].GetCentrePosition());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].GetCentrePosition());
			if (num == ZoneType.None && groundType == GroundType.Ground && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].BLKHDGGHFLA()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].KEBKENOJICG(ACJFIEKCKEC: false, 1167f);
				continue;
			}
			DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: false, 825f);
			result = false;
		}
		return result;
	}

	private bool IBOBPEHJOOH(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		for (int i = 1; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].EHGDHOMFDGM());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].BOBEIFEGLOL());
			if (num == ZoneType.WithoutZone && groundType == (GroundType.Grass | GroundType.Ground) && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].CBALBDIFOGF()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: true, 1754f);
				continue;
			}
			DHEJKKGFJID[i].KAJPIPEHCHA(ACJFIEKCKEC: false, 481f);
			result = false;
		}
		return result;
	}

	private bool IDBNBHCIMKN(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		for (int i = 0; i < DHEJKKGFJID.Length; i++)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].GetCentrePosition());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].GetCentrePosition());
			if (num == ZoneType.WithoutZone && groundType == GroundType.TilledEarth && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].GetCentrePosition()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: true, 1f);
				continue;
			}
			DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: false, 1f);
			result = false;
		}
		return result;
	}

	public void OKLCNLPOJHB(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 1; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].DCAPKPOGHPK(), IrrigatorType.Side);
			}
			for (int j = 0; j < centerSquares.Length; j += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].FANOLHHEFBO(), IrrigatorType.None);
			}
		}
		else
		{
			for (int k = 1; k < sideSquares.Length; k += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].EHGDHOMFDGM(), IrrigatorType.None);
			}
			for (int l = 1; l < centerSquares.Length; l += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].BLKHDGGHFLA(), IrrigatorType.Center);
			}
		}
	}

	public bool CBKMIKEJCJD()
	{
		return CKAGPGBNHBC(sideSquares) & LEEEBPKBCJF(centerSquares);
	}

	public bool KHFBKLDDGEG()
	{
		return LEEEBPKBCJF(sideSquares) & LPBNMKFNIHE(centerSquares);
	}

	public bool LAIGKKJPAOF()
	{
		return LPBNMKFNIHE(sideSquares) & NANFHODDFGL(centerSquares);
	}

	public void FKNJJOLAALG(bool MANGBEKEOED)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (MANGBEKEOED)
		{
			for (int i = 1; i < sideSquares.Length; i++)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[i].GetCentrePosition(), (IrrigatorType)4);
			}
			for (int j = 0; j < centerSquares.Length; j += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[j].GetCentrePosition(), IrrigatorType.Center);
			}
		}
		else
		{
			for (int k = 0; k < sideSquares.Length; k += 0)
			{
				WorldGrid.PMLHOCINDCF(sideSquares[k].GetCentrePosition(), IrrigatorType.Center);
			}
			for (int l = 0; l < centerSquares.Length; l += 0)
			{
				WorldGrid.PMLHOCINDCF(centerSquares[l].DCAPKPOGHPK(), IrrigatorType.Center);
			}
		}
	}

	private bool KBALLMPBENG(BuildSquare[] DHEJKKGFJID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 0; i < DHEJKKGFJID.Length; i += 0)
		{
			ZoneType num = WorldGrid.AGKGGAFFFGM(DHEJKKGFJID[i].BLKHDGGHFLA());
			GroundType groundType = WorldGrid.NCEHFMPBBAK(DHEJKKGFJID[i].BLKHDGGHFLA());
			if (num == ZoneType.WithoutZone && groundType == (GroundType.Ground | GroundType.TilledEarth) && WorldGrid.BKKHDHJEPMK(DHEJKKGFJID[i].KGGGPHEMLII()) == IrrigatorType.None)
			{
				DHEJKKGFJID[i].PHHDMNLPOJL(ACJFIEKCKEC: false, 978f);
				continue;
			}
			DHEJKKGFJID[i].SetAvailable(ACJFIEKCKEC: false, 661f);
			result = false;
		}
		return result;
	}

	public bool JHGAFAIJJHO()
	{
		return IDHCIDLNKJK(sideSquares) & OGGPABHDPCO(centerSquares);
	}
}
