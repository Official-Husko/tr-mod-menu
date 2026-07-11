using System;
using UnityEngine;

public class SOEncyclopedia : ScriptableObject
{
	[Serializable]
	public struct EncyclopediaSection
	{
		public string sectionTitle;

		public string sectionTitleID;

		public EncyclopediaSubSection[] subSections;
	}

	[Serializable]
	public struct EncyclopediaSubSection
	{
		public string subSectionTitle;

		public string subSectionTitleID;

		[TextArea(3, 10)]
		public string subSectionText;

		public string subSectionTextID;
	}

	public EncyclopediaSection[] sections;
}
