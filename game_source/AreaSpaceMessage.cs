using System;
using Newtonsoft.Json;

[Serializable]
public class AreaSpaceMessage : CrafterMessage
{
	[JsonProperty("pIM")]
	public PlaceablesInsideMessage placeablesInsideMessage;

	[JsonProperty("hAS")]
	public Vector2Online[] hiddenAreaSquares;

	public void ICGFMCAIAAD(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.INDIOFCBFIJ(OMMPBICOPNO);
	}

	public void NJAHJLDMLCM(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.NIECKADIJEO(OMMPBICOPNO);
	}

	public void NBAGHIJIIPA(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.CLKJIIEBJHP(OMMPBICOPNO);
	}

	public void MFOMFFPIKHG(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.BHHFOCMADCB(OMMPBICOPNO);
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineAreaSpace onlineAreaSpace)
		{
			onlineAreaSpace.areaSpace.ActivateArea(DAEMAAOLHMG: true);
		}
		return onlineObject;
	}

	public void EPMOPAGOKAM(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.MLOHGLKCPDK(OMMPBICOPNO);
	}

	public void PLCNECPFJJC(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.IOHPGCGKLIJ(OMMPBICOPNO);
	}

	public void PIMGHEIFHAB(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.FKCHCFGJFML(OMMPBICOPNO);
	}

	public void BIMNEHPIONK(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.IOHPGCGKLIJ(OMMPBICOPNO);
	}

	public void IGLLDHBPGLI(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.JCGFNDPNECL(OMMPBICOPNO);
	}

	public void BHHFOCMADCB(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.DCPKDNONFHF(OMMPBICOPNO);
	}

	public void NIECKADIJEO(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.FGHLBEABGLB(OMMPBICOPNO);
	}

	public void INDIOFCBFIJ(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.FGHLBEABGLB(OMMPBICOPNO);
	}

	public void FGHLBEABGLB(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.KCKJBCAIIGH(OMMPBICOPNO);
	}

	public void IOHPGCGKLIJ(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.ONIOCPCJHNO(OMMPBICOPNO);
	}

	public void AKJOMDGDFIB(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.LPNOEOCDOKF(OMMPBICOPNO);
	}

	public void GHHKACEHIOP(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.NMPCDPAJDLB(OMMPBICOPNO);
	}

	public void HAIGBPBFLPB(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.LPNOEOCDOKF(OMMPBICOPNO);
	}

	public void BKHLMLGCKPE(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.FGHLBEABGLB(OMMPBICOPNO);
	}

	public void ONIOCPCJHNO(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.NJABALNECMH(OMMPBICOPNO);
	}

	public void BNBJFAHIMNH(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.BNBJFAHIMNH(OMMPBICOPNO);
	}

	public void NJABALNECMH(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.NBAGHIJIIPA(OMMPBICOPNO);
	}

	public AreaSpaceMessage(OnlineAreaSpace IMAELGHGMFJ)
		: base(IMAELGHGMFJ)
	{
		placeablesInsideMessage = new PlaceablesInsideMessage(IMAELGHGMFJ.areaSpace.placeablesInside);
	}

	public void JCGFNDPNECL(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.OBJHBMIEEML(OMMPBICOPNO);
	}

	public void IPFPANJBHLI(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.CLKJIIEBJHP(OMMPBICOPNO);
	}

	public void CLKJIIEBJHP(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.LPNOEOCDOKF(OMMPBICOPNO);
	}

	public void MLOHGLKCPDK(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.EFIOCHBLNGK(OMMPBICOPNO);
	}

	public void GBDMCNEMPAD(PlaceablesInside OMMPBICOPNO)
	{
		placeablesInsideMessage.BKHLMLGCKPE(OMMPBICOPNO);
	}
}
