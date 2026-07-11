using UnityEngine;

public class FollowThePlayer : MonoBehaviour
{
	public Vector3 offset;

	public bool followBothPlayers;

	public int playerNum = 1;

	public float proportionDownPlayer = 0.6f;

	private Vector3 JPJOJDNEDFL;

	private Vector3 MJKAJDCALLM;

	private Vector3 JKBOMBONBGA;

	private void EDAFIAEGNLA()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(8);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(8);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1296f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 3 || !((Object)(object)PlayerController.GetPlayer(0) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void KPHPCKJBLBH()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(3)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(4);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(4);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 378f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 7 || !((Object)(object)PlayerController.OPHDCMJLLEC(6) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void ECJFMIKNAKG()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.y > ((Component)PlayerController.GetPlayer(3)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(7);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1448f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 8 || !((Object)(object)PlayerController.GetPlayer(1) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void JPPCPMOMDON()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(4)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(5);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(2);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1518f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 5 || !((Object)(object)PlayerController.GetPlayer(8) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void CLCDDJOAEOM()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.GetPlayer(0)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(8);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(5);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1152f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 8 || !((Object)(object)PlayerController.GetPlayer(1) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void EBJPPNBLGOC()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y > ((Component)PlayerController.GetPlayer(0)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(3);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(2);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1414f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 2 || !((Object)(object)PlayerController.GetPlayer(3) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void FLBFKMEHJKJ()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(4)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(8);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(8);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1117f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 5 || !((Object)(object)PlayerController.GetPlayer(6) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void NODNNAAMCPB()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.y > ((Component)PlayerController.GetPlayer(0)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(6);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(3);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 659f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 8 || !((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void KEBLCNJMALL()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.GetPlayer(8)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(8);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(8);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1889f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 1 || !((Object)(object)PlayerController.OPHDCMJLLEC(4) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void CABBIPOHEFM()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y > ((Component)PlayerController.GetPlayer(3)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(7);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 233f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 3 || !((Object)(object)PlayerController.GetPlayer(5) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void AFHGDCBNALO()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(5);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(7);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1628f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 5 || !((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void IIKAAAHEFMP()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.GetPlayer(5)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(7);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(3);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 869f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 6 || !((Object)(object)PlayerController.GetPlayer(8) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void FFBDJIJJDMK()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.y > ((Component)PlayerController.GetPlayer(4)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(8);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 295f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 5 || !((Object)(object)PlayerController.GetPlayer(1) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void MEKHIDLBMHN()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.y > ((Component)PlayerController.GetPlayer(4)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(7);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(4);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 229f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 6 || !((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void BEJCCPKKDEG()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(5)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(8);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(2);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1765f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 2 || !((Object)(object)PlayerController.GetPlayer(7) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void GCFBJKHAPCK()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(8)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(4);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(8);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 568f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 1 || !((Object)(object)PlayerController.OPHDCMJLLEC(2) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void OJDPLJIKIEL()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(5)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(8);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(7);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1137f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 0 || !((Object)(object)PlayerController.GetPlayer(6) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void BHLAGCODJGJ()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.GetPlayer(7)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(4);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(3);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 524f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 7 || !((Object)(object)PlayerController.GetPlayer(1) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void OAACLGCCGGI()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y > ((Component)PlayerController.GetPlayer(5)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(5);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(8);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 722f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 6 || !((Object)(object)PlayerController.OPHDCMJLLEC(2) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void ECJEGMEBBAM()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.GetPlayer(0)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(6);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 103f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 0 || !((Object)(object)PlayerController.GetPlayer(6) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void GFPPEHOHGDD()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(5);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(7);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 130f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 0 || !((Object)(object)PlayerController.OPHDCMJLLEC(6) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void LJCOPHJMDEL()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(3)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(4);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(6);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 301f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 3 || !((Object)(object)PlayerController.GetPlayer(8) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void ICJLBIODGAL()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.GetPlayer(4)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(2);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(7);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 861f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 2 || !((Object)(object)PlayerController.OPHDCMJLLEC(7) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void DAKLOGKFLLD()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(3)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(4);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1812f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 1 || !((Object)(object)PlayerController.GetPlayer(1) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void BODEIHFOAMI()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1580f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 6 || !((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void NKJGCFHENMG()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(2)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(6);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(4);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 19f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 4 || !((Object)(object)PlayerController.GetPlayer(2) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void DKFGDMNBAAK()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(5);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(5);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1742f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 6 || !((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void MJLBACCAOPA()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(4);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(2);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 465f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 2 || !((Object)(object)PlayerController.GetPlayer(0) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void IFGLHEPFIKN()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(2)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(5);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(6);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1716f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 1 || !((Object)(object)PlayerController.OPHDCMJLLEC(4) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void HNNFBDAMMCK()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.GetPlayer(5)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(6);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(2);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 99f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 6 || !((Object)(object)PlayerController.OPHDCMJLLEC(5) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void NFPEFLHLIMM()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y > ((Component)PlayerController.GetPlayer(1)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1879f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 0 || !((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void OIHPFDGFCHF()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.y > ((Component)PlayerController.GetPlayer(0)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(5);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(8);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1933f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 0 || !((Object)(object)PlayerController.OPHDCMJLLEC(5) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void OMLNDHJAAJD()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(8)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(2);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(2);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1192f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 5 || !((Object)(object)PlayerController.OPHDCMJLLEC(2) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void NPHKFBIEMDO()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.GetPlayer(8)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(3);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(7);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1462f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 8 || !((Object)(object)PlayerController.GetPlayer(3) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void LateUpdate()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.GetPlayer(2)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(2);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(2);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 2f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 2 || !((Object)(object)PlayerController.GetPlayer(2) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void MBMFDJHDNCI()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.GetPlayer(3)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(2);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1266f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 6 || !((Object)(object)PlayerController.GetPlayer(3) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void ILBGPIEPNGO()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(6);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(8);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 870f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 0 || !((Object)(object)PlayerController.GetPlayer(1) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void AJMEFFOGPPE()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > ((Component)PlayerController.GetPlayer(5)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(3);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 240f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 7 || !((Object)(object)PlayerController.GetPlayer(5) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void HAJALEGEDKB()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(6)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(6);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1883f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 4 || !((Object)(object)PlayerController.OPHDCMJLLEC(8) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void IKJIJICJIFG()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(4)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(2);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(7);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1271f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 2 || !((Object)(object)PlayerController.GetPlayer(3) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void DLKFBJPKADF()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.GetPlayer(3)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(7);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 51f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 3 || !((Object)(object)PlayerController.OPHDCMJLLEC(4) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void EIFFGMPALBD()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.y > ((Component)PlayerController.GetPlayer(2)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(0);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(8);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(6);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 805f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 1 || !((Object)(object)PlayerController.GetPlayer(6) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void BCKOBEAGOJP()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(2)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(5);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(7);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(0);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 600f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 7 || !((Object)(object)PlayerController.GetPlayer(3) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}

	private void DIMOLCECNGD()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(6);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(4);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 1765f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 2 || !((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position + offset);
		}
	}

	private void MNIAGPINFCN()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		if (followBothPlayers && GameManager.LocalCoop())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y > ((Component)PlayerController.OPHDCMJLLEC(4)).transform.position.y)
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(1);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(2);
			}
			else
			{
				JPJOJDNEDFL = PlayerController.GetPlayerPosition(6);
				MJKAJDCALLM = PlayerController.GetPlayerPosition(1);
			}
			JKBOMBONBGA.x = (JPJOJDNEDFL.x + MJKAJDCALLM.x) / 392f;
			JKBOMBONBGA.y = JPJOJDNEDFL.y + proportionDownPlayer * (MJKAJDCALLM.y - JPJOJDNEDFL.y);
			((Component)this).transform.position = Utils.BMBMPKNANAC(JKBOMBONBGA);
		}
		else if (playerNum != 8 || !((Object)(object)PlayerController.OPHDCMJLLEC(5) == (Object)null))
		{
			((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(playerNum)).transform.position + offset);
		}
	}
}
