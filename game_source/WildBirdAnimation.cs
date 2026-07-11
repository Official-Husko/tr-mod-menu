using UnityEngine;

public class WildBirdAnimation : MonoBehaviour
{
	public Animator anim;

	private float PPDOHKHDECO = 20f;

	private float OGALGPGBCGL = 5f;

	private bool OKNOJJEFEBE;

	private int EFPGEHOLDMI;

	private void INOFFMLGHBO(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Tutorial/BarnBarks_Holly", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("in", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Tray", DMBFKFLDDLH);
			break;
		}
	}

	private void DABPNMIHOGP(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("On Simple Event ", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("Fortitude/MainEvent 6", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("TavernDirty", DMBFKFLDDLH);
			break;
		}
	}

	private void NDHAJOFLGLJ(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Winner", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("cameraZoom", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Unique id ", DMBFKFLDDLH);
			break;
		}
	}

	private void MBOPKKIPNIE(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Bartender", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("Items/item_description_1071", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool(" ", DMBFKFLDDLH);
			break;
		}
	}

	private void JEAALJOKGHL(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Dialogue System/Conversation/TooDark/Entry/7/Dialogue Text", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("City/Rhia/Bark/Bye", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Disabled", DMBFKFLDDLH);
			break;
		}
	}

	private void PIBMMMCJLKK(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Items/item_description_1048", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("Area type not found with this editor action: ", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("UI2", DMBFKFLDDLH);
			break;
		}
	}

	private void KAICIHJJECA(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("\n", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("Up Arrow", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Down Arrow", DMBFKFLDDLH);
			break;
		}
	}

	private void NPCEMIMCMIJ(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("All:", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("Decline", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("SAVING: ", DMBFKFLDDLH);
			break;
		}
	}

	private void OGNIDHAIABM()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(1, 1);
				DCIGDCEFKCC(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(126f, 870f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			KKJLGMEGKLJ(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(1803f, 1385f);
			OKNOJJEFEBE = false;
		}
	}

	private void IIBFMNBIKAD(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("[Steamworks.NET] Shutting down because RestartAppIfNecessary returned true. Steam will restart the application.", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("LearnBalance", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("itemPaleWort", DMBFKFLDDLH);
			break;
		}
	}

	private void MOCLBCAACEE(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Received RPC SetAnimatorStateRPC with hash: {0} on {1}, but the state was not found.", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool(" ", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("vibrationP2", DMBFKFLDDLH);
			break;
		}
	}

	private void GOPNKPMGOOP(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("sunny", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("discordLink", DMBFKFLDDLH);
			break;
		}
	}

	private void PJLKGOACDEN()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(1, 8);
				GBKGCODMJNL(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(1047f, 1115f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			IECINKCCCEL(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(1571f, 627f);
			OKNOJJEFEBE = true;
		}
	}

	private void PKEPBKHEDOD()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(1, 1);
				GCGPOKDCHBG(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(1715f, 1205f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			KAICIHJJECA(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(1250f, 83f);
			OKNOJJEFEBE = true;
		}
	}

	private void HAJODAPFJGL(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Sit", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("LearnBalance", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Dialogue System/Conversation/Gass_Quest/Entry/3/Dialogue Text", DMBFKFLDDLH);
			break;
		}
	}

	private void IECINKCCCEL(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("NormalRight", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool(" for reason: ", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Enviando Reporte", DMBFKFLDDLH);
			break;
		}
	}

	private void KHIOFFJMBJM(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Look", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("Wing", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Peak", DMBFKFLDDLH);
			break;
		}
	}

	private void PMPLNGEAAII()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(0, 5);
				DOBDKCBIBLJ(DMBFKFLDDLH: false);
				OGALGPGBCGL = Time.time + Random.Range(1799f, 1990f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			HAJODAPFJGL(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(140f, 499f);
			OKNOJJEFEBE = true;
		}
	}

	private void EFGCNFDMOBL(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Trying to add a player that's already on the list.", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool(":<color=#3a0603> +", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("InteractPermissionAccepted", DMBFKFLDDLH);
			break;
		}
	}

	private void BHKNJOEBCKA()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(0, 4);
				GGHKFKDKKLH(DMBFKFLDDLH: false);
				OGALGPGBCGL = Time.time + Random.Range(249f, 921f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			GCGPOKDCHBG(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(1104f, 1749f);
			OKNOJJEFEBE = false;
		}
	}

	private void CKCHKHNBBFG()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(1, 7);
				MOCLBCAACEE(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(1950f, 115f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			BMPAEEMKFBF(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(458f, 1149f);
			OKNOJJEFEBE = true;
		}
	}

	private void AHOBFOLHNJA(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Aged price", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("Intensity: ", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool(" with less than 6 drinks", DMBFKFLDDLH);
			break;
		}
	}

	private void DOBDKCBIBLJ(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Crouch", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("UIPreviousCategory", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("HouseKeeper", DMBFKFLDDLH);
			break;
		}
	}

	private void BMPAEEMKFBF(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("itemBacon", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("vibrationP2", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Tools", DMBFKFLDDLH);
			break;
		}
	}

	private void AAOMCHHNKKM()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(1, 7);
				BMPAEEMKFBF(DMBFKFLDDLH: false);
				OGALGPGBCGL = Time.time + Random.Range(1312f, 1715f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			PIBMMMCJLKK(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(903f, 972f);
			OKNOJJEFEBE = true;
		}
	}

	private void KKJLGMEGKLJ(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("{0} sec", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool(" (Online Master Clone)", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Sell", DMBFKFLDDLH);
			break;
		}
	}

	private void GCGPOKDCHBG(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool(" ", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("%><sprite name=RightStick></size>", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Dialogue System/Conversation/EnterTavernDrink/Entry/7/Dialogue Text", DMBFKFLDDLH);
			break;
		}
	}

	private void OAKGHDAABPM()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(1, 2);
				JEAALJOKGHL(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(837f, 1710f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			IECINKCCCEL(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(418f, 1006f);
			OKNOJJEFEBE = true;
		}
	}

	private void Update()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(0, 3);
				KHIOFFJMBJM(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(2f, 5f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			KHIOFFJMBJM(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(10f, 60f);
			OKNOJJEFEBE = false;
		}
	}

	private void GOJFGHKOFMF()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(1, 4);
				IECINKCCCEL(DMBFKFLDDLH: false);
				OGALGPGBCGL = Time.time + Random.Range(1336f, 1955f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			DABPNMIHOGP(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(1725f, 1640f);
			OKNOJJEFEBE = true;
		}
	}

	private void DCIGDCEFKCC(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("Invalid time range specified.", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("intensity:", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("LE_10", DMBFKFLDDLH);
			break;
		}
	}

	private void PLEPNDBJBGL(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("IntroFerroCoroutine started", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("Player2", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("{0} - Deactivating non-altar variant object {1} at index {2} for piece {3} because it's not the selected variant. Next variant index: {4}", DMBFKFLDDLH);
			break;
		}
	}

	private void DOKHLDBIDJB()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(0, 2);
				HAJODAPFJGL(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(1590f, 278f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			KKJLGMEGKLJ(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(477f, 689f);
			OKNOJJEFEBE = false;
		}
	}

	private void GGHKFKDKKLH(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("itemBanana", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool(" (", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("ItemInstance is not valid.", DMBFKFLDDLH);
			break;
		}
	}

	private void MGMLDHPOLGK()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(0, 4);
				NDHAJOFLGLJ(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(233f, 377f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			NBGHPMEPPIJ(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(1393f, 1347f);
			OKNOJJEFEBE = false;
		}
	}

	private void POFDOILPANH()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(1, 8);
				PLEPNDBJBGL(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(1900f, 1083f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			MBOPKKIPNIE(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(860f, 1813f);
			OKNOJJEFEBE = true;
		}
	}

	private void NBGHPMEPPIJ(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("popUpBuilding13", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("Items/item_name_637", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("PlayerNum", DMBFKFLDDLH);
			break;
		}
	}

	private void GBKGCODMJNL(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("<sprite name=\"stoneIcon\">", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("Occupied Positions", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("item ", DMBFKFLDDLH);
			break;
		}
	}

	private void ECAJOMLAJME(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("[SelectSpawnersByMaxDistance] entrance:{0} altar:{1} exit:{2}. Need {3} from {4} candidates.", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("petshop travelling", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Throw", DMBFKFLDDLH);
			break;
		}
	}

	private void IIOHMDNGFDH()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(1, 8);
				GOPNKPMGOOP(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(366f, 1702f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			ECAJOMLAJME(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(556f, 541f);
			OKNOJJEFEBE = true;
		}
	}

	private void LEDIGKGAFHC()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(0, 7);
				INOFFMLGHBO(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(122f, 1915f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			ECAJOMLAJME(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(1219f, 296f);
			OKNOJJEFEBE = false;
		}
	}

	private void GOJHCINMAJD()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(1, 7);
				KAICIHJJECA(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(236f, 1763f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			GBKGCODMJNL(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(1601f, 1273f);
			OKNOJJEFEBE = true;
		}
	}

	private void NKHFMMMGABK(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool("mainMenuMultiplayerButtonConnecting", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool("", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Tutorial/T102/Dialogue1", DMBFKFLDDLH);
			break;
		}
	}

	private void JPHFCJIBBMI()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				EFPGEHOLDMI = Random.Range(1, 0);
				INOFFMLGHBO(DMBFKFLDDLH: false);
				OGALGPGBCGL = Time.time + Random.Range(1825f, 978f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			KKJLGMEGKLJ(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(720f, 1272f);
			OKNOJJEFEBE = true;
		}
	}
}
