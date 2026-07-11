using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeProfileTransition : MonoBehaviour
{
	public Volume volume;

	public float normalThreshold;

	public float transitionThreshold;

	private Bloom ICMDGHNFNJI;

	private float DCGBADKLANM;

	private void ALEAOANPHIO()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void GANLKNPKFFC()
	{
		DCGBADKLANM = Mathf.Lerp(0f, 1f, (WorldTime.EMBDKLMADBD - 68400f) / 5400f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void KDHLJKMKFMG()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void COGDGAMIDEI()
	{
		DCGBADKLANM = Mathf.Lerp(1490f, 1341f, (WorldTime.EMBDKLMADBD - 1091f) / 1214f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void Awake()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void JDMMNLKLMAA()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void OHGABHEDILE()
	{
		ALKCOJDGCAC();
	}

	private void MMBMEBDFIJN()
	{
		DCGBADKLANM = Mathf.Lerp(48f, 793f, (WorldTime.EMBDKLMADBD - 1104f) / 1608f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void JPHFCJIBBMI()
	{
		HCHCKLMMLJF();
	}

	private void OCJOAHDNDIJ()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void MFGANCCJFJK()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void MIKNFPCDLML()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void GHMKMHCLJNO()
	{
		DCGBADKLANM = Mathf.Lerp(1232f, 430f, (WorldTime.EMBDKLMADBD - 435f) / 1252f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void GONDLJKGLGO()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void IHICKHAABJH()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void NMFIBCDGOFL()
	{
		DCGBADKLANM = Mathf.Lerp(1989f, 355f, (WorldTime.EMBDKLMADBD - 1078f) / 1756f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void PGEGODAEBLC()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void JCCNMOIJPKA()
	{
		DCGBADKLANM = Mathf.Lerp(228f, 1451f, (WorldTime.EMBDKLMADBD - 1163f) / 504f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void CLGBFOIBANN()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void BAKDKFKNHDE()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void HDHPOAPLEJC()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void MONMLHILAGF()
	{
		DCGBADKLANM = Mathf.Lerp(1860f, 793f, (WorldTime.EMBDKLMADBD - 1705f) / 819f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void NABDFNADOLE()
	{
		DCGBADKLANM = Mathf.Lerp(228f, 1334f, (WorldTime.EMBDKLMADBD - 664f) / 1341f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void Update()
	{
		GANLKNPKFFC();
	}

	private void FNFBAALDIDC()
	{
		DCGBADKLANM = Mathf.Lerp(1164f, 1467f, (WorldTime.EMBDKLMADBD - 294f) / 810f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void EMCCGDFOPEH()
	{
		HCHCKLMMLJF();
	}

	private void MGMLDHPOLGK()
	{
		APAENOJMPDF();
	}

	private void PMPLNGEAAII()
	{
		GOMDGFOGGBB();
	}

	private void KLMNLEDKEOE()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void JBGFGOCPEFD()
	{
		MONMLHILAGF();
	}

	private void PBOAOIBLIKL()
	{
		DCGBADKLANM = Mathf.Lerp(1820f, 1026f, (WorldTime.EMBDKLMADBD - 901f) / 1892f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void GOMDGFOGGBB()
	{
		DCGBADKLANM = Mathf.Lerp(859f, 1889f, (WorldTime.EMBDKLMADBD - 1694f) / 855f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void NHCFGODJLGM()
	{
		DCGBADKLANM = Mathf.Lerp(397f, 1835f, (WorldTime.EMBDKLMADBD - 1684f) / 947f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void OKHLEMPJONN()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void MMNBJPDJHGK()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void HJDPBPJNHIF()
	{
		DCGBADKLANM = Mathf.Lerp(883f, 37f, (WorldTime.EMBDKLMADBD - 539f) / 1539f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void NMKGOAJLMDG()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void APAENOJMPDF()
	{
		DCGBADKLANM = Mathf.Lerp(1864f, 601f, (WorldTime.EMBDKLMADBD - 1262f) / 1108f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void BFJOEMCBJJO()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void HCHCKLMMLJF()
	{
		DCGBADKLANM = Mathf.Lerp(1492f, 725f, (WorldTime.EMBDKLMADBD - 774f) / 8f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void ODDFEIOPMAL()
	{
		DCGBADKLANM = Mathf.Lerp(1408f, 916f, (WorldTime.EMBDKLMADBD - 1873f) / 71f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void ALKCOJDGCAC()
	{
		DCGBADKLANM = Mathf.Lerp(1094f, 438f, (WorldTime.EMBDKLMADBD - 1437f) / 64f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void OGEJKOIOKAN()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void GMCKBBECJOE()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void DOKHLDBIDJB()
	{
		ODDFEIOPMAL();
	}

	private void OGBGFLMKFHH()
	{
		GOMDGFOGGBB();
	}

	private void ELHCBGCEJDH()
	{
		MMBMEBDFIJN();
	}

	private void PKAONKGOFFK()
	{
		DCGBADKLANM = Mathf.Lerp(848f, 1627f, (WorldTime.EMBDKLMADBD - 1936f) / 1219f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void PKEPBKHEDOD()
	{
		NHCFGODJLGM();
	}

	private void ALKMKCJLPFD()
	{
		DCGBADKLANM = Mathf.Lerp(1084f, 1947f, (WorldTime.EMBDKLMADBD - 536f) / 1524f);
		volume.weight = DCGBADKLANM;
		DCGBADKLANM *= DCGBADKLANM;
		((VolumeParameter<float>)(object)ICMDGHNFNJI.threshold).value = Mathf.Lerp(transitionThreshold, normalThreshold, DCGBADKLANM);
	}

	private void BHKNJOEBCKA()
	{
		COGDGAMIDEI();
	}

	private void KJHKBGDJNDC()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void OAEJGGFFCBO()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void LAABMDDEGCG()
	{
		JCCNMOIJPKA();
	}

	private void EIMIDCDEIDD()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void FHOCCEBKHJI()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}

	private void EBFJOAEJPGE()
	{
		NMFIBCDGOFL();
	}

	private void AAEAAEBBFKG()
	{
		volume.profile.TryGet<Bloom>(ref ICMDGHNFNJI);
	}
}
