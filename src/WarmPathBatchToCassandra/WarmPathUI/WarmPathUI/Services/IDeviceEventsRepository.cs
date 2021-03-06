// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.​
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.​
// ------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using WarmPathUI.Models;

namespace WarmPathUI.Services
{
    public interface IDeviceEventsRepository
    {
        Task<IEnumerable<DeviceEvent>> GetDeviceEventsAsync(double swLon, double swLat, double neLon, double neLat);
    }
}
