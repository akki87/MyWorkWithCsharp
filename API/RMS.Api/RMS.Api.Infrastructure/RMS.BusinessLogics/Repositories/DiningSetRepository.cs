using RMS.Api.Core.Contracts;
using RMS.Api.Core.Models;
using RMS.Api.Infrastructure.Data.Context;

namespace RMS.Api.Infrastructure.Repositories
{
	public class DiningSetRepository : IDiningSetRepository
	{
        private readonly RMSContext _context;

        public DiningSetRepository(RMSContext context)
        {
            _context = context;
        }
        public List<DiningSet> GetAllDiningSet()
		{
			return _context.DiningSets.ToList();
		}
		public DiningSet GetDiningSetById(int id)
		{

			return _context.DiningSets.Find(id);
		}
		public bool AddDiningSet(DiningSet record)
		{
			DiningSet diningSet = new DiningSet()
			{
				DiningSetId=record.DiningSetId,
				ChairCount=record.ChairCount,
				Status=record.Status,
				SectionId=record.SectionId,
			};
			_context.DiningSets.Add(record);
			_context.SaveChanges();
			return true;
		}
		public bool UpdateDiningSet(int id, DiningSet record)
		{
			DiningSet recordToUpdate = _context.DiningSets.Find(id);
			if (recordToUpdate != null)
				return false;
			recordToUpdate.DiningSetId=record.DiningSetId;
			recordToUpdate.ChairCount=record.ChairCount;
			recordToUpdate.Status=record.Status;
			recordToUpdate.SectionId=record.SectionId;
			_context.DiningSets.Update(recordToUpdate);
			_context.SaveChanges();
			return true;
		}
		public bool DeleteDiningSet(int id)
		{
			var diningset = _context.DiningSets.Find(id);
			_context.DiningSets.Remove(diningset);
			_context.SaveChanges();
			return true;
		}
	}
}
