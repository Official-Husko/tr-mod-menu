using AlmenaraGames;
using UnityEngine;

public class ChessPillarInteractable : MonoBehaviour, IProximity, IHoverable, IInteractable, ISelectable
{
	[Header("Visual")]
	[SerializeField]
	private ChessPillarSegmentAnimator topAnimator;

	[SerializeField]
	private ChessPillarSegmentAnimator midAnimator;

	[SerializeField]
	private ChessPillarSegmentAnimator botAnimator;

	[Header("Labels")]
	[SerializeField]
	private string labelTop = "ChangeTop";

	[SerializeField]
	private string labelMid = "ChangeMid";

	[SerializeField]
	private string labelBottom = "ChangeBottom";

	[SerializeField]
	private AudioObject rotatingSound;

	private MineChessPillarPuzzle ONCCKDONEFG;

	public bool GBELEBJJDIN(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EJCBPHEKCLC(int JIIGOACEIKL)
	{
		if (!OBDFGODGIFN(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.IFMCAEBOJGD(JIIGOACEIKL, 1, CDPAMNIPPEC: false);
		return true;
	}

	public bool PGGAIFNKIBO(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.PIJKBBCAJON() && !DDNNIMGLIGI())
		{
			return DecorationMode.GetPlayer(JIIGOACEIKL).GABNNLJOMHI();
		}
		return true;
	}

	public bool EPIGICPGDOE(int JIIGOACEIKL)
	{
		ONCCKDONEFG.AHAPPDLCMHC(JIIGOACEIKL, 1);
		return false;
	}

	public void MIMGPIANHNJ(MineChessPillarPuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool AGJPLNCFBCF(int JIIGOACEIKL)
	{
		ONCCKDONEFG.FCFFDCOAOBC(JIIGOACEIKL, 1);
		return false;
	}

	public bool KMEJOPAKIJM(int JIIGOACEIKL)
	{
		if (!OBDFGODGIFN(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.FCFFDCOAOBC(JIIGOACEIKL, 1);
		return false;
	}

	public void FKKPKAFDOIJ(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && PlayerInputs.GetPlayer(JIIGOACEIKL).KFAFNEJNDDL("AceT_Quest"))
		{
			ONCCKDONEFG.FCFFDCOAOBC(JIIGOACEIKL, 0);
		}
	}

	public bool LJCFJIOBDLD(int JIIGOACEIKL)
	{
		ONCCKDONEFG.HDPFNDHAGHC(JIIGOACEIKL, 0, CDPAMNIPPEC: false);
		return true;
	}

	public bool KLLBNFOLHKI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!PGGAIFNKIBO(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get(labelTop));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(labelMid));
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(labelBottom));
		return true;
	}

	public bool JCCFAFPMGFI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!PGBPDAODKDL(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get(labelTop));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(labelMid));
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(labelBottom));
		return false;
	}

	public void DJODLMDOBOH(int JIIGOACEIKL)
	{
		if (PGBPDAODKDL(JIIGOACEIKL) && PlayerInputs.GetPlayer(JIIGOACEIKL).ALPHFOIMNIA("<br/>Graphics Shader Level: "))
		{
			ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 8, CDPAMNIPPEC: false);
		}
	}

	private bool AMCBIGLJAGF()
	{
		if (!topAnimator.FMLCCBIJBOI() && !midAnimator.DMDKHJIBHCC())
		{
			return botAnimator.KGDLEADHOAA();
		}
		return false;
	}

	public void AHMDCJIHGPK(ChessPieceType[] DGCONJOFNEL)
	{
		topAnimator.KDPCNPIJCMH(DGCONJOFNEL[1]);
		midAnimator.KDPCNPIJCMH(DGCONJOFNEL[0]);
		botAnimator.SetInitialPiece(DGCONJOFNEL[7]);
	}

	public bool Select(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 0);
		return false;
	}

	public bool OBDFGODGIFN(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.APPEDHAFFBP() && !MDPPINBONFF())
		{
			return DecorationMode.KKJABELKCNM(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return false;
	}

	public void EJJOGBGFAPP(int JIIGOACEIKL)
	{
	}

	public bool FACGEEJCMEC(int JIIGOACEIKL)
	{
		ONCCKDONEFG.IFMCAEBOJGD(JIIGOACEIKL, 0);
		return false;
	}

	public bool KJAAAGCKDFD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!OBDFGODGIFN(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get(labelTop));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(labelMid));
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get(labelBottom));
		return true;
	}

	private bool PLADCIEAOGO()
	{
		if (!topAnimator.KGDLEADHOAA() && !midAnimator.GKNOGNBNOFM)
		{
			return botAnimator.BAOCNFDHPKF();
		}
		return false;
	}

	public bool MDOKMENGIGJ(int JIIGOACEIKL)
	{
		ONCCKDONEFG.FLLAKENMLLI(JIIGOACEIKL, 1);
		return true;
	}

	public void NAAMONCFKMB(MineChessPillarPuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool EOGGOJDMAEB(int JIIGOACEIKL)
	{
		ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 1);
		return false;
	}

	public bool FLOJCBDNEPK(int JIIGOACEIKL)
	{
		ONCCKDONEFG.FCFFDCOAOBC(JIIGOACEIKL, 0, CDPAMNIPPEC: false);
		return false;
	}

	public bool FOFNFPIJKMI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!PGGAIFNKIBO(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get(labelTop));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(labelMid));
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.NextItem, LocalisationSystem.Get(labelBottom));
		return true;
	}

	private bool MGHJBALMNGF()
	{
		if (!topAnimator.BAOCNFDHPKF() && !midAnimator.KGDLEADHOAA())
		{
			return botAnimator.DMDKHJIBHCC();
		}
		return false;
	}

	public void PLCKGMKINKG(int JIIGOACEIKL)
	{
	}

	public void PEOILAGPJNB(int JIIGOACEIKL)
	{
		if (PGBPDAODKDL(JIIGOACEIKL) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LKOGGHNGBKD("Duplicate shop id found: "))
		{
			ONCCKDONEFG.ICINLLNENHM(JIIGOACEIKL, 3, CDPAMNIPPEC: false);
		}
	}

	public bool NPAEHHHLBBM(int JIIGOACEIKL)
	{
		return false;
	}

	public void PIEPKEHAPII(int JIIGOACEIKL)
	{
	}

	public void EANLEFNBGKL(MineChessPillarPuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
	}

	public bool MEKJDKLEMEC(int JIIGOACEIKL)
	{
		if (!PGGAIFNKIBO(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.IFMCAEBOJGD(JIIGOACEIKL, 0);
		return true;
	}

	public void FOHLKFBMGOP(MineChessPillarPuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
	}

	public bool MMDECMPNLIL(int JIIGOACEIKL)
	{
		if (!PGBPDAODKDL(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.AHAPPDLCMHC(JIIGOACEIKL, 0);
		return true;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void GJFFCALHIEA(int JIIGOACEIKL)
	{
	}

	public void ACGNGMLCCMA(int DOGONNHJIOF, ChessPieceType FLMCIFNEJKH)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		object obj = DOGONNHJIOF switch
		{
			0 => topAnimator, 
			1 => midAnimator, 
			2 => botAnimator, 
			_ => null, 
		};
		if ((Object)(object)rotatingSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(rotatingSound, ((Component)this).transform.position);
		}
		((ChessPillarSegmentAnimator)obj)?.MNKHDGPLLCI(FLMCIFNEJKH);
	}

	public bool EIPHBAHILIF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!MAEPPEIGMNI(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get(labelTop));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(labelMid));
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get(labelBottom));
		return false;
	}

	public void EJDLBJGJAAN(int JIIGOACEIKL)
	{
	}

	public bool PHOKDJNJDPI(int JIIGOACEIKL)
	{
		return true;
	}

	public bool GDFKHBMAFHE(int JIIGOACEIKL)
	{
		ONCCKDONEFG.AHAPPDLCMHC(JIIGOACEIKL, 0);
		return false;
	}

	public void NDJCAFBKCIL(int JIIGOACEIKL)
	{
	}

	public bool HMEKGMOLBPA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void HIAFCHPNJLK(ChessPieceType[] DGCONJOFNEL)
	{
		topAnimator.CGCPKJHNGDB(DGCONJOFNEL[0]);
		midAnimator.CGCPKJHNGDB(DGCONJOFNEL[1]);
		botAnimator.IHEDPINIOMM(DGCONJOFNEL[7]);
	}

	public bool LIDJEBPBDAH(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.HKAOHMPIAHC() && !DDNNIMGLIGI())
		{
			return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return true;
	}

	private bool MDPPINBONFF()
	{
		if (!topAnimator.FMLCCBIJBOI() && !midAnimator.BAOCNFDHPKF())
		{
			return botAnimator.GKNOGNBNOFM;
		}
		return true;
	}

	public bool KPMGMIBPGEF(int JIIGOACEIKL)
	{
		ONCCKDONEFG.AHAPPDLCMHC(JIIGOACEIKL, 1);
		return true;
	}

	public void InitializeVisuals(ChessPieceType[] DGCONJOFNEL)
	{
		topAnimator.SetInitialPiece(DGCONJOFNEL[0]);
		midAnimator.SetInitialPiece(DGCONJOFNEL[1]);
		botAnimator.SetInitialPiece(DGCONJOFNEL[2]);
	}

	public bool IPCLAJNIOLI(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PLGPABMFEKK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		return false;
	}

	public void CEDDOKBCHAI(int JIIGOACEIKL)
	{
	}

	public void NKOJGNCMFJK(int DOGONNHJIOF, ChessPieceType FLMCIFNEJKH)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		object obj = DOGONNHJIOF switch
		{
			0 => topAnimator, 
			1 => midAnimator, 
			2 => botAnimator, 
			_ => null, 
		};
		if ((Object)(object)rotatingSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(rotatingSound, ((Component)this).transform.position);
		}
		((ChessPillarSegmentAnimator)obj)?.CGFCLFOIEFP(FLMCIFNEJKH);
	}

	public void IJBBCBKBNAN(MineChessPillarPuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
	}

	public void PLGDHFDAKOI(MineChessPillarPuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
	}

	public void EFCFFEOMJDI(int JIIGOACEIKL)
	{
	}

	public void IPEEHGAKHPP(MineChessPillarPuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
	}

	public bool JJNCCBKOBOD(int JIIGOACEIKL)
	{
		return true;
	}

	public void ODLBJAGGAFM(int JIIGOACEIKL)
	{
		if (MAEPPEIGMNI(JIIGOACEIKL) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LKOGGHNGBKD("City/Rhia/Introduce"))
		{
			ONCCKDONEFG.FCFFDCOAOBC(JIIGOACEIKL, 2, CDPAMNIPPEC: false);
		}
	}

	public void DFFCCILMAHN(int JIIGOACEIKL)
	{
		if (JGDDHIEJPMH(JIIGOACEIKL) && PlayerInputs.GetPlayer(JIIGOACEIKL).ALPHFOIMNIA("Close"))
		{
			ONCCKDONEFG.FCFFDCOAOBC(JIIGOACEIKL, 4, CDPAMNIPPEC: false);
		}
	}

	public bool IBMMEBJBHOE(int JIIGOACEIKL)
	{
		if (!PLAKEEACNIE(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.FCFFDCOAOBC(JIIGOACEIKL, 0);
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 1, CDPAMNIPPEC: false);
		return true;
	}

	public bool GGLKCAFNFOB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CIAMOMDAKLJ(int JIIGOACEIKL)
	{
		return false;
	}

	public void DKANOGHJOEE(ChessPieceType[] DGCONJOFNEL)
	{
		topAnimator.SetInitialPiece(DGCONJOFNEL[1]);
		midAnimator.KDPCNPIJCMH(DGCONJOFNEL[0]);
		botAnimator.CGCPKJHNGDB(DGCONJOFNEL[3]);
	}

	public bool LDAGOHPIGNA(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 1);
		return true;
	}

	public bool BEBIPNCCEMH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!LIDJEBPBDAH(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.NextItem, LocalisationSystem.Get(labelTop));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(labelMid));
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get(labelBottom));
		return true;
	}

	public bool AGFFGBEPDNP(int JIIGOACEIKL)
	{
		ONCCKDONEFG.IFMCAEBOJGD(JIIGOACEIKL, 0);
		return true;
	}

	public bool CMPCHBMGLKI(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EHFNNOCENEL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool FAMALNLMJPP(int JIIGOACEIKL)
	{
		ONCCKDONEFG.IFMCAEBOJGD(JIIGOACEIKL, 0, CDPAMNIPPEC: false);
		return true;
	}

	public bool OFLILJIAJMB(int JIIGOACEIKL)
	{
		return true;
	}

	private bool PEIIKGHLLJP()
	{
		if (!topAnimator.DMDKHJIBHCC() && !midAnimator.GKNOGNBNOFM)
		{
			return botAnimator.KGDLEADHOAA();
		}
		return true;
	}

	public bool NHGDAEOPGOG(int JIIGOACEIKL)
	{
		return false;
	}

	public void IMFDDHFICNF(int JIIGOACEIKL)
	{
		if (PGBPDAODKDL(JIIGOACEIKL) && PlayerInputs.GetPlayer(JIIGOACEIKL).ALPHFOIMNIA("CliveProgress"))
		{
			ONCCKDONEFG.AHAPPDLCMHC(JIIGOACEIKL, 2);
		}
	}

	public bool LEFHAOJHCBH(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.HGBOPAKJNHJ() && !PLADCIEAOGO())
		{
			return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return false;
	}

	private bool DKFLONIFGFN()
	{
		if (!topAnimator.DMDKHJIBHCC() && !midAnimator.KGDLEADHOAA())
		{
			return botAnimator.GKNOGNBNOFM;
		}
		return false;
	}

	public void FGHDPBIPEIH(int DOGONNHJIOF, ChessPieceType FLMCIFNEJKH)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		object obj = DOGONNHJIOF switch
		{
			0 => topAnimator, 
			1 => midAnimator, 
			2 => botAnimator, 
			_ => null, 
		};
		if ((Object)(object)rotatingSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(rotatingSound, ((Component)this).transform.position);
		}
		((ChessPillarSegmentAnimator)obj)?.NEHIBGELEMI(FLMCIFNEJKH);
	}

	public void AOFPMOPONPH(int JIIGOACEIKL)
	{
		if (LIDJEBPBDAH(JIIGOACEIKL) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonUp("Fireplace not attached on OnlineFireplace of placeable "))
		{
			ONCCKDONEFG.IFMCAEBOJGD(JIIGOACEIKL, 0);
		}
	}

	public void BIMOGGCLINL(int DOGONNHJIOF, ChessPieceType FLMCIFNEJKH)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		object obj = DOGONNHJIOF switch
		{
			0 => topAnimator, 
			1 => midAnimator, 
			2 => botAnimator, 
			_ => null, 
		};
		if ((Object)(object)rotatingSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(rotatingSound, ((Component)this).transform.position);
		}
		((ChessPillarSegmentAnimator)obj)?.NEHIBGELEMI(FLMCIFNEJKH);
	}

	public bool FKJKOBMJNGO(int JIIGOACEIKL)
	{
		return true;
	}

	public void ALGANHMGHDK(ChessPieceType[] DGCONJOFNEL)
	{
		topAnimator.SetInitialPiece(DGCONJOFNEL[0]);
		midAnimator.KDPCNPIJCMH(DGCONJOFNEL[0]);
		botAnimator.SetInitialPiece(DGCONJOFNEL[5]);
	}

	public void FFDBDLAPEGB(int DOGONNHJIOF, ChessPieceType FLMCIFNEJKH)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		object obj = DOGONNHJIOF switch
		{
			0 => topAnimator, 
			1 => midAnimator, 
			2 => botAnimator, 
			_ => null, 
		};
		if ((Object)(object)rotatingSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(rotatingSound, ((Component)this).transform.position);
		}
		((ChessPillarSegmentAnimator)obj)?.NEHIBGELEMI(FLMCIFNEJKH);
	}

	public bool JDBDJCDEEKJ(int JIIGOACEIKL)
	{
		if (!PGBPDAODKDL(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.ICINLLNENHM(JIIGOACEIKL, 1, CDPAMNIPPEC: false);
		return true;
	}

	public bool JGDDHIEJPMH(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.DDCOMOHHEBB() && !MDPPINBONFF())
		{
			return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return false;
	}

	public void PLKFEPAHAEK(int JIIGOACEIKL)
	{
	}

	public void CDKKOGBHJBN(ChessPieceType[] DGCONJOFNEL)
	{
		topAnimator.KDPCNPIJCMH(DGCONJOFNEL[1]);
		midAnimator.CGCPKJHNGDB(DGCONJOFNEL[0]);
		botAnimator.IHEDPINIOMM(DGCONJOFNEL[5]);
	}

	public void CPMPLAKLIEC(MineChessPillarPuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
	}

	public bool PLAKEEACNIE(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.MDPKONCJHBI() && !PLADCIEAOGO())
		{
			return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IBEFDKHFBFM();
		}
		return false;
	}

	public bool ONMFMJGODIM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!PLAKEEACNIE(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PrevNext, LocalisationSystem.Get(labelTop));
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(labelMid));
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get(labelBottom));
		return false;
	}

	public void JJELBOKLMLB(int JIIGOACEIKL)
	{
	}

	public void IILCHLHOPBF(int JIIGOACEIKL)
	{
	}

	public void GJHNAMEIFLI(int JIIGOACEIKL)
	{
	}

	public void DNNDDGDPPPM(int JIIGOACEIKL)
	{
	}

	public bool FCLHFAJMLBO(int JIIGOACEIKL)
	{
		if (!LEFHAOJHCBH(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 0, CDPAMNIPPEC: false);
		return true;
	}

	private bool MCDHBDFLMOE()
	{
		if (!topAnimator.KGDLEADHOAA() && !midAnimator.DMDKHJIBHCC())
		{
			return botAnimator.DMDKHJIBHCC();
		}
		return true;
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public void GHLJPCOIADF(int JIIGOACEIKL)
	{
	}

	public bool ONAOLIEIMHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool NBAOALGLFLG(int JIIGOACEIKL)
	{
		return false;
	}

	public void NDCCGOLPIED(int DOGONNHJIOF, ChessPieceType FLMCIFNEJKH)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		object obj = DOGONNHJIOF switch
		{
			0 => topAnimator, 
			1 => midAnimator, 
			2 => botAnimator, 
			_ => null, 
		};
		if ((Object)(object)rotatingSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(rotatingSound, ((Component)this).transform.position);
		}
		((ChessPillarSegmentAnimator)obj)?.PlayTransition(FLMCIFNEJKH);
	}

	public bool PLJHIFHNOBD(int JIIGOACEIKL)
	{
		return false;
	}

	private bool BNMDNBFFLJO()
	{
		if (!topAnimator.GKNOGNBNOFM && !midAnimator.GKNOGNBNOFM)
		{
			return botAnimator.GKNOGNBNOFM;
		}
		return true;
	}

	public bool FCCIIBFDFKO(int JIIGOACEIKL)
	{
		return true;
	}

	public bool JGMHLOOOAEN(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.MDPKONCJHBI() && !AMCBIGLJAGF())
		{
			return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND();
		}
		return true;
	}

	public bool ADPCMNFDKNI(int JIIGOACEIKL)
	{
		ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 0, CDPAMNIPPEC: false);
		return false;
	}

	public bool KNOAMKONOOP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool PGBPDAODKDL(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.MDPKONCJHBI() && !DDNNIMGLIGI())
		{
			return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return true;
	}

	public void CJOLCLDGFMB(int JIIGOACEIKL)
	{
	}

	public void Initialize(MineChessPillarPuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
	}

	public bool NIJAOPABLBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!OBDFGODGIFN(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get(labelTop));
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(labelMid));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get(labelBottom));
		return true;
	}

	public bool JAKBCLGIIJO(int JIIGOACEIKL)
	{
		if (!PLAKEEACNIE(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.FLLAKENMLLI(JIIGOACEIKL, 0, CDPAMNIPPEC: false);
		return true;
	}

	public bool KCDBIMPMGON(int JIIGOACEIKL)
	{
		if (!MAEPPEIGMNI(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.AHAPPDLCMHC(JIIGOACEIKL, 1, CDPAMNIPPEC: false);
		return false;
	}

	public bool ODMCEIBDMJP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!JGMHLOOOAEN(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PrevNext, LocalisationSystem.Get(labelTop));
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(labelMid));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get(labelBottom));
		return false;
	}

	private bool DDNNIMGLIGI()
	{
		if (!topAnimator.DMDKHJIBHCC() && !midAnimator.KGDLEADHOAA())
		{
			return botAnimator.GKNOGNBNOFM;
		}
		return true;
	}

	public bool NJPFHBINPKE(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MAEPPEIGMNI(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.PIJKBBCAJON() && !PLADCIEAOGO())
		{
			return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return true;
	}

	public bool FEEGKDKHJOE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool NCDNGJMMEDG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!PGGAIFNKIBO(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.PrevNext, LocalisationSystem.Get(labelTop));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(labelMid));
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get(labelBottom));
		return true;
	}

	public bool FNFLFAIMACE(int JIIGOACEIKL)
	{
		return false;
	}

	public bool JHJFAKBEMAE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!LIDJEBPBDAH(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.NextItem, LocalisationSystem.Get(labelTop));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(labelMid));
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get(labelBottom));
		return false;
	}

	public void AHJKKEMFNCM(int JIIGOACEIKL)
	{
		if (MAEPPEIGMNI(JIIGOACEIKL) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).KFAFNEJNDDL("Quit to desktop?"))
		{
			ONCCKDONEFG.FLLAKENMLLI(JIIGOACEIKL, 0);
		}
	}

	public void KDHOEPHOIJB(MineChessPillarPuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
	}

	public void NMPNLEAAJNM(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG != (Object)null && !ONCCKDONEFG.IsPuzzleSolved() && !BNMDNBFFLJO())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool NHHDNHLKADK(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MCPGDCCHEHM(int JIIGOACEIKL)
	{
		if (!OBDFGODGIFN(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.IFMCAEBOJGD(JIIGOACEIKL, 1);
		return false;
	}

	public bool IJNMMFDHDJC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void KABPEFFBKIC(ChessPieceType[] DGCONJOFNEL)
	{
		topAnimator.CGCPKJHNGDB(DGCONJOFNEL[0]);
		midAnimator.SetInitialPiece(DGCONJOFNEL[0]);
		botAnimator.SetInitialPiece(DGCONJOFNEL[3]);
	}

	public void AOMEFKOJDLL(int JIIGOACEIKL)
	{
	}

	public bool OOLNLKPJIML(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.IFMCAEBOJGD(JIIGOACEIKL, 0, CDPAMNIPPEC: false);
		return true;
	}

	public void DCBLHLOFPMK(int JIIGOACEIKL)
	{
	}

	private bool NFNADMDJBAB()
	{
		if (!topAnimator.KGDLEADHOAA() && !midAnimator.FMLCCBIJBOI())
		{
			return botAnimator.BAOCNFDHPKF();
		}
		return true;
	}

	public void NEINIEFIGFO(ChessPieceType[] DGCONJOFNEL)
	{
		topAnimator.CGCPKJHNGDB(DGCONJOFNEL[0]);
		midAnimator.CGCPKJHNGDB(DGCONJOFNEL[1]);
		botAnimator.CGCPKJHNGDB(DGCONJOFNEL[6]);
	}

	public bool DOFKECGCCAJ(int JIIGOACEIKL)
	{
		if (!PGGAIFNKIBO(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.AHAPPDLCMHC(JIIGOACEIKL, 1, CDPAMNIPPEC: false);
		return false;
	}

	public bool AHJGDENBOJL(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.AHAPPDLCMHC(JIIGOACEIKL, 1, CDPAMNIPPEC: false);
		return false;
	}

	public void RefreshVisual(int DOGONNHJIOF, ChessPieceType FLMCIFNEJKH)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		object obj = DOGONNHJIOF switch
		{
			0 => topAnimator, 
			1 => midAnimator, 
			2 => botAnimator, 
			_ => null, 
		};
		if ((Object)(object)rotatingSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(rotatingSound, ((Component)this).transform.position);
		}
		((ChessPillarSegmentAnimator)obj)?.PlayTransition(FLMCIFNEJKH);
	}

	public void BNPNIKKPICE(int JIIGOACEIKL)
	{
		if (OBDFGODGIFN(JIIGOACEIKL) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("ReceiveStackContainer"))
		{
			ONCCKDONEFG.ICINLLNENHM(JIIGOACEIKL, 6);
		}
	}

	public bool DMFBDCCJKMD(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.FCFFDCOAOBC(JIIGOACEIKL, 0);
		return false;
	}

	public bool FNJHKKPGJFC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void HFFHJBLMGAB(int JIIGOACEIKL)
	{
		if (JGMHLOOOAEN(JIIGOACEIKL) && PlayerInputs.GetPlayer(JIIGOACEIKL).ALPHFOIMNIA("Dialogue System/Conversation/BirdCatInteraction/Entry/5/Dialogue Text"))
		{
			ONCCKDONEFG.FCFFDCOAOBC(JIIGOACEIKL, 5);
		}
	}

	public bool JHHLEFJFDCM(int JIIGOACEIKL)
	{
		ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 1, CDPAMNIPPEC: false);
		return false;
	}

	public void MCMNFPEIFOF(int DOGONNHJIOF, ChessPieceType FLMCIFNEJKH)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		object obj = DOGONNHJIOF switch
		{
			0 => topAnimator, 
			1 => midAnimator, 
			2 => botAnimator, 
			_ => null, 
		};
		if ((Object)(object)rotatingSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(rotatingSound, ((Component)this).transform.position);
		}
		((ChessPillarSegmentAnimator)obj)?.CGFCLFOIEFP(FLMCIFNEJKH);
	}

	public bool JOFKADGLMPD(int JIIGOACEIKL)
	{
		if (!PLAKEEACNIE(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 0);
		return false;
	}

	public void MOCADENPBCO(MineChessPillarPuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Use"))
		{
			ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 2);
		}
	}

	public bool MAMIILGPEHF(int JIIGOACEIKL)
	{
		if (!JGDDHIEJPMH(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.FCFFDCOAOBC(JIIGOACEIKL, 0);
		return true;
	}

	public bool MDENHNAGFPM(int JIIGOACEIKL)
	{
		ONCCKDONEFG.HDPFNDHAGHC(JIIGOACEIKL, 1, CDPAMNIPPEC: false);
		return false;
	}

	public bool IFBELBJBAIO(int JIIGOACEIKL)
	{
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get(labelTop));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(labelMid));
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get(labelBottom));
		return true;
	}

	public bool NHHLLANEOEA(int JIIGOACEIKL)
	{
		if (!LEFHAOJHCBH(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.ICINLLNENHM(JIIGOACEIKL, 0, CDPAMNIPPEC: false);
		return false;
	}

	public void FCACPDCJIOO(int JIIGOACEIKL)
	{
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 0, CDPAMNIPPEC: false);
		return false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.OnSegmentChanged(JIIGOACEIKL, 1);
		return true;
	}
}
