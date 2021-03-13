namespace TrackerLibrary
{
	public class MatchupEntryModel
	{
		public TeamModel TeamCompeting { get; set; }
		public double score { get; set; }
		public MatchupModel ParentMatchup { get; set; }
	}
}