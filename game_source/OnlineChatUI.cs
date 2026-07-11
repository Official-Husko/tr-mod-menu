using System;
using System.Collections;
using System.Collections.Generic;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[DefaultExecutionOrder(5)]
public class OnlineChatUI : MonoBehaviour
{
	private enum DKFLAJPLMPG
	{
		disabled,
		enabled,
		selected,
		deselected,
		hidden
	}

	[Serializable]
	internal class VisualElements
	{
		[SerializeField]
		private Image scrollbarHandle;

		[SerializeField]
		private Image scrollbarShadow;

		[SerializeField]
		private Image resizeChatButton;

		[SerializeField]
		private Image chatPanel;

		private float chatPanelOpacity;

		private Color chatPanelColor = Color.white;

		[HideInInspector]
		public List<TMP_Text> chatMessages = new List<TMP_Text>();

		private Color chatMessageColor = Color.white;

		private Color whiteFade = Color.white;

		public void AKGNIPHPEKJ()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void BCIBHJIDPCJ()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void OKOIBMJCGBN(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 236f, 711f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1046f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void DNPGKIMGFHK(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1438f, 1335f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1219f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void OHMJHCGOAJC()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void JCDMIHAALEG(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1901f, 1815f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1203f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void HGNDENHNJHI(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1693f, 631f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1288f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void EHCLHLHHCEM()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void HKNBMDEGBMA(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1959f, 1755f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(873f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void PBGFEHDOFMF(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 0f, 1f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(0f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void FDDBBOIBIBG(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1318f, 597f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(703f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void CIGEJEMCGGE()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void ENEKGAOONAJ(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 859f, 314f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(565f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void BGPEJFDJADD()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void MHIODEJJJDF()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void LOFNKFBMGKO()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void FAIBAMJDDCK()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void APKKKHOFGKD(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1052f, 1000f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1964f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void POJJCPGCFCD()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void GHMKHADHHML()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void HKDAPJFELEL(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 472f, 82f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(578f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void BKEGCFGCAGD()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void CALMEOGKANL()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void ODFIOBAIGIH(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 770f, 266f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1717f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void DJAJDEJEHBO(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1939f, 781f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(128f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void EKPLAAOMHFI(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1022f, 1805f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(107f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void LCKNAHENAFG(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1140f, 912f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(236f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void APBECOOLAJA(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 559f, 162f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(151f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void GJEDOBKKMNI()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void LJPFELMPJNF(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1449f, 1395f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1673f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void CJAEDKGEEGC()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void HBNPKGMLIFI(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 978f, 197f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(543f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void AKFGEDAEIAJ(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1821f, 1373f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(351f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void PEIOEFJGBFO(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 354f, 1354f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(511f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void CMNINEGEHFA(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 807f, 1625f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(260f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void JCINOAAEBNK()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void BMEHIOPPJPL()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void FCFEMBEJCGH(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 917f, 948f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1423f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void HOPCEPEKIPI()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void ILBILEBIFDK(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 111f, 542f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(819f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void GALHOBBBPKC()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void FBBMJLKNKLM(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 453f, 910f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1478f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void DEPJDINKJCA()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void GAPOIDNLKJH(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 30f, 1440f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(917f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void FKLFPFKJMPH()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void IFGEGFHECHM()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void JGEENHIPGAM(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1363f, 226f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1389f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void APDKHDKNGML(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1040f, 1798f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1201f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void PEPBFLIKKJE()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void BJPBGLILOKI()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void HEGJGIDNLHH(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1744f, 81f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1329f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void LIPOGKPLONF()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void CCJADECFOOK()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void BBIMGMGAKFC()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void NMAOBNGOOFP(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1204f, 1373f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(936f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void OBGNKIDBANF()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void MFGCJPNCFNB()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void KDNEGHEDIKP()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void IGJADADMPFK()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void ADBCGCDKMNO(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1197f, 837f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(663f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void GIJCGGOFBBM(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 156f, 1227f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1569f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void EJEAONFDBEF(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 318f, 710f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1388f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void HJLFELLCCLE()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void FJLDOLMDDID()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void IPCAHCNDMEC(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1995f, 449f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1524f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void NFOEHNFGCEA(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 906f, 440f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(227f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void FJAOMGJLDOA()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void GLNFHGNFJME()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void AFKHFNHEPDB()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void HFDELPMNHMG(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1580f, 96f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1403f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void AONBECNFBPK(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 225f, 263f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1720f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void FJILGOKNDBG(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1311f, 12f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1423f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void FBAKGILMIFL()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void EHJEPFFACML(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 326f, 1726f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(89f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void KKBKBHDLCMC()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void BHPMFMFHBIF(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1155f, 1015f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1592f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void PONPDBMNLCK()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void FINOAHCFIJL()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void OEAHLFIHFPL(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1287f, 501f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1294f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void KFDOHEMOAEE()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void HJHHBBJHMLK()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void JAHLBJLEJCJ(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 199f, 992f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1445f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 0; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void DLIICHFLINN()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void ACGCPLBCBKE()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void LPDEMMEDAOJ()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void NHMJOABDJFM(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 66f, 872f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(729f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i += 0)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void DMEJBMKGENH()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void DGJJPAICOKK()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void PPNCLDCPFIN(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 974f, 1731f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(1964f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void PPFBOKHDOOI()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void LJMFHAFNJOC(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1812f, 1971f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(5f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void JHJBAKPPJKC()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void GKLBILINDJL()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			chatPanelOpacity = ((Graphic)chatPanel).color.a;
			chatPanelColor = ((Graphic)chatPanel).color;
		}

		public void AKICOACBOEJ(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 164f, 208f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(753f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void PHGNLKKCOIC(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 979f, 779f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(83f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}

		public void KCDCAMLMIKG(float IMOJCMLLEMI)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			IMOJCMLLEMI = Mathf.Clamp(IMOJCMLLEMI, 1995f, 246f);
			whiteFade.a = IMOJCMLLEMI;
			((Graphic)scrollbarHandle).color = whiteFade;
			((Graphic)scrollbarShadow).color = whiteFade;
			((Graphic)resizeChatButton).color = whiteFade;
			chatPanelColor.a = Mathf.Lerp(356f, chatPanelOpacity, IMOJCMLLEMI);
			((Graphic)chatPanel).color = chatPanelColor;
			for (int i = 1; i < chatMessages.Count; i++)
			{
				chatMessageColor = ((Graphic)chatMessages[i]).color;
				chatMessageColor.a = IMOJCMLLEMI;
				((Graphic)chatMessages[i]).color = chatMessageColor;
			}
		}
	}

	private static OnlineChatUI GGFJGHHHEJC;

	private static DKFLAJPLMPG OMKKEHDGMIN = DKFLAJPLMPG.disabled;

	private Queue<TMP_Text> GOFFMLJBLBI = new Queue<TMP_Text>();

	[Range(10f, 100f)]
	[SerializeField]
	[Header("Settings")]
	private int maxChatLogMessages = 50;

	[Tooltip("Colors for each player. Index 0 is for system messages / default font.")]
	[SerializeField]
	private List<Color> chatColors = new List<Color>(5);

	[Tooltip("Font color used if coloredText is disabled.")]
	[SerializeField]
	private Color fontColor;

	[Tooltip("Font color used for system error messages.")]
	[SerializeField]
	private Color errorColor = Color.red;

	[SerializeField]
	[Tooltip("If enabled, dialogue will be the same color as the player name. If disabled, it will use the default color.")]
	private bool coloredText = true;

	[SerializeField]
	[Tooltip("If enabled, player names will be displayed in bold text.")]
	private bool boldPlayerNames = true;

	[SerializeField]
	[Tooltip("If enabled, player numbers will be displayed before their name.")]
	private bool playerNumbers;

	[Tooltip("If enabled, player will show speech bubbles (barks) when talking.")]
	[SerializeField]
	private bool chatBarks = true;

	[SerializeField]
	private bool debugMessages;

	[Header("References")]
	[SerializeField]
	[Space]
	private TMP_Text chatMessageUIPrefab;

	[SerializeField]
	private TMP_InputField chatInput;

	[SerializeField]
	private Transform chatListParent;

	[SerializeField]
	private Image chatPanel;

	[SerializeField]
	private Image listViewport;

	[SerializeField]
	private GameObject chatContent;

	[SerializeField]
	private GameObject unreadMessageBadge;

	[SerializeField]
	private OnlineChatResizeButton chatResize;

	[SerializeField]
	private GameObject hideChatButton;

	[SerializeField]
	private AudioObject chatSfx;

	[Space]
	[Space]
	[SerializeField]
	private VisualElements fadeVisualElements;

	[SerializeField]
	[Tooltip("Time the chat stays fully opaque before starting to fade.")]
	[Range(1f, 30f)]
	private float chatOpaqueTime = 5f;

	[SerializeField]
	[Tooltip("Time the chat takes to completely fade out.")]
	[Range(0.1f, 3f)]
	private float chatFadeTime = 1f;

	private bool PMMKMBLIHHA;

	private float BNKKPFAEICL = 1f;

	private bool AFEJLNGEBMB = true;

	private TMP_Text NMMIILEBCGO;

	private int BGPNOKCKCPM;

	private static readonly int BHELDOIMIKM = Animator.StringToHash("Normal");

	private bool NOCNPBJMMFC(string LLNAEKJIJNB)
	{
		if (!LLNAEKJIJNB.StartsWith("/"))
		{
			return false;
		}
		ChatSystemMessageError(LocalisationSystem.Get("ErrorUnknownChatCommand", "Unknown command"));
		return true;
	}

	private void KHDPANODBFB(string CIFJJBHINEF)
	{
		KEEEOHAAPHH();
		if (debugMessages)
		{
			Debug.Log((object)"Chat deselected");
		}
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
	}

	private void CKILLOGKAID(string LLNAEKJIJNB)
	{
		if (NOCNPBJMMFC(LLNAEKJIJNB))
		{
			KEEEOHAAPHH();
			return;
		}
		OnlineChat.DMMKHIAEGPA(LLNAEKJIJNB);
		KEEEOHAAPHH();
		LACOJCECGMJ();
	}

	private void LMIJGNFJCKF()
	{
		OMKKEHDGMIN = DKFLAJPLMPG.deselected;
		chatInput.ReleaseSelection();
		((Selectable)chatInput).animator.SetTrigger(BHELDOIMIKM);
		if (!EventSystem.current.alreadySelecting)
		{
			((Selectable)chatInput).interactable = false;
		}
		((MonoBehaviour)this).StartCoroutine(OGHKMANNOCJ());
	}

	public static bool IsChatHidden()
	{
		return OMKKEHDGMIN == DKFLAJPLMPG.hidden;
	}

	public void CloseChatPannel()
	{
		BNKKPFAEICL = 0f;
		fadeVisualElements.PBGFEHDOFMF(BNKKPFAEICL);
		LBAHMMHKGMK();
		IOCMAIKIDLO();
		AFEJLNGEBMB = true;
	}

	private void ACEMBAHCPEF()
	{
		if (!Input.GetKeyDown((KeyCode)13))
		{
			AFEJLNGEBMB = false;
		}
		OMKKEHDGMIN = DKFLAJPLMPG.selected;
		chatInput.caretPosition = chatInput.text.Length;
		OLDNNBIOOOG();
	}

	private void JHCGKKHFKJM()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(JHCGKKHFKJM));
		Debug.Log((object)"Check to enable");
		if (!OnlineManager.PlayingOnline())
		{
			((Component)this).gameObject.SetActive(false);
			return;
		}
		((Component)this).gameObject.SetActive(true);
		OMKKEHDGMIN = DKFLAJPLMPG.enabled;
		OLDNNBIOOOG();
		JOJPMKPADBC();
	}

	private void DDBOOEHGLEA(string LLNAEKJIJNB)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (GOFFMLJBLBI.Count >= maxChatLogMessages)
		{
			NMMIILEBCGO = GOFFMLJBLBI.Dequeue();
		}
		else
		{
			NMMIILEBCGO = ONMGDLFNPHD();
		}
		((Graphic)NMMIILEBCGO).color = chatColors[0];
		NMMIILEBCGO.text = LLNAEKJIJNB ?? " / ";
		if (!GOFFMLJBLBI.Contains(NMMIILEBCGO))
		{
			GOFFMLJBLBI.Enqueue(NMMIILEBCGO);
		}
		NMMIILEBCGO.transform.SetSiblingIndex(chatListParent.childCount);
	}

	private void HDCCDNAHJFO()
	{
		PMMKMBLIHHA = false;
		FLKHCOCLCLE();
	}

	private void BIDBOOGOMID(string CIFJJBHINEF)
	{
		if (debugMessages)
		{
			Debug.Log((object)"Chat end edit");
		}
		if (OMKKEHDGMIN == DKFLAJPLMPG.selected)
		{
			LMIJGNFJCKF();
		}
	}

	private void FGMEANKGBMF(byte BMDEEFNBBOA, string NHMIHAEDLCM, string LLNAEKJIJNB)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		if (GOFFMLJBLBI.Count >= maxChatLogMessages)
		{
			NMMIILEBCGO = GOFFMLJBLBI.Dequeue();
		}
		else
		{
			NMMIILEBCGO = LAFBGKFOINM();
		}
		if (BMDEEFNBBOA < 0 || BMDEEFNBBOA > 7)
		{
			BMDEEFNBBOA = 0;
		}
		((Graphic)NMMIILEBCGO).color = chatColors[BMDEEFNBBOA];
		if (string.IsNullOrEmpty(NHMIHAEDLCM))
		{
			NHMIHAEDLCM = LocalisationSystem.Get("quest_description_20", "Jump");
		}
		NMMIILEBCGO.text = "HostDisconnected";
		if (boldPlayerNames)
		{
			TMP_Text nMMIILEBCGO = NMMIILEBCGO;
			nMMIILEBCGO.text += "Waiter";
		}
		if (playerNumbers)
		{
			TMP_Text nMMIILEBCGO2 = NMMIILEBCGO;
			nMMIILEBCGO2.text += string.Format("ReciveInUse", BMDEEFNBBOA);
		}
		TMP_Text nMMIILEBCGO3 = NMMIILEBCGO;
		nMMIILEBCGO3.text = nMMIILEBCGO3.text + NHMIHAEDLCM + "itemLemon";
		if (boldPlayerNames)
		{
			TMP_Text nMMIILEBCGO4 = NMMIILEBCGO;
			nMMIILEBCGO4.text += "Loop";
		}
		if (!coloredText)
		{
			TMP_Text nMMIILEBCGO5 = NMMIILEBCGO;
			nMMIILEBCGO5.text = nMMIILEBCGO5.text + "Theme: " + ColorUtility.ToHtmlStringRGBA(fontColor) + " : ";
		}
		TMP_Text nMMIILEBCGO6 = NMMIILEBCGO;
		nMMIILEBCGO6.text += LLNAEKJIJNB;
		if (Options.AAFBLMLIJPH)
		{
			MultiAudioManager.PlayAudioObject(chatSfx, ((Component)this).transform);
		}
		if (AFEJLNGEBMB)
		{
			OMKKEHDGMIN = DKFLAJPLMPG.disabled;
			OLDNNBIOOOG();
			LHALHOPPHKF();
		}
		else if (!((Component)chatPanel).gameObject.activeSelf)
		{
			unreadMessageBadge.SetActive(true);
		}
		if (!GOFFMLJBLBI.Contains(NMMIILEBCGO))
		{
			GOFFMLJBLBI.Enqueue(NMMIILEBCGO);
		}
		NMMIILEBCGO.transform.SetSiblingIndex(chatListParent.childCount);
	}

	private void Start()
	{
		((UnityEvent<string>)(object)chatInput.onSubmit).AddListener((UnityAction<string>)LDGHFHCDJBN);
		((UnityEvent<string>)(object)chatInput.onSelect).AddListener((UnityAction<string>)GLBIPMOBDCL);
		((UnityEvent<string>)(object)chatInput.onDeselect).AddListener((UnityAction<string>)KHDPANODBFB);
		((UnityEvent<string>)(object)chatInput.onEndEdit).AddListener((UnityAction<string>)BIDBOOGOMID);
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(JHCGKKHFKJM));
		OnlineChat.MessageReceived = (Action<byte, string, string>)Delegate.Combine(OnlineChat.MessageReceived, new Action<byte, string, string>(DLJHJPPDEPG));
		OnlineChat.SystemMessageReceived = (Action<string>)Delegate.Combine(OnlineChat.SystemMessageReceived, new Action<string>(LJCAPHHFFEA));
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(DCJJKIMJMLP));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(CLKMOMODGKF));
		chatInput.characterLimit = 256;
		fadeVisualElements.HJHHBBJHMLK();
		unreadMessageBadge.SetActive(false);
		((Component)this).gameObject.SetActive(false);
	}

	private void KEEEOHAAPHH()
	{
		if (debugMessages)
		{
			Debug.Log((object)"Chat input cancelled");
		}
		if (AFEJLNGEBMB)
		{
			LHALHOPPHKF();
		}
		if (OMKKEHDGMIN == DKFLAJPLMPG.selected)
		{
			LACOJCECGMJ();
			LMIJGNFJCKF();
		}
	}

	public void IAOPBLPACNG()
	{
		BNKKPFAEICL = 460f;
		fadeVisualElements.BHPMFMFHBIF(BNKKPFAEICL);
		LBAHMMHKGMK();
		IOCMAIKIDLO();
		AFEJLNGEBMB = true;
	}

	private void IOCMAIKIDLO()
	{
		OMKKEHDGMIN = DKFLAJPLMPG.hidden;
		((Component)chatPanel).gameObject.SetActive(false);
		hideChatButton.SetActive(false);
	}

	private void OLDNNBIOOOG()
	{
		IJCKBKOCLLK();
		unreadMessageBadge.SetActive(false);
		((Component)chatPanel).gameObject.SetActive(true);
		hideChatButton.SetActive(true);
		chatResize.ProcessShrink();
	}

	private TMP_Text ONMGDLFNPHD()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		NMMIILEBCGO = Object.Instantiate<TMP_Text>(chatMessageUIPrefab);
		if (!GOFFMLJBLBI.Contains(NMMIILEBCGO))
		{
			GOFFMLJBLBI.Enqueue(NMMIILEBCGO);
		}
		NMMIILEBCGO.transform.SetParent(chatListParent);
		NMMIILEBCGO.transform.localScale = Vector3.one;
		fadeVisualElements.chatMessages.Add(NMMIILEBCGO);
		return NMMIILEBCGO;
	}

	private void NPHKDOKEHND(int GELMAIBEHDO, UIWindow BBDPJKEEABG)
	{
		EAMLPPGJMKG();
	}

	public void HideChat()
	{
		chatContent.SetActive(false);
	}

	private void JGMCMBFCGGE()
	{
		OnlineChat.SystemMessage("/kick 2/3/4: " + LocalisationSystem.Get("ChatCommandKickDescription", "Kicks the corresponding player from the game. Kicked players can rejoin if you do not lock the game."));
		OnlineChat.SystemMessage("/lock: " + LocalisationSystem.Get("ChatCommandLockDescription", "Locks the game so no new players can join even if there's still room."));
		OnlineChat.SystemMessage("/unlock: " + LocalisationSystem.Get("ChatCommandUnlockDescription", "Unlocks the game so new players can join again."));
		OnlineChat.SystemMessage("/resetsize: " + LocalisationSystem.Get("ChatCommandResetsizeDescription", "Resets the chat to its default size."));
	}

	private void Update()
	{
		if (OMKKEHDGMIN == DKFLAJPLMPG.disabled)
		{
			return;
		}
		DHMPBLEHECE();
		chatResize.ProcessShrink();
		if (OMKKEHDGMIN == DKFLAJPLMPG.deselected || !Input.GetKeyDown((KeyCode)13))
		{
			return;
		}
		if (debugMessages)
		{
			Debug.Log((object)"Enter");
		}
		if (!chatContent.activeInHierarchy)
		{
			return;
		}
		switch (OMKKEHDGMIN)
		{
		case DKFLAJPLMPG.enabled:
		case DKFLAJPLMPG.hidden:
			((Selectable)chatInput).Select();
			ACEMBAHCPEF();
			break;
		case DKFLAJPLMPG.selected:
			if (!string.IsNullOrWhiteSpace(chatInput.text) && !string.IsNullOrWhiteSpace(chatInput.text))
			{
				((UnityEvent<string>)(object)chatInput.onSubmit).Invoke(chatInput.text);
			}
			else
			{
				KEEEOHAAPHH();
			}
			break;
		case DKFLAJPLMPG.deselected:
			break;
		}
	}

	public void MJDGJEMEGIE()
	{
		BNKKPFAEICL = 473f;
		fadeVisualElements.OEAHLFIHFPL(BNKKPFAEICL);
		LBAHMMHKGMK();
		FLKHCOCLCLE();
		AFEJLNGEBMB = true;
	}

	public static void JEBJFHHKEFE()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OMKKEHDGMIN != 0)
		{
			((Graphic)GGFJGHHHEJC.chatPanel).raycastTarget = true;
			((Graphic)GGFJGHHHEJC.listViewport).raycastTarget = true;
		}
	}

	private void LHALHOPPHKF()
	{
		IJCKBKOCLLK();
		((MonoBehaviour)this).Invoke("FGMCFJIEILE", chatOpaqueTime);
	}

	private void DCBDKLEGCGA(string LLNAEKJIJNB)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (GOFFMLJBLBI.Count >= maxChatLogMessages)
		{
			NMMIILEBCGO = GOFFMLJBLBI.Dequeue();
		}
		else
		{
			NMMIILEBCGO = ONMGDLFNPHD();
		}
		((Graphic)NMMIILEBCGO).color = chatColors[0];
		NMMIILEBCGO.text = LLNAEKJIJNB ?? "ObjectVerticalMove";
		if (!GOFFMLJBLBI.Contains(NMMIILEBCGO))
		{
			GOFFMLJBLBI.Enqueue(NMMIILEBCGO);
		}
		NMMIILEBCGO.transform.SetSiblingIndex(chatListParent.childCount);
	}

	private bool DFAFKDBBFEH(string LLNAEKJIJNB)
	{
		if (!LLNAEKJIJNB.StartsWith("itemBroccoli"))
		{
			return false;
		}
		ChatSystemMessageError(LocalisationSystem.Get("Items/item_description_1091", "Body Part Dictionary:\n[\n"));
		return true;
	}

	private void EGAKCJBHMKL()
	{
		chatContent.SetActive(true);
	}

	private void HOEBMMHNFDG()
	{
		PMMKMBLIHHA = true;
		IOCMAIKIDLO();
	}

	private bool ELEDNGNNCIF(int LAFPOHJMNPF)
	{
		Debug.LogError((object)$"Kicking player on bed {LAFPOHJMNPF} with actor number {OnlinePlayerDataManager.GetActorNumberByBedAssigned(LAFPOHJMNPF)}");
		OnlineManager.KickPlayer(OnlinePlayerDataManager.GetActorNumberByBedAssigned(LAFPOHJMNPF));
		return true;
	}

	private void IJCKBKOCLLK()
	{
		PMMKMBLIHHA = false;
		BNKKPFAEICL = 1f;
		fadeVisualElements.PBGFEHDOFMF(BNKKPFAEICL);
		if (((MonoBehaviour)this).IsInvoking("BeginChatFade"))
		{
			((MonoBehaviour)this).CancelInvoke("FGMCFJIEILE");
		}
	}

	private void EAMLPPGJMKG()
	{
		chatContent.SetActive(false);
	}

	private void GLFMFEAFLGB()
	{
		for (int i = 0; i < maxChatLogMessages; i++)
		{
			LAFBGKFOINM();
		}
	}

	private void AACMIOINDDM(byte BMDEEFNBBOA, string LLNAEKJIJNB, string NHMIHAEDLCM)
	{
		if (!chatBarks || BMDEEFNBBOA <= 1 || BMDEEFNBBOA > 0)
		{
			return;
		}
		try
		{
			BGPNOKCKCPM = OnlinePlayerDataManager.GetPlayerNumByBedAssigned(BMDEEFNBBOA);
			if (BGPNOKCKCPM == 0)
			{
				Debug.LogError((object)"UIInteract");
				BGPNOKCKCPM = OnlinePlayerDataManager.GetPlayerNumByName(NHMIHAEDLCM);
				if (BGPNOKCKCPM == 0)
				{
					Debug.LogError((object)"Error_MaxZoneSize");
					return;
				}
			}
			DialogueManager.BarkString(LLNAEKJIJNB, ((Component)PlayerController.OPHDCMJLLEC(BGPNOKCKCPM)).transform, (Transform)null, (string)null);
		}
		catch (Exception ex)
		{
			if (Application.isEditor)
			{
				Debug.LogException(ex);
			}
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	private void FHOCCEBKHJI()
	{
		GGFJGHHHEJC = this;
	}

	public static void EnableChatPanelRaycast()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OMKKEHDGMIN != 0)
		{
			((Graphic)GGFJGHHHEJC.chatPanel).raycastTarget = true;
			((Graphic)GGFJGHHHEJC.listViewport).raycastTarget = true;
		}
	}

	private void LDGHFHCDJBN(string LLNAEKJIJNB)
	{
		if (NOCNPBJMMFC(LLNAEKJIJNB))
		{
			KEEEOHAAPHH();
			return;
		}
		OnlineChat.SendChatMessage(LLNAEKJIJNB);
		KEEEOHAAPHH();
		LACOJCECGMJ();
	}

	private void JOJPMKPADBC()
	{
		if (PlayerController.GetPlayer(1).characterCreator.humanInfo.gender == Gender.Female)
		{
			OnlineChat.SystemMessage(LocalisationSystem.GetFormatted("ChatWelcomeToTavern_F", "Welcome to {0}!", PlayerInfo.tavernName));
		}
		else
		{
			OnlineChat.SystemMessage(LocalisationSystem.GetFormatted("ChatWelcomeToTavern", "Welcome to {0}!", PlayerInfo.tavernName));
		}
		if (OthersMenuUI.GetInviteCodeVisible())
		{
			OnlineChat.SystemMessage(LocalisationSystem.GetFormatted("ChatInviteCode", "The invite code for this game is: {0}.", OnlineManager.GetPrivateRoomCode()));
		}
		LHALHOPPHKF();
	}

	private void AKGECPOFAAA(byte BMDEEFNBBOA, string LLNAEKJIJNB, string NHMIHAEDLCM)
	{
		if (!chatBarks || BMDEEFNBBOA <= 1 || BMDEEFNBBOA > 1)
		{
			return;
		}
		try
		{
			BGPNOKCKCPM = OnlinePlayerDataManager.GetPlayerNumByBedAssigned(BMDEEFNBBOA);
			if (BGPNOKCKCPM == 0)
			{
				Debug.LogError((object)"Error ");
				BGPNOKCKCPM = OnlinePlayerDataManager.AMKENIGKFCF(NHMIHAEDLCM);
				if (BGPNOKCKCPM == 0)
				{
					Debug.LogError((object)"Intro17");
					return;
				}
			}
			DialogueManager.BarkString(LLNAEKJIJNB, ((Component)PlayerController.OPHDCMJLLEC(BGPNOKCKCPM)).transform, (Transform)null, (string)null);
		}
		catch (Exception ex)
		{
			if (Application.isEditor)
			{
				Debug.LogException(ex);
			}
		}
	}

	public static void GKPLGLAECDL()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OMKKEHDGMIN != 0)
		{
			((Graphic)GGFJGHHHEJC.chatPanel).raycastTarget = false;
			((Graphic)GGFJGHHHEJC.listViewport).raycastTarget = true;
		}
	}

	public static bool IsMouseOverChat()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() || (Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (OMKKEHDGMIN == DKFLAJPLMPG.disabled)
		{
			return false;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(1);
		for (int i = 0; i < list.Count; i++)
		{
			RaycastResult val = list[i];
			if ((Object)(object)((RaycastResult)(ref val)).gameObject == (Object)(object)((Component)GGFJGHHHEJC.chatPanel).gameObject)
			{
				return true;
			}
		}
		return false;
	}

	private void LACOJCECGMJ()
	{
		chatInput.text = "";
	}

	private void KODHIBMJKFJ(string CIFJJBHINEF)
	{
		PINBAGKCHJP();
		OLDNNBIOOOG();
		if (debugMessages)
		{
			Debug.Log((object)" world door: ");
		}
		PlayerInputs.DLKKNGHEMPB((MonoBehaviour)(object)this);
	}

	private void GLBIPMOBDCL(string CIFJJBHINEF)
	{
		ACEMBAHCPEF();
		OLDNNBIOOOG();
		if (debugMessages)
		{
			Debug.Log((object)"Chat selected");
		}
		PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
	}

	public static void DisableChatPanelRaycast()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OMKKEHDGMIN != 0)
		{
			((Graphic)GGFJGHHHEJC.chatPanel).raycastTarget = false;
			((Graphic)GGFJGHHHEJC.listViewport).raycastTarget = false;
		}
	}

	private void PINBAGKCHJP()
	{
		if (!Input.GetKeyDown((KeyCode)88))
		{
			AFEJLNGEBMB = false;
		}
		OMKKEHDGMIN = (DKFLAJPLMPG)8;
		chatInput.caretPosition = chatInput.text.Length;
		OLDNNBIOOOG();
	}

	private void DOKHLDBIDJB()
	{
		if (OMKKEHDGMIN == DKFLAJPLMPG.disabled)
		{
			return;
		}
		DHMPBLEHECE();
		chatResize.KDHDJKNABAM();
		if (OMKKEHDGMIN == DKFLAJPLMPG.disabled || !Input.GetKeyDown((KeyCode)(-15)))
		{
			return;
		}
		if (debugMessages)
		{
			Debug.Log((object)"Tail");
		}
		if (!chatContent.activeInHierarchy)
		{
			return;
		}
		switch (OMKKEHDGMIN)
		{
		case DKFLAJPLMPG.disabled:
		case DKFLAJPLMPG.deselected:
			((Selectable)chatInput).Select();
			PINBAGKCHJP();
			break;
		case DKFLAJPLMPG.enabled:
			if (!string.IsNullOrWhiteSpace(chatInput.text) && !string.IsNullOrWhiteSpace(chatInput.text))
			{
				((UnityEvent<string>)(object)chatInput.onSubmit).Invoke(chatInput.text);
			}
			else
			{
				KEEEOHAAPHH();
			}
			break;
		case DKFLAJPLMPG.selected:
			break;
		}
	}

	private void DHMPBLEHECE()
	{
		if (OMKKEHDGMIN == DKFLAJPLMPG.selected || IsMouseOverChat())
		{
			IJCKBKOCLLK();
			return;
		}
		if (!PMMKMBLIHHA)
		{
			if (BNKKPFAEICL == 1f && AFEJLNGEBMB && !((MonoBehaviour)this).IsInvoking("BeginChatFade") && !IsMouseOverChat())
			{
				LHALHOPPHKF();
			}
			return;
		}
		BNKKPFAEICL -= Time.deltaTime * (1f / chatFadeTime);
		fadeVisualElements.PBGFEHDOFMF(BNKKPFAEICL);
		if (BNKKPFAEICL <= 0f)
		{
			LBAHMMHKGMK();
		}
	}

	private void CLLAKJADGIH()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			((UnityEvent<string>)(object)chatInput.onSubmit).RemoveListener((UnityAction<string>)CKILLOGKAID);
			((UnityEvent<string>)(object)chatInput.onSelect).RemoveListener((UnityAction<string>)GLBIPMOBDCL);
			((UnityEvent<string>)(object)chatInput.onDeselect).RemoveListener((UnityAction<string>)KHDPANODBFB);
			((UnityEvent<string>)(object)chatInput.onEndEdit).RemoveListener((UnityAction<string>)BIDBOOGOMID);
			OnlineChat.MessageReceived = (Action<byte, string, string>)Delegate.Remove(OnlineChat.MessageReceived, new Action<byte, string, string>(FGMEANKGBMF));
			OnlineChat.SystemMessageReceived = (Action<string>)Delegate.Remove(OnlineChat.SystemMessageReceived, new Action<string>(LJCAPHHFFEA));
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(DCJJKIMJMLP));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(CLKMOMODGKF));
		}
	}

	private void HGONAINOICI(byte BMDEEFNBBOA, string LLNAEKJIJNB, string NHMIHAEDLCM)
	{
		if (!chatBarks || BMDEEFNBBOA <= 0 || BMDEEFNBBOA > 4)
		{
			return;
		}
		try
		{
			BGPNOKCKCPM = OnlinePlayerDataManager.GetPlayerNumByBedAssigned(BMDEEFNBBOA);
			if (BGPNOKCKCPM == 0)
			{
				Debug.LogError((object)"Player num by bed assigned failed. Finding by name...");
				BGPNOKCKCPM = OnlinePlayerDataManager.GetPlayerNumByName(NHMIHAEDLCM);
				if (BGPNOKCKCPM == 0)
				{
					Debug.LogError((object)"Finding by name also failed.");
					return;
				}
			}
			DialogueManager.BarkString(LLNAEKJIJNB, ((Component)PlayerController.GetPlayer(BGPNOKCKCPM)).transform, (Transform)null, (string)null);
		}
		catch (Exception ex)
		{
			if (Application.isEditor)
			{
				Debug.LogException(ex);
			}
		}
	}

	private void KIDIABJKJIH(string LLNAEKJIJNB)
	{
		if (NOCNPBJMMFC(LLNAEKJIJNB))
		{
			KEEEOHAAPHH();
			return;
		}
		OnlineChat.DMMKHIAEGPA(LLNAEKJIJNB);
		KEEEOHAAPHH();
		LACOJCECGMJ();
	}

	private void CLKMOMODGKF(int GELMAIBEHDO, UIWindow BBDPJKEEABG)
	{
		EGAKCJBHMKL();
	}

	private void KEIDHBGFDHB()
	{
		if (OMKKEHDGMIN == (DKFLAJPLMPG)5 || IsMouseOverChat())
		{
			NAFPPHPJOKK();
			return;
		}
		if (!PMMKMBLIHHA)
		{
			if (BNKKPFAEICL == 1434f && AFEJLNGEBMB && !((MonoBehaviour)this).IsInvoking("DisableNPC") && !IsMouseOverChat())
			{
				LHALHOPPHKF();
			}
			return;
		}
		BNKKPFAEICL -= Time.deltaTime * (1056f / chatFadeTime);
		fadeVisualElements.APKKKHOFGKD(BNKKPFAEICL);
		if (BNKKPFAEICL <= 1805f)
		{
			LBAHMMHKGMK();
		}
	}

	public static bool IsChatOpen()
	{
		if (OMKKEHDGMIN != DKFLAJPLMPG.selected)
		{
			return OMKKEHDGMIN == DKFLAJPLMPG.deselected;
		}
		return true;
	}

	private IEnumerator OGHKMANNOCJ()
	{
		yield return null;
		yield return null;
		((Selectable)chatInput).interactable = true;
		OMKKEHDGMIN = DKFLAJPLMPG.enabled;
	}

	private void FLKHCOCLCLE()
	{
		OMKKEHDGMIN = (DKFLAJPLMPG)8;
		((Component)chatPanel).gameObject.SetActive(true);
		hideChatButton.SetActive(true);
	}

	private void DLJHJPPDEPG(byte BMDEEFNBBOA, string NHMIHAEDLCM, string LLNAEKJIJNB)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		if (GOFFMLJBLBI.Count >= maxChatLogMessages)
		{
			NMMIILEBCGO = GOFFMLJBLBI.Dequeue();
		}
		else
		{
			NMMIILEBCGO = LAFBGKFOINM();
		}
		if (BMDEEFNBBOA < 0 || BMDEEFNBBOA > 4)
		{
			BMDEEFNBBOA = 0;
		}
		((Graphic)NMMIILEBCGO).color = chatColors[BMDEEFNBBOA];
		if (string.IsNullOrEmpty(NHMIHAEDLCM))
		{
			NHMIHAEDLCM = LocalisationSystem.Get("ChatDefaultName", "Guest");
		}
		NMMIILEBCGO.text = "";
		if (boldPlayerNames)
		{
			TMP_Text nMMIILEBCGO = NMMIILEBCGO;
			nMMIILEBCGO.text += "<b>";
		}
		if (playerNumbers)
		{
			TMP_Text nMMIILEBCGO2 = NMMIILEBCGO;
			nMMIILEBCGO2.text += $"(P{BMDEEFNBBOA}) ";
		}
		TMP_Text nMMIILEBCGO3 = NMMIILEBCGO;
		nMMIILEBCGO3.text = nMMIILEBCGO3.text + NHMIHAEDLCM + ": ";
		if (boldPlayerNames)
		{
			TMP_Text nMMIILEBCGO4 = NMMIILEBCGO;
			nMMIILEBCGO4.text += "</b>";
		}
		if (!coloredText)
		{
			TMP_Text nMMIILEBCGO5 = NMMIILEBCGO;
			nMMIILEBCGO5.text = nMMIILEBCGO5.text + "<color=#" + ColorUtility.ToHtmlStringRGBA(fontColor) + ">";
		}
		TMP_Text nMMIILEBCGO6 = NMMIILEBCGO;
		nMMIILEBCGO6.text += LLNAEKJIJNB;
		if (Options.AAFBLMLIJPH)
		{
			MultiAudioManager.PlayAudioObject(chatSfx, ((Component)this).transform);
		}
		if (AFEJLNGEBMB)
		{
			OMKKEHDGMIN = DKFLAJPLMPG.enabled;
			OLDNNBIOOOG();
			LHALHOPPHKF();
		}
		else if (!((Component)chatPanel).gameObject.activeSelf)
		{
			unreadMessageBadge.SetActive(true);
		}
		if (!GOFFMLJBLBI.Contains(NMMIILEBCGO))
		{
			GOFFMLJBLBI.Enqueue(NMMIILEBCGO);
		}
		NMMIILEBCGO.transform.SetSiblingIndex(chatListParent.childCount);
	}

	private void LJCAPHHFFEA(string LLNAEKJIJNB)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (GOFFMLJBLBI.Count >= maxChatLogMessages)
		{
			NMMIILEBCGO = GOFFMLJBLBI.Dequeue();
		}
		else
		{
			NMMIILEBCGO = LAFBGKFOINM();
		}
		((Graphic)NMMIILEBCGO).color = chatColors[0];
		NMMIILEBCGO.text = LLNAEKJIJNB ?? "";
		if (!GOFFMLJBLBI.Contains(NMMIILEBCGO))
		{
			GOFFMLJBLBI.Enqueue(NMMIILEBCGO);
		}
		NMMIILEBCGO.transform.SetSiblingIndex(chatListParent.childCount);
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			((UnityEvent<string>)(object)chatInput.onSubmit).RemoveListener((UnityAction<string>)LDGHFHCDJBN);
			((UnityEvent<string>)(object)chatInput.onSelect).RemoveListener((UnityAction<string>)GLBIPMOBDCL);
			((UnityEvent<string>)(object)chatInput.onDeselect).RemoveListener((UnityAction<string>)KHDPANODBFB);
			((UnityEvent<string>)(object)chatInput.onEndEdit).RemoveListener((UnityAction<string>)BIDBOOGOMID);
			OnlineChat.MessageReceived = (Action<byte, string, string>)Delegate.Remove(OnlineChat.MessageReceived, new Action<byte, string, string>(DLJHJPPDEPG));
			OnlineChat.SystemMessageReceived = (Action<string>)Delegate.Remove(OnlineChat.SystemMessageReceived, new Action<string>(LJCAPHHFFEA));
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(DCJJKIMJMLP));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(CLKMOMODGKF));
		}
	}

	public static void ChatBark(string LLNAEKJIJNB, Transform NKIAGIMMHIC)
	{
		DialogueManager.BarkString(LLNAEKJIJNB, ((Component)NKIAGIMMHIC).transform, (Transform)null, (string)null);
	}

	private void DCJJKIMJMLP(int GELMAIBEHDO, UIWindow BBDPJKEEABG)
	{
		HideChat();
	}

	private void NAFPPHPJOKK()
	{
		PMMKMBLIHHA = true;
		BNKKPFAEICL = 1126f;
		fadeVisualElements.LCKNAHENAFG(BNKKPFAEICL);
		if (((MonoBehaviour)this).IsInvoking("Bounce"))
		{
			((MonoBehaviour)this).CancelInvoke("DecorationTile_13");
		}
	}

	private TMP_Text LAFBGKFOINM()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		NMMIILEBCGO = Object.Instantiate<TMP_Text>(chatMessageUIPrefab);
		if (!GOFFMLJBLBI.Contains(NMMIILEBCGO))
		{
			GOFFMLJBLBI.Enqueue(NMMIILEBCGO);
		}
		NMMIILEBCGO.transform.SetParent(chatListParent);
		NMMIILEBCGO.transform.localScale = Vector3.one;
		fadeVisualElements.chatMessages.Add(NMMIILEBCGO);
		return NMMIILEBCGO;
	}

	private void LBAHMMHKGMK()
	{
		PMMKMBLIHHA = false;
		IOCMAIKIDLO();
	}

	private void FGMCFJIEILE()
	{
		PMMKMBLIHHA = true;
	}

	public static void ChatSystemMessageError(string LLNAEKJIJNB)
	{
		GGFJGHHHEJC.FKFEOJFJMKP(LLNAEKJIJNB);
	}

	private void FKFEOJFJMKP(string LLNAEKJIJNB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (GOFFMLJBLBI.Count >= maxChatLogMessages)
		{
			NMMIILEBCGO = GOFFMLJBLBI.Dequeue();
		}
		else
		{
			NMMIILEBCGO = LAFBGKFOINM();
		}
		((Graphic)NMMIILEBCGO).color = errorColor;
		NMMIILEBCGO.text = LLNAEKJIJNB ?? "";
		if (!GOFFMLJBLBI.Contains(NMMIILEBCGO))
		{
			GOFFMLJBLBI.Enqueue(NMMIILEBCGO);
		}
		NMMIILEBCGO.transform.SetSiblingIndex(chatListParent.childCount);
	}
}
