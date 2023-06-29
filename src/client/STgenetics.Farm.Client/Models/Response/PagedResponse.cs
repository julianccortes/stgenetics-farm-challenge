using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STgenetics.Farm.Application.Dtos.Common.Paginated
{
    public class PagedResponse<T>: PagedMetadata
    {
        public List<T> Items { get; set; }

        public PagedResponse(List<T> items, int count, int pageNumber, int pageSize)
        {

            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);        
            Items = items;            
        }        
    }
}
