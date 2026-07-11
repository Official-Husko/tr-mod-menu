using AlmenaraGames;
using UnityEngine;

public class SnowgangController : MonoBehaviour
{
	public GameObject spriteObj;

	public GameObject hurtObj;

	public GameObject snowmanFx;

	private bool PPGPGLDBDJP;

	public void DFAOEEKJJHE(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CutGrass);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1991f, 1431f, 1332f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = false;
		}
	}

	private void IJILOIAOKBF()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(false);
			hurtObj.SetActive(false);
		}
		else
		{
			hurtObj.SetActive(false);
			spriteObj.SetActive(true);
		}
	}

	private void NMPFHHEFOPH()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(true);
			hurtObj.SetActive(true);
		}
		else
		{
			hurtObj.SetActive(true);
			spriteObj.SetActive(false);
		}
	}

	public void IDCFPDJDFOF(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CutTree);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(992f, 1362f, 87f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = false;
		}
	}

	public void LNNDJOHOCKF(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.TalkWithGass);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(263f, 1345f, 1855f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = true;
		}
	}

	public void HJPMCBJDBIN(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CreateRoom);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1296f, 1666f, 1644f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = true;
		}
	}

	private void ONNAGOCFJML()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
		}
		else
		{
			hurtObj.SetActive(false);
			spriteObj.SetActive(false);
		}
	}

	public void ABGMCBMONKD(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.HarvestCrop);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1858f, 1155f, 1536f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = true;
		}
	}

	public void BGPCODGCHIK(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.TillEarth);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1063f, 1947f, 921f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = false;
		}
	}

	public void OPFCMMLMHGI(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CreateRoom);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1914f, 799f, 1547f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = true;
		}
	}

	public void PCFHCAIFMNB(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.PlantSeed);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(12f, 315f, 1186f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = true;
		}
	}

	public void EPKKDOGJADG(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CreateRoom);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1948f, 1877f, 1569f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = false;
		}
	}

	public void IKGGEJAFFND(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.PlantSeed);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(784f, 1254f, 1068f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = false;
		}
	}

	public void OHPDFMJLDNC(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.TalkWithGass);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(854f, 1438f, 632f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = false;
		}
	}

	private void MAIMGNMIFKG()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
		}
		else
		{
			hurtObj.SetActive(false);
			spriteObj.SetActive(true);
		}
	}

	private void BPNOIDBAPJE()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
		}
		else
		{
			hurtObj.SetActive(false);
			spriteObj.SetActive(false);
		}
	}

	public void KBOBIMDPOOL(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CreateRoom);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1427f, 1781f, 50f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = false;
		}
	}

	private void AGFLPEOOEAM()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(true);
			hurtObj.SetActive(true);
		}
		else
		{
			hurtObj.SetActive(true);
			spriteObj.SetActive(true);
		}
	}

	public void GMILOMABIJJ(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CutGrass);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1738f, 931f, 131f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = true;
		}
	}

	private void OIEJIBAPDMM()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
		}
		else
		{
			hurtObj.SetActive(false);
			spriteObj.SetActive(false);
		}
	}

	public void Hurt(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.SmashSnowman);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(0f, 0.1458333f, 0f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = true;
		}
	}

	private void OnEnable()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
		}
		else
		{
			hurtObj.SetActive(false);
			spriteObj.SetActive(true);
		}
	}

	public void FDKMDLKECCG(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CreateRoom);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1857f, 1389f, 608f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = true;
		}
	}

	public void DGAFDBNHDHF(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.TillEarth);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1563f, 1581f, 196f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = true;
		}
	}

	private void BJOOCKCBPLJ()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
		}
		else
		{
			hurtObj.SetActive(true);
			spriteObj.SetActive(false);
		}
	}

	private void LCJCGFNFBBD()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
		}
		else
		{
			hurtObj.SetActive(true);
			spriteObj.SetActive(false);
		}
	}

	public void FFPBILOCPLK(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.SmashSnowman);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(132f, 1975f, 656f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = true;
		}
	}

	private void DIJOBOFGCIK()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
		}
		else
		{
			hurtObj.SetActive(true);
			spriteObj.SetActive(false);
		}
	}

	public void GMBOBNBKJAD(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.ChopRock);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1278f, 108f, 385f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = false;
		}
	}

	public void GANNKCKHGGF(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CutTree);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1053f, 1617f, 1034f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = true;
		}
	}

	private void ANMOAFFGEOE()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
		}
		else
		{
			hurtObj.SetActive(false);
			spriteObj.SetActive(false);
		}
	}

	private void HCKMHIHALBL()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
		}
		else
		{
			hurtObj.SetActive(false);
			spriteObj.SetActive(false);
		}
	}

	public void BPHAFIBHJGL(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.PlantSeed);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(466f, 198f, 1657f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = false;
		}
	}

	public void BICDFBEOHPH(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CreateRoom);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(298f, 1765f, 399f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = false;
		}
	}

	public void NCOGKGCHDHB(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CutGrass);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1597f, 403f, 1070f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = true;
		}
	}

	private void FPJABCNDEEJ()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(false);
			hurtObj.SetActive(false);
		}
		else
		{
			hurtObj.SetActive(true);
			spriteObj.SetActive(false);
		}
	}

	public void FHIEDPNGPFA(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CutGrass);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1273f, 752f, 583f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = false;
		}
	}

	public void FCGFHHGMKNP(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.SmashSnowman);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1667f, 919f, 1938f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = false;
		}
	}

	public void MGEECEHJHLA(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CutTree);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(88f, 507f, 1994f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = true;
		}
	}

	public void EJBKJPPCGIL(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CreateRoom);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1174f, 1424f, 1187f), ((Component)this).transform.rotation);
			spriteObj.SetActive(true);
			hurtObj.SetActive(false);
			PPGPGLDBDJP = true;
		}
	}

	public void HNKKHBEKLAI(HitDetection NOCOHCGPMFF)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!PPGPGLDBDJP)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(NOCOHCGPMFF.playerNum, ActionDone.CutTree);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().snowmanSmash, ((Component)this).transform);
			Object.Instantiate<GameObject>(snowmanFx, ((Component)this).transform.position - new Vector3(1250f, 1536f, 1175f), ((Component)this).transform.rotation);
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
			PPGPGLDBDJP = true;
		}
	}

	private void PGDBFGFMGKI()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(true);
			hurtObj.SetActive(true);
		}
		else
		{
			hurtObj.SetActive(false);
			spriteObj.SetActive(true);
		}
	}

	private void LEPDLPEPEFD()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(false);
			hurtObj.SetActive(true);
		}
		else
		{
			hurtObj.SetActive(true);
			spriteObj.SetActive(true);
		}
	}

	private void AOJCCOIHPMH()
	{
		if (PPGPGLDBDJP)
		{
			spriteObj.SetActive(false);
			hurtObj.SetActive(false);
		}
		else
		{
			hurtObj.SetActive(false);
			spriteObj.SetActive(true);
		}
	}
}
