using System.Collections.Generic;
using System.Text;

namespace psai.net;

public class Theme
{
	public int id;

	public string Name;

	public ThemeType themeType;

	public int priority;

	public int restSecondsMax;

	public int restSecondsMin;

	public List<Segment> m_segments;

	public float intensityAfterRest;

	public int musicDurationGeneral;

	public int musicDurationAfterRest;

	public Weighting weightings;

	public static bool ThemeInterruptionBehaviorRequiresEvaluationOfSegmentCompatibilities(ThemeInterruptionBehavior interruptionBehavior)
	{
		if (interruptionBehavior != ThemeInterruptionBehavior.immediately && interruptionBehavior != ThemeInterruptionBehavior.at_end_of_current_snippet && interruptionBehavior != ThemeInterruptionBehavior.layer)
		{
			return interruptionBehavior == ThemeInterruptionBehavior.never;
		}
		return true;
	}

	public static string ThemeTypeToString(ThemeType themeType)
	{
		return themeType switch
		{
			ThemeType.basicMood => "Basic Mood", 
			ThemeType.basicMoodAlt => "Mood Alteration", 
			ThemeType.dramaticEvent => "Dramatic Event", 
			ThemeType.action => "Action", 
			ThemeType.shock => "Shock", 
			ThemeType.highlightLayer => "Highlight Layer", 
			_ => "", 
		};
	}

	public static ThemeInterruptionBehavior GetThemeInterruptionBehavior(ThemeType sourceThemeType, ThemeType targetThemeType)
	{
		switch (sourceThemeType)
		{
		case ThemeType.basicMood:
			switch (targetThemeType)
			{
			case ThemeType.basicMood:
				return ThemeInterruptionBehavior.at_end_of_current_snippet;
			case ThemeType.basicMoodAlt:
				return ThemeInterruptionBehavior.at_end_of_current_snippet;
			case ThemeType.dramaticEvent:
				return ThemeInterruptionBehavior.immediately;
			case ThemeType.action:
				return ThemeInterruptionBehavior.immediately;
			case ThemeType.shock:
				return ThemeInterruptionBehavior.immediately;
			case ThemeType.highlightLayer:
				return ThemeInterruptionBehavior.layer;
			}
			break;
		case ThemeType.basicMoodAlt:
			switch (targetThemeType)
			{
			case ThemeType.basicMood:
				return ThemeInterruptionBehavior.never;
			case ThemeType.basicMoodAlt:
				return ThemeInterruptionBehavior.at_end_of_current_snippet;
			case ThemeType.dramaticEvent:
				return ThemeInterruptionBehavior.immediately;
			case ThemeType.action:
				return ThemeInterruptionBehavior.immediately;
			case ThemeType.shock:
				return ThemeInterruptionBehavior.immediately;
			case ThemeType.highlightLayer:
				return ThemeInterruptionBehavior.layer;
			}
			break;
		case ThemeType.dramaticEvent:
			switch (targetThemeType)
			{
			case ThemeType.basicMood:
				return ThemeInterruptionBehavior.never;
			case ThemeType.basicMoodAlt:
				return ThemeInterruptionBehavior.never;
			case ThemeType.dramaticEvent:
				return ThemeInterruptionBehavior.at_end_of_current_snippet;
			case ThemeType.action:
				return ThemeInterruptionBehavior.immediately;
			case ThemeType.shock:
				return ThemeInterruptionBehavior.immediately;
			case ThemeType.highlightLayer:
				return ThemeInterruptionBehavior.layer;
			}
			break;
		case ThemeType.action:
			switch (targetThemeType)
			{
			case ThemeType.basicMood:
				return ThemeInterruptionBehavior.never;
			case ThemeType.basicMoodAlt:
				return ThemeInterruptionBehavior.never;
			case ThemeType.dramaticEvent:
				return ThemeInterruptionBehavior.never;
			case ThemeType.action:
				return ThemeInterruptionBehavior.at_end_of_current_snippet;
			case ThemeType.shock:
				return ThemeInterruptionBehavior.immediately;
			case ThemeType.highlightLayer:
				return ThemeInterruptionBehavior.layer;
			}
			break;
		case ThemeType.shock:
			switch (targetThemeType)
			{
			case ThemeType.basicMood:
				return ThemeInterruptionBehavior.never;
			case ThemeType.basicMoodAlt:
				return ThemeInterruptionBehavior.never;
			case ThemeType.dramaticEvent:
				return ThemeInterruptionBehavior.never;
			case ThemeType.action:
				return ThemeInterruptionBehavior.never;
			case ThemeType.shock:
				return ThemeInterruptionBehavior.immediately;
			case ThemeType.highlightLayer:
				return ThemeInterruptionBehavior.layer;
			}
			break;
		case ThemeType.highlightLayer:
			return ThemeInterruptionBehavior.never;
		}
		return ThemeInterruptionBehavior.undefined;
	}

	public Theme()
	{
		m_segments = new List<Segment>();
		weightings = new Weighting();
		id = -1;
		restSecondsMax = 0;
		restSecondsMin = 0;
		priority = 0;
		themeType = ThemeType.none;
		Name = "";
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Name);
		stringBuilder.Append(" (");
		stringBuilder.Append(id);
		stringBuilder.Append(")");
		stringBuilder.Append(" [");
		stringBuilder.Append(themeType);
		stringBuilder.Append("]");
		return stringBuilder.ToString();
	}

	internal void BuildSequencesToEndSegmentForAllSnippets()
	{
		foreach (Segment segment in m_segments)
		{
			segment.nextSnippetToShortestEndSequence = null;
		}
		List<Segment> list = new List<Segment>();
		foreach (Segment segment2 in m_segments)
		{
			if ((segment2.SnippetTypeBitfield & 4) > 0)
			{
				list.Add(segment2);
			}
		}
		SetTheNextSnippetToShortestEndSequenceForAllSourceSnippetsOfTheSnippetsInThisList(list.ToArray());
		if (LogLevel.debug > Logger.Instance.LogLevel)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("BuildSequencesToEndSnippetForAllSnippets completed for Theme ");
		stringBuilder.Append(Name);
		stringBuilder.Append("\n");
		foreach (Segment segment3 in m_segments)
		{
			stringBuilder.Append(segment3.Name);
			stringBuilder.Append(" -> ");
			if (segment3.nextSnippetToShortestEndSequence == null)
			{
				stringBuilder.Append(" null");
			}
			else
			{
				stringBuilder.Append(segment3.nextSnippetToShortestEndSequence.Name);
			}
			stringBuilder.Append("\n");
		}
		Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
	}

	private void SetTheNextSnippetToShortestEndSequenceForAllSourceSnippetsOfTheSnippetsInThisList(Segment[] listOfSnippetsWithValidEndSequences)
	{
		Dictionary<Segment, List<Segment>> dictionary = new Dictionary<Segment, List<Segment>>();
		foreach (Segment segment in listOfSnippetsWithValidEndSequences)
		{
			foreach (Segment item in GetSetOfAllSourceSegmentsCompatibleToSegment(segment, Logik.COMPATIBILITY_PERCENTAGE_SAME_GROUP, SegmentSuitability.end))
			{
				if (item.nextSnippetToShortestEndSequence == null && item.ThemeId == segment.ThemeId)
				{
					if (!dictionary.ContainsKey(item))
					{
						dictionary[item] = new List<Segment>();
					}
					dictionary[item].Add(segment);
				}
			}
		}
		foreach (Segment key in dictionary.Keys)
		{
			key.nextSnippetToShortestEndSequence = key.ReturnSegmentWithLowestIntensityDifference(dictionary[key]);
		}
		Segment[] array = new Segment[dictionary.Count];
		dictionary.Keys.CopyTo(array, 0);
		if (array.Length != 0)
		{
			SetTheNextSnippetToShortestEndSequenceForAllSourceSnippetsOfTheSnippetsInThisList(array);
		}
	}

	internal void BuildSequencesToTargetThemeForAllSegments(Soundtrack soundtrack, Theme targetTheme)
	{
		foreach (Segment segment in m_segments)
		{
			segment.MapOfNextTransitionSegmentToTheme.Remove(targetTheme.id);
		}
		List<Segment> list = new List<Segment>();
		foreach (Segment segment2 in m_segments)
		{
			if (segment2.CheckIfAtLeastOneDirectTransitionOrLayeringIsPossible(soundtrack, targetTheme.id))
			{
				list.Add(segment2);
			}
		}
		SetTheNextSegmentToShortestTransitionSequenceToTargetThemeForAllSourceSegmentsOfTheSegmentsInThisList(list.ToArray(), soundtrack, targetTheme);
		if (LogLevel.debug > Logger.Instance.LogLevel)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("BuildSequencesToTargetThemeForAllSegments completed for Theme ");
		stringBuilder.Append(this);
		stringBuilder.Append(" to Theme ");
		stringBuilder.Append(targetTheme);
		stringBuilder.Append("\n");
		foreach (Segment segment3 in m_segments)
		{
			stringBuilder.Append(segment3);
			stringBuilder.Append(" -> ");
			if (!segment3.MapOfNextTransitionSegmentToTheme.ContainsKey(targetTheme.id))
			{
				stringBuilder.Append(" DirectTransition:");
				stringBuilder.Append(segment3.CheckIfAtLeastOneDirectTransitionOrLayeringIsPossible(soundtrack, targetTheme.id));
			}
			else
			{
				stringBuilder.Append(segment3.MapOfNextTransitionSegmentToTheme[targetTheme.id].ToString());
			}
			stringBuilder.Append("\n");
		}
		Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
	}

	private List<Segment> GetSetOfAllSourceSegmentsCompatibleToSegment(Segment targetSnippet, float minCompatibilityThreshold, SegmentSuitability doNotIncludeSegmentsWithThisSuitability)
	{
		List<Segment> list = new List<Segment>();
		foreach (Segment segment in m_segments)
		{
			if (segment.IsUsableAs(doNotIncludeSegmentsWithThisSuitability))
			{
				continue;
			}
			foreach (Follower follower in segment.Followers)
			{
				if (follower.snippetId == targetSnippet.Id && follower.compatibility >= minCompatibilityThreshold)
				{
					list.Add(segment);
				}
			}
		}
		return list;
	}

	private void SetTheNextSegmentToShortestTransitionSequenceToTargetThemeForAllSourceSegmentsOfTheSegmentsInThisList(Segment[] listOfSnippetsWithValidTransitionSequencesToTargetTheme, Soundtrack soundtrack, Theme targetTheme)
	{
		Dictionary<Segment, List<Segment>> dictionary = new Dictionary<Segment, List<Segment>>();
		foreach (Segment segment in listOfSnippetsWithValidTransitionSequencesToTargetTheme)
		{
			List<Segment> setOfAllSourceSegmentsCompatibleToSegment = GetSetOfAllSourceSegmentsCompatibleToSegment(segment, Logik.COMPATIBILITY_PERCENTAGE_SAME_GROUP, SegmentSuitability.none);
			setOfAllSourceSegmentsCompatibleToSegment.Remove(segment);
			foreach (Segment item in setOfAllSourceSegmentsCompatibleToSegment)
			{
				if (!item.MapOfNextTransitionSegmentToTheme.ContainsKey(targetTheme.id) && !item.CheckIfAtLeastOneDirectTransitionOrLayeringIsPossible(soundtrack, targetTheme.id) && item.ThemeId == segment.ThemeId)
				{
					if (!dictionary.ContainsKey(item))
					{
						dictionary[item] = new List<Segment>();
					}
					dictionary[item].Add(segment);
				}
			}
		}
		foreach (Segment key in dictionary.Keys)
		{
			key.MapOfNextTransitionSegmentToTheme[targetTheme.id] = key.ReturnSegmentWithLowestIntensityDifference(dictionary[key]);
		}
		Segment[] array = new Segment[dictionary.Count];
		dictionary.Keys.CopyTo(array, 0);
		if (array.Length != 0)
		{
			SetTheNextSegmentToShortestTransitionSequenceToTargetThemeForAllSourceSegmentsOfTheSegmentsInThisList(array, soundtrack, targetTheme);
		}
	}
}
