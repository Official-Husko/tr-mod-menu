using System.Runtime.CompilerServices;
using UnityEngine;

public class FloatingMovement : MonoBehaviour
{
	private bool OBPDOHANDFD;

	private Vector3 BHEMMELCGDN;

	private float AAFJOAPNNBA;

	public float theta;

	public float height;

	public float LIDGIPGPHJJ { get; set; }

	public void COOIPCDMFHE(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(574f, 503f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.KHMEGDIABBF().wavesRate);
		}
	}

	[SpecialName]
	public void CACEJBLLICF(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	protected void FDHMOEDMPNG()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.NEFIEJALANL().wavesPeriod) / WavesManager.KHMEGDIABBF().wavesPeriod;
			height = WavesManager.ELGNEJNLBNO().wavesHeight * BDPGIOMDHMD() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 0);
		}
	}

	[SpecialName]
	public void NCEKLMGNLLI(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public float BDGOAGPOCPB()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	[SpecialName]
	public void ECDJOHLHNPA(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	protected void OAKGHDAABPM()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.DCAEBALADIM().wavesPeriod) / WavesManager.JCMKNNOEONP().wavesPeriod;
			height = WavesManager.NBKKEINELDN().wavesHeight * NCMAMEJDCLC() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	protected void HCEDMLJNOBL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		KBFNEEBDCLG(((Component)this).transform.position);
	}

	protected void POFDOILPANH()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.KHMEGDIABBF().wavesPeriod) / WavesManager.BADFKMEJOKE().wavesPeriod;
			height = WavesManager.ELGNEJNLBNO().wavesHeight * PIBAHKMJONP() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 0);
		}
	}

	protected void IIOHMDNGFDH()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.OFLELHKKNKC().wavesPeriod) / WavesManager.EFPJLFMBPLL().wavesPeriod;
			height = WavesManager.MAAAKALBBEE().wavesHeight * AMEJOAGAFDI() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	[SpecialName]
	public void PLPFMHJBICE(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	protected void MHCOLHEDNGN()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.HEKFJEKFMNO().wavesPeriod) / WavesManager.DBJCACLEFGK().wavesPeriod;
			height = WavesManager.AFFGPMFKEFH().wavesHeight * IGCANOMMILK() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	protected void GOJFGHKOFMF()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.BIIOFAHFNPA().wavesPeriod) / WavesManager.BADFKMEJOKE().wavesPeriod;
			height = WavesManager.NEFIEJALANL().wavesHeight * NACPGDDIBKA() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 0);
		}
	}

	protected void DMFMNEMDFNP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		KBFNEEBDCLG(((Component)this).transform.position);
	}

	public void IDBNNNCIBKA(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(565f, 1192f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.ELGNEJNLBNO().wavesRate);
		}
	}

	[SpecialName]
	public float NACPGDDIBKA()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	protected void OONONNJFEFL()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.KGPJPILAHDE().wavesPeriod) / WavesManager.DIHCEGINELM().wavesPeriod;
			height = WavesManager.CMIHGBHPLFP().wavesHeight * DKDODOKDKNK() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	[SpecialName]
	public void BHCPFOAFNAE(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public float IDBLILNIPOM()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	public void NGPEAOKIHKJ(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(1649f, 893f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.LKOABOAADCD().wavesRate);
		}
	}

	public void OPDKNKAAIEK(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(1643f, 1147f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.PDECKLKPKCG().wavesRate);
		}
	}

	protected void HNEGFBCKIIJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		IJOBGPCEHEF(((Component)this).transform.position);
	}

	protected void ACPFEBOENOM()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.NJNFHEPLEHL().wavesPeriod) / WavesManager.NJNFHEPLEHL().wavesPeriod;
			height = WavesManager.KHMEGDIABBF().wavesHeight * BDGOAGPOCPB() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	protected void DHBMBJOLGDE()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.AGGAGCBAGLL().wavesPeriod) / WavesManager.LKOABOAADCD().wavesPeriod;
			height = WavesManager.OFLELHKKNKC().wavesHeight * IDBLILNIPOM() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	protected void CAOKPIIFHBJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		DJGFFKNFOMD(((Component)this).transform.position);
	}

	protected void CMLLBIDFNEB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		CalculateOffset(((Component)this).transform.position);
	}

	protected void IMIONHLAKIH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		MCMKNJLPPIC(((Component)this).transform.position);
	}

	public FloatingMovement()
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = 1f;
		((MonoBehaviour)this)._002Ector();
	}

	[SpecialName]
	public void OOPMCHAAKOK(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	protected void PEIFJDIGKOC()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.MIGKKKELOJO().wavesPeriod) / WavesManager.BIIOFAHFNPA().wavesPeriod;
			height = WavesManager.CNDNOECMKME().wavesHeight * MCKPNJBBBCF() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	[SpecialName]
	public float JECFEKEFMPB()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	[SpecialName]
	public void HIEECJBHHOL(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	protected void JLCFNPBBKEK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		MCMKNJLPPIC(((Component)this).transform.position);
	}

	[SpecialName]
	public float HGGAEDLOFIL()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	[SpecialName]
	public float EIBAIHDPIDH()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	protected void CHIJGHPHCNA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		NGPEAOKIHKJ(((Component)this).transform.position);
	}

	protected void HOFKJPBBLGP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		CalculateOffset(((Component)this).transform.position);
	}

	[SpecialName]
	public float KNPGGKBDCML()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	[SpecialName]
	public float AMEJOAGAFDI()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	protected void GNAHKAHPCFB()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.HFIJHDBKCIA().wavesPeriod) / WavesManager.AJIGOHGPFPP().wavesPeriod;
			height = WavesManager.AGGAGCBAGLL().wavesHeight * HGGAEDLOFIL() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	protected void Update()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.GGFJGHHHEJC.wavesPeriod) / WavesManager.GGFJGHHHEJC.wavesPeriod;
			height = WavesManager.GGFJGHHHEJC.wavesHeight * LIDGIPGPHJJ * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	protected void PLHEHGHFCJI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		OPDKNKAAIEK(((Component)this).transform.position);
	}

	public void KBFNEEBDCLG(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(178f, 130f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.CNDNOECMKME().wavesRate);
		}
	}

	[SpecialName]
	public float IGCANOMMILK()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	protected void CMDHELEDLBP()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.NEFIEJALANL().wavesPeriod) / WavesManager.LKOABOAADCD().wavesPeriod;
			height = WavesManager.BIIOFAHFNPA().wavesHeight * EIBAIHDPIDH() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	[SpecialName]
	public float FBALFCBMEED()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	public void IJMAEMJBNBI(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(1000f, 555f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.NEFIEJALANL().wavesRate);
		}
	}

	protected void GGCCOKCOMEE()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.BADFKMEJOKE().wavesPeriod) / WavesManager.MAAAKALBBEE().wavesPeriod;
			height = WavesManager.HFIJHDBKCIA().wavesHeight * LIDGIPGPHJJ * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 0);
		}
	}

	[SpecialName]
	public float BDPGIOMDHMD()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	[SpecialName]
	public void DEKHOGGKHHC(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	protected void NKDFMFFDGKC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		OPDKNKAAIEK(((Component)this).transform.position);
	}

	[SpecialName]
	public float NCMAMEJDCLC()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	protected void HHLBFDBHDMC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		KBFNEEBDCLG(((Component)this).transform.position);
	}

	protected void CFIIEJDJFPB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		IDBNNNCIBKA(((Component)this).transform.position);
	}

	protected void NIHJCJJKDBA()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.JCMKNNOEONP().wavesPeriod) / WavesManager.CNDNOECMKME().wavesPeriod;
			height = WavesManager.LKOABOAADCD().wavesHeight * LIDGIPGPHJJ * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	protected void FKPNIHJGFBJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		NGPEAOKIHKJ(((Component)this).transform.position);
	}

	[SpecialName]
	public void AABCGAINMHL(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public void JMMFCCFHFBI(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	public void IJOBGPCEHEF(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(431f, 700f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.BADFKMEJOKE().wavesRate);
		}
	}

	public void MCMKNJLPPIC(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(70f, 1520f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.NJNFHEPLEHL().wavesRate);
		}
	}

	protected void LALAFOIGMKN()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CAGIBNLHJBN())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.JCMKNNOEONP().wavesPeriod) / WavesManager.BIIOFAHFNPA().wavesPeriod;
			height = WavesManager.AJIGOHGPFPP().wavesHeight * PKKADGNHMAM() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	[SpecialName]
	public void MDLKJCLGHPP(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public float CLBANBAJNDD()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	[SpecialName]
	public void PHAJJKPOILL(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	protected void MMPMJNAFKHC()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.AJIGOHGPFPP().wavesPeriod) / WavesManager.OOKBNHMMFON().wavesPeriod;
			height = WavesManager.DIHCEGINELM().wavesHeight * BDPGIOMDHMD() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	public void GFNGFKKFNOF(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(1499f, 1053f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.OFLELHKKNKC().wavesRate);
		}
	}

	protected void KDBJHCAEGCM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		OPDKNKAAIEK(((Component)this).transform.position);
	}

	[SpecialName]
	public void EGNMJDIJELH(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	protected void IOHIEBBDOJN()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.DICHPHEOINO().wavesPeriod) / WavesManager.KGPJPILAHDE().wavesPeriod;
			height = WavesManager.DCAEBALADIM().wavesHeight * BDPGIOMDHMD() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	protected void MCMKNBIBDFF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		KBFNEEBDCLG(((Component)this).transform.position);
	}

	[SpecialName]
	public void GILPFBMKLID(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	public void IHBHAIFEBHP(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(196f, 359f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.CNDNOECMKME().wavesRate);
		}
	}

	[SpecialName]
	public void IIMNCCOLPGG(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public void OIEIMOIJFCM(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	protected void GOJHCINMAJD()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.NBKKEINELDN().wavesPeriod) / WavesManager.BADFKMEJOKE().wavesPeriod;
			height = WavesManager.BADFKMEJOKE().wavesHeight * NACPGDDIBKA() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	[SpecialName]
	public float DKDODOKDKNK()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	public void CalculateOffset(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(0f, 20f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.GGFJGHHHEJC.wavesRate);
		}
	}

	protected void OFDEGDJGGGF()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.OPGGPLEOGCG())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.JCMKNNOEONP().wavesPeriod) / WavesManager.NJNFHEPLEHL().wavesPeriod;
			height = WavesManager.OFLELHKKNKC().wavesHeight * ILGPOEBIFDG() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	protected void HPIMHEMJMAA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		IDBNNNCIBKA(((Component)this).transform.position);
	}

	protected void IDHCFOCEPMD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		COOIPCDMFHE(((Component)this).transform.position);
	}

	[SpecialName]
	public void JNONMBOCMLK(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	public void MEOGCODFLCJ(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(300f, 1888f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.HFIJHDBKCIA().wavesRate);
		}
	}

	[SpecialName]
	public float JMIJHMHFMMP()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	protected void CAIJLMJBMLA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		IDBNNNCIBKA(((Component)this).transform.position);
	}

	protected void KFBOPABEJNL()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.CMIHGBHPLFP().wavesPeriod) / WavesManager.JCMKNNOEONP().wavesPeriod;
			height = WavesManager.AFFGPMFKEFH().wavesHeight * PIBAHKMJONP() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 0);
		}
	}

	[SpecialName]
	public float ILGPOEBIFDG()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	protected void Start()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		CalculateOffset(((Component)this).transform.position);
	}

	[SpecialName]
	public float BDJPLKHGAHP()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	[SpecialName]
	public float MCKPNJBBBCF()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	protected void BGENEAOILOF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		IJOBGPCEHEF(((Component)this).transform.position);
	}

	protected void FPOIFOGELHC()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.NoPlayers())
		{
			theta = (Time.timeSinceLevelLoad + AAFJOAPNNBA * WavesManager.OOKBNHMMFON().wavesPeriod) / WavesManager.DICHPHEOINO().wavesPeriod;
			height = WavesManager.MIGKKKELOJO().wavesHeight * EIBAIHDPIDH() * Mathf.Sin(theta);
			((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(BHEMMELCGDN + Vector3.up * height, 1);
		}
	}

	public void DJGFFKNFOMD(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OBPDOHANDFD)
		{
			AAFJOAPNNBA = Random.Range(1174f, 711f);
		}
		else
		{
			AAFJOAPNNBA = Utils.NMLNAGFLNMC(WorldGrid.PCJLCPOEKHM(IMOBLFMHKOD), WavesManager.BIIOFAHFNPA().wavesRate);
		}
	}

	[SpecialName]
	public float PIBAHKMJONP()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}

	[SpecialName]
	public void LADJKDAEMKG(float AODONKKHPBP)
	{
		_003CDAJFGCKKGCK_003Ek__BackingField = AODONKKHPBP;
	}

	protected void APEIPGIHEKP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BHEMMELCGDN = ((Component)this).transform.localPosition;
		MCMKNJLPPIC(((Component)this).transform.position);
	}

	[SpecialName]
	public float PKKADGNHMAM()
	{
		return _003CDAJFGCKKGCK_003Ek__BackingField;
	}
}
