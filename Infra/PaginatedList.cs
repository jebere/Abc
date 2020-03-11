using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    namespace Abc.Infra
    {
        public class PaginatedList<T> : List<T>
        {
            public int PageIndex { get; }
            public int TotalPages { get; }
            public bool HasPreviousPage => PageIndex > 1;
            public bool HasNextPage => PageIndex < TotalPages;

            public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
            {
                PageIndex = pageIndex;
                TotalPages = (int)Math.Ceiling(count / (double)pageSize);

                this.AddRange(items);
            }

            public static async Task<PaginatedList<T>> CreateAsync(
                IQueryable<T> dataSet, int pageIndex, int pageSize)
            {
                var count = await dataSet.CountAsync();
                var items = await dataSet.Skip(
                        (pageIndex - 1) * pageSize)
                    .Take(pageSize).ToListAsync();
                return new PaginatedList<T>(items, count, pageIndex, pageSize);
            }
        }
    }

