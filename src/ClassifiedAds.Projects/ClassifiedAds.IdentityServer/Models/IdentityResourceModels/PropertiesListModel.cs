﻿using IdentityServer4.EntityFramework.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ClassifiedAds.IdentityServer.Models.IdentityResourceModels
{
    public class PropertiesListModel
    {
        public int IdentityResourceId { get; set; }
        public string IdentityResourceName { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public List<IdentityResourcePropertyModel> Properties { get; set; }

        public static PropertiesListModel FromEntity(IdentityResource identityResource)
        {
            return new PropertiesListModel
            {
                IdentityResourceId = identityResource.Id,
                IdentityResourceName = identityResource.Name,
                Properties = identityResource.Properties?.Select(x => new IdentityResourcePropertyModel
                {
                    Id = x.Id,
                    Key = x.Key,
                    Value = x.Value,
                })?.ToList(),
            };
        }
    }
}
