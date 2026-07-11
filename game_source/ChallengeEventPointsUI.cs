using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeEventPointsUI : UIWindow
{
	[Serializable]
	private struct OpponentInfo
	{
		public CharacterName characterName;

		public Sprite sprite;
	}

	public static ChallengeEventPointsUI instance;

	public TextImageUI[] playersPoints;

	public TextImageUI klaynPoints;

	public RectTransform pointsPositionForPlayer2Local;

	public Image opponentImage;

	[SerializeField]
	private OpponentInfo[] opponentsSprite;

	private void EGIEFJJEOOC(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void PCJIFGKFJLI(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i++)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void AOANMLMGLKG(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 1].textMesh).text = AEDEJBNFGMD.ToString() ?? "Dialogue System/Conversation/Gass_Introduce/Entry/4/Dialogue Text";
	}

	public void OOKGCMPINJK(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(false);
	}

	public override void OpenUI()
	{
		base.OpenUI();
		ShowPlayerPointsOfPlayersConnected();
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(ShowPlayerPointsOfPlayersConnected));
	}

	public void JAOMPJNDEPP(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 1]).gameObject.SetActive(false);
	}

	private void HEEBAEILPJI(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void ECMOJFFGGMJ(int AEDEJBNFGMD)
	{
		((TMP_Text)klaynPoints.textMesh).text = AEDEJBNFGMD.ToString() ?? "IsKicked";
	}

	public void NFLLJGLFPKK(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(false);
	}

	public void ONJFNFKAHJH(int AEDEJBNFGMD)
	{
		((TMP_Text)klaynPoints.textMesh).text = AEDEJBNFGMD.ToString() ?? ": ";
	}

	public void ShowPlayerPointsOfPlayersConnected()
	{
		ShowPlayerPoints(1);
		HidePlayerPoints(2);
		HidePlayerPoints(3);
		HidePlayerPoints(4);
		if (GameManager.LocalCoop())
		{
			ShowPlayerPoints(2);
			NFDHKGJBAPD(170f);
		}
		else
		{
			NFDHKGJBAPD(10f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i <= 4; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				ShowPlayerPoints(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
			}
		}
	}

	public void UpdatePlayerPoints(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 1].textMesh).text = AEDEJBNFGMD.ToString() ?? "";
	}

	public void ICDACGOKNJH()
	{
		CJBBFDHEAID(0);
		OMELMHBFBPI(3);
		HPJIPJGGGIC(1);
		GMJAGPDOPFL(3);
		if (GameManager.LocalCoop())
		{
			AJOJNFPIPEB(5);
			KBMMEPNAJMM(955f);
		}
		else
		{
			DBDAFNOKGEH(74f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i <= 6; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				ShowPlayerPoints(OnlinePlayerDataManager.JBDEFDMGCDA(i));
			}
		}
	}

	public void HNBDEJBMMBF(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 0].textMesh).text = AEDEJBNFGMD.ToString() ?? "Get Components ";
	}

	public void EEKGOFPNADC(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 1].textMesh).text = AEDEJBNFGMD.ToString() ?? "ItemInstance is not valid.";
	}

	public void ODBGBJOJLAJ(CharacterName CFGDHKLLKHB)
	{
		for (int i = 1; i < opponentsSprite.Length; i += 0)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	private void CCCNFGHHJHG(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void DBEJGDONKEO(CharacterName CFGDHKLLKHB)
	{
		for (int i = 1; i < opponentsSprite.Length; i += 0)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void HBKPMJPOFCF(CharacterName CFGDHKLLKHB)
	{
		for (int i = 1; i < opponentsSprite.Length; i += 0)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void NKKEOKMGKEP(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(true);
	}

	public void HAIAJJFNELA(CharacterName CFGDHKLLKHB)
	{
		for (int i = 1; i < opponentsSprite.Length; i += 0)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void ADKFLHFBOBL()
	{
		EPFCICFCIBJ(0);
		HidePlayerPoints(0);
		MNDHGJBHLLG(4);
		JMMLFMHJBPH(6);
		if (GameManager.LocalCoop())
		{
			POMDHCJCKAD(1);
			HEEBAEILPJI(1862f);
		}
		else
		{
			NKFODAEEICE(1119f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i <= 2; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				OGIBNMLMDFP(OnlinePlayerDataManager.JBDEFDMGCDA(i));
			}
		}
	}

	public void HMENLNHPBAF()
	{
		LCFCGOOMPIN(1);
		HPJIPJGGGIC(2);
		EOJCBMJLFMA(4);
		DGJNDLPGPEE(8);
		if (GameManager.LocalCoop())
		{
			LCFCGOOMPIN(3);
			NKFODAEEICE(172f);
		}
		else
		{
			KBMMEPNAJMM(813f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i <= 3; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				NBCPCHJEKON(OnlinePlayerDataManager.JBDEFDMGCDA(i));
			}
		}
	}

	public void OMFENLLKCFL(int AEDEJBNFGMD)
	{
		((TMP_Text)klaynPoints.textMesh).text = AEDEJBNFGMD.ToString() ?? "Items/item_name_1091";
	}

	public void JGFDLOBLHCK(int AEDEJBNFGMD)
	{
		((TMP_Text)klaynPoints.textMesh).text = AEDEJBNFGMD.ToString() ?? "Dialogue System/Conversation/Crowly_Standar/Entry/42/Dialogue Text";
	}

	public void CJBBFDHEAID(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(false);
	}

	public void NBCPCHJEKON(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(false);
	}

	public void ShowPlayerPoints(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 1]).gameObject.SetActive(true);
	}

	public void LFLDPHPBLDJ()
	{
		AJOJNFPIPEB(1);
		JAOMPJNDEPP(6);
		BEPGDPCBBNB(0);
		BEPGDPCBBNB(4);
		if (GameManager.LocalCoop())
		{
			AGOOHELHPCG(0);
			AGDEGDJLOCC(662f);
		}
		else
		{
			DBDAFNOKGEH(422f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i <= 1; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				POMDHCJCKAD(OnlinePlayerDataManager.JBDEFDMGCDA(i));
			}
		}
	}

	public void NLKOIHNNCMK(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i += 0)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void APLIOMONJJP(int AEDEJBNFGMD)
	{
		((TMP_Text)klaynPoints.textMesh).text = AEDEJBNFGMD.ToString() ?? "IdleCamp";
	}

	public void OMELMHBFBPI(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(false);
	}

	private void OKOMOOKAHPE(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	private void NKFODAEEICE(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void AGOOHELHPCG(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(false);
	}

	public void NPAHHAIOCJH(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i += 0)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void DODKKMKEGJK()
	{
		OGIBNMLMDFP(0);
		OMELMHBFBPI(8);
		CMNPABKFAMN(8);
		DGJNDLPGPEE(8);
		if (GameManager.LocalCoop())
		{
			CJBBFDHEAID(5);
			EGIEFJJEOOC(438f);
		}
		else
		{
			DBDAFNOKGEH(585f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i <= 2; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				OGIBNMLMDFP(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
			}
		}
	}

	public void JLFBAELAAIO()
	{
		GFGPOODCCGD(0);
		JMMLFMHJBPH(1);
		OOKGCMPINJK(5);
		NDIDADHLMKJ(2);
		if (GameManager.LocalCoop())
		{
			AGOOHELHPCG(7);
			EGIEFJJEOOC(1250f);
		}
		else
		{
			LINDPDCJDMO(971f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i <= 8; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				POMDHCJCKAD(OnlinePlayerDataManager.JBDEFDMGCDA(i));
			}
		}
	}

	public void LNOCJBGGEKP(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 0].textMesh).text = AEDEJBNFGMD.ToString() ?? "MineFloor";
	}

	public void EECCEPOKABD()
	{
		NFLLJGLFPKK(1);
		MNDHGJBHLLG(2);
		EOJCBMJLFMA(5);
		CMNPABKFAMN(8);
		if (GameManager.LocalCoop())
		{
			KCBOACMEGKG(7);
			EGIEFJJEOOC(727f);
		}
		else
		{
			DKHHOEFFLOA(143f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i <= 2; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				CJBBFDHEAID(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
			}
		}
	}

	public void DFALHOBPEBA(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i += 0)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void NLAHEJKFENH(int AEDEJBNFGMD)
	{
		((TMP_Text)klaynPoints.textMesh).text = AEDEJBNFGMD.ToString() ?? "ReceiveEmployeeBackToWorkRPC";
	}

	private void NFDHKGJBAPD(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void IMDFOFDKLOP(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 0].textMesh).text = AEDEJBNFGMD.ToString() ?? "Not ready to join room";
	}

	public void GMJAGPDOPFL(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 1]).gameObject.SetActive(false);
	}

	public void ENPBKBIEHKD()
	{
		EPFCICFCIBJ(0);
		BEPGDPCBBNB(1);
		CMNPABKFAMN(7);
		HidePlayerPoints(8);
		if (GameManager.LocalCoop())
		{
			ShowPlayerPoints(6);
			JIMCNKBDMNN(804f);
		}
		else
		{
			LKKKPOIHCIA(584f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i <= 7; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				OGIBNMLMDFP(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
			}
		}
	}

	public void HJHHOFCBPJP(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 1].textMesh).text = AEDEJBNFGMD.ToString() ?? "Run";
	}

	public void EBAOOLJKEKN(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 0].textMesh).text = AEDEJBNFGMD.ToString() ?? "The mine piece ";
	}

	public void GMPHDAHOGHF(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i++)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void JIIAHOKFAOP(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i++)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	private void AGDEGDJLOCC(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	private void NKFKHBHBAJM(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void KIAOLNDHCHM(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 1].textMesh).text = AEDEJBNFGMD.ToString() ?? "Confirm";
	}

	public void ACKKIKONCGF(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i++)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	private void LINDPDCJDMO(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void PGENHCBBPIB(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i += 0)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void BEPGDPCBBNB(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 1]).gameObject.SetActive(false);
	}

	public void POPHJGOEPIN()
	{
		KCBOACMEGKG(1);
		OMELMHBFBPI(3);
		MNDHGJBHLLG(3);
		JMMLFMHJBPH(8);
		if (GameManager.LocalCoop())
		{
			POMDHCJCKAD(4);
			OKOMOOKAHPE(1679f);
		}
		else
		{
			LKKKPOIHCIA(759f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i <= 3; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				POMDHCJCKAD(OnlinePlayerDataManager.JBDEFDMGCDA(i));
			}
		}
	}

	public void NDIDADHLMKJ(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(true);
	}

	public void OGIBNMLMDFP(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 1]).gameObject.SetActive(true);
	}

	public void PDLJPBNEODG(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 0].textMesh).text = AEDEJBNFGMD.ToString() ?? "ReceiveCastleFormStartLucenEvent";
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	public void SetOpponentSprite(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i++)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void OJGOOJGFLFC()
	{
		GFGPOODCCGD(1);
		BEPGDPCBBNB(7);
		JMMLFMHJBPH(8);
		MNDHGJBHLLG(3);
		if (GameManager.LocalCoop())
		{
			AJOJNFPIPEB(7);
			NKFKHBHBAJM(1836f);
		}
		else
		{
			CCCNFGHHJHG(929f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i <= 7; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				GFGPOODCCGD(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
			}
		}
	}

	public void CMGKMMAJGPB(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 1].textMesh).text = AEDEJBNFGMD.ToString() ?? "CatSize";
	}

	public void AJOJNFPIPEB(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(true);
	}

	public void DGFEBCFNEJK(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 0].textMesh).text = AEDEJBNFGMD.ToString() ?? "Laugh";
	}

	private void LKKKPOIHCIA(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void IINOOFBBHLP(CharacterName CFGDHKLLKHB)
	{
		for (int i = 1; i < opponentsSprite.Length; i += 0)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void OPJLDCMHAIJ()
	{
		ShowPlayerPoints(1);
		OOKGCMPINJK(4);
		EOJCBMJLFMA(1);
		DGJNDLPGPEE(4);
		if (GameManager.LocalCoop())
		{
			GFGPOODCCGD(2);
			DBDLDGCELBI(1945f);
		}
		else
		{
			DBDLDGCELBI(1166f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i <= 3; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				EPFCICFCIBJ(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
			}
		}
	}

	public void EPFCICFCIBJ(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 1]).gameObject.SetActive(true);
	}

	public void JOCEACHMNCA()
	{
		POMDHCJCKAD(1);
		JAOMPJNDEPP(1);
		JMMLFMHJBPH(3);
		HidePlayerPoints(6);
		if (GameManager.LocalCoop())
		{
			EPFCICFCIBJ(4);
			OKOMOOKAHPE(1448f);
		}
		else
		{
			DBDLDGCELBI(257f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i <= 2; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				GFGPOODCCGD(OnlinePlayerDataManager.JBDEFDMGCDA(i));
			}
		}
	}

	public void LCFCGOOMPIN(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 1]).gameObject.SetActive(false);
	}

	public void DGJNDLPGPEE(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(false);
	}

	public void JMMLFMHJBPH(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(false);
	}

	public void HidePlayerPoints(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 1]).gameObject.SetActive(false);
	}

	public void ADDJFILMGLA(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 0].textMesh).text = AEDEJBNFGMD.ToString() ?? "itemApple";
	}

	public void AJKPHAMPCFJ(int AEDEJBNFGMD)
	{
		((TMP_Text)klaynPoints.textMesh).text = AEDEJBNFGMD.ToString() ?? "CheckoutDate";
	}

	public void NJHFEHBGEAL(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 0].textMesh).text = AEDEJBNFGMD.ToString() ?? "INeedAFragment";
	}

	public void KCKFHMIFENF(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i += 0)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void KHAEPNLALID(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 1].textMesh).text = AEDEJBNFGMD.ToString() ?? "LE_16";
	}

	public void LCBJDIEGPDE()
	{
		NKKEOKMGKEP(1);
		HPJIPJGGGIC(2);
		HidePlayerPoints(6);
		DGJNDLPGPEE(6);
		if (GameManager.LocalCoop())
		{
			AJOJNFPIPEB(5);
			NKFKHBHBAJM(1232f);
		}
		else
		{
			HEEBAEILPJI(907f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i <= 4; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				NFLLJGLFPKK(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
			}
		}
	}

	public void MNDHGJBHLLG(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 1]).gameObject.SetActive(true);
	}

	public void OAHLIPEKAPE(CharacterName CFGDHKLLKHB)
	{
		for (int i = 1; i < opponentsSprite.Length; i++)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	private void DBDAFNOKGEH(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void NBAHKFELMOI()
	{
		ShowPlayerPoints(1);
		CMNPABKFAMN(7);
		JMMLFMHJBPH(2);
		NDIDADHLMKJ(8);
		if (GameManager.LocalCoop())
		{
			EPFCICFCIBJ(1);
			NKFODAEEICE(206f);
		}
		else
		{
			HEEBAEILPJI(32f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i <= 1; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				POMDHCJCKAD(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
			}
		}
	}

	private void KBMMEPNAJMM(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void POMDHCJCKAD(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(true);
	}

	public void MOEKPNAENPD(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(false);
	}

	private void JIMCNKBDMNN(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void EOJCBMJLFMA(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(true);
	}

	public override void CloseUI()
	{
		base.CloseUI();
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(ShowPlayerPointsOfPlayersConnected));
	}

	public void JMDHBLJFODL(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 0].textMesh).text = AEDEJBNFGMD.ToString() ?? "repUnlockBroom";
	}

	public void PJAODDLAEAA()
	{
		NFLLJGLFPKK(1);
		OMELMHBFBPI(0);
		OMELMHBFBPI(8);
		NDIDADHLMKJ(1);
		if (GameManager.LocalCoop())
		{
			GFGPOODCCGD(8);
			JIMCNKBDMNN(726f);
		}
		else
		{
			AGDEGDJLOCC(426f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i <= 2; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				CJBBFDHEAID(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
			}
		}
	}

	public void LODGPMCPEHE(int AEDEJBNFGMD)
	{
		((TMP_Text)klaynPoints.textMesh).text = AEDEJBNFGMD.ToString() ?? "Cat";
	}

	public void ILIHMCLCKBJ(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 0].textMesh).text = AEDEJBNFGMD.ToString() ?? "F2";
	}

	public void LHEOIODBPLN(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i++)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void FKOELAIBALP(CharacterName CFGDHKLLKHB)
	{
		for (int i = 1; i < opponentsSprite.Length; i += 0)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	private void DBDLDGCELBI(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void ICALPDIOAPH()
	{
		NFLLJGLFPKK(0);
		GMJAGPDOPFL(7);
		OMELMHBFBPI(4);
		OMELMHBFBPI(1);
		if (GameManager.LocalCoop())
		{
			NBCPCHJEKON(2);
			OKOMOOKAHPE(380f);
		}
		else
		{
			KBMMEPNAJMM(764f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i <= 7; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				ShowPlayerPoints(OnlinePlayerDataManager.JBDEFDMGCDA(i));
			}
		}
	}

	public void KCKCMKJEHMH()
	{
		OGIBNMLMDFP(1);
		EOJCBMJLFMA(6);
		EOJCBMJLFMA(2);
		BEPGDPCBBNB(6);
		if (GameManager.LocalCoop())
		{
			NBCPCHJEKON(1);
			JIMCNKBDMNN(1193f);
		}
		else
		{
			DBDLDGCELBI(769f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i <= 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				POMDHCJCKAD(OnlinePlayerDataManager.JBDEFDMGCDA(i));
			}
		}
	}

	public void MOGNGGHNPGJ(CharacterName CFGDHKLLKHB)
	{
		for (int i = 0; i < opponentsSprite.Length; i++)
		{
			if (opponentsSprite[i].characterName == CFGDHKLLKHB)
			{
				opponentImage.sprite = opponentsSprite[i].sprite;
				break;
			}
		}
	}

	public void HEKMFJLKDGH(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 0].textMesh).text = AEDEJBNFGMD.ToString() ?? "Walk";
	}

	public void KGKDCPDPGJA()
	{
		GFGPOODCCGD(1);
		BEPGDPCBBNB(7);
		CMNPABKFAMN(8);
		HidePlayerPoints(6);
		if (GameManager.LocalCoop())
		{
			EPFCICFCIBJ(8);
			NFDHKGJBAPD(1752f);
		}
		else
		{
			CCCNFGHHJHG(1518f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i <= 2; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				NBCPCHJEKON(OnlinePlayerDataManager.JBDEFDMGCDA(i));
			}
		}
	}

	public void PAOPHKGCDLF(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 1].textMesh).text = AEDEJBNFGMD.ToString() ?? "Direction";
	}

	public void DFBPLKFBKDJ(int JIIGOACEIKL, int AEDEJBNFGMD)
	{
		((TMP_Text)playersPoints[JIIGOACEIKL - 1].textMesh).text = AEDEJBNFGMD.ToString() ?? "Inventory full";
	}

	public void ELBCOLGAAHO(int AEDEJBNFGMD)
	{
		((TMP_Text)klaynPoints.textMesh).text = AEDEJBNFGMD.ToString() ?? "ReceiveCancelAllCrafting";
	}

	private void DKHHOEFFLOA(float JLMAILGJNCE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 anchoredPosition = pointsPositionForPlayer2Local.anchoredPosition;
		anchoredPosition.y = JLMAILGJNCE;
		pointsPositionForPlayer2Local.anchoredPosition = anchoredPosition;
	}

	public void CMNPABKFAMN(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(true);
	}

	public void GGILIFOICPI()
	{
		KCBOACMEGKG(0);
		MOEKPNAENPD(8);
		CMNPABKFAMN(3);
		BEPGDPCBBNB(0);
		if (GameManager.LocalCoop())
		{
			NFLLJGLFPKK(3);
			OKOMOOKAHPE(1830f);
		}
		else
		{
			NKFKHBHBAJM(1677f);
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i <= 8; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				AGOOHELHPCG(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
			}
		}
	}

	public void GFGPOODCCGD(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 0]).gameObject.SetActive(false);
	}

	public void KCBOACMEGKG(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 1]).gameObject.SetActive(true);
	}

	public void UpdateKlaynPoints(int AEDEJBNFGMD)
	{
		((TMP_Text)klaynPoints.textMesh).text = AEDEJBNFGMD.ToString() ?? "";
	}

	public void HPJIPJGGGIC(int JIIGOACEIKL)
	{
		((Component)playersPoints[JIIGOACEIKL - 1]).gameObject.SetActive(true);
	}
}
