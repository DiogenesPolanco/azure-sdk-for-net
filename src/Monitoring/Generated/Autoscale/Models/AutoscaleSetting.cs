// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.Monitoring.Autoscale.Models;

namespace Microsoft.WindowsAzure.Management.Monitoring.Autoscale.Models
{
    /// <summary>
    /// Autoscale setting.
    /// </summary>
    public partial class AutoscaleSetting
    {
        private bool _enabled;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }
        
        private IList<AutoscaleProfile> _profiles;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<AutoscaleProfile> Profiles
        {
            get
            {
                if (this._profiles == null)
                {
                    this._profiles = new System.Collections.Generic.List<Microsoft.WindowsAzure.Management.Monitoring.Autoscale.Models.AutoscaleProfile>();
                }
                return this._profiles;
            }
            set { this._profiles = value; }
        }
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<AutoscaleProfile> ProfilesValue
        {
            get { return this._profiles; }
            set { this._profiles = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AutoscaleSetting class.
        /// </summary>
        public AutoscaleSetting()
        {
        }
    }
}
