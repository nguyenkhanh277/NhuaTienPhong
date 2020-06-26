using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.Persistence.Repositories
{
    public class OrderRepository : Repository<Order>
    {
        public string id = "";

        public OrderRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Order order)
        {
            if (String.IsNullOrEmpty(order.Id))
            {
                string seq = GetAutoID(order.OrderDate);
                order.Id = "PO" + order.OrderDate.ToString("ddMMyyyy") + seq;
                order.SEQ = seq;
                order.Status = GlobalConstants.StatusValue.Using;
                order.CreatedAt = DateTime.Now;
                order.CreatedBy = GlobalConstants.username;
                Add(order);
                id = order.Id;
            }
            else
            {
                Update(order);
            }
        }

        public void Update(Order order)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(order.Id));
                if (raw != null)
                {
                    raw.CollectInformation(order);
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

        public string GetAutoID(DateTime dateTime)
        {
            string result = "1";
            try
            {
                var order = Find(_ => _.OrderDate.Year.Equals(dateTime.Year) && _.OrderDate.Month.Equals(dateTime.Month) && _.OrderDate.Day.Equals(dateTime.Day));
                if (order != null)
                {
                    result = order.Max(_ => _.SEQ);
                    result = (result == null ? "1" : result);
                }
            }
            catch { }
            return int.Parse(result).ToString("0000");
        }
    }
}