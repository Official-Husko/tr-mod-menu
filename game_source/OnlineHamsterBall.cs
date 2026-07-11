using Photon.Pun;
using UnityEngine;

public class OnlineHamsterBall : OnlineObject
{
	public Hamsterball hamsterball;

	[HideInInspector]
	public int actorNumber = -1;

	private float DCGBADKLANM;

	public bool HHPAOKIDACD()
	{
		if (actorNumber == -1 && OnlineManager.MasterOrOffline())
		{
			return true;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	public void DKPOMMPEKJF()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior)))
		{
			OnlineObjectsManager.instance.BPDDEKABKKM(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void ReceiveKick(float AINPJHKNJGL, int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		MLCDKGMNCMD(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.Kick(AINPJHKNJGL, CDPAMNIPPEC: false);
	}

	public void OHFNCLDPPFG(int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		LDKHBGOIFJM(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.BallTouch(CDPAMNIPPEC: true);
	}

	public void UpdateBallPosition()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.PetShop))
		{
			OnlineObjectsManager.instance.AddBallMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void NNHBGEOBBDD()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		DGEAMEKEIHD(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendBallTouch(uniqueId, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public void OILCAFHEKMF(float AINPJHKNJGL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		DGEAMEKEIHD(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendKick(uniqueId, AINPJHKNJGL, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public void PABDMHPJDHN()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(~(Location.Tavern | Location.Camp | Location.Farm | Location.BarnInterior)))
		{
			OnlineObjectsManager.instance.AddBallMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	protected void PBFGFECPPPO()
	{
		if (OnlineManager.PlayingOnline())
		{
			AddIfUniqueObject();
		}
	}

	private void GJLGPIKODLD(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.DHDLMCGIAAO();
		}
	}

	protected void KACEOJDPLKB()
	{
		if (OnlineManager.PlayingOnline())
		{
			JIDKFEFAIMH();
		}
	}

	protected void MFMMHDPGCBO()
	{
		if (OnlineManager.PlayingOnline())
		{
			AddIfUniqueObject();
		}
	}

	public void EMNMHFPPCGP(int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		GJLGPIKODLD(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.BallTouch(CDPAMNIPPEC: true);
	}

	public void BAGMCHNCHNB()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MGEOLDPHNLL(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.KEHDLCGIBGH(uniqueId, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public void FIKEAHOJIDN(float AINPJHKNJGL, int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		OJIAJPFOHPJ(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.Kick(AINPJHKNJGL, CDPAMNIPPEC: true);
	}

	protected virtual void FixedUpdate()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			if (actorNumber == PhotonNetwork.LocalPlayer.ActorNumber)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
				return;
			}
			DBEFBFPAOAA += Time.fixedDeltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			hamsterball.rb.MovePosition(Vector2.op_Implicit(Utils.EKCCGNEDPNO(Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM)), 1)));
		}
	}

	public void IDGIOHNLPKC(float AINPJHKNJGL, int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		BKDPPGMPBIN(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.Kick(AINPJHKNJGL, CDPAMNIPPEC: false);
	}

	public void CELIHABCMIK(float AINPJHKNJGL, int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		JFFLHCLNDNO(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.Kick(AINPJHKNJGL, CDPAMNIPPEC: true);
	}

	public void JIIJNHEPBFF()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(~(Location.Tavern | Location.River | Location.Quarry | Location.Farm)))
		{
			OnlineObjectsManager.instance.BPDDEKABKKM(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	protected void CFIIEJDJFPB()
	{
		if (OnlineManager.PlayingOnline())
		{
			AddIfUniqueObject();
		}
	}

	public void PMOPBDMECEG()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Tavern | Location.Road | Location.Camp | Location.BarnInterior))
		{
			OnlineObjectsManager.instance.BPDDEKABKKM(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void GINGMDJFHAM()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(~(Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm)))
		{
			OnlineObjectsManager.instance.AddBallMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void IPLCOLJKNLO(float AINPJHKNJGL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		AMIMFLPEPLC(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendKick(uniqueId, AINPJHKNJGL, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public void GFLBBCJNIEP(float AINPJHKNJGL, int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		BEBPBLCNKDP(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.Kick(AINPJHKNJGL, CDPAMNIPPEC: false);
	}

	protected virtual void MENCIOFBFIE()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			if (actorNumber == PhotonNetwork.LocalPlayer.ActorNumber)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
				return;
			}
			DBEFBFPAOAA += Time.fixedDeltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			hamsterball.rb.MovePosition(Vector2.op_Implicit(Utils.EKCCGNEDPNO(Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM)), 1)));
		}
	}

	protected void PFLBPMIEKGF()
	{
		if (OnlineManager.PlayingOnline())
		{
			AddIfUniqueObject();
		}
	}

	public void HPPIGMKAEHO(int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		GJLGPIKODLD(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.BallTouch(CDPAMNIPPEC: false);
	}

	public void OLPIGPFKEHJ(int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		GOCEKHJEEJP(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.BallTouch(CDPAMNIPPEC: true);
	}

	public void NIFNCBMJGIO(float AINPJHKNJGL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		GOCEKHJEEJP(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendKick(uniqueId, AINPJHKNJGL, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public void IKGIIICDIME()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Road | Location.Camp))
		{
			OnlineObjectsManager.instance.BPDDEKABKKM(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public bool AmIControllingThisHamsterball()
	{
		if (actorNumber == -1 && OnlineManager.MasterOrOffline())
		{
			return true;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	public void PBKEMAENBBP(int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		AMIMFLPEPLC(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.BallTouch(CDPAMNIPPEC: false);
	}

	private void OJIAJPFOHPJ(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.DHDLMCGIAAO();
		}
	}

	private void JFFLHCLNDNO(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.DHDLMCGIAAO();
		}
	}

	private void BKDPPGMPBIN(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.ClearMovingHamsters();
		}
	}

	public void SendKick(float AINPJHKNJGL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		MLCDKGMNCMD(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendKick(uniqueId, AINPJHKNJGL, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public void FEMIMKHECGC(float AINPJHKNJGL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		AMIMFLPEPLC(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendKick(uniqueId, AINPJHKNJGL, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public void OENGJHDENBE(float AINPJHKNJGL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		BEBPBLCNKDP(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendKick(uniqueId, AINPJHKNJGL, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	private void DGEAMEKEIHD(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.ClearMovingHamsters();
		}
	}

	public bool KFDEAGLHGBP()
	{
		if (actorNumber == -1 && OnlineManager.MasterOrOffline())
		{
			return true;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	public void LKBFEIEDGCP()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(~(Location.Road | Location.River | Location.Camp)))
		{
			OnlineObjectsManager.instance.BPDDEKABKKM(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void EKDAFGOOHFI()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		OJIAJPFOHPJ(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.KEHDLCGIBGH(uniqueId, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public bool CKCDLPKFCGM()
	{
		if (actorNumber == -1 && OnlineManager.MasterOrOffline())
		{
			return false;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	public void ReceiveBallTouch(int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		MLCDKGMNCMD(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.BallTouch(CDPAMNIPPEC: false);
	}

	private void MLCDKGMNCMD(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.ClearMovingHamsters();
		}
	}

	public void JJHFMEOFJBH(int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		BEBPBLCNKDP(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.BallTouch(CDPAMNIPPEC: false);
	}

	public void EOOEAPCHHJL(int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		LDKHBGOIFJM(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.BallTouch(CDPAMNIPPEC: false);
	}

	protected void IFHLGOMBACP()
	{
		if (OnlineManager.PlayingOnline())
		{
			KHGHLLJDFHD();
		}
	}

	private void BLONGMICIHH(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.ClearMovingHamsters();
		}
	}

	public void DCAAFCCPGBG()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MLCDKGMNCMD(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendBallTouch(uniqueId, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public bool GCMKJOCEHGP()
	{
		if (actorNumber == -1 && OnlineManager.MasterOrOffline())
		{
			return true;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	protected void FHEGBNMJADG()
	{
		if (OnlineManager.PlayingOnline())
		{
			AddIfUniqueObject();
		}
	}

	private void MGEOLDPHNLL(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.DHDLMCGIAAO();
		}
	}

	private void GOCEKHJEEJP(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.ClearMovingHamsters();
		}
	}

	public bool AGCOKCOFAJG()
	{
		if (actorNumber == -1 && OnlineManager.MasterOrOffline())
		{
			return false;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	protected virtual void ADJMGPNBDGF()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			if (actorNumber == PhotonNetwork.LocalPlayer.ActorNumber)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
				return;
			}
			DBEFBFPAOAA += Time.fixedDeltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			hamsterball.rb.MovePosition(Vector2.op_Implicit(Utils.EKCCGNEDPNO(Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM)), 0)));
		}
	}

	public void PDMGPLEENAN(float AINPJHKNJGL, int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		AMIMFLPEPLC(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.Kick(AINPJHKNJGL, CDPAMNIPPEC: false);
	}

	public void DKILJHIFPIB(float AINPJHKNJGL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		BLONGMICIHH(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendKick(uniqueId, AINPJHKNJGL, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public bool DJIHEOPNPCC()
	{
		if (actorNumber == -1 && OnlineManager.MasterOrOffline())
		{
			return false;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	protected void HJDLNCOAKIK()
	{
		if (OnlineManager.PlayingOnline())
		{
			JIDKFEFAIMH();
		}
	}

	protected virtual void OBJHHNMMCGF()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			if (actorNumber == PhotonNetwork.LocalPlayer.ActorNumber)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
				return;
			}
			DBEFBFPAOAA += Time.fixedDeltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			hamsterball.rb.MovePosition(Vector2.op_Implicit(Utils.EKCCGNEDPNO(Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM)), 1)));
		}
	}

	public bool JIOGOGGMCLP()
	{
		if (actorNumber == -1 && OnlineManager.MasterOrOffline())
		{
			return true;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	protected void JPHEOLEEAPB()
	{
		if (OnlineManager.PlayingOnline())
		{
			JIDKFEFAIMH();
		}
	}

	protected void IGIKNCOLCKL()
	{
		if (OnlineManager.PlayingOnline())
		{
			JIDKFEFAIMH();
		}
	}

	public void JEDMMNDPDNO()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(~(Location.Tavern | Location.River | Location.Quarry | Location.Farm | Location.FarmShop)))
		{
			OnlineObjectsManager.instance.BPDDEKABKKM(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	private void LDKHBGOIFJM(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.DHDLMCGIAAO();
		}
	}

	protected virtual void CLJBKGOGBII()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			if (actorNumber == PhotonNetwork.LocalPlayer.ActorNumber)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
				return;
			}
			DBEFBFPAOAA += Time.fixedDeltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			hamsterball.rb.MovePosition(Vector2.op_Implicit(Utils.EKCCGNEDPNO(Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM)), 1)));
		}
	}

	public void AAKEPOGJFKG(float AINPJHKNJGL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		DGEAMEKEIHD(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendKick(uniqueId, AINPJHKNJGL, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public bool HNDIOLHICEP()
	{
		if (actorNumber == -1 && OnlineManager.MasterOrOffline())
		{
			return false;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	public void KKMCGHFPINO(float AINPJHKNJGL, int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		MGEOLDPHNLL(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.Kick(AINPJHKNJGL, CDPAMNIPPEC: true);
	}

	private void AMIMFLPEPLC(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.ClearMovingHamsters();
		}
	}

	public void FPNLMMLOJJF(float AINPJHKNJGL, int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		JFFLHCLNDNO(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.Kick(AINPJHKNJGL, CDPAMNIPPEC: true);
	}

	public void JIEFOFMMFDD(int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		GJLGPIKODLD(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.BallTouch(CDPAMNIPPEC: false);
	}

	private void BEBPBLCNKDP(int MPMECNEJOMB)
	{
		actorNumber = MPMECNEJOMB;
		if (actorNumber != PhotonNetwork.LocalPlayer.ActorNumber)
		{
			OnlineObjectsManager.instance.DHDLMCGIAAO();
		}
	}

	public bool DKMAGPHJBBO()
	{
		if (actorNumber == -1 && OnlineManager.PGAGDFAEEFB())
		{
			return false;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	public void EOCLPGKBKOM(float AINPJHKNJGL, int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		BEBPBLCNKDP(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.Kick(AINPJHKNJGL, CDPAMNIPPEC: true);
	}

	public void HIIHLGBEJLA(int ECPOBCFJFIF, Vector2 EDGHIIIBLPJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		GOCEKHJEEJP(ECPOBCFJFIF);
		hamsterball.rb.position = EDGHIIIBLPJ;
		DBEFBFPAOAA = AFMFHCAHEFO;
		hamsterball.BallTouch(CDPAMNIPPEC: false);
	}

	public void SendBallTouch()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MLCDKGMNCMD(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendBallTouch(uniqueId, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}

	public bool EBALLEKHONA()
	{
		if (actorNumber == -1 && OnlineManager.MasterOrOffline())
		{
			return false;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	public bool CNOFEKKBAFC()
	{
		if (actorNumber == -1 && OnlineManager.MasterOrOffline())
		{
			return true;
		}
		return PhotonNetwork.LocalPlayer.ActorNumber == actorNumber;
	}

	protected void Start()
	{
		if (OnlineManager.PlayingOnline())
		{
			AddIfUniqueObject();
		}
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		Debug.Log((object)("Get Components " + ((Object)((Component)this).gameObject).name));
		hamsterball = ((Component)this).gameObject.GetComponent<Hamsterball>();
		hamsterball.onlineHamsterBall = this;
		uniqueObject = ((Component)hamsterball).GetComponent<UniqueObject>();
	}

	protected void LANGHIOBJIH()
	{
		if (OnlineManager.PlayingOnline())
		{
			KHGHLLJDFHD();
		}
	}

	public void PONGBOLGFBN()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior))
		{
			OnlineObjectsManager.instance.AddBallMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void LIKAKNKBGBA(float AINPJHKNJGL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		MLCDKGMNCMD(PhotonNetwork.LocalPlayer.ActorNumber);
		OnlineObjectsManager.instance.SendKick(uniqueId, AINPJHKNJGL, Vector2.op_Implicit(((Component)hamsterball).transform.position));
	}
}
