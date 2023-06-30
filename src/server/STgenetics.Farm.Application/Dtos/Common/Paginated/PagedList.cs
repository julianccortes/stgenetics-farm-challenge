using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STgenetics.Farm.Application.Dtos.Common.Paginated
{
    public class PagedList<T> : List<T>
    {
        public PagedMetadata MetaData { get; set; }

        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            MetaData = new PagedMetadata
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };

            AddRange(items);
        }

        public static PagedList<T> ToPagedList(List<T> source, int totalCount, int pageNumber, int pageSize)
        {  
            return new PagedList<T>(source, totalCount, pageNumber, pageSize);
        }
    }
}
