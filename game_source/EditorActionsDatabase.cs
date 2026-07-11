using System;
using System.Collections.Generic;
using UnityEngine;

public class EditorActionsDatabase : ScriptableObject
{
	[Serializable]
	public class DecoTileLine
	{
		public int ID;

		public string name;

		public string decoTileTypeName;

		public TavernFloor tavernFloor;

		public int price;

		public int planks;

		public int nails;

		public int stones;

		public int mortar;
	}

	[SerializeField]
	private TavernConstructionAction[] _editorActionsInfo;

	public FarmConstructionAction[] _farmActionsInfo;

	[SerializeField]
	private DecorationTile[] _decorationTiles;

	public List<DecoTileLine> file = new List<DecoTileLine>();

	public int OHJAEKNIMBB(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int KGIACNJALLK(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int AHKKPAKDCGF(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int NIKEOLGMANG(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] KMIBAJPIHIG()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int DHCOOPMNFPK(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int BAHEFBNKPNJ(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] HCGAJJAKEIM()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int FCHMMCKOBAA(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] HKPCACEEDKN()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int HJPDDKEFOND(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] MAFPDADAOKF()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int BEDBIKMPHKL(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int FMBOBFGCJOE(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] IOIKFKDDKIG()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int FLECKGPPJLD(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int LCBENFJCJCL(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] NHNKIGCHDMO()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int PBKCJENKGLD(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int BCNMOFEKLAA(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int GEDMGLOHIEM(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int HBADPJHAOKN(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] EEHLGKIPPHF()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int BGGIACHFGIG(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int EIMHDGALHBP(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] DLOGGGLCBIA()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int PCLPEIEOLKL(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int HDPNBOMAFNK(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int DAJGHJIAPDE(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int NICFLGGDANG(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int CMMINAIPNAN(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] KCDLDINFDDL()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int IMFOHFNGBMP(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] JLCJMNALGKD()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public TavernConstructionAction[] FDPHHFKENNN()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public TavernConstructionAction[] NPDJFJAMDHM()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int AAHPNJFKOBB(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int IOAAJLJGNLL(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int NCIEMDFIGCL(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int IEADKCKJELP(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int ALMPCBGHMMO(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int DAPEONLNMAC(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int LMFJIKENOKK(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] ACJLEIIJCID()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int BBFDOFICEMD(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int EINBMFHLFNJ(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] HHKEJHFBAII()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int OAKDJEOKBAD(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int NALKNMJFBLJ(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int HMEMFHLBOJM(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int GHDDECNNIHP(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int FIDOHKIHAJM(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int DPNJBGPBEEL(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] PHCDNELBIBN()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int HAPILOKLAOL(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int OHCHJLIPKGJ(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] PJOBFLFLEIN()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int DIAJKIBAICH(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int BEFBGOABFBE(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] DCEAOBGGKJJ()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int AMIJFCGAOEI(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] AECMGDFIKBM()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int DGJOIGKNLFL(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int LHDDMIHGKNL(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int FAFHNJPCADA(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int PNNNLLJFPMN(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int GNMJCAHAHHC(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int FGKDDEJBFDL(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] JFOBDONGLIO()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int IHIHBNIMPBF(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] FKLGALDKMCL()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public TavernConstructionAction[] AONJBOLADFO()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public TavernConstructionAction[] AEFKNJEGLNP()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int IILJCPELKMJ(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int JADDDJEECGH(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int PMCIKNKMBKG(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] GFFEMNFDPHE()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int EHAGPINIJMM(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int FLGDAIPDOLG(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int GNAFFKILFIO(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int EJFAKGNFMPM(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int ADCPJHKAMNB(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int KHNLHBPDEFG(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int PJIMJOFLEOC(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int JAJEGEENPKO(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] OGMKBACJNBG()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public TavernConstructionAction[] PCKIJFCKGBA()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public TavernConstructionAction[] OPOFJFKAEHO()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int CIOMBDFDDBD(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int IJLJHHJFKKN(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int MDMLBJPPKHI(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int JIFENEGAOBO(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int MCPECCLLKOL(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int JGGBAFOFNPL(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int OKHFIBNPHHG(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int JCLEKOKHJBK(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] OCKPPAGFGBP()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int OOEFGJPMKAG(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int AHKNKGGAKGI(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] GEBEBHKJCJD()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int OJLOBOMBIDE(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] GAKJAOKNOOO()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int DDADIKHBKFA(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int CHEDBDDDPJD(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int CDLPHEBMIKH(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] DLCNEJNMOAC()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public TavernConstructionAction[] KIOMGNPIAJP()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public TavernConstructionAction[] BJCJOACMDNM()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int BKFNCIOCBHH(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int LBIEKKJKDGM(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int MHKMOHGBGGG(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] IGPBGFFEHMO()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int AGBABOGEKAG(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public TavernConstructionAction[] FCHCGFGCPAF()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int NOJCCDFBGAJ(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] NDHOMKLGIIO()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int MALHKJBMIMG(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] IKHFCEHGHJE()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int GNBPPNIIOCD(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public int BIIOHGMANPN(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}

	public int IJHBKNDCNDG(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] PAJLEPLALDG()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int KJMMPKCINNF(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] BMODHMNFPEO()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int MHAHGENDAKM(DecorationTile NHMCILKHBOD)
	{
		List<DecorationTile> list = new List<DecorationTile>(_decorationTiles);
		list.Add(NHMCILKHBOD);
		_decorationTiles = list.ToArray();
		return NHMCILKHBOD.id;
	}

	public TavernConstructionAction[] GPPEPEEJNHK()
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.AddRange(_decorationTiles);
		return list.ToArray();
	}

	public int FONBBFJMMKN(TavernConstructionAction FMDOLEFOGIC)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>(_editorActionsInfo);
		list.Add(FMDOLEFOGIC);
		_editorActionsInfo = list.ToArray();
		return FMDOLEFOGIC.id;
	}
}
