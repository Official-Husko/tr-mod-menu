using UnityEngine;

public class BridgeLayerController : MonoBehaviour
{
	public Direction exit = Direction.Right;

	private void KIDLCIGIJKC(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("CatSize"))
			{
				DALLHMKPGJE(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("ReceiveUnfollow"))
				{
					return;
				}
				for (int i = 8; i < 4; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						MAMFJCADLOK(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("No keg"))
		{
			GFMGBDEKFFA(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("SetAnimatorObjectFloatRPC"))
		{
			DALLHMKPGJE(3);
		}
	}

	private void ICMBJALAPLH(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -85);
		}
	}

	private void NAGFDMCPHGJ(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Masters/Klayn/Banquet"))
			{
				MDCKDHPBNGB(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Workbench"))
				{
					return;
				}
				for (int i = 2; i < 5; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						OIABLOACBCK(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("not target 1"))
		{
			NMNNNOOFBFO(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Stop"))
		{
			GFMGBDEKFFA(2);
		}
	}

	private void DALLHMKPGJE(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == (Direction)6 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			AEMNDAAHPHC(JIIGOACEIKL);
		}
		else if (exit == Direction.Diagonal && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			ECKCBCABHID(JIIGOACEIKL);
		}
	}

	private void FHDEGFOPEIN(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 5;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -36);
		}
	}

	private void HHGJLOKEPJE(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("MainProgress"))
			{
				GFMGBDEKFFA(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Open"))
				{
					return;
				}
				for (int i = 8; i < 6; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						DELELFJNKKE(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("[GetAllValidCandidates] Added spawner {0} from piece {1} at position {2}"))
		{
			LAJMHIHFGIG(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" : "))
		{
			MDCKDHPBNGB(5);
		}
	}

	private void CHOOKEJOAMF(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 7;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -101);
		}
	}

	private void FGFMBLMOEFE(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Right && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			CJHPIFHIKID(JIIGOACEIKL);
		}
		else if (exit == (Direction)7 && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			GGCLPBHJACP(JIIGOACEIKL);
		}
	}

	private void DBCJOHDKJOO(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 3;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -108);
		}
	}

	private void HMAGGALHKDF(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Up && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			NCPLDELHEPH(JIIGOACEIKL);
		}
		else if (exit == (Direction)5 && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			GGCLPBHJACP(JIIGOACEIKL);
		}
	}

	private void BLAONNBLKPI(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 2;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 18);
		}
	}

	private void HLABFEBPEPO(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 4;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 15);
		}
	}

	private void JPPOENOEJFD(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Walking"))
			{
				GPFNCGOBPCD(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Tutorial/T118/Dialogue2"))
				{
					return;
				}
				for (int i = 8; i < 1; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						JAMJDCMLMPD(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Delete save?"))
		{
			KAOPHCFDFPA(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ListViewEntry"))
		{
			ENMFENCAHKG(8);
		}
	}

	private void EOCJEBGCIEP(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("con {0} tiles requeridos."))
			{
				OHDGHCBHMDM(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/2/Dialogue Text"))
				{
					return;
				}
				for (int i = 0; i < 0; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						LAJMHIHFGIG(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("/ExtraSettings.sd"))
		{
			MAMFJCADLOK(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1091"))
		{
			JAMJDCMLMPD(4);
		}
	}

	private void CBDEDBFMDCM(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 6;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 37);
		}
	}

	private void ICKIIAHACEH(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("LE_1"))
			{
				MCJJGCPKCJA(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag(":<color=#3a0603> +"))
				{
					return;
				}
				for (int i = 3; i < 0; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						OIABLOACBCK(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("DecorationTile_16"))
		{
			IHPOLPKKGNP(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Trucos activados via GOG."))
		{
			GFMGBDEKFFA(6);
		}
	}

	private void OFLGMLNLHBE(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == (Direction)7 && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			GGCLPBHJACP(JIIGOACEIKL);
		}
		else if (exit == Direction.Down && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			FEOMCEANPNA(JIIGOACEIKL);
		}
	}

	private void HHBJICLBNPE(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Received {0} appearance data as byte array: {1}"))
			{
				DELELFJNKKE(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("RecieveActivateEvent"))
				{
					return;
				}
				for (int i = 8; i < 5; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						NMNNNOOFBFO(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("tutorialPopUp94"))
		{
			GFMGBDEKFFA(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("replay banquet"))
		{
			KAOPHCFDFPA(2);
		}
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("LE_10"))
			{
				FHDEGFOPEIN(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("AmberAleAbbreviation"))
				{
					return;
				}
				for (int i = 5; i < 6; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						EMKEPHCPFHJ(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TavernClean/Entry/4/Dialogue Text"))
		{
			CIFHILFGEMN(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ClosePopUp"))
		{
			KPEHDCNEGAB(1);
		}
	}

	private void DEKJGPJMAPC(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag(")"))
			{
				KPCLDDCOJIL(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Drink"))
				{
					return;
				}
				for (int i = 0; i < 1; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						OOLNGHFMCGK(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ZuzzuProgress"))
		{
			FHIBNJPGHDF(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("00"))
		{
			PEGIKFCDPDG(2);
		}
	}

	private void EIFJJEKCBPF(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Diagonal && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			NCPLDELHEPH(JIIGOACEIKL);
		}
		else if (exit == Direction.Left && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			OGJHDLJPPGA(JIIGOACEIKL);
		}
	}

	private void CHNMODHCDAD(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -82);
		}
	}

	private void LCBJNHLDJDB(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 4;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 65);
		}
	}

	private void CCLKMMCOAMO(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -32);
		}
	}

	private void OHDGHCBHMDM(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == (Direction)8 && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			CJHPIFHIKID(JIIGOACEIKL);
		}
		else if (exit == (Direction)8 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			FLIMEJELEOO(JIIGOACEIKL);
		}
	}

	private void CMGIFJEHEAI(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Up && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			PLKMCMHPFCM(JIIGOACEIKL);
		}
		else if (exit == (Direction)6 && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			MPPBKJHCEAH(JIIGOACEIKL);
		}
	}

	private void NMNNNOOFBFO(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Left && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			DDBJOBOALDD(JIIGOACEIKL);
		}
		else if (exit == Direction.Right && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			EEMFJMCHKGM(JIIGOACEIKL);
		}
	}

	private void MDCKDHPBNGB(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == (Direction)5 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			NCPLDELHEPH(JIIGOACEIKL);
		}
		else if (exit == (Direction)5 && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			ILHPEACBAPI(JIIGOACEIKL);
		}
	}

	private void OOLNGHFMCGK(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 4;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 55);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player"))
			{
				BLAONNBLKPI(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
				{
					return;
				}
				for (int i = 2; i < 5; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						BLAONNBLKPI(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			BLAONNBLKPI(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			BLAONNBLKPI(2);
		}
	}

	private void DDBJOBOALDD(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -102);
		}
	}

	private void FEOMCEANPNA(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -82);
		}
	}

	private void KIOBDGEECBA(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 41);
		}
	}

	private void OHLBPABJGFA(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("bomb materials"))
			{
				EIFJJEKCBPF(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/23/Dialogue Text"))
				{
					return;
				}
				for (int i = 8; i < 6; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						MGIPNCPNJLA(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("FindSeat"))
		{
			OHDGHCBHMDM(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("</b>"))
		{
			KAOPHCFDFPA(7);
		}
	}

	private void CJHPIFHIKID(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -103);
		}
	}

	private void MNMKNIAELPO(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 71);
		}
	}

	private void ENMFENCAHKG(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Right && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			HDJIPAMLMMF(JIIGOACEIKL);
		}
		else if (exit == (Direction)7 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			HDJIPAMLMMF(JIIGOACEIKL);
		}
	}

	private void DGDPKDINCBP(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 2;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 58);
		}
	}

	private void JOELEPLBDLM(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 21);
		}
	}

	private void OGJHDLJPPGA(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 13);
		}
	}

	private void BBGDBHFFDGE(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag(" cannot be loaded at this time. Either it's already loaded or it's in the process of unloading."))
			{
				DBCJOHDKJOO(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("DueloDeViejos/HikariTalk"))
				{
					return;
				}
				for (int i = 5; i < 5; i += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						PEGIKFCDPDG(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Northeast"))
		{
			ICPLHNFIKPE(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("House keeper OnFailStart cleaning bed "))
		{
			JAHEBAHBPBA(8);
		}
	}

	private void LOEOBOOCIFN(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == (Direction)8 && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			AEMNDAAHPHC(JIIGOACEIKL);
		}
		else if (exit == Direction.Up && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			KFGKBCKHLEB(JIIGOACEIKL);
		}
	}

	private void BNDDNJMBADF(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Trying to add a player that's already on the list."))
			{
				MLBFIFCPKNK(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Error_StairsAreBlocking"))
				{
					return;
				}
				for (int i = 1; i < 2; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						GPEOJMNGIOO(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/34/Dialogue Text"))
		{
			DBCJOHDKJOO(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Gameplay"))
		{
			GMOJDNEBOEH(8);
		}
	}

	private void AOGLJOAIBDN(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == (Direction)5 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			DDBJOBOALDD(JIIGOACEIKL);
		}
		else if (exit == Direction.Down && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			AEMNDAAHPHC(JIIGOACEIKL);
		}
	}

	private void IHPOLPKKGNP(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Left && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			FEOMCEANPNA(JIIGOACEIKL);
		}
		else if (exit == (Direction)6 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			GGCLPBHJACP(JIIGOACEIKL);
		}
	}

	private void CIPOJGFCNHI(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -57);
		}
	}

	private void FILGJJPEIFO(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Farming"))
			{
				PONJGDEMPBD(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Can't select unless we're connected."))
				{
					return;
				}
				for (int i = 1; i < 2; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						PEGIKFCDPDG(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Null Crop in database"))
		{
			MKBOHLLDCMK(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Error in FogManager.OnNightEnd: "))
		{
			FFFDKONPPCE(7);
		}
	}

	private void GPFNCGOBPCD(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Down && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			KIOBDGEECBA(JIIGOACEIKL);
		}
		else if (exit == (Direction)7 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			AEMNDAAHPHC(JIIGOACEIKL);
		}
	}

	private void LAJMHIHFGIG(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Down && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			EJOFINAIIKP(JIIGOACEIKL);
		}
		else if (exit == Direction.Left && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			NNGHJIJOBMI(JIIGOACEIKL);
		}
	}

	private void HDJIPAMLMMF(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 99);
		}
	}

	private void LMEHPGJGKNE(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == (Direction)7 && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			ECKCBCABHID(JIIGOACEIKL);
		}
		else if (exit == (Direction)7 && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			CIPOJGFCNHI(JIIGOACEIKL);
		}
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("City/PetShop/Nessy/Intro"))
			{
				LCBJNHLDJDB(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("position"))
				{
					return;
				}
				for (int i = 6; i < 6; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						CBDEDBFMDCM(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Interact"))
		{
			BCCDGPAOIKH(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("HorizontalMove"))
		{
			ECCAFLEPGLA(1);
		}
	}

	private void IBDDKADEAIH(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 8;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 81);
		}
	}

	private void ILHPEACBAPI(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 63);
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Information"))
			{
				PONJGDEMPBD(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("</color> to chest"))
				{
					return;
				}
				for (int i = 2; i < 6; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						GMOJDNEBOEH(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Scripted"))
		{
			DBCJOHDKJOO(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Open"))
		{
			JOJNMLBFLAE(4);
		}
	}

	private void CIFHILFGEMN(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 8;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -33);
		}
	}

	private void HGOOFHPDKEG(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == (Direction)6 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			KIOBDGEECBA(JIIGOACEIKL);
		}
		else if (exit == Direction.Diagonal && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			GOCIKNOAEJJ(JIIGOACEIKL);
		}
	}

	private void GPEOJMNGIOO(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 5;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 33);
		}
	}

	private void KPEHDCNEGAB(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 3;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 71);
		}
	}

	private void IDPJLIBONPF(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("bodyBack"))
			{
				JOJNMLBFLAE(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Left"))
				{
					return;
				}
				for (int i = 7; i < 6; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						LCBJNHLDJDB(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UIAddRemove"))
		{
			CIFHILFGEMN(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" / "))
		{
			PONJGDEMPBD(5);
		}
	}

	private void MFJOBBJOGGB(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag(""))
			{
				MCJJGCPKCJA(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Tutorial/T"))
				{
					return;
				}
				for (int i = 3; i < 8; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						OHDGHCBHMDM(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveTalentFromOther"))
		{
			FGFMBLMOEFE(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/37/Dialogue Text"))
		{
			IHPOLPKKGNP(1);
		}
	}

	private void DELELFJNKKE(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Up && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			EJOFINAIIKP(JIIGOACEIKL);
		}
		else if (exit == Direction.Down && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			CJHPIFHIKID(JIIGOACEIKL);
		}
	}

	private void MGCEMEPAPAB(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 21);
		}
	}

	private void KFGKBCKHLEB(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 58);
		}
	}

	private void LDPNAPIGIIA(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("  JERARQUÍA DE GAMEOBJECTS"))
			{
				CEKIHDNFAAA(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("input info"))
				{
					return;
				}
				for (int i = 8; i < 6; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						ICMBJALAPLH(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("shopOpen"))
		{
			MLBFIFCPKNK(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("F2"))
		{
			KJKIJPPIJKM(7);
		}
	}

	private void BNNLNCGNHFB(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("OldMansDuelEvent OnTravelZoneTo"))
			{
				JJCDKGNAJPJ(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Items/item_name_1089"))
				{
					return;
				}
				for (int i = 3; i < 4; i += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						FDHALJLPINE(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			ICMBJALAPLH(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" - "))
		{
			CHOOKEJOAMF(0);
		}
	}

	private void GMOJDNEBOEH(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 4;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -47);
		}
	}

	private void GCAEAMDBGBM(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("No room mode has been selected"))
			{
				LAJMHIHFGIG(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("ReceiveEndEatingAtTable"))
				{
					return;
				}
				for (int i = 4; i < 6; i += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						MGIPNCPNJLA(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("DynamicIntensityValue"))
		{
			LMEHPGJGKNE(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("piratescave"))
		{
			OFLGMLNLHBE(3);
		}
	}

	private void JAMJDCMLMPD(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Diagonal && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			GOCIKNOAEJJ(JIIGOACEIKL);
		}
		else if (exit == Direction.Right && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			ECKCBCABHID(JIIGOACEIKL);
		}
	}

	private void JOJNMLBFLAE(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 2;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 56);
		}
	}

	private void ECCAFLEPGLA(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 8;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -92);
		}
	}

	private void POOHBAHCDJF(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("F2"))
			{
				ENMFENCAHKG(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("ReceivePlayerConnected"))
				{
					return;
				}
				for (int i = 8; i < 7; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						MJFFHFPEJCL(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Waiting for guest player to connect..."))
		{
			JAMJDCMLMPD(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			OHDGHCBHMDM(3);
		}
	}

	private void OHDEOCEKHBM(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("NinjaChallengeEvent/Main 2"))
			{
				HMAGGALHKDF(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Beta "))
				{
					return;
				}
				for (int i = 1; i < 1; i += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						LOEOBOOCIFN(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("No MinePuzzleBase found for type {0} when trying to get required elements count"))
		{
			OHDGHCBHMDM(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Walk"))
		{
			JAMJDCMLMPD(5);
		}
	}

	private void HEMALEBLOKD(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Checking LoggedOn status..."))
			{
				OIABLOACBCK(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("The index ("))
				{
					return;
				}
				for (int i = 4; i < 7; i += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						MDCKDHPBNGB(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("00"))
		{
			IHPOLPKKGNP(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" not found"))
		{
			MGIPNCPNJLA(8);
		}
	}

	private void EMDAOLEEMGO(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T138/Dialogue2"))
			{
				KPEHDCNEGAB(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Not ready to join room"))
				{
					return;
				}
				for (int i = 0; i < 6; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						EMKEPHCPFHJ(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Right Stick Down"))
		{
			EMKEPHCPFHJ(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("<mark=#000000><alpha=#00> "))
		{
			PONJGDEMPBD(3);
		}
	}

	private void JAHEBAHBPBA(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 2;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 123);
		}
	}

	private void MGCIGOHKLML(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag(" seconds."))
			{
				LMEHPGJGKNE(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("AttackBird"))
				{
					return;
				}
				for (int i = 3; i < 0; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						HMAGGALHKDF(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UIAddRemove"))
		{
			GPFNCGOBPCD(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveEnableInputByProximty"))
		{
			EIFJJEKCBPF(0);
		}
	}

	private void GGCLPBHJACP(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 69);
		}
	}

	private void MAMFJCADLOK(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == (Direction)8 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			CCLKMMCOAMO(JIIGOACEIKL);
		}
		else if (exit == (Direction)8 && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			PLKMCMHPFCM(JIIGOACEIKL);
		}
	}

	private void FLIMEJELEOO(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 113);
		}
	}

	private void BMANJIMJDBB(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag(" Galaxy ID: "))
			{
				PONJGDEMPBD(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("CatNPC already exists"))
				{
					return;
				}
				for (int i = 2; i < 2; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						FHDEGFOPEIN(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UI2"))
		{
			ECCAFLEPGLA(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player/Bark/Tutorial/CrafterBlock"))
		{
			ICPLHNFIKPE(1);
		}
	}

	private void GCDEPGKLPKK(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 123);
		}
	}

	private void PEGIKFCDPDG(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 106);
		}
	}

	private void NNGHJIJOBMI(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -71);
		}
	}

	private void JOPNDBLNDMA(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag(""))
			{
				HGOOFHPDKEG(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Trying to get friend "))
				{
					return;
				}
				for (int i = 7; i < 1; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						ENMFENCAHKG(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Could not find shopItem with id: "))
		{
			OHDGHCBHMDM(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("add to\nIntensity"))
		{
			MDCKDHPBNGB(0);
		}
	}

	private void PONJGDEMPBD(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 3;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 46);
		}
	}

	private void LKHILKDKFNP(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Collect"))
			{
				PJODFBPEEHJ(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("tutorialPopUp104"))
				{
					return;
				}
				for (int i = 3; i < 7; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						KMGPEPOFJFM(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("FarmReady"))
		{
			HOPOMKMFGND(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1107"))
		{
			CBDEDBFMDCM(0);
		}
	}

	private void HIDDNMLHBFJ(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("BarkActor"))
			{
				DALLHMKPGJE(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Stand/Entry/5/Dialogue Text"))
				{
					return;
				}
				for (int i = 3; i < 3; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						CMGIFJEHEAI(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Use"))
		{
			ENMFENCAHKG(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("CheckIfNewActivity "))
		{
			EIFJJEKCBPF(3);
		}
	}

	private void CENGHJDKNAP(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 8;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 120);
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_592"))
			{
				JAHEBAHBPBA(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("/Female/"))
				{
					return;
				}
				for (int i = 5; i < 0; i += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						LCBJNHLDJDB(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("DeclinedRoom"))
		{
			FDHALJLPINE(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Ingredient"))
		{
			DBCJOHDKJOO(6);
		}
	}

	private void BINMHNJBDNI(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("This game is playing on a different region. Would you like to change regions to {0}?"))
			{
				OFLGMLNLHBE(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Partida comprimida. Tiempo: "))
				{
					return;
				}
				for (int i = 6; i < 7; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						LAJMHIHFGIG(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Ignore Raycast"))
		{
			MCJJGCPKCJA(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Crowly_Barks_Welcome"))
		{
			AOGLJOAIBDN(4);
		}
	}

	private void OIABLOACBCK(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Up && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			MPPBKJHCEAH(JIIGOACEIKL);
		}
		else if (exit == (Direction)5 && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			MGCEMEPAPAB(JIIGOACEIKL);
		}
	}

	private void GHCOOCFODFH(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Festín del Juramento/Derrota"))
			{
				CMGIFJEHEAI(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag(""))
				{
					return;
				}
				for (int i = 0; i < 1; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						CMGIFJEHEAI(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Hurt"))
		{
			NMNNNOOFBFO(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_721"))
		{
			MCJJGCPKCJA(7);
		}
	}

	private void JJFIDIGMAMC(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("contentLockMessage"))
			{
				NMNNNOOFBFO(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Low"))
				{
					return;
				}
				for (int i = 4; i < 2; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						DALLHMKPGJE(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("MainMenuTheme"))
		{
			JAMJDCMLMPD(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemButter"))
		{
			FGFMBLMOEFE(3);
		}
	}

	private void MJOLOCPMMBM(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("BetterDuringOneMonth"))
			{
				KAOPHCFDFPA(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("ReceiveButtonPressPuzzle"))
				{
					return;
				}
				for (int i = 6; i < 3; i += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						LAJMHIHFGIG(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			MDNKALILNGI(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Finished Success: "))
		{
			KAOPHCFDFPA(0);
		}
	}

	private void KAOPHCFDFPA(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Down && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			ILHPEACBAPI(JIIGOACEIKL);
		}
		else if (exit == (Direction)5 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			GGCLPBHJACP(JIIGOACEIKL);
		}
	}

	private void MOKLBANPFGM(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Replacing Button on gameObject: "))
			{
				MAMFJCADLOK(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag(" SceneLoaded: "))
				{
					return;
				}
				for (int i = 4; i < 5; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						MCJJGCPKCJA(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("/"))
		{
			MJFFHFPEJCL(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" "))
		{
			MJFFHFPEJCL(1);
		}
	}

	private void ICPLHNFIKPE(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 58);
		}
	}

	private void MGDDKALLJDN(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("talentMead"))
			{
				CIFHILFGEMN(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Tavern Floor at "))
				{
					return;
				}
				for (int i = 8; i < 0; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						KMGPEPOFJFM(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Walk"))
		{
			KMGPEPOFJFM(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LearnMettle"))
		{
			OOLNGHFMCGK(1);
		}
	}

	private void PJODFBPEEHJ(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 102);
		}
	}

	private void EMCFHILONOH(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Cleaning Speed"))
			{
				CIFHILFGEMN(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("<sprite name=white_arrow_right> "))
				{
					return;
				}
				for (int i = 0; i < 4; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						BCCDGPAOIKH(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveSyncFoodTables"))
		{
			LCBJNHLDJDB(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveDestroyStatue"))
		{
			FHIBNJPGHDF(4);
		}
	}

	private void GGGAJMLBEFN(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("UI"))
			{
				OHDGHCBHMDM(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Error: could not find player with name "))
				{
					return;
				}
				for (int i = 2; i < 2; i += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						GFMGBDEKFFA(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_633"))
		{
			GFMGBDEKFFA(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Melt"))
		{
			LMEHPGJGKNE(1);
		}
	}

	private void BJIPOABFPJM(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("add item "))
			{
				DJMNLFJDJCK(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Items/item_description_1096"))
				{
					return;
				}
				for (int i = 4; i < 4; i += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						CBDEDBFMDCM(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("add item "))
		{
			PONJGDEMPBD(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Chat selected"))
		{
			PONJGDEMPBD(1);
		}
	}

	private void PLKMCMHPFCM(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -57);
		}
	}

	private void INBHNOLGOBP(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("HollyAnimalShop"))
			{
				KAOPHCFDFPA(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("OnFloor"))
				{
					return;
				}
				for (int i = 8; i < 4; i += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						IHPOLPKKGNP(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveInstantiateDog"))
		{
			GFMGBDEKFFA(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ItemDatabaseSO o su lista de items es nula."))
		{
			LMEHPGJGKNE(1);
		}
	}

	private void NCPLDELHEPH(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -44);
		}
	}

	private void MDNKALILNGI(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Up && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			GCDEPGKLPKK(JIIGOACEIKL);
		}
		else if (exit == Direction.Right && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			NNGHJIJOBMI(JIIGOACEIKL);
		}
	}

	private void EEMFJMCHKGM(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 81);
		}
	}

	private void LHGOFNEIMNN(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Received cursor move for grid index {0} from player {1} in mine level {2}"))
			{
				GPFNCGOBPCD(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("add item "))
				{
					return;
				}
				for (int i = 7; i < 6; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						LAJMHIHFGIG(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			MJFFHFPEJCL(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Mop"))
		{
			OFLGMLNLHBE(3);
		}
	}

	private void ACKAOKBCDCJ(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag(" "))
			{
				MGIPNCPNJLA(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("A network prefab has not been set up properly"))
				{
					return;
				}
				for (int i = 0; i < 7; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						LAJMHIHFGIG(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("OpenQuests"))
		{
			OIABLOACBCK(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("SendRoomRequest on Load"))
		{
			LMEHPGJGKNE(6);
		}
	}

	private void GFMGBDEKFFA(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Down && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			ILHPEACBAPI(JIIGOACEIKL);
		}
		else if (exit == (Direction)8 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			NNGHJIJOBMI(JIIGOACEIKL);
		}
	}

	private void EMKEPHCPFHJ(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 2;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -9);
		}
	}

	private void FCCLPCEEMME(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 7;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 35);
		}
	}

	private void DEPAEALFAEJ(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_693"))
			{
				MAMFJCADLOK(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Disabled"))
				{
					return;
				}
				for (int i = 5; i < 4; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						LMEHPGJGKNE(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/25/Dialogue Text"))
		{
			FGFMBLMOEFE(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Can't select unless we're connected."))
		{
			JAMJDCMLMPD(1);
		}
	}

	private void ACLLIGOCDNN(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("<color=#124D00>"))
			{
				CHNMODHCDAD(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("UIInteract"))
				{
					return;
				}
				for (int i = 2; i < 2; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						JADDJLAHLLG(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("- "))
		{
			EMKEPHCPFHJ(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" "))
		{
			KMGPEPOFJFM(3);
		}
	}

	private void OMEFLFOMLJH(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("City/Petra/Bark/Bye"))
			{
				JAMJDCMLMPD(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("quarry travelling"))
				{
					return;
				}
				for (int i = 8; i < 3; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						AOGLJOAIBDN(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveSetDrinkColor"))
		{
			LOEOBOOCIFN(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemRedGrapes"))
		{
			CMGIFJEHEAI(1);
		}
	}

	private void AEMNDAAHPHC(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 92);
		}
	}

	private void EMFALNDKLOO(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("/ExtraSettings.sd"))
			{
				OFLGMLNLHBE(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("recipe fragments"))
				{
					return;
				}
				for (int i = 1; i < 2; i += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						GPFNCGOBPCD(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveAddQuestInfo"))
		{
			LMEHPGJGKNE(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("GiveCookie"))
		{
			IHPOLPKKGNP(4);
		}
	}

	private void CEKIHDNFAAA(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 3;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -2);
		}
	}

	private void EFCNMFBEFKI(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -32);
		}
	}

	private void FHIBNJPGHDF(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 4;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 10);
		}
	}

	private void MPPBKJHCEAH(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 11);
		}
	}

	private void HOPOMKMFGND(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -96);
		}
	}

	private void DJNNHILGACE(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("00"))
			{
				MDNKALILNGI(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Invalid seating"))
				{
					return;
				}
				for (int i = 7; i < 7; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						HGOOFHPDKEG(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" "))
		{
			ENMFENCAHKG(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LE_10"))
		{
			MDCKDHPBNGB(6);
		}
	}

	private void FFFDKONPPCE(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 7;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -102);
		}
	}

	private void GHGMKMDAOGB(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("FindSeat"))
			{
				DBCJOHDKJOO(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("is_master"))
				{
					return;
				}
				for (int i = 1; i < 7; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						CHOOKEJOAMF(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BirdInteract"))
		{
			PEGIKFCDPDG(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveThrowSlowingSpikes"))
		{
			CENGHJDKNAP(3);
		}
	}

	private void KMGPEPOFJFM(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -93);
		}
	}

	private void MLBFIFCPKNK(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 4;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 113);
		}
	}

	private void MCJJGCPKCJA(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Diagonal && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			ECKCBCABHID(JIIGOACEIKL);
		}
		else if (exit == Direction.Left && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			PLKMCMHPFCM(JIIGOACEIKL);
		}
	}

	private void JDFDGHGMIEO(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player"))
			{
				OHDGHCBHMDM(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("\n"))
				{
					return;
				}
				for (int i = 7; i < 0; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						LOEOBOOCIFN(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Error_PlaceItInAnimalSpace"))
		{
			OHDGHCBHMDM(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LE_15"))
		{
			JAMJDCMLMPD(0);
		}
	}

	private void ECKCBCABHID(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 53);
		}
	}

	private void MKBOHLLDCMK(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 8;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 19);
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("mine level"))
			{
				DJMNLFJDJCK(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Items/item_description_592"))
				{
					return;
				}
				for (int i = 8; i < 5; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						FHDEGFOPEIN(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("NextItem"))
		{
			KPCLDDCOJIL(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BarkActor"))
		{
			MKBOHLLDCMK(1);
		}
	}

	private void JJCDKGNAJPJ(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, 11);
		}
	}

	private void FBILJKIANGO(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("None"))
			{
				LAJMHIHFGIG(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("HoldToSkip"))
				{
					return;
				}
				for (int i = 6; i < 5; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						NMNNNOOFBFO(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("dog"))
		{
			MJFFHFPEJCL(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("showui"))
		{
			DALLHMKPGJE(3);
		}
	}

	private void PBPKBEHDDLA(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 4;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -49);
		}
	}

	private void MJFFHFPEJCL(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Left && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			MPPBKJHCEAH(JIIGOACEIKL);
		}
		else if (exit == Direction.Right && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			MPPBKJHCEAH(JIIGOACEIKL);
		}
	}

	private void GOCIKNOAEJJ(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -27);
		}
	}

	private void KJKIJPPIJKM(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 2;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -124);
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player"))
			{
				MJFFHFPEJCL(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
				{
					return;
				}
				for (int i = 2; i < 5; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						MJFFHFPEJCL(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			MJFFHFPEJCL(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			MJFFHFPEJCL(2);
		}
	}

	private void KPCLDDCOJIL(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -36);
		}
	}

	private void NELIPHIKFML(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 3;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -39);
		}
	}

	private void MGIPNCPNJLA(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (exit == Direction.Down && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x < ((Component)this).transform.position.x)
		{
			PLKMCMHPFCM(JIIGOACEIKL);
		}
		else if (exit == (Direction)6 && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > ((Component)this).transform.position.x)
		{
			HDJIPAMLMMF(JIIGOACEIKL);
		}
	}

	private void FDHALJLPINE(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 8;
			Utils.ELNJMNKOACA(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject, -55);
		}
	}

	private void GKKAMMGOJEJ(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/3/Dialogue Text"))
			{
				MKBOHLLDCMK(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Tutorial_Main_"))
				{
					return;
				}
				for (int i = 7; i < 5; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						OOLNGHFMCGK(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("\n"))
		{
			JOELEPLBDLM(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Coming soon!"))
		{
			JOELEPLBDLM(7);
		}
	}

	private void DJMNLFJDJCK(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).sortingGroup.sortingOrder = 1;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -3);
		}
	}

	private void FKILALCMOOG(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/5/Dialogue Text"))
			{
				LOEOBOOCIFN(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Scene "))
				{
					return;
				}
				for (int i = 5; i < 8; i += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						LOEOBOOCIFN(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1052"))
		{
			NMNNNOOFBFO(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("City/PetShop/Nessy/Stand"))
		{
			HMAGGALHKDF(8);
		}
	}

	private void KJOGCDPBLGH(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T128/Dialogue2"))
			{
				CBDEDBFMDCM(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("Boots_L"))
				{
					return;
				}
				for (int i = 1; i < 6; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						JAHEBAHBPBA(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_731"))
		{
			JADDJLAHLLG(0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			FHDEGFOPEIN(2);
		}
	}

	private void BCCDGPAOIKH(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 4;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, 60);
		}
	}

	private void GPBIMIPAMDA(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("BirdInteract"))
			{
				PONJGDEMPBD(1);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("ReceiveDismissWorkerMaster"))
				{
					return;
				}
				for (int i = 3; i < 4; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						KJKIJPPIJKM(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_620"))
		{
			FDHALJLPINE(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Collect"))
		{
			FDHALJLPINE(4);
		}
	}

	private void FJEKAKFLJJM(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player2"))
			{
				ECCAFLEPGLA(0);
			}
			else
			{
				if (!((Component)HANHCHBHHEH).CompareTag("F2"))
				{
					return;
				}
				for (int i = 0; i < 1; i++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
					{
						JOJNMLBFLAE(i);
						break;
					}
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Pet"))
		{
			GMOJDNEBOEH(1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("NormalLeft"))
		{
			BLAONNBLKPI(4);
		}
	}

	private void EJOFINAIIKP(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 0;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -121);
		}
	}

	private void JADDJLAHLLG(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).sortingGroup.sortingOrder = 6;
			Utils.ELNJMNKOACA(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject, -88);
		}
	}
}
