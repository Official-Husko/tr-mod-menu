using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class HerbInfo : IOnlineSerializable
{
	[JsonProperty("1")]
	public int id;

	[JsonProperty("2")]
	public Vector2Online position;

	[JsonProperty("3")]
	public bool hasFlower;

	[JsonProperty("4")]
	public byte chosenSprite;

	public Herb FNDIKJCEPMF()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GetItem(117, GGBBJNBBLMF: false, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.EGKBDMDNOBI()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.IEHOAGEPPDD();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb KPJGMOJJDEN()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.COEFFIHKMJG(145).PHGCBMPGGLI(), Vector2.op_Implicit(position.HAAGJDKCKDE()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.IHOGIIAMFBP();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb MCNDJJJKOEB()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.INJBNHPGCIJ(114, GGBBJNBBLMF: true).LLCLICBABLN(), Vector2.op_Implicit(position.NJMEOADBLDG()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.APFFIELFFEK();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb GKEILCANNAI()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.INJBNHPGCIJ(122, GGBBJNBBLMF: false, DAINLFIMLIH: false).LLCLICBABLN(), Vector2.op_Implicit(position.BBGCPCAKDOM()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.APFFIELFFEK();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb JMFEIFHCEOD()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.CPMMBEPEJLO(-137, GGBBJNBBLMF: true, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.OAFGJFPCOLC()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.IEHOAGEPPDD();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb OOBKBNELBMC()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.CPMMBEPEJLO(-200).PHGCBMPGGLI(), Vector2.op_Implicit(position.GCGKIMHLDFO()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.MJCPAIAKBDP();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb KPOGKLGPMHP()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.CPMMBEPEJLO(-128).PHGCBMPGGLI(), Vector2.op_Implicit(position.MJADEINDKGN()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.MJKJHIAELDF();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb AECLNPIPIOH()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GetItem(138).LLCLICBABLN(), Vector2.op_Implicit(position.OBCABJAAPJC()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.APFFIELFFEK();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb JBKJEPODABH()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GOKIDLOELKB(26, GGBBJNBBLMF: true).LLCLICBABLN(), Vector2.op_Implicit(position.NKHENEJNFBC()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.JKOHALAMCNO();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb DNOJIDKFPOP()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GetItem(-90, GGBBJNBBLMF: true, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.GCGKIMHLDFO()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.DBICLDIKDEI();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb MLMAKOOPPCF()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.INJBNHPGCIJ(150, GGBBJNBBLMF: false, DAINLFIMLIH: false).LLCLICBABLN(), Vector2.op_Implicit(position.ALPFNOPMEAD()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.COFAALKOHBC();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb NACLEDDCPJJ()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.INJBNHPGCIJ(5).PHGCBMPGGLI(), Vector2.op_Implicit(position.EGMJFMENOKE()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.DAMLJEHIOMJ();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb CLAFHMFFCAK()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GOKIDLOELKB(-88, GGBBJNBBLMF: true).PHGCBMPGGLI(), Vector2.op_Implicit(position.OBCABJAAPJC()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.DBICLDIKDEI();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb PFGEMELONEH()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GOKIDLOELKB(52, GGBBJNBBLMF: false, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.NJMEOADBLDG()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.DBICLDIKDEI();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb JDKEKMMNKKP()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.EABMGELAAPG(66).PHGCBMPGGLI(), Vector2.op_Implicit(position.BBGCPCAKDOM()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.CKHAAOEMAKN();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb NMJACBMJOAB()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.EABMGELAAPG(-55, GGBBJNBBLMF: false, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.EGMJFMENOKE()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.CKHAAOEMAKN();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb HGINMCAPING()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.KMBGJEKCJFJ(38).PHGCBMPGGLI(), Vector2.op_Implicit(position.LEALNPKFFHE()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.MJKJHIAELDF();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb HPMGNKOHHOC()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.COEFFIHKMJG(-156, GGBBJNBBLMF: true, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.EGMJFMENOKE()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.IEHOAGEPPDD();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb MOJIFDCLKMK()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.CPMMBEPEJLO(106, GGBBJNBBLMF: true).PHGCBMPGGLI(), Vector2.op_Implicit(position.BBGCPCAKDOM()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.IHOGIIAMFBP();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb BEFMNHOCONE()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.AFOACBIHNCL(-118, GGBBJNBBLMF: true).PHGCBMPGGLI(), Vector2.op_Implicit(position.BBGCPCAKDOM()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.CKHAAOEMAKN();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb PGKKLIKJGDA()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.EABMGELAAPG(82, GGBBJNBBLMF: false, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.OBCABJAAPJC()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.DBICLDIKDEI();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb FFOABCMIKPG()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GOKIDLOELKB(-92, GGBBJNBBLMF: false, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.HAAGJDKCKDE()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.UpdateVisual();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb NJBBKOAONFI()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.CPMMBEPEJLO(-69, GGBBJNBBLMF: true).PHGCBMPGGLI(), Vector2.op_Implicit(position.EHJBDAEKEBA()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.MJCPAIAKBDP();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb BHICADDOPOD()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.CPMMBEPEJLO(-36, GGBBJNBBLMF: false, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.HAAGJDKCKDE()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.JKOHALAMCNO();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb MJHCOEDGKDC()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GetItem(2004).PHGCBMPGGLI(), Vector2.op_Implicit(position.DMBNLBPEELL()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.UpdateVisual();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb DHGCCJIIBJI()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GetItem(-188, GGBBJNBBLMF: true, DAINLFIMLIH: false).LLCLICBABLN(), Vector2.op_Implicit(position.KEIGEKMBHFO()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.DAMLJEHIOMJ();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb LAFHCLDAOLK()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GOKIDLOELKB(101, GGBBJNBBLMF: true, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.ELNKJGCEIHB()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.APFFIELFFEK();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb NBFADFHFABF()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.EABMGELAAPG(-136, GGBBJNBBLMF: true).LLCLICBABLN(), Vector2.op_Implicit(position.IFMEAHIDGPE()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.IHOGIIAMFBP();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb MAOBINLOBNO()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.INJBNHPGCIJ(96, GGBBJNBBLMF: true, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.ELNKJGCEIHB()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.MJKJHIAELDF();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb PEAAIGHOLND()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.KMBGJEKCJFJ(-12, GGBBJNBBLMF: false, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.NKHENEJNFBC()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.MJKJHIAELDF();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb HGJONLCBKEJ()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GetItem(-117, GGBBJNBBLMF: true).LLCLICBABLN(), Vector2.op_Implicit(position.OBCABJAAPJC()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.APFFIELFFEK();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb CCKIPHLPOND()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.COEFFIHKMJG(176, GGBBJNBBLMF: true, DAINLFIMLIH: false).LLCLICBABLN(), Vector2.op_Implicit(position.OBCABJAAPJC()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.DBICLDIKDEI();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb DKGGPCGFFPJ()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GOKIDLOELKB(-168, GGBBJNBBLMF: false, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.NJMEOADBLDG()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.CKHAAOEMAKN();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public HerbInfo(ForestElement PEMAMDKDBBO)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		position = new Vector2Online(Vector2.op_Implicit(((Component)PEMAMDKDBBO).transform.position));
		if (PEMAMDKDBBO is Herb herb)
		{
			id = herb.id;
			chosenSprite = (byte)herb.chosenSprite;
			hasFlower = herb.hasFlower;
		}
	}

	public Herb DPOKPDGPKEJ()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.INJBNHPGCIJ(-156, GGBBJNBBLMF: true, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.GCGKIMHLDFO()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.MJCPAIAKBDP();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}

	public Herb JIJJMLMJKJJ()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(ItemDatabaseAccessor.CPMMBEPEJLO(135, GGBBJNBBLMF: false, DAINLFIMLIH: false).PHGCBMPGGLI(), Vector2.op_Implicit(position.KEIGEKMBHFO()), Quaternion.identity).GetComponent<Herb>();
		component.id = id;
		component.chosenSprite = chosenSprite;
		component.hasFlower = hasFlower;
		component.JKOHALAMCNO();
		WorldGrid.EMBBOIKGPDA(component);
		return component;
	}
}
