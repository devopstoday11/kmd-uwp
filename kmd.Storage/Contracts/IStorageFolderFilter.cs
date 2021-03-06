﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Windows.Storage;

namespace kmd.Storage.Contracts
{
    public interface IStorageFolderFilter
    {
        Task<IEnumerable<IStorageItem2>> FilterAsync(IStorageFolder folder, FilterOptions options, CancellationToken cancellationToken = default(CancellationToken));
    }

    public class FilterOptions
    {
        public string QueryText { get; set; }
    }
}