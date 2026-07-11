using Newtonsoft.Json;

public class HumanInfoMsg : IOnlineSerializable
{
	[JsonProperty("1")]
	public byte gender;

	[JsonProperty("2")]
	public short skin;

	[JsonProperty("3")]
	public short skinMat;

	[JsonProperty("4")]
	public short hair;

	[JsonProperty("5")]
	public short hairMat;

	[JsonProperty("6")]
	public short hatMat;

	[JsonProperty("7")]
	public short eyes;

	[JsonProperty("8")]
	public short irisMat;

	[JsonProperty("9")]
	public short nose;

	[JsonProperty("10")]
	public short mouth;

	[JsonProperty("11")]
	public short beard;

	[JsonProperty("12")]
	public short beardMat;

	[JsonProperty("13")]
	public short torso;

	[JsonProperty("14")]
	public short torsoMat1;

	[JsonProperty("15")]
	public short torsoMat2;

	[JsonProperty("16")]
	public short torsoMat3;

	[JsonProperty("17")]
	public short legs;

	[JsonProperty("18")]
	public short legsMat1;

	[JsonProperty("19")]
	public short legsMat2;

	[JsonProperty("20")]
	public short legsMat3;

	[JsonProperty("21")]
	public short shoes;

	[JsonProperty("22")]
	public short shoesMat1;

	[JsonProperty("23")]
	public short shoesMat2;

	public void MJHLPBPKHGH(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Legs, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Eyes, DKDFNAGAFNL.AKBDNBOJNNE(eyes));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Nose, DKDFNAGAFNL.DLFHMEEOJCI(mouth));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(torso));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Nose, DKDFNAGAFNL.AKBDNBOJNNE(legs));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.PFABHCPKGCA(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-72), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-79), CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)121, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat2));
	}

	public void KCAOLDPFHPL(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Nose, DKDFNAGAFNL.OKNNCEAGNDF(eyes));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Nose, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Legs, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(torso));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Eyes, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Mouth, DKDFNAGAFNL.LGCAPCKCAGD(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-77), CharacterSpritesDBAccessor.MIAIOBLCEND(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(torsoMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)46, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-74), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-91), CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat2));
	}

	public HumanInfo AIHGHKDDOBO()
	{
		HumanInfo humanInfo = new HumanInfo();
		LFOGNGHELDK(humanInfo);
		return humanInfo;
	}

	public HumanInfo IPCIDDGPIBC()
	{
		HumanInfo humanInfo = new HumanInfo();
		IBKDMAPKIDI(humanInfo);
		return humanInfo;
	}

	public void OCGDLLDCGDE(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Beard, DKDFNAGAFNL.AKBDNBOJNNE(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.LGCAPCKCAGD(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Nose, DKDFNAGAFNL.DLFHMEEOJCI(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Shoes, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.HACHFHGFFEB(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)91, CharacterSpritesDBAccessor.MDBJNKMOKMM(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.PFABHCPKGCA(beardMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)86, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-55), CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-107), CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public void IHANIFMHIFK(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Nose, DKDFNAGAFNL.LGCAPCKCAGD(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Mouth, DKDFNAGAFNL.AKBDNBOJNNE(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Beard, DKDFNAGAFNL.DLFHMEEOJCI(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(beard));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(torso));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Nose, DKDFNAGAFNL.AKBDNBOJNNE(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(hairMat));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)88, CharacterSpritesDBAccessor.MDBJNKMOKMM(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MDBJNKMOKMM(beardMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat1));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-61), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)55, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)48, CharacterSpritesDBAccessor.GetMaterial(shoesMat2));
	}

	public HumanInfo JPMNBPPLGAF()
	{
		HumanInfo humanInfo = new HumanInfo();
		NAEEGDAGIAO(humanInfo);
		return humanInfo;
	}

	public HumanInfo KFDPNCNMOGK()
	{
		HumanInfo humanInfo = new HumanInfo();
		JIOBGDMCBNH(humanInfo);
		return humanInfo;
	}

	public void LHOIGEIDHIA(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Legs, DKDFNAGAFNL.LGCAPCKCAGD(eyes));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(nose));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Nose, DKDFNAGAFNL.DLFHMEEOJCI(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Nose, DKDFNAGAFNL.OKNNCEAGNDF(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Hair, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(skinMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)94, CharacterSpritesDBAccessor.HACHFHGFFEB(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.GetMaterial(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.HACHFHGFFEB(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(torsoMat1));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)102, CharacterSpritesDBAccessor.GetMaterial(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)73, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-42), CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat2));
	}

	public HumanInfo PNJBJDAEBOO()
	{
		HumanInfo humanInfo = new HumanInfo();
		OABLCHJPPIN(humanInfo);
		return humanInfo;
	}

	public void NHHGCLALLLC(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Eyes, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Nose, DKDFNAGAFNL.DLFHMEEOJCI(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Shoes, DKDFNAGAFNL.OKNNCEAGNDF(nose));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Legs, DKDFNAGAFNL.CONPDKDNOBO(mouth));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Legs, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Mouth, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Hair, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)34, CharacterSpritesDBAccessor.GetMaterial(hatMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.PFABHCPKGCA(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.GetMaterial(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-13), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)127, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-56), CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat2));
	}

	public HumanInfo JFKFIJECINE()
	{
		HumanInfo humanInfo = new HumanInfo();
		MJHLPBPKHGH(humanInfo);
		return humanInfo;
	}

	public void BCNMBFMDKEF(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Hair, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Nose, DKDFNAGAFNL.AKBDNBOJNNE(eyes));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Eyes, DKDFNAGAFNL.OKNNCEAGNDF(nose));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Mouth, DKDFNAGAFNL.DLFHMEEOJCI(mouth));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Hair, DKDFNAGAFNL.OKNNCEAGNDF(beard));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(torso));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Shoes, DKDFNAGAFNL.LGCAPCKCAGD(shoes));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.HACHFHGFFEB(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-60), CharacterSpritesDBAccessor.MIAIOBLCEND(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat1));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-53), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat2));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-94), CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-68), CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat2));
	}

	public void BIOJHCFGHJA(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Mouth, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Hair, DKDFNAGAFNL.AKBDNBOJNNE(eyes));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(mouth));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Shoes, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.OKNNCEAGNDF(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Mouth, DKDFNAGAFNL.LGCAPCKCAGD(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)121, CharacterSpritesDBAccessor.CIJJJBJNLIF(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.HACHFHGFFEB(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.PFABHCPKGCA(beardMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Beard, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)43, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)84, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)97, CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat2));
	}

	public void JAKENFOAHCC(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Eyes, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Beard, DKDFNAGAFNL.OKNNCEAGNDF(eyes));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Beard, DKDFNAGAFNL.OKNNCEAGNDF(nose));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Hair, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Eyes, DKDFNAGAFNL.DLFHMEEOJCI(beard));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(torso));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(legs));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Hair, CharacterSpritesDBAccessor.MDBJNKMOKMM(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-54), CharacterSpritesDBAccessor.MDBJNKMOKMM(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MDBJNKMOKMM(beardMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso3, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-27), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-113), CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Hat, CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat2));
	}

	public void IBEPBJGGCOI(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Legs, DKDFNAGAFNL.CONPDKDNOBO(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(nose));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Hair, DKDFNAGAFNL.DLFHMEEOJCI(beard));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MIAIOBLCEND(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Pants, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)105, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)106, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)90, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat2));
	}

	public HumanInfo HPMHBGFLCKJ()
	{
		HumanInfo humanInfo = new HumanInfo();
		PNPMDLOFHNG(humanInfo);
		return humanInfo;
	}

	public HumanInfo PMKKFDHOJBB()
	{
		HumanInfo humanInfo = new HumanInfo();
		OCGDLLDCGDE(humanInfo);
		return humanInfo;
	}

	public void JDBLFBKJCHO(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Beard, DKDFNAGAFNL.LGCAPCKCAGD(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Nose, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Eyes, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.OKNNCEAGNDF(legs));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-78), CharacterSpritesDBAccessor.CIJJJBJNLIF(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(torsoMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)50, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)114, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-89), CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat2));
	}

	public void JJEMKIKNIOG(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Legs, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Hair, DKDFNAGAFNL.DLFHMEEOJCI(eyes));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(nose));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Hair, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Legs, DKDFNAGAFNL.OKNNCEAGNDF(beard));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(torso));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(legs));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Legs, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-115), CharacterSpritesDBAccessor.CIJJJBJNLIF(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Beard, CharacterSpritesDBAccessor.HACHFHGFFEB(beardMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-54), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)121, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)41, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public void FHCIEPPIDND(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Beard, DKDFNAGAFNL.DLFHMEEOJCI(eyes));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Hair, DKDFNAGAFNL.LGCAPCKCAGD(nose));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Beard, DKDFNAGAFNL.DLFHMEEOJCI(mouth));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Hair, DKDFNAGAFNL.CONPDKDNOBO(beard));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Eyes, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-120), CharacterSpritesDBAccessor.GetMaterial(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.HACHFHGFFEB(beardMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-89), CharacterSpritesDBAccessor.GetMaterial(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)122, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat2));
	}

	public HumanInfo GCHCKFGIOAE()
	{
		HumanInfo humanInfo = new HumanInfo();
		CMAHNFKIBPP(humanInfo);
		return humanInfo;
	}

	public void ACDLMJBNBKO(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Hair, DKDFNAGAFNL.AKBDNBOJNNE(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(eyes));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Eyes, DKDFNAGAFNL.LGCAPCKCAGD(nose));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Legs, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Legs, DKDFNAGAFNL.CONPDKDNOBO(beard));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(torso));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Shoes, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Nose, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(hairMat));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)51, CharacterSpritesDBAccessor.MDBJNKMOKMM(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso3, CharacterSpritesDBAccessor.CIJJJBJNLIF(irisMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)66, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-70), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)37, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat2));
	}

	public void DCGFHOHPMBG(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Nose, DKDFNAGAFNL.AKBDNBOJNNE(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.OKNNCEAGNDF(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Hair, DKDFNAGAFNL.LGCAPCKCAGD(nose));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Shoes, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Shoes, DKDFNAGAFNL.OKNNCEAGNDF(beard));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(torso));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Nose, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Pants, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)123, CharacterSpritesDBAccessor.PFABHCPKGCA(hatMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Pants, CharacterSpritesDBAccessor.CIJJJBJNLIF(beardMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Pants, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)41, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-8), CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)42, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat2));
	}

	public void PNPMDLOFHNG(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Mouth, DKDFNAGAFNL.CONPDKDNOBO(hair));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Nose, DKDFNAGAFNL.OKNNCEAGNDF(eyes));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Mouth, DKDFNAGAFNL.DLFHMEEOJCI(nose));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Nose, DKDFNAGAFNL.OKNNCEAGNDF(beard));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Mouth, DKDFNAGAFNL.AKBDNBOJNNE(legs));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Eyes, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Pants, CharacterSpritesDBAccessor.CIJJJBJNLIF(hairMat));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)79, CharacterSpritesDBAccessor.MIAIOBLCEND(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.PFABHCPKGCA(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.PFABHCPKGCA(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-6), CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)87, CharacterSpritesDBAccessor.GetMaterial(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-39), CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat2));
	}

	public void AFCBKPMBFKN(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Mouth, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Hair, DKDFNAGAFNL.AKBDNBOJNNE(nose));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Nose, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Nose, DKDFNAGAFNL.CONPDKDNOBO(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Hair, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-116), CharacterSpritesDBAccessor.CIJJJBJNLIF(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(beardMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat1));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)28, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat2));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-126), CharacterSpritesDBAccessor.GetMaterial(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)75, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat2));
	}

	public HumanInfo EMGJPKONKIC()
	{
		HumanInfo humanInfo = new HumanInfo();
		PNPMDLOFHNG(humanInfo);
		return humanInfo;
	}

	public void EGGGFKNBIJF(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Mouth, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Legs, DKDFNAGAFNL.AKBDNBOJNNE(nose));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(mouth));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(torso));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Eyes, DKDFNAGAFNL.AKBDNBOJNNE(legs));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MDBJNKMOKMM(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)79, CharacterSpritesDBAccessor.PFABHCPKGCA(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(irisMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(beardMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat1));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)52, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-57), CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-126), CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public void PFEOOGHCCII(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(skin));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Shoes, DKDFNAGAFNL.LGCAPCKCAGD(hair));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(eyes));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Nose, DKDFNAGAFNL.AKBDNBOJNNE(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(mouth));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(beard));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(torso));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Legs, DKDFNAGAFNL.AKBDNBOJNNE(legs));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Mouth, DKDFNAGAFNL.AKBDNBOJNNE(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-61), CharacterSpritesDBAccessor.MIAIOBLCEND(hatMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MIAIOBLCEND(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-109), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)124, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-114), CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public void HPIPOGJDJEP(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(skin));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Legs, DKDFNAGAFNL.CONPDKDNOBO(hair));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Eyes, DKDFNAGAFNL.LGCAPCKCAGD(eyes));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.OKNNCEAGNDF(beard));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Mouth, DKDFNAGAFNL.LGCAPCKCAGD(legs));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Shoes, DKDFNAGAFNL.CONPDKDNOBO(shoes));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-125), CharacterSpritesDBAccessor.CIJJJBJNLIF(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MIAIOBLCEND(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)58, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-8), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)28, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public void OABLCHJPPIN(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Hair, DKDFNAGAFNL.CONPDKDNOBO(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Eyes, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Nose, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Mouth, DKDFNAGAFNL.CONPDKDNOBO(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(beard));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(torso));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Legs, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Shoes, DKDFNAGAFNL.CONPDKDNOBO(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hat, CharacterSpritesDBAccessor.GetMaterial(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(torsoMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.GetMaterial(legsMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants2, CharacterSpritesDBAccessor.GetMaterial(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants3, CharacterSpritesDBAccessor.GetMaterial(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Shoes2, CharacterSpritesDBAccessor.GetMaterial(shoesMat2));
	}

	public void MGLDOIMAGPF(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Mouth, DKDFNAGAFNL.LGCAPCKCAGD(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(nose));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Beard, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(torso));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(skinMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.CIJJJBJNLIF(hairMat));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-44), CharacterSpritesDBAccessor.CIJJJBJNLIF(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.PFABHCPKGCA(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Beard, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-29), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)102, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-104), CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat2));
	}

	public HumanInfo KDJIDHMPBJK()
	{
		HumanInfo humanInfo = new HumanInfo();
		COCLAEENIGE(humanInfo);
		return humanInfo;
	}

	public HumanInfo JKOMBMBMIJP()
	{
		HumanInfo humanInfo = new HumanInfo();
		EDKGGGEKIJG(humanInfo);
		return humanInfo;
	}

	public HumanInfo DNCFJOJIKIP()
	{
		HumanInfo humanInfo = new HumanInfo();
		KEKGKFPJGBF(humanInfo);
		return humanInfo;
	}

	public void NAEEGDAGIAO(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Hair, DKDFNAGAFNL.LGCAPCKCAGD(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Hair, DKDFNAGAFNL.OKNNCEAGNDF(eyes));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Eyes, DKDFNAGAFNL.AKBDNBOJNNE(nose));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Legs, DKDFNAGAFNL.OKNNCEAGNDF(beard));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(legs));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Nose, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(skinMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)108, CharacterSpritesDBAccessor.MIAIOBLCEND(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.CIJJJBJNLIF(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)105, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)44, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)64, CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat2));
	}

	public void CMAHNFKIBPP(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.OKNNCEAGNDF(skin));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Hair, DKDFNAGAFNL.AKBDNBOJNNE(eyes));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Legs, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Mouth, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.OKNNCEAGNDF(torso));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Nose, DKDFNAGAFNL.AKBDNBOJNNE(legs));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Mouth, DKDFNAGAFNL.AKBDNBOJNNE(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)23, CharacterSpritesDBAccessor.CIJJJBJNLIF(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(beardMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-38), CharacterSpritesDBAccessor.GetMaterial(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)117, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Tool, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat2));
	}

	public void CIEKFFLMJJN(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Hair, DKDFNAGAFNL.LGCAPCKCAGD(hair));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Hair, DKDFNAGAFNL.LGCAPCKCAGD(eyes));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Hair, DKDFNAGAFNL.LGCAPCKCAGD(nose));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Hair, DKDFNAGAFNL.CONPDKDNOBO(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Nose, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Mouth, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MIAIOBLCEND(hairMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes2, CharacterSpritesDBAccessor.HACHFHGFFEB(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.CIJJJBJNLIF(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.GetMaterial(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)121, CharacterSpritesDBAccessor.GetMaterial(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-119), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-128), CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat2));
	}

	public HumanInfo OLCGLAMLEKG()
	{
		HumanInfo humanInfo = new HumanInfo();
		IBKDMAPKIDI(humanInfo);
		return humanInfo;
	}

	public void KGGEPMPAKOM(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Nose, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Eyes, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Legs, DKDFNAGAFNL.OKNNCEAGNDF(nose));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Mouth, DKDFNAGAFNL.LGCAPCKCAGD(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Nose, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Shoes, DKDFNAGAFNL.AKBDNBOJNNE(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Nose, DKDFNAGAFNL.LGCAPCKCAGD(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(skinMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-99), CharacterSpritesDBAccessor.MIAIOBLCEND(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.PFABHCPKGCA(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)19, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat2));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-74), CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-51), CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat2));
	}

	public void IBKDMAPKIDI(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Nose, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(eyes));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Beard, DKDFNAGAFNL.AKBDNBOJNNE(nose));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Legs, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Hair, DKDFNAGAFNL.LGCAPCKCAGD(legs));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Shoes, DKDFNAGAFNL.AKBDNBOJNNE(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(skinMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(hairMat));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)109, CharacterSpritesDBAccessor.HACHFHGFFEB(hatMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.HACHFHGFFEB(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat2));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-97), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-7), CharacterSpritesDBAccessor.GetMaterial(shoesMat2));
	}

	public HumanInfo EKDNKDJCNIE()
	{
		HumanInfo humanInfo = new HumanInfo();
		PIGADGGMKNE(humanInfo);
		return humanInfo;
	}

	public HumanInfo KNIJPPCDAAC()
	{
		HumanInfo humanInfo = new HumanInfo();
		KCAOLDPFHPL(humanInfo);
		return humanInfo;
	}

	public void GFIIPEBHOHI(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Hair, DKDFNAGAFNL.AKBDNBOJNNE(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(nose));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Shoes, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Beard, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-6), CharacterSpritesDBAccessor.GetMaterial(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.MIAIOBLCEND(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat1));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-69), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)108, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)33, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat2));
	}

	public void PBPMGIPNFKK(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Legs, DKDFNAGAFNL.AKBDNBOJNNE(eyes));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Beard, DKDFNAGAFNL.LGCAPCKCAGD(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Mouth, DKDFNAGAFNL.DLFHMEEOJCI(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(beard));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(torso));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Eyes, DKDFNAGAFNL.LGCAPCKCAGD(legs));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Hair, DKDFNAGAFNL.AKBDNBOJNNE(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.HACHFHGFFEB(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-81), CharacterSpritesDBAccessor.PFABHCPKGCA(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.CIJJJBJNLIF(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.MIAIOBLCEND(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-2), CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)61, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-120), CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public HumanInfo NMMOMBBGAPN()
	{
		HumanInfo humanInfo = new HumanInfo();
		LHOIGEIDHIA(humanInfo);
		return humanInfo;
	}

	public void FDCFIHLDAFN(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(hair));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Eyes, DKDFNAGAFNL.DLFHMEEOJCI(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(mouth));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Hair, DKDFNAGAFNL.CONPDKDNOBO(beard));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(torso));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)79, CharacterSpritesDBAccessor.MIAIOBLCEND(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.HACHFHGFFEB(beardMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Pants, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)112, CharacterSpritesDBAccessor.GetMaterial(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-12), CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat2));
	}

	public void HONBDCOHKNP(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(eyes));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(nose));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Mouth, DKDFNAGAFNL.LGCAPCKCAGD(mouth));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Nose, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)114, CharacterSpritesDBAccessor.CIJJJBJNLIF(hatMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)119, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.TorsoExtra, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)117, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public HumanInfo KDONCKANFDK()
	{
		HumanInfo humanInfo = new HumanInfo();
		EGGGFKNBIJF(humanInfo);
		return humanInfo;
	}

	public HumanInfo NAAGCBMPMJC()
	{
		HumanInfo humanInfo = new HumanInfo();
		MGLDOIMAGPF(humanInfo);
		return humanInfo;
	}

	public void CENNCJBADOO(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(skin));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Shoes, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Nose, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Legs, DKDFNAGAFNL.LGCAPCKCAGD(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Legs, DKDFNAGAFNL.CONPDKDNOBO(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MIAIOBLCEND(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)102, CharacterSpritesDBAccessor.MIAIOBLCEND(hatMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)124, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-56), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Pants3, CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat2));
	}

	public void JJDEOJACBIK(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Mouth, DKDFNAGAFNL.CONPDKDNOBO(hair));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(nose));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Legs, DKDFNAGAFNL.LGCAPCKCAGD(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.DLFHMEEOJCI(beard));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Mouth, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Legs, DKDFNAGAFNL.LGCAPCKCAGD(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.HACHFHGFFEB(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-45), CharacterSpritesDBAccessor.MDBJNKMOKMM(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)62, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-80), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-1), CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public void LCJBMNNFMII(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(skin));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Shoes, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Eyes, DKDFNAGAFNL.AKBDNBOJNNE(eyes));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(mouth));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Beard, DKDFNAGAFNL.OKNNCEAGNDF(beard));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Nose, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-66), CharacterSpritesDBAccessor.GetMaterial(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.GetMaterial(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-8), CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)114, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)71, CharacterSpritesDBAccessor.GetMaterial(shoesMat2));
	}

	public HumanInfo NIMNFHPPEDD()
	{
		HumanInfo humanInfo = new HumanInfo();
		JJDEOJACBIK(humanInfo);
		return humanInfo;
	}

	public void KEKGKFPJGBF(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(skin));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(eyes));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Mouth, DKDFNAGAFNL.AKBDNBOJNNE(nose));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Mouth, DKDFNAGAFNL.LGCAPCKCAGD(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(beard));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Beard, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Hair, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Shoes, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)49, CharacterSpritesDBAccessor.HACHFHGFFEB(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.PFABHCPKGCA(irisMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.MIAIOBLCEND(beardMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso3, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-115), CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)100, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public void OJIGKLOMMEG(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Beard, DKDFNAGAFNL.AKBDNBOJNNE(hair));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Mouth, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Eyes, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Beard, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Hair, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(legs));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Mouth, DKDFNAGAFNL.AKBDNBOJNNE(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-1), CharacterSpritesDBAccessor.GetMaterial(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.PFABHCPKGCA(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat1));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)62, CharacterSpritesDBAccessor.GetMaterial(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-118), CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-88), CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat2));
	}

	public HumanInfo MMANMILFLLM()
	{
		HumanInfo humanInfo = new HumanInfo();
		GHGONLGIGPH(humanInfo);
		return humanInfo;
	}

	public void JIOBGDMCBNH(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Beard, DKDFNAGAFNL.DLFHMEEOJCI(eyes));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(nose));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Nose, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Shoes, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Hair, DKDFNAGAFNL.CONPDKDNOBO(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(skinMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-39), CharacterSpritesDBAccessor.MDBJNKMOKMM(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(beardMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)71, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-110), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)27, CharacterSpritesDBAccessor.GetMaterial(shoesMat2));
	}

	public void GHGONLGIGPH(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Hair, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(nose));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Hair, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.OKNNCEAGNDF(beard));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Mouth, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MDBJNKMOKMM(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.ToolMug, CharacterSpritesDBAccessor.GetMaterial(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.CIJJJBJNLIF(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)28, CharacterSpritesDBAccessor.GetMaterial(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-104), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat2));
	}

	public HumanInfo NGKKIPOMEDI()
	{
		HumanInfo humanInfo = new HumanInfo();
		JDBLFBKJCHO(humanInfo);
		return humanInfo;
	}

	public HumanInfo AGFFIDOGHBG()
	{
		HumanInfo humanInfo = new HumanInfo();
		IBEPBJGGCOI(humanInfo);
		return humanInfo;
	}

	public HumanInfo LFEMBDPPAPO()
	{
		HumanInfo humanInfo = new HumanInfo();
		LCJBMNNFMII(humanInfo);
		return humanInfo;
	}

	public void EMONBHCBCNJ(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(skin));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Hair, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Legs, DKDFNAGAFNL.LGCAPCKCAGD(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Nose, DKDFNAGAFNL.DLFHMEEOJCI(mouth));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Shoes, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(torso));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Eyes, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Nose, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Shoes, CharacterSpritesDBAccessor.CIJJJBJNLIF(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-64), CharacterSpritesDBAccessor.MDBJNKMOKMM(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(irisMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.HACHFHGFFEB(beardMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Hair, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-121), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-81), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public HumanInfo BFMCNANBPMI()
	{
		HumanInfo humanInfo = new HumanInfo();
		PFNILCDDLML(humanInfo);
		return humanInfo;
	}

	public HumanInfo NECAFFGKIGF()
	{
		HumanInfo humanInfo = new HumanInfo();
		KGGEPMPAKOM(humanInfo);
		return humanInfo;
	}

	public void HAOLLCPGEGG(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Mouth, DKDFNAGAFNL.CONPDKDNOBO(hair));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Mouth, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(nose));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Hair, DKDFNAGAFNL.CONPDKDNOBO(mouth));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Hair, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.MIAIOBLCEND(hairMat));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)66, CharacterSpritesDBAccessor.MDBJNKMOKMM(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-125), CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat2));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-1), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-120), CharacterSpritesDBAccessor.GetMaterial(shoesMat2));
	}

	public HumanInfo GIJPKBKJKEN()
	{
		HumanInfo humanInfo = new HumanInfo();
		OCGDLLDCGDE(humanInfo);
		return humanInfo;
	}

	public void COCLAEENIGE(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Shoes, DKDFNAGAFNL.LGCAPCKCAGD(hair));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Mouth, DKDFNAGAFNL.LGCAPCKCAGD(eyes));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Hair, DKDFNAGAFNL.DLFHMEEOJCI(nose));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(mouth));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Eyes, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Eyes, DKDFNAGAFNL.OKNNCEAGNDF(legs));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Eyes, DKDFNAGAFNL.LGCAPCKCAGD(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-68), CharacterSpritesDBAccessor.CIJJJBJNLIF(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.HACHFHGFFEB(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)87, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-87), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso3, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)127, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public void FIBGHKPCMJJ(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(skin));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Eyes, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Nose, DKDFNAGAFNL.LGCAPCKCAGD(eyes));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(nose));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Beard, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(beard));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Legs, DKDFNAGAFNL.OKNNCEAGNDF(legs));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(skinMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-91), CharacterSpritesDBAccessor.GetMaterial(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.PFABHCPKGCA(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)87, CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)111, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-10), CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat2));
	}

	public void LFOGNGHELDK(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Eyes, DKDFNAGAFNL.LGCAPCKCAGD(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.OKNNCEAGNDF(eyes));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Hair, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(mouth));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(beard));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(torso));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Beard, DKDFNAGAFNL.LGCAPCKCAGD(legs));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Nose, DKDFNAGAFNL.AKBDNBOJNNE(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(skinMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)76, CharacterSpritesDBAccessor.HACHFHGFFEB(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(beardMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat1));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)102, CharacterSpritesDBAccessor.GetMaterial(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)39, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Beard, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-126), CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat2));
	}

	public HumanInfo EPCOPOEFBGH()
	{
		HumanInfo humanInfo = new HumanInfo();
		GFIIPEBHOHI(humanInfo);
		return humanInfo;
	}

	public void MMLGHKFOHMO(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(eyes));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Legs, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Eyes, DKDFNAGAFNL.DLFHMEEOJCI(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(torso));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(hairMat));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-100), CharacterSpritesDBAccessor.HACHFHGFFEB(hatMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(legsMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-72), CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-124), CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-42), CharacterSpritesDBAccessor.HACHFHGFFEB(shoesMat2));
	}

	public void DONFANBLLFJ(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Mouth, DKDFNAGAFNL.LGCAPCKCAGD(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Eyes, DKDFNAGAFNL.DLFHMEEOJCI(mouth));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Legs, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Eyes, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Eyes, DKDFNAGAFNL.OKNNCEAGNDF(shoes));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(skinMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.CIJJJBJNLIF(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-111), CharacterSpritesDBAccessor.PFABHCPKGCA(hatMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(beardMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(torsoMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)89, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-38), CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-73), CharacterSpritesDBAccessor.GetMaterial(shoesMat2));
	}

	public HumanInfo EJPDIOHELNL()
	{
		HumanInfo humanInfo = new HumanInfo();
		BIOJHCFGHJA(humanInfo);
		return humanInfo;
	}

	public HumanInfo NNDHFKIAGDI()
	{
		HumanInfo humanInfo = new HumanInfo();
		JDMINLHFJHN(humanInfo);
		return humanInfo;
	}

	public HumanInfoMsg(HumanInfo DKDFNAGAFNL)
	{
		gender = (byte)DKDFNAGAFNL.gender;
		skin = (short)DKDFNAGAFNL.FHCGPOIPNNB(BodyPart.Skin);
		hair = (short)DKDFNAGAFNL.FHCGPOIPNNB(BodyPart.Hair);
		eyes = (short)DKDFNAGAFNL.FHCGPOIPNNB(BodyPart.Eyes);
		mouth = (short)DKDFNAGAFNL.FHCGPOIPNNB(BodyPart.Mouth);
		beard = (short)DKDFNAGAFNL.FHCGPOIPNNB(BodyPart.Beard);
		nose = (short)DKDFNAGAFNL.FHCGPOIPNNB(BodyPart.Nose);
		torso = (short)DKDFNAGAFNL.FHCGPOIPNNB(BodyPart.Torso);
		legs = (short)DKDFNAGAFNL.FHCGPOIPNNB(BodyPart.Legs);
		shoes = (short)DKDFNAGAFNL.FHCGPOIPNNB(BodyPart.Shoes);
		skinMat = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Skin);
		hairMat = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Hair);
		hatMat = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Hat);
		irisMat = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Iris);
		beardMat = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Beard);
		torsoMat1 = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Torso1);
		torsoMat2 = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Torso2);
		torsoMat3 = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Torso3);
		legsMat1 = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Pants);
		legsMat2 = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Pants2);
		legsMat3 = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Pants3);
		shoesMat1 = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Shoes);
		shoesMat2 = (short)DKDFNAGAFNL.BJPCEPJOHGN(CharacterLayer.Shoes2);
	}

	public HumanInfo LOLFGLGFGBI()
	{
		HumanInfo humanInfo = new HumanInfo();
		CMAHNFKIBPP(humanInfo);
		return humanInfo;
	}

	public HumanInfo OPFNKDJNPJI()
	{
		HumanInfo humanInfo = new HumanInfo();
		KCAOLDPFHPL(humanInfo);
		return humanInfo;
	}

	public HumanInfo EGLLBNNJKOM()
	{
		HumanInfo humanInfo = new HumanInfo();
		BIOJHCFGHJA(humanInfo);
		return humanInfo;
	}

	public HumanInfo KLPEJDGNAEK()
	{
		HumanInfo humanInfo = new HumanInfo();
		OCGDLLDCGDE(humanInfo);
		return humanInfo;
	}

	public void AOCBNCCPFAF(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Legs, DKDFNAGAFNL.LGCAPCKCAGD(eyes));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Eyes, DKDFNAGAFNL.OKNNCEAGNDF(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Hair, DKDFNAGAFNL.DLFHMEEOJCI(beard));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Eyes, DKDFNAGAFNL.AKBDNBOJNNE(legs));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-74), CharacterSpritesDBAccessor.MIAIOBLCEND(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(irisMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.HACHFHGFFEB(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Shoes, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-98), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-76), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-66), CharacterSpritesDBAccessor.GetMaterial(shoesMat2));
	}

	public void PFNILCDDLML(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Skin, DKDFNAGAFNL.AKBDNBOJNNE(skin));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Nose, DKDFNAGAFNL.LGCAPCKCAGD(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Shoes, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Legs, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Mouth, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Eyes, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Mouth, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(skinMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.CIJJJBJNLIF(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)62, CharacterSpritesDBAccessor.CIJJJBJNLIF(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)63, CharacterSpritesDBAccessor.GetMaterial(legsMat2));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-128), CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-58), CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public void NBPDGKNAIFJ(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(skin));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(eyes));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Nose, DKDFNAGAFNL.LGCAPCKCAGD(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Hair, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Legs, DKDFNAGAFNL.CONPDKDNOBO(beard));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.OKNNCEAGNDF(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(legs));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Mouth, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)82, CharacterSpritesDBAccessor.CIJJJBJNLIF(hatMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso3, CharacterSpritesDBAccessor.CIJJJBJNLIF(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Pants, CharacterSpritesDBAccessor.MDBJNKMOKMM(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat1));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-74), CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-107), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)77, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat2));
	}

	public void PIGADGGMKNE(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Beard, DKDFNAGAFNL.AKBDNBOJNNE(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Eyes, DKDFNAGAFNL.CONPDKDNOBO(eyes));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Nose, DKDFNAGAFNL.AKBDNBOJNNE(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Nose, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.LGCAPCKCAGD(torso));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Beard, DKDFNAGAFNL.LGCAPCKCAGD(legs));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Nose, DKDFNAGAFNL.CONPDKDNOBO(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-108), CharacterSpritesDBAccessor.PFABHCPKGCA(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Pants, CharacterSpritesDBAccessor.CIJJJBJNLIF(beardMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso3, CharacterSpritesDBAccessor.MIAIOBLCEND(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(torsoMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-14), CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat2));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)18, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-120), CharacterSpritesDBAccessor.GetMaterial(shoesMat2));
	}

	public void FEDLDJJJJEO(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Eyes, DKDFNAGAFNL.OKNNCEAGNDF(hair));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Hair, DKDFNAGAFNL.AKBDNBOJNNE(eyes));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Nose, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Beard, DKDFNAGAFNL.LGCAPCKCAGD(mouth));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Hair, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.GetMaterial(hairMat));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)21, CharacterSpritesDBAccessor.HACHFHGFFEB(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.HACHFHGFFEB(irisMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.HACHFHGFFEB(beardMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(torsoMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Hair, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-33), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-82), CharacterSpritesDBAccessor.HACHFHGFFEB(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-71), CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat2));
	}

	public HumanInfo DKJAGFAMDBD()
	{
		HumanInfo humanInfo = new HumanInfo();
		MJHLPBPKHGH(humanInfo);
		return humanInfo;
	}

	public void ECICLLIJKLD(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(skin));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Torso, DKDFNAGAFNL.AKBDNBOJNNE(hair));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Shoes, DKDFNAGAFNL.AKBDNBOJNNE(eyes));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(nose));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Eyes, DKDFNAGAFNL.CONPDKDNOBO(mouth));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Beard, DKDFNAGAFNL.CONPDKDNOBO(beard));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Skin, DKDFNAGAFNL.CONPDKDNOBO(torso));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Legs, DKDFNAGAFNL.DLFHMEEOJCI(legs));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(shoes));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(skinMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-27), CharacterSpritesDBAccessor.MDBJNKMOKMM(hatMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(legsMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-79), CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat2));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)36, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)39, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat2));
	}

	public HumanInfo BBFMMKFDOGL()
	{
		HumanInfo humanInfo = new HumanInfo();
		COCLAEENIGE(humanInfo);
		return humanInfo;
	}

	public HumanInfo CKACGHAGMNA()
	{
		HumanInfo humanInfo = new HumanInfo();
		HPIPOGJDJEP(humanInfo);
		return humanInfo;
	}

	public void JDMINLHFJHN(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Nose, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Mouth, DKDFNAGAFNL.OKNNCEAGNDF(eyes));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Hair, DKDFNAGAFNL.DLFHMEEOJCI(nose));
		DKDFNAGAFNL.JPPLJJDCNMF(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Shoes, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.DLFHMEEOJCI(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Eyes, DKDFNAGAFNL.LGCAPCKCAGD(legs));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(skinMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-128), CharacterSpritesDBAccessor.HACHFHGFFEB(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.PFABHCPKGCA(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.HACHFHGFFEB(torsoMat1));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat2));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Hair, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)66, CharacterSpritesDBAccessor.CIJJJBJNLIF(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-22), CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.MIAIOBLCEND(shoesMat1));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-12), CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat2));
	}

	public void MAMCGGIFFGH(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.gender = (Gender)gender;
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.CONPDKDNOBO(skin));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Legs, DKDFNAGAFNL.AKBDNBOJNNE(hair));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Legs, DKDFNAGAFNL.LGCAPCKCAGD(eyes));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Mouth, DKDFNAGAFNL.AKBDNBOJNNE(nose));
		DKDFNAGAFNL.EIJNLBCNMBA(BodyPart.Mouth, DKDFNAGAFNL.AKBDNBOJNNE(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Shoes, DKDFNAGAFNL.LGCAPCKCAGD(beard));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(torso));
		DKDFNAGAFNL.AMJNIFPBBJF(BodyPart.Nose, DKDFNAGAFNL.CONPDKDNOBO(legs));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Eyes, DKDFNAGAFNL.DLFHMEEOJCI(shoes));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(skinMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.HACHFHGFFEB(hairMat));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)(-29), CharacterSpritesDBAccessor.MDBJNKMOKMM(hatMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.PFABHCPKGCA(irisMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat1));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Beard, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat2));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.CIJJJBJNLIF(torsoMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Shoes, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)66, CharacterSpritesDBAccessor.GetMaterial(legsMat2));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)63, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat3));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.MDBJNKMOKMM(shoesMat1));
		DKDFNAGAFNL.OIENACLLJGE((CharacterLayer)(-68), CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat2));
	}

	public void EDKGGGEKIJG(HumanInfo DKDFNAGAFNL)
	{
		DKDFNAGAFNL.MNCIIMJKMDN((Gender)gender);
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Skin, DKDFNAGAFNL.OKNNCEAGNDF(skin));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Shoes, DKDFNAGAFNL.DLFHMEEOJCI(hair));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Mouth, DKDFNAGAFNL.DLFHMEEOJCI(eyes));
		DKDFNAGAFNL.NCMHHJKBMBH(BodyPart.Torso, DKDFNAGAFNL.LGCAPCKCAGD(nose));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.OKNNCEAGNDF(mouth));
		DKDFNAGAFNL.LALJHMIDEMP(BodyPart.Beard, DKDFNAGAFNL.AKBDNBOJNNE(beard));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Torso, DKDFNAGAFNL.DLFHMEEOJCI(torso));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Shoes, DKDFNAGAFNL.OKNNCEAGNDF(legs));
		DKDFNAGAFNL.KDACAOIDLEO(BodyPart.Legs, DKDFNAGAFNL.LGCAPCKCAGD(shoes));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(skinMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.PFABHCPKGCA(hairMat));
		DKDFNAGAFNL.PGOAOEEJMGK((CharacterLayer)(-127), CharacterSpritesDBAccessor.MIAIOBLCEND(hatMat));
		DKDFNAGAFNL.OIENACLLJGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.MDBJNKMOKMM(irisMat));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso3, CharacterSpritesDBAccessor.CIJJJBJNLIF(beardMat));
		DKDFNAGAFNL.GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(torsoMat1));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.PFABHCPKGCA(torsoMat2));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(torsoMat3));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Torso3, CharacterSpritesDBAccessor.PFABHCPKGCA(legsMat1));
		DKDFNAGAFNL.PHOEIGIKFGE((CharacterLayer)113, CharacterSpritesDBAccessor.MDBJNKMOKMM(legsMat2));
		DKDFNAGAFNL.PGOAOEEJMGK(CharacterLayer.Pants, CharacterSpritesDBAccessor.MIAIOBLCEND(legsMat3));
		DKDFNAGAFNL.PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(shoesMat1));
		DKDFNAGAFNL.GBNPMEBJCFD((CharacterLayer)(-47), CharacterSpritesDBAccessor.CIJJJBJNLIF(shoesMat2));
	}
}
