using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Rewired;
using Sirenix.Utilities;
using UnityEngine;

public static class InputUtils
{
	[CompilerGenerated]
	private sealed class OFDDJGPEJGL
	{
		public Gender gender;

		public MatchEvaluator _003C_003E9__0;

		internal string CEGBIMPJNID(Match match)
		{
			string text = match.Value.Substring(11, match.Value.Length - 12).Trim();
			try
			{
				return (gender == Gender.Male) ? text.Split('/')[0] : text.Split('/')[1];
			}
			catch (Exception)
			{
				return string.Empty;
			}
		}
	}

	[CompilerGenerated]
	private sealed class DEHNBGIEFFG
	{
		public int startIndex;

		public EmployeeInfo employeeInfo;

		public MatchEvaluator _003C_003E9__0;

		internal string EFECLBLICJI(Match match)
		{
			string text = match.Value.Substring(startIndex, match.Value.Length - (startIndex + 1)).Trim();
			try
			{
				if (employeeInfo == null || string.IsNullOrEmpty(employeeInfo.name))
				{
					return text.Split('/')[0];
				}
				return (employeeInfo.gender == Gender.Male) ? text.Split('/')[0] : text.Split('/')[1];
			}
			catch (Exception)
			{
				return string.Empty;
			}
		}
	}

	[CompilerGenerated]
	private sealed class LJCCEEPKJMF
	{
		public int playerNum;

		public MatchEvaluator _003C_003E9__0;

		internal string NABAEHBFNKH(Match match)
		{
			string text = match.Value.Substring(14, match.Value.Length - 15).Trim();
			try
			{
				return (PlayerController.GetPlayer(playerNum).characterCreator.humanInfo.gender == Gender.Male) ? text.Split('/')[0] : text.Split('/')[1];
			}
			catch (Exception)
			{
				return string.Empty;
			}
		}
	}

	private static string LBOJBODPCLC = "#9A3F00";

	private static string ACHLMJCGDGA = "#9A3F00";

	private static readonly Dictionary<string, string> PPEOJGEPLOC = new Dictionary<string, string>
	{
		{ "₥", "M" },
		{ "Ø", "O" },
		{ "₦", "N" },
		{ "€", "E" },
		{ "¥", "Y" },
		{ "ɨ", "i" },
		{ "օ", "o" },
		{ "ռ", "n" },
		{ "ǟ", "a" },
		{ "ʍ", "w" },
		{ "ɛ", "e" },
		{ "₱", "P" },
		{ "₲", "G" },
		{ "₭", "K" },
		{ "₡", "C" },
		{ "₮", "T" },
		{ "₵", "C" },
		{ "₤", "L" },
		{ "₨", "R" },
		{ "₫", "D" },
		{ "Đ", "D" },
		{ "đ", "d" },
		{ "ø", "o" },
		{ "ß", "ss" },
		{ "Ⓐ", "A" },
		{ "Ⓑ", "B" },
		{ "Ⓒ", "C" },
		{ "Ⓓ", "D" },
		{ "Ⓔ", "E" },
		{ "Ⓕ", "F" },
		{ "Ⓖ", "G" },
		{ "Ⓗ", "H" },
		{ "Ⓘ", "I" },
		{ "Ⓙ", "J" },
		{ "Ⓚ", "K" },
		{ "Ⓛ", "L" },
		{ "Ⓜ", "M" },
		{ "Ⓝ", "N" },
		{ "Ⓞ", "O" },
		{ "Ⓟ", "P" },
		{ "Ⓠ", "Q" },
		{ "Ⓡ", "R" },
		{ "Ⓢ", "S" },
		{ "Ⓣ", "T" },
		{ "Ⓤ", "U" },
		{ "Ⓥ", "V" },
		{ "Ⓦ", "W" },
		{ "Ⓧ", "X" },
		{ "Ⓨ", "Y" },
		{ "Ⓩ", "Z" },
		{ "ⓐ", "a" },
		{ "ⓑ", "b" },
		{ "ⓒ", "c" },
		{ "ⓓ", "d" },
		{ "ⓔ", "e" },
		{ "ⓕ", "f" },
		{ "ⓖ", "g" },
		{ "ⓗ", "h" },
		{ "ⓘ", "i" },
		{ "ⓙ", "j" },
		{ "ⓚ", "k" },
		{ "ⓛ", "l" },
		{ "ⓜ", "m" },
		{ "ⓝ", "n" },
		{ "ⓞ", "o" },
		{ "ⓟ", "p" },
		{ "ⓠ", "q" },
		{ "ⓡ", "r" },
		{ "ⓢ", "s" },
		{ "ⓣ", "t" },
		{ "ⓤ", "u" },
		{ "ⓥ", "v" },
		{ "ⓦ", "w" },
		{ "ⓧ", "x" },
		{ "ⓨ", "y" },
		{ "ⓩ", "z" },
		{ "ᴀ", "A" },
		{ "ʙ", "B" },
		{ "ᴄ", "C" },
		{ "ᴅ", "D" },
		{ "ᴇ", "E" },
		{ "ꜰ", "F" },
		{ "ɢ", "G" },
		{ "ʜ", "H" },
		{ "ɪ", "I" },
		{ "ᴊ", "J" },
		{ "ᴋ", "K" },
		{ "ʟ", "L" },
		{ "ᴍ", "M" },
		{ "ɴ", "N" },
		{ "ᴏ", "O" },
		{ "ᴘ", "P" },
		{ "ʀ", "R" },
		{ "ꞅ", "S" },
		{ "ᴛ", "T" },
		{ "ᴜ", "U" },
		{ "ᴠ", "V" },
		{ "ᴡ", "W" },
		{ "ʏ", "Y" },
		{ "ᴢ", "Z" },
		{ "\ud835\udcd0", "A" },
		{ "\ud835\udcd1", "B" },
		{ "\ud835\udcd2", "C" },
		{ "\ud835\udcd3", "D" },
		{ "\ud835\udcd4", "E" },
		{ "\ud835\udcd5", "F" },
		{ "\ud835\udcd6", "G" },
		{ "\ud835\udcd7", "H" },
		{ "\ud835\udcd8", "I" },
		{ "\ud835\udcd9", "J" },
		{ "\ud835\udcda", "K" },
		{ "\ud835\udcdb", "L" },
		{ "\ud835\udcdc", "M" },
		{ "\ud835\udcdd", "N" },
		{ "\ud835\udcde", "O" },
		{ "\ud835\udcdf", "P" },
		{ "\ud835\udce0", "Q" },
		{ "\ud835\udce1", "R" },
		{ "\ud835\udce2", "S" },
		{ "\ud835\udce3", "T" },
		{ "\ud835\udce4", "U" },
		{ "\ud835\udce5", "V" },
		{ "\ud835\udce6", "W" },
		{ "\ud835\udce7", "X" },
		{ "\ud835\udce8", "Y" },
		{ "\ud835\udce9", "Z" },
		{ "\ud835\udcea", "a" },
		{ "\ud835\udceb", "b" },
		{ "\ud835\udcec", "c" },
		{ "\ud835\udced", "d" },
		{ "\ud835\udcee", "e" },
		{ "\ud835\udcef", "f" },
		{ "\ud835\udcf0", "g" },
		{ "\ud835\udcf1", "h" },
		{ "\ud835\udcf2", "i" },
		{ "\ud835\udcf3", "j" },
		{ "\ud835\udcf4", "k" },
		{ "\ud835\udcf5", "l" },
		{ "\ud835\udcf6", "m" },
		{ "\ud835\udcf7", "n" },
		{ "\ud835\udcf8", "o" },
		{ "\ud835\udcf9", "p" },
		{ "\ud835\udcfa", "q" },
		{ "\ud835\udcfb", "r" },
		{ "\ud835\udcfc", "s" },
		{ "\ud835\udcfd", "t" },
		{ "\ud835\udcfe", "u" },
		{ "\ud835\udcff", "v" },
		{ "\ud835\udd00", "w" },
		{ "\ud835\udd01", "x" },
		{ "\ud835\udd02", "y" },
		{ "\ud835\udd03", "z" },
		{ "Ａ", "A" },
		{ "Ｂ", "B" },
		{ "Ｃ", "C" },
		{ "Ｄ", "D" },
		{ "Ｅ", "E" },
		{ "Ｆ", "F" },
		{ "Ｇ", "G" },
		{ "Ｈ", "H" },
		{ "Ｉ", "I" },
		{ "Ｊ", "J" },
		{ "Ｋ", "K" },
		{ "Ｌ", "L" },
		{ "Ｍ", "M" },
		{ "Ｎ", "N" },
		{ "Ｏ", "O" },
		{ "Ｐ", "P" },
		{ "Ｑ", "Q" },
		{ "Ｒ", "R" },
		{ "Ｓ", "S" },
		{ "Ｔ", "T" },
		{ "Ｕ", "U" },
		{ "Ｖ", "V" },
		{ "Ｗ", "W" },
		{ "Ｘ", "X" },
		{ "Ｙ", "Y" },
		{ "Ｚ", "Z" },
		{ "ａ", "a" },
		{ "ｂ", "b" },
		{ "ｃ", "c" },
		{ "ｄ", "d" },
		{ "ｅ", "e" },
		{ "ｆ", "f" },
		{ "ｇ", "g" },
		{ "ｈ", "h" },
		{ "ｉ", "i" },
		{ "ｊ", "j" },
		{ "ｋ", "k" },
		{ "ｌ", "l" },
		{ "ｍ", "m" },
		{ "ｎ", "n" },
		{ "ｏ", "o" },
		{ "ｐ", "p" },
		{ "ｑ", "q" },
		{ "ｒ", "r" },
		{ "ｓ", "s" },
		{ "ｔ", "t" },
		{ "ｕ", "u" },
		{ "ｖ", "v" },
		{ "ｗ", "w" },
		{ "ｘ", "x" },
		{ "ｙ", "y" },
		{ "ｚ", "z" },
		{ "ᴬ", "A" },
		{ "ᴮ", "B" },
		{ "ᴰ", "D" },
		{ "ᴱ", "E" },
		{ "ᴳ", "G" },
		{ "ᴴ", "H" },
		{ "ᴵ", "I" },
		{ "ᴶ", "J" },
		{ "ᴷ", "K" },
		{ "ᴸ", "L" },
		{ "ᴹ", "M" },
		{ "ᴺ", "N" },
		{ "ᴼ", "O" },
		{ "ᴾ", "P" },
		{ "ᴿ", "R" },
		{ "ᵀ", "T" },
		{ "ᵁ", "U" },
		{ "ᵂ", "W" },
		{ "ᵃ", "a" },
		{ "ᵇ", "b" },
		{ "ᶜ", "c" },
		{ "ᵈ", "d" },
		{ "ᵉ", "e" },
		{ "ᶠ", "f" },
		{ "ᵍ", "g" },
		{ "ʰ", "h" },
		{ "ⁱ", "i" },
		{ "ʲ", "j" },
		{ "ᵏ", "k" },
		{ "ˡ", "l" },
		{ "ᵐ", "m" },
		{ "ⁿ", "n" },
		{ "ᵒ", "o" },
		{ "ᵖ", "p" },
		{ "ʳ", "r" },
		{ "ˢ", "s" },
		{ "ᵗ", "t" },
		{ "ᵘ", "u" },
		{ "ᵛ", "v" },
		{ "ʷ", "w" },
		{ "ˣ", "x" },
		{ "ʸ", "y" },
		{ "ᶻ", "z" },
		{ "\u0365", "" },
		{ "\u0363", "" },
		{ "\u036b", "" }
	};

	private static ActionElementMap FNIKKHCEKLO;

	private static string EOKBKAKDMGH;

	public static string CFFBEHMDPPK(string CAEDMEDBEGI, Gender HNLNENELPKI)
	{
		try
		{
			string value = "[NPCGender=";
			int num = 100;
			if (CAEDMEDBEGI.Contains(value))
			{
				Regex regex = new Regex("\\[NPCGender=[^\\]]*\\]");
				int num2 = CAEDMEDBEGI.Length - 1;
				int num3 = 0;
				while (num2 >= 0 && num3 < num)
				{
					num3++;
					int num4 = CAEDMEDBEGI.LastIndexOf(value, num2, StringComparison.OrdinalIgnoreCase);
					num2 = num4 - 1;
					if (num4 < 0)
					{
						continue;
					}
					string text = CAEDMEDBEGI.Substring(0, num4);
					string input = CAEDMEDBEGI.Substring(num4);
					string text2 = regex.Replace(input, delegate(Match match)
					{
						string text3 = match.Value.Substring(11, match.Value.Length - 12).Trim();
						try
						{
							return (HNLNENELPKI == Gender.Male) ? text3.Split('/')[0] : text3.Split('/')[1];
						}
						catch (Exception)
						{
							return string.Empty;
						}
					});
					CAEDMEDBEGI = text + text2;
				}
			}
		}
		catch (Exception ex)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)ex.Message);
			}
		}
		return CAEDMEDBEGI;
	}

	public static string NEOJFOPLCOF(CropSeason EECEKHKAAIH)
	{
		return EECEKHKAAIH switch
		{
			CropSeason.Spring => "<color=#18650E>" + LocalisationSystem.Get(EECEKHKAAIH.ToString()) + "</color>", 
			CropSeason.Summer => "<color=#A87700>" + LocalisationSystem.Get(EECEKHKAAIH.ToString()) + "</color>", 
			CropSeason.Autumn => "<color=#B20B0F>" + LocalisationSystem.Get(EECEKHKAAIH.ToString()) + "</color>", 
			_ => "<color=#1A4FB2>" + LocalisationSystem.Get(EECEKHKAAIH.ToString()) + "</color>", 
		};
	}

	public static string CMOBIDABHKM(int JIIGOACEIKL, string OKNOJJEFEBE)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		string INAPMPEEDPO = "";
		Controller val = ReInput.players.GetPlayer(JIIGOACEIKL - 1).controllers.GetLastActiveController();
		if (val == null)
		{
			val = (Controller)(object)PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard;
		}
		if ((int)val.type != 2)
		{
			AAPOEKOONKL(JIIGOACEIKL, (ControllerType)0, OKNOJJEFEBE, out INAPMPEEDPO, NGDDAAFCDIL: false);
			if (string.IsNullOrEmpty(INAPMPEEDPO))
			{
				AAPOEKOONKL(JIIGOACEIKL, (ControllerType)1, OKNOJJEFEBE, out INAPMPEEDPO, NGDDAAFCDIL: false);
			}
			return "<color=" + ((JIIGOACEIKL == 1) ? LBOJBODPCLC : ACHLMJCGDGA) + ">" + (string.IsNullOrEmpty(LocalisationSystem.Get(INAPMPEEDPO)) ? INAPMPEEDPO : LocalisationSystem.Get(INAPMPEEDPO)) + "</color>";
		}
		AAPOEKOONKL(JIIGOACEIKL, (ControllerType)2, OKNOJJEFEBE, out INAPMPEEDPO, NGDDAAFCDIL: false);
		return ButtonsContext.GetPlayer(JIIGOACEIKL).GetSpriteTagWithElementName(INAPMPEEDPO, val);
	}

	public static string LPGJFAOKMNE(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Invalid comparison between Unknown and I4
		try
		{
			int num = 50;
			EOKBKAKDMGH = "[ControllerType:";
			if (CAEDMEDBEGI.Contains(EOKBKAKDMGH))
			{
				while (CAEDMEDBEGI.Contains("[ControllerType:"))
				{
					EOKBKAKDMGH = "[ControllerType";
					int num2 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH) + 1;
					int num3 = 1;
					EOKBKAKDMGH = "[";
					while (num3 > 0 && num2 < CAEDMEDBEGI.Length)
					{
						if (CAEDMEDBEGI[num2].ToString() == "[")
						{
							num3++;
						}
						EOKBKAKDMGH += CAEDMEDBEGI[num2];
						if (CAEDMEDBEGI[num2].ToString() == "]")
						{
							num3--;
						}
						num2++;
					}
					num3 = 0;
					if ((int)PlayerInputs.GetPlayerControllers(JIIGOACEIKL).GetLastActiveController().type != 2)
					{
						string text = "";
						for (int i = 0; i < EOKBKAKDMGH.Length; i++)
						{
							if (EOKBKAKDMGH[i].ToString() == ":")
							{
								num2 = ((!(EOKBKAKDMGH[i + 1].ToString() == " ")) ? (i + 1) : (i + 2));
								break;
							}
						}
						for (int j = num2; j < EOKBKAKDMGH.Length; j++)
						{
							if (EOKBKAKDMGH[j].ToString() == "[")
							{
								num3++;
							}
							if (num3 > 0)
							{
								text += EOKBKAKDMGH[j];
							}
							else
							{
								if (!(EOKBKAKDMGH[j].ToString() != ",") || !(EOKBKAKDMGH[j].ToString() != "，"))
								{
									break;
								}
								text += EOKBKAKDMGH[j];
							}
							if (EOKBKAKDMGH[j].ToString() == "]")
							{
								num3--;
							}
						}
						CAEDMEDBEGI = CAEDMEDBEGI.Replace(EOKBKAKDMGH, text);
					}
					else
					{
						string text2 = "";
						for (int k = 0; k < EOKBKAKDMGH.Length; k++)
						{
							if (EOKBKAKDMGH[k].ToString() == "[")
							{
								num3++;
							}
							if ((EOKBKAKDMGH[k].ToString() == "," || EOKBKAKDMGH[k].ToString() == "，") && num3 <= 1)
							{
								num2 = ((!(EOKBKAKDMGH[k + 1].ToString() == " ")) ? (k + 1) : (k + 2));
								break;
							}
							if (EOKBKAKDMGH[k].ToString() == "]")
							{
								num3--;
							}
						}
						num3 = 0;
						for (int l = num2; l < EOKBKAKDMGH.Length; l++)
						{
							if (EOKBKAKDMGH[l].ToString() == "[")
							{
								num3++;
							}
							if (num3 > 0)
							{
								text2 += EOKBKAKDMGH[l];
							}
							else
							{
								if (!(EOKBKAKDMGH[l].ToString() != "]"))
								{
									break;
								}
								text2 += EOKBKAKDMGH[l];
							}
							if (EOKBKAKDMGH[l].ToString() == "]")
							{
								num3--;
							}
						}
						CAEDMEDBEGI = CAEDMEDBEGI.Replace(EOKBKAKDMGH, text2);
					}
					num--;
					if (num == 0)
					{
						break;
					}
				}
			}
		}
		catch (Exception ex)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)ex.Message);
			}
		}
		try
		{
			int num = 50;
			EOKBKAKDMGH = "[ControllerType=";
			if (CAEDMEDBEGI.Contains(EOKBKAKDMGH))
			{
				while (CAEDMEDBEGI.Contains("[ControllerType="))
				{
					EOKBKAKDMGH = "[ControllerType";
					int num4 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH) + 1;
					int num5 = 1;
					EOKBKAKDMGH = "[";
					while (num5 > 0 && num4 < CAEDMEDBEGI.Length)
					{
						if (CAEDMEDBEGI[num4].ToString() == "[")
						{
							num5++;
						}
						EOKBKAKDMGH += CAEDMEDBEGI[num4];
						if (CAEDMEDBEGI[num4].ToString() == "]")
						{
							num5--;
						}
						num4++;
					}
					num5 = 0;
					if ((int)PlayerInputs.GetPlayerControllers(JIIGOACEIKL).GetLastActiveController().type != 2)
					{
						string text3 = "";
						for (int m = 0; m < EOKBKAKDMGH.Length; m++)
						{
							if (EOKBKAKDMGH[m].ToString() == "=")
							{
								num4 = ((!(EOKBKAKDMGH[m + 1].ToString() == " ")) ? (m + 1) : (m + 2));
								break;
							}
						}
						for (int n = num4; n < EOKBKAKDMGH.Length; n++)
						{
							if (EOKBKAKDMGH[n].ToString() == "[")
							{
								num5++;
							}
							if (num5 > 0)
							{
								text3 += EOKBKAKDMGH[n];
							}
							else
							{
								if (!(EOKBKAKDMGH[n].ToString() != "/"))
								{
									break;
								}
								text3 += EOKBKAKDMGH[n];
							}
							if (EOKBKAKDMGH[n].ToString() == "]")
							{
								num5--;
							}
						}
						CAEDMEDBEGI = CAEDMEDBEGI.Replace(EOKBKAKDMGH, text3);
					}
					else
					{
						string text4 = "";
						for (int num6 = 0; num6 < EOKBKAKDMGH.Length; num6++)
						{
							if (EOKBKAKDMGH[num6].ToString() == "[")
							{
								num5++;
							}
							if (EOKBKAKDMGH[num6].ToString() == "/" && num5 <= 1)
							{
								num4 = ((!(EOKBKAKDMGH[num6 + 1].ToString() == " ")) ? (num6 + 1) : (num6 + 2));
								break;
							}
							if (EOKBKAKDMGH[num6].ToString() == "]")
							{
								num5--;
							}
						}
						num5 = 0;
						for (int num7 = num4; num7 < EOKBKAKDMGH.Length; num7++)
						{
							if (EOKBKAKDMGH[num7].ToString() == "[")
							{
								num5++;
							}
							if (num5 > 0)
							{
								text4 += EOKBKAKDMGH[num7];
							}
							else
							{
								if (!(EOKBKAKDMGH[num7].ToString() != "]"))
								{
									break;
								}
								text4 += EOKBKAKDMGH[num7];
							}
							if (EOKBKAKDMGH[num7].ToString() == "]")
							{
								num5--;
							}
						}
						CAEDMEDBEGI = CAEDMEDBEGI.Replace(EOKBKAKDMGH, text4);
					}
					num--;
					if (num == 0)
					{
						break;
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)ex2.Message);
			}
		}
		try
		{
			string value = "[PlayerGender=";
			int num = 100;
			if (CAEDMEDBEGI.Contains(value))
			{
				Regex regex = new Regex("\\[PlayerGender=[^\\]]*\\]");
				int num8 = CAEDMEDBEGI.Length - 1;
				int num9 = 0;
				while (num8 >= 0 && num9 < num)
				{
					num9++;
					int num10 = CAEDMEDBEGI.LastIndexOf(value, num8, StringComparison.OrdinalIgnoreCase);
					num8 = num10 - 1;
					if (num10 < 0)
					{
						continue;
					}
					string text5 = CAEDMEDBEGI.Substring(0, num10);
					string input = CAEDMEDBEGI.Substring(num10);
					string text6 = regex.Replace(input, delegate(Match match)
					{
						string text15 = match.Value.Substring(14, match.Value.Length - 15).Trim();
						try
						{
							return (PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender == Gender.Male) ? text15.Split('/')[0] : text15.Split('/')[1];
						}
						catch (Exception)
						{
							return string.Empty;
						}
					});
					CAEDMEDBEGI = text5 + text6;
				}
			}
			if (CAEDMEDBEGI.Contains("[PlayerName]"))
			{
				CAEDMEDBEGI = CAEDMEDBEGI.Replace("[PlayerName]", PlayerInfo.HBILFLLKHGP);
			}
			if (CAEDMEDBEGI.Contains("[Player1Name]"))
			{
				CAEDMEDBEGI = CAEDMEDBEGI.Replace("[Player1Name]", PlayerInfo.HBILFLLKHGP);
			}
			if (CAEDMEDBEGI.Contains("[Player2Name]"))
			{
				CAEDMEDBEGI = CAEDMEDBEGI.Replace("[Player2Name]", PlayerInfo.KGDAOACEMJO);
			}
			if (CAEDMEDBEGI.Contains("[TavernName]"))
			{
				CAEDMEDBEGI = CAEDMEDBEGI.Replace("[TavernName]", PlayerInfo.tavernName);
			}
		}
		catch (Exception ex3)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)ex3.Message);
			}
		}
		try
		{
			string value2 = "[SinglePlayer=";
			int num = 100;
			if (CAEDMEDBEGI.Contains(value2))
			{
				Regex regex2 = new Regex("\\[SinglePlayer=[^\\]]*\\]");
				int num11 = CAEDMEDBEGI.Length - 1;
				int num12 = 0;
				while (num11 >= 0 && num12 < num)
				{
					num12++;
					int num13 = CAEDMEDBEGI.LastIndexOf(value2, num11, StringComparison.OrdinalIgnoreCase);
					num11 = num13 - 1;
					if (num13 < 0)
					{
						continue;
					}
					string text7 = CAEDMEDBEGI.Substring(0, num13);
					string input2 = CAEDMEDBEGI.Substring(num13);
					string text8 = regex2.Replace(input2, delegate(Match match)
					{
						string text14 = match.Value.Substring(14, match.Value.Length - 15).Trim();
						try
						{
							return GameManager.SinglePlayerOffline() ? text14.Split('/')[0] : text14.Split('/')[1];
						}
						catch (Exception)
						{
							return string.Empty;
						}
					});
					CAEDMEDBEGI = text7 + text8;
				}
			}
		}
		catch (Exception ex4)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)ex4.Message);
			}
		}
		try
		{
			FFBMPKJMELA(ref CAEDMEDBEGI, WorkerType.Waiter);
			FFBMPKJMELA(ref CAEDMEDBEGI, WorkerType.Bouncer);
			FFBMPKJMELA(ref CAEDMEDBEGI, WorkerType.Barworker);
			FFBMPKJMELA(ref CAEDMEDBEGI, WorkerType.HouseKeeper);
		}
		catch (Exception ex5)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)ex5.Message);
			}
		}
		try
		{
			int num = 50;
			EOKBKAKDMGH = "[Action";
			if (CAEDMEDBEGI.Contains(EOKBKAKDMGH))
			{
				while (CAEDMEDBEGI.Contains("[Action"))
				{
					EOKBKAKDMGH = "[Action";
					int num14 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH);
					num14 += 8;
					string text9 = "";
					for (; num14 < CAEDMEDBEGI.Length && !(CAEDMEDBEGI[num14].ToString() == "]"); num14++)
					{
						text9 += CAEDMEDBEGI[num14];
					}
					text9 = text9.Replace(" ", "");
					num14 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH);
					EOKBKAKDMGH = "";
					while (!EOKBKAKDMGH.Contains("]") && num14 < CAEDMEDBEGI.Length)
					{
						EOKBKAKDMGH += CAEDMEDBEGI[num14];
						num14++;
					}
					CAEDMEDBEGI = CAEDMEDBEGI.Replace(EOKBKAKDMGH, CMOBIDABHKM(JIIGOACEIKL, text9));
					num--;
					if (num == 0)
					{
						break;
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)ex6.Message);
			}
		}
		try
		{
			EOKBKAKDMGH = "[Red";
			int num = 100;
			if (CAEDMEDBEGI.Contains(EOKBKAKDMGH))
			{
				while (CAEDMEDBEGI.Contains("[Red"))
				{
					EOKBKAKDMGH = "[Red";
					int num15 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH);
					num15 += 5;
					string text10 = "";
					for (; num15 < CAEDMEDBEGI.Length && !(CAEDMEDBEGI[num15].ToString() == "]"); num15++)
					{
						text10 += CAEDMEDBEGI[num15];
					}
					num15 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH);
					EOKBKAKDMGH = "";
					while (!EOKBKAKDMGH.Contains("]") && num15 < CAEDMEDBEGI.Length)
					{
						EOKBKAKDMGH += CAEDMEDBEGI[num15];
						num15++;
					}
					CAEDMEDBEGI = CAEDMEDBEGI.Replace(EOKBKAKDMGH, "<b><color=#A90000>" + text10 + "</color></b>");
					num--;
					if (num == 0)
					{
						break;
					}
				}
			}
		}
		catch (Exception ex7)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)ex7.Message);
			}
		}
		try
		{
			EOKBKAKDMGH = "[Grey";
			int num = 100;
			if (CAEDMEDBEGI.Contains(EOKBKAKDMGH))
			{
				while (CAEDMEDBEGI.Contains("[Grey"))
				{
					EOKBKAKDMGH = "[Grey";
					int num16 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH);
					num16 += 6;
					string text11 = "";
					for (; num16 < CAEDMEDBEGI.Length && !(CAEDMEDBEGI[num16].ToString() == "]"); num16++)
					{
						text11 += CAEDMEDBEGI[num16];
					}
					num16 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH);
					EOKBKAKDMGH = "";
					while (!EOKBKAKDMGH.Contains("]") && num16 < CAEDMEDBEGI.Length)
					{
						EOKBKAKDMGH += CAEDMEDBEGI[num16];
						num16++;
					}
					CAEDMEDBEGI = CAEDMEDBEGI.Replace(EOKBKAKDMGH, "<b><color=#9a672a>" + text11 + "</color></b>");
					num--;
					if (num == 0)
					{
						break;
					}
				}
			}
		}
		catch (Exception ex8)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)ex8.Message);
			}
		}
		try
		{
			EOKBKAKDMGH = "[Brown2";
			int num = 100;
			if (CAEDMEDBEGI.Contains(EOKBKAKDMGH))
			{
				while (CAEDMEDBEGI.Contains("[Brown2"))
				{
					EOKBKAKDMGH = "[Brown2";
					int num17 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH);
					num17 += 8;
					string text12 = "";
					for (; num17 < CAEDMEDBEGI.Length && !(CAEDMEDBEGI[num17].ToString() == "]"); num17++)
					{
						text12 += CAEDMEDBEGI[num17];
					}
					num17 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH);
					EOKBKAKDMGH = "";
					while (!EOKBKAKDMGH.Contains("]") && num17 < CAEDMEDBEGI.Length)
					{
						EOKBKAKDMGH += CAEDMEDBEGI[num17];
						num17++;
					}
					CAEDMEDBEGI = CAEDMEDBEGI.Replace(EOKBKAKDMGH, "<color=#822F00>" + text12 + "</color>");
					num--;
					if (num == 0)
					{
						break;
					}
				}
			}
		}
		catch (Exception ex9)
		{
			if (Application.isEditor)
			{
				Debug.LogException(ex9);
			}
		}
		try
		{
			EOKBKAKDMGH = "[Brown";
			int num = 100;
			if (CAEDMEDBEGI.Contains(EOKBKAKDMGH))
			{
				while (CAEDMEDBEGI.Contains("[Brown"))
				{
					EOKBKAKDMGH = "[Brown";
					int num18 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH);
					num18 += 7;
					string text13 = "";
					for (; num18 < CAEDMEDBEGI.Length && !(CAEDMEDBEGI[num18].ToString() == "]"); num18++)
					{
						text13 += CAEDMEDBEGI[num18];
					}
					num18 = CAEDMEDBEGI.IndexOf(EOKBKAKDMGH);
					EOKBKAKDMGH = "";
					while (!EOKBKAKDMGH.Contains("]") && num18 < CAEDMEDBEGI.Length)
					{
						EOKBKAKDMGH += CAEDMEDBEGI[num18];
						num18++;
					}
					CAEDMEDBEGI = CAEDMEDBEGI.Replace(EOKBKAKDMGH, "<b><color=#9A3F00>" + text13 + "</color></b>");
					num--;
					if (num == 0)
					{
						break;
					}
				}
			}
		}
		catch (Exception ex10)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)ex10.Message);
			}
		}
		return CAEDMEDBEGI;
	}

	public static string GEJLCOGDMID(string CAEDMEDBEGI, params string[] NBBLAEDBEEK)
	{
		if (CAEDMEDBEGI == null)
		{
			return "";
		}
		for (int i = 0; i < NBBLAEDBEEK.Length; i++)
		{
			if (CAEDMEDBEGI.Contains("{" + i + "}"))
			{
				if (!StringExtensions.IsNullOrWhitespace(NBBLAEDBEEK[i]))
				{
					CAEDMEDBEGI = CAEDMEDBEGI.Replace("{" + i + "}", NBBLAEDBEEK[i]);
				}
				else
				{
					Debug.LogError((object)"Replace 0 is empty!");
				}
			}
		}
		return CAEDMEDBEGI;
	}

	public static string CMOBIDABHKM(int JIIGOACEIKL, ActionType OKNOJJEFEBE)
	{
		return CMOBIDABHKM(JIIGOACEIKL, OKNOJJEFEBE.ToString());
	}

	public static void AAPOEKOONKL(int JIIGOACEIKL, ControllerType ONCGHAJMGCO, string OKNOJJEFEBE, out string INAPMPEEDPO, bool NGDDAAFCDIL = true, string EEHPMOPMGMJ = "")
	{
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Invalid comparison between Unknown and I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Invalid comparison between Unknown and I4
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		INAPMPEEDPO = EEHPMOPMGMJ;
		ActionElementMap val = null;
		if (PlayerInputs.GetPlayerControllers(JIIGOACEIKL) != null)
		{
			if (PlayerInputs.GetPlayerControllers(JIIGOACEIKL).maps != null)
			{
				if (OKNOJJEFEBE == "WASD")
				{
					List<string> list = new List<string>();
					foreach (ActionElementMap item in PlayerInputs.GetPlayerControllers(JIIGOACEIKL).maps.ElementMapsWithAction("VerticalMove", NGDDAAFCDIL))
					{
						if (item != null && item.controllerMap.controllerType == ONCGHAJMGCO && list.Count < 2)
						{
							list.Add(item.elementIdentifierName);
						}
					}
					foreach (ActionElementMap item2 in PlayerInputs.GetPlayerControllers(JIIGOACEIKL).maps.ElementMapsWithAction("HorizontalMove", NGDDAAFCDIL))
					{
						if (item2 != null && item2.controllerMap.controllerType == ONCGHAJMGCO && list.Count < 4)
						{
							list.Add(item2.elementIdentifierName);
						}
					}
					for (int i = 0; i < list.Count; i++)
					{
						if (i + 1 == list.Count)
						{
							INAPMPEEDPO += list[i];
						}
						else
						{
							INAPMPEEDPO = INAPMPEEDPO + list[i] + " / ";
						}
					}
				}
				else if (OKNOJJEFEBE == "ObjectMove")
				{
					List<string> list2 = new List<string>();
					if ((int)ONCGHAJMGCO == 2)
					{
						foreach (ActionElementMap item3 in PlayerInputs.GetPlayerControllers(JIIGOACEIKL).maps.ElementMapsWithAction("ObjectVerticalMove", NGDDAAFCDIL))
						{
							if (item3 != null && item3.controllerMap.controllerType == ONCGHAJMGCO)
							{
								list2.Add(item3.elementIdentifierName);
							}
						}
						foreach (ActionElementMap item4 in PlayerInputs.GetPlayerControllers(JIIGOACEIKL).maps.ElementMapsWithAction("ObjectHorizontalMove", NGDDAAFCDIL))
						{
							if (item4 != null && item4.controllerMap.controllerType == ONCGHAJMGCO)
							{
								list2.Add(item4.elementIdentifierName);
							}
						}
						for (int j = 0; j < list2.Count; j++)
						{
							if (j + 1 == list2.Count)
							{
								INAPMPEEDPO += list2[j];
							}
							else
							{
								INAPMPEEDPO = INAPMPEEDPO + list2[j] + " / ";
							}
						}
					}
					else
					{
						INAPMPEEDPO = "Mouse";
					}
				}
				else
				{
					val = PlayerInputs.GetPlayerControllers(JIIGOACEIKL).maps.GetFirstElementMapWithAction(ONCGHAJMGCO, OKNOJJEFEBE, NGDDAAFCDIL);
					if (val == null)
					{
						val = (((int)ONCGHAJMGCO != 1 && (int)ONCGHAJMGCO != 2) ? PlayerInputs.GetPlayerControllers(JIIGOACEIKL).maps.GetFirstElementMapWithAction((ControllerType)1, OKNOJJEFEBE, NGDDAAFCDIL) : PlayerInputs.GetPlayerControllers(JIIGOACEIKL).maps.GetFirstElementMapWithAction((ControllerType)0, OKNOJJEFEBE, NGDDAAFCDIL));
					}
					if (val != null)
					{
						INAPMPEEDPO = val.elementIdentifierName;
					}
					else
					{
						Debug.LogError((object)(OKNOJJEFEBE + " nulo en " + ((object)(ControllerType)(ref ONCGHAJMGCO)).ToString()));
					}
				}
			}
			else
			{
				Debug.LogError((object)"Player.Controllers.maps null");
			}
		}
		else
		{
			Debug.LogError((object)"Player.Controllers null");
		}
	}

	public static string CMOBIDABHKM(int JIIGOACEIKL, ControllerType GIOAMBKBCJO, ActionType JKJJKBAFNMO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if ((int)GIOAMBKBCJO != 2)
		{
			AAPOEKOONKL(JIIGOACEIKL, (ControllerType)0, JKJJKBAFNMO.ToString(), out var INAPMPEEDPO, NGDDAAFCDIL: false);
			if (string.IsNullOrEmpty(INAPMPEEDPO))
			{
				AAPOEKOONKL(JIIGOACEIKL, (ControllerType)1, JKJJKBAFNMO.ToString(), out INAPMPEEDPO, NGDDAAFCDIL: false, JKJJKBAFNMO.ToString());
			}
			return "<color=" + ((JIIGOACEIKL == 1) ? LBOJBODPCLC : ACHLMJCGDGA) + ">" + (string.IsNullOrEmpty(LocalisationSystem.Get(INAPMPEEDPO)) ? INAPMPEEDPO : LocalisationSystem.Get(INAPMPEEDPO)) + "</color>";
		}
		return CMOBIDABHKM(JIIGOACEIKL, JKJJKBAFNMO);
	}

	private static void FFBMPKJMELA(ref string CAEDMEDBEGI, WorkerType NCMDEGABGCH)
	{
		string value = "[WaiterGender=";
		int num = 100;
		switch (NCMDEGABGCH)
		{
		case WorkerType.Waiter:
			value = "[WaiterGender=";
			break;
		case WorkerType.Bouncer:
			value = "[BouncerGender=";
			break;
		case WorkerType.Barworker:
			value = "[BartenderGender=";
			break;
		case WorkerType.HouseKeeper:
			value = "[HouseKeeperGender=";
			break;
		}
		if (!CAEDMEDBEGI.Contains(value))
		{
			return;
		}
		Regex regex = new Regex("\\[WaiterGender=[^\\]]*\\]");
		int startIndex = 14;
		EmployeeInfo employeeInfo = null;
		switch (NCMDEGABGCH)
		{
		case WorkerType.Waiter:
			regex = new Regex("\\[WaiterGender=[^\\]]*\\]");
			startIndex = 14;
			employeeInfo = StaffManager.GetWorkerInfo(WorkerType.Waiter);
			break;
		case WorkerType.Bouncer:
			regex = new Regex("\\[BouncerGender=[^\\]]*\\]");
			startIndex = 15;
			employeeInfo = StaffManager.GetWorkerInfo(WorkerType.Bouncer);
			break;
		case WorkerType.Barworker:
			regex = new Regex("\\[BartenderGender=[^\\]]*\\]");
			startIndex = 17;
			employeeInfo = StaffManager.GetWorkerInfo(WorkerType.Barworker);
			break;
		case WorkerType.HouseKeeper:
			regex = new Regex("\\[HouseKeeperGender=[^\\]]*\\]");
			startIndex = 19;
			employeeInfo = StaffManager.GetWorkerInfo(WorkerType.HouseKeeper);
			break;
		}
		int num2 = CAEDMEDBEGI.Length - 1;
		int num3 = 0;
		while (num2 >= 0 && num3 < num)
		{
			num3++;
			int num4 = CAEDMEDBEGI.LastIndexOf(value, num2, StringComparison.OrdinalIgnoreCase);
			num2 = num4 - 1;
			if (num4 < 0)
			{
				continue;
			}
			string text = CAEDMEDBEGI.Substring(0, num4);
			string input = CAEDMEDBEGI.Substring(num4);
			string text2 = regex.Replace(input, delegate(Match match)
			{
				string text3 = match.Value.Substring(startIndex, match.Value.Length - (startIndex + 1)).Trim();
				try
				{
					if (employeeInfo == null || string.IsNullOrEmpty(employeeInfo.name))
					{
						return text3.Split('/')[0];
					}
					return (employeeInfo.gender == Gender.Male) ? text3.Split('/')[0] : text3.Split('/')[1];
				}
				catch (Exception)
				{
					return string.Empty;
				}
			});
			CAEDMEDBEGI = text + text2;
		}
	}

	public static string NHGIAHHNIJF(string LEGEBNFCBDJ)
	{
		if (string.IsNullOrEmpty(LEGEBNFCBDJ))
		{
			return LEGEBNFCBDJ;
		}
		StringBuilder stringBuilder = new StringBuilder(LEGEBNFCBDJ.Length);
		for (int i = 0; i < LEGEBNFCBDJ.Length; i++)
		{
			char value = LEGEBNFCBDJ[i];
			if (PPEOJGEPLOC.TryGetValue(value.ToString(), out var value2))
			{
				stringBuilder.Append(value2);
			}
			else
			{
				stringBuilder.Append(value);
			}
		}
		return stringBuilder.ToString();
	}
}
