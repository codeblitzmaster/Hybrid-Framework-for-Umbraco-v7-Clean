//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Zbu.ModelsBuilder v2.0.0.26
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Zbu.ModelsBuilder;
using Zbu.ModelsBuilder.Umbraco;

namespace Umbraco.Extensions.Models.Generated
{
	/// <summary>Website</summary>
	[PublishedContentModel("Website")]
	public partial class Website : Data
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Website";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Website(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Website, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}


		/// <summary>Site name</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}

		/// <summary>Internal redirect</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return this.GetPropertyValue<IPublishedContent>("umbracoInternalRedirectId"); }
		}
	}
}
