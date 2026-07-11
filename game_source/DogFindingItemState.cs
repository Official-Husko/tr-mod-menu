using UnityEngine;

public class DogFindingItemState : DogStateBase
{
	private bool actionDone;

	private void NHLDDKEFMDD()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: false);
		dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), CLLHBACAFOM, KPMCGMJJBEA, 430f, MFCMOOKEHMN: true);
		actionDone = false;
	}

	private void APGLLOHDPHO()
	{
		actionDone = false;
	}

	private void PHADIJFHHGD()
	{
		dogNPC.JINJODIENIN(DogState.FollowPlayer);
	}

	private void HMLFDDDGGBO()
	{
		actionDone = false;
	}

	private void MMMLGOMMHEL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.GIPAJJKDEJK(CDPAMNIPPEC: true);
		dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), JKJHDNOJLEO, EDDOIJHPBHM, 520f, MFCMOOKEHMN: false);
		actionDone = false;
	}

	private void FCPLKBGNAGF()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: false);
		dogNPC.CFJOGFDANJH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), KHKIJGICIFF, PBBBJBHFGNN, 1104f, MFCMOOKEHMN: false);
		actionDone = false;
	}

	private void FEHGALEDJKI()
	{
		actionDone = true;
	}

	private void HMNPBBDKJCD()
	{
		dogNPC.ChangeState(DogState.FollowPlayer);
	}

	private void JHJPHDEJLJO()
	{
		dogNPC.IHMEOKNMHIJ(DogState.IdleNearPlayer);
	}

	private void HPBFAMABJCK()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.JOECEIFKHAJ(CDPAMNIPPEC: true);
		dogNPC.StartWalking(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), HMNPBBDKJCD, GBDLGKNDBIK, 142f, MFCMOOKEHMN: true);
		actionDone = true;
	}

	private void MKJDIMFOGIA()
	{
		actionDone = true;
	}

	private void NPODJIPPJCA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.IODEEPJHFGG(CDPAMNIPPEC: true);
		dogNPC.IIAGOMMJLML(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), AFIBEMKCFAG, GBDLGKNDBIK, 1162f, MFCMOOKEHMN: false);
		actionDone = true;
	}

	private void ILJIKCMCAIF()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.IODEEPJHFGG(CDPAMNIPPEC: false);
		dogNPC.DHGFHNALOAH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), LLNADECIHMG, PKKNFNMFOON, 399f, MFCMOOKEHMN: true);
		actionDone = true;
	}

	private void CKGFIHKADBM()
	{
		actionDone = false;
	}

	private void AJOCLLDACGP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.PPOICOJBOCI(CDPAMNIPPEC: false);
		dogNPC.CFJOGFDANJH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), OLHIGLGMJBO, PKKNFNMFOON, 495f, MFCMOOKEHMN: true);
		actionDone = true;
	}

	private void KBCKFDDDEGE()
	{
		actionDone = true;
	}

	private void EGJLEIHNJGL()
	{
		dogNPC.GNCLBACINCA(DogState.IdleNearPlayer);
	}

	private void JKJHDNOJLEO()
	{
		dogNPC.GNCLBACINCA(DogState.IdleNearPlayer);
	}

	private void PNLCMEHGHMH()
	{
		dogNPC.GNCLBACINCA(DogState.IdleNearPlayer);
	}

	private void OLHIGLGMJBO()
	{
		dogNPC.CHFKPKDBIJL(DogState.FollowPlayer);
	}

	private void NMDFDLIPNPP()
	{
		dogNPC.GIIJKKALBEM(DogState.IdleNearPlayer);
	}

	private void DBKLPCJNNPL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BCLAMKGEKIO(CDPAMNIPPEC: true);
		dogNPC.CFJOGFDANJH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), GKLHGHEMCMB, FIKLNLMANCH, 1272f, MFCMOOKEHMN: false);
		actionDone = false;
	}

	public override void HMLMFDKLCCM()
	{
		if (!actionDone && dogNPC.walkTo.IIMEFNIECLI())
		{
			actionDone = true;
		}
		if (actionDone)
		{
			dogNPC.dogAnimation.DogAnimations(DogNPC.DogInteractionType.Dig);
		}
	}

	private void GNDAIOGMJDL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: true);
		dogNPC.StartWalking(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: true);
		actionDone = false;
	}

	private void GCNAPIKOOOE()
	{
		dogNPC.GIIJKKALBEM(DogState.FollowPlayer);
	}

	private void EKHEMIBOHLF()
	{
		dogNPC.IHMEOKNMHIJ(DogState.FollowPlayer);
	}

	private void KHKIJGICIFF()
	{
		dogNPC.JINJODIENIN(DogState.FollowPlayer);
	}

	private void FIKLNLMANCH()
	{
		actionDone = false;
	}

	private void LNBKMGAIDHD()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.GIPAJJKDEJK(CDPAMNIPPEC: false);
		dogNPC.IIAGOMMJLML(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), FFEIDFCNAMA, MAILEMECPME, 896f, MFCMOOKEHMN: false);
		actionDone = false;
	}

	private void IJKIFECCGEP()
	{
		actionDone = false;
	}

	private void EJPFGEHOKPK()
	{
		actionDone = true;
	}

	private void JFKIMFNGCJA()
	{
		dogNPC.ChangeState(DogState.FollowPlayer);
	}

	private void CLLHBACAFOM()
	{
		dogNPC.ChangeState(DogState.FollowPlayer);
	}

	private void PBBBJBHFGNN()
	{
		actionDone = false;
	}

	private void POBNIHMOLKC()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.JOECEIFKHAJ(CDPAMNIPPEC: false);
		dogNPC.CFJOGFDANJH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), HMNPBBDKJCD, FIKLNLMANCH, 234f, MFCMOOKEHMN: false);
		actionDone = false;
	}

	private void FNJODLOADKA()
	{
		actionDone = false;
	}

	private void EJFEJIIKJNL()
	{
		dogNPC.JINJODIENIN(DogState.FollowPlayer);
	}

	private void MBFHAMKHGEF()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.PPOICOJBOCI(CDPAMNIPPEC: false);
		dogNPC.DHGFHNALOAH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), EKHEMIBOHLF, MAILEMECPME, 51f, MFCMOOKEHMN: true);
		actionDone = true;
	}

	private void PKKNFNMFOON()
	{
		actionDone = false;
	}

	private void JFFFKIBMMEG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BCLAMKGEKIO(CDPAMNIPPEC: false);
		dogNPC.IIAGOMMJLML(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), PHADIJFHHGD, FEHGALEDJKI, 60f, MFCMOOKEHMN: true);
		actionDone = true;
	}

	private void EDIKIMAJLEO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.GDCFJNFPMGE(CDPAMNIPPEC: true);
		dogNPC.IIAGOMMJLML(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), EGJLEIHNJGL, PBBBJBHFGNN, 898f, MFCMOOKEHMN: true);
		actionDone = false;
	}

	private void LLNADECIHMG()
	{
		dogNPC.CHFKPKDBIJL(DogState.IdleNearPlayer);
	}

	private void AFIBEMKCFAG()
	{
		dogNPC.JINJODIENIN(DogState.IdleNearPlayer);
	}

	private void BPHGBLICJAF()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.IODEEPJHFGG(CDPAMNIPPEC: false);
		dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), JKJHDNOJLEO, FIKLNLMANCH, 704f, MFCMOOKEHMN: false);
		actionDone = true;
	}

	private void NNBPENENIIC()
	{
		dogNPC.ChangeState(DogState.FollowPlayer);
	}

	private void FFEIDFCNAMA()
	{
		dogNPC.GNCLBACINCA(DogState.FollowPlayer);
	}

	private void IHINKOIKJKI()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.IODEEPJHFGG(CDPAMNIPPEC: true);
		dogNPC.StartWalking(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), FFEIDFCNAMA, KBCKFDDDEGE, 652f, MFCMOOKEHMN: true);
		actionDone = true;
	}

	private void LPCOADBOKED()
	{
		dogNPC.ChangeState(DogState.FollowPlayer);
	}

	private void PDOBHPLPKHG()
	{
		actionDone = true;
	}

	private void DCGPJAMJBGC()
	{
		dogNPC.CHFKPKDBIJL(DogState.IdleNearPlayer);
	}

	private void AIOKBGJLDNE()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BJGOFPBMCME(CDPAMNIPPEC: true);
		dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), AFIBEMKCFAG, IJKIFECCGEP, 1849f, MFCMOOKEHMN: true);
		actionDone = false;
	}

	private void GIOCOKJJADI()
	{
		dogNPC.GIIJKKALBEM(DogState.FollowPlayer);
	}

	private void BEEDFJOOPAH()
	{
		actionDone = true;
	}

	private void OOGHMIJDJDP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: true);
		dogNPC.CFJOGFDANJH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), JHJPHDEJLJO, FNJODLOADKA, 1680f, MFCMOOKEHMN: false);
		actionDone = true;
	}

	private void ALDAHNKKOGE()
	{
		actionDone = true;
	}

	private void EDDFAALFNGB()
	{
		actionDone = false;
	}

	private void NNKAENANDMH()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BCLAMKGEKIO(CDPAMNIPPEC: false);
		dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), EKHEMIBOHLF, CKGFIHKADBM, 674f, MFCMOOKEHMN: false);
		actionDone = true;
	}

	private void CLKIHFCLOOE()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: false);
		dogNPC.DHGFHNALOAH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), GIOCOKJJADI, MKJDIMFOGIA, 1079f, MFCMOOKEHMN: false);
		actionDone = true;
	}

	private void GBDLGKNDBIK()
	{
		actionDone = true;
	}

	private void NHLNGJHGBCC()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: true);
		dogNPC.DHGFHNALOAH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), NMDFDLIPNPP, PBBBJBHFGNN, 582f, MFCMOOKEHMN: true);
		actionDone = false;
	}

	private void GKLHGHEMCMB()
	{
		dogNPC.IHMEOKNMHIJ(DogState.FollowPlayer);
	}

	private void BBALKNNPABJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: true);
		dogNPC.IIAGOMMJLML(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), JHJPHDEJLJO, GBDLGKNDBIK, 1539f, MFCMOOKEHMN: true);
		actionDone = false;
	}

	private void JLGBPBDMHJA()
	{
		dogNPC.GIIJKKALBEM(DogState.FollowPlayer);
	}

	private void LBELGDFFBGL()
	{
		dogNPC.CHFKPKDBIJL(DogState.FollowPlayer);
	}

	private void KMFMHKIPDAL()
	{
		actionDone = false;
	}

	private void MCKJBIGHLED()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.JOECEIFKHAJ(CDPAMNIPPEC: false);
		dogNPC.IIAGOMMJLML(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), PHADIJFHHGD, APGLLOHDPHO, 668f, MFCMOOKEHMN: false);
		actionDone = false;
	}

	private void JKFFEJHENMO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BJGOFPBMCME(CDPAMNIPPEC: true);
		dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), LPCOADBOKED, HMLFDDDGGBO, 1718f, MFCMOOKEHMN: false);
		actionDone = false;
	}

	private void KEIDPJAMLLN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: true);
		dogNPC.DHGFHNALOAH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), JFKIMFNGCJA, MAILEMECPME, 1439f, MFCMOOKEHMN: true);
		actionDone = true;
	}

	private void MAILEMECPME()
	{
		actionDone = true;
	}

	private void JPPBLECEEMP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.IODEEPJHFGG(CDPAMNIPPEC: false);
		dogNPC.CFJOGFDANJH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), DCGPJAMJBGC, MAILEMECPME, 1481f, MFCMOOKEHMN: true);
		actionDone = false;
	}

	private void LOBEIHFMKHA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.JOECEIFKHAJ(CDPAMNIPPEC: false);
		dogNPC.CFJOGFDANJH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), LBELGDFFBGL, PDOBHPLPKHG, 1399f, MFCMOOKEHMN: false);
		actionDone = true;
	}

	private void KPMCGMJJBEA()
	{
		actionDone = false;
	}

	private void BAMPHNJNPMG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.GDCFJNFPMGE(CDPAMNIPPEC: true);
		dogNPC.CFJOGFDANJH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), PNLCMEHGHMH, FEHGALEDJKI, 912f, MFCMOOKEHMN: true);
		actionDone = true;
	}

	private void IEJGDOPLBLB()
	{
		actionDone = false;
	}

	private void EDDOIJHPBHM()
	{
		actionDone = false;
	}

	private void BIBLAPBMLIG()
	{
		dogNPC.JINJODIENIN(DogState.FollowPlayer);
	}

	private void HDFALEFINJG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.GDCFJNFPMGE(CDPAMNIPPEC: true);
		dogNPC.DHGFHNALOAH(Vector2.op_Implicit(((Component)dogNPC.currentDogHole).transform.position), BIBLAPBMLIG, PBBBJBHFGNN, 1013f, MFCMOOKEHMN: true);
		actionDone = true;
	}

	private void GOPIJNFDCME()
	{
		actionDone = true;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		GNDAIOGMJDL();
	}
}
