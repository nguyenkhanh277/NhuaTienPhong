using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.Persistence.Repositories
{
    public class CarRepository : Repository<Car>
    {
        public string id = "";

        public CarRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Car car)
        {
            if (String.IsNullOrEmpty(car.Id))
            {
                car.Id = GetAutoID();
                car.CreatedAt = DateTime.Now;
                car.CreatedBy = GlobalConstants.username;
                Add(car);
                id = car.Id;
            }
            else
            {
                Update(car);
            }
        }

        public void Update(Car car)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(car.Id));
                if (raw != null)
                {
                    raw.CollectInformation(car);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                    id = raw.Id;
                }
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}