using RMS.Api.Core.Models;

namespace RMS.Api.Core.Contracts
{
	public interface ISectionRepository
	{
		public List<Section> GetAllSections();
		public Section GetSectionById(int id);
		public bool AddSection(Section record);
		public bool UpdateSection(int id, Section record);
		public bool RemoveSection(int id);
	}
}
